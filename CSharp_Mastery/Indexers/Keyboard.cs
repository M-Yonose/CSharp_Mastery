using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    public class Keyboard
    {
        private Key[] keys;

        public Key this[string index]
        {
            get
            {
                foreach (var key in keys)
                {
                    if (key.Name == index)
                    {
                        return key;
                    }
                }
                return null;
            }
            set
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Name == index)
                    {
                        keys[i] = value;
                        return;
                    }
                }
            }
        }

        public Keyboard()
        {
            keys = new Key[]
            {
                new Key{ Name = "A", Value = 65 },
                new Key{ Name = "B", Value = 66 },
                new Key{ Name = "C", Value = 67 }
            };
        }
    }
}