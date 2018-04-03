using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Class1 : IDictionary<Red, Green>
    {
        public Green this[Red key]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<Red> Keys
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ICollection<Green> Values
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(KeyValuePair<Red, Green> item)
        {
            throw new NotImplementedException();
        }

        public void Add(Red key, Green value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<Red, Green> item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(Red key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<Red, Green>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<Red, Green>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<Red, Green> item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Red key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(Red key, out Green value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
