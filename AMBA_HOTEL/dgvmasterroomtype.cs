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
    public partial class dgvmasterroomtype : Form
    {
        private readonly AMBA_HOTELEntities _db;
        public dgvmasterroomtype()
        {
            InitializeComponent();
            _db = new AMBA_HOTELEntities();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvmasterroomtype_Load(object sender, EventArgs e)
        {
            var masterroomtype = _db.RoomTypes.FirstOrDefault();
            dataGridView1.DataSource = masterroomtype;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MasterRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
