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
    public partial class Form1 : Form
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
        string expression = "";
        double memoryValue = 0;
        double memoryVal = 0;
        bool isResultCalculated = false;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // -Kha //
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblHistory.Text = "";
            expression = ""; // Reset cả chuỗi tính toán ngầm
            memoryValue = 0; // Tùy chọn: Clear có xóa Memory không? Thường nút C là xóa hết, CE chỉ xóa số nhập.
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
        private void btn_Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Logic: Nếu màn hình đang là "0" hoặc vừa bấm dấu bằng thì clear đi nhập mới
            if (txtDisplay.Text == "0" || isResultCalculated)
            {
                txtDisplay.Text = "";
                isResultCalculated = false;
            }

            txtDisplay.Text += btn.Text;

        }

        private void btn_Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string op = btn.Text;

            // Chuẩn hóa ký tự (để DataTable hiểu)
            if (op == "×" || op == "X" || op == "x") op = "*";
            if (op == "÷" || op == ":") op = "/";

            // --- FIX LỖI: Bấm ')' xong bấm '*' bị dính số 0 ---

            // TRƯỜNG HỢP 1: Nếu biểu thức đang kết thúc bằng dấu đóng ngoặc ')'
            // Thì CHỈ THÊM DẤU, KHÔNG lấy số 0 từ màn hình.
            if (expression.EndsWith(")"))
            {
                expression += op;
            }
            // TRƯỜNG HỢP 2: Nếu màn hình có số (khác 0 hoặc người dùng đã nhập số)
            // Thì lấy số đó + dấu (ví dụ: 5 +)
            else if (txtDisplay.Text != "0" || (!string.IsNullOrEmpty(expression) && !expression.EndsWith(")")))
            {
                expression += txtDisplay.Text + op;
            }
            // Trường hợp đặc biệt: Nếu muốn hỗ trợ nhập số âm đầu tiên (ví dụ -5)
            // và expression đang rỗng thì có thể cần xử lý riêng, nhưng với logic cơ bản thì else if trên là đủ.
            else
            {
                // Nếu vừa vào chưa nhập gì mà bấm + - * / thì có thể chặn hoặc coi như 0 +
                expression += "0" + op;
            }

            lblHistory.Text = expression;
            txtDisplay.Text = "0"; // Reset màn hình để nhập số tiếp
            isResultCalculated = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
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
            try
            {
                string finalExpression = expression;

                // --- SỬA LỖI 1: Xử lý logic đóng ngoặc ---
                // Nếu biểu thức kết thúc bằng ')' và màn hình đang là số 0 (do vừa reset)
                // thì KHÔNG ghép thêm text vào nữa. Tránh lỗi thành "(1+2)0"
                if (expression.EndsWith(")") && txtDisplay.Text == "0")
                {
                    // Giữ nguyên finalExpression, không làm gì cả
                }
                else
                {
                    // Trường hợp bình thường: Nối con số đang nhập dở vào cuối
                    finalExpression += txtDisplay.Text;
                }

                // --- SỬA LỖI 2: Xử lý dấu chấm/phẩy (Localization) ---
                // DataTable.Compute chỉ hiểu dấu chấm (.) là thập phân, không hiểu dấu phẩy (,)
                // Ví dụ: đổi "2,5 + 3" thành "2.5 + 3"
                finalExpression = finalExpression.Replace(",", ".");

                // Tính toán
                System.Data.DataTable table = new System.Data.DataTable();
                object result = table.Compute(finalExpression, "");

                // Chuyển kết quả về dạng chuỗi
                string resultString = result.ToString();

                // Kiểm tra lỗi chia cho 0 (Infinity) hoặc không xác định (NaN)
                if (resultString == "∞" || resultString == "NaN" || resultString == "Infinity")
                {
                    txtDisplay.Text = "Error";
                }
                else
                {
                    // Đổi lại dấu chấm thành phẩy để hiển thị đúng chuẩn Việt Nam (nếu muốn)
                    txtDisplay.Text = resultString.Replace(".", ",");
                }

                // Dọn dẹp và đánh dấu đã tính xong
                expression = "";
                lblHistory.Text = "";
                isResultCalculated = true;
            }
            catch
            {
                // Mẹo: Nếu muốn biết lỗi gì thì dùng MessageBox.Show(ex.Message);
                txtDisplay.Text = "Error";
            }
        }

        private void btn_Parenthesis_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "(")
            {
                // --- FIX LỖI: Vừa mở máy bấm ( ra *( ---

                // Logic: Chỉ tự thêm dấu nhân (*) khi:
                // 1. Màn hình đang có số KHÁC 0 (ví dụ: 2( -> 2*( )
                // 2. HOẶC biểu thức kết thúc bằng dấu đóng ngoặc (ví dụ: )( -> )*( )

                if (txtDisplay.Text != "0")
                {
                    // Trường hợp: 5( -> thành 5*(
                    expression += txtDisplay.Text + "*(";
                }
                else if (expression.EndsWith(")"))
                {
                    // Trường hợp: (1+2)( -> thành (1+2)*(
                    expression += "*(";
                }
                else
                {
                    // Trường hợp bình thường: Vừa mở máy hoặc sau dấu cộng/trừ
                    expression += "(";
                }

                lblHistory.Text = expression;
                txtDisplay.Text = "0";
            }
            else // Nút đóng ngoặc ')'
            {
                // Khi đóng ngoặc, nối số hiện tại vào
                expression += txtDisplay.Text + ")";
                lblHistory.Text = expression;

                // Reset về 0 (Lưu ý: việc này gây ra lỗi số 0 ở nút phép toán, nhưng code ở mục 1 đã xử lý rồi)
                txtDisplay.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                // Xóa ký tự cuối
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }

            // Nếu xóa hết thì trả về "0", không để chuỗi rỗng "" dễ gây lỗi Parse
            if (string.IsNullOrEmpty(txtDisplay.Text) || txtDisplay.Text == "-")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btn_MathFunction_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out double num))
            {
                return; // Nếu không phải số thì thoát luôn
            }

            Button btn = (Button)sender;
            double result = 0;
            string op = btn.Text; // Lấy tên nút (x², √, n!, ...)

            // 2. Xử lý từng phép toán
            switch (op)
            {
                case "x²": // Bình phương
                    result = num * num;
                    break;

                case "x³": // Lập phương
                    result = Math.Pow(num, 3);
                    break;

                case "10ˣ": // 10 mũ x
                    result = Math.Pow(10, num);
                    break;

                case "1/x": // Nghịch đảo
                    if (num == 0)
                    {
                        txtDisplay.Text = "Cannot divide by 0";
                        isResultCalculated = true;
                        return;
                    }
                    result = 1 / num;
                    break;
                case "³√x": // Căn bậc 3
                    result = Math.Pow(num, 1.0 / 3.0);
                    break;

                // case "√": // Căn bậc 2 (Lưu ý: Copy đúng ký tự trên nút của bạn vào đây)
                case "√":
                    if (num < 0)
                    {
                        txtDisplay.Text = "Invalid Input";
                        isResultCalculated = true;
                        return;
                    }
                    result = Math.Sqrt(num);
                    break;

                case "%": // Phần trăm (Chuyển thành số thập phân)
                    result = num / 100;
                    break;

                case "n!": // Giai thừa
                           // Kiểm tra số âm
                    if (num < 0)
                    {
                        txtDisplay.Text = "Invalid Input";
                        isResultCalculated = true;
                        return;
                    }

                    // Kiểm tra số nguyên (Giai thừa thường chỉ tính cho số nguyên)
                    // Math.Floor(num) == num nghĩa là số không có phần thập phân
                    if (Math.Floor(num) != num)
                    {
                        txtDisplay.Text = "Integer required";
                        isResultCalculated = true;
                        return;
                    }

                    // Kiểm tra tràn số (Double chỉ chịu được đến khoảng 170!)
                    if (num > 170)
                    {
                        txtDisplay.Text = "Overflow"; // Số quá lớn
                        isResultCalculated = true;
                        return;
                    }

                    // Tính giai thừa bằng vòng lặp
                    result = 1;
                    for (int i = 1; i <= (int)num; i++)
                    {
                        result *= i;
                    }
                    break;

                case "±": // Đổi dấu (Âm/Dương)
                    result = -num;
                    break;

                default:
                    return; // Nếu không khớp nút nào thì thoát
            }

            // 3. Hiển thị kết quả
            // Replace dấu chấm thành phẩy nếu cần (tùy máy tính)
            txtDisplay.Text = result.ToString().Replace(".", ",");

            // 4. Quan trọng: Đánh dấu đã tính xong để nhập số mới sẽ reset màn hình
            isResultCalculated = true;
        }

        private void btn_Memory_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "Error" || string.IsNullOrEmpty(txtDisplay.Text)) return;

            // 2. Lấy giá trị hiện tại trên màn hình
            if (double.TryParse(txtDisplay.Text, out double currentNum))
            {
                Button btn = (Button)sender;

                // 3. Cộng hoặc Trừ vào biến nhớ
                if (btn.Text == "M+")
                {
                    memoryVal += currentNum;
                }
                else if (btn.Text == "M-")
                {
                    memoryVal -= currentNum;
                }
                isResultCalculated = true;
            }
        }

        private void btnMemory_MouseUp(object sender, MouseEventArgs e)
        {
            // TRƯỜNG HỢP 1: Bấm Chuột Phải -> Gọi tính năng MR (Recall)
            if (e.Button == MouseButtons.Right)
            {
                txtDisplay.Text = memoryVal.ToString();
                isResultCalculated = true; // Để bấm số tiếp theo sẽ reset màn hình

                // (Tùy chọn) Hiển thị thông báo nhỏ
                MessageBox.Show("Đã lấy số từ bộ nhớ: " + memoryVal);
            }
            // TRƯỜNG HỢP 2: Bấm Chuột Trái -> Gọi tính năng M+ (Add)
            else if (e.Button == MouseButtons.Left)
            {
                // Gọi lại logic tính toán bộ nhớ bạn đã viết

                // Cách đơn giản nhất: Copy logic M+ vào đây luôn cho gọn
                if (double.TryParse(txtDisplay.Text, out double currentNum))
                {
                    Button btn = (Button)sender;
                    if (btn.Text == "M+") memoryVal += currentNum;
                    else if (btn.Text == "M-") memoryVal -= currentNum;

                    isResultCalculated = true;
                }
            }
            }
    }
}
