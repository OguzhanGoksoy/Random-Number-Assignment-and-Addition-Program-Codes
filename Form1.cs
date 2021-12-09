using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void temizle()
        {
            listBox1.Items.Clear();
            ElemanSayısı.Text = "";
            sayılarınToplamı.Text = "";
            ListeyeEklText.Text = "";
        }

        void guncelle()
        {
            int toplam = 0;
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                toplam += Convert.ToInt32(listBox1.Items[i]);
                sayılarınToplamı.Text = toplam.ToString();
               
            }



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            temizle();

        }

        private void listeyiDoldur_Click(object sender, EventArgs e)
        {
            int a = 0; 
            Random rnd = new Random();

            for(a = 0;a<10;a++ )
            {
                listBox1.Items.Add(rnd.Next(0,20));
                ElemanSayısı.Text = (listBox1.Items.Count).ToString();
            }

            guncelle();
        }

        private void ListeTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void SecilenElemanSil_Click(object sender, EventArgs e)
        {
            try
            {
                int secim = listBox1.SelectedIndex;
                if (secim == -1)
                {
                    MessageBox.Show("Lütfen Sayı Seçiniz");
                    
                }
                else
                {
                    listBox1.Items.RemoveAt(secim);

                    int n = 0;
                    int aa = 0;
                    n = Convert.ToInt32(ElemanSayısı.Text);

                    aa = n - 1;
                    ElemanSayısı.Text = aa.ToString();
                    sayılarınToplamı.Text = 0.ToString();
                }
               
            }
            catch
            {
                MessageBox.Show("Lütfen Sayı Seçin");
               
            }
           
            ListeyeEklText.Text = "";
            guncelle();
        }

        private void listeyeEkle_Click(object sender, EventArgs e)
        {
            if (ListeyeEklText.Text == "")
            {
                MessageBox.Show("Sayı Giriniz");
            }
            else
            {
                listBox1.Items.Add(ListeyeEklText.Text);
                ListeyeEklText.Text = "";

                if (ElemanSayısı.Text == "")
                {
                    int n = 0;
                    int aa = 0;
                    ElemanSayısı.Text = aa.ToString();
                    n = Convert.ToInt32(ElemanSayısı.Text);

                    aa = n + 1;
                    ElemanSayısı.Text = aa.ToString();

                }

                else
                {
                    int n;

                    n = Convert.ToInt32(ElemanSayısı.Text);
                    n = n + 1;
                    ElemanSayısı.Text = n.ToString();
                }
                guncelle();
            }
        }
    }
}
