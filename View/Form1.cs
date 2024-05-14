using Calculadora.Model;
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

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {
            Addition suma = new Addition();
            decimal Num1 = decimal.TryParse(txtNum1.Text)
            suma.Operation();

        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
