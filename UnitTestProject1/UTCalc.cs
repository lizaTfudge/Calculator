using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCalc
{
    [TestClass]
    public class UTCalc
    {
        [TestMethod]
        public void WhenResult_is_Negative()
        {
            string operand = "–";
            double result = -12, n1 = 6, n2 = 18;
            CalculatorForm calculatorForm = new CalculatorForm();
            string expectedResult = result.ToString();
            string actualResult = (calculatorForm.Result(operand,n1,n2)).ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WhenResult_is_Positive()
        {
            string operand = "+";
            double result = 12, n1 = 7, n2 = 5;

            CalculatorForm calculatorForm = new CalculatorForm();
            string expectedResult = result.ToString();
            string actualResult = (calculatorForm.Result(operand, n1, n2)).ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void WhenExpression_is_Mixed()
        {
            string op1 = "+",op2 = "–";
            double n1_1 = 8, n2_1 = 6;
            CalculatorForm calculatorForm = new CalculatorForm();
            string actualResult1 = (calculatorForm.Result(op1, n1_1, n2_1)).ToString();

            double result2 = 7, n1_2 = Double.Parse(actualResult1), n2_2 = 7;
            string expectedResult = result2.ToString();
            string actualResult2 = (calculatorForm.Result(op2, n1_2, n2_2)).ToString();
            Assert.AreEqual(expectedResult, actualResult2);
        }

        [TestMethod]
        public void WhenResult_is_Decimal()
        {
            string operand = "/";
            double result = 0.15, n1 = 0.75, n2 = 5;

            CalculatorForm calculatorForm = new CalculatorForm();
            string expectedResult = result.ToString();
            string actualResult = (calculatorForm.Result(operand, n1, n2)).ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TheResult_of_Division()
        {
            string operand = "/";
            double result = 114, n1 = 456, n2 = 4;

            CalculatorForm calculatorForm = new CalculatorForm();
            string expectedResult = result.ToString();
            string actualResult = (calculatorForm.Result(operand, n1, n2)).ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TheResult_of_DecimalMultiplication()
        {
            string operand = "*";
            double result = 0.224, n1 = 0.4, n2 = 0.56;

            CalculatorForm calculatorForm = new CalculatorForm();
            string expectedResult = result.ToString();
            string actualResult = (calculatorForm.Result(operand, n1, n2)).ToString();
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
