using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    static class ListUtils
    {
        public static void TryDoAction<T>(this List<T> i_List, T i_Value, Action<List<T>, T> i_DoIfValueDontExsist, Action<List<T>, T> i_DoIfValueExsist,
            Action<List<T>, T> i_DoIfDefaultValue)
        {
            if (i_Value.Equals(default(T)))
            {
                i_DoIfDefaultValue.Invoke(i_List,i_Value);
            }
            else
            {
                if (i_List.Contains(i_Value))
                {
                    i_DoIfValueExsist.Invoke(i_List,i_Value);
                }
                else
                {
                    i_DoIfValueDontExsist(i_List,i_Value);
                }
            }
        }
    }
}
