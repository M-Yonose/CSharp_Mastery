using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImportantInterfaces
{
    public class PeopleEnumerator : IEnumerator<Person>
    {
        public Person Current => throw new NotImplementedException();

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}