using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;

namespace Yapısal_Projeyi
{
    public partial class İŞÇİFORMU : Form
    {
        public İŞÇİFORMU()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALWAN;Initial Catalog=YBS2024;Integrated Security=True;TrustServerCertificate=True");
        string Gender = "";
        //void ViewGridData()
        //{
        //    try
        //    {
        //        con.Open();
        //        string query = "select * from işçiform";
        //        SqlDataAdapter adapter = new SqlDataAdapter(query, con);
        //        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
        //        var ds = new DataSet();
        //        adapter.Fill(ds);
        //        con.Close();
        //    }
        //    catch
        //    {

        //    }
        //}
        private void İÇŞİFORMU_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - resizepanel.Width) / 2;
            int y = (this.Height - resizepanel.Height) / 2;
            resizepanel.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regemail = new Regex("^[a-z0-9ğüçşöı]+([-_.a-z0-9şğüöçı]*)*@[a-z]+\\.[a-z]+$");
            Regex regadsoyad = new Regex("^[A-ZÖÇŞİĞÜ]+\\s[A-ZÖÇŞİĞÜ]+$");

            //************************************************************************************************************************************************************
            // ** AD SOYAD **
            if (regadsoyad.IsMatch(mtadsoyad.Text) == false)
            {
                MessageBox.Show("HATALI AD-SOYAD !!!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbladsoyad.ForeColor = Color.Red;
                adsoyadwrnlbl.Visible = true;
            }
            else
            {
                lbladsoyad.ForeColor = Color.Black;
                adsoyadwrnlbl.Visible = false;
            }
            //************************************************************************************************************************************************************
            // ** DOĞUM TARİH **

            if (!mtdogumtarihi.MaskFull)
            {
                MessageBox.Show("HATALI DOĞUM TARİHİ !!!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbldogumtarihi.ForeColor = Color.Red;
            }
            else
            {
                lbldogumtarihi.ForeColor = Color.Black;
            }
            //************************************************************************************************************************************************************
            // ** CİNSİYET **

            if (Gender == "")
            {
                MessageBox.Show("HATALI CİNSİYET !!!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblcinsiyet.ForeColor = Color.Red;
            }
            else
            {
                lblcinsiyet.ForeColor = Color.Black;
            }
            //************************************************************************************************************************************************************
            // ** TELEFON **

            if (!mttelefon.MaskFull)
            {
                MessageBox.Show("HATALI TELEFON !!!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbltelefon.ForeColor = Color.Red;
            }
            else
            {
                lbltelefon.ForeColor = Color.Black;
            }
            //************************************************************************************************************************************************************
            // ** EMAİL **

            if (regemail.IsMatch(mtemail.Text) == false)
            {
                MessageBox.Show("HATALI E-MAİL !!!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblemail.ForeColor = Color.Red;
                emailwrnlbl.Visible = true;
            }
            else
            {
                lblemail.ForeColor = Color.Black;
                emailwrnlbl.Visible = false;
            }
            //************************************************************************************************************************************************************
            // ** BÖLÜM **

            if (cbbolum.Text.Trim().IsNullOrEmpty())
            {
                MessageBox.Show("HATALI BÖLÜM !!!", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblbolum.ForeColor = Color.Red;
            }
            else
            {
                lblbolum.ForeColor = Color.Black;
            }

            if (redchecklbl.ForeColor == lbladsoyad.ForeColor && redchecklbl.ForeColor == lbldogumtarihi.ForeColor && redchecklbl.ForeColor == lblcinsiyet.ForeColor && redchecklbl.ForeColor == lbltelefon.ForeColor && redchecklbl.ForeColor == lblemail.ForeColor && redchecklbl.ForeColor == lblbolum.ForeColor)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd1 = new SqlCommand("insert into işçiform values ('" + mtadsoyad.Text + "','" + mtdogumtarihi.Text + "','" + Gender + "','" + mttelefon.Text + "','" + mtemail.Text + "','" + cbbolum.Text + "')", con);
                cmd1.ExecuteNonQuery();
                con.Close();
                //ViewGridData();
                this.Close();
                MessageBox.Show("Başvurunuz başarılı iletildi", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GİRİŞFORMU form = new GİRİŞFORMU();
                form.Show();
            }
            else
            {

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            GİRİŞFORMU form = new GİRİŞFORMU();
            form.Show();
            this.Close();
        }

        private void rberkek_CheckedChanged(object sender, EventArgs e)
        {

            Gender = "Erkek";
        }

        private void rbkadın_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Kadın";
        }



    }    
}
