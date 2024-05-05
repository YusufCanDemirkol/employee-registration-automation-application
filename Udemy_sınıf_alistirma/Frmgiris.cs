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
    public partial class Frmgiris : Form
    {
        public Frmgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3O5HSBU\\SQLEXPRESS01;Initial Catalog=personal_veri_tabani;Integrated Security=True");

        private void Frmgiris_Load(object sender, EventArgs e)
        {

        }

        private void btgiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand dogrula = new SqlCommand("select * from Tbl_giris where kullanici_adi=@p1 and şifre=@p2", baglanti);
            dogrula.Parameters.AddWithValue("@p1", txtkullanıcıadı.Text);
            dogrula.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = dogrula.ExecuteReader();
            if(dr.Read())
            {
                FrmAna fr = new FrmAna();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre hatalı");
            }
          baglanti.Close();
        }
    }
}
