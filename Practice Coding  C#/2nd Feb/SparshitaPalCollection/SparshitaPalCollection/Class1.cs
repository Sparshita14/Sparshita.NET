using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshitaPalCollection
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> prev { get; set; }
        public Node<T> next { get; set; }
        public Node(T val)
        {
            data = val;
            prev = null;
            next = null;

        }
    }

    public class SparshitaPalCollection<T> : ICollection<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public SparshitaPalCollection()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                Node<T> current = GetNodeAtIndex(index);
                return current.data;
            }

            set
            {
                throw new NotSupportedException("you cannot set value");
            }

        }

        public int Count { get; private set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item); ;

            if (head == null)
            {
                // nothing in linkedlist
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode; ;
                newNode.prev = tail;
                tail = newNode;
            }
            Count++;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            Node<T> current = head;
            while(current != null)
            {
                if(EqualityComparer<T>.Default.Equals(current.data, item))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            if(arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            }
            if(arrayIndex+Count > array.Length)
            {
                throw new ArgumentException("the destination is not enough to fit");
            }

            Node<T> current = head;
            int index = arrayIndex;
            while(current!=null)
            {
                array[index++] = current.data;
                current = current.next;
            }
        }

        public bool Remove(T item)
        {
            Node<T> current = head;

            while(current != null)
            {
                if (EqualityComparer<T>.Default.Equals((current.data, item)))
                {
                    RemoveNode(current) ; 
                    return true;
                }
                current=current.next;
            }
            return false;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current=head;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(T item)
        {
            Node<T> current =head;
            int index = 0;
            while(current!=null)
            {
                if (EqualityComparer<T>.Default.Equals((current.data, item)))
                {
                    return index;
                }
                current=current.next;
                index++;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                
                throw new ArgumentOutOfRangeException(nameof(index));
                
            }
            if(index==Count)
            {
                Add(item);
                return;
            }

            Node<T> newNode = new Node<T>(item);
            if(index==0)
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            else 
            {
                Node<T> current = GetNodeAtIndex(index);
                newNode.next = current;
                newNode.prev = current.prev;
                current.prev.next = newNode;
                current.prev = newNode;
            }
            Count++;
        }

        public void RemoveAt(int index)
        {
            if(index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            Node<T> nodeRemove = GetNodeAtIndex(index);
            RemoveNode(nodeRemove);
        }

        private Node<T> GetNodeAtIndex(int index)
        {
            if(index<0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            Node<T> current = head;
            for(int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current;
        }

        private void RemoveNode(Node<T> nodeRemove)
        {
            if(nodeRemove == null)
            {
                return;
            }
            if (nodeRemove == head)
            {
                head = nodeRemove.next;
                if (head != null)
                {
                    head.prev = null;
                }
            }
            else if (nodeRemove == tail)
            {
                tail = nodeRemove.prev;
                if (tail != null)
                {
                    tail.next = null;
                }
            }
            else
            {
                nodeRemove.prev.next=nodeRemove.next;
                nodeRemove.next.prev=nodeRemove.prev;
            }
            Count--;
        }
    }
}
