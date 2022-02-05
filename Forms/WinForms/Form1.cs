using DesktopDataAccess.Classes;
using DesktopCore.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = DesktopCore.Classes.Message;
using System.Text.RegularExpressions;
using Group = DesktopDataAccess.Classes.Group;

namespace DesktopProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           

            Student student = new Student();
            Group group = new Group();

            
            student.Name = textBoxName.Text;
            student.Surname = textBoxSurname.Text;
            group.Name = textBoxGroup.Text;
            student.GroupId = group.Id;

            Student.Insert(student,group);
            Group.Insert(group);


        }


        //private void Error(Message msg) 
        //{
        //    if (msg != null)
        //    {
        //        MessageBox.Show(msg.Txt, msg.Type.ToString());
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
