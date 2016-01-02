using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    internal class UserRank<T> : IComparable
    {
        private int k_NotInIndex = -1;
        private int k_Bigger = 1;
        private int k_Smaller = -1;
        private int k_Equal = 0;

        public User User { get; private set; }

        public string Id { get; private set; }

        public string Name { get; private set; }

        public string NameCount
        {
            get
            {
                return string.Format("{0} ({1})", Name, m_ObjectsIn.Count);
            }
        }

        private List<T> m_ObjectsIn;

        public UserRank(User i_User)
        {
            User = i_User;
            Id = i_User.Id;
            Name = i_User.Name;
            m_ObjectsIn = new List<T>();
        }

        public void AddObjectToUser(T i_ObjectToAdd)
        {
            if (m_ObjectsIn.IndexOf(i_ObjectToAdd) == k_NotInIndex)
            {
                m_ObjectsIn.Add(i_ObjectToAdd);
            }
        }

        public int GetObjectCount()
        {
            return m_ObjectsIn.Count;
        }

        public List<T> GetObjectList()
        {
            return m_ObjectsIn;
        }

        public int CompareTo(object i_otherObject)
        {
            int result = k_Equal;
            UserRank<T> i_OtherUserRank = i_otherObject as UserRank<T>;
            if (i_OtherUserRank == null || m_ObjectsIn.Count > i_OtherUserRank.m_ObjectsIn.Count)
            {
                result = k_Bigger;
            }
            else if (m_ObjectsIn.Count < i_OtherUserRank.m_ObjectsIn.Count)
            {
                result = k_Smaller;
            }

            if (result == k_Equal)
            {
                result = string.Compare(i_OtherUserRank.Name, Name);
            }

            return result;
        }
    }
}
