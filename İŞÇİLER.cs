using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Yapısal_Projeyi
{
    public partial class İŞÇİLER : Form
    {
        public İŞÇİLER()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ALWAN;Initial Catalog=YBS2024;Integrated Security=True;TrustServerCertificate=True");

        void ViewGridData()
        {
            try
            {
                con.Open();
                string query = "select * from işçiler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }


        private void İŞÇİLER_Load(object sender, EventArgs e)
        {
            ViewGridData();
        }

        private void İŞÇİLER_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the selected cell
                object value = dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                // Display the value in the TextBox
                idtxt.Text = value != null ? value.ToString() : string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string myquery = "delete from işçiler where ID='" + idtxt.Text + "';";
            SqlCommand cmd = new SqlCommand(myquery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ViewGridData();
        }
    }
}
