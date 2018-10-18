using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hideall();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Hideall()
        {
            label1.Hide();
            button1.Hide();
            comboBox1.Hide();
            label2.Hide();
            button2.Hide();
            comboBox2.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            button3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            button4.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            button5.Hide();
            textBox10.Hide();
            textBox11.Hide();
            textBox12.Hide();
            textBox13.Hide();
            textBox14.Hide();
            button6.Hide();
        }
        

        private async void button1_Click_1(object sender, EventArgs e)
        {
            label1.Show();
            await Task.Delay(500);
            comboBox1.Show();
            await Task.Delay(250);
            comboBox1.Hide();
            await Task.Delay(500);
            comboBox1.Show();
            await Task.Delay(250);
            comboBox1.Hide();
            await Task.Delay(500);
            comboBox1.Show();

        }
        private void parellelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hideall();
            button1.Show();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            label2.Show();
            await Task.Delay(500);
            comboBox2.Show();
            await Task.Delay(250);
            comboBox2.Hide();
            await Task.Delay(500);
            comboBox2.Show();
            await Task.Delay(250);
            comboBox2.Hide();
            await Task.Delay(500);
            comboBox2.Show();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Hideall();
                button1.Show();
                label1.Show();
                comboBox1.Show();
                pictureBox1.Show();
                textBox1.Show();
                textBox2.Show();
                button3.Show();

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Hideall();
                button1.Show();
                label1.Show();
                comboBox1.Show();
                pictureBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox3.BringToFront();
                textBox4.BringToFront();
                textBox5.BringToFront();
                button4.Show();
               

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Hideall();
                button1.Show();
                label1.Show();
                comboBox1.Show();
                pictureBox3.Show();
                textBox6.Show();
                textBox7.Show();
                textBox8.Show();
                textBox9.Show();
                textBox6.BringToFront();
                textBox7.BringToFront();
                textBox8.BringToFront();
                textBox9.BringToFront();
                button5.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Hideall();
                button1.Show();
                label1.Show();
                comboBox1.Show();
                pictureBox4.Show();
                textBox10.Show();
                textBox11.Show();
                textBox12.Show();
                textBox13.Show();
                textBox14.Show();
                textBox10.BringToFront();
                textBox11.BringToFront();
                textBox12.BringToFront();
                textBox13.BringToFront();
                textBox14.BringToFront();
                button6.Show();
            }
            else
            {
                MessageBox.Show("Please select an option from the drop down menu!");
            }
        }

        private void seriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hideall();
            button1.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void parallelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hideall();
            button2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        
        {
            double r1 = Convert.ToDouble(textBox1.Text);
            double r2 = Convert.ToDouble(textBox2.Text);

            if (r1 > 0) 
                try
                {
                    if (r2 < 0)
                        MessageBox.Show("Dont be an idiot. Enter a positive number!");
                    else
                        r1 = r1 + r2;
                    label3.Text = Convert.ToString(r1);
                }
                catch
                {
                    MessageBox.Show("dont be an idiot. Type in a number!");
                }
            
            else
                MessageBox.Show("type in a positive number.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double r1 = Convert.ToDouble(textBox3.Text);
                double r2 = Convert.ToDouble(textBox4.Text);
                double r3 = Convert.ToDouble(textBox5.Text);

                r1 = r1 + r2 + r3;
                label3.Text = Convert.ToString(r1);
            }
            catch
            {
                MessageBox.Show("dont be an idiot. type in a number");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(textBox6.Text);
            double r2 = Convert.ToDouble(textBox7.Text);
            double r3 = Convert.ToDouble(textBox8.Text);
            double r4 = Convert.ToDouble(textBox9.Text);

            r1 = r1 + r2 + r3 + r4;
            label3.Text = Convert.ToString(r1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(textBox10.Text);
            double r2 = Convert.ToDouble(textBox11.Text);
            double r3 = Convert.ToDouble(textBox12.Text);
            double r4 = Convert.ToDouble(textBox13.Text);
            double r5 = Convert.ToDouble(textBox14.Text);
            r1 = r1 + r2 + r3 + r4 + r5;
            label3.Text = Convert.ToString(r1);
        }
    }
}
