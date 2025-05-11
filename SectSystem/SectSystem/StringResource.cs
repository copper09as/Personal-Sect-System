
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;
using SectSystem.Data;

public static class StringResource
{
    public const string updateFromDataBase = "updateFromDataBase";

    public const string sectTable = "sectdata";
    /*public static string GetSectDataSql(SectData sectData)
    =>
    string.Format("insert into sectdata set name = '{0}',responsibility = '{1}',leadername = '{2}',tutions = '{3}',year = '{4}';",
    sectData.Name, sectData.Responsibility, sectData.LeaderName, sectData.Tutions, sectData.Years);
    public static string GetParDataSql(PraData praData)
    =>
   string.Format("insert into practitioner set name = '{0}',cultivation = '{1}',yearold = '{2}',sect = '{3}',weapon = '{4}',sex = '{5}',raction = '{6}';",
   praData.Name, praData.Cultivation, praData.Years, praData.Sect, praData.Weapon, praData.Sex, praData.Raction);
    */
    
    public static string UpdateSectDataSql(SectData sectData)
    =>
    string.Format("update sectdata set name = '{0}',leadername = '{1}',responsibility = '{2}',tutions = '{3}',year = '{4}' where sectid = '{5}';", 
    sectData.Name, sectData.LeaderName, sectData.Responsibility, sectData.Tutions, sectData.Years,sectData.Id);
}

