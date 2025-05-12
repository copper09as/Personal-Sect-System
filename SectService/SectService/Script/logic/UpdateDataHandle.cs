
using Game.Script.Net;

public partial class MsgHandler
{
    public static void MsgUpdateSect(ClientState c, MsgBase msgBase)
    {
        MsgUpdateSect msg = (MsgUpdateSect)msgBase;
        DbManager.UpdateData(StringResource.UpdateSectDataSql(msg.sect));
        NetManager.Send(c, msg);
    }

}