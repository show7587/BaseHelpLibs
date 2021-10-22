using BaseHelpLibs;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BaseHelpLibsTest
{
    [TestClass]
    public class ComputeHelperTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            var result = ComputeHelper.Compute("5*10");
            Assert.AreEqual(50, result);
            
        }
    }
}
