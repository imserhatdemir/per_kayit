namespace per_kayit
{
    partial class FrmAnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.pkayıt = new System.Windows.Forms.GroupBox();
            this.tmzbuton = new System.Windows.Forms.Button();
            this.textboxmeslek = new System.Windows.Forms.TextBox();
            this.mtmaas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bekar = new System.Windows.Forms.RadioButton();
            this.kayıtbuton = new System.Windows.Forms.Button();
            this.evli = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.coboxsehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxad = new System.Windows.Forms.TextBox();
            this.textboxsoyad = new System.Windows.Forms.TextBox();
            this.islem = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grafbuton = new System.Windows.Forms.Button();
            this.istbuton = new System.Windows.Forms.Button();
            this.gncbuton = new System.Windows.Forms.Button();
            this.silbuton = new System.Windows.Forms.Button();
            this.listbuton = new System.Windows.Forms.Button();
            this.kayıt = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelveritabaniDataSet2 = new per_kayit.personelveritabaniDataSet2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_perTableAdapter = new per_kayit.personelveritabaniDataSet2TableAdapters.tbl_perTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pkayıt.SuspendLayout();
            this.islem.SuspendLayout();
            this.kayıt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pkayıt
            // 
            this.pkayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pkayıt.Controls.Add(this.tmzbuton);
            this.pkayıt.Controls.Add(this.textboxmeslek);
            this.pkayıt.Controls.Add(this.mtmaas);
            this.pkayıt.Controls.Add(this.label7);
            this.pkayıt.Controls.Add(this.label6);
            this.pkayıt.Controls.Add(this.bekar);
            this.pkayıt.Controls.Add(this.kayıtbuton);
            this.pkayıt.Controls.Add(this.evli);
            this.pkayıt.Controls.Add(this.label5);
            this.pkayıt.Controls.Add(this.coboxsehir);
            this.pkayıt.Controls.Add(this.label4);
            this.pkayıt.Controls.Add(this.txtboxid);
            this.pkayıt.Controls.Add(this.label3);
            this.pkayıt.Controls.Add(this.label1);
            this.pkayıt.Controls.Add(this.label2);
            this.pkayıt.Controls.Add(this.textboxad);
            this.pkayıt.Controls.Add(this.textboxsoyad);
            this.pkayıt.Location = new System.Drawing.Point(7, 8);
            this.pkayıt.Name = "pkayıt";
            this.pkayıt.Size = new System.Drawing.Size(317, 323);
            this.pkayıt.TabIndex = 0;
            this.pkayıt.TabStop = false;
            this.pkayıt.Text = "Personel Kayıt";
            // 
            // tmzbuton
            // 
            this.tmzbuton.Location = new System.Drawing.Point(53, 288);
            this.tmzbuton.Name = "tmzbuton";
            this.tmzbuton.Size = new System.Drawing.Size(237, 29);
            this.tmzbuton.TabIndex = 15;
            this.tmzbuton.Text = "Temizle";
            this.tmzbuton.UseVisualStyleBackColor = true;
            this.tmzbuton.Click += new System.EventHandler(this.tmzbuton_Click);
            // 
            // textboxmeslek
            // 
            this.textboxmeslek.Location = new System.Drawing.Point(143, 223);
            this.textboxmeslek.Name = "textboxmeslek";
            this.textboxmeslek.Size = new System.Drawing.Size(100, 26);
            this.textboxmeslek.TabIndex = 15;
            // 
            // mtmaas
            // 
            this.mtmaas.Location = new System.Drawing.Point(143, 159);
            this.mtmaas.Mask = "0000";
            this.mtmaas.Name = "mtmaas";
            this.mtmaas.Size = new System.Drawing.Size(100, 26);
            this.mtmaas.TabIndex = 5;
            this.mtmaas.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "MAAŞ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "DURUM:";
            // 
            // bekar
            // 
            this.bekar.AutoSize = true;
            this.bekar.Location = new System.Drawing.Point(203, 194);
            this.bekar.Name = "bekar";
            this.bekar.Size = new System.Drawing.Size(70, 23);
            this.bekar.TabIndex = 7;
            this.bekar.TabStop = true;
            this.bekar.Text = "Bekar";
            this.bekar.UseVisualStyleBackColor = true;
            this.bekar.CheckedChanged += new System.EventHandler(this.bekar_CheckedChanged);
            // 
            // kayıtbuton
            // 
            this.kayıtbuton.Location = new System.Drawing.Point(53, 255);
            this.kayıtbuton.Name = "kayıtbuton";
            this.kayıtbuton.Size = new System.Drawing.Size(237, 29);
            this.kayıtbuton.TabIndex = 10;
            this.kayıtbuton.Text = "Kaydet";
            this.kayıtbuton.UseVisualStyleBackColor = true;
            this.kayıtbuton.Click += new System.EventHandler(this.kayıtbuton_Click);
            // 
            // evli
            // 
            this.evli.AutoSize = true;
            this.evli.Location = new System.Drawing.Point(143, 194);
            this.evli.Name = "evli";
            this.evli.Size = new System.Drawing.Size(54, 23);
            this.evli.TabIndex = 6;
            this.evli.TabStop = true;
            this.evli.Text = "Evli";
            this.evli.UseVisualStyleBackColor = true;
            this.evli.CheckedChanged += new System.EventHandler(this.evli_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "MESLEK:";
            // 
            // coboxsehir
            // 
            this.coboxsehir.FormattingEnabled = true;
            this.coboxsehir.Location = new System.Drawing.Point(143, 126);
            this.coboxsehir.Name = "coboxsehir";
            this.coboxsehir.Size = new System.Drawing.Size(100, 27);
            this.coboxsehir.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "ŞEHİR:";
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(143, 30);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(100, 26);
            this.txtboxid.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // textboxad
            // 
            this.textboxad.Location = new System.Drawing.Point(143, 62);
            this.textboxad.Name = "textboxad";
            this.textboxad.Size = new System.Drawing.Size(100, 26);
            this.textboxad.TabIndex = 2;
            // 
            // textboxsoyad
            // 
            this.textboxsoyad.Location = new System.Drawing.Point(143, 94);
            this.textboxsoyad.Name = "textboxsoyad";
            this.textboxsoyad.Size = new System.Drawing.Size(100, 26);
            this.textboxsoyad.TabIndex = 3;
            // 
            // islem
            // 
            this.islem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.islem.Controls.Add(this.button1);
            this.islem.Controls.Add(this.grafbuton);
            this.islem.Controls.Add(this.istbuton);
            this.islem.Controls.Add(this.gncbuton);
            this.islem.Controls.Add(this.silbuton);
            this.islem.Controls.Add(this.listbuton);
            this.islem.Location = new System.Drawing.Point(633, 12);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(290, 323);
            this.islem.TabIndex = 15;
            this.islem.TabStop = false;
            this.islem.Text = "İşlemler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Raporlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grafbuton
            // 
            this.grafbuton.Location = new System.Drawing.Point(103, 230);
            this.grafbuton.Name = "grafbuton";
            this.grafbuton.Size = new System.Drawing.Size(100, 29);
            this.grafbuton.TabIndex = 14;
            this.grafbuton.Text = "Grafikler";
            this.grafbuton.UseVisualStyleBackColor = true;
            this.grafbuton.Click += new System.EventHandler(this.grafbuton_Click);
            // 
            // istbuton
            // 
            this.istbuton.Location = new System.Drawing.Point(103, 195);
            this.istbuton.Name = "istbuton";
            this.istbuton.Size = new System.Drawing.Size(100, 29);
            this.istbuton.TabIndex = 13;
            this.istbuton.Text = "İstatistik";
            this.istbuton.UseVisualStyleBackColor = true;
            this.istbuton.Click += new System.EventHandler(this.istbuton_Click);
            // 
            // gncbuton
            // 
            this.gncbuton.Location = new System.Drawing.Point(103, 160);
            this.gncbuton.Name = "gncbuton";
            this.gncbuton.Size = new System.Drawing.Size(100, 29);
            this.gncbuton.TabIndex = 12;
            this.gncbuton.Text = "Güncelle";
            this.gncbuton.UseVisualStyleBackColor = true;
            this.gncbuton.Click += new System.EventHandler(this.gncbuton_Click);
            // 
            // silbuton
            // 
            this.silbuton.Location = new System.Drawing.Point(103, 125);
            this.silbuton.Name = "silbuton";
            this.silbuton.Size = new System.Drawing.Size(100, 29);
            this.silbuton.TabIndex = 11;
            this.silbuton.Text = "Sil";
            this.silbuton.UseVisualStyleBackColor = true;
            this.silbuton.Click += new System.EventHandler(this.silbuton_Click);
            // 
            // listbuton
            // 
            this.listbuton.Location = new System.Drawing.Point(103, 92);
            this.listbuton.Name = "listbuton";
            this.listbuton.Size = new System.Drawing.Size(100, 29);
            this.listbuton.TabIndex = 9;
            this.listbuton.Text = "Listele";
            this.listbuton.UseVisualStyleBackColor = true;
            this.listbuton.Click += new System.EventHandler(this.listbuton_Click);
            // 
            // kayıt
            // 
            this.kayıt.Controls.Add(this.dataGridView1);
            this.kayıt.Location = new System.Drawing.Point(10, 345);
            this.kayıt.Name = "kayıt";
            this.kayıt.Size = new System.Drawing.Size(913, 148);
            this.kayıt.TabIndex = 15;
            this.kayıt.TabStop = false;
            this.kayıt.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblperBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 123);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "perad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "perad";
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "persehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "persehir";
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "permaas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "permaas";
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            // 
            // tblperBindingSource
            // 
            this.tblperBindingSource.DataMember = "tbl_per";
            this.tblperBindingSource.DataSource = this.personelveritabaniDataSet2;
            // 
            // personelveritabaniDataSet2
            // 
            this.personelveritabaniDataSet2.DataSetName = "personelveritabaniDataSet2";
            this.personelveritabaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(402, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_perTableAdapter
            // 
            this.tbl_perTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(355, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(935, 531);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kayıt);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.pkayıt);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAnaForm";
            this.Text = "Personel Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pkayıt.ResumeLayout(false);
            this.pkayıt.PerformLayout();
            this.islem.ResumeLayout(false);
            this.kayıt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelveritabaniDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pkayıt;
        private System.Windows.Forms.MaskedTextBox mtmaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton bekar;
        private System.Windows.Forms.RadioButton evli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox coboxsehir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxad;
        private System.Windows.Forms.TextBox textboxsoyad;
        private System.Windows.Forms.GroupBox islem;
        private System.Windows.Forms.Button grafbuton;
        private System.Windows.Forms.Button istbuton;
        private System.Windows.Forms.Button gncbuton;
        private System.Windows.Forms.Button silbuton;
        private System.Windows.Forms.Button kayıtbuton;
        private System.Windows.Forms.Button listbuton;
        private System.Windows.Forms.GroupBox kayıt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tmzbuton;
        private personelveritabaniDataSet2 personelveritabaniDataSet2;
        private System.Windows.Forms.BindingSource tblperBindingSource;
        private personelveritabaniDataSet2TableAdapters.tbl_perTableAdapter tbl_perTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textboxmeslek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

