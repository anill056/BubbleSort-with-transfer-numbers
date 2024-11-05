using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace dizilerrr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(5);
            listBox1.Items.Add(1);
            listBox1.Items.Add(25);
            listBox1.Items.Add(75);
            listBox1.Items.Add(2);

        }

        private ICollection aktar(int[] dizi)
        {
            for(int i = 0; i<=dizi.Length-1; i++)
            {
                for(int j = i+1; j<=dizi.Length-1; j++)
                {
                    int temp;
                    if(dizi[i] > dizi[j])
                    {
                        temp = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
            return dizi; // ICOLLECTİON İNDEXLİ VERİLERİ BÜTÜN HALİNDE SIRALANMIŞ HALİNDE DÖNDÜRÜR.
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count;
            int[] yenidizi = new int[adet];

            for(int i = 0; i < adet;i++)
            {
                yenidizi[i] = Convert.ToInt32(listBox1.Items[i]);
            }

            

            foreach(int eleman in aktar(yenidizi))
            {
                MessageBox.Show(eleman.ToString());
            }
        }
    }
}
