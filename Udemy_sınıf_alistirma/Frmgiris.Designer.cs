namespace Udemy_sınıf_alistirma
{
    partial class Frmgiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkullanıcıadı = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btgiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(482, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "PERSONEL KAYIT / TAKİP";
            // 
            // txtkullanıcıadı
            // 
            this.txtkullanıcıadı.Location = new System.Drawing.Point(265, 165);
            this.txtkullanıcıadı.Margin = new System.Windows.Forms.Padding(5);
            this.txtkullanıcıadı.Name = "txtkullanıcıadı";
            this.txtkullanıcıadı.Size = new System.Drawing.Size(164, 43);
            this.txtkullanıcıadı.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(265, 273);
            this.txtsifre.Margin = new System.Windows.Forms.Padding(5);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(164, 43);
            this.txtsifre.TabIndex = 3;
            // 
            // btgiris
            // 
            this.btgiris.Font = new System.Drawing.Font("MS Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgiris.Location = new System.Drawing.Point(231, 371);
            this.btgiris.Margin = new System.Windows.Forms.Padding(5);
            this.btgiris.Name = "btgiris";
            this.btgiris.Size = new System.Drawing.Size(221, 44);
            this.btgiris.TabIndex = 4;
            this.btgiris.Text = "giriş";
            this.btgiris.UseVisualStyleBackColor = true;
            this.btgiris.Click += new System.EventHandler(this.btgiris_Click);
            // 
            // Frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(860, 504);
            this.Controls.Add(this.btgiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullanıcıadı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frmgiris";
            this.Load += new System.EventHandler(this.Frmgiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkullanıcıadı;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btgiris;
    }
}