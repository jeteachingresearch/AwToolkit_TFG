using Microsoft.VisualStudio.TestTools.UnitTesting;

using AwWidgetsCore.controllers;
using AwWidgetsCore.models.interfaces;
using AwWidgetsCore.models;

using AwWidgetsCoreUnitTesting.stubs;


namespace AwWidgetsCoreUnitTesting.controllers
{
    [TestClass]
    public class AwGeneralGazeControllerTest
    {
        private AwControlStub userControl;

        private AwGeneralGazeController<int, GeneralGazeData> controller;

        // trigger event to do teh proper test 

        public delegate void GazeDataReceivedEventHandler(object source, GazeDataEventArgs<GeneralGazeData> args);

        public event GazeDataReceivedEventHandler GazeDataObtained;

        public void obtainGazeData(GeneralGazeData setup)
        {
            OnGazeDataReceived(setup);
        }

        protected virtual void OnGazeDataReceived(GeneralGazeData gazeData)
        {
            var args = new GazeDataEventArgs<GeneralGazeData>(gazeData);
            GazeDataObtained(this, args);
        }

        [TestInitialize]
        public void startup()
        {
            userControl = new AwControlStub();
            controller = new AwGeneralGazeController<int, GeneralGazeData>(userControl, 100);
        }

        //TODO: Investigate how to perform "integration tests" with delegates
        [TestMethod]
        public void testNonLookingEvent()
        {
            this.GazeDataObtained += this.controller.OnGazeDataReceived;
            var data = new GeneralGazeData(false);
            this.obtainGazeData(data);
            Assert.IsTrue(userControl.resetStylesActivated);
        }
    }
}
