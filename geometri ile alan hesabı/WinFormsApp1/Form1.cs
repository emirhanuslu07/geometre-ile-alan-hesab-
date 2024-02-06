using System.Reflection.Metadata;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Hesaplama hesaplama = new Hesaplama();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_hesapla_Click(object sender, EventArgs e)
        {
            Hesaplama islem = new Hesaplama();
            int kenar = Int32.Parse(textBox4.Text);
            int sonuc = islem.alanhesapla(kenar);
            label6.Text = sonuc.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 0;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            TabControl1.SelectedIndex = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesaplama islem = new Hesaplama();

        }   

        private void button2_Click(object sender, EventArgs e)
        {
            Hesaplama islem = new Hesaplama();
            int taban = Int32.Parse(textBox9.Text);
            int yükseklik = Int32.Parse(textBox8.Text);
            double sonuc = islem.alanhesapla(taban, yükseklik);
            label7.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hesaplama islem = new Hesaplama();
            int kenar = Int32.Parse(textBox10.Text);
            double sonuc = islem.alanhesapla(kenar);
            label12.Text = sonuc.ToString();

        }
    }
}