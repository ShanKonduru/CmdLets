using shan.cmdlets;

namespace shan.cmdlets.UnitTest;

[TestClass]
public class TestSimpleCalc
{
    [TestMethod]
    public void TestSimpleCalcAddMethod()
    {
        int result = SimpleCalc.Add(10, 20);
        Assert.AreEqual(result, 30, "Add did not work.");
    }

    [TestMethod]
    public void TestSimpleCalcSubMethod()
    {
        int result = SimpleCalc.Subtract(20, 10);
        Assert.AreEqual(result, 10, "Subtract did not work.");
    }
}