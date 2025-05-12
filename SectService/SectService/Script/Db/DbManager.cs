using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System;
using Newtonsoft.Json;
using SectSystem.Data;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;
using System.Xml.Linq;
public class DbManager
{
    public static MySqlConnection mySql;

    public static bool Connect(string db, string ip, int port, string user, string pw)
    {
        mySql = new MySqlConnection();

        string s = string.Format
            ("Database={0};Data Source={1};port={2};User Id={3};Password={4};Charset=utf8mb4", db, ip, port, user, pw);
        mySql.ConnectionString = s;
        try
        {
            mySql.Open();
            Console.WriteLine("{数据库}connect succ");
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine("{数据库}connect fail," + e.Message);
            return false;
        }
    }
    private static bool IsSafeString(string str)
    {
        return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']");
    }
    public static bool IsAccountExist(string id)
    {
        /*if(!DbManager.IsSafeString(id))
        {
            return false;
        }*/
        string s = "select * from account where id = @id;";
        try
        {
            MySqlCommand cmd = new MySqlCommand(s, mySql);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            bool hasRows = dataReader.HasRows;
            dataReader.Close();
            return hasRows;
        }
        catch (Exception e)
        {
            Console.WriteLine("{数据库}Create Player fail," + e.Message);
            return false;
        }
    }
    public static bool IsNameExist(string name)
    {
        if (!DbManager.IsSafeString(name))
        {
            return false;
        }
        string s = string.Format("select * from sectdata where name='{0}';", name);
        try
        {
            MySqlCommand cmd = new MySqlCommand(s, mySql);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            bool hasRows = dataReader.HasRows;
            dataReader.Close();
            return hasRows;
        }
        catch (Exception e)
        {
            Console.WriteLine("{数据库}Create People fail," + e.Message);
            return false;
        }
    }
    public static bool Register(string id, string pw)
    {
        /*if(!DbManager.IsSafeString(id))
        {
            MessageBox.Show("账号字符不安全");
            return false;
        }
        if (!DbManager.IsSafeString(pw))
        {
            MessageBox.Show("密码字符不安全");
            return false;
        }*/
        if (DbManager.IsAccountExist(id))
        {
            Console.WriteLine("账号名重复");
            return false;
        }
        string sql = "insert into account set id = @id ,pw = @pw;";
        try
        {
            MySqlCommand cmd = new MySqlCommand(sql, mySql);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pw", pw);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine("{数据库}Register Fail," + e.Message);
            return false;
        }
    }
    public static bool CheckPassword(string id, string pw)
    {
        if (!DbManager.IsSafeString(id))
        {
            Console.WriteLine("{数据库}CheckPassWord Fail,id not safe,");
            return false;
        }
        if (!DbManager.IsSafeString(pw))
        {
            Console.WriteLine("{数据库}CheckPassWord Fail,pw not safe,");
            return false;
        }
        string sql = string.Format("select * from account where id ='{0}'and pw ='{1}';", id, pw);
        try
        {
            MySqlCommand cmd = new MySqlCommand(sql, mySql);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            bool hasRows = dataReader.HasRows;
            dataReader.Close();
            return hasRows;
        }
        catch (Exception e)
        {
            Console.WriteLine("{数据库}Check PassWord err," + e.Message);
            return false;
        }
    }
    public static bool CreateData(string sql)
    {
        try
        {
            MySqlCommand cmd = new MySqlCommand(sql, mySql);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine("{数据库}Create Sect fail," + e.Message);
            return false;
        }
    }
    public static List<SectData> GetSectData()
    {
        string sql = "select * from sectdata";
        List<SectData> sects = new List<SectData>();
        try
        {
            MySqlCommand cmd = new MySqlCommand(sql, mySql);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                SectData sect = new SectData()
                {
                    id = int.Parse(dataReader["sectid"].ToString()),
                    name = dataReader["name"].ToString(),
                    leaderName = dataReader["leadername"].ToString(),
                    man = int.Parse(dataReader["man"].ToString()),
                    woman = int.Parse(dataReader["woman"].ToString()),
                    responsibility = dataReader["responsibility"].ToString(),
                    years = int.Parse(dataReader["year"].ToString()),
                    tutions = dataReader["tutions"].ToString()
                };
                sects.Add(sect);
            }
            dataReader.Close();
            return sects;
        }
        catch (Exception e)
        {
            Console.WriteLine("{数据库}View fail," + e.Message);
            return sects;
        }
    }
    public static bool DeleteData(string table, string id)
    {
        try
        {
            string sql = string.Format("delete from {0} where sectid = {1};",table,id);
            MySqlCommand cmd = new MySqlCommand(sql, mySql);
            cmd.ExecuteNonQuery();
            Console.Write(table);
            Console.Write(id);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            return false;
        }
    }

    public static bool UpdateData(string sql)
    {
        try
        {
            MySqlCommand cmd = new MySqlCommand(sql, mySql);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine("{数据库}update fail," + e.Message);
            return false;
        }
    }
}

