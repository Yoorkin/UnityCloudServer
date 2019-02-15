using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyNetwork
{
    [Serializable]
    class Room : MsgBase
    {
        public static int RoomCount = 0;
        public Room(string name, string password, int maxnumber, string type)
        {
            Index = RoomCount++;
            Name = name;
            Password = password;
            MaxNumber = maxnumber;
            Type = type;
        }
        public int Index;
        public string Name;
        public int MaxNumber;
        public string Type;
        public string Password;
        public ArrayList ClientList = new ArrayList();

    }

    [Serializable]
    class PrivateMsg : MsgBase
    {
        public string Msg;
        public PrivateMsg(string msg)
        {
            Msg = msg;
            base.MsgID = MsgType.PrivateMsg;
        }

    }
    [Serializable]
    class MsgBase
    {
        public int MsgID;
    }
    public class MsgType
    {
        public const short Login = 100;
        public const short PrivateMsg = 101;
        public int CreateRoom = 102;

        public int JoinRoom = 201;
        public int ExitRoom = 202;
        public int Transform = 203;
        public int SceneChange = 204;

    }
}


