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
        // -Kha //

        //string CalTotal;
        double num1;
        double num2;
        double memory = 0;
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
        // -Kha //
        private void btnEql_Click(object sender, EventArgs e)
        {
            // -Nam //

            // Xử lý tính căn bậc x của y sau khi nhập x và y
            // Tính y^(1/x) và xuất kết quả, reset trạng thái chờ
            if (isXRootYMode && txtDisplay.Text != "")
            {
                double y = double.Parse(txtDisplay.Text);
                txtDisplay.Text = Math.Pow(y, 1.0 / xRootY_x).ToString();
                isXRootYMode = false; // Reset trạng thái sau khi tính
                return;
            }

            // Nam- //

            // -Kha //

            // các phép tính thông thường
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
            // Logic: Chỉ cho phép thêm dấu chấm nếu trong chuỗi CHƯA có dấu chấm nào
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
        // -Kha //

        // -Nam //

        // Thoát ứng dụng khi nhấn nút OFF
        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Tính sin của giá trị nhập vào (đơn vị độ), chuyển độ sang radian trước khi tính
        private void btnSin_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sin(val * Math.PI / 180).ToString(); // Chuyển độ sang radian
        }

        // Tính cos tương tự, giá trị nhập là độ
        private void btnCos_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Cos(val * Math.PI / 180).ToString();
        }

        // Tính tan tương tự, giá trị nhập là độ
        private void btnTan_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Tan(val * Math.PI / 180).ToString();
        }

        // Tính arcsin, kết quả trả về đơn vị độ
        private void btnSinInv_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (Math.Asin(val) * 180 / Math.PI).ToString();
        }

        // Tính arccos, kết quả trả về đơn vị độ
        private void btnCosInv_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (Math.Acos(val) * 180 / Math.PI).ToString();
        }

        // Tính arctan, kết quả trả về đơn vị độ
        private void btnTanInv_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (Math.Atan(val) * 180 / Math.PI).ToString();
        }

        // Tính căn bậc hai của giá trị nhập
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(val).ToString();
        }

        // Nút tính căn bậc x của y (theo công thức y^(1/x))
        // Lưu số đầu tiên nhập làm x, chờ nhập y
        double xRootY_x = 0;
        bool isXRootYMode = false;
        private void btnXRootY_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                xRootY_x = double.Parse(txtDisplay.Text); // Lưu x
                txtDisplay.Clear();
                isXRootYMode = true; // Chuyển sang chế độ chờ nhập y
            }
        }

        // Tính căn bậc ba của số nhập
        private void btnCubicRoot_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Pow(val, 1.0 / 3.0).ToString();
        }

        // Tính logarit cơ số 10
        private void btnLog_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Log10(val).ToString();
        }

        // Tính logarit tự nhiên (ln)
        private void btnLn_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtDisplay.Text);
            txtDisplay.Text = Math.Log(val).ToString();
        }

        // Hiển thị hằng số pi
        private void btnPi_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.PI.ToString();
        }

        // Hiển thị hằng số e (cơ số logarit tự nhiên)
        private void btnE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Math.E.ToString();
        }

        // Chuyển đổi giữa số thập phân và phân số dạng "a/b"
        // Nếu nhập là phân số, chuyển sang thập phân
        // Nếu nhập là thập phân, chuyển sang phân số gần đúng tối giản
        private void btnSD_Click(object sender, EventArgs e)
        {
            string input = txtDisplay.Text;
            double val;

            if (input.Contains("/"))
            {
                var parts = input.Split('/');
                if (parts.Length == 2)
                {
                    double a = double.Parse(parts[0]);
                    double b = double.Parse(parts[1]);
                    val = a / b;
                    txtDisplay.Text = val.ToString();
                }
            }
            else
            {
                val = double.Parse(input);
                int denominator = 1000000; // Độ chính xác 1 triệu
                int numerator = (int)(val * denominator);
                int gcd = GCD(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;
                txtDisplay.Text = $"{numerator}/{denominator}";
            }
        }

        // Hàm tìm ước chung lớn nhất của hai số dùng thuật toán Euclid
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        // -Nam //

        // Kha//

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                // Xóa ký tự cuối cùng
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            // Nếu xóa hết thì hiển thị lại số 0 (tuỳ chọn)
            if (txtDisplay.Text == "")
            {
                 txtDisplay.Text = "0"; 
            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;

            try
            {
                int val = int.Parse(txtDisplay.Text);
                if (val < 0)
                {
                    MessageBox.Show("Không tính giai thừa số âm!");
                    return;
                }

                double factorial = 1;
                for (int i = 1; i <= val; i++)
                {
                    factorial *= i;
                }
                txtDisplay.Text = factorial.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi định dạng số!");
            }
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double val = double.Parse(txtDisplay.Text);
                txtDisplay.Text = (val * val * val).ToString(); // Hoặc Math.Pow(val, 3)
            }
        }

        private void btnTenPow_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double val = double.Parse(txtDisplay.Text);
                txtDisplay.Text = Math.Pow(10, val).ToString();
            }
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                // 1. Cộng vào bộ nhớ
                memory += double.Parse(txtDisplay.Text);

                // 2. Hiển thị luôn kết quả bộ nhớ ra màn hình để bạn nhìn thấy
                txtDisplay.Text = memory.ToString();

                // 3. Reset lại num1 để chuẩn bị cho phép tính mới (tránh lỗi cộng chuỗi)
                // (Tuỳ chọn, tuỳ vào logic bài toán của bạn)
            }
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                memory -= double.Parse(txtDisplay.Text);
                txtDisplay.Text = memory.ToString(); // Hiện luôn kết quả còn lại
            }
        }
        // Kha//
    }
}
