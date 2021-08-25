using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void btnSum_Click(object sender, EventArgs e)
        {

            int sum = calculator.Sum(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()));
            MessageBox.Show("Sum is : " + sum);

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            int minus = calculator.Minus(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()));
            MessageBox.Show("Minus is : " + minus);
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {

            int multiple = calculator.Multiple(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()));
            MessageBox.Show("Multiple is : " + multiple);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            int divide = calculator.Divide(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()));
            MessageBox.Show("Divide is : " + divide);
        }
    }
}
