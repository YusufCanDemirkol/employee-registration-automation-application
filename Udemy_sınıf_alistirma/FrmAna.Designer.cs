namespace Udemy_sınıf_alistirma
{
    partial class FrmAna
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbmeslek = new System.Windows.Forms.ComboBox();
            this.mskmaas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbbekar = new System.Windows.Forms.RadioButton();
            this.cmbsehir = new System.Windows.Forms.ComboBox();
            this.rdbevli = new System.Windows.Forms.RadioButton();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btgrafik = new System.Windows.Forms.Button();
            this.btistatistik = new System.Windows.Forms.Button();
            this.bttemizle = new System.Windows.Forms.Button();
            this.btgüncelle = new System.Windows.Forms.Button();
            this.btsil = new System.Windows.Forms.Button();
            this.btkaydet = new System.Windows.Forms.Button();
            this.btlistele = new System.Windows.Forms.Button();
            this.tbl1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personal_veri_tabaniDataSet = new Udemy_sınıf_alistirma.personal_veri_tabaniDataSet();
            this.tbl_1TableAdapter = new Udemy_sınıf_alistirma.personal_veri_tabaniDataSetTableAdapters.Tbl_1TableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.perİdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perŞehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMedeniDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personal_veri_tabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PERSONEL ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "PERSONEL soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ŞEHİR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "MEDENİ DURUM :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "MESLEK :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cmbmeslek);
            this.groupBox1.Controls.Add(this.mskmaas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rdbbekar);
            this.groupBox1.Controls.Add(this.cmbsehir);
            this.groupBox1.Controls.Add(this.rdbevli);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(56, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 330);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personel kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbmeslek
            // 
            this.cmbmeslek.FormattingEnabled = true;
            this.cmbmeslek.Items.AddRange(new object[] {
            "öğretmen",
            "öğrenci",
            "kasap",
            "mali müşavir",
            "sahaf",
            "çiçekçi",
            "software engineer",
            "temizlikçi",
            "nalbur",
            "nalbant"});
            this.cmbmeslek.Location = new System.Drawing.Point(192, 288);
            this.cmbmeslek.Name = "cmbmeslek";
            this.cmbmeslek.Size = new System.Drawing.Size(218, 28);
            this.cmbmeslek.TabIndex = 6;
            // 
            // mskmaas
            // 
            this.mskmaas.Location = new System.Drawing.Point(192, 217);
            this.mskmaas.Mask = "00000";
            this.mskmaas.Name = "mskmaas";
            this.mskmaas.Size = new System.Drawing.Size(218, 26);
            this.mskmaas.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "MAAŞ :";
            // 
            // rdbbekar
            // 
            this.rdbbekar.AutoSize = true;
            this.rdbbekar.Location = new System.Drawing.Point(296, 249);
            this.rdbbekar.Name = "rdbbekar";
            this.rdbbekar.Size = new System.Drawing.Size(74, 24);
            this.rdbbekar.TabIndex = 8;
            this.rdbbekar.TabStop = true;
            this.rdbbekar.Text = "bekar";
            this.rdbbekar.UseVisualStyleBackColor = true;
            this.rdbbekar.CheckedChanged += new System.EventHandler(this.rdbbekar_CheckedChanged);
            // 
            // cmbsehir
            // 
            this.cmbsehir.FormattingEnabled = true;
            this.cmbsehir.Items.AddRange(new object[] {
            "adana",
            "urfa",
            "antep",
            "maraş",
            "izmir",
            "hatay",
            "kocaeli",
            "sakarya",
            "istanbul ",
            "manisa",
            "kırklareli",
            "edirne",
            "diyarbakır",
            "ordu",
            "trabzon",
            "kütahya",
            "giresun",
            "antalya",
            "muğla",
            "malatya",
            "siir",
            "elazığ",
            "van",
            "ağrı",
            "kastamonu",
            "kars",
            "erzurum",
            "erzincan",
            "batman",
            "muş",
            "çanakkale",
            "bursa",
            "ankara",
            "bolu",
            "düzce",
            "nevşehir",
            "niğde",
            "konya",
            "kayseri"});
            this.cmbsehir.Location = new System.Drawing.Point(192, 173);
            this.cmbsehir.Name = "cmbsehir";
            this.cmbsehir.Size = new System.Drawing.Size(218, 28);
            this.cmbsehir.TabIndex = 4;
            // 
            // rdbevli
            // 
            this.rdbevli.AutoSize = true;
            this.rdbevli.Location = new System.Drawing.Point(234, 251);
            this.rdbevli.Name = "rdbevli";
            this.rdbevli.Size = new System.Drawing.Size(56, 24);
            this.rdbevli.TabIndex = 7;
            this.rdbevli.TabStop = true;
            this.rdbevli.Text = "evli";
            this.rdbevli.UseVisualStyleBackColor = true;
            this.rdbevli.CheckedChanged += new System.EventHandler(this.rdbevli_CheckedChanged);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(192, 122);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(218, 26);
            this.txtsoyad.TabIndex = 3;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(192, 73);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(218, 26);
            this.txtad.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(192, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(218, 26);
            this.txtid.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btgrafik);
            this.groupBox2.Controls.Add(this.btistatistik);
            this.groupBox2.Controls.Add(this.bttemizle);
            this.groupBox2.Controls.Add(this.btgüncelle);
            this.groupBox2.Controls.Add(this.btsil);
            this.groupBox2.Controls.Add(this.btkaydet);
            this.groupBox2.Controls.Add(this.btlistele);
            this.groupBox2.Location = new System.Drawing.Point(636, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 330);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "işlemler";
            // 
            // btgrafik
            // 
            this.btgrafik.Location = new System.Drawing.Point(167, 249);
            this.btgrafik.Name = "btgrafik";
            this.btgrafik.Size = new System.Drawing.Size(155, 49);
            this.btgrafik.TabIndex = 6;
            this.btgrafik.Text = "GRAFİKLER";
            this.btgrafik.UseVisualStyleBackColor = true;
            this.btgrafik.Click += new System.EventHandler(this.btgrafik_Click);
            // 
            // btistatistik
            // 
            this.btistatistik.Location = new System.Drawing.Point(290, 173);
            this.btistatistik.Name = "btistatistik";
            this.btistatistik.Size = new System.Drawing.Size(155, 45);
            this.btistatistik.TabIndex = 5;
            this.btistatistik.Text = "İSTATİSTİK";
            this.btistatistik.UseVisualStyleBackColor = true;
            this.btistatistik.Click += new System.EventHandler(this.btistatistik_Click);
            // 
            // bttemizle
            // 
            this.bttemizle.Location = new System.Drawing.Point(290, 99);
            this.bttemizle.Name = "bttemizle";
            this.bttemizle.Size = new System.Drawing.Size(155, 49);
            this.bttemizle.TabIndex = 4;
            this.bttemizle.Text = "TEMİZLE";
            this.bttemizle.UseVisualStyleBackColor = true;
            this.bttemizle.Click += new System.EventHandler(this.bttemizle_Click);
            // 
            // btgüncelle
            // 
            this.btgüncelle.Location = new System.Drawing.Point(290, 25);
            this.btgüncelle.Name = "btgüncelle";
            this.btgüncelle.Size = new System.Drawing.Size(155, 51);
            this.btgüncelle.TabIndex = 3;
            this.btgüncelle.Text = "GÜNCELLE";
            this.btgüncelle.UseVisualStyleBackColor = true;
            this.btgüncelle.Click += new System.EventHandler(this.btgüncelle_Click);
            // 
            // btsil
            // 
            this.btsil.Location = new System.Drawing.Point(37, 173);
            this.btsil.Name = "btsil";
            this.btsil.Size = new System.Drawing.Size(155, 45);
            this.btsil.TabIndex = 2;
            this.btsil.Text = "SİL";
            this.btsil.UseVisualStyleBackColor = true;
            this.btsil.Click += new System.EventHandler(this.btsil_Click);
            // 
            // btkaydet
            // 
            this.btkaydet.Location = new System.Drawing.Point(37, 99);
            this.btkaydet.Name = "btkaydet";
            this.btkaydet.Size = new System.Drawing.Size(155, 49);
            this.btkaydet.TabIndex = 1;
            this.btkaydet.Text = "KAYDET";
            this.btkaydet.UseVisualStyleBackColor = true;
            this.btkaydet.Click += new System.EventHandler(this.btkaydet_Click);
            // 
            // btlistele
            // 
            this.btlistele.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btlistele.Location = new System.Drawing.Point(37, 29);
            this.btlistele.Name = "btlistele";
            this.btlistele.Size = new System.Drawing.Size(155, 47);
            this.btlistele.TabIndex = 0;
            this.btlistele.Text = "LİSTELE";
            this.btlistele.UseVisualStyleBackColor = true;
            this.btlistele.Click += new System.EventHandler(this.btlistele_Click);
            // 
            // tbl1BindingSource
            // 
            this.tbl1BindingSource.DataMember = "Tbl_1";
            this.tbl1BindingSource.DataSource = this.personal_veri_tabaniDataSet;
            // 
            // personal_veri_tabaniDataSet
            // 
            this.personal_veri_tabaniDataSet.DataSetName = "personal_veri_tabaniDataSet";
            this.personal_veri_tabaniDataSet.EnforceConstraints = false;
            this.personal_veri_tabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_1TableAdapter
            // 
            this.tbl_1TableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(522, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1286, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perİdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perŞehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perMedeniDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbl1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1537, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 348);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1543, 375);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "kayıtlar";
            // 
            // perİdDataGridViewTextBoxColumn
            // 
            this.perİdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.perİdDataGridViewTextBoxColumn.DataPropertyName = "Perİd";
            this.perİdDataGridViewTextBoxColumn.HeaderText = "Perİd";
            this.perİdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perİdDataGridViewTextBoxColumn.Name = "perİdDataGridViewTextBoxColumn";
            this.perİdDataGridViewTextBoxColumn.ReadOnly = true;
            this.perİdDataGridViewTextBoxColumn.Width = 83;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 150;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // perŞehirDataGridViewTextBoxColumn
            // 
            this.perŞehirDataGridViewTextBoxColumn.DataPropertyName = "PerŞehir";
            this.perŞehirDataGridViewTextBoxColumn.HeaderText = "PerŞehir";
            this.perŞehirDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perŞehirDataGridViewTextBoxColumn.Name = "perŞehirDataGridViewTextBoxColumn";
            this.perŞehirDataGridViewTextBoxColumn.Width = 150;
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            this.perMaasDataGridViewTextBoxColumn.Width = 150;
            // 
            // perMedeniDurumDataGridViewCheckBoxColumn
            // 
            this.perMedeniDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerMedeniDurum";
            this.perMedeniDurumDataGridViewCheckBoxColumn.HeaderText = "PerMedeniDurum";
            this.perMedeniDurumDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.perMedeniDurumDataGridViewCheckBoxColumn.Name = "perMedeniDurumDataGridViewCheckBoxColumn";
            this.perMedeniDurumDataGridViewCheckBoxColumn.Width = 150;
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            this.perMeslekDataGridViewTextBoxColumn.Width = 150;
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 727);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "FrmAna";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personal_veri_tabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskmaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbbekar;
        private System.Windows.Forms.ComboBox cmbsehir;
        private System.Windows.Forms.RadioButton rdbevli;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btgrafik;
        private System.Windows.Forms.Button btistatistik;
        private System.Windows.Forms.Button bttemizle;
        private System.Windows.Forms.Button btgüncelle;
        private System.Windows.Forms.Button btsil;
        private System.Windows.Forms.Button btkaydet;
        private System.Windows.Forms.Button btlistele;
        private System.Windows.Forms.ComboBox cmbmeslek;
        private personal_veri_tabaniDataSet personal_veri_tabaniDataSet;
        private System.Windows.Forms.BindingSource tbl1BindingSource;
        private personal_veri_tabaniDataSetTableAdapters.Tbl_1TableAdapter tbl_1TableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perİdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perŞehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perMedeniDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

