using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "A95")
            {
                textBox1.Text = "2.00";
            }
            else if (comboBox1.Text == "A92")
            {
                textBox1.Text = "1.00";
            }
            else if(comboBox1.Text == "Diesel")
            {
                textBox1.Text = "0.60";
            }
        }
        



private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox4.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(textBox2.Text);
            switch (comboBox1.Text)
            {
                case "A92":
                    textBox3.Text = Convert.ToString(a * 1.0);
                    break;
                case "A95":
                    textBox3.Text = Convert.ToString(a * 2.0);
                    break;
                case "Diesel":
                    textBox3.Text = Convert.ToString(a * 0.60);
                    break;
            }


            double c;
            double d;


            c = Convert.ToDouble(textBox3.Text);


            double a1;
            double b1;
            double c1;
            double d1;


            b1 = Convert.ToDouble(textBox4.Text);
            c1 = Convert.ToDouble(textBox8.Text);
            d1 = Convert.ToDouble(textBox11.Text);

            double summcafe;
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                textBox6.Text = Convert.ToString((b1 * 4) + (c1 * 5) + (d1 * 3));
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox1.Checked)
            {
                textBox6.Text = Convert.ToString(b1 * 4);
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                textBox6.Text = Convert.ToString((b1 * 4) + (c1 * 5));
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox1.Checked && checkBox3.Checked)
            {
                textBox6.Text = Convert.ToString((b1 * 4) + (d1 * 3));
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox2.Checked)
            {
                textBox6.Text = Convert.ToString(c1 * 5);
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox2.Checked && checkBox3.Checked)
            {
                textBox6.Text = Convert.ToString((c1 * 5) + (d1 * 3));
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }
            else if (checkBox3.Checked)
            {
                textBox6.Text = Convert.ToString(d1 * 3);
                summcafe = Convert.ToDouble(textBox6.Text);
                textBox7.Text = Convert.ToString(c + summcafe);

            }

            else
            {
                textBox6.Text = Convert.ToString(0);
                textBox7.Text = Convert.ToString(c);
            }
            summcafe = Convert.ToDouble(textBox6.Text);
            textBox7.Text = Convert.ToString(c + summcafe);



        }
    }
}