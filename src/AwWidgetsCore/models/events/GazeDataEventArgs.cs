namespace AwWidgetsCore.models
{
    public class GazeDataEventArgs<T> : EventArgs
    {
        public T GazeData { get; set; }

        public GazeDataEventArgs(T gazeData)
        {
            GazeData = gazeData;
        }

        public override string ToString()
        {
            return "GazeDataEventArgs: { GazeData: " + GazeData + "}";
        }

    }
}
