using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_hash_table
{
    public class customHashTable
    {
        private LinkedList<object>[] MoHashTable = null;
        private int MiHashListSize = 0;

        public customHashTable(int PiHashTableSize)
        {
            MiHashListSize = PiHashTableSize;
            MoHashTable = new LinkedList<object>[PiHashTableSize];
        }
        private int generateHash(string key)
        {
            int hashCode = 0;
            for (int LcX = 0; LcX < key.Length; LcX++)
            {
                hashCode = (hashCode + ((int)key[LcX]) * LcX) % MiHashListSize;
            }
            return hashCode;
        }
        public string set(string PsKey, object PoValue)
        {
            if (this.duplicatedKey(PsKey))
                return "The key: " + PsKey + " is duplicated.";

            int LiKeyHash = this.generateHash(PsKey);
            if (MoHashTable[LiKeyHash] == null)
                MoHashTable[LiKeyHash] = new LinkedList<object>();

            MoHashTable[LiKeyHash].AddLast(new object[] { PsKey, PoValue });
            return "The key: " + PsKey + " has been added.";
        }
        private bool duplicatedKey(string PsKey)
        {
            string[] LsKeys = this.keys();
            foreach (string LsKey in LsKeys)
                if (LsKey.Equals(PsKey))
                    return true;

            return false;
        }
        public object? get(string PsKey)
        {
            object LoValue = null;
            int LiKeyHash = this.generateHash(PsKey);
            LinkedList<object> LoBucket = MoHashTable[LiKeyHash];
            foreach (object[] LoItem in LoBucket)
                if (((string)LoItem[0]) == PsKey)
                    LoValue = LoItem[1];

            return LoValue;
        }
        public string[] keys()
        {
            string LsKeys = string.Empty;

            foreach (LinkedList<object> LoHashes in MoHashTable)
                if (LoHashes != null)
                    foreach (object[] LoLinkedListItem in LoHashes)
                        LsKeys += LoLinkedListItem[0].ToString() + ",";

            LsKeys = LsKeys.EndsWith(",") ? LsKeys.Substring(0, LsKeys.Length - 1) : LsKeys;
            return LsKeys.Split(",").ToArray<string>();
        }
    }
}