using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionaryList<number,name>
    {
        number[] _keys;
        name[] _values;
        public MyDictionaryList()
        {
            _keys = new number[0];
            _values = new name[0];
        }
        public void Add(number key,name value)
        {
            number[] tempKeys = _keys;
            name[] tempValue = _values;
            _keys = new number[_keys.Length + 1];
            _values = new name[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValue[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }
        public int Length
        {
            get { return _keys.Length; }
        }
        public number[] Keys
        {
            get { return _keys; }
        }
        public name[] Values
        {
            get { return _values; }
        }
    }
}
