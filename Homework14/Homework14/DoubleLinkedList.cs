using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Homework14
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>, IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;
        public DoubleLinkedList()
        {
            _count = 0;
            _head = null;
            _tail = null;
        }
        public DoubleLinkedList(T value)
        {
            _count = 1;
            _tail=_head = new Node<T>(value);
        }

        public DoubleLinkedList(T[] values)
        {
            _count = values.Length;
            _head = new Node<T>(values[0]);
            
            _tail = _head;
            if (values.Length != 0)
            {
                for (int i = 1; i < values.Length; i++)
                {
                    Node<T> node = new Node<T>(values[i]);
                    _tail.Next = node;
                    node.Previous = _tail;
                    _tail = node;
                }
                _head.Previous = null;
                _tail.Next = null; 
            }
            else
            {
                _head = null;
                _tail = null;
            }
        }
        public int Count { get { return _count; } }

        public bool isEmpty
        { get
            { if (_count < 1) return true;
                else return false;
            } 
        }

        public void AddFirst(T data)
        {
            _count++;
            if (_head != null)
            {
                _head.Previous = new Node<T>(data, Next: _head, Previous: null);
                _head = _head.Previous;
            }
            else
            {
                _head = _tail = new Node<T>(data);
            }
            
        }

        public void AddLast(T data)
        {
            _count++;
            if (_tail != null)
            {
                _tail.Next = new Node<T>(data, Next:null , Previous: _tail);
                _tail = _tail.Next;      
            }
            else
            {
                _head = _tail = new Node<T>(data);
            }
        }


        public void Clear()
        {
            if(_count>0)
            {
                _head = null;
                _tail = null;
                _count = 0;
            }
        }

        public bool Contains(T data)
        {
            Node<T> node = _head;
             for(int i=0;i<_count;i++)
                {
                   if(node.Data.Equals(data))
                    {
                        return true;
                    }
                    node = node.Next;
                }
              return false;
            
            
        }
        private IEnumerable<T> GetEnumerable()
        {
            Node<T> node = _head;
            while(node!=null)
            {
                yield return node.Data;
                node = node.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerable().GetEnumerator();
        }

        public bool Remove(T data)
        {
            Node<T> nodehead = _head;
            if (_head.Data.Equals(data))
            {
                _head = _head.Next;
                _head.Previous = null;
                _count--;
                return true;
            }
            else if (_tail.Data.Equals(data))
            {
                _tail = _tail.Previous;
                _tail.Next = null;
                _count--;
                return true;
            }
            else
            {
                for (int i = 0; i < _count; i++)
                {
                    if (nodehead.Data.Equals(data))
                    {
                        nodehead.Previous.Next = nodehead.Next;
                        nodehead.Next.Previous = nodehead.Previous;
                        _count--;
                        return true;
                    }
                   
                    nodehead = nodehead.Next;
                }
    
                return false;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerable().GetEnumerator();
        }
        

        public IEnumerable<T> BackEnumerator()
        {
            Node<T> node = _tail;
            while (node != null)
            {
                yield return node.Data;
                node = node.Previous;
            }
        }
    }
}
