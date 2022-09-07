using AwWidgetsCore.models;
using AwWidgetsCore.models.interfaces;
using AwWidgetsCore.controllers;

namespace AwWidgetsControls
{
    /**
     * D generic type refears to the "data" the component may need to display
     * T generic type refeers to the "type" of gaze data the component will be recieving
     */
    public class AwPanel<D, T>: Panel, IAwWidget where T : IAwSelfAware
    {

        Color _originalBackColor;

        private AwGeneralGazeController<D, T> _controller;


        public AwPanel(int gazeAttentionThreshold)
        {
            _originalBackColor = this.BackColor;

            _controller = new AwGeneralGazeController<D, T>(this, gazeAttentionThreshold);
        }

        public AwGeneralGazeController<D, T> getController()
        {
            return _controller;
        }

        void IAwWidget.displayWithUnnoticeableDisturbance()
        {
            this.BackColor = Color.Green;
        }

        void IAwWidget.displayWithSubtleDisturbance()
        {
            this.BackColor = Color.Yellow;
        }

        void IAwWidget.displayWithIntrusiveDisturbance()
        {
            this.BackColor = Color.Orange;
        }

        void IAwWidget.displayWithDisruptiveDisturbance()
        {
            this.BackColor = Color.Red;
        }

        public void resetStyles()
        {
            if(this.BackColor != _originalBackColor)
            {
                this.BackColor = _originalBackColor;
            }
        }

        public Tuple<int, int> getSize()
        {
            return new Tuple<int, int>(this.Width, this.Height);
        }

        public Tuple<int, int> getTopLeftCorner()
        {
            return new Tuple<int, int>(this.Location.X, this.Location.Y);
        }
    }
}
