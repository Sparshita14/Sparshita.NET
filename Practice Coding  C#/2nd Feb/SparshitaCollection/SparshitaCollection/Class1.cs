using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparshitaCollection
{
    public class SparshitaCollection<T> : ICollection<T>, IList<T>
    {
        private LinkedList<T> myList;
        public SparshitaCollection()
        {
            myList = new LinkedList<T>();
        }

        public T this[int index]
        {
            get
            {
                if(index<0 || index>= myList.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(index));
                }
                return myList.ElementAt(index);
            }
            set
            {
                throw new NotSupportedException("Setting elements by index is not supported in this implementation");
            }
        }

        public int Count => myList.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            myList.AddLast(item);
        }
        public void Clear()
        {
            myList.Clear();
        }
        public bool Contains(T item)
        {
            return myList.Contains(item);
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            myList.CopyTo(array, arrayIndex);
        }
        public bool Remove(T item)
        {
            return myList.Remove(item);
        }
        public int IndexOf(T item)
        {
            int index = 0;
            foreach (T item2 in myList)
            {
                if (EqualityComparer<T>.Default.Equals(item2, item))
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > myList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            if (index == myList.Count)
            {
                myList.AddLast(item);
            }
            else
            {

                var node = myList.First;
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }
                myList.AddBefore(node, item);

            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index > myList.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            var node = myList.First;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            myList.Remove(node);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return myList.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

      
    }
}
