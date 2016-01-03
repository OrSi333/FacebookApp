using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public class LazyList<T>
    {
        List<UserRank<T>> m_userRankList;
        private LazyList(List<UserRank<T>> i_userRankList) 
        {
            m_userRankList = i_userRankList;
        }

        private static LazyList<T> initLazyList(List<UserRank<T>> i_userRankList)
        {
            return new LazyList<T>(i_userRankList);
        }

    }
}
