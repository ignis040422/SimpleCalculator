using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // ===== 변수 선언 =====
        string currentInput = "";   // 현재 입력 중인 숫자
        int firstNumber = 0;        // 첫 번째 피연산자
        string op = "";             // 연산자 저장
        bool isNewInput = false;    // 새 숫자 입력 시작 여부

        // ===== 생성자 =====
        public Form1()
        {
            InitializeComponent();
        }

        // ===== 숫자 입력 공통 처리 =====
        private void InputNumber(string num)
        {
            // 연산 직후 새 입력이면 현재 입력값 초기화
            if (isNewInput)
            {
                currentInput = "";
                isNewInput = false;
            }

            // 숫자 누적
            currentInput += num;

            // 위쪽 수식창에 표시
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
            if (currentInput == "") return;

            firstNumber = int.Parse(currentInput);
            op = "+";
            txtExpression.Text += " + ";
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

            // 아래쪽 결과창에만 결과 표시
            txtResult.Text = result.ToString();

            // 결과를 다음 계산에 활용 가능하게 저장
            currentInput = result.ToString();
            op = "";
            isNewInput = true;
        }

        // ===== Del 버튼 =====
        private void del_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            // 현재 입력값 마지막 글자 삭제
            currentInput = currentInput.Substring(0, currentInput.Length - 1);

            // 위쪽 수식창 마지막 글자 삭제
            if (txtExpression.Text.Length > 0)
            {
                txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);
            }
        }

        // ===== C 버튼 =====
        private void C_Click(object sender, EventArgs e)
        {
            currentInput = "";
            firstNumber = 0;
            op = "";
            isNewInput = false;

            txtExpression.Text = "";
            txtResult.Text = "";
        }

        // ===== CE 버튼 =====
        // 네가 요청한 방식: 위/아래 모두 전체 초기화
        private void CE_Click(object sender, EventArgs e)
        {
            currentInput = "";
            firstNumber = 0;
            op = "";
            isNewInput = false;

            txtExpression.Text = "";
            txtResult.Text = "";
        }

        // ===== 기타 버튼 =====
        private void btndot_Click(object sender, EventArgs e)
        {
            // 아직 사용 안 함
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            // 아직 사용 안 함
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // 라벨 클릭 이벤트
        }
    }
}