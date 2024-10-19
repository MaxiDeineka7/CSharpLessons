using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningProject.Classes.MyExamples
{
    public class CustomCollection : IEnumerable<int>
    {
        private List<int> _items = new List<int>();

        public void Add(int item)
        {
            _items.Add(item);
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();


        public class Employee : IComparable<Employee>
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public int CompareTo(Employee other)
            {
                return Age.CompareTo(other.Age);
            }
        }

        public class ResourceHolder : IDisposable
        {
            private bool disposed = false;

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!disposed)
                {
                    if (disposing)
                    {

                    }
                    disposed = true;
                }
            }
        }

        public class UserAge : ICollection<int>
        {
            private List<int> _items = new List<int>();

            public void Add(int item) => _items.Add(item);
            public void Clear() => _items.Clear();
            public bool Contains(int item) => _items.Contains(item);
            public void CopyTo(int[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
            public bool Remove(int item) => _items.Remove(item);
            public int Count => _items.Count;
            public bool IsReadOnly => false;

            public IEnumerator<int> GetEnumerator() => _items.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

    }
}
