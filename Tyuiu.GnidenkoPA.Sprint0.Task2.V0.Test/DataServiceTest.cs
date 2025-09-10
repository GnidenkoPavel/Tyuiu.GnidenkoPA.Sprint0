using Tyuiu.GnidenkoPA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GnidenkoPA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Паша";
            var res = DataService.GetMassage(name);
            Assert.AreEqual("Привет, Паша", res);
        }
    }
}
