using DesktopCore;
using DesktopCore.Classes;
using System;

namespace DesktopDataAccess.Classes
{
    public class Student :BaseObject
    {
        private const string table = "students";


        public string Name { get; set; }
        public string Surname { get; set; }
        public int GroupId { get; set; }

        public static void Insert(Student student, Group group)
        {
            string sql = $@"INSERT INTO [{table}]
                            VALUES ('{student.Name}','{student.Surname}',{student.GroupId})";

           
            DBContext.Execute(sql);
        }


        //public static void Delete(int id)
        //{
        //    string sql = @$"DELETE FROM [{table}]
        //                    WHERE id =[{id}]";

        //   
        //    DBContext.Execute(sql);
        //}



        //public static void Update(Student student)
        //{
        //    string sql = @$"INSERT INTO [{table}]
        //                    VALUES ('{student.Name}')";

        //
        //    DBContext.Execute(sql);
        //}
    }
}
