using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library;
namespace Kutuphaneni_Olustur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 nesne = new Class1();
            double a, b;
            char c='0';
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            if (checkedListBox1.SelectedIndex == 0)
                c = '*';
            else if (checkedListBox1.SelectedIndex == 1)
                c = '/';
            else if (checkedListBox1.SelectedIndex == 2)
                c = '+';
            else if (checkedListBox1.SelectedIndex == 3)
                c = '-';

            textBox3.Text = nesne.Hesapla(a, b, c).ToString();

        }
    }
}
