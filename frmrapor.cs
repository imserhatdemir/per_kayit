using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace per_kayit
{
    public partial class frmrapor : Form
    {
        public frmrapor()
        {
            InitializeComponent();
        }

        private void frmrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelveritabaniDataSet2.tbl_per' table. You can move, or remove it, as needed.
            this.tbl_perTableAdapter.Fill(this.personelveritabaniDataSet2.tbl_per);

            this.reportViewer1.RefreshReport();
        }
    }
}
