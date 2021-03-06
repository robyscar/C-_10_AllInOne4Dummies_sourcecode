using System;

namespace Indexer
{
    public class KeyedArray
    {
        // The following string provides the "key" into the array --
        // the key is the string used to identify an element.
        private string[] _keys;

        // The object is the actual data associated with that key.
        private object[] _arrayElements;

        // KeyedArray -- Create a fixed-size KeyedArray.
        public KeyedArray(int size)
        {
            _keys = new string[size];
            _arrayElements = new object[size];
        }

        // Find -- Find the index of the element corresponding to the
        //    string targetKey (return a negative if it can't be found).
        private int Find(string targetKey)
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                if (String.Compare(_keys[i], targetKey) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        // FindEmpty -- Find room in the array for a new entry.
        private int FindEmpty()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                if (_keys[i] == null)
                {
                    return i;
                }
            }

            throw new Exception("Array is full");
        }

        // Look up contents by string key -- this is the indexer.
        public object this[string key]
        {
            set
            {
                // See if the string is already there.
                int index = Find(key);
                if (index < 0)
                {
                    // It isn't -- find a new spot.
                    index = FindEmpty();
                    _keys[index] = key;
                }

                // Save the object in the corresponding spot.
                _arrayElements[index] = value;
            }

            get
            {
                int index = Find(key);
                if (index < 0)
                {
                    return null;
                }
                return _arrayElements[index];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an array with enough room.
            KeyedArray ma = new KeyedArray(100);

            // Save the ages of the Simpson kids.
            ma["Bart"] = 10;
            ma["Lisa"] = 8;
            ma["Maggie"] = 2;

            // Look up the age of Lisa.
            Console.WriteLine("Let's find Lisa's age");
            int age = (int)ma["Lisa"];
            Console.WriteLine("Lisa is {0}", age);
            Console.Read();
        }
    }
}
