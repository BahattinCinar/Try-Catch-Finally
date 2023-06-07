using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace kullanıcının_belirlediği_aralıklarda_toplam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i, baslangic, toplam = 0, kactane, sayi, hata = 0;
                byte bitis;

                baslangic = int.Parse(textBox1.Text);
                bitis = byte.Parse(textBox2.Text);
                kactane = int.Parse(textBox3.Text);

                for (i = 1; i <= kactane;)
                {
                    sayi = int.Parse(Interaction.InputBox("sayi Giriniz", "ekran", "buraya", 250, 250));
                    if (sayi > bitis || sayi < baslangic)
                    {
                        MessageBox.Show("hatali sayi girdiniz. Lutfen duzeltin");
                        hata++;
                        if (hata == 3)
                        {
                            MessageBox.Show("3 hata yaptin");
                            break;
                        }
                    }
                    else
                    {
                        toplam = toplam + sayi;
                        listBox1.Items.Add("girilen sayi= " + sayi);
                        i++;
                    }
                }
                listBox1.Items.Add("sayilarin toplami = " + toplam);

            }
            catch (FormatException error1)
            {
                MessageBox.Show("Tam sayi gireceksiniz");
                MessageBox.Show(error1.Message);
            }
            catch (OverflowException error2)
            {
                MessageBox.Show("0-255 arasi sayi girisi yapiniz");
                MessageBox.Show(error2.Message);
            }
            catch
            {
                MessageBox.Show("Beklenmedik hata error3");
            }
            finally 
            {
                MessageBox.Show("Bu mesaj kutusu kapatildiginda uygulama sifirlanacak !!!!");
                listBox1.Items.Clear();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
