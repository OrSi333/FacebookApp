using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    class EventFormFacade : IEventFormFacade
    {

        private EventForm m_eventForm;

        public static IEventFormFacade CreateForm()
        {
            return new EventFormFacade();
        }
        
        public void LoadAndShowEvent(Event i_Event, Point i_LoadingLocation)
        {
            m_eventForm = new EventForm();
            m_eventForm.loadEvent(i_Event,i_LoadingLocation);
            m_eventForm.Show();
        }

        public void Close()
        {
            if (m_eventForm != null)
            {
                m_eventForm.Close();   
            }
        }
    }
}
