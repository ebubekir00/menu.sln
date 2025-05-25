using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> UcretList = new List<int>();
        
        private void button11_Click(object sender, EventArgs e)
        {           
           listBox1.Items.Add("200TL Köri Soslu Makarna");
           UcretList.Add(200);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("210TL Pesto Soslu Makarna");
            UcretList.Add(210);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("230TL Peynirli Pizza");
            UcretList.Add(230);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("170TL Sosisli Ekmek");
            UcretList.Add(170);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("150TL Tavuk Pilav");
            UcretList.Add(150);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("280TL Karışık Pizza");
            UcretList.Add(280);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("180TL Kumru Ekmek");
            UcretList.Add(180);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("200TL Köfte Burger");
            UcretList.Add(200);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("80TL Cheese Cake");
            UcretList.Add(80);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("70TL Magnolya");
            UcretList.Add(70);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("60TL Sütlaç");
            UcretList.Add(60);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("160TL Çikolatalı Pasta");
            UcretList.Add(160);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("60TL Brownie");
            UcretList.Add(60);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("100TL Çikolatalı Kurabiye");
            UcretList.Add(100);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("100TL Mozaik Pasta");
            UcretList.Add(100);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("90TL Fondü");
            UcretList.Add(90);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL"; toplamFiyat = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            panel1.Enabled = true;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            panel1.Enabled = false;
            panel2.Enabled = true;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("100TL Sıcak Çikolata");
            UcretList.Add(100);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("70TL Expresso");
            UcretList.Add(70);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("60TL Türk Kahvesi");
            UcretList.Add(60);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("80TL Americano");
            UcretList.Add(80);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("20TL Çay");
            UcretList.Add(20);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("100TL Çikolatalı Kurabiye");
            UcretList.Add(100);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("25TL Oralet");
            UcretList.Add(25);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("110TL Mocha");
            UcretList.Add(110);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("60TL Limonata");
            UcretList.Add(60);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("80TL Ice Latte");
            UcretList.Add(110);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("50TL Cola");
            UcretList.Add(50);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("20TL Soda");
            UcretList.Add(20);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("60TL Mocha");
            UcretList.Add(60);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("120TL Ice Mocha");
            UcretList.Add(120);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("110TL Frappe");
            UcretList.Add(110);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("450TL Serpme Kahvaltı");
            UcretList.Add(450);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("200TL Menemen");
            UcretList.Add(200);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("180TL Kavurmalı Tava Omlet");
            UcretList.Add(180);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("190TL Kahvaltı Tabağı");
            UcretList.Add(190);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = true;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;

            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = true;
            panel5.Enabled = false;
            panel6.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;

            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = true;
            panel6.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;

            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = true;
        }
        int toplamFiyat = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            panel1.Enabled = true;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("70TL Karışık Tost");
            UcretList.Add(70);
            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("65TL Sandiviç");
            UcretList.Add(190);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("180TL Sigara Böreği Tabağı");
            UcretList.Add(180);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("200TL Patates Kızartması Tabağı");
            UcretList.Add(200);

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult sorgu = MessageBox.Show("Sipariş Listenizi Sıfırlamak İstediğinize Emin Misiniz?"
                , "Uyarı"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);

            if(sorgu == DialogResult.Yes)
            {
                listBox1.Items.Clear();
                UcretList.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            List<int> secilenler = listBox1.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();

            
            foreach (int i in secilenler)
            {
                listBox1.Items.RemoveAt(i);   
                UcretList.RemoveAt(i);        
            }

            foreach (int i in UcretList)
            {
                toplamFiyat += i;
            }
            label8.Text = toplamFiyat.ToString() + "TL";
            toplamFiyat = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alınmıştır.", "Bilgilendirme" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            listBox1.Items.Clear();
            UcretList.Clear();

            label8.Text = "0TL";
        }
    }
}
