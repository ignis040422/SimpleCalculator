namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // ===== 변수 =====
        string currentInput = "";   // 현재 입력된 숫자 저장
        int firstNumber = 0;        // 첫 번째 피연산자
        string op = "";             // 연산자 (+, -, *, /)
        bool isNewInput = false;    // 새로운 숫자 입력 여부

        public Form1()
        {
            InitializeComponent();
        }

        // ===== 숫자 입력 공통 처리 =====
        private void InputNumber(string num)
        {
            // 연산 후 새로운 입력 시작 시 초기화
            if (isNewInput)
            {
                currentInput = "";
                isNewInput = false;
            }

            // 숫자 누적 입력
            currentInput += num;

            // 위 TextBox에 수식 형태로 표시
            txtExpression.Text += num;
        }

        // ===== 숫자 버튼 =====
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

        // ===== + 버튼 =====
        private void btnpl_Click(object sender, EventArgs e)
        {
            // 입력값 없으면 실행 안 함
            if (currentInput == "") return;

            // 첫 번째 숫자 저장
            firstNumber = int.Parse(currentInput);

            // 연산자 설정
            op = "+";

            // 수식 표시
            txtExpression.Text += " + ";

            // 다음 입력 준비
            isNewInput = true;
        }

        // ===== - 버튼 =====
        private void btnmin_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "-";

            txtExpression.Text += " - ";
            isNewInput = true;
        }

        // ===== × 버튼 =====
        private void btnmul_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "*";

            txtExpression.Text += " × ";
            isNewInput = true;
        }

        // ===== ÷ 버튼 =====
        private void btndiv_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "/";

            txtExpression.Text += " ÷ ";
            isNewInput = true;
        }

        // ===== = 버튼 =====
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 입력값 또는 연산자 없으면 실행 안 함
            if (currentInput == "" || op == "") return;

            int secondNumber = int.Parse(currentInput); // 두 번째 숫자
            int result = 0; // 결과 저장 변수

            // 연산자에 따라 계산 수행
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
                // 0으로 나누는 경우 예외 처리
                if (secondNumber == 0)
                {
                    MessageBox.Show("0으로 나눌 수 없습니다.");
                    return;
                }

                result = firstNumber / secondNumber;
            }

            // 아래 TextBox에 결과 출력
            txtResult.Text = result.ToString();

            // 결과를 다음 계산에 사용 가능하도록 저장
            currentInput = result.ToString();
            op = "";
            isNewInput = true;
        }

        // ===== 기타 버튼 =====
        private void btndot_Click(object sender, EventArgs e) { }   // 소수점 (미구현)
        private void btnpm_Click(object sender, EventArgs e) { }    // 부호 변경 (미구현)
        private void C_Click(object sender, EventArgs e) { }        // 전체 초기화 (과제3)
        private void CE_Click(object sender, EventArgs e) { }       // 현재 입력 삭제 (과제3)
        private void del_Click(object sender, EventArgs e) { }      // 한 글자 삭제 (과제3)
        private void label1_Click(object sender, EventArgs e) { }   // 라벨 이벤트
    }
}