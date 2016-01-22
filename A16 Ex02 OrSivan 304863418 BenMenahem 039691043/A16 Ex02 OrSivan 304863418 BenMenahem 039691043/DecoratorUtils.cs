using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    static class DecoratorUtils
    {
        public static Action NoAction
        {
            get { return null; }
        }
        
        public static void InvokeIfNotNull(this Action i_Action)
        {
            if (i_Action != null)
            {
                i_Action.Invoke();
            }
        }

        public static IEventFormFacade Decorate<T>(this IEventFormFacade i_EventFormFacadeToDecorate,
            Predicate<T> i_CheckToContinue, T i_PredicatParameter, Action i_DoIfFail)
        {
            if (i_EventFormFacadeToDecorate == null)
            {
                i_EventFormFacadeToDecorate = EventFormFacade.CreateForm();
            }
            return new EventFormPreLoadDecorator<T>(i_EventFormFacadeToDecorate,i_CheckToContinue,i_PredicatParameter,i_DoIfFail);
        }

        public static IEventFormFacade Decorate(this IEventFormFacade i_EventFormFacadeToDecorate, Action i_DoPreLoad,
            Action i_DoAfterLoad)
        {
            if (i_EventFormFacadeToDecorate == null)
            {
                i_EventFormFacadeToDecorate = EventFormFacade.CreateForm();
            }
            return new EventFormActionDecorator(i_EventFormFacadeToDecorate,i_DoPreLoad,i_DoAfterLoad);
        }

    }
}
