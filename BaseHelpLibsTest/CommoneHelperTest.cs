using BaseHelpLibs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseHelpLibsTest
{
    [TestClass]
    public class CommoneHelperTest
    {
        private bool expected = true; //期望
        private bool actual = true; //實際

        [DataRow("75-08-07", "Republic", "1986-08-07", "-", "")]
        [DataRow("75/08/07", "Republic", "1986/08/07", "/", "")]
        [DataRow("75.08.07", "Republic", "1986.08.07", ".", "")]
        [DataRow("75-08-07", "Republic", "1986/08/07", "-", "/")]
        [TestMethod]
        public void ChangeYearTest(string dateT, string type, string expectedStr, string _splitSymbol, string _outputSymbol)
        {   
            var actualResult = CommonHelper.ChangeYear(dateT, type, _splitSymbol, _outputSymbol);
            Assert.AreEqual(expectedStr, actualResult);
        }

        [DataRow("75-08-07", "Republic", "1986-08-07")]
        [TestMethod]
        public void ChangeYearTest2(string dateT, string type, string expectedStr)
        {
            var actualResult = CommonHelper.ChangeYear(dateT, type);
            Assert.AreEqual(expectedStr, actualResult);
        }
    }
}
