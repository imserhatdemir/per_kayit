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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZAROK\\SQLEXPRESS;Initial Catalog=personelveritabani;Integrated Security=True");

        private void bg_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_ytc where kad=@a1 and sifre=@a2", baglanti);
            komut.Parameters.AddWithValue("@a1", txtkad.Text);
            komut.Parameters.AddWithValue("@a2", txts.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ");
            }
            baglanti.Close();
        }

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
