using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    public class Node<T>
    {
        public T data; // T will be switched with a choosen datatype.
        public Node<T> next;

        public Node(T _data)
        {
            data = _data;
            next = null;
        }
    }
}
