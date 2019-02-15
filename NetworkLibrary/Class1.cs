using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;

namespace NetworkLibrary
{  
    [Serializable]
    public class MessageBase
    {
        public short Flag;
        public T Read<T>()
        {
            return (T)Convert.ChangeType(this, typeof(T));
        }
    }

    namespace ServerCommand
    {
        public class ServerMsg
        {
            public const short ServerCommand = 101;
            public const short LobbyInfo = 150;
            public const short RoomInfo = 151;
            public const short AccountInfo = 152;
        }
        [Serializable]
        public class CommandMsg:MessageBase
        {
            public CommandMsg()
            {
                base.Flag = ServerMsg.ServerCommand;
            }
            public Hashtable table = new Hashtable();
           

        }
        //大厅资料(房间资料的集合)
        [Serializable]
        public class LobbyInfo:MessageBase
        {
            public LobbyInfo()
            {
                Flag = ServerMsg.LobbyInfo;
            }
            public ArrayList RoomInfoList = new ArrayList();

        }
        //账户资料
        [Serializable]
        public class AccountInfo:MessageBase
        {
            public AccountInfo()
            {
                Flag = ServerMsg.AccountInfo;
            }
            public int TemID;//临时ID
            public string Name;//名字
        }
        //房间资料
        [Serializable]
        public class RoomInfo:MessageBase
        {
            public RoomInfo()
            {
                Flag = ServerMsg.RoomInfo;
            }
            public int TemID;//临时房间ID
            public AccountInfo AdminInfo;//房主账户资料
            public ArrayList MateInfoList = new ArrayList();//舍友资料列表
            public int MateMaxCount;//房间人数上限
            public bool IsPlaying = false;//是否已开始游戏
            public string Name;//房间名
            public string Password;//房间密码
            public string Tag;//附加资料(游戏模式地图什么的)
        }

    }
}
