using System;
using System.Collections.Generic;
using System.Text;

namespace Homework14
{
   public class Node <T>
    {

        public Node(T data, Node<T> Next = null, Node<T> Previous = null)
        {
            Data = data;
            this.Next = Next;
            this.Previous = Previous;
        }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public T Data { get; set; }
    }
}
