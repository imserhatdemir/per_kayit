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

namespace per_kayit
{
    public partial class istatistikfrm : Form
    {
        public istatistikfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZAROK\\SQLEXPRESS;Initial Catalog=personelveritabani;Integrated Security=True");
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void istatistikfrm_Load(object sender, EventArgs e)
        {

            ///toplam personel sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from tbl_per", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                ltp.Text = dr1[0].ToString();
            }
            baglanti.Close();
            ////evli personel sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from tbl_per where perdurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lep.Text = dr2[0].ToString();
            }
            baglanti.Close();
            //bekar personel sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from tbl_per where perdurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lbp.Text = dr3[0].ToString();
            }
            baglanti.Close();
            //şehir sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(persehir)) from tbl_per ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                ls.Text = dr4[0].ToString();
            }
            baglanti.Close();
            //maaş toplamı
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(permaas) from tbl_per ", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                ltm.Text = dr5[0].ToString();
            }
            baglanti.Close();
            //ortalama maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg(permaas) from tbl_per ", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lom.Text = dr6[0].ToString();
            }
            baglanti.Close();

        }
    }
}
