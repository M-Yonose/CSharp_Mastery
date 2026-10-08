using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImportantInterfaces
{
    public class TreeEnumberator : IEnumerator<Node>
    {
        private Node _root;
        public Node Current { get; private set; }

        object IEnumerator.Current => Current;

        public TreeEnumberator(Node root)
        {
            Current = root;
            _root = root;
        }

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
            Current = _root;
        }
    }
}