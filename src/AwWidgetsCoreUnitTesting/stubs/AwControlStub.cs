using System;

using AwWidgetsCore.models;
using AwWidgetsCore.models.interfaces;

namespace AwWidgetsCoreUnitTesting.stubs
{
    public class AwControlStub : IAwWidget
    {
        public DisturbanceLevels activatedStatus = DisturbanceLevels.NONE;
        public bool resetStylesActivated = false;

        void IAwWidget.displayWithDisruptiveDisturbance()
        {
            activatedStatus = DisturbanceLevels.DISRUPTIVE;
            Console.WriteLine("DISRUPTIVE Disturbance has been Activated!");
        }

        void IAwWidget.displayWithIntrusiveDisturbance()
        {
            activatedStatus = DisturbanceLevels.INTRUSIVE;
            Console.WriteLine("INTRUSIVE Disturbance has been Activated!");
        }

        void IAwWidget.displayWithSubtleDisturbance()
        {
            activatedStatus = DisturbanceLevels.SUBTLE;
            Console.WriteLine("SUBTLE Disturbance has been Activated!");
        }

        void IAwWidget.displayWithUnnoticeableDisturbance()
        {
            activatedStatus = DisturbanceLevels.UNNOTICEABLE;
            Console.WriteLine("UNNOTICEABLE Disturbance has been Activated!");
        }

        Tuple<int, int> IAwWidget.getSize()
        {
            return Tuple.Create(10, 10);
        }

        Tuple<int, int> IAwWidget.getTopLeftCorner()
        {
            return Tuple.Create(0, 0);
        }

        void IAwWidget.resetStyles()
        {
            resetStylesActivated = true;
            Console.WriteLine("STYLES have been reseted!");
        }
    }
}
