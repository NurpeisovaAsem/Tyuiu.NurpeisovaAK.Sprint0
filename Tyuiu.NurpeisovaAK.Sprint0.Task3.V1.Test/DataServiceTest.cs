using Tyuiu.NurpeisovaAK.Sprint0.Task3.V1.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint0.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
