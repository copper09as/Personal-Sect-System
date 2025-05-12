using Game.Script.Net;

public partial class MsgHandler
{
    public static void MsgGetSect(ClientState c, MsgBase msgBase)
    {
        MsgGetSect msg = (MsgGetSect)msgBase;
        msg.sects = DbManager.GetSectData();
        foreach(var sect in msg.sects)
        {
            Console.WriteLine(sect.leaderName);
        }
        NetManager.Send(c,msg);
    }
}
