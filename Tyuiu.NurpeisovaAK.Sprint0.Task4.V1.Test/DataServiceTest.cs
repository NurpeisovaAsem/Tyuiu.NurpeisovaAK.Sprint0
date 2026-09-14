using Tyuiu.NurpeisovaAK.Sprint0.Task4.V1.Lib;
namespace Tyuiu.NurpeisovaAK.Sprint0.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
