using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string CalTotal;
        double num1;
        double num2;
        string option;
        double result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text +"2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            if (option == null || option == "")
                return;

            try
            {
                if (txtDisplay.Text != "")
                    num2 = double.Parse(txtDisplay.Text);

                switch (option)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Không thể chia cho 0");
                            return;
                        }
                        result = num1 / num2;
                        break;

                    case "pow":
                        result = Math.Pow(num1, num2);
                        break;

                    case "square":
                        result = num1 * num1;
                        break;
                }

                txtDisplay.Text = result.ToString();
                num1 = result;   // cho phép bấm tiếp
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu trong txtDisplay chưa có dấu chấm thì thêm vào
            if (!txtDisplay.Text.Contains("."))
            {
                if (txtDisplay.Text == "")
                {
                    txtDisplay.Text = "0.";
                }
                else
                {
                    txtDisplay.Text += ".";
                }
            }
            }

        private void btnPow_Click(object sender, EventArgs e)
        {
            option = "pow";
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                txtDisplay.Text = Math.Sqrt(num).ToString();
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            option = "square";
            num1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();   // giống +, -, *, /
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                if (num != 0)
                    txtDisplay.Text = (1 / num).ToString();
                else
                    MessageBox.Show("Không thể chia cho 0");
            }
            }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                txtDisplay.Text = (-num).ToString();
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double num = double.Parse(txtDisplay.Text);
                txtDisplay.Text = (num / 100).ToString();
            }
        }
    }
}
