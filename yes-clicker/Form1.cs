using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yes_clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "ja")
            {
                button1.Text = "nee";
            }
            else
            {
                button1.Text = "ja";
            }

            if (button2.Text == "ja")
            {
                button2.Text = "nee";
            }
            else
            {
                button2.Text = "ja";
            }
            winCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "ja")
            {
                button2.Text = "nee";
            }
            else
            {
                button2.Text = "ja";
            }

            if (button4.Text == "ja")
            {
                button4.Text = "nee";
            }
            else
            {
                button4.Text = "ja";
            }
            winCheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "ja")
            {
                button3.Text = "nee";
            }
            else
            {
                button3.Text = "ja";
            }

            if (button2.Text == "ja")
            {
                button2.Text = "nee";
            }
            else
            {
                button2.Text = "ja";
            }

            if (button4.Text == "ja")
            {
                button4.Text = "nee";
            }
            else
            {
                button4.Text = "ja";
            }
            winCheck();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "ja")
            {
                button4.Text = "nee";
            }
            else
            {
                button4.Text = "ja";
            }

            if (button8.Text == "ja")
            {
                button8.Text = "nee";
            }
            else
            {
                button8.Text = "ja";
            }

            if (button1.Text == "ja")
            {
                button1.Text = "nee";
            }
            else
            {
                button1.Text = "ja";
            }
            winCheck();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "ja")
            {
                button5.Text = "nee";
            }
            else
            {
                button5.Text = "ja";
            }
            winCheck();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "ja")
            {
                button6.Text = "nee";
            }
            else
            {
                button6.Text = "ja";
            }

            if (button9.Text == "ja")
            {
                button9.Text = "nee";
            }
            else
            {
                button9.Text = "ja";
            }

            if (button7.Text == "ja")
            {
                button7.Text = "nee";
            }
            else
            {
                button7.Text = "ja";
            }
            winCheck();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "ja")
            {
                button7.Text = "nee";
            }
            else
            {
                button7.Text = "ja";
            }

            if (button5.Text == "ja")
            {
                button5.Text = "nee";
            }
            else
            {
                button5.Text = "ja";
            }

            if (button6.Text == "ja")
            {
                button6.Text = "nee";
            }
            else
            {
                button6.Text = "ja";
            }
            winCheck();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "ja")
            {
                button8.Text = "nee";
            }
            else
            {
                button8.Text = "ja";
            }

            if (button9.Text == "ja")
            {
                button9.Text = "nee";
            }
            else
            {
                button9.Text = "ja";
            }

            if (button2.Text == "ja")
            {
                button2.Text = "nee";
            }
            else
            {
                button2.Text = "ja";
            }
            winCheck();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "ja")
            {
                button9.Text = "nee";
            }
            else
            {
                button9.Text = "ja";
            }

            if (button1.Text == "ja")
            {
                button1.Text = "nee";
            }
            else
            {
                button1.Text = "ja";
            }
            winCheck();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            button1.Text = "nee";
            button2.Text = "nee";
            button3.Text = "nee";
            button4.Text = "nee";
            button5.Text = "nee";
            button6.Text = "nee";
            button7.Text = "nee";
            button8.Text = "nee";
            button9.Text = "nee";
        }
        public void winCheck()
        {
            if (button1.Text == "ja" && button2.Text == "ja" && button3.Text == "ja" && button4.Text == "ja" && button5.Text == "ja" && button6.Text == "ja" && button7.Text == "ja" && button8.Text == "ja" && button9.Text == "ja")
            {
                MessageBox.Show("Je hebt de puzzel opgelost!");
            }
        }
    }
}
