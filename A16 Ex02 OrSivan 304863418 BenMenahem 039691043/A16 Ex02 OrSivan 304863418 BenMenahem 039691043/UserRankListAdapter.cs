using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public class UserRankListAdapter<T>
    {
        public List<UserRank<T>> UserRankList { get; set; }

        private UserRankListAdapter() 
        {
            UserRankList = null;
        }

        private static UserRankListAdapter<T> initUserRankListAdapter()
        {
            return new UserRankListAdapter<T>();
        }
    }
}
