using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    class EventFormPreLoadDecorator<T> : IEventFormFacade
    {
        protected IEventFormFacade m_EventFormFacade;
        protected Predicate<T> m_checkToContinue; 
        protected T m_predicatParameter;
        protected Action m_doIfFail;

        public EventFormPreLoadDecorator(IEventFormFacade i_EventFormFacade, Predicate<T> i_CheckToContinue ,T i_PredicatParameter, Action i_DoIfFail)
        {
            m_EventFormFacade = i_EventFormFacade;
            m_checkToContinue = i_CheckToContinue;
            m_predicatParameter = i_PredicatParameter;
            m_doIfFail = i_DoIfFail;
        }
        
        public void LoadAndShowEvent(Event i_Event, Point i_LoadingLocation)
        {
            if (m_checkToContinue.Invoke(m_predicatParameter))
            {
                m_EventFormFacade.LoadAndShowEvent(i_Event, i_LoadingLocation);   
            }
            else
            {
                m_doIfFail.InvokeIfNotNull();
            }
        }

        public void Close()
        {
            m_EventFormFacade.Close();
        }

    }
}
