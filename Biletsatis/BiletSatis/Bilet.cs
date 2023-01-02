using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace Ders14
{
    class Bilet
    {
        
        public Bilet()
        {                
        }
     
        
        public SqlConnection baglanti=new SqlConnection ( @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
      
        public void sat(string koltukno,string yolcu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into otobus (Koltukno,Yolcu) values ('" + koltukno + "','" + yolcu + "')",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Satış tamamlandı", "Bilet satış");
            komut.Dispose();
            baglanti.Close();
         
        } 
        public void iptal(string koltukno)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from otobus where Koltukno = '" + koltukno + "'", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Satış iptal edildi", "Bilet satış");
            komut.Dispose();
            baglanti.Close();


        
        }
        public bool bosmu(Button bt , string koltukno)
        {
            bool bos = false;
            SqlCommand komut = new SqlCommand("Select * from otobus where Koltukno='" + koltukno + "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                bos = false;
                bt.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                bos = true;
                bt.BackColor = System.Drawing.Color.Red;
            }
            return bos;
           
        }
    }
}
