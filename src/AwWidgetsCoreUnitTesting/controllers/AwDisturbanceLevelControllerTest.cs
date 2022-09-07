using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AwWidgetsCore.controllers;
using AwWidgetsCore.models;

namespace AwWidgetsCoreUnitTesting.controllers
{
    [TestClass]
    public class AwDisturbanceLevelControllerTest
    {

        AwDisturbanceLevelController disturbanceController;

        [TestInitialize]
        public void startup()
        {
            disturbanceController = new AwDisturbanceLevelController(100);
        }

        [TestMethod]
        public void statusShouldBeNoneByDefault()
        {
            var status = disturbanceController.getStatus();
            Assert.AreEqual(DisturbanceLevels.NONE, status);
        }

        [TestMethod]
        public void shouldTriggerUnnoticeableDisturbance()
        {
            disturbanceController.determineDisturbanceLevel(110);
            var status = disturbanceController.getStatus();
            Assert.AreEqual(DisturbanceLevels.UNNOTICEABLE, status);
        }

        [TestMethod]
        public void shouldTriggerIntrusiveDisturbance()
        {
            disturbanceController.determineDisturbanceLevel(410);
            var status = disturbanceController.getStatus();
            Assert.AreEqual(DisturbanceLevels.INTRUSIVE, status);
        }

        [TestMethod]
        public void shouldResetDisturbanceStatus()
        {
            disturbanceController.determineDisturbanceLevel(410);
            var status = disturbanceController.getStatus();
            Assert.AreEqual(DisturbanceLevels.INTRUSIVE, status);
            disturbanceController.resetDisturbancelevel();
            status = disturbanceController.getStatus();
            Assert.AreEqual(DisturbanceLevels.NONE, status);
        }
    }
}
