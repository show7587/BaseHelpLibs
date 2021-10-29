using BaseHelpLibs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseHelpLibsTest
{
    [TestClass]
    public class DateHelperTest
    {
        private bool expected = true; //期望
        private bool actual = true; //實際

        [DataRow(2021, 2, "4", "2021-02-28")]
        [DataRow(2021, 3, "2", "2021-03-31")]
        [DataRow(2024, 2, "2", "2024-02-29")]
        [TestMethod]
        public void GetLastDayFormatTest(int year, int month, string day, string _expected)
        {
            var actualResult = DateHelper.GetLastDayFormat(year, month, day);
            Assert.AreEqual(_expected, actualResult);

        }
    }
}
