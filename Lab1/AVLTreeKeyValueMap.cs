using DSA.DataStructures.Trees;
using Lab1;
using System.Collections.Generic;

namespace Lab1
{
    class AVLTreeKeyValueMap<TKey, TValue> : IKeyValueMap<TKey, TValue>
    {
        private AVLTreeMap<TKey, TValue> AVLTreeMap = new AVLTreeMap<TKey, TValue>();

        public int Height => AVLTreeMap.Height;

        public int Count => AVLTreeMap.Count;

        public void Add(TKey key, TValue value)
        {
            AVLTreeMap.Add(key, value);
        }

        public KeyValuePair<TKey, TValue> Get(TKey key)
        {
            TValue value;
            AVLTreeMap.TryGetValue(key, out value);
            return new KeyValuePair<TKey, TValue>(key, value);
        }

        public bool Remove(TKey key)
        {
            if (AVLTreeMap.ContainsKey(key))
            {
                AVLTreeMap.Remove(key);
                return true;
            }
            else
            {
                return false;
            }


        }
}