using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    public class DictionaryProxy<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private object m_Lock = new object();
        private Dictionary<TKey, TValue> m_SynchedDictionary;
        public DictionaryProxy()
        {
            m_SynchedDictionary = new Dictionary<TKey, TValue>();
        }



        public void Add(TKey key, TValue value)
        {
            lock (m_Lock)
            {
                m_SynchedDictionary.Add(key, value);
            }
        }

        public bool ContainsKey(TKey key)
        {
            lock (m_Lock)
            {
                return m_SynchedDictionary.ContainsKey(key);
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                lock (m_Lock)
                {
                    return m_SynchedDictionary.Keys;
                }
            }
        }

        public bool Remove(TKey key)
        {
            lock (m_Lock)
            {
                return m_SynchedDictionary.Remove(key);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            lock (m_Lock)
            {
                return m_SynchedDictionary.TryGetValue(key, out value);
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                lock (m_Lock)
                {
                    return m_SynchedDictionary.Values;
                }
            }
        }

        public TValue this[TKey key]
        {
            get
            {
                lock (m_Lock)
                {
                    return m_SynchedDictionary[key];
                }
            }
            set
            {
                lock (m_Lock)
                {
                    m_SynchedDictionary[key] = value;
                }
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            lock (m_Lock)
            {
                m_SynchedDictionary.Add(item.Key, item.Value);
            }
        }

        public void Clear()
        {
            lock (m_Lock)
            {
                m_SynchedDictionary.Clear();
            }
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            lock (m_Lock)
            {
                return m_SynchedDictionary.Contains(item);
            }
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();

        }

        public int Count
        {
            get
            {
                lock (m_Lock)
                {
                    return m_SynchedDictionary.Count;
                }
            }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return m_SynchedDictionary.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return m_SynchedDictionary.GetEnumerator();
        }
    }
}
