using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_hash_table
{
    public class HashTable
    {
        private ArrayList[] data;
        public HashTable(int size)
        {
            data = new ArrayList[size];
        }

        internal int generateHash(string key)
        {
            int hashCode = 0;
            for (int LcX = 0; LcX < key.Length; LcX++)
            {
                hashCode = (hashCode + ((int)key[LcX]) * LcX) % this.data.Length;
            }
            return hashCode;
        }

        public void set(string PsKey, object PoValue)
        {
            int LiKeyHash = this.generateHash(PsKey);
            if (this.data[LiKeyHash] == null)
            {
                this.data[LiKeyHash] = new ArrayList(2);
            }
            this.data.SetValue(this.data, LiKeyHash);
        }

        public object get(string PsKey)
        {
            int LiHash = this.generateHash(PsKey);
            ArrayList LoBucket = this.data[LiHash];
            return LoBucket[1];
        }
    }
}