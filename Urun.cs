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

namespace Petrol
{
    public partial class Urun : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=ENES\SQL;Initial Catalog=petroleri;Integrated Security=True");
        public Urun()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Urun_Load(object sender, EventArgs e)
        {

            Listeleme_Click(null, null);
        }

        private void Listeleme_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Urun", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void Ekleme_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Urun(UrunAdi, UrunMarka, UrunFiyati, StokMiktari) VALUES (@UrunAdi, @UrunMarka, @UrunFiyati, @StokMiktari)", baglanti);
                komut.Parameters.AddWithValue("@UrunAdi", TxturunAdi.Text);
                komut.Parameters.AddWithValue("@UrunMarka", TxturunMarka.Text);
                komut.Parameters.AddWithValue("@UrunFiyati", Convert.ToDecimal(TxturunFiyat.Text));
                komut.Parameters.AddWithValue("@StokMiktari", Convert.ToInt32(TxturunMiktarı.Text));
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla eklendi!");
                Listeleme_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void Silme_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin.");
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Urun WHERE Urun_id = @Urun_id", baglanti);
                komut.Parameters.AddWithValue("@Urun_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells["Urun_id"].Value));
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla silindi!");
                Listeleme_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir satır seçin.");
                return;
            }

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Urun SET UrunAdi = @UrunAdi, UrunMarka = @UrunMarka, UrunFiyati = @UrunFiyati, StokMiktari = @StokMiktari WHERE Urun_id = @Urun_id", baglanti);
                komut.Parameters.AddWithValue("@UrunAdi", TxturunAdi.Text);
                komut.Parameters.AddWithValue("@UrunMarka", TxturunMarka.Text);
                komut.Parameters.AddWithValue("@UrunFiyati", Convert.ToDecimal(TxturunFiyat.Text));
                komut.Parameters.AddWithValue("@StokMiktari", Convert.ToInt32(TxturunMiktarı.Text));
                komut.Parameters.AddWithValue("@Urun_id", Convert.ToInt32(dataGridView1.CurrentRow.Cells["Urun_id"].Value));
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla güncellendi!");
                Listeleme_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void Ara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtArma.Text))
            {
                MessageBox.Show("Lütfen bir arama terimi girin.");
                return;
            }

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Urun WHERE UrunAdi LIKE @Arama", baglanti);
                da.SelectCommand.Parameters.AddWithValue("@Arama", "%" + TxtArma.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Hatası: " + ex.Message);
            }
        }
    }
}