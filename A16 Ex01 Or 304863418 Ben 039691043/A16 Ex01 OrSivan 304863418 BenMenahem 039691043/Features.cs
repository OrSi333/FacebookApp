using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    class Features
    {

        internal class UserRank<T> {
            public User User { get; private set; }

            public string Id { get; private set; }
            public string Name { get; private set; }
            private List<T> m_ObjectsIn;

            public UserRank(User i_User) {

                User = i_User;
                Id = i_User.Id;
                Name = i_User.Name;
                m_ObjectsIn = new List<T>();
            
            }

            public void AddObjectToUser(T i_ObjectToAdd) {
                if (m_ObjectsIn.IndexOf(i_ObjectToAdd) == -1)
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

        }
        internal static void FetchEvents(User i_LoggedInUser)
        {

        }

        internal static Dictionary<string, UserRank<Photo>> FetchTags(User i_LoggedInUser)
        {
            FacebookObjectCollection<Photo> userTaggedPhotos = i_LoggedInUser.PhotosTaggedIn;
            Dictionary<string, UserRank<Photo>> allTaggedFriendsOnUserPhotos = new Dictionary<string, UserRank<Photo>>();
            foreach (Photo photo in userTaggedPhotos)
            {
                foreach (PhotoTag photoTag in photo.Tags) {
                    
                    UserRank<Photo> currentFriendTag;

                    if (!allTaggedFriendsOnUserPhotos.TryGetValue(photoTag.User.Id, out currentFriendTag))
                    {
                        currentFriendTag = new UserRank<Photo>(photoTag.User);
                        allTaggedFriendsOnUserPhotos.Add(photoTag.User.Id, currentFriendTag);
                    }

                    currentFriendTag.AddObjectToUser(photo);

                }
            }

            return allTaggedFriendsOnUserPhotos;
            
        }

    }
}
