namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtExpression = new TextBox();
            txtResult = new TextBox();
            label1 = new Label();
            btnce = new Button();
            btnc = new Button();
            butdel = new Button();
            button4 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            button8 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            button12 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            button17 = new Button();
            btn0 = new Button();
            button19 = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtExpression
            // 
            txtExpression.Location = new Point(33, 89);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(295, 23);
            txtExpression.TabIndex = 0;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(33, 140);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(295, 23);
            txtResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F);
            label1.Location = new Point(33, 33);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 2;
            label1.Text = "SimpleCalculator";
            label1.Click += label1_Click;
            // 
            // btnce
            // 
            btnce.Font = new Font("맑은 고딕", 11F, FontStyle.Bold);
            btnce.Location = new Point(33, 194);
            btnce.Name = "btnce";
            btnce.Size = new Size(69, 38);
            btnce.TabIndex = 3;
            btnce.Text = "CE";
            btnce.UseVisualStyleBackColor = true;
            btnce.Click += CE_Click;
            // 
            // btnc
            // 
            btnc.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnc.Location = new Point(108, 194);
            btnc.Name = "btnc";
            btnc.Size = new Size(69, 38);
            btnc.TabIndex = 4;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += C_Click;
            // 
            // butdel
            // 
            butdel.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            butdel.Location = new Point(184, 194);
            butdel.Name = "butdel";
            butdel.Size = new Size(69, 38);
            butdel.TabIndex = 5;
            butdel.Text = "del";
            butdel.UseVisualStyleBackColor = true;
            butdel.Click += del_Click;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button4.Location = new Point(259, 194);
            button4.Name = "button4";
            button4.Size = new Size(69, 38);
            button4.TabIndex = 6;
            button4.Text = "÷";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btndiv_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn7.Location = new Point(33, 238);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 38);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn8.Location = new Point(109, 238);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 38);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn9.Location = new Point(184, 238);
            btn9.Name = "btn9";
            btn9.Size = new Size(69, 38);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // button8
            // 
            button8.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            button8.Location = new Point(259, 238);
            button8.Name = "button8";
            button8.Size = new Size(69, 38);
            button8.TabIndex = 10;
            button8.Text = "×";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnmul_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn4.Location = new Point(33, 282);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 38);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn5.Location = new Point(108, 282);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 38);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn6.Location = new Point(184, 282);
            btn6.Name = "btn6";
            btn6.Size = new Size(69, 38);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // button12
            // 
            button12.Font = new Font("맑은 고딕", 15.25F, FontStyle.Bold);
            button12.Location = new Point(259, 282);
            button12.Name = "button12";
            button12.Size = new Size(69, 38);
            button12.TabIndex = 14;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnmin_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn1.Location = new Point(33, 326);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 38);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn2.Location = new Point(108, 326);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 38);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn3.Location = new Point(184, 326);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 38);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btnPlus.Location = new Point(259, 326);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(69, 38);
            btnPlus.TabIndex = 18;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnpl_Click;
            // 
            // button17
            // 
            button17.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            button17.Location = new Point(33, 370);
            button17.Name = "button17";
            button17.Size = new Size(69, 38);
            button17.TabIndex = 19;
            button17.Text = "+/-";
            button17.UseVisualStyleBackColor = true;
            button17.Click += btnpm_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btn0.Location = new Point(108, 370);
            btn0.Name = "btn0";
            btn0.Size = new Size(69, 38);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // button19
            // 
            button19.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            button19.Location = new Point(184, 370);
            button19.Name = "button19";
            button19.Size = new Size(69, 38);
            button19.TabIndex = 21;
            button19.Text = ".";
            button19.UseVisualStyleBackColor = true;
            button19.Click += btndot_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold);
            btnEqual.Location = new Point(259, 370);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(69, 38);
            btnEqual.TabIndex = 22;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(btnEqual);
            Controls.Add(button19);
            Controls.Add(btn0);
            Controls.Add(button17);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(button12);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(button8);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(button4);
            Controls.Add(butdel);
            Controls.Add(btnc);
            Controls.Add(btnce);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(txtExpression);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExpression;
        private TextBox txtResult;
        private Label label1;
        private Button btnce;
        private Button btnc;
        private Button butdel;
        private Button button4;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button button8;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button button12;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button button17;
        private Button btn0;
        private Button button19;
        private Button btnEqual;
    }
}
