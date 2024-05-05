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

namespace Udemy_sınıf_alistirma
{
    public partial class FrmAna : Form
    {
        public FrmAna()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3O5HSBU\\SQLEXPRESS01;Initial Catalog=personal_veri_tabani;Integrated Security=True");

        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            cmbmeslek.Text = "";
            cmbsehir.Text="";
            mskmaas.Text = "";
            rdbevli.Checked = false;    
            rdbbekar.Checked = false;   

        }
        private void Form1_Load(object sender, EventArgs e)
        {

           

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutekle = new SqlCommand("insert into Tbl_1 (perad,persoyad,perşehir,permaas,permeslek,permedenidurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komutekle.Parameters.AddWithValue("@p1", txtad.Text);
            komutekle.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komutekle.Parameters.AddWithValue("@p3", cmbsehir.Text);
            komutekle.Parameters.AddWithValue("@p4", mskmaas.Text);
            komutekle.Parameters.AddWithValue("@p5", cmbmeslek.Text);
            komutekle.Parameters.AddWithValue("@p6", label8.Text);

            komutekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kişiler eklenmiştir");
        }

        private void btlistele_Click(object sender, EventArgs e)
        {
           
            this.tbl_1TableAdapter.Fill(this.personal_veri_tabaniDataSet.Tbl_1);
        }

        private void rdbevli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbevli.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void rdbbekar_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbbekar.Checked==true)
            { 
                label8.Text = "False"; 
            }

        }

        private void bttemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbsehir.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskmaas.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbmeslek.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            


        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                rdbevli.Checked = true;
                rdbbekar.Checked = false;

            }
            if(label8.Text == "False") 
            {
                rdbbekar.Checked = true;
                rdbevli.Checked= false;
            }
        }

        private void btsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_1 where perid=@d1",baglanti);
            komutsil.Parameters.AddWithValue("@d1",txtid.Text); 
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt silindi");
        }

        private void btgüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand(" update Tbl_1 set perad=@a1,persoyad=@a2,perşehir=@a3,permaas=@a4,permedenidurum=@a5,permeslek=@a6 where perid=@a7",baglanti);

            komutguncelle.Parameters.AddWithValue("@a1", txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbsehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskmaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", cmbmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtid.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("bilgiler güncellenmiştir");
        }

        private void btistatistik_Click(object sender, EventArgs e)
        {
            frmistatistik fr= new frmistatistik();
            fr.Show();
        }

        private void btgrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler1 fr = new FrmGrafikler1();
            fr.Show();

        }
    }
    }
