using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ambahotel
{
    public partial class Form1 : Form
    {
        private object tbusername;
        private object tbpassword;
        private object _db;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbusername.Text.Trim();
                var password = tbpassword.Text;

                var user = _db.User.FirstOrDefaul(q => q.username == username && q.password == password);
                if (user != null) 
                {
            } 
        }

    }
}
