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
using Microsoft.IdentityModel.Tokens;
using System.Text.RegularExpressions;

namespace Yapısal_Projeyi
{
    public partial class YÖNETİCİEKLEMEFORMU : Form
    {
        public YÖNETİCİEKLEMEFORMU()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=ALWAN;Initial Catalog=YBS2024;Integrated Security=True;TrustServerCertificate=True");
        private void addbtn_Click(object sender, EventArgs e)
        {

            if (nametxt.Text.Trim().IsNullOrEmpty())
            {
                MessageBox.Show("Lütfen adınızı yazınız...", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usernametxt.Text.Trim().IsNullOrEmpty())
            {
                MessageBox.Show("Lütfen kullancı adınızı yazınız...", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passtxt.Text.Trim().IsNullOrEmpty())
            {
                MessageBox.Show("Lütfen şifrenizi yazınız...", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd1 = new SqlCommand("insert into Yöneticiler values ('" + nametxt.Text + "','" + usernametxt.Text + "','" + passtxt.Text + "')", con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    ViewGridData();
                    MessageBox.Show("KULLANICI BAŞARILI EKLENDİ");
                }
                catch
                {

                }
            }
        }
        void ViewGridData()
        {
            try
            {
                con.Open();
                string query = "select * from Yöneticiler";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                Userinfo.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void YÖNETİCİFORMU_Load(object sender, EventArgs e)
        {
            ViewGridData();

        }

        private void deletbtn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string myquery = "delete from Yöneticiler where Username='" + usernametxt.Text + "';";
            SqlCommand cmd2 = new SqlCommand(myquery, con);
            cmd2.ExecuteNonQuery();
            con.Close();
            ViewGridData();
            MessageBox.Show("KULLANICI BAŞARILI SİLİNDİ");
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Userinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nametxt.Text = Userinfo.SelectedRows[0].Cells[0].Value.ToString();
            usernametxt.Text = Userinfo.SelectedRows[0].Cells[1].Value.ToString();
            passtxt.Text = Userinfo.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("Update Yöneticiler set Name='" + nametxt.Text + "', Password='" + passtxt.Text + "'where Username='" + usernametxt.Text + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                ViewGridData();
                MessageBox.Show("KULLANICI BAŞARILI DÜZENLENDİ");
            }
            catch
            {

            }
        }

        private void YÖNETİCİFORMU_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - resizepanel.Width) / 2;
            int y = (this.Height - resizepanel.Height) / 2;
            resizepanel.Location = new Point(x, y);
        }
    }
}
