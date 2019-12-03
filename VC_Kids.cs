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
    public partial class VC_Kids : Form
    {
        public VC_Kids()
        {
            InitializeComponent();
            this.Text = "kids";
        }

        private void VC_Kids_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VC_AddForm AKF = new VC_AddForm("Kids",textBox2.Text);
            string[] Atts = { "Name", "Birthdate", "Gender", "Address", "Parent_Email", "Phone_Number","ClassNo" };
            AKF.SetDesign(Atts, 1);
            AKF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                VC_AddForm AKF = new VC_AddForm("Kids", textBox2.Text);
                string[] Atts = { "Name", "Birthdate", "Gender", "Address", "Parent_Email", "Phone_Number", "ClassNo" };
                AKF.SetDesign(Atts, 0);
                AKF.Show();
            }
            else
            {
                MessageBox.Show("Enter ID");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            V_DatagridView vdgv = new V_DatagridView();
            vdgv.DisplayData(dataGridView1, "Kids");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int id;
                id = Int32.Parse(textBox3.Text);
                M_Kids kd = new M_Kids();
                kd.Delete("Kids", id, "KidID");
            }
            else
            {
                MessageBox.Show("Enter ID");
            }
        }
    }
}
