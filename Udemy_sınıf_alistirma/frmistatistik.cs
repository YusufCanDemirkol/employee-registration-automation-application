using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Udemy_sınıf_alistirma
{
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3O5HSBU\\SQLEXPRESS01;Initial Catalog=personal_veri_tabani;Integrated Security=True");


        private void frmistatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count (*) from Tbl_1", baglanti);
            SqlDataReader dr = komut1.ExecuteReader();  
            while(dr.Read()) 
            {
                lbltplprssys1.Text = dr[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count (*) from Tbl_1 where Permedenidurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read()) 
            {
             lblevliprssys1.Text= dr2[0].ToString();    
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count (*) from Tbl_1 where Permedenidurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                lblbkrprssys1.Text= dr3[0].ToString();  
            }
            baglanti.Close();   
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count (distinct (PerŞehir)) from tbl_1", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
              lblşhrçşdsys1.Text= dr4[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum (Permaas) from Tbl_1", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
                while(dr5.Read())
            {
                lbltplmaaş1.Text= dr5[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select avg (Permaas) from Tbl_1", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while(dr6.Read()) 
            {
                lblortmaaş1.Text= dr6[0].ToString();
            }
            baglanti.Close();

        }
    }
}
