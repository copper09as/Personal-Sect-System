
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;
using SectSystem.Data;

public static class StringResource
{
    public const string updateFromDataBase = "updateFromDataBase";

    public const string sectTable = "sectdata";
    public static string CreateSectDataSql(MsgAddSect sectData)
    =>
    string.Format("insert into sectdata set name = '{0}',responsibility = '{1}',leadername = '{2}',tutions = '{3}',year = '{4}';",
    sectData.name, sectData.responsibility, sectData.leaderName, sectData.tutions, sectData.years);
    public static string CreateParDataSql(MsgAddPra praData)
    =>
   string.Format("insert into practitioner set name = '{0}',cultivation = '{1}',yearold = '{2}',sect = '{3}',weapon = '{4}',sex = '{5}',raction = '{6}';",
   praData.name, praData.cultivation, praData.years, praData.sect, praData.weapon, praData.sex, praData.raction);
    public static string UpdateSectDataSql(SectData sectData)
    =>
    string.Format("update sectdata set name = '{0}',leadername = '{1}',responsibility = '{2}',tutions = '{3}',year = '{4}' where sectid = '{5}';", 
    sectData.name, sectData.leaderName, sectData.responsibility, sectData.tutions, sectData.years,sectData.id);
}

