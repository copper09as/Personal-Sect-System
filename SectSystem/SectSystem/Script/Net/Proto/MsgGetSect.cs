using System.Collections.Generic;
using SectSystem.Data;
[System.Serializable]
public class MsgGetSect:MsgBase
{
    public MsgGetSect()
    {
        protoName = "MsgGetSect";
    }
    
    public List<SectData> sects;
}

