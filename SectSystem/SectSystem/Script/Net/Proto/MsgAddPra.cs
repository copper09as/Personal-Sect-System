using SectSystem.Data;

public class MsgAddPra:MsgBase
{
    public MsgAddPra()
    {
        protoName = "MsgAddPra";
    }
    public string name;
    public string cultivation;
    public string raction;
    public string weapon;
    public string sect;
    public int years;
    public int sex;
}

