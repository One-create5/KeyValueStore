using System;
using System.Collections.Generic;

namespace KeyValueStore
{
    class MyDictionary
    {
        private KeyValue[] keyValues;
        private int numStored;

        public MyDictionary() 
        {
            keyValues = new KeyValue[100];
            numStored = 0;
        }

        public Object this[string key] 
        {
            set 
            {

                if (numStored <= keyValues.Length)
                {
                    int found = FindIndexValue(key);
                    if (found != -1)
                    {
                        keyValues[found] = new KeyValue(key, value);
                    }

                    keyValues[numStored] = new KeyValue(key, value);
                    numStored++;
                }
            }

            get 
            {
                return FindKeyValue(key);
            }
        }

        private int FindIndexValue(string key) 
        {
            for (int i = 0; i < keyValues.Length; i++)
            {
                if (key == keyValues[i].key)
                {
                    return i;
                }
            }

            return -1;
        }

        private object FindKeyValue(string key) 
        {

            for (int i = 0; i < keyValues.Length; i++)
            {
                if (key == keyValues[i].key)
                {
                    return keyValues[i].value;
                }
            }
            throw new KeyNotFoundException($"Key ({key}) not found");
            
        }
    }
}
