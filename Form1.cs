using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol
{
    public partial class Form1 : Form
    {
        public static string genel_bilgi = "";


        SqlConnection baglanti = new SqlConnection(@"Data Source=ENES\SQL;Initial Catalog=petroleri;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adını giriniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Şifre Giriniz");
                return;
            }

            string kul = textBox1.Text;
            string sifre = textBox2.Text;

            try
            {
                baglanti.Open();
                string sorgu = "SELECT * FROM login WHERE KullaniciAdi=@kul AND sifre=@sifre";
                SqlCommand command = new SqlCommand(sorgu, baglanti);
                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@sifre", sifre);

                SqlDataReader oku = command.ExecuteReader();

                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin " + oku["KullaniciAdi"].ToString();
                    MessageBox.Show(genel_bilgi);

                    // Ürün ekranına yönlendirme
                    Urun urunFormu = new Urun();
                    urunFormu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adını giriniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Şifre Giriniz");
                return;
            }

            string kul = textBox1.Text;
            string sifre = textBox2.Text;

            try
            {

                baglanti.Open();


                string sorgu = "SELECT * FROM login WHERE KullaniciAdi=@kul AND sifre=@sifre";
                SqlCommand command = new SqlCommand(sorgu, baglanti);


                command.Parameters.AddWithValue("@kul", kul);
                command.Parameters.AddWithValue("@sifre", sifre);


                SqlDataReader oku = command.ExecuteReader();

                if (oku.Read())
                {
                    genel_bilgi = "Hoşgeldin " + oku["KullaniciAdi"].ToString();
                    MessageBox.Show(genel_bilgi);
                    Kategoriler kategorilerForm = new Kategoriler();
                    kategorilerForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
     
 