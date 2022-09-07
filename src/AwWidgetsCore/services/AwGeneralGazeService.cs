using AwWidgetsCore.models;

namespace AwWidgetsCore.services
{

    public class AwGeneralGazeService<T>
    {
        public delegate void GazeDataObtainedEventHandler(object source, GazeDataEventArgs<T> args);

        public event GazeDataObtainedEventHandler GazeDataObtained;

        public T data { get; set; }

        public void obtainGazeData()
        {
            Console.WriteLine("Fetching general gaze data...");
            Thread.Sleep(3000);

            OnGazeDataObtained(this.data);
        }

        protected virtual void OnGazeDataObtained(T gazeData)
        {
            Console.WriteLine("Sending the event with data:");
            Console.WriteLine(gazeData.ToString());
            var gazeDataEventArgs = new GazeDataEventArgs<T>(gazeData);
            GazeDataObtained(this, gazeDataEventArgs);
        }
    }
}
