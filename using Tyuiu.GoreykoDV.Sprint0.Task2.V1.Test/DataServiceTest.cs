using Tyuiu.GoreykoDV.Sprint0.Task2.V1.Lib;

namespace using_Tyuiu.GoreykoDV.Sprint0.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Dasha";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Dasha", res);
        }
    }
}
