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
    public partial class BAŞVURULAR : Form
    {
        public BAŞVURULAR()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALWAN;Initial Catalog=YBS2024;Integrated Security=True;TrustServerCertificate=True");
        void ViewGridData()
        {
            try
            {
                con.Open();
                string query = "select * from işçiform";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                başvurulargridview.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void BAŞVURULAR_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Başvuruyu reddetmek istediğinize emin misiniz ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string myquery = "delete from işçiform where ID='" + idtxt.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ViewGridData();
            }

        }

        private void BAŞVURULAR_Load(object sender, EventArgs e)
        {
            ViewGridData();
        }


        private void başvurulargridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the selected cell
                object value = başvurulargridview[e.ColumnIndex, e.RowIndex].Value;
                // Display the value in the TextBox
                idtxt.Text = value != null ? value.ToString() : string.Empty;  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ALWAN;Initial Catalog=YBS2024;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string id = idtxt.Text; // Get the ID from the textbox

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an ID.");
                return;
            }

            // Ask for confirmation before proceeding
            DialogResult result = MessageBox.Show("Başvuruyu kabul etmek istediğinize emin misiniz ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return; // Exit if the user does not confirm
            }

            string sqlInsertQuery = @"
            INSERT INTO işçiler (ADSOYAD, DOĞUMTARİHİ, CİNSİYET, TELEFON, EMAİL, BÖLÜM)
            SELECT ADSOYAD, DOĞUMTARİHİ, CİNSİYET, TELEFON, EMAİL, BÖLÜM
            FROM işçiform
            WHERE id = @id";

            string sqlDeleteQuery = "DELETE FROM işçiform WHERE id = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand insertCommand = new SqlCommand(sqlInsertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@id", id);
                        int rowsInserted = insertCommand.ExecuteNonQuery();
                        if (rowsInserted > 0)
                        {
                            using (SqlCommand deleteCommand = new SqlCommand(sqlDeleteQuery, connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@id", id);
                                deleteCommand.ExecuteNonQuery();
                            }
                            MessageBox.Show("Başvur kabul edilmiş.");
                        }
                        else
                        {
                            MessageBox.Show("ID BULUNMADI");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                ViewGridData();
            }

        }

            
        
    }
}
