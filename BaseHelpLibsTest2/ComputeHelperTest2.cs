using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseHelpLibsTest2
{
    [TestClass]
    public class ComputeHelperTest2
    {
        [TestMethod]
        public void ComputeTest()
        {
            var result = ComputeHelper.Compute("5*10");
            Assert.AreEqual(50, result);

        }
    }
}
