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
    public partial class frmgrafik : Form
    {
        public frmgrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZAROK\\SQLEXPRESS;Initial Catalog=personelveritabani;Integrated Security=True");

        private void frmgrafik_Load(object sender, EventArgs e)
        {
            ////
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("select persehir,count(*)from tbl_per group by persehir", baglanti);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart2.Series["Sehirler"].Points.AddXY(dr1[0], dr1[0]);
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("select permeslek,avg(permaas)from tbl_per group by permeslek", baglanti);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[0]);
            }
            baglanti.Close();
        }
    }
}
