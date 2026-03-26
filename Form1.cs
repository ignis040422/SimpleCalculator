using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // 현재 입력 중인 숫자
        string currentInput = "";

        // 마지막에 새 입력을 시작해야 하는지 여부
        bool isNewInput = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 숫자 입력 공통 처리
        private void InputNumber(string num)
        {
            // = 계산 직후 새 숫자를 입력하면 새로 시작
            if (isNewInput)
            {
                txtExpression.Text = "";
                txtResult.Text = "";
                currentInput = "";
                isNewInput = false;
            }

            currentInput += num;
            txtExpression.Text += num;
        }

        // 현재 수식의 마지막 숫자 부분만 찾아서 currentInput에 맞게 바꿔주는 함수
        private void ReplaceCurrentInputInExpression()
        {
            string expr = txtExpression.Text;

            if (expr == "")
            {
                txtExpression.Text = currentInput;
                return;
            }

            int plusIndex = expr.LastIndexOf(" + ");
            int minusIndex = expr.LastIndexOf(" - ");
            int mulIndex = expr.LastIndexOf(" × ");
            int divIndex = expr.LastIndexOf(" ÷ ");

            int lastOperatorIndex = Math.Max(
                Math.Max(plusIndex, minusIndex),
                Math.Max(mulIndex, divIndex)
            );

            if (lastOperatorIndex == -1)
            {
                // 연산자가 없으면 전체를 현재 입력값으로 교체
                txtExpression.Text = currentInput;
            }
            else
            {
                // 마지막 연산자 뒤의 숫자만 현재 입력값으로 교체
                string leftPart = expr.Substring(0, lastOperatorIndex + 3);
                txtExpression.Text = leftPart + currentInput;
            }
        }

        // 숫자 버튼
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

        // + 버튼
        private void btnpl_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "") return;

            // 연산자 연속 입력 방지
            if (txtExpression.Text.EndsWith(" + ") ||
                txtExpression.Text.EndsWith(" - ") ||
                txtExpression.Text.EndsWith(" × ") ||
                txtExpression.Text.EndsWith(" ÷ "))
                return;

            txtExpression.Text += " + ";
            currentInput = "";
            isNewInput = false;
        }

        // - 버튼
        private void btnmin_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "") return;

            if (txtExpression.Text.EndsWith(" + ") ||
                txtExpression.Text.EndsWith(" - ") ||
                txtExpression.Text.EndsWith(" × ") ||
                txtExpression.Text.EndsWith(" ÷ "))
                return;

            txtExpression.Text += " - ";
            currentInput = "";
            isNewInput = false;
        }

        // × 버튼
        private void btnmul_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "") return;

            if (txtExpression.Text.EndsWith(" + ") ||
                txtExpression.Text.EndsWith(" - ") ||
                txtExpression.Text.EndsWith(" × ") ||
                txtExpression.Text.EndsWith(" ÷ "))
                return;

            txtExpression.Text += " × ";
            currentInput = "";
            isNewInput = false;
        }

        // ÷ 버튼
        private void btndiv_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "") return;

            if (txtExpression.Text.EndsWith(" + ") ||
                txtExpression.Text.EndsWith(" - ") ||
                txtExpression.Text.EndsWith(" × ") ||
                txtExpression.Text.EndsWith(" ÷ "))
                return;

            txtExpression.Text += " ÷ ";
            currentInput = "";
            isNewInput = false;
        }

        // = 버튼
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "") return;

            try
            {
                // 마지막이 연산자로 끝나면 계산하지 않음
                if (txtExpression.Text.EndsWith(" + ") ||
                    txtExpression.Text.EndsWith(" - ") ||
                    txtExpression.Text.EndsWith(" × ") ||
                    txtExpression.Text.EndsWith(" ÷ "))
                    return;

                // 계산 가능한 형태로 변환
                string expression = txtExpression.Text
                    .Replace("×", "*")
                    .Replace("÷", "/");

                var result = new DataTable().Compute(expression, "");

                txtResult.Text = result.ToString();
                currentInput = result.ToString();
                isNewInput = true;
            }
            catch
            {
                MessageBox.Show("계산 오류");
            }
        }

        // Del 버튼
        private void del_Click(object sender, EventArgs e)
        {
            if (isNewInput) return;
            if (txtExpression.Text == "") return;

            // 마지막 한 글자 삭제
            txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);

            // currentInput 다시 계산
            string expr = txtExpression.Text;

            int plusIndex = expr.LastIndexOf(" + ");
            int minusIndex = expr.LastIndexOf(" - ");
            int mulIndex = expr.LastIndexOf(" × ");
            int divIndex = expr.LastIndexOf(" ÷ ");

            int lastOperatorIndex = Math.Max(
                Math.Max(plusIndex, minusIndex),
                Math.Max(mulIndex, divIndex)
            );

            if (lastOperatorIndex == -1)
                currentInput = expr;
            else
                currentInput = expr.Substring(lastOperatorIndex + 3);
        }

        // C 버튼
        private void C_Click(object sender, EventArgs e)
        {
            currentInput = "";
            isNewInput = false;
            txtExpression.Text = "";
            txtResult.Text = "";
        }

        // CE 버튼
        // 네가 요청한 대로 전체 초기화
        private void CE_Click(object sender, EventArgs e)
        {
            currentInput = "";
            isNewInput = false;
            txtExpression.Text = "";
            txtResult.Text = "";
        }

        // . 버튼
        private void btndot_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                txtExpression.Text = "";
                txtResult.Text = "";
                currentInput = "";
                isNewInput = false;
            }

            // 현재 입력값에 이미 소수점이 있으면 추가 안 함
            if (currentInput.Contains(".")) return;

            if (currentInput == "")
            {
                currentInput = "0";
                txtExpression.Text += "0";
            }

            currentInput += ".";
            txtExpression.Text += ".";
        }

        // ± 버튼
        private void btnpm_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;
            if (isNewInput) return;

            if (currentInput.StartsWith("-"))
                currentInput = currentInput.Substring(1);
            else
                currentInput = "-" + currentInput;

            ReplaceCurrentInputInExpression();
        }

        // 라벨 이벤트
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}