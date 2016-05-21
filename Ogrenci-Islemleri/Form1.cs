//Ödev3
//13253039
//Hilal MEMİŞ


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections;
namespace HW313253039
{
    public partial class Form1 : Form
    {
        ArrayList liste = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // Öğrenci ekleme Metodu
        {
            Ogrenci ogr = new Ogrenci(ogrnotextBox2.Text, ogrbolumtextBox3.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, ogradtextBox1.Text, ders1textBox4.Text, ders2textBox1.Text, ders3textBox2.Text);
            if (ogrnotextBox2.Text != "" && ogrbolumtextBox3.Text != "" && comboBox2.SelectedIndex != 0 && comboBox4.SelectedIndex!=0 && comboBox3.SelectedIndex != 0 && ogradtextBox1.Text != "" && ders1textBox4.Text != "" && ders2textBox1.Text != "" && ders3textBox2.Text != "")
                liste.Add(ogr);
            else
                MessageBox.Show("Bilgileri eksik girdiğiniz için ekleme işlemi yapılamadı...");

            ogradtextBox1.Text = "";         //ekleme işleminden sonra ekran temizlemek için
            ogrnotextBox2.Text = "";
            ogradtextBox1.Text = "";
            ogrbolumtextBox3.Text = "";
            comboBox4.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            ders1textBox4.Text = "";
            ders2textBox1.Text = "";
            ders3textBox2.Text = "";
            ogradtextBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1;       
        }

        private void button4_Click(object sender, EventArgs e)          //Arama yapılan  derse kaç kişinin kaydolduğu  ve sınav sonuç ortalamasını bulan metod
        {
            float toplam = 0;
            int sayac = 0;
            float ort = 0;
            if (FizikradioButton1.Checked == true)
            {

                for (int i = 0; i < liste.Count; i++)
                {
                    
                    if (((Ogrenci)liste[i]).ders1.Contains("Fizik"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                        sayac++;

                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Fizik"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                        sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Fizik"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                        sayac++;
                    }
                    
                }
                FizikradioButton1.Checked = false;         //işlem tamamlandıktan sonra radiobottondaki işaretlemenin kalkması için
            }
            else if (MatematikradioButton2.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1.Contains("Matematik"))    
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                        sayac++;

                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Matematik"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                        sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Matematik"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                        sayac++;
                    }
                    
                }
                MatematikradioButton2.Checked = false;
            }
            else if (KimyaradioButton3.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1.Contains("Kimya"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                        sayac++;

                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Kimya"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                        sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Kimya"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                        sayac++;
                    }
                   
                }
                KimyaradioButton3.Checked = false;
            }
            else if (GeometriradioButton4.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1.Contains("Geometri"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                        sayac++;

                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Geometri"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                        sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Geometri"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                        sayac++;
                    }
                    
                }
                GeometriradioButton4.Checked = false;
            }
            else if (BiyolojiradioButton5.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1.Contains("Biyoloji"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                        sayac++;

                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Biyoloji"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                        sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Biyoloji"))
                    {
                        toplam += int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                        sayac++;
                    }
                    
                }
                BiyolojiradioButton5.Checked = false;
            }
            

            ort = toplam / sayac;
            listBox10.Items.Add("Öğrenci sayısı :"+sayac);
            listBox10.Items.Add("Ortalama :"+ort);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void button6_Click(object sender, EventArgs e)        //seçilen ders için 60 dan küçük not alanların numaraları ve isimleri 
        {

            if (FizikradioButton6.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Fizik") && int.Parse(((Ogrenci)liste[i]).ders1sonuc) < 60 || ((Ogrenci)liste[i]).ders2.Contains("Fizik") &&
                        int.Parse(((Ogrenci)liste[i]).ders2sonuc) < 60 || ((Ogrenci)liste[i]).ders3.Contains("Fizik") && int.Parse(((Ogrenci)liste[i]).ders3sonuc) < 60)
                    {
                        listBox1.Items.Add("No: " + ((Ogrenci)liste[i]).ogrno + " " + "Ad: " + ((Ogrenci)liste[i]).ad);
                    }

                }
                if (liste.Count == 0)
                {
                    MessageBox.Show("Öğrenci eklemelisiniz");
                }
                FizikradioButton6.Checked = false;
            }
            else if (MatematikradioButton7.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1.Contains("Matematik") && int.Parse(((Ogrenci)liste[i]).ders1sonuc) < 60 || ((Ogrenci)liste[i]).ders2.Contains("Matematik") && int.Parse(((Ogrenci)liste[i]).ders2sonuc) < 60 || ((Ogrenci)liste[i]).ders3.Contains("Matematik") && int.Parse(((Ogrenci)liste[i]).ders3sonuc) < 60)
                    {
                        listBox1.Items.Add("No: " + ((Ogrenci)liste[i]).ogrno + " " + "Ad: " + ((Ogrenci)liste[i]).ad);
                    }

                }
                if (liste.Count == 0)
                {
                    MessageBox.Show("Öğrenci eklemelisiniz");
                }
                MatematikradioButton7.Checked = false;
            }
            else if (KimyaradioButton8.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1.Contains("Kimya") && int.Parse(((Ogrenci)liste[i]).ders1sonuc) < 60 || ((Ogrenci)liste[i]).ders2.Contains("Kimya") && int.Parse(((Ogrenci)liste[i]).ders2sonuc) < 60 || ((Ogrenci)liste[i]).ders3.Contains("Kimya") && int.Parse(((Ogrenci)liste[i]).ders3sonuc) < 60)
                    {
                        listBox1.Items.Add("No: " + ((Ogrenci)liste[i]).ogrno + " " + "Ad: " + ((Ogrenci)liste[i]).ad);

                    }

                }
                if (liste.Count == 0)
                {
                    MessageBox.Show("Öğrenci eklemelisiniz");
                }
                KimyaradioButton8.Checked = false;
            }
            else if (GeometriradioButton9.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1.Contains("Geometri") && int.Parse(((Ogrenci)liste[i]).ders1sonuc) < 60 || ((Ogrenci)liste[i]).ders2.Contains("Geometri") && int.Parse(((Ogrenci)liste[i]).ders2sonuc) < 60 || ((Ogrenci)liste[i]).ders3.Contains("Geometri") && int.Parse(((Ogrenci)liste[i]).ders3sonuc) < 60)
                    {
                        listBox1.Items.Add("No: " + ((Ogrenci)liste[i]).ogrno + " " + "Ad: " + ((Ogrenci)liste[i]).ad);

                    }

                }
                if (liste.Count == 0)
                {
                    MessageBox.Show("Öğrenci eklemelisiniz");
                }
                GeometriradioButton9.Checked = false;
            }
            else if (BiyolojiradioButton10.Checked == true)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    if (((Ogrenci)liste[i]).ders1.Contains("Biyoloji") && int.Parse(((Ogrenci)liste[i]).ders1sonuc) < 60 || ((Ogrenci)liste[i]).ders2.Contains("Biyoloji") && int.Parse(((Ogrenci)liste[i]).ders2sonuc) < 60 || ((Ogrenci)liste[i]).ders3.Contains("Biyoloji") && int.Parse(((Ogrenci)liste[i]).ders3sonuc) < 60)
                    {
                        listBox1.Items.Add("No: " + ((Ogrenci)liste[i]).ogrno + " " + "Ad: " + ((Ogrenci)liste[i]).ad);

                    }

                }
                if (liste.Count == 0)
                {
                    MessageBox.Show("Öğrenci eklemelisiniz");
                }
                BiyolojiradioButton10.Checked = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)    //En yüksek sınav sonucunu veren metod
        {
            tabControl1.SelectedIndex = 3;
            int enyüksekNot = 0;
            int enyüksekNotMat = 0;
            int enyüksekNotKimya = 0;
            int enyüksekNotGeo = 0;
            int enyüksekNotBioloji = 0;
            int sayac = 0;
            if (liste.Count == 0)
            {
                MessageBox.Show("Öğrenci eklemelisiniz");
            }
            else
            {
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Fizik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) > enyüksekNot)
                            enyüksekNot = int.Parse(((Ogrenci)liste[i]).ders1sonuc);

                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Fizik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) > enyüksekNot)
                            enyüksekNot = int.Parse(((Ogrenci)liste[i]).ders2sonuc);

                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Fizik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) > enyüksekNot)
                            enyüksekNot = int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                    }

                }
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Fizik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) == enyüksekNot)
                            sayac++;

                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Fizik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) == enyüksekNot)
                            sayac++;

                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Fizik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) == enyüksekNot)
                            sayac++;

                    }

                }


                for (int i = 0; i < sayac; i++)           //birden fazla yüksek not varsa o kadar yazdırmak için
                {
                    listBox2.Items.Add(enyüksekNot);
                }
                sayac = 0;


                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Matematik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) > enyüksekNotMat)
                            enyüksekNotMat = int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Matematik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) > enyüksekNotMat)
                            enyüksekNotMat = int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Matematik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) > enyüksekNotMat)
                            enyüksekNotMat = int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                    }

                }
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Matematik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) == enyüksekNotMat)
                            sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Matematik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) == enyüksekNotMat)
                            sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Matematik"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) == enyüksekNotMat)
                            sayac++;
                    }

                }
                for (int i = 0; i < sayac; i++)
                {
                    listBox3.Items.Add(enyüksekNotMat);
                }
                sayac = 0;
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Kimya"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) > enyüksekNotKimya)
                            enyüksekNotKimya = int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Kimya"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) > enyüksekNotKimya)
                            enyüksekNotKimya = int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Kimya"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) > enyüksekNotKimya)
                            enyüksekNotKimya = int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                    }

                }
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Kimya"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) == enyüksekNotKimya)
                            sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Kimya"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) == enyüksekNotKimya)
                            sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Kimya"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) == enyüksekNotKimya)
                            sayac++;
                    }

                }
                for (int i = 0; i < sayac; i++)
                {
                    listBox4.Items.Add(enyüksekNotKimya);
                }
                sayac = 0;
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Geometri"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) > enyüksekNotGeo)
                            enyüksekNotGeo = int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Geometri"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) > enyüksekNotGeo)
                            enyüksekNotGeo = int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Geometri"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) > enyüksekNotGeo)
                            enyüksekNotGeo = int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                    }

                }
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Geometri"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) == enyüksekNotGeo)
                            sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Geometri"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) == enyüksekNotGeo)
                            sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Geometri"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) == enyüksekNotGeo)
                            sayac++;
                    }

                }
                for (int i = 0; i < sayac; i++)
                {
                    listBox5.Items.Add(enyüksekNotGeo);
                }
                sayac = 0;

                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Biyoloji"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) > enyüksekNotBioloji)
                            enyüksekNotBioloji = int.Parse(((Ogrenci)liste[i]).ders1sonuc);
                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Biyoloji"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) > enyüksekNotBioloji)
                            enyüksekNotBioloji = int.Parse(((Ogrenci)liste[i]).ders2sonuc);
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Biyoloji"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) > enyüksekNotBioloji)
                            enyüksekNotBioloji = int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                    }

                }
                for (int i = 0; i < liste.Count; i++)
                {

                    if (((Ogrenci)liste[i]).ders1.Contains("Biyoloji"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders1sonuc) == enyüksekNotBioloji)
                            sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders2.Contains("Biyoloji"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders2sonuc) == enyüksekNotBioloji)
                            sayac++;
                    }
                    else if (((Ogrenci)liste[i]).ders3.Contains("Biyoloji"))
                    {
                        if (int.Parse(((Ogrenci)liste[i]).ders3sonuc) == enyüksekNotBioloji)
                            sayac++;
                    }

                }
                for (int i = 0; i < sayac; i++)
                {
                    listBox6.Items.Add(enyüksekNotBioloji);
                }

            }
        }

        private void button8_Click(object sender, EventArgs e)            //Genel sınav ortalamalarına göre küçükten büyüğe sıralı olarak öğrenci numaralarını, isimlerini  ve sınav sonuçlarını görüntüleyen metod
        {
            tabControl1.SelectedIndex = 4;
            float[] dizi = new float[liste.Count];
            float toplam;
            float enkücük;
            if (liste.Count == 0)
            {
                MessageBox.Show("Öğrenci eklemelisiniz");
            }
            else
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    toplam = 0;
                    toplam = int.Parse(((Ogrenci)liste[i]).ders1sonuc) + int.Parse(((Ogrenci)liste[i]).ders2sonuc) + int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                    dizi[i] = (float)toplam / 3;

                }

                for (int i = dizi.Length; i > 0; i--)
                {
                    enkücük = (float)dizi[0];
                    for (int j = 0; j < dizi.Length; j++)
                    {
                        if (enkücük > dizi[j])
                            enkücük = dizi[j];
                    }
                    for (int j = 0; j < dizi.Length; j++)
                    {
                        if (dizi[j] == enkücük)
                        {
                            if (dizi[j] < 101)
                            {
                                listBox7.Items.Add(liste[j].ToString());
                                dizi[j] = 101;

                            }
                        }
                    }
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void button10_Click(object sender, EventArgs e)       //İsme ve numaraya göre öğrenci arama işlemini ve Arama sonucunda öğrencinin aldığı dersler ve ilgli notlar ile öğrecinin ortalamasını listeyen metod
        {
            float[] dizi = new float[liste.Count];
            float toplam;
            for (int i = 0; i < liste.Count; i++)
            {
                if (textBox1.Text.Contains(((Ogrenci)liste[i]).ad)==true && textBox2.Text.Contains(((Ogrenci)liste[i]).ogrno)==true)
                {
                    toplam = 0;
                    toplam = int.Parse(((Ogrenci)liste[i]).ders1sonuc) + int.Parse(((Ogrenci)liste[i]).ders2sonuc) + int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                    dizi[i] = (float)toplam / 3;
                    listBox8.Items.Add(((Ogrenci)liste[i]).ders1 + " Sonuç = " + ((Ogrenci)liste[i]).ders1sonuc);
                    listBox8.Items.Add(((Ogrenci)liste[i]).ders2 + " Sonuç = " + ((Ogrenci)liste[i]).ders2sonuc);
                    listBox8.Items.Add(((Ogrenci)liste[i]).ders3 + " Sonuç = " + ((Ogrenci)liste[i]).ders3sonuc);
                    listBox8.Items.Add("Sınav Ortalaması= " + dizi[i]);
                }
               
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
            textBox3.Focus();
        }

        private void button12_Click(object sender, EventArgs e)        //İsmi girilen bölümde kaç öğrenci bulunduğunu ve bölüm not ortalamasını bulan metod
        {
            
            float ort=0;
            int sayac = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                if (textBox3.Text.Contains(((Ogrenci)liste[i]).bolum))
                {
                    ort += int.Parse(((Ogrenci)liste[i]).ders1sonuc) + int.Parse(((Ogrenci)liste[i]).ders2sonuc) + int.Parse(((Ogrenci)liste[i]).ders3sonuc);
                    sayac++;
                }
            }
            listBox9.Items.Add("Bölüm ortalaması = "+ort/(sayac*3));
            listBox9.Items.Add("Bu bölümdeki öğrenci sayısı = "+sayac);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)    //combobox ta seçilen elemanın tekrar seçilmemesi için kullanılan metod
        {
            try
            {
                if (comboBox2.SelectedIndex.ToString() == comboBox3.SelectedIndex.ToString() || comboBox2.SelectedIndex.ToString() == comboBox4.SelectedIndex.ToString())
                    comboBox2.SelectedIndex = 0;

            }
            catch (Exception)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)        
        {
            try
            {
                if (comboBox3.SelectedIndex.ToString() == comboBox2.SelectedIndex.ToString() || comboBox3.SelectedIndex.ToString() == comboBox2.SelectedIndex.ToString())
                    comboBox3.SelectedIndex = 0;

            }
            catch (Exception)
            {

            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.SelectedIndex.ToString() == comboBox2.SelectedIndex.ToString() || comboBox4.SelectedIndex.ToString() == comboBox3.SelectedIndex.ToString())
                {
                   
                    comboBox4.SelectedIndex = 0;
                   
                }

            }
            catch (Exception)
            {
 
            } 
        }
        private void ogrnotextBox2_TextChanged(object sender, EventArgs e)       //ogrenci numarasının sadece sayı değeri almasını sağlar
        {
            try
            {
                int sayi1 = Convert.ToInt32(ogrnotextBox2.Text);
            }
            catch (Exception sorun)
            {
                if (ogrnotextBox2.Text != "")
                {
                    MessageBox.Show("Hata:" + sorun.Message);
                    ogrnotextBox2.Clear();
                }
            }
        }

        private void ders1textBox4_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
               int sayi1 = Convert.ToInt32(ders1textBox4.Text);
               if (int.Parse(ders1textBox4.Text) > 100 )
               {
                   MessageBox.Show("0 ve 100 arasında not ekleyebilirsiniz");
                   ders1textBox4.Clear();

               }
                
            }
            catch (Exception sorun)
            {
                if (ders1textBox4.Text != "")
                {
                MessageBox.Show("Hata:" + sorun.Message);
                ders1textBox4.Clear();
                }
                
            }
        }

        private void ders2textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(ders2textBox1.Text);
                if (int.Parse(ders2textBox1.Text) > 100 )
                {
                    MessageBox.Show("0 ve 100 arasında not ekleyebilirsiniz");
                    ders2textBox1.Clear();

                }
            }
            catch (Exception sorun)
            {
                if (ders2textBox1.Text != "")
                {
                    MessageBox.Show("Hata:" + sorun.Message);
                    ders2textBox1.Clear();
                    
                }
            }
        }

        private void ders3textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(ders3textBox2.Text);
                if (int.Parse(ders3textBox2.Text) > 100  )
                {
                    MessageBox.Show("0 ve 100 arasında not ekleyebilirsiniz" );
                    ders3textBox2.Clear();
 
                }
            }
            
            catch (Exception sorun)
            {
                if (ders3textBox2.Text != "")
                {
                    MessageBox.Show("Hata:" + sorun.Message);
                    ders3textBox2.Clear();
                }
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 8;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button32_Click(object sender, EventArgs e)
        {
            listBox8.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            listBox10.Items.Clear();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            listBox9.Items.Clear();
            textBox3.Clear();
            textBox3.Focus();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            listBox7.Items.Clear();
        }

       
        
           



    }

}

