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
               

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Hideall();
                button1.Show();
                label1.Show();
                comboBox1.Show();
                pictureBox3.Show();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Hideall();
                button1.Show();
                label1.Show();
                comboBox1.Show();
                pictureBox4.Show();
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

            r1 = r1 + r2;
            label3.Text = Convert.ToString(r1);
        }
    }
}
