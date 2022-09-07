using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AwWidgetsCore.models;

namespace AwWidgetsCoreUnitTesting.models
{
    [TestClass]
    public class GeneralGazeDataTest
    {
        [TestMethod]
        public void isAffectedTest()
        {
            GeneralGazeData data = new GeneralGazeData(true);
            Assert.IsTrue(data.isAffected(new Tuple<int, int>(10, 10), new Point(0, 0)));
        }

        [TestMethod]
        public void isNotAffectedTest()
        {
            GeneralGazeData data = new GeneralGazeData(false);
            Assert.IsFalse(data.isAffected(new Tuple<int, int>(10, 10), new Point(0, 0)));
        }
    }
}
