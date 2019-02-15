using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Collections;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using NetworkLibrary;
using NetworkLibrary.ServerCommand;
using System.Diagnostics;
using System.IO;

namespace UnityCloudServer
{
    public partial class Form1 : Form
    {

        public TcpListener Listener;
        public ArrayList AccountList = new ArrayList();
        public ArrayList RoomList = new ArrayList();

        public Form1()
        {
            InitializeComponent();

        }
        public Socket GetSocket(TcpClient clt)
        {
            Socket s = clt.Client;
            return s;
        }

        public void ClientThread(object Client)
        {
            TcpClient client = (TcpClient)Client;
            t1:
            NetworkStream stream = client.GetStream();//取得新连接的数据流  
            //=====copy来的代码==============
            var memoryStream = new MemoryStream();
            //将基础流写入内存流
            const int bufferLength = 1024;
            byte[] buffer = new byte[bufferLength];
            int actual;
            do
            {
                actual = stream.Read(buffer, 0, buffer.Length);
            }
            while (stream.DataAvailable);
            //int actual = stream.Read(buffer, 0, bufferLength);
            if (actual > 0)
            {
                memoryStream.Write(buffer, 0, actual);

                memoryStream.Position = 0;
                //===============================
                //stream.Position = 0;
                //stream.Seek(0, System.IO.SeekOrigin.Begin);
                AccountInfo info = (AccountInfo)Account.Formatter.Deserialize(memoryStream);//反序列Msg 
                if (info.Name == null) return;
                Account account = new Account(client, info);
                AccountList.Add(account);//加入到账户列表
                StateBox.Items.Add("玩家 " + info.Name + "(TemID " + info.TemID + ")" + "连接了服务器");
                labelOnlineCount.Text = Account.Count.ToString();
                do
                {
                    MessageBase Msg = (MessageBase)Account.Formatter.Deserialize(stream);//反序列Msg 
                    if (Msg.Flag == ServerMsg.ServerCommand) { Command(account, Msg); continue; }//如果是服务指令就不转发
                    Room room = (Room)RoomList[account.RoomInfo.TemID];//取得自己在的房间
                    Debug.Print(Msg.Flag.ToString());
                    Transmit(account, Msg);
                } while (true);
            }
            else
            {
                goto t1;
            }

        }
        public void Transmit(Account account,MessageBase Msg)//转发Msg
        {

                for (int i = 0; i < account.RoomInfo.MateInfoList.Count; i++)
                {
                    AccountInfo RoomMate = (AccountInfo)account.RoomInfo.MateInfoList[i];//取得同一个房间的舍友资料
                    if (RoomMate.TemID == account.Info.TemID) continue;//如果是自己就不发
                    Account Account = (Account)AccountList[RoomMate.TemID];//取得这个舍友的账户
                    NetworkStream ReceiveStream = (NetworkStream)account.Client.GetStream();//取得这个舍友账户的数据流
                    Account.Formatter.Serialize(ReceiveStream, Msg);//发给他
                }    
        }

        public void Command(Account account,MessageBase Msg)//处理服务命令与消息
        {
            /* Command-MsgTable
             * 服务端指令参数对照:
             * 1. string Command = CreateRoom, string RoomName, int MaxMateCount, string Tag;
             * 2. string Command = JoinRoom, int RoomTemID;
             * 3. string Command = LeaveRom;
             * 4. string Command = GetRoomInfo, int RoomTemID;
             * 5. string Command = GetAccountInfo, int AccountTemID;
             * 6. string Command = GetLobbyInfo;
             */
            CommandMsg msg = (CommandMsg)Msg;
            Room room;
            switch(msg.table["Command"].ToString())
            {
                case "CreateRoom"://创建房间
                    room = new Room(account, (string)msg.table["RoomName"], (int)msg.table["MaxMateCount"], (string)msg.table["Tag"]);
                    RoomList.Add(room);
                    account.RoomInfo = room.Info;
                    room.MateList.Add(account);
                    break;
                case "JoinRoom"://加入房间
                    room = (Room)RoomList[(int)msg.table["RoomTemID"]];
                    account.RoomInfo = room.Info;
                    room.MateList.Add(account);
                    break;
                case "LeaveRoom"://离开房间
                    room = (Room)RoomList[account.RoomInfo.TemID];
                    room.MateList.Remove(account);
                    account.RoomInfo = null;
                    break;
                case "GetLobbyInfo"://获取房间集合
                    LobbyInfo lobby = new LobbyInfo();
                    foreach (Room r in RoomList)
                        lobby.RoomInfoList.Add(r.Info);
                    account.Send(lobby);
                    break;
                case "GetRoomInfo"://获取单个房间信息
                    room = (Room)RoomList[(int)msg.table["RoomTemID"]];
                    account.Send(room.Info);
                    break;
                case "GetAccount"://获取账户信息
                    Account a = (Account)AccountList[(int)msg.table["AccountTemID"]];
                    account.Send(a.Info);
                    break;
                
            }
        }
            
        public void Listen()
        {
            do
            {
                TcpClient client = Listener.AcceptTcpClient();//侦听新连接
                Thread TransmitThread = new Thread(new ParameterizedThreadStart(ClientThread));//创建一个线程负责消息转发
                TransmitThread.Start(client);
            } while (true);

        }


  
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 开启服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.开启服务ToolStripMenuItem.Enabled = false;
            this.关闭服务ToolStripMenuItem.Enabled = true;
            FormStartPort startport = new UnityCloudServer.FormStartPort();
            startport.ShowDialog();
            Listener = new TcpListener(IPAddress.Any, Convert.ToInt32(startport.textBox1.Text));
            Listener.Start();

            this.StateBox.Items.Add(DateTime.Now + " 服务端已在" + startport.textBox1.Text + "端口开启");
            Thread thread = new Thread(new ThreadStart(Listen));
            thread.Start();
        }

        private void ListenerTick_Tick(object sender, EventArgs e)
        {

        }

        private void 关闭服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Listener.Stop();
            //foreach (TcpClient client in ClientList)
            //    client.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MsglistView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StateBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Room
    {
        static int Count = 0;//总房间数/房间在RoomList中的索引
        public ArrayList MateList = new ArrayList();
        public RoomInfo Info;
        public Room(Account OwnerAccount,string RoomName,int MaxMateCount,string RoomTag)
        {
            Info = new RoomInfo { TemID = Count++, IsPlaying = false, AdminInfo = OwnerAccount.Info, Name = RoomName, Tag = RoomTag,MateMaxCount=MaxMateCount };
            
        }
        public void Join(Account account)
        {
            if(Info.MateInfoList.Count<Info.MateMaxCount)
            {
                MateList.Add(account);
                Info.MateInfoList.Add(account.Info);
                account.RoomInfo = Info;
            }

        }
        public void Leave(Account account)
        {
            MateList.Remove(account);
            Info.MateInfoList.Remove(account);
            account.RoomInfo = null;
           // if(Info.AdminInfo.TemID == account.Info.TemID) 房主离开房间
        }
    }
    public class Account
    {
        static public BinaryFormatter Formatter = new BinaryFormatter();
        public static int Count = 0;//总账户数目
        public RoomInfo RoomInfo;
        private TcpClient tcpClient;

        public AccountInfo Info;
        public Account(TcpClient client,AccountInfo info)
        {
            tcpClient = client;
            Info = info;
            Info.TemID = ++Count;
        }
        public TcpClient Client { get { return tcpClient; } }
        public void Send( MessageBase Msg)
        {
              Formatter.Serialize(tcpClient.GetStream(), Msg);
        }
    }
}
  
