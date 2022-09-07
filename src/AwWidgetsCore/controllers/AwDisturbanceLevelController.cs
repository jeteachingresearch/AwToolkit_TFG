using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AwWidgetsCore.models;

namespace AwWidgetsCore.controllers
{
    public class AwDisturbanceLevelController
    {
        private int _threshold;
        private DisturbanceLevels status;

        public AwDisturbanceLevelController(int threshold)
        {
            _threshold = threshold;
        }

        public void determineDisturbanceLevel(int elapsedTime)
        {
            if (elapsedTime > this._threshold * 4)
            {
                status =  DisturbanceLevels.INTRUSIVE;
            }
            else if (elapsedTime > this._threshold * 3)
            {
                status =  DisturbanceLevels.DISRUPTIVE;
            }
            else if (elapsedTime > this._threshold * 2)
            {
                status = DisturbanceLevels.SUBTLE;
            }
            else if (elapsedTime > this._threshold)
            {
                status = DisturbanceLevels.UNNOTICEABLE;
            }
            else
            {
                status = DisturbanceLevels.NONE;
            }
        }

        public void resetDisturbancelevel()
        {
            status = DisturbanceLevels.NONE;
        }

        public DisturbanceLevels getStatus()
        {
            return status;
        }
    }
}
