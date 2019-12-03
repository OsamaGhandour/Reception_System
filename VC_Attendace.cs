using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class VC_Attendace : Form
    {
        V_DatagridView VV;
        public VC_Attendace()
        {
            InitializeComponent();
        }

        private void VC_Attendace_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Present();


        }

        void ViewData()
        {
            VV = new V_DatagridView();
            VV.DisplayData(dataGridView1, "AttendanceQ");

        }

        void Present()
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int noofpres = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            noofpres++;
            M_Attendance AttKid = new M_Attendance();
            string[] atts = { "Present" };
            string no = noofpres.ToString();
            string[] values = { no };
            AttKid.updateuser2("AttendanceQ", id, atts, values, "KidIDA");
            ViewData();


        }

        void Absent()
        {
            int id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int noofpres = Int32.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            noofpres++;
            M_Attendance AttKid = new M_Attendance();
            string[] atts = { "Absent" };
            string no = noofpres.ToString();
            string[] values = { no };
            AttKid.updateuser2("AttendanceQ", id, atts, values, "KidIDA");
            ViewData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Absent();
        }
    }
}
