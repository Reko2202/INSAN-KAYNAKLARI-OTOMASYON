using Microsoft.Identity.Client.Extensions.Msal;
using System.Data;
using System.Data.SqlClient;

namespace Yapısal_Projeyi
{
    public partial class GİRİŞFORMU : Form
    {
        public GİRİŞFORMU()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALWAN;Initial Catalog=YBS2024;Integrated Security=True;TrustServerCertificate=True");

        private void göstercheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (göstercheckbox.Checked)
            {
                şifretextBox.UseSystemPasswordChar = false;
            }
            else
            {
                şifretextBox.UseSystemPasswordChar = true;
            }
        }

        private void girişbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Count(*) from Yöneticiler where Username='" + kullancıadıtextBox.Text + "' and Password= '" + şifretextBox.Text + "'", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                YÖNETİCİEKRANI frm = new YÖNETİCİEKRANI();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlıştır tekrar deneyeniz");
            }
            con.Close();
        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmdlbtn_Click(object sender, EventArgs e)
        {
            İŞÇİFORMU form = new İŞÇİFORMU();
            form.Show();
            this.Hide();
        }

        private void şifretextBox_TextChanged(object sender, EventArgs e)
        {
            şifretextBox.UseSystemPasswordChar = true;
        }

        private void GirişFormu_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
