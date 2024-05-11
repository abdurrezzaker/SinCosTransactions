namespace NTPodev01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] geçmiþ = new string[50];
        int index = 0;
        Matematik matematik = new Matematik();
        private void button3_Click(object sender, EventArgs e)
        {
            string girilen = textBox1.Text;
            geçmiþ[index] = textBox1.Text;
            index++;
            geçmiþ[index] = textBox1.Text;
            index++;
            girilen = girilen.Trim();
            int[] girilenDizi = Array.ConvertAll(girilen.Split(','), int.Parse);
            int sonuc = matematik.MaxBul(girilenDizi);
            textBox1.Text = sonuc.ToString();
            geçmiþ[index] = textBox1.Text;
            index++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double gDeger = Convert.ToDouble(textBox1.Text);
            geçmiþ[index] = textBox1.Text;
            index++;
            gDeger = matematik.KarekökBul(gDeger);
            textBox1.Text = gDeger.ToString();
            geçmiþ[index] = textBox1.Text;
            index++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g = Convert.ToInt32(textBox1.Text);
            geçmiþ[index] = textBox1.Text;
            index++;
            g = matematik.MutlakBul(g);
            textBox1.Text = g.ToString();
            geçmiþ[index] = textBox1.Text;
            index++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(textBox1.Text);
            geçmiþ[index] = textBox1.Text;
            index++;
            v = matematik.SinBul(v);
            textBox1.Text = v.ToString();
            geçmiþ[index] = textBox1.Text;
            index++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(textBox1.Text);
            geçmiþ[index] = textBox1.Text;
            index++;
            v = matematik.cosBul(v);
            textBox1.Text = v.ToString();
            geçmiþ[index] = textBox1.Text;
            index++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SinAndCosForm sAndCosForm = new SinAndCosForm();
            int isaret;
            int baslangic = Convert.ToInt32(textBox2.Text);
            int bitis = Convert.ToInt32(textBox3.Text);

            if (radioButton1.Checked)
            {
                radioButton2.Enabled = false;
                isaret = 0;
                sAndCosForm.SinyalCiz(baslangic, bitis, isaret);
                sAndCosForm.ShowDialog();

            }
            else if (radioButton2.Checked)
            {
                radioButton1.Enabled = false;
                isaret = 1;
                sAndCosForm.SinyalCiz(baslangic, bitis, isaret);
                sAndCosForm.ShowDialog();
            }
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                
                textBox1.Text = geçmiþ[index];
                index--;

            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= 0)
            {
                
                textBox1.Text = geçmiþ[index];
            }
            
        }
    }
}
