using DesktopCore;
using DesktopCore.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopDataAccess.Classes
{
    public class Group :BaseObject
    {
        private const string table = "groups";
        
        public string Name { get; set; }

        public static void Insert(Group group)
        {
         
            string sql = @$"INSERT INTO [{table}]
                            VALUES ('{group.Name}')";

         
                DBContext.Execute(sql);
      }

        public static int Proverka(Group group)
        {

            string sql = $@"SELECT id FROM groups
                          WHERE group_name = '{group.Name}'";

            
                return DBContext.ExCheck(sql);
            
           
        }
    }
}
