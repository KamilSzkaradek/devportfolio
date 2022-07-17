using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_calculator
{
    public partial class Form1 : Form
    {
        private int enableOnce = 0;
        private int dotOnce = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {}
        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e){}
        private void textBox1_TextChanged(object sender, EventArgs e){}
        private void enableActions() 
        {
            if (enableOnce == 0)
            {
                buttonDivide.Enabled = true;
                buttonSubtract.Enabled = true;
                buttonAdd.Enabled = true;
                buttonMultiply.Enabled = true;
                buttonDot.Enabled = true;
                enableOnce = 1;
            }
            else if (enableOnce == 1) 
            {
                buttonEquals.Enabled = true;
            }
        }
        private void disableActions()
        {
            buttonDivide.Enabled = false;
            buttonSubtract.Enabled = false;
            buttonAdd.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonEquals.Enabled = false;
            buttonDot.Enabled = false;
        }
        private void disableNumbers()
        {
            buttonZero.Enabled = false;
            buttonOne.Enabled = false;
            buttonTwo.Enabled = false;
            buttonThree.Enabled = false;
            buttonFour.Enabled = false;
            buttonFive.Enabled = false;
            buttonSix.Enabled = false;
            buttonSeven.Enabled = false;
            buttonEight.Enabled = false;
            buttonNine.Enabled = false;
        }
        private void enableNumbers()
        {
            buttonZero.Enabled = true;
            buttonOne.Enabled = true;
            buttonTwo.Enabled = true;
            buttonThree.Enabled = true;
            buttonFour.Enabled = true;
            buttonFive.Enabled = true;
            buttonSix.Enabled = true;
            buttonSeven.Enabled = true;
            buttonEight.Enabled = true;
            buttonNine.Enabled = true;
        }
        private void disableAll() 
        {
            disableActions();
            disableNumbers();
        }
        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e){}
        private void Form1_Load(object sender, EventArgs e){}
        private void changeDot()
        {
            if (dotOnce == 0)
            {
                buttonDot.Enabled = true;
            }
            else 
            {
                buttonDot.Enabled=false;
            }
        }
        private void buttonSeven_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("7");
        }
        private void buttonEight_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("8");
        }
        private void buttonNine_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("9");
        }
        private void buttonFour_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("4");
        }
        private void buttonFive_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("5");
        }
        private void buttonSix_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("6");
        }
        private void buttonThree_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("3");
        }
        private void buttonTwo_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("2");
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("1");
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            changeDot();
            enableActions();
            textBox1.AppendText("0");
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            dotOnce = 0;
            disableActions();
            textBox1.AppendText(" - ");
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            dotOnce = 1;
            changeDot();
            textBox1.AppendText(",");
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            dotOnce = 0;
            disableActions();
            textBox1.AppendText(" + ");
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            dotOnce = 0;
            disableActions();
            textBox1.AppendText(" / ");
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            disableAll();
            var text = textBox1.Text;
            var words = text.Split(' ');
            textBox1.AppendText(" = ");
            switch (words[1])
            {
                case "*":
                    textBox1.AppendText((double.Parse(words[0]) * double.Parse(words[2])).ToString());
                    break;
                case "/":
                    textBox1.AppendText((double.Parse(words[0]) / double.Parse(words[2])).ToString());
                    break;
                case "+":
                    textBox1.AppendText((double.Parse(words[0]) + double.Parse(words[2])).ToString());
                    break;
                case "-":
                    textBox1.AppendText((double.Parse(words[0]) - double.Parse(words[2])).ToString());
                    break;
            }
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            dotOnce = 0;
            disableActions();
            textBox1.AppendText(" * ");
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            enableOnce = 0;
            disableActions();
            enableNumbers();
            textBox1.Clear();
        }
    }
}
