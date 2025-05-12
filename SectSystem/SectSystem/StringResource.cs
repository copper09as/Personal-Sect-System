
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;
using SectSystem.Data;

public static class StringResource
{
    //更新ui事件
    public const string updateFromDataBase = "updateFromDataBase";
    //宗派表名字
    public const string sectTable = "sectdata";
    //更改宗派表数据协议
    public const string msgUpdateSect = "MsgUpdateSect";
    //增加人员协议
    public const string msgAddPra = "MsgAddPra";
    //增加宗派协议
    public const string msgAddSect = "MsgAddSect";
    //登录协议
    public const string msgLogin = "MsgLogin";
    //注册协议
    public const string msgRegister = "MsgRegister";
    //获取宗派信息协议
    public const string msgGetSect = "MsgGetSect";
    //删除数据协议
    public const string msgDel = "MsgDel";
    /*public static string GetSectDataSql(SectData sectData)
    =>
    string.Format("insert into sectdata set name = '{0}',responsibility = '{1}',leadername = '{2}',tutions = '{3}',year = '{4}';",
    sectData.Name, sectData.Responsibility, sectData.LeaderName, sectData.Tutions, sectData.Years);
    public static string GetParDataSql(PraData praData)
    =>
   string.Format("insert into practitioner set name = '{0}',cultivation = '{1}',yearold = '{2}',sect = '{3}',weapon = '{4}',sex = '{5}',raction = '{6}';",
   praData.Name, praData.Cultivation, praData.Years, praData.Sect, praData.Weapon, praData.Sex, praData.Raction);
    
    
    public static string UpdateSectDataSql(SectData sectData)
    =>
    string.Format("update sectdata set name = '{0}',leadername = '{1}',responsibility = '{2}',tutions = '{3}',year = '{4}' where sectid = '{5}';", 
    sectData.name, sectData.leaderName, sectData.responsibility, sectData.tutions, sectData.years,sectData.id);
*/
}


