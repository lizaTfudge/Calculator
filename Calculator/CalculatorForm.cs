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
    public partial class CalculatorForm : Form
    {
        bool operandPerformed = false;      //Была ли нажата кнопка операции
        string operand = "";                //Переменная со знаком нажатой операции
        double result = 0, n1 = 0, n2 = 0;  //Переменные для записи результатов вычислений

        public CalculatorForm()
        {
            InitializeComponent();
            lbPreResult.Text = "";
            lbResult.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e) //ПОЛНАЯ ОЧИСТКА ПОЛЕЙ
        {
            tBxCalc.Text = "0";
            lbResult.Text = "";
            lbPreResult.Visible = false;
            result = 0;
            operand = "";
        }

        private void NumbEvent(object sender, EventArgs e) //НАБОР ЧИСЕЛ
        {
            if (tBxCalc.Text == "0" || operandPerformed) //стирание строки каждый раз при вводе новой переменной
            {
                tBxCalc.Clear();
            }

            Button btn = (Button)sender;
            tBxCalc.Text += btn.Text;
            operandPerformed = false;
        }

        public double Result(string operand, double n1, double n2)
        {
            switch (operand)
            {
                case "+": tBxCalc.Text = (n1 + n2).ToString(); break;
                case "/": tBxCalc.Text = (n1 / n2).ToString(); break;
                case "*": tBxCalc.Text = (n1 * n2).ToString(); break;
                case "–": tBxCalc.Text = (n1 - n2).ToString(); break;
            }
            result = Double.Parse(tBxCalc.Text);
            return result;
        }

        private void operandEvent(object sender, EventArgs e) //Событие при нажатии арифм. операций
        {
            lbPreResult.Visible = true;
            operandPerformed = true;

            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lbResult.Text += tBxCalc.Text + " " + newOperand + " ";

            n1 = result;
            n2 = Double.Parse(tBxCalc.Text);
            Result(operand, n1, n2);

            result = Double.Parse(tBxCalc.Text);
            lbPreResult.Text = "=" + result.ToString();
            tBxCalc.Clear();
            operand = newOperand;
        }

        private void btnResult_Click(object sender, EventArgs e) //ВЫЧИСЛЕНИЕ РЕЗУЛЬТАТА
        {
            lbResult.Text = "";
            operandPerformed = true;

            n1 = result;
            n2 = Double.Parse(tBxCalc.Text);
            Result(operand,n1,n2);

            tBxCalc.Text = result.ToString();
            lbPreResult.Visible = false;
            result = 0;
            operand = "";
        }

        private void btnPeriod_Click(object sender, EventArgs e) //запятая (для десятичных чисел)
        {
            if (!operandPerformed && !tBxCalc.Text.Contains(","))
            {
                tBxCalc.Text += ",";
            }
            else if (operandPerformed)
            {
                tBxCalc.Text = "0";
            }

            if (!tBxCalc.Text.Contains(","))
            {
                tBxCalc.Text += ",";
            }
            operandPerformed = false;
        }

        private void btnDel_Click(object sender, EventArgs e)  //СТИРАНИЕ ПОСЛЕДНЕГО СИМВОЛА СТРОКИ
        {
            tBxCalc.Text = tBxCalc.Text.Substring(0, tBxCalc.Text.Length - 1);
            if (tBxCalc.Text == "")
            {
                tBxCalc.Text = "0";
            }
        }
    }
}
