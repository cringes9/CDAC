namespace DAL;
using BOL;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
public class HRDBManager
{
    public static string constring=@"server=localhost;Datbase=Transflower;Uid=root;Pwd=root";
    public static List<Department> GetAllDepartments()
    {
          List<Department> allDepartments = new List<Department>();
          using (MySqlConnection con=new MySqlConnection(constring))
          {
            con.Open();
            using(MySqlCommand com=con.CreateCommand())
            {
                com.Connection=con;
            }
          }

          return allDepartments;
    }

}