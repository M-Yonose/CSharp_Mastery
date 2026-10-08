using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImportantInterfaces
{
    public class People : IEnumerable<Person>, ICollection<Person>, IDisposable
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Person item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Person item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Person item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return new PeopleEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}