using DesktopCore;
using DesktopProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Hide();
            studentForm studentForm = new studentForm();
            studentForm.Show();
            
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            Hide();
            groupForm groupForm = new groupForm();
            groupForm.Show();
        }

        
            
private void mainForm_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT first_name as Name,second_name as Surname,group_name as Groups
                            FROM students
                            INNER JOIN groups
                            ON students.group_id = groups.id"; 
            
            dataGridView1.DataSource=DBContext.ExecuteData(sql).Tables[0];

        }
    }
}
