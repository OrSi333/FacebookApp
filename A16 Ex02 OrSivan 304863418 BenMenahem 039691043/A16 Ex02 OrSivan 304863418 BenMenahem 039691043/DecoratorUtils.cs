using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    static class DecoratorUtils
    {
        public static Action<Event> NoAction
        {
            get { return null; }
        }
        
        public static void InvokeIfNotNull<T>(this Action<T> i_Action, T i_InvokeParam)
        {
            if (i_Action != null)
            {
                i_Action.Invoke(i_InvokeParam);
            }
        }

        public static IEventFormFacade Decorate<T>(this IEventFormFacade i_EventFormFacadeToDecorate,
            Func<Event,T,bool> i_CheckToContinue, T i_PredicatParameter, Action<Event> i_DoIfFail)
        {
            if (i_EventFormFacadeToDecorate == null)
            {
                i_EventFormFacadeToDecorate = EventFormFacade.CreateForm();
            }
            return new EventFormPreLoadDecorator<T>(i_EventFormFacadeToDecorate,i_CheckToContinue,i_PredicatParameter,i_DoIfFail);
        }

        public static IEventFormFacade Decorate(this IEventFormFacade i_EventFormFacadeToDecorate, Action<Event> i_DoPreLoad,
            Action<Event> i_DoAfterLoad)
        {
            if (i_EventFormFacadeToDecorate == null)
            {
                i_EventFormFacadeToDecorate = EventFormFacade.CreateForm();
            }
            return new EventFormActionDecorator(i_EventFormFacadeToDecorate,i_DoPreLoad,i_DoAfterLoad);
        }

    }
}
