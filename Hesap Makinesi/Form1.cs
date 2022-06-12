namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        static int birinciSayi;
        static string islem;
        static int sonuc;
        static bool hafiza = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
                textBox1.Text += "0";
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            birinciSayi = 0;
            sonuc = 0;
            islem = "";
            hafiza = false;
        }

        private void bArti_Click(object sender, EventArgs e)
        {
            if (!hafiza)
            {
                birinciSayi = int.Parse(textBox1.Text);
                label1.Text = textBox1.Text + "+";
                textBox1.Clear();
                hafiza = true;
                islem = "arti";
            }
            else
            {
                label1.Text = "";
                sonuc = birinciSayi + int.Parse(textBox1.Text);
                birinciSayi = sonuc;
                label1.Text += sonuc + "+";
                textBox1.Clear();
                textBox1.Text = sonuc.ToString();
                hafiza = false;
            }
        }

        private void sEsit_Click(object sender, EventArgs e)
        {
            if(islem == "arti")
            {
                sonuc = birinciSayi + int.Parse(textBox1.Text);
                label1.Text = birinciSayi +"+"+ textBox1.Text+"=";
                textBox1.Clear();
                textBox1.Text = sonuc.ToString();
                hafiza = false;
            }
            else if(islem == "eksi")
            {
                sonuc = birinciSayi - int.Parse(textBox1.Text);
                label1.Text = birinciSayi + "-" + textBox1.Text + "=";
                textBox1.Clear();
                textBox1.Text = sonuc.ToString();
                hafiza = false;
            }
            else if (islem == "carp")
            {
                sonuc = birinciSayi * int.Parse(textBox1.Text);
                label1.Text = birinciSayi + "x" + textBox1.Text + "=";
                textBox1.Clear();
                textBox1.Text = sonuc.ToString();
                hafiza = false;
            }
            else if (islem == "bol")
            {
                sonuc = birinciSayi / int.Parse(textBox1.Text);
                label1.Text = birinciSayi + "/" + textBox1.Text + "=";
                textBox1.Clear();
                textBox1.Text = sonuc.ToString();
                hafiza = false;
            }

        }

        private void bEksi_Click(object sender, EventArgs e)
        {
            if (!hafiza)
            {
                birinciSayi = int.Parse(textBox1.Text);
                label1.Text = textBox1.Text + "-";
                textBox1.Clear();
                hafiza = true;
                islem = "eksi";
            }
            else
            {
                label1.Text = "";
                sonuc = birinciSayi + int.Parse(textBox1.Text);
                birinciSayi = sonuc;
                label1.Text += sonuc + "-";
                textBox1.Clear();
                textBox1.Text = sonuc.ToString();
                hafiza = false;
            }
        }

        private void bCarp_Click(object sender, EventArgs e)
        {
            if (!hafiza)
            {
                birinciSayi = int.Parse(textBox1.Text);
                label1.Text = textBox1.Text + "x";
                textBox1.Clear();
                hafiza = true;
                islem = "carp";
            }
            else
            {
                label1.Text = "";
                sonuc = birinciSayi + int.Parse(textBox1.Text);
                birinciSayi = sonuc;
                label1.Text += sonuc + "x";
                textBox1.Clear();
                textBox1.Text = sonuc.ToString();
                hafiza = false;
            }
        }

        private void bBol_Click(object sender, EventArgs e)
        {
            if (!hafiza)
            {
                birinciSayi = int.Parse(textBox1.Text);
                label1.Text = textBox1.Text + "/";
                textBox1.Clear();
                hafiza = true;
                islem = "bol";
            }
            else
            {
                label1.Text = "";
                sonuc = birinciSayi + int.Parse(textBox1.Text);
                birinciSayi = sonuc;
                label1.Text += sonuc + "/";
                textBox1.Clear();
                textBox1.Text = sonuc.ToString();
                hafiza = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}