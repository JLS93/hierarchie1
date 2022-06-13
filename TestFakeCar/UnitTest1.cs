using Microsoft.VisualStudio.TestTools.UnitTesting;
using hierarchie1;

namespace TestFakeCar
{
    class FakeTemplate : CarTemplate, IVehicle, ICar
    {
        public int count = 0;
        /*
        string IVehicle.LicencePlate()
        {
            count += 1;
            return "ouai 999";
        }
        
        float IRoadVehicle.MaxLegalSpeed()
        {
            return 100;
        }
        int ICar.MaxPassengerCount()
        {
            return 5;
        }
        */
    }
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                var iface = new FakeTemplate();
                var auto = new DaciaSandeco(iface);
                Assert.AreEqual("ad 962 hf", auto.LicencePlate());
                Assert.AreEqual(250, auto.MaxLegalSpeed());
            // Assert.AreEqual(1, iface.count);
            Assert.IsTrue(auto.MaxLegalSpeed() > 100);

        }
    }
}
