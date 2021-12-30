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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ZAROK\\SQLEXPRESS;Initial Catalog=personelveritabani;Integrated Security=True");

        void temizle()
        {
            txtboxid.Text = "";
            textboxad.Text = "";
            textboxsoyad.Text = "";
            coboxsehir.Text = "";
            mtmaas.Text = "";
            textboxmeslek.Text = "";
            evli.Checked = false;
            bekar.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelveritabaniDataSet2.tbl_per' table. You can move, or remove it, as needed.
         
        
        }

       

        private void listbuton_Click(object sender, EventArgs e)
        {
            this.tbl_perTableAdapter.Fill(this.personelveritabaniDataSet2.tbl_per);
        }

        private void kayıtbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_per (perad,persoyad,persehir,permaas,permeslek,perdurum)values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", textboxad.Text);
            komut.Parameters.AddWithValue("@p2", textboxsoyad.Text);
            komut.Parameters.AddWithValue("@p3", coboxsehir.Text);
            komut.Parameters.AddWithValue("@p4", mtmaas.Text);
            komut.Parameters.AddWithValue("@p5", textboxmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void evli_CheckedChanged(object sender, EventArgs e)
        {
            if (evli.Checked == true)
            {
                label8.Text = "True";
            }

        }

        private void bekar_CheckedChanged(object sender, EventArgs e)
        {
            if (bekar.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void tmzbuton_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtboxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textboxad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textboxsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            coboxsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mtmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textboxmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                evli.Checked = true;
            }
           if(label8.Text == "False")
            {
                bekar.Checked = false;
            }
        }

        private void silbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete From tbl_per Where perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtboxid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void gncbuton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand gnc = new SqlCommand("Update tbl_per Set perad=@b1,persoyad=@b2,persehir=@b3,permaas=@b4,permeslek=@b6,perdurum=@b5 where perid=@b7",baglanti);
            gnc.Parameters.AddWithValue("@b1", textboxad.Text);
            gnc.Parameters.AddWithValue("@b2", textboxsoyad.Text);
            gnc.Parameters.AddWithValue("@b3", coboxsehir.Text);
            gnc.Parameters.AddWithValue("@b4", mtmaas.Text);
            gnc.Parameters.AddWithValue("@b5", label8.Text);
            gnc.Parameters.AddWithValue("@b6", textboxmeslek.Text);
            gnc.Parameters.AddWithValue("@b7", txtboxid.Text);

            gnc.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Tamam");
        }

        private void istbuton_Click(object sender, EventArgs e)
        {
            istatistikfrm fr = new istatistikfrm();
            fr.Show();
        }

        private void grafbuton_Click(object sender, EventArgs e)
        {
            frmgrafik frg = new frmgrafik();
            frg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmrapor frp = new frmrapor();
            frp.Show();
        }
    }
}
