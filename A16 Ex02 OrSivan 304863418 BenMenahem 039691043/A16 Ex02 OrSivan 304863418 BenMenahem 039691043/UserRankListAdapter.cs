using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public class UserRankListAdapter<T>
    {
        private List<UserRank<T>> m_userRankList;
        public List<UserRank<T>> UserRankList
        {
            get
            {
                return m_userRankList;
            }

            set
            {
                m_userRankList = value;
            }
        }

        private UserRankListAdapter() 
        {
            m_userRankList = null;
        }
        //

        private static UserRankListAdapter<T> initUserRankListAdapter()
        {
            return new UserRankListAdapter<T>();
        }

    }
}
