using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    interface IEventFormFacade
    {
        void LoadAndShowEvent(Event i_Event, Point i_LoadingLocation);

        void Close();
    }
}
