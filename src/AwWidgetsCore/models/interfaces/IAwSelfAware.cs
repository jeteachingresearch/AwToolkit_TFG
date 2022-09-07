using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwWidgetsCore.models.interfaces
{
    public interface IAwSelfAware
    {
        /**
         * This method allows to detect if the user gaze focus is affecting one component
         */
        public bool isAffected(Tuple<int,int> size, Point topLeftCorner);
    }
}
