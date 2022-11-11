using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace troll_hesap_makinasi
{
    public partial class Form1 : Form
    {
        depolama depo = new depolama();
        int sayac = 1;
        string islem;
        double sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        
        {

            if (sayac == 1)
            {
                depo.sayi1 = "1";
                
            textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "1";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }
        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "2";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "2";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "3";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "3";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "4";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "4";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "5";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "5";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "6";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "6";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "7";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "7";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "8";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "8";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "9";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "9";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = "0";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = "0";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = ",";

                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = ",";
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = "+";


            sayac++;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = "-";

            sayac++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = "X";

            sayac++;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            islem = "/";
            sayac++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                depo.sayi1 = null;
                textBox1.Text = depo.sayi1;
            }
            else
            {
                depo.sayi2 = null;
                textBox1.Text = depo.sayi1 + " " + islem + " " + depo.sayi2;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            depo.sayi1 = null;
            depo.sayi2 = null;
            sayac = 1;
            this.Controls.Clear();
            this.InitializeComponent();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                sonuc = double.Parse(depo.sayi1) + double.Parse(depo.sayi2);
                textBox2.Text = Convert.ToString(sonuc);
            }
            else if (islem == "-")
            {
                sonuc = double.Parse(depo.sayi1) - double.Parse(depo.sayi2);
                textBox2.Text = Convert.ToString(sonuc);
            }
            else if (islem == "X")
            {
                sonuc = double.Parse(depo.sayi1) * double.Parse(depo.sayi2);
                textBox2.Text = Convert.ToString(sonuc);

            }
            else if (islem == "/")
            {
                sonuc = double.Parse(depo.sayi1) / double.Parse(depo.sayi2);
                textBox2.Text = Convert.ToString(sonuc);

            }
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(sonuc);
        }
    }
}
