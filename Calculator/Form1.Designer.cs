namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btnFraction = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnOpenParen = new System.Windows.Forms.Button();
            this.btnCloseParen = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnSinInv = new System.Windows.Forms.Button();
            this.btnCosInv = new System.Windows.Forms.Button();
            this.btnTanInv = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnTenPower = new System.Windows.Forms.Button();
            this.btnCubicRoot = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnXRootY = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnSD = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.lblExpression = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(207, 139);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(194, 44);
            this.txtDisplay.TabIndex = 47;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(64, 525);
            this.btn1.Margin = new System.Windows.Forms.Padding(2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 39);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(123, 525);
            this.btn2.Margin = new System.Windows.Forms.Padding(2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 39);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(64, 481);
            this.btn4.Margin = new System.Windows.Forms.Padding(2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 39);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(183, 525);
            this.btn3.Margin = new System.Windows.Forms.Padding(2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 39);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(123, 480);
            this.btn5.Margin = new System.Windows.Forms.Padding(2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 39);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(64, 569);
            this.btn0.Margin = new System.Windows.Forms.Padding(2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 39);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(183, 437);
            this.btn9.Margin = new System.Windows.Forms.Padding(2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 39);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(123, 437);
            this.btn8.Margin = new System.Windows.Forms.Padding(2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 39);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(64, 437);
            this.btn7.Margin = new System.Windows.Forms.Padding(2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 39);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(183, 481);
            this.btn6.Margin = new System.Windows.Forms.Padding(2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 39);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(303, 481);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(56, 40);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.DarkGray;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(243, 569);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 39);
            this.btnDiv.TabIndex = 15;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.DarkGray;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(243, 525);
            this.btnMul.Margin = new System.Windows.Forms.Padding(2);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(56, 39);
            this.btnMul.TabIndex = 14;
            this.btnMul.Text = "X";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.DarkGray;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(243, 482);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(56, 39);
            this.btnMin.TabIndex = 13;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.DarkGray;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(243, 437);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(56, 39);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.DarkGray;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(183, 569);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(56, 39);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.White;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(123, 569);
            this.btnDot.Margin = new System.Windows.Forms.Padding(2);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(56, 39);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.Color.Black;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSqrt.Location = new System.Drawing.Point(183, 297);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(56, 39);
            this.btnSqrt.TabIndex = 19;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Black;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSquare.Location = new System.Drawing.Point(303, 340);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(2);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(56, 39);
            this.btnSquare.TabIndex = 20;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.BackColor = System.Drawing.Color.Black;
            this.btnNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNegate.Location = new System.Drawing.Point(64, 340);
            this.btnNegate.Margin = new System.Windows.Forms.Padding(2);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(55, 39);
            this.btnNegate.TabIndex = 21;
            this.btnNegate.Text = "±";
            this.btnNegate.UseVisualStyleBackColor = false;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // btnFraction
            // 
            this.btnFraction.BackColor = System.Drawing.Color.Black;
            this.btnFraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFraction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFraction.Location = new System.Drawing.Point(183, 383);
            this.btnFraction.Margin = new System.Windows.Forms.Padding(2);
            this.btnFraction.Name = "btnFraction";
            this.btnFraction.Size = new System.Drawing.Size(56, 39);
            this.btnFraction.TabIndex = 22;
            this.btnFraction.Text = "x/y";
            this.btnFraction.UseVisualStyleBackColor = false;
            this.btnFraction.Click += new System.EventHandler(this.btnFraction_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.Black;
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPercent.Location = new System.Drawing.Point(243, 383);
            this.btnPercent.Margin = new System.Windows.Forms.Padding(2);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(56, 39);
            this.btnPercent.TabIndex = 23;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnPow
            // 
            this.btnPow.BackColor = System.Drawing.Color.Black;
            this.btnPow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPow.Location = new System.Drawing.Point(183, 340);
            this.btnPow.Margin = new System.Windows.Forms.Padding(2);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(56, 39);
            this.btnPow.TabIndex = 24;
            this.btnPow.Text = "xʸ";
            this.btnPow.UseVisualStyleBackColor = false;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDel.Location = new System.Drawing.Point(303, 437);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(56, 39);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "DEL";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.BackColor = System.Drawing.Color.White;
            this.btnMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMinus.Location = new System.Drawing.Point(303, 569);
            this.btnMMinus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(56, 39);
            this.btnMMinus.TabIndex = 26;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = false;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.BackColor = System.Drawing.Color.White;
            this.btnMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPlus.Location = new System.Drawing.Point(303, 525);
            this.btnMPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(56, 40);
            this.btnMPlus.TabIndex = 27;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = false;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnOpenParen
            // 
            this.btnOpenParen.BackColor = System.Drawing.Color.Black;
            this.btnOpenParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenParen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenParen.Location = new System.Drawing.Point(64, 383);
            this.btnOpenParen.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenParen.Name = "btnOpenParen";
            this.btnOpenParen.Size = new System.Drawing.Size(56, 39);
            this.btnOpenParen.TabIndex = 28;
            this.btnOpenParen.Text = "(";
            this.btnOpenParen.UseVisualStyleBackColor = false;
            this.btnOpenParen.Click += new System.EventHandler(this.btnOpenParen_Click);
            // 
            // btnCloseParen
            // 
            this.btnCloseParen.BackColor = System.Drawing.Color.Black;
            this.btnCloseParen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseParen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCloseParen.Location = new System.Drawing.Point(123, 383);
            this.btnCloseParen.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseParen.Name = "btnCloseParen";
            this.btnCloseParen.Size = new System.Drawing.Size(56, 39);
            this.btnCloseParen.TabIndex = 28;
            this.btnCloseParen.Text = ")";
            this.btnCloseParen.UseVisualStyleBackColor = false;
            this.btnCloseParen.Click += new System.EventHandler(this.btnCloseParen_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.Black;
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFactorial.Location = new System.Drawing.Point(303, 383);
            this.btnFactorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(56, 39);
            this.btnFactorial.TabIndex = 30;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.Black;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSin.Location = new System.Drawing.Point(183, 211);
            this.btnSin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(56, 39);
            this.btnSin.TabIndex = 31;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.Black;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCos.Location = new System.Drawing.Point(243, 211);
            this.btnCos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(56, 39);
            this.btnCos.TabIndex = 32;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.Black;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTan.Location = new System.Drawing.Point(303, 211);
            this.btnTan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(56, 39);
            this.btnTan.TabIndex = 33;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnSinInv
            // 
            this.btnSinInv.BackColor = System.Drawing.Color.Black;
            this.btnSinInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinInv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSinInv.Location = new System.Drawing.Point(183, 254);
            this.btnSinInv.Margin = new System.Windows.Forms.Padding(2);
            this.btnSinInv.Name = "btnSinInv";
            this.btnSinInv.Size = new System.Drawing.Size(56, 39);
            this.btnSinInv.TabIndex = 34;
            this.btnSinInv.Text = "sin⁻¹";
            this.btnSinInv.UseVisualStyleBackColor = false;
            this.btnSinInv.Click += new System.EventHandler(this.btnSinInv_Click);
            // 
            // btnCosInv
            // 
            this.btnCosInv.BackColor = System.Drawing.Color.Black;
            this.btnCosInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosInv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCosInv.Location = new System.Drawing.Point(243, 254);
            this.btnCosInv.Margin = new System.Windows.Forms.Padding(2);
            this.btnCosInv.Name = "btnCosInv";
            this.btnCosInv.Size = new System.Drawing.Size(56, 39);
            this.btnCosInv.TabIndex = 35;
            this.btnCosInv.Text = "cos⁻¹";
            this.btnCosInv.UseVisualStyleBackColor = false;
            this.btnCosInv.Click += new System.EventHandler(this.btnCosInv_Click);
            // 
            // btnTanInv
            // 
            this.btnTanInv.BackColor = System.Drawing.Color.Black;
            this.btnTanInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanInv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTanInv.Location = new System.Drawing.Point(303, 254);
            this.btnTanInv.Margin = new System.Windows.Forms.Padding(2);
            this.btnTanInv.Name = "btnTanInv";
            this.btnTanInv.Size = new System.Drawing.Size(56, 39);
            this.btnTanInv.TabIndex = 36;
            this.btnTanInv.Text = "tan⁻¹";
            this.btnTanInv.UseVisualStyleBackColor = false;
            this.btnTanInv.Click += new System.EventHandler(this.btnTanInv_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.Color.Black;
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLn.Location = new System.Drawing.Point(64, 297);
            this.btnLn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(56, 39);
            this.btnLn.TabIndex = 37;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Black;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLog.Location = new System.Drawing.Point(124, 297);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(56, 39);
            this.btnLog.TabIndex = 38;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnTenPower
            // 
            this.btnTenPower.BackColor = System.Drawing.Color.Black;
            this.btnTenPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenPower.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTenPower.Location = new System.Drawing.Point(123, 340);
            this.btnTenPower.Margin = new System.Windows.Forms.Padding(2);
            this.btnTenPower.Name = "btnTenPower";
            this.btnTenPower.Size = new System.Drawing.Size(56, 39);
            this.btnTenPower.TabIndex = 39;
            this.btnTenPower.Text = "10ˣ";
            this.btnTenPower.UseVisualStyleBackColor = false;
            this.btnTenPower.Click += new System.EventHandler(this.btnTenPower_Click);
            // 
            // btnCubicRoot
            // 
            this.btnCubicRoot.BackColor = System.Drawing.Color.Black;
            this.btnCubicRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCubicRoot.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCubicRoot.Location = new System.Drawing.Point(243, 297);
            this.btnCubicRoot.Margin = new System.Windows.Forms.Padding(2);
            this.btnCubicRoot.Name = "btnCubicRoot";
            this.btnCubicRoot.Size = new System.Drawing.Size(56, 39);
            this.btnCubicRoot.TabIndex = 40;
            this.btnCubicRoot.Text = "³√x";
            this.btnCubicRoot.UseVisualStyleBackColor = false;
            this.btnCubicRoot.Click += new System.EventHandler(this.btnCubicRoot_Click);
            // 
            // btnCube
            // 
            this.btnCube.BackColor = System.Drawing.Color.Black;
            this.btnCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCube.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCube.Location = new System.Drawing.Point(243, 340);
            this.btnCube.Margin = new System.Windows.Forms.Padding(2);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(56, 39);
            this.btnCube.TabIndex = 41;
            this.btnCube.Text = "x³";
            this.btnCube.UseVisualStyleBackColor = false;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnXRootY
            // 
            this.btnXRootY.BackColor = System.Drawing.Color.Black;
            this.btnXRootY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXRootY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXRootY.Location = new System.Drawing.Point(303, 297);
            this.btnXRootY.Margin = new System.Windows.Forms.Padding(2);
            this.btnXRootY.Name = "btnXRootY";
            this.btnXRootY.Size = new System.Drawing.Size(56, 39);
            this.btnXRootY.TabIndex = 42;
            this.btnXRootY.Text = "ˣ√y";
            this.btnXRootY.UseVisualStyleBackColor = false;
            this.btnXRootY.Click += new System.EventHandler(this.btnXRootY_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.Black;
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPi.Location = new System.Drawing.Point(63, 254);
            this.btnPi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(56, 39);
            this.btnPi.TabIndex = 43;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.Black;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnE.Location = new System.Drawing.Point(123, 254);
            this.btnE.Margin = new System.Windows.Forms.Padding(2);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(56, 39);
            this.btnE.TabIndex = 44;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnSD
            // 
            this.btnSD.BackColor = System.Drawing.Color.Black;
            this.btnSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSD.Location = new System.Drawing.Point(123, 211);
            this.btnSD.Margin = new System.Windows.Forms.Padding(2);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(56, 39);
            this.btnSD.TabIndex = 45;
            this.btnSD.Text = "S⇔D";
            this.btnSD.UseVisualStyleBackColor = false;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOff.Location = new System.Drawing.Point(64, 211);
            this.btnOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(56, 39);
            this.btnOff.TabIndex = 46;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // lblExpression
            // 
            this.lblExpression.BackColor = System.Drawing.Color.White;
            this.lblExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpression.Location = new System.Drawing.Point(12, 9);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(398, 184);
            this.lblExpression.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(422, 644);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnSD);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnXRootY);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnCubicRoot);
            this.Controls.Add(this.btnTenPower);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnTanInv);
            this.Controls.Add(this.btnCosInv);
            this.Controls.Add(this.btnSinInv);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnCloseParen);
            this.Controls.Add(this.btnOpenParen);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMMinus);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnFraction);
            this.Controls.Add(this.btnNegate);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btnOperator_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Button btnFraction;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnOpenParen;
        private System.Windows.Forms.Button btnCloseParen;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnSinInv;
        private System.Windows.Forms.Button btnCosInv;
        private System.Windows.Forms.Button btnTanInv;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnTenPower;
        private System.Windows.Forms.Button btnCubicRoot;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnXRootY;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label lblExpression;
    }
}

