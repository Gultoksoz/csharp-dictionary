using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tkey[] tempkeys;
        Tvalue[] values;
        Tvalue[] tempvalues;

        public Tkey[] Keys { get { return keys; } }
        public Tvalue[] Values { get { return values; } }

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey tkey, Tvalue tvalue)
        {
            tempkeys = keys;
            tempvalues = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
            }

            for (int i = 0; i < tempvalues.Length; i++)
            {
                values[i] = tempvalues[i];
            }

            keys[keys.Length - 1] = tkey;
            values[values.Length - 1] = tvalue;
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("No..: " + Keys[i] + " Name..: " + Values[i]);
            }
        }
    }
}
