using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// question 21
// our valuetype will have Value
namespace Final022
{
    class Generic<T> where T: struct
    {
        private ICollection<T> items;

        public void Add(T item)
        {
            items.Add(item);
        }

        public T getSingle(params Value)
        {
            return items.FirstOrDefault(search);
        }

        public ICollection<T> sortDescending()
        {
            return items.OrderByDescending(c => c.Value);
        }
    }

 
}
