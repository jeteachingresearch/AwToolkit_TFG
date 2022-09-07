using AwWidgetsCore.models.interfaces;

namespace AwWidgetsCore.models
{
    public struct SpecificGazeData: IAwSelfAware
    {
        private Point GazePosition { get; set; }
        private DateTime TimeStamp { get; set; }

        public SpecificGazeData(Point gazePosition)
        {
            GazePosition = gazePosition;
            TimeStamp = DateTime.Now;
        }

        public SpecificGazeData(Tuple<int,int> gazePosition)
        {
            GazePosition = new Point(gazePosition.Item1, gazePosition.Item2);
            TimeStamp = DateTime.Now;
        }

        public SpecificGazeData(Point gazePosition, DateTime timeStamp)
        {
            GazePosition = gazePosition;
            TimeStamp = timeStamp;
        }

        public SpecificGazeData(int x, int y, DateTime timeStamp)
        {
            GazePosition = new Point(x, y);
            TimeStamp = timeStamp;
        }

        public override string ToString()
        {
            return "SpecificGazeData: { gazePosition: " + GazePosition + ", timeStamp: " + TimeStamp + "}";
        }

        public bool isAffected(Tuple<int, int> size, Point topLeftCorner)
        {
            // if the point is inside the area of the component 
            return (
                this.GazePosition.X >= topLeftCorner.X && 
                this.GazePosition.X <= topLeftCorner.X + size.Item1
                ) &&
                (
                this.GazePosition.Y >= topLeftCorner.Y && 
                this.GazePosition.Y <= topLeftCorner.Y + size.Item2
                );
        }
    }
}
