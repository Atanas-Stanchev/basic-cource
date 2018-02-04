using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterAPP
{
    public partial class FormConverter : Form
    {
        public FormConverter()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            var amountBGN = this.numericUpDownAmount.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.labelResult.Text = amountBGN + " BGN = " + Math.Round(amountEUR, 2) + "EUR";

        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelResult_click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var amountBGN = this.numericUpDownAmount.Value;
            var amountEUR = amountBGN * 1.95583m;
            this.labelResult.Text = amountBGN + " BGN = " + Math.Round(amountEUR, 2) + "EUR";


        }

        private void numericUpDownAmount_KeyUp(object sender, KeyEventArgs e)
        {
          
        }
    }
}
