using System;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UstHesap u1 = new UstHesap();
            int sonuc = u1.Hesapla(Convert.ToInt32(textBox1.Text));
            textBox2.Text = sonuc.ToString();
        }
    }
}
