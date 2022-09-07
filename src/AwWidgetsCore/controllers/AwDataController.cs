namespace AwWidgetsCore.controllers
{
    public class AwDataController<D>
    {
        private D? _previousData;
        private D? _data = default(D);
        private DateTime? _lastUpdated = null;

        public D? getData()
        {
            return _data;
        }

        public void setData(D data)
        {   
            if(_lastUpdated == null && data != null)
            {
                _data = data;
                _lastUpdated = DateTime.Now;
            } else if (data == null)
            {
                throw new ArgumentNullException();
            } else
            {
                throw new InvalidOperationException("Please use the update method in order to update the data");
            }
            
        }

        public void updateData(D data)
        {
            if (_lastUpdated != null && !data.Equals(_previousData))
            {
                _previousData = _data;
                _data = data;
                _lastUpdated = DateTime.Now;
            }
        }

        public bool hasDataChangedSinceLastGaze(DateTime time)
        {
            return _lastUpdated <= time;
        }
    }
}
