using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ruleOfThree
{
    public partial class Form1 : Form
    {
        double x22;
        public Form1()
        {
            InitializeComponent();
        }

        private void x11_TextChanged(object sender, EventArgs e)
        {

        }

        private void x12_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultRuleOfThree_Click(object sender, EventArgs e)
        {

        }

        private void bttnResultRuleOfThree_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(x11.Text) && !string.IsNullOrWhiteSpace(x12.Text) && !string.IsNullOrWhiteSpace(x21.Text) && int.TryParse(x11.Text, out int output) && int.TryParse(x12.Text, out int output2) && int.TryParse(x21.Text, out int output3))
            {
                    double x11in = double.Parse(x11.Text);
                    double x12in = double.Parse(x12.Text);
                    double x21in = double.Parse(x21.Text);
                    double x222 = (x12in * x21in) / x11in;
                    resultRuleOfThree.Text = x222.ToString("n4");
                }
                else
                {
                    resultRuleOfThree.Text = "";
                    MessageBox.Show("Please enter numbers!");
                }
        }

        private void resultRuleOfThreeDouble_Click(object sender, EventArgs e)
        {

        }

        private void d11_TextChanged(object sender, EventArgs e)
        {

        }

        private void d12_TextChanged(object sender, EventArgs e)
        {

        }

        private void d13_TextChanged(object sender, EventArgs e)
        {

        }

        private void d21_TextChanged(object sender, EventArgs e)
        {

        }

        private void d22_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttn_CalcDouble_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(d11.Text) && !string.IsNullOrWhiteSpace(d12.Text) && !string.IsNullOrWhiteSpace(d13.Text) && !string.IsNullOrWhiteSpace(d21.Text) && !string.IsNullOrWhiteSpace(d22.Text) && int.TryParse(d11.Text, out int output) && int.TryParse(d12.Text, out int output2) && int.TryParse(d12.Text, out int output3) && int.TryParse(d13.Text, out int output4) && int.TryParse(d21.Text, out int output5) && int.TryParse(d22.Text, out int output6))
            {
                double d11in = double.Parse(d11.Text);
                double d12in = double.Parse(d12.Text);
                double d13in = double.Parse(d13.Text);
                double d21in = double.Parse(d21.Text);
                double d22in = double.Parse(d22.Text);
                double d222 = (d22in * d13in * d11in) / (d12in * d21in);
                resultRuleOfThreeDouble.Text = d222.ToString("n4");
            }
            else
            {
                resultRuleOfThreeDouble.Text = "";
                MessageBox.Show("Please enter numbers!");
            }

        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            x11.Text = "";
            x12.Text = "";
            x21.Text = "";
            d11.Text = "";
            d12.Text = "";
            d13.Text = "";
            d21.Text = "";
            d22.Text = "";
            resultRuleOfThreeDouble.Text = "";
            resultRuleOfThree.Text = "";
        }
    }
}
