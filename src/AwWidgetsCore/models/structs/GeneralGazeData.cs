using AwWidgetsCore.models.interfaces;

namespace AwWidgetsCore.models
{
    public struct GeneralGazeData : IAwSelfAware
    {
        private bool IsLooking { get; set; }
        private DateTime TimeStamp { get; set; }

        public GeneralGazeData(bool isLooking)
        {
            IsLooking = isLooking;
            TimeStamp = DateTime.Now;
        }

        public GeneralGazeData(bool isLooking, DateTime timeStamp)
        {
            IsLooking = isLooking;
            TimeStamp = timeStamp;
        }

        public override string ToString()
        {
            return "GeneralGazeData: { isLooking: " + IsLooking + ", timeStamp: " + TimeStamp + "}"; 
        }

        public bool isAffected(Tuple<int, int> size, Point topLeftCorner)
        {
            // if the user is looking the screen, no need to check the position
            return this.IsLooking;
        }
    }
}
