using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ImportantInterfaces
{
    public class Tree : IEnumerable<Node>
    {
        public Node Root { get; private set; }

        public void AddLeft(Node item, int value)
        {

        }

        public void AddRight(Node item, int value)
        {

        }

        public IEnumerator<Node> GetEnumerator()
        {
            return new TreeEnumberator(Root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}