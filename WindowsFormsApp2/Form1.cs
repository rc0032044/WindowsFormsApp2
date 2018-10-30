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


        private void Hideall()
        {
/*this is a method that will hide all user interface elements and enabling me 
 * to only show what is needed by the user*/
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
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            button7.Hide();
            textBox15.Hide();
            textBox16.Hide();
            textBox17.Hide();
            textBox18.Hide();
            textBox19.Hide();
            button8.Hide();
            textBox20.Hide();
            textBox21.Hide();
            textBox22.Hide();
            textBox23.Hide();
            button9.Hide();
            textBox24.Hide();
            textBox25.Hide();
            textBox26.Hide();
            textBox27.Hide();
            textBox28.Hide();
            button10.Hide();
        }

        private void seriesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         /* this code is for hiding all elements and only showing button1 when 
          * series is selected from the drop down menu*/
			Hideall();
            button1.Show();
        }


        private async void button1_Click_1(object sender, EventArgs e)
        {
/* this code is for the formulae for the calculation selected by the user to
 * show up in a label when button1 is clicked*/

//this code also makes combobox1 flash twice so that the user knows to select a value from the index

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

private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
			/*this code is for what element a shown when different index's are selected from the combobox*/

            if (comboBox1.SelectedIndex == 0)
            {
				/*this code will hide all element and only show what is needed by the user when
				 * they select the calculatore for series circuit with 2 resistors*/

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
				/*this code will hide all element and only show what is needed by the user when
				 * they select the calculatore for series circuit with 3 resistors*/
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
				/*this code will hide all element and only show what is needed by the user when
				 * they select the calculatore for series circuit with 4 resistors*/
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
				/*this code will hide all element and only show what is needed by the user when
				 * they select the calculatore for series circuit with 5 resistors*/

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
				/*this code is for showing a message to the user if they
				 * dont select anything from the combobox*/

                MessageBox.Show("Please select an option from the drop down menu!");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
/* this code is for the formulae for the calculation selected by the user to
 * show up in a label when button2 is clicked*/

//this code also makes combobox2 flash twice so that the user knows to select a value from the index
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

// Series circuit calculate button code //
        private void button3_Click(object sender, EventArgs e)

        {
			/* this code converts strings textboxes 1 & 2 into doubles*/
			
            double r1 = Convert.ToDouble(textBox1.Text);
            double r2 = Convert.ToDouble(textBox2.Text);

            r1 = r1 + r2;

            label3.Text = Convert.ToString(r1);
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
// Series circuit numerical restriction //

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (isNum(e))
			{
				e.Handled = false;
			}

			else
			{
				e.Handled = true;
			}
		}

		private static bool isNum(KeyPressEventArgs e)
		{
			return (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.' || e.KeyChar == 8;
		}

		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }
            else

            {
                e.Handled = true;
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
//code for parrallel circuit calculator//

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                Hideall();
                button2.Show();
                label2.Show();
                comboBox2.Show();
                pictureBox5.Show();
                textBox15.Show();
                textBox16.Show();
                textBox15.BringToFront();
                textBox16.BringToFront();
                button7.Show();
                label3.BringToFront();
                label3.Show();


            }

            else if (comboBox2.SelectedIndex == 1)
            {
                Hideall();
                button2.Show();
                label2.Show();
                comboBox2.Show();
                pictureBox6.Show();
                textBox17.Show();
                textBox18.Show();
                textBox19.Show();
                textBox17.BringToFront();
                textBox18.BringToFront();
                textBox19.BringToFront();
                button8.Show();
            }

            else if (comboBox2.SelectedIndex == 2)
            {
                Hideall();
                button2.Show();
                label2.Show();
                comboBox2.Show();
                pictureBox7.Show();
                textBox20.Show();
                textBox21.Show();
                textBox22.Show();
                textBox23.Show();
                textBox20.BringToFront();
                textBox21.BringToFront();
                textBox22.BringToFront();
                textBox23.BringToFront();
                button9.Show();
            }

            else if (comboBox2.SelectedIndex == 3)
            {
                Hideall();
                button2.Show();
                label2.Show();
                comboBox2.Show();

                pictureBox8.Show();
                textBox24.Show();
                textBox25.Show();
                textBox26.Show();
                textBox27.Show();
                textBox28.Show();
                textBox24.BringToFront();
                textBox25.BringToFront();
                textBox26.BringToFront();
                textBox27.BringToFront();
                textBox28.BringToFront();
                button10.Show();
            }

            else
            {
                MessageBox.Show("Please select an option from the drop down menu!");
            }
        }
//Parallel series calculate button code//
        private void button7_Click_1(object sender, EventArgs e)
        {
            {
                double r1 = Convert.ToDouble(textBox15.Text);
                double r2 = Convert.ToDouble(textBox16.Text);

                r1 = (1 / r1) + (1 / r2);
                r2 = 1 / r1;


                label3.Text = Convert.ToString(r2);
            }

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(textBox17.Text);
            double r2 = Convert.ToDouble(textBox18.Text);
            double r3 = Convert.ToDouble(textBox19.Text);

            r1 = 1 / r1 + 1 / r2 + 1 / r3;
            r2 = 1 / r1;
            label3.Text = Convert.ToString(r2);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(textBox20.Text);
            double r2 = Convert.ToDouble(textBox21.Text);
            double r3 = Convert.ToDouble(textBox22.Text);
            double r4 = Convert.ToDouble(textBox23.Text);

            r1 = 1 / r1 + 1 / r2 + 1 / r3 + 1 / r4;
            r2 = 1 / r1;
            label3.Text = Convert.ToString(r2);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(textBox24.Text);
            double r2 = Convert.ToDouble(textBox25.Text);
            double r3 = Convert.ToDouble(textBox26.Text);
            double r4 = Convert.ToDouble(textBox27.Text);
            double r5 = Convert.ToDouble(textBox28.Text);

            r1 = 1 / r1 + 1 / r2 + 1 / r3 + 1 / r4 + 1 / r5;
            r2 = 1 / r1;
            label3.Text = Convert.ToString(r2);
        }
        //Parallel circuit numerical restriction code//

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }
            else

            {
                e.Handled = true;
            }

        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))

			{
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNum(e))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}