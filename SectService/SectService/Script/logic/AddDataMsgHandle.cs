using Game.Script.Net;

public partial class MsgHandler
{
    public static void MsgAddSect(ClientState c, MsgBase msgBase)
    {
        MsgAddSect msg = (MsgAddSect)msgBase;
        DbManager.CreateData(StringResource.CreateSectDataSql(msg));
        foreach (var client in NetManager.clients.Values)
        {
            NetManager.Send(client, msg);
            Console.WriteLine(client.socket);
        }
    }
    public static void MsgAddPra(ClientState c, MsgBase msgBase)
    {
        MsgAddPra msg = (MsgAddPra)msgBase;
        DbManager.CreateData(StringResource.CreateParDataSql(msg));
        foreach (var client in NetManager.clients.Values)
        {
            NetManager.Send(client, msg);
            Console.WriteLine(client.socket);
        }
    }
    public static void MsgDel(ClientState c, MsgBase msgBase)
    {
        MsgDel msg = (MsgDel)msgBase;
        DbManager.DeleteData(msg.table, msg.id);
        foreach(var client in NetManager.clients.Values)
        {
            NetManager.Send(client, msg);
            Console.WriteLine(client.socket);
        }
    }
}

