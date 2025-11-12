using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeshaCalculator
{
    public partial class Form1 : Form
    {
        double enterFirstValue, enterSecondValue;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 407;
            this.Height = 630;
            txtResult.Width = 359;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 407;
            this.Height = 630;
            txtResult.Width = 359;
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))

                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            enterFirstValue = Convert.ToDouble(txtResult.Text);
            op = num.Text;
            txtResult.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            enterSecondValue = Convert.ToDouble(txtResult.Text);

            lblShowOp.Text = "";
            switch (op)
            {
                case "+":
                    txtResult.Text = (enterFirstValue + enterSecondValue).ToString();
                break;

                case "-":
                    txtResult.Text = (enterFirstValue - enterSecondValue).ToString();
                break;

                case "*":
                    txtResult.Text = (enterFirstValue * enterSecondValue).ToString();
                break;

                case "/":
                    txtResult.Text = (enterFirstValue / enterSecondValue).ToString();
                break;

                case "Mod":
                    txtResult.Text = (enterFirstValue % enterSecondValue).ToString();
                break;

                case "Exp":
                    double i = Convert.ToDouble(txtResult.Text);
                    double j = Convert.ToDouble(txtResult.Text);
                    j = enterSecondValue;
                    txtResult.Text = Math.Exp(i * Math.Log(j * 4)).ToString();
                break;

                default:
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblShowOp.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lblShowOp.Text = "";

            String f, s;

            f = Convert.ToString(enterFirstValue);
            s = Convert.ToString(enterSecondValue);

            f = "";
            s = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;

            exitCal = MessageBox.Show("Подтвердите, хотите ли вы выйти?", "LeshaCalculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3,141592653589976323";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Log" + "(" + (txtResult.Text) + ")");
            log = Math.Log10(log);
            txtResult.Text = Convert.ToString(log);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            double sq = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Sqrt" + "(" + (txtResult.Text) + ")");
            sq = Math.Sqrt(sq);
            txtResult.Text = Convert.ToString(sq);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            double sh = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Sinh" + "(" + (txtResult.Text) + ")");
            sh = Math.Sinh(sh);
            txtResult.Text = Convert.ToString(sh);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Sin" + "(" + (txtResult.Text) + ")");
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Cosh" + "(" + (txtResult.Text) + ")");
            cosh = Math.Cosh(cosh);
            txtResult.Text = Convert.ToString(cosh);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Cos" + "(" + (txtResult.Text) + ")");
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Tanh" + "(" + (txtResult.Text) + ")");
            tanh = Math.Tanh(tanh);
            txtResult.Text = Convert.ToString(tanh);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Tan" + "(" + (txtResult.Text) + ")");
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            double x;
            lblShowOp.Text = Convert.ToString((txtResult.Text) + "²");
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            double x;
            lblShowOp.Text = Convert.ToString((txtResult.Text) + "³");
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));

            txtResult.Text = Convert.ToString(a);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double inx = Convert.ToDouble(txtResult.Text);
            lblShowOp.Text = Convert.ToString("Ilog" + "(" + (txtResult.Text) + ")");
            inx = Math.Log(inx);
            txtResult.Text = Convert.ToString(inx);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double a;

            lblShowOp.Text = Convert.ToString((txtResult.Text) + "%");

            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);

            txtResult.Text = Convert.ToString(a);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void button23_Click(object sender, EventArgs e)
        {   
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 841;
            this.Height = 630;
            txtResult.Width = 792;
        }
    }
}
