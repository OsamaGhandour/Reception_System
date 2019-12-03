using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    class V_DatagridView
    {
        private SqlConnection Connect = new SqlConnection("Data Source=ZEYADS-LAPTOP;Initial Catalog=Nursery;Integrated Security=True");
        SqlDataAdapter adapt;
        public void DisplayData(DataGridView dgv,string qu)
        {
            Connect.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from "+qu, Connect);
            adapt.Fill(dt);
            dgv.DataSource = dt;
            Connect.Close();
        }
    }
}
