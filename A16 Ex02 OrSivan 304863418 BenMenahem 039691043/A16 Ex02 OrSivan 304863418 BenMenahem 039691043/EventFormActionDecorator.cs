using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    class EventFormActionDecorator : IEventFormFacade
    {
        private IEventFormFacade m_EventFormFacade;
        private Action m_doPreLoad;
        private Action m_doAfterLoad;

        public EventFormActionDecorator(IEventFormFacade i_EventFormFacade, Action i_DoPreLoad, Action i_DoAfterLoad)
        {
            m_EventFormFacade = i_EventFormFacade;
            m_doPreLoad = i_DoPreLoad;
            m_doAfterLoad = i_DoAfterLoad;
        }
        
        public void LoadAndShowEvent(Event i_Event, Point i_LoadingLocation)
        {
            m_doPreLoad.InvokeIfNotNull();
            m_EventFormFacade.LoadAndShowEvent(i_Event,i_LoadingLocation);
            m_doAfterLoad.InvokeIfNotNull();
        }

        public void Close()
        {
            m_EventFormFacade.Close();
        }

        
    }

}
