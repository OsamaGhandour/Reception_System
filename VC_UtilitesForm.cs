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
    public partial class VC_UtilitesForm : Form
    {
        public VC_UtilitesForm()
        {
            InitializeComponent();
            this.Text = "Utilities";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VC_AddForm AUF = new VC_AddForm("Utilities", textBox2.Text);
            string[] Atts =  { "Supplier", "Type", "Units", "Price"};
            AUF.SetDesign(Atts,1);
            AUF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                VC_AddForm AUF = new VC_AddForm("Utilities", textBox2.Text);
                string[] Atts = { "Supplier", "Type", "Units", "Price" };
                AUF.SetDesign(Atts, 0);
                AUF.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            V_DatagridView vdg = new V_DatagridView();
            vdg.DisplayData(dataGridView1, "Utilities");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int id;
                id = Int32.Parse(textBox3.Text);
                M_Utilities ut = new M_Utilities();
                ut.Delete("Utilities", id, "UtilityID");
            }
            else
            {
                MessageBox.Show("Enter ID");
            }
        }
    }
}
