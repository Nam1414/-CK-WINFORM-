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
            // -NAM //
            // Xử lý căn bậc x của y trước, ưu tiên nếu đang ở chế độ này
            if (isXRootYMode)
            {
                if (double.TryParse(txtDisplay.Text, out double y))
                {
                    if (y < 0 && xRootY_x % 2 == 0)
                    {
                        MessageBox.Show("Không thể tính căn bậc chẵn của số âm");
                        isXRootYMode = false;
                        return;
                    }
                    double result = Math.Pow(y, 1.0 / xRootY_x);
                    txtDisplay.Text = result.ToString();
                    isXRootYMode = false; // Reset trạng thái
                    return; // Đã xử lý xong, không thực hiện các phép tính khác
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho y");
                    return;
                }
            }
            // -NAM//

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
        // Hàm kiểm tra và parse số an toàn
        private bool TryParseInput(out double result)
        {
            if (!double.TryParse(txtDisplay.Text, out result))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ");
                return false;
            }
            return true;
        }
        // Tính sin của giá trị nhập vào (đơn vị độ), chuyển độ sang radian trước khi tính
        private void btnSin_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                txtDisplay.Text = Math.Sin(val * Math.PI / 180).ToString();
            }
        }
        // Tính cos tương tự, giá trị nhập là độ
        private void btnCos_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                txtDisplay.Text = Math.Cos(val * Math.PI / 180).ToString();
            }
        }
        // Tính tan tương tự, giá trị nhập là độ
        private void btnTan_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                // Kiểm tra điểm không xác định của tan (90 + k*180 độ)
                double mod = val % 180;
                if (Math.Abs(mod - 90) < 1e-10)
                {
                    MessageBox.Show("Giá trị nhập vào làm tan không xác định");
                    return;
                }
                txtDisplay.Text = Math.Tan(val * Math.PI / 180).ToString();
            }
        }
        // Tính arcsin, kết quả trả về đơn vị độ
        private void btnSinInv_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                if (val < -1 || val > 1)
                {
                    MessageBox.Show("Giá trị arcsin phải nằm trong khoảng [-1, 1]");
                    return;
                }
                txtDisplay.Text = (Math.Asin(val) * 180 / Math.PI).ToString();
            }
        }
        // Tính arccos, kết quả trả về đơn vị độ
        private void btnCosInv_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                if (val < -1 || val > 1)
                {
                    MessageBox.Show("Giá trị arccos phải nằm trong khoảng [-1, 1]");
                    return;
                }
                txtDisplay.Text = (Math.Acos(val) * 180 / Math.PI).ToString();
            }
        }
        // Tính arctan, kết quả trả về đơn vị độ
        private void btnTanInv_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                txtDisplay.Text = (Math.Atan(val) * 180 / Math.PI).ToString();
            }
        }
        // Tính căn bậc hai của giá trị nhập
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                if (val < 0)
                {
                    MessageBox.Show("Không thể tính căn bậc hai của số âm");
                    return;
                }
                txtDisplay.Text = Math.Sqrt(val).ToString();
            }
        }
        // Biến lưu bậc căn x
        double xRootY_x = 0;
        // Biến trạng thái chờ nhập y
        bool isXRootYMode = false;
        // Khi bấm nút x√y: nhập x, chờ nhập y
        private void btnXRootY_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double x))
            {
                if (x == 0)
                {
                    MessageBox.Show("Không thể tính căn bậc 0");
                    return;
                }
                xRootY_x = x;
                txtDisplay.Clear(); // Xóa để nhập y
                isXRootYMode = true;
            }
        }
        // Tính căn bậc ba của số nhập
        private void btnCubicRoot_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                txtDisplay.Text = Math.Pow(val, 1.0 / 3.0).ToString();
            }
        }
        // Tính logarit cơ số 10
        private void btnLog_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                if (val <= 0)
                {
                    MessageBox.Show("Giá trị log phải lớn hơn 0");
                    return;
                }
                txtDisplay.Text = Math.Log10(val).ToString();
            }
        }
        // Tính logarit tự nhiên (ln)
        private void btnLn_Click(object sender, EventArgs e)
        {
            if (TryParseInput(out double val))
            {
                if (val <= 0)
                {
                    MessageBox.Show("Giá trị ln phải lớn hơn 0");
                    return;
                }
                txtDisplay.Text = Math.Log(val).ToString();
            }
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
        // Biến lưu trạng thái hiện tại (true: đang hiển thị thập phân, false: đang hiển thị phân số)
        bool isDecimalDisplay = true;
        private void btnSD_Click(object sender, EventArgs e)
        {
            string input = txtDisplay.Text.Trim();
            // Nếu đang hiển thị phân số ("a/b") => đổi sang số thập phân
            if (input.Contains("/"))
            {
                var parts = input.Split('/');
                if (parts.Length == 2)
                {
                    if (!double.TryParse(parts[0], out double a) || !double.TryParse(parts[1], out double b))
                    {
                        MessageBox.Show("Phân số không hợp lệ");
                        return;
                    }
                    if (b == 0)
                    {
                        MessageBox.Show("Mẫu số không được bằng 0");
                        return;
                    }
                    double val = a / b;
                    txtDisplay.Text = val.ToString();
                    isDecimalDisplay = true; // Đang ở dạng thập phân sau khi chuyển đổi
                }
                else
                {
                    MessageBox.Show("Định dạng phân số sai");
                }
            }
            // Ngược lại: nếu đang ở số thập phân => chuyển về phân số tối giản
            else
            {
                if (!double.TryParse(input, out double val))
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ");
                    return;
                }
                // Chuyển sang phân số tối giản (ví dụ 0.2 -> 1/5)
                int denominator = 1000000; // Độ chính xác 1 triệu (có thể thay đổi nhỏ hơn nếu muốn)
                int numerator = (int)Math.Round(val * denominator);

                // Tìm ước chung lớn nhất
                int gcd = GCD(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;

                txtDisplay.Text = $"{numerator}/{denominator}";
                isDecimalDisplay = false; // Đang ở phân số
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
    }
}
