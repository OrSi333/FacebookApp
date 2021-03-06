﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Reflection;
using FacebookWrapper.ObjectModel;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public class CentralSingleton
    {
        private static readonly object sr_instanceKey = new object();
        private static CentralSingleton s_instance;
        private readonly object r_appConfigKey = new object();
        private readonly object r_attendeesFromEventKey = new object();
        private readonly object r_SharedPhotosTagsKey = new object();
        private FBAppConfig m_AppConfig;
        private UserRankListAdapter<Event> m_AttendeesFromEventListAdapter = null;
        private UserRankListAdapter<Photo> m_SharedPhotosTagsListAdapter = null;

        public static CentralSingleton Instance
        {
            get
            {
                if (s_instance == null)
                {
                    lock (sr_instanceKey)
                    {
                        if (s_instance == null)
                        {
                            s_instance = new CentralSingleton();
                        }
                    }
                }

                return s_instance;
            }
        }

        public FBAppConfig AppConfig
        {
            get
            {
                return getLazyInstance<FBAppConfig>(m_AppConfig, r_appConfigKey);
            }
        }

        public UserRankListAdapter<Event> AttendeesFromEventListAdapter
        {
            get
            {
                return getLazyInstance<UserRankListAdapter<Event>>(m_AttendeesFromEventListAdapter, r_attendeesFromEventKey);
            }
        }

        public UserRankListAdapter<Photo> SharedPhotosTagsListAdapter
        {
            get
            {
                return getLazyInstance<UserRankListAdapter<Photo>>(m_SharedPhotosTagsListAdapter, r_SharedPhotosTagsKey);
            }
        }

        private T getLazyInstance<T>(T io_InstanceRef, object i_Key)
            where T : class
        {
            if (io_InstanceRef == null)
            {
                lock (i_Key)
                {
                    if (io_InstanceRef == null)
                    {
                        io_InstanceRef = invokePrivateStaticInit<T>();
                    }
                }
            }

            return io_InstanceRef;
        }

        private T invokePrivateStaticInit<T>()
            where T : class
        {
            Type type = typeof(T);
            object objToInit = null;
            foreach (MethodInfo method in type.GetMethods(BindingFlags.NonPublic | BindingFlags.Static))
            {
                if (method.IsPrivate && method.IsStatic && method.Name.StartsWith("init"))
                {
                    objToInit = method.Invoke(null, null);
                    break;
                }
            }

            if (objToInit == null)
            {
                throw new Exception(string.Format("Class {0} doesn't contain a private static init method!", type));
            }
            else
            {
                return objToInit as T;
            }
        }

        private CentralSingleton() { }
    }
}