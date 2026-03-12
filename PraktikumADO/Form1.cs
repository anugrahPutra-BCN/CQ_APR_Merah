using System; 
using System.Windows.Forms; 
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        //menambahkan variabel koneksi
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        // membuat method koneksi database
        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=DESKTOP-98D81B1\\ANUGRAH;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );           
        }

        //implement tombol koneksi database
        private void btnConnect_Click(object sender, EventArgs e) 
        { 
            try
            {
                Koneksi();
                conn.Open();

                MessageBox.Show("Koneksi ke Database berhasil");

                conn.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Mahasiswa";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Matakuliah";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "UPDATE Mahasiswa SET Alamat='Yogyakarta' WHERE NIM='23110100001'";

                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Jumlah baris terpengaruh : " + hasil);

                conn.Close();
            }
            catch ( Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungDosen_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                cmd = new SqlCommand("SELECT COUNT(*) FROM Dosen", conn);

                int jumlah = (int)cmd.ExecuteScalar();
                
                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                cmd = new SqlCommand("UPDATE MataKuliah SET SKS=4 WHERE KodeMK='IF210101'", conn);

                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil diupdate : " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                cmd = new SqlCommand("INSERT INTO ProgramStudi VALUES('MI01','Manajemen Informatika')", conn);

                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil ditambahkan : " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertProgramStudi_Click(object sender, EventArgs e)
        {

        }
    }
}
