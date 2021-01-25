using System;
using System.Collections.Generic;
using System.Text;

namespace MaDictionary
{
    public class dictionaryManager<K, V>
    {

        K[] _keys;
        V[] _values;

        public dictionaryManager()
        {
            _keys = new K[0];
            _values = new V[0];

        }
        

        public void Add(K key, V value)
        {
            K[] _tempKey = _keys;
            V[] _tempValue = _values;
            _keys = new K[_keys.Length + 1];
            _values = new V[_values.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _keys[i] = _tempKey[i];
                _values[i] = _tempValue[i];
            }
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

        }

        public void GetAll()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine(" Key :  {0}  | Value :   {1}", _keys[i], _values[i]);
            }
        }


        public int Length
        {
            get { return _keys.Length; }
            
        }

        






    }
}

