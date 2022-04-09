using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] dizi = { "Sema ", "Beyza ", "Mehmet ", "Oktay ", "Sedat " };
        int[] miktar = { 3900, 3800, 7600, 4500, 5500 };
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < dizi.Length; i++)
            {
                listBox1.Items.Add(dizi[i] + miktar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int kayit = listBox1.Items.Count;
                MessageBox.Show("Toplam Kayıt Sayısı:" + kayit.ToString());
            }
            else { MessageBox.Show("Kayıt Bulunamadı."); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int toplam = 0;
                for (int i = 0; i < miktar.Length; i++)
                {
                    toplam += miktar[i];
                }
                MessageBox.Show("Toplam Miktar:" + toplam.ToString());
            }
            else { MessageBox.Show("Kayıt Bulunamadı."); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.ClearSelected();
                int index = Array.IndexOf(miktar, miktar.Min());
                listBox1.SelectedIndex = index;
            }
            else { MessageBox.Show("Kayıt Bulunamadı."); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.ClearSelected();
                //indexof dizideki indexi belirler
                int index = Array.IndexOf(miktar, miktar.Max());
                listBox1.SelectedIndex = index;
            }
            else { MessageBox.Show("Kayıt Bulunamadı."); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            //listbox çoklu seçim
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < miktar.Length; i++)
                {
                    if (miktar[i] <= 4000)
                    {
                        listBox1.SelectedIndex = i;
                    }
                }
            }
            else { MessageBox.Show("Kayıt Bulunamadı."); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < miktar.Length; i++)
                {

                    if ((miktar[i] < 7000) && (miktar[i] > 5000))
                    {
                        //farklı bir seçim yöntemi selectindex ile aynı
                        listBox1.SetSelected(i, true);
                    }

                }
            }
            else { MessageBox.Show("Kayıt Bulunamadı."); }

        }
        private void button9_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
                miktar[3] += 300;
                //buton1 e tıkla
                button1_Click(sender, e);
                listBox1.ClearSelected();
                listBox1.SelectedIndex = 3;
            }
            else { MessageBox.Show("Kayıt Bulunamadı."); }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            if (listBox1.Items.Count > 0)
            {
                //indexof dizideki hangi indexte olduğumuzu belirler
                int index = Array.IndexOf(miktar, miktar.Last());
                listBox1.SelectedIndex = index;
                MessageBox.Show(dizi.Last());
            }
            else { MessageBox.Show("Kayıt Bulunamadı."); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (listBox1.Items[i].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        listBox1.SetSelected(i, true);
                    }
                }
            }
            else { MessageBox.Show("ListBoxda Değer Yok."); }
        }
    }
}