using shan.cmdlets;

namespace shan.cmdlets.UnitTest;

[TestClass]
public class TestSimpleCalc
{
    [TestMethod]
    public void TestMethod1()
    {
        int result = SimpleCalc.Add(10, 20);
        Assert.AreEqual(result, 30, "Add did not work.");
    }
}