using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangiAyOldugunuBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            int sayi = Convert.ToInt16(textBox1.Text);
            switch(sayi)
            {
                case 1: listBox1.Items.Add("Ocak");break;
                case 2: listBox1.Items.Add("Şubat");break;
                case 3: listBox1.Items.Add("Mart");break;
                case 4: listBox1.Items.Add("Nisan");break;
                case 5: listBox1.Items.Add("Mayıs");break;
                case 6: listBox1.Items.Add("Haziran");break;
                case 7: listBox1.Items.Add("Temmuz");break;
                case 8: listBox1.Items.Add("Ağustos");break;
                case 9: listBox1.Items.Add("Eylül");break;
                case 10: listBox1.Items.Add("Ekim");break;
                case 11: listBox1.Items.Add("Kasım");break;
                case 12: listBox1.Items.Add("Aralık");break;
                default: listBox1.Items.Add("Girilen sayıya eşit ay bulunmamaktadır"); break;
            }
        }
    }
}
