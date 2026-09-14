using Tyuiu.NurpeisovaAK.Sprint0.Task2.V1.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint0.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Асем";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Асем", res);

        }
    }
}
