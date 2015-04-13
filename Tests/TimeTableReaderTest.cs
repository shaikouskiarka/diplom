using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
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
