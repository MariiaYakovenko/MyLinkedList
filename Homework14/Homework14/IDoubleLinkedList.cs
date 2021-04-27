using System;
using System.Collections.Generic;
using System.Text;

namespace Homework14
{
  public interface IDoubleLinkedList<T>
    {
       public void AddLast(T data);
       public void AddFirst(T data);
       public bool Remove(T data);
       public bool Contains(T data);
       public void Clear();
       public int Count { get; }
       public bool isEmpty { get; }
       public IEnumerable<T> BackEnumerator();
    }
}
