using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.CustomCollection_HomeWork3
{
    public class CustomStack<T> : ICollection<T>
    {
        public event EventHandler AddElement;
        public event EventHandler RemoveElement;
        private T[] sourceArray;
        public int Count => sourceArray.Length;

        public bool IsReadOnly { get { return false; } }

        public void Add(T item)
        {
            if (sourceArray == null)
            {
                sourceArray = new T[1];
                sourceArray[0] = item;
                return;
            }
            T[] newArray = new T[sourceArray.Length + 1];
            newArray[0] = item;
            Array.Copy(sourceArray, 0, newArray, 1, sourceArray.Length);
            sourceArray = newArray;
            AddElement.Invoke(this,EventArgs.Empty);
            ElementAdded();
        }

        public void Clear()
        {
            sourceArray = null;
        }

        public bool Contains(T item)
        {
            return sourceArray.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        bool ICollection<T>.Remove(T item)
        {
            throw new NotImplementedException();
        }
        public void Push(T item)
        {
            Add(item);
        }
        public void Pop()
        {
            T[] newArray = new T[sourceArray.Length - 1];
            Array.Copy(sourceArray, 1, newArray, 0, sourceArray.Length - 1);
            sourceArray = newArray;
            ElementRemoved();
        }
        public T Peek()
        {
            if (sourceArray.Length == 0 || sourceArray == null)
            {
                return default(T);
            }
            else return sourceArray[0];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void ElementRemoved()
        {
            RemoveElement.Invoke(this, EventArgs.Empty);
        }
        public void ElementAdded()
        {
            AddElement.Invoke(this, EventArgs.Empty);  
        }
    }
}
