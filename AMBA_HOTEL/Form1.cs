using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMBA_HOTEL
{
    public partial class Form1 : Form
    {
        private readonly AMBA_HOTELEntities _db;
        public Form1()
        {
            InitializeComponent();
            _db = new AMBA_HOTELEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var Username = tbUsername.Text.Trim();
                var Password = tbPassword.Text;

                var User =_db.Employees.FirstOrDefault(q => q.Username == Username && q.Password == Password);
                if (User == null)
                {
                    MessageBox.Show("AHAHAH YAAAH SALAH");
                }
                else
                {
                    var mainWindow = new main_form ();
                    mainWindow.Show();
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wring. Please try again");
            }
        }
    }
}