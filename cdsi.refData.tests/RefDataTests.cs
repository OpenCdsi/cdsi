using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using cdsi.refData;

namespace cdsi.refData.tests
{
    [TestClass]
    public class RefDataTests
    {
        [TestMethod]
        public void AntigenNames()
        {
            var names = RefData.Antigen.Keys;
            Assert.AreEqual(24, names.Count);
            Assert.AreEqual("Cholera", names.First());
        }

        [TestMethod]
        public void CanParseAntigenData()
        {
            var data = RefData.Antigen["Cholera"];
            Assert.AreEqual("Cholera", data.series[0].targetDisease);
        }

        [TestMethod]
        public void CanParseScheduleData()
        {
            var data = RefData.Schedule;
            Assert.IsInstanceOfType(data, typeof(scheduleSupportingData));
        }
    }
}
