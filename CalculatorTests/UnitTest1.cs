using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenResult_is_Negative()
        {
            string operand = "-";
            double result = -12, n1 = 6, n2 = 18;
            CalculatorForm calculatorForm = new CalculatorForm();
            string expectedResult = result.ToString();
            string actualResult = calculatorForm.Result(operand,n1,n2);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
