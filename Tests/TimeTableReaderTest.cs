using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimetableApp;
using System.IO;

namespace Tests
{
    [TestClass]
    public class TimetableReaderTest
    {
        private string source;
        private TimetableReader timetable;

        [TestInitialize]
        public void Init()
        {
            source = File.ReadAllText(@"name.txt");
            timetable = new TimetableReader(source);
        }

        [TestMethod]
        public void TestStatusOK()
        {
            Assert.AreEqual(timetable.Status, "OK");
        }
    }
}
