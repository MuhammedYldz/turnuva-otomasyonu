using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TracerLibrary;

namespace TrackerUI
{
    public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel model);
    }
}
