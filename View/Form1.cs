using Calculadora.Model;
using Calculadora.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularOperaciones()
        {
            if (decimal.TryParse(txtNum1.Text, out decimal num1) && 
                decimal.TryParse(txtNum2.Text, out decimal num2))
            {
                Addition suma = new Addition();
                txtS.Text = suma.Operation(num1, num2).ToString();

                Subtraction resta = new Subtraction();
                txtR.Text = resta.Operation(num1, num2).ToString();

                Division division = new Division();
                txtD.Text = division.Operation(num1, num2).ToString();

                Multiplication multi = new Multiplication();
                txtM.Text = multi.Operation(num1, num2).ToString();
            }

        }

        private void txtNum1_TextChanged(object sender, EventArgs e) 
        {
            CalcularOperaciones();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            CalcularOperaciones();
        }
    }
}
