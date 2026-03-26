using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        bool isNewInput = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 숫자 입력
        private void InputNumber(string num)
        {
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

        // 연산자 입력 공통
        private void InputOperator(string op)
        {
            if (txtExpression.Text == "") return;

            if (txtExpression.Text.EndsWith(" + ") ||
                txtExpression.Text.EndsWith(" - ") ||
                txtExpression.Text.EndsWith(" × ") ||
                txtExpression.Text.EndsWith(" ÷ "))
                return;

            txtExpression.Text += op;
            currentInput = "";
            isNewInput = false;
        }

        // 현재 입력 숫자 부분만 교체
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
                txtExpression.Text = currentInput;
            }
            else
            {
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

        // 사칙연산 버튼
        private void btnpl_Click(object sender, EventArgs e) { InputOperator(" + "); }
        private void btnmin_Click(object sender, EventArgs e) { InputOperator(" - "); }
        private void btnmul_Click(object sender, EventArgs e) { InputOperator(" × "); }
        private void btndiv_Click(object sender, EventArgs e) { InputOperator(" ÷ "); }

        // 왼쪽 괄호 (
        private void btnLeftParen_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                txtExpression.Text = "";
                txtResult.Text = "";
                currentInput = "";
                isNewInput = false;
            }

            // 숫자나 ) 바로 뒤에는 곱셈 자동 추가
            if (txtExpression.Text.Length > 0)
            {
                char last = txtExpression.Text[txtExpression.Text.Length - 1];
                if (char.IsDigit(last) || last == ')' || last == '.')
                {
                    txtExpression.Text += " × ";
                }
            }

            txtExpression.Text += "(";
            currentInput = "";
        }

        // 오른쪽 괄호 )
        private void btnRightParen_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "") return;

            char last = txtExpression.Text[txtExpression.Text.Length - 1];
            if (last == '(') return;

            if (txtExpression.Text.EndsWith(" + ") ||
                txtExpression.Text.EndsWith(" - ") ||
                txtExpression.Text.EndsWith(" × ") ||
                txtExpression.Text.EndsWith(" ÷ "))
                return;

            int openCount = 0;
            int closeCount = 0;

            foreach (char c in txtExpression.Text)
            {
                if (c == '(') openCount++;
                if (c == ')') closeCount++;
            }

            if (openCount > closeCount)
            {
                txtExpression.Text += ")";
            }
        }

        // 루트 버튼 √
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (isNewInput)
            {
                txtExpression.Text = "";
                txtResult.Text = "";
                currentInput = "";
                isNewInput = false;
            }

            // 숫자나 ) 뒤에 루트가 오면 곱셈 처리
            if (txtExpression.Text.Length > 0)
            {
                char last = txtExpression.Text[txtExpression.Text.Length - 1];
                if (char.IsDigit(last) || last == ')' || last == '.')
                {
                    txtExpression.Text += " × ";
                }
            }

            txtExpression.Text += "√(";
            currentInput = "";
        }

        // = 버튼
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "") return;

            try
            {
                if (txtExpression.Text.EndsWith(" + ") ||
                    txtExpression.Text.EndsWith(" - ") ||
                    txtExpression.Text.EndsWith(" × ") ||
                    txtExpression.Text.EndsWith(" ÷ "))
                    return;

                string originalExpression = txtExpression.Text;

                // 괄호 자동 닫기
                int openCount = 0;
                int closeCount = 0;
                foreach (char c in originalExpression)
                {
                    if (c == '(') openCount++;
                    if (c == ')') closeCount++;
                }

                while (openCount > closeCount)
                {
                    originalExpression += ")";
                    closeCount++;
                }

                string expression = originalExpression
                    .Replace("×", "*")
                    .Replace("÷", "/")
                    .Replace(" ", "");

                double result = ExpressionEvaluator.Evaluate(expression);
                string resultText = result.ToString();

                txtExpression.Text = originalExpression + " = " + resultText;
                txtResult.Text = resultText;
                currentInput = resultText;
                isNewInput = true;
            }
            catch
            {
                MessageBox.Show("계산 오류");
            }
        }

        // Del 버튼 - 한 글자 삭제
        private void del_Click(object sender, EventArgs e)
        {
            if (isNewInput) return;
            if (txtExpression.Text == "") return;

            txtExpression.Text = txtExpression.Text.Substring(0, txtExpression.Text.Length - 1);

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

        // C 버튼 - 전체 삭제
        private void C_Click(object sender, EventArgs e)
        {
            currentInput = "";
            isNewInput = false;
            txtExpression.Text = "";
            txtResult.Text = "";
        }

        // CE 버튼 - 마지막 숫자만 삭제
        private void CE_Click(object sender, EventArgs e)
        {
            if (txtExpression.Text == "") return;
            if (isNewInput) return;

            string expr = txtExpression.Text;

            int i = expr.Length - 1;

            while (i >= 0 && (char.IsDigit(expr[i]) || expr[i] == '.'))
            {
                i--;
            }

            if (i < expr.Length - 1)
            {
                txtExpression.Text = expr.Substring(0, i + 1);
                currentInput = "";
            }
            else
            {
                txtExpression.Text = "";
                currentInput = "";
            }
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    // 괄호, 사칙연산, 루트 지원 계산기 파서
    public class ExpressionEvaluator
    {
        private string text;
        private int pos;

        private ExpressionEvaluator(string expression)
        {
            text = expression;
            pos = 0;
        }

        public static double Evaluate(string expression)
        {
            var parser = new ExpressionEvaluator(expression);
            double value = parser.ParseExpression();

            if (parser.pos < parser.text.Length)
                throw new Exception("잘못된 수식");

            return value;
        }

        // +, -
        private double ParseExpression()
        {
            double value = ParseTerm();

            while (pos < text.Length)
            {
                if (Match('+'))
                {
                    value += ParseTerm();
                }
                else if (Match('-'))
                {
                    value -= ParseTerm();
                }
                else
                {
                    break;
                }
            }

            return value;
        }

        // *, /
        private double ParseTerm()
        {
            double value = ParseFactor();

            while (pos < text.Length)
            {
                if (Match('*'))
                {
                    value *= ParseFactor();
                }
                else if (Match('/'))
                {
                    double divisor = ParseFactor();
                    if (divisor == 0)
                        throw new DivideByZeroException();

                    value /= divisor;
                }
                else
                {
                    break;
                }
            }

            return value;
        }

        // 숫자, 괄호, 루트, 음수
        private double ParseFactor()
        {
            if (Match('+'))
                return ParseFactor();

            if (Match('-'))
                return -ParseFactor();

            if (Match('√'))
            {
                double value = ParseFactor();
                if (value < 0)
                    throw new Exception("음수의 루트 불가");

                return Math.Sqrt(value);
            }

            if (Match('('))
            {
                double value = ParseExpression();

                if (!Match(')'))
                    throw new Exception("괄호 오류");

                return value;
            }

            return ParseNumber();
        }

        private double ParseNumber()
        {
            int start = pos;

            while (pos < text.Length && (char.IsDigit(text[pos]) || text[pos] == '.'))
            {
                pos++;
            }

            if (start == pos)
                throw new Exception("숫자 오류");

            string number = text.Substring(start, pos - start);
            return double.Parse(number);
        }

        private bool Match(char c)
        {
            if (pos < text.Length && text[pos] == c)
            {
                pos++;
                return true;
            }
            return false;
        }
    }
}