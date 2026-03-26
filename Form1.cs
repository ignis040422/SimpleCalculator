using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // ===== 변수 =====
        string currentInput = "";
        int firstNumber = 0;
        string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        // ===== 숫자 버튼 =====
        private void btn0_Click(object sender, EventArgs e)
        {
            currentInput += "0";
            txtResult.Text = currentInput;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            currentInput += "1";
            txtResult.Text = currentInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            currentInput += "2";
            txtResult.Text = currentInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            currentInput += "3";
            txtResult.Text = currentInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            currentInput += "4";
            txtResult.Text = currentInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            currentInput += "5";
            txtResult.Text = currentInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            currentInput += "6";
            txtResult.Text = currentInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            currentInput += "7";
            txtResult.Text = currentInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            currentInput += "8";
            txtResult.Text = currentInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            currentInput += "9";
            txtResult.Text = currentInput;
        }

        // ===== + 버튼 =====
        private void btnpl_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "+";

            txtExpression.Text = currentInput + " + ";
            currentInput = "";
        }

        // ===== = 버튼 =====
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (currentInput == "" || op == "") return;

            int secondNumber = int.Parse(currentInput);
            int result = firstNumber + secondNumber;

            txtExpression.Text = firstNumber + " + " + secondNumber + " = " + result;
            txtResult.Text = result.ToString();

            currentInput = result.ToString();
            op = "";
        }

        // ===== 아래는 네가 만든 버튼들 (삭제 안 함 / 빈 상태 유지 or 최소 처리) =====

        private void btnmin_Click(object sender, EventArgs e)
        {
            // 과제1에서는 사용 안 함
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            // 과제1에서는 사용 안 함
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            // 과제1에서는 사용 안 함
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            // 과제1에서는 사용 안 함
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            // 과제1에서는 사용 안 함
        }

        private void C_Click(object sender, EventArgs e)
        {
            // 과제1에서는 사용 안 함
        }

        private void CE_Click(object sender, EventArgs e)
        {
            // 과제1에서는 사용 안 함
        }

        private void del_Click(object sender, EventArgs e)
        {
            // 과제1에서는 사용 안 함
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}