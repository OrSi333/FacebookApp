using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public class UserRankListAdapter<T>
    {
        List<UserRank<T>> m_userRankList;
        private UserRankListAdapter(List<UserRank<T>> i_userRankList) 
        {
            m_userRankList = i_userRankList;
        }
        //

        private static UserRankListAdapter<T> initUserRankListAdapter(List<UserRank<T>> i_userRankList)
        {
            return new UserRankListAdapter<T>(i_userRankList);
        }

    }
}
