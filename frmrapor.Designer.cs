namespace per_kayit
{
    partial class frmrapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personelveritabaniDataSet2 = new per_kayit.personelveritabaniDataSet2();
            this.tbl_perBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_perTableAdapter = new per_kayit.personelveritabaniDataSet2TableAdapters.tbl_perTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_perBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tbl_perBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "per_kayit.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // personelveritabaniDataSet2
            // 
            this.personelveritabaniDataSet2.DataSetName = "personelveritabaniDataSet2";
            this.personelveritabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_perBindingSource
            // 
            this.tbl_perBindingSource.DataMember = "tbl_per";
            this.tbl_perBindingSource.DataSource = this.personelveritabaniDataSet2;
            // 
            // tbl_perTableAdapter
            // 
            this.tbl_perTableAdapter.ClearBeforeFill = true;
            // 
            // frmrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrapor";
            this.Text = "RAPORLAR";
            this.Load += new System.EventHandler(this.frmrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_perBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_perBindingSource;
        private personelveritabaniDataSet2 personelveritabaniDataSet2;
        private personelveritabaniDataSet2TableAdapters.tbl_perTableAdapter tbl_perTableAdapter;
    }
}