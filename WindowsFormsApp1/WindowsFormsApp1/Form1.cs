using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int girilensayi;
            girilensayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(girilensayi);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] notlar = new int[listBox1.Items.Count];
           
            for(  int i=0; i < listBox1.Items.Count; i++)
            {
                notlar[i] = Int32.Parse(listBox1.Items[i].ToString());
                
            }
            Array.Sort(notlar);
            int toplam = 0;
            foreach (int sayi in notlar)
            {
                toplam = toplam + sayi;

            }
            label3.Text = (toplam / notlar.Length).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] notlar = new int[listBox1.Items.Count];
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                notlar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(notlar);
            label4.Text = notlar[notlar.Length - 1].ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] notlar = new int[listBox1.Items.Count];
            for(int i = 0; i < listBox1.Items.Count; i ++)
            {
                notlar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(notlar);

            label6.Text = notlar[0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] notlar = new int[listBox1.Items.Count];
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                notlar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }
            Array.Sort(notlar);

            foreach (int sayi in notlar)
            {
                if (sayi % 2 == 1)
                {
                    listBox3.Items.Add(sayi); 

                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] notlar = new int[listBox1.Items.Count];
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                notlar[i] = Int32.Parse(listBox1.Items[i].ToString());
            }

            Array.Sort(notlar);
            
            foreach (int sayi in notlar)
            {
                if (sayi % 2 ==0)
                {
                    listBox2.Items.Add(sayi);
                }
            }
        }
    }
}
