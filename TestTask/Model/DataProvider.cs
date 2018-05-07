﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public abstract class DataProvider<T> : ICollection<T>
    {
        private List<T> list;

        public DataProvider()
        {
            list = new List<T>();
        }

        public int Count => ((ICollection<T>)list).Count;

        public bool IsReadOnly => ((ICollection<T>)list).IsReadOnly;

        public void Add(T item)
        {
            ((ICollection<T>)list).Add(item);
        }

        public abstract void AddItem(T item);

        public void Clear()
        {
            ((ICollection<T>)list).Clear();
        }

        public bool Contains(T item)
        {
            return ((ICollection<T>)list).Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            ((ICollection<T>)list).CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((ICollection<T>)list).GetEnumerator();
        }

        public bool Remove(T item)
        {
            return ((ICollection<T>)list).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<T>)list).GetEnumerator();
        }
    }
}
