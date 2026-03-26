namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // ----- 변수 -----
        string currentInput = "";
        int firstNumber = 0;
        string op = "";
        bool isNewInput = false;

        public Form1()
        {
            InitializeComponent();
        }

        // ----- 숫자 입력 공통 -----
        private void InputNumber(string num)
        {
            if (isNewInput)
            {
                currentInput = "";
                isNewInput = false;
            }

            currentInput += num;

            // 위: 수식 누적
            txtExpression.Text += num;
        }

        // ----- 숫자 버튼 -----
        private void btn0_Click(object sender, EventArgs e) { InputNumber("0"); }
        private void btn1_Click(object sender, EventArgs e) { InputNumber("1"); }
        private void btn2_Click(object sender, EventArgs e) { InputNumber("2"); }
        private void btn3_Click(object sender, EventArgs e) { InputNumber("3"); }
        private void btn4_Click(object sender, EventArgs e) { InputNumber("4"); }
        private void btn5_Click(object sender, EventArgs e) { InputNumber("5"); }
        private void btn6_Click(object sender, EventArgs e) { InputNumber("6"); }
        private void btn7_Click(object sender, EventArgs e) { InputNumber("7"); }
        private void btn8_Click(object sender, EventArgs e) { InputNumber("8"); }
        private void btn9_Click(object sender, EventArgs e) { InputNumber("9"); }

        // ----- + 버튼 -----
        private void btnpl_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "+";

            txtExpression.Text += " + ";
            isNewInput = true;
        }

        // ----- = 버튼 -----
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (currentInput == "" || op == "") return;

            int secondNumber = int.Parse(currentInput);
            int result = 0;

            if (op == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (op == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (op == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (op == "/")
            {
                if (secondNumber == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.");
                    return;
                }

                result = firstNumber / secondNumber;
            }

            // 아래: 결과만 표시
            txtResult.Text = result.ToString();

            currentInput = result.ToString();
            op = "";
            isNewInput = true;
        }

        // ----- 나머지 버튼 유지 -----
        private void btnmin_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "-";

            txtExpression.Text += " - ";
            isNewInput = true;
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "*";

            txtExpression.Text += " × ";
            isNewInput = true;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "/";

            txtExpression.Text += " ÷ ";
            isNewInput = true;
        }

        private void btndot_Click(object sender, EventArgs e) { }

        private void btnpm_Click(object sender, EventArgs e) { }

        private void C_Click(object sender, EventArgs e) { }

        private void CE_Click(object sender, EventArgs e) { }

        private void del_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}