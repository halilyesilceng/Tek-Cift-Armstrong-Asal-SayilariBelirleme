using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;

namespace TekCİftArmstrongAsal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void EkraniHazirla()
        {
            mtxtBaslangic.Text = "1";
            mtxtBitis.Text = "10000";
            mtxtBaslangic.Focus();
        }
        Boolean Dogrula(int baslangic, int bitis)
        {
            if (bitis > baslangic)
            {
                return true;
            }
            else
            {
                MessageBox.Show("İşlem Başarısız...");
                return false;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ntfBildirim.ShowBalloonTip(30000);
          
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            BigInteger tekCarpim = 1, ciftCarpim = 1;

            double ciftToplam = 0, tekToplam = 0;
            int baslangic = Convert.ToInt32(mtxtBaslangic.Text);
            int bitis = Convert.ToInt32(mtxtBitis.Text);

            Dogrula(baslangic, bitis);
            if (tbKontrol.SelectedIndex == 0)
            {

                lwTeksayi.Items.Clear();
                for (int i = baslangic; i < bitis; i++)
                {

                    if ((i % 2) != 0)
                    {
                        tekToplam += i;
                        tekCarpim *= i;
                        lwTeksayi.Items.Add(i.ToString());

                    }

                    txtTekToplam.Text = tekToplam.ToString();
                    txtTekCarpim.Text = tekCarpim.ToString();
                }
            }
            else if (tbKontrol.SelectedIndex == 1)
            {




                lwCiftSayi.Items.Clear();
                for (int m = baslangic; m < bitis; m++)
                {

                    if ((m % 2) == 0)
                    {
                        ciftToplam += m;
                        ciftCarpim *= m;
                        lwCiftSayi.Items.Add(m.ToString());

                    }


                    txtCiftToplam.Text = ciftToplam.ToString();

                    txtCiftCarpim.Text = ciftCarpim.ToString();
                }
            }
            else if (tbKontrol.SelectedIndex == 2)
            {


                lwAsalSayi.Items.Clear();
                int asalToplam = 0, sayac = 0;
                BigInteger asalCarpim = 1;
                for (int j = baslangic; j < bitis; j++)
                {

                    for (int k = 2; k < j; k++)
                    {
                        if ((j % k) == 0 || j == 1)
                        {
                            sayac++;
                        }

                    }
                    if (sayac == 0)
                    {
                        asalToplam += j;
                        asalCarpim *= j;
                        txtAsalToplam.Text = asalToplam.ToString();
                        txtAsalCarpim.Text = asalCarpim.ToString();
                        lwAsalSayi.Items.Add(j.ToString());
                    }

                    sayac = 0;

                }
            }
            else if (tbKontrol.SelectedIndex == 3)
            {


                lwArmstrongSayi.Items.Clear();
                int armstrongToplam = 0;
                BigInteger armstrongCarpim = 1;




                for (int i = baslangic; i <= bitis; i++)
                {
                    int basamakDeger = 0, basamakSayisi = 0;
                    int temp;

                    double sonuc = 0;

                    temp = i;


                    while (temp != 0)
                    {
                        basamakSayisi++;

                        temp = temp / 10;
                    }

                    temp = i;

                    while (temp != 0)
                    {
                        basamakDeger = temp % 10;
                        sonuc = sonuc + Math.Pow((double)basamakDeger, (double)basamakSayisi);
                        temp = temp / 10;
                    }

                    if (i == sonuc)
                    {
                        armstrongCarpim *= i;
                        armstrongToplam += i;
                        lwArmstrongSayi.Items.Add(" " + i);


                    }


                }
                txtArmstrongCarpim.Text = armstrongCarpim.ToString();
                txtArmstrongToplam.Text = armstrongToplam.ToString();


            }
          
            using (StreamWriter yazici = new StreamWriter(@"log.txt"))
            {
                foreach (ListViewItem item in lwTeksayi.Items)
                {
                    yazici.WriteLine(item.Text);
                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                        yazici.Write(item.SubItems[i].Text);
                    }
                }
            }
            using (StreamWriter yazici = new StreamWriter(@"log.txt"))
            {
                foreach (ListViewItem item in lwCiftSayi.Items)
                {
                    yazici.WriteLine(item.Text);
                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                        yazici.Write(item.SubItems[i].Text);
                    }
                }
            }

            using (StreamWriter yazici = new StreamWriter(@"log.txt"))
            {
                foreach (ListViewItem item in lwAsalSayi.Items)
                {
                    yazici.WriteLine(item.Text);
                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                       yazici.Write(item.SubItems[i].Text);
                    }
                }
            }
            using (StreamWriter yazici = new StreamWriter(@"log.txt"))
            {
                foreach (ListViewItem item in lwArmstrongSayi.Items)
                {
                    yazici.WriteLine(item.Text);
                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                        yazici.Write(item.SubItems[i].Text);
                    }
                }
            }
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if ((tbKontrol.SelectedIndex) != 0)
            {
                tbKontrol.SelectedIndex -= 1;
            }
            else
            {
                MessageBox.Show(" Geri Gidilecek Bir Tab Bulunmuyor...Lütfen İleri Tuşunu Kullanınız");
            }
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            if ((tbKontrol.SelectedIndex) <= 3)
            {
                tbKontrol.SelectedIndex += 1;
            }
            else
            {
                MessageBox.Show("İlerlenecek Bir Tab Bilgisi Yok... Lütfen Geri Tuşunu Kullanınız");
            }
        }

        private void mtxtBaslangic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)

                )
            {
                e.Handled = true;
            }
        }

        private void mtxtBitis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar) ||
                char.IsSymbol(e.KeyChar) ||
                char.IsWhiteSpace(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar)

                )
            {
                e.Handled = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            EkraniHazirla();
        }
    }
}
