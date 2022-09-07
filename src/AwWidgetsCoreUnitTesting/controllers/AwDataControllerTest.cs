using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AwWidgetsCore.controllers;

namespace AwWidgetsCoreUnitTesting.controllers
{
    [TestClass]
    public class AwDataControllerTest
    {
        AwDataController<int> dataController;

        [TestInitialize]
        public void startup()
        {
            dataController = new AwDataController<int>();
        }

        [TestMethod]
        public void shouldBeAbleToSetData()
        {
            dataController.setData(1);
            Assert.AreEqual(1, dataController.getData());
        }
        
        [TestMethod]
        public void shouldUpdateData()
        {
            dataController.setData(5);
            dataController.updateData(4);
            var result = dataController.getData();
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void shouldNotUpdateData()
        {
            dataController.updateData(5);
            var result = dataController.getData();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void shouldThrowInvalidOperationException()
        {
            dataController.setData(5);
            dataController.setData(7);
        }

        [TestMethod]
        public void dataShouldHaveChangedSinzeLastGaze()
        {
            dataController.setData(1);
            dataController.hasDataChangedSinceLastGaze(DateTime.Now);
            Assert.AreEqual(1, dataController.getData());
            Assert.IsTrue(dataController.hasDataChangedSinceLastGaze(DateTime.Now));
        }
    }
}
