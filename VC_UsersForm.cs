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
    public partial class VC_UsersForm : Form
    {
        public VC_UsersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VC_UserAU AddU = new VC_UserAU("Add",dataGridView1, textBox2.Text);
            AddU.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                VC_UserAU UpdateU = new VC_UserAU("Update", dataGridView1,textBox2.Text);
                UpdateU.Show();
            }
            else
            {
                MessageBox.Show("Enter ID");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            V_DatagridView VV = new V_DatagridView();
            VV.DisplayData(dataGridView1,"Users");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id;

            id = Int32.Parse(textBox3.Text);
          //  M_Genral.Delete("Users", id, "UserID");
        }
    }
}
