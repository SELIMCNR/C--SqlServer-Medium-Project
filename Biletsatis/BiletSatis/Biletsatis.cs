
using Ders14;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BiletSatis
{
    public partial class Biletsatis : Form
    {
        public Biletsatis()
        {
            InitializeComponent();
        }

            public SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            Bilet b = new Bilet();

            /*Her koltuğu boş mu diye konrol edelim*/
            void kontrolYap(System.Windows.Forms.Button bt)
            {
                bool bosmu;
                bosmu = b.bosmu(bt, textBox1.Text);
                textBox2.Text = "";
                if (bosmu == true)
                {
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                else
                {
                    button1.Enabled = true;
                    button2.Enabled = false;
                }
            }


            void koltuk_kontrol()
            {
                b.bosmu(button3, "1");
                b.bosmu(button4, "2");
                b.bosmu(button5, "3");
                b.bosmu(button6, "4");
                b.bosmu(button7, "5");
                b.bosmu(button8, "6");
                b.bosmu(button9, "7");
                b.bosmu(button10, "8");
                b.bosmu(button11, "9");
                b.bosmu(button12, "10");
                b.bosmu(button13, "11");
                b.bosmu(button14, "12");
                b.bosmu(button15, "13");
                b.bosmu(button16, "14");
                b.bosmu(button17, "15");
                b.bosmu(button18, "16");
                b.bosmu(button19, "17");
                b.bosmu(button20, "18");
                b.bosmu(button21, "19");
                b.bosmu(button22, "20");
                b.bosmu(button23, "21");
                b.bosmu(button24, "22");
                b.bosmu(button25, "23");
                b.bosmu(button26, "24");
                b.bosmu(button27, "25");
                b.bosmu(button28, "26");
                b.bosmu(button29, "27");
                b.bosmu(button30, "28");
                b.bosmu(button31, "29");
                b.bosmu(button32, "30");
                b.bosmu(button33, "31");
                b.bosmu(button34, "32");
                b.bosmu(button35, "33");
                b.bosmu(button36, "34");
                b.bosmu(button37, "35");
                b.bosmu(button38, "36");
            }

            public void listele()
            {
                SqlCommand komut = new SqlCommand("Select * from otobus", baglanti);
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }


        

        private void button3_Click(object sender, EventArgs e)
            {
            textBox1.Text = "1";
            kontrolYap(button3);
        }

        private void button4_Click(object sender, EventArgs e)
            {
            textBox1.Text = "2";
            kontrolYap(button4);
        }

        private void button5_Click(object sender, EventArgs e)
            {
            textBox1.Text = "3";
            kontrolYap(button5);
        }

        private void button6_Click(object sender, EventArgs e)
            {
            textBox1.Text = "4";
            kontrolYap(button6);
        }

        private void button7_Click(object sender, EventArgs e)
            {
            textBox1.Text = "5";
            kontrolYap(button7);
        }

        private void button8_Click(object sender, EventArgs e)
            {
            textBox1.Text = "6";
            kontrolYap(button8);
        }

        private void button9_Click(object sender, EventArgs e)
            {
            textBox1.Text = "7";
            kontrolYap(button9);
        }

        private void button10_Click(object sender, EventArgs e)
            {
            textBox1.Text = "8";
            kontrolYap(button10);

        }

        private void button11_Click(object sender, EventArgs e)
            {
                textBox1.Text = "9";
                kontrolYap(button11);
            }

            private void button12_Click(object sender, EventArgs e)
            {
                textBox1.Text = "10";
                kontrolYap(button12);
            }

            private void button13_Click(object sender, EventArgs e)
            {
                textBox1.Text = "11";
                kontrolYap(button13);
            }

            private void button14_Click(object sender, EventArgs e)
            {
                textBox1.Text = "12";
                kontrolYap(button14);
            }

            private void button15_Click(object sender, EventArgs e)
            {
                textBox1.Text = "13";
                kontrolYap(button15);
            }

            private void button17_Click(object sender, EventArgs e)
            {
                textBox1.Text = "15";
                kontrolYap(button17);
            }

            private void button16_Click(object sender, EventArgs e)
            {
                textBox1.Text = "14";
                kontrolYap(button16);
            }

            private void button18_Click(object sender, EventArgs e)
            {
                textBox1.Text = "16";
                kontrolYap(button18);
            }

            private void button19_Click(object sender, EventArgs e)
            {
                textBox1.Text = "17";
                kontrolYap(button19);
            }

            private void button20_Click(object sender, EventArgs e)
            {
                textBox1.Text = "18";
                kontrolYap(button20);
            }

            private void button21_Click(object sender, EventArgs e)
            {
                textBox1.Text = "19";
                kontrolYap(button21);
            }

            private void button22_Click(object sender, EventArgs e)
            {
                textBox1.Text = "20";
                kontrolYap(button22);
            }

            private void button23_Click(object sender, EventArgs e)
            {
                textBox1.Text = "21";
                kontrolYap(button23);
            }

            private void button24_Click(object sender, EventArgs e)
            {
                textBox1.Text = "22";
                kontrolYap(button24);
            }

            private void button25_Click(object sender, EventArgs e)
            {
                textBox1.Text = "23";
                kontrolYap(button25);
            }

            private void button26_Click(object sender, EventArgs e)
            {
                textBox1.Text = "24";
                kontrolYap(button26);
            }

            private void button27_Click(object sender, EventArgs e)
            {
                textBox1.Text = "25";
                kontrolYap(button27);
            }

            private void button28_Click(object sender, EventArgs e)
            {
                textBox1.Text = "26";
                kontrolYap(button28);
            }

            private void button29_Click(object sender, EventArgs e)
            {
                textBox1.Text = "27";
                kontrolYap(button29);
            }

            private void button30_Click(object sender, EventArgs e)
            {
                textBox1.Text = "28";
                kontrolYap(button30);
            }

            private void button31_Click(object sender, EventArgs e)
            {
                textBox1.Text = "29";
                kontrolYap(button31);
            }

            private void button32_Click(object sender, EventArgs e)
            {
                textBox1.Text = "30";
                kontrolYap(button32);
            }

            private void button33_Click(object sender, EventArgs e)
            {
                textBox1.Text = "31";
                kontrolYap(button33);
            }

            private void button34_Click(object sender, EventArgs e)
            {
                textBox1.Text = "32";
                kontrolYap(button34);
            }

            private void button35_Click(object sender, EventArgs e)
            {
                textBox1.Text = "33";
                kontrolYap(button26);
            }

            private void button36_Click(object sender, EventArgs e)
            {
                textBox1.Text = "34";
                kontrolYap(button36);
            }

            private void button37_Click(object sender, EventArgs e)
            {
                textBox1.Text = "35";
                kontrolYap(button37);
            }

            private void button38_Click(object sender, EventArgs e)
            {
                textBox1.Text = "36";
                kontrolYap(button38);
            }

        private void Biletsatis_Load(object sender, EventArgs e)
        {

         
                listele();
                koltuk_kontrol();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bilet sat
            string yolcu, koltukno;
            koltukno = textBox1.Text;
            yolcu = textBox2.Text;
            b.sat(koltukno, yolcu);
            koltuk_kontrol();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // bilet iptal 
            b.iptal(textBox1.Text);
            koltuk_kontrol();
            listele();
        }
    }
    }


