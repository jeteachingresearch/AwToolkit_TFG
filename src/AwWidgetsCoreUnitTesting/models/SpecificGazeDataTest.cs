using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AwWidgetsCore.models;

namespace AwWidgetsCoreUnitTesting.models
{
    [TestClass]
    public class SpecificGazeDataTest
    {

        [TestMethod]
        public void isAffectedTest()
        {

            SpecificGazeData data = new SpecificGazeData(Tuple.Create(5,5));
            var result = data.isAffected(Tuple.Create(10, 10), new Point(0, 0));

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isNotAffectedTest()
        {
            SpecificGazeData data = new SpecificGazeData(Tuple.Create(10, 10));
            Assert.IsFalse(data.isAffected(Tuple.Create(10, 10), new Point(11, 11)));
        }
    }
}
