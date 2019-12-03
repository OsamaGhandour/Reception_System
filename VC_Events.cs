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
    public partial class VC_Events : Form
    {
        public VC_Events()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VC_AddForm AEF = new VC_AddForm("Eventss",textBox2.Text);
            string[] Atts = {"Type","Place","Date","Time","Price" };
            AEF.SetDesign(Atts, 1);
            AEF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                VC_AddForm AEF = new VC_AddForm("Eventss", textBox2.Text);
                string[] Atts = { "Type", "Place", "Date", "Time", "Price" };
                AEF.SetDesign(Atts, 0);
                AEF.Show();
            }
            else
            {
                MessageBox.Show("Enter ID");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            V_DatagridView vdgv = new V_DatagridView();
            vdgv.DisplayData(dataGridView1, "Eventss");
        }

        private void VC_Events_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( textBox3.Text !="")
            {
                int id;
                id = Int32.Parse(textBox3.Text);
                M_Events ev = new M_Events();
                ev.Delete("Eventss", id, "EventID");
            }
        }
    }
}
