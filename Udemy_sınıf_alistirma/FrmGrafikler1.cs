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
    public partial class FrmGrafikler1 : Form
    {
        public FrmGrafikler1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3O5HSBU\\SQLEXPRESS01;Initial Catalog=personal_veri_tabani;Integrated Security=True");

        private void FrmGrafikler1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select PerŞehir,COUNT(*) from Tbl_1 group by PerŞehir", baglanti);
            
            SqlDataReader dr1= komut1.ExecuteReader();
            while(dr1.Read())
            {
                chart1.Series["sehirler"].Points.AddXY(dr1[0], dr1[1]); 
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select PerŞehir,Sum(Permaas) from Tbl_1 group by PerŞehir", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                chart2.Series["maaslar"].Points.AddXY(dr2[0], dr2[1]);  
            }
            baglanti.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
