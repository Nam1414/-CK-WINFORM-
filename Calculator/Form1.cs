using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;// cần cài gói NCalc

namespace Calculator
{
    public partial class Form1 : Form
    {
        double memoryValue = 0;
        bool isResultCalculated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.ReadOnly = false; // Cho phép nhập/thao tác bằng nút hoặc bàn phím
        }

        // Cập nhật Label khi TextBox thay đổi                                                -Nam-
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            lblExpression.Text = txtDisplay.Text;
        }

        // Chèn bất kỳ chuỗi nào vào vị trí con trỏ của TextBox                                                -Nam-
        private void InsertAtCaret(string s)
        {
            int caretPos = txtDisplay.SelectionStart;
            txtDisplay.Text = txtDisplay.Text.Insert(caretPos, s);
            txtDisplay.SelectionStart = caretPos + s.Length;
            txtDisplay.Focus();
        }

        // button số 0-9                                                -Kha-
        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (isResultCalculated)
            {
                txtDisplay.Text = "";
                isResultCalculated = false;
            }
            InsertAtCaret(btn.Text);
        }

        //button toán tử + - * /                                                -Kha-
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string op = btn.Text;
            if (op == "×" || op == "X" || op == "x") op = "*";
            if (op == "÷" || op == ":") op = "/";
            InsertAtCaret(op);
            isResultCalculated = false;
        }

        //button dấu chấm thập phân                                                -Kha-
        private void btnDot_Click(object sender, EventArgs e)
        {
            InsertAtCaret(".");
        }

        //button ngoặc (                                                -Kha-
        private void btnOpenParen_Click(object sender, EventArgs e)
        { 
            InsertAtCaret("(");
        }

        //button ngoặc )                                                -Kha-
        private void btnCloseParen_Click(object sender, EventArgs e)
        { 
            InsertAtCaret(")"); 
        }

        //button Del                                                -Kha-
        private void btnDel_Click(object sender, EventArgs e)
        {           
            int caretPos = txtDisplay.SelectionStart;
            if (caretPos > 0 && txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(caretPos - 1, 1);
                txtDisplay.SelectionStart = caretPos - 1;
            }
            txtDisplay.Focus();
            memoryValue = 0;
        }

        //button AC                                                -Kha-
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            isResultCalculated = false;
        }

        //button =                                                -Kha-
        private void btnEquals_Click(object sender, EventArgs e)
        {
            string expr = txtDisplay.Text;
            while
                (expr.Count(c => c == '(') > expr.Count(c => c == ')'))expr += ")";
            try
            {
                Expression exprEval = new Expression(expr);
                exprEval.EvaluateFunction += delegate (string name, FunctionArgs args)
                {
                    // ---- Xử lý hàm đặc biệt ----
                    if (name.Equals("Sin", StringComparison.OrdinalIgnoreCase))
                    {
                        args.Result = Math.Sin(ToRad(args.Parameters[0].Evaluate()));
                    }
                    else if (name.Equals("Cos", StringComparison.OrdinalIgnoreCase))
                    {
                        args.Result = Math.Cos(ToRad(args.Parameters[0].Evaluate()));
                    }
                    else if (name.Equals("Tan", StringComparison.OrdinalIgnoreCase))
                    {
                        double deg = Convert.ToDouble(args.Parameters[0].Evaluate());
                        double mod = deg % 180;

                        if (Math.Abs(mod - 90) < 1e-10)
                        {
                            throw new Exception("Giá trị làm tan không xác định");
                        }
                        args.Result = Math.Tan(deg * Math.PI / 180);
                    }
                    else if (name.Equals("Asin", StringComparison.OrdinalIgnoreCase))
                    {
                        double val = Convert.ToDouble(args.Parameters[0].Evaluate());

                        if (val < -1 || val > 1)
                        {
                            throw new Exception("Giá trị arcsin phải nằm trong [-1, 1]");
                        }
                        args.Result = Math.Asin(val) * 180 / Math.PI; // ĐỔI RADIAN SANG ĐỘ
                    }
                    else if (name.Equals("Acos", StringComparison.OrdinalIgnoreCase))
                    {
                        double val = Convert.ToDouble(args.Parameters[0].Evaluate());

                        if (val < -1 || val > 1)
                        {
                            throw new Exception("Giá trị arccos phải nằm trong [-1, 1]");
                        }
                        args.Result = Math.Acos(val) * 180 / Math.PI; // ĐỔI RADIAN SANG ĐỘ
                    }
                    else if (name.Equals("Atan", StringComparison.OrdinalIgnoreCase))
                    {
                        double val = Convert.ToDouble(args.Parameters[0].Evaluate());

                        args.Result = Math.Atan(val) * 180 / Math.PI; // ĐỔI RADIAN SANG ĐỘ
                    }
                    else if (name.Equals("Sqrt", StringComparison.OrdinalIgnoreCase))
                    {
                        double val = Convert.ToDouble(args.Parameters[0].Evaluate());

                        if (val < 0) throw new Exception("Căn không nhận số âm");
                        {
                            args.Result = Math.Sqrt(val);
                        }
                    }
                    else if (name.Equals("Ln", StringComparison.OrdinalIgnoreCase))
                    {
                        args.Result = Math.Log(Convert.ToDouble(args.Parameters[0].Evaluate()));
                    }
                    else if (name.Equals("Log", StringComparison.OrdinalIgnoreCase))
                    {
                        args.Result = Math.Log10(Convert.ToDouble(args.Parameters[0].Evaluate()));
                    }
                    else if (name.Equals("fact", StringComparison.OrdinalIgnoreCase))
                    {
                        double n = Convert.ToDouble(args.Parameters[0].Evaluate());

                        if (n < 0 || Math.Floor(n) != n)
                        {
                            throw new Exception("Chỉ tính giai thừa cho số nguyên không âm");
                        }
                        double res = 1; for (int i = 2; i <= (int)n; i++) res *= i;

                        args.Result = res;
                    }
                };
                var result = exprEval.Evaluate();
                txtDisplay.Text = result.ToString();
                isResultCalculated = true;
            }
            catch (Exception ex)
            {
                txtDisplay.Text = "Error";
                MessageBox.Show(ex.Message);
                isResultCalculated = true;
            }
        }

        //button √                                                -Nam-
        private void btnSqrt_Click(object sender, EventArgs e)
        { 
            InsertAtCaret("Sqrt(");
        }

        //button ³√x                                                -Nam-
        private void btnCubicRoot_Click(object sender, EventArgs e)
        { 
            InsertAtCaret("Pow(,1/3)"); txtDisplay.SelectionStart -= 4; 
        }

        //button ˣ√y                                                -Nam-
        private void btnXRootY_Click(object sender, EventArgs e) 
        { 
            InsertAtCaret("Pow(,1/ )"); txtDisplay.SelectionStart -= 4; 
        }

        //button 10ˣ                                                -Kha-
        private void btnTenPower_Click(object sender, EventArgs e) 
        { 
            InsertAtCaret("Pow(10,"); 
        }

        //button xʸ                                                -Kha-
        private void btnPow_Click(object sender, EventArgs e)
        {
            InsertAtCaret("Pow(,)");
            txtDisplay.SelectionStart -= 2; // Con trỏ sau dấu '(' để nhập x
            txtDisplay.Focus();
        }

        //button  x²                                                -Kha-
        private void btnSquare_Click(object sender, EventArgs e)
        {
            InsertAtCaret("Pow(,2)");
            txtDisplay.SelectionStart -= 3; // Con trỏ sau '(' để nhập x
            txtDisplay.Focus();
        }

        //button  x³                                                -Kha-
        private void btnCube_Click(object sender, EventArgs e)
        {
            InsertAtCaret("Pow(,3)");
            txtDisplay.SelectionStart -= 3;
            txtDisplay.Focus();
        }

        //button %                                                -Kha-
        private void btnPercent_Click(object sender, EventArgs e) 
        { 
            InsertAtCaret("/100"); 
        }

        //button Log                                                -Nam-
        private void btnLog_Click(object sender, EventArgs e) 
        {
            InsertAtCaret("Log("); 
        }

        //button Ln                                                -Nam-
        private void btnLn_Click(object sender, EventArgs e)
        {
            InsertAtCaret("Ln("); 
        }

        //button Sin                                                -Nam-
        private void btnSin_Click(object sender, EventArgs e)
        {
            InsertAtCaret("Sin(");
        }

        //button Cos                                                -Nam-
        private void btnCos_Click(object sender, EventArgs e)
        {
            InsertAtCaret("Cos(");
        }

        //button Tan                                                -Nam-
        private void btnTan_Click(object sender, EventArgs e) 
        { 
            InsertAtCaret("Tan("); 
        }

        //button Sin-1                                                -Nam-
        private void btnSinInv_Click(object sender, EventArgs e) 
        { 
            InsertAtCaret("Asin(");
        }

        //button Cos-1                                                -Nam-
        private void btnCosInv_Click(object sender, EventArgs e)
        {
            InsertAtCaret("Acos(");
        }

        //button Tan-1                                                -Nam-
        private void btnTanInv_Click(object sender, EventArgs e) 
        { 
            InsertAtCaret("Atan("); 
        }

        //button π                                                -Nam-
        private void btnPi_Click(object sender, EventArgs e) 
        { 
            InsertAtCaret(Math.PI.ToString("G15")); 
        }

        //button e                                                -Nam-
        private void btnE_Click(object sender, EventArgs e)
        { 
            InsertAtCaret(Math.E.ToString("G15"));
        }

        //button n!                                                -Kha-
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            InsertAtCaret("fact(");
        }

        //button phan số /                                                -Kha-
        private void btnFraction_Click(object sender, EventArgs e)
        {
            InsertAtCaret("(/)");
            txtDisplay.SelectionStart -= 2; // Chỉ con trỏ vào sau '('
            txtDisplay.Focus();
        }

        //button ±                                                -Kha-
        private void btnNegate_Click(object sender, EventArgs e)
        {
            int caretPos = txtDisplay.SelectionStart;

            // Nếu ở đầu chuỗi, hoặc phía trước là toán tử hoặc ngoặc mở, chỉ thêm "-"
            if (caretPos == 0 || "+-*/(,".Contains(txtDisplay.Text[caretPos - 1]))
            {
                txtDisplay.Text = txtDisplay.Text.Insert(caretPos, "-");
                txtDisplay.SelectionStart = caretPos + 1;
                txtDisplay.Focus();
                return;
            }

            // Nếu đang chọn một số, đổi thành (-số)
            int left = caretPos - 1;

            // Tìm số bên trái
            while (left >= 0 && (char.IsDigit(txtDisplay.Text[left]) || txtDisplay.Text[left] == '.'))
            {
                left--;
            }
            {
                left++;
            }
            string before = txtDisplay.Text.Substring(0, left);
            string number = txtDisplay.Text.Substring(left, caretPos - left);
            string after = txtDisplay.Text.Substring(caretPos);

            // Nếu số đã có dấu trừ phía trước, xóa dấu trừ
            if (before.EndsWith("-"))
            {
                before = before.Substring(0, before.Length - 1);
            }
            else
            { 
                before += "-"; 
            }
            txtDisplay.Text = before + number + after;
            txtDisplay.SelectionStart = before.Length + number.Length;
            txtDisplay.Focus();
        }

        //button Off                                                -Nam-
        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        // button M+                                                -Kha-
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double v))
            {
                memoryValue += v;
                lblExpression.Text = memoryValue.ToString();
            }
            else
            {
                MessageBox.Show("Giá trị không hợp lệ để cộng vào bộ nhớ");
            }
        }

        // button M-                                                -Kha-
        private void btnMMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double v))
            {
                memoryValue -= v;
                lblExpression.Text = memoryValue.ToString();
            }
            else
            {
                MessageBox.Show("Giá trị không hợp lệ để trừ vào bộ nhớ");
            }
        }

        //button SD (Chuyển đổi phân số ⇔ thập phân)                                                -Nam-
        bool isDecimalDisplay = true;
        private void btnSD_Click(object sender, EventArgs e)
        {
            string input = txtDisplay.Text.Trim();
            if (string.IsNullOrEmpty(input) || input == "Error")
            {
                return;
            }

            // Đang là phân số ⇒ sang thập phân
            if (input.Contains("/"))
            {
                var parts = input.Split('/');
                if (parts.Length == 2 && double.TryParse(parts[0], out double num) && double.TryParse(parts[1], out double deno))
                {
                    if (deno == 0)
                    { 
                        txtDisplay.Text = "Error";
                        return; 
                    }
                    txtDisplay.Text = (num / deno).ToString();
                    isDecimalDisplay = true;
                }
            }

            // Đang là số thường ⇒ sang phân số tối giản
            else
            {
                string standardInput = input.Replace(",", ".");
                if (!double.TryParse(standardInput, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double val))
                {
                    return;
                }
                long denominator = 1000000;
                long numerator = (long)Math.Round(val * denominator);
                long commonDivisor = GCD(numerator, denominator);
                numerator /= commonDivisor;
                denominator /= commonDivisor;
                if (denominator == 1)
                { 
                    txtDisplay.Text = numerator.ToString(); 
                }
                else
                {
                    txtDisplay.Text = $"{numerator}/{denominator}";
                }
                isDecimalDisplay = false;
            }
        }

        // Tìm ƯCLN của 2 số nguyên                                                -Nam-
        private long GCD(long a, long b)
        {
            a = Math.Abs(a); 
            b = Math.Abs(b);
            while (b != 0) 
            { 
                long temp = b; b = a % b; a = temp; 
            }
            return a;
        }

        // Chuyển độ sang radian                                                -Nam-
        private double ToRad(object x)
        {
            double deg = Convert.ToDouble(x);
            return deg * Math.PI / 180;
        }

        // Cho phép nhập liệu bàn phím                                                -Kha-
        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false; // Cho phép nhập liệu bàn phím
        }
    }
}
