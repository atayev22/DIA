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
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void logIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxMail.Text=="dia" && textBoxPass.Text=="1234")
            {
                Hide();
                mainForm mainForm = new mainForm();
                mainForm.Show();
               
            }
            else
            {
                MessageBox.Show("Неправильный pass. или mail");
                textBoxMail.Clear();
                textBoxPass.Clear();
            }
        }
    }
}
