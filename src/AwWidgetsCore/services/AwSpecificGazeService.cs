using AwWidgetsCore.models;

namespace AwWidgetsCore.services
{
    internal class AwSpecificGazeService
    {

        public delegate void GazeDataObtainedEventHandler(object source, SpecificGazeData args);

        public event GazeDataObtainedEventHandler GazeDataObtained;

        public SpecificGazeData data { get; set; }

        public void obtainGazeData()
        {
            Console.WriteLine("Fetching general gaze data...");
            Thread.Sleep(3000);

            OnGazeDataObtained(this.data);
        }

        protected virtual void OnGazeDataObtained(SpecificGazeData gazeData)
        {
            Console.WriteLine("Sending the event with data:");
            Console.WriteLine(gazeData.ToString());
            GazeDataObtained(this, gazeData);
        }
    }
}
