using DesktopDataAccess.Classes;
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
    public partial class groupForm : Form
    {
        public groupForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Group group = new Group();
            group.Name = textBoxGroupNameG.Text;

            if (Group.Proverka(group) != 0)
            {
                MessageBox.Show("Такая группа существует");
                textBoxGroupNameG.Clear();
            }
            else
            {
                Group.Insert(group);
                MessageBox.Show("Группа добавлена");
                textBoxGroupNameG.Clear();
            }
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Hide();
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }
    }
}
