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
using WinForms;

namespace DesktopProject
{
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           

            Student student = new Student();
            Group group = new Group();



            student.Name = textBoxName.Text;
            student.Surname = textBoxSurname.Text;
            group.Name = textBoxGroupNameS.Text;

            

            if (Group.Proverka(group) != 0)
            {
                group.Id = Group.Proverka(group);


                Student.Insert(student, group);

                MessageBox.Show("Успешно добавлено");


                textBoxName.Clear();
                textBoxSurname.Clear();
                textBoxGroupNameS.Clear();
            }
            else
            {
                MessageBox.Show("Такой группы не суш");
                textBoxGroupNameS.Clear();
            }
           
            
            

            


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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }
    }
}
