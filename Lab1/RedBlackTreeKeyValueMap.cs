using System.Collections.Generic;
using DSA.DataStructures.Trees;

namespace Lab1
{
    public class RedBlackTreeKeyValueMap<TKey, TValue>
    {
        private RedBlackTreeMap<TKey, TValue> RedBlackTreeMap = new RedBlackTreeMap<TKey, TValue>();

        public int Height => RedBlackTreeMap.Height;

        public int Count => RedBlackTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            RedBlackTreeMap.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            TValue value;
            RedBlackTreeMap.TryGetValue(key, out value);
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (RedBlackTreeMap.ContainsKey(key))
            {
                RedBlackTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

