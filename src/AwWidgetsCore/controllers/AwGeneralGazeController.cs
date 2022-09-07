using AwWidgetsCore.models;
using AwWidgetsCore.models.interfaces;

namespace AwWidgetsCore.controllers
{
    public class AwGeneralGazeController<D, T> where T : IAwSelfAware
    {
        private IAwWidget _widget;
        private AwDisturbanceLevelController _disturbancelevelController;
        private AwDataController<D> _dataController;

        private DateTime _lastLooked;
        private bool skipDataCheck = true;

        public AwGeneralGazeController(IAwWidget awWidget, int threshold)
        {
            if(awWidget != null)
            {
                _widget = awWidget;
            } else
            {
                throw new ArgumentNullException();
            }
            _disturbancelevelController = new AwDisturbanceLevelController(threshold);
            _dataController = new AwDataController<D>();

            _lastLooked = DateTime.Now;
        }

        public AwDataController<D> getDataController()
        {
            return _dataController;
        }

        // check if component is affected
        // YES -> reset the distubance level, reset component status
        // NO -> 
        // determine the disturbance level to apply
        // update the component visuals if needed
        public void OnGazeDataReceived(object sourcce, GazeDataEventArgs<T> args)
        {
            var point = new Point(_widget.getTopLeftCorner().Item1, _widget.getTopLeftCorner().Item2);
            var isAffected = args.GazeData.isAffected(_widget.getSize(), point);
            
            if(isAffected)
            {
                // reset disturbance level
                _lastLooked = DateTime.Now;
                _disturbancelevelController.resetDisturbancelevel();
                triggerDisplayChange(DisturbanceLevels.NONE);
            } else
            {
                // execture disturbance
                if (skipDataCheck || _dataController.hasDataChangedSinceLastGaze(DateTime.Now))
                {
                    // determine disturbance level
                    var elapsedTime = (int)DateTime.Now.Subtract(_lastLooked).TotalMilliseconds;
                    _disturbancelevelController.determineDisturbanceLevel(elapsedTime);
                    triggerDisplayChange(_disturbancelevelController.getStatus());
                }
            }
        }

        private void triggerDisplayChange(DisturbanceLevels disturbance)
        {
            switch (disturbance)
            {
                case DisturbanceLevels.UNNOTICEABLE:
                    _widget.displayWithUnnoticeableDisturbance();
                    break;
                case DisturbanceLevels.SUBTLE:
                    _widget.displayWithSubtleDisturbance();
                    break;
                case DisturbanceLevels.INTRUSIVE:
                    _widget.displayWithIntrusiveDisturbance();
                    break;
                case DisturbanceLevels.DISRUPTIVE:
                    _widget.displayWithDisruptiveDisturbance();
                    break;
                default:
                    break;
            }
        }
    }
}
