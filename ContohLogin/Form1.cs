using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContohLogin
{
    public partial class Form1 : Form
    {
        string Username = "admin";
        string Password = "123456";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text.ToUpper()==Username.ToUpper() && tbPassword.Text==Password)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password wrong!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
