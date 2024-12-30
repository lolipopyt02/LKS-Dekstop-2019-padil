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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            var btnMasterRoomType = new dgvmasterroomtype();
            btnMasterRoomType.MdiParent = this;
            btnMasterRoomType.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void main_form_Load(object sender, EventArgs e)
        {

        }
    }
}
