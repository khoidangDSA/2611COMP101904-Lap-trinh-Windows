using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Repository<T> where T : IEntity
    {
        private readonly List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public T FindById(string id)
        {
            foreach (T item in items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return default(T);
        }

        public List<T> Find(Func<T, bool> condition)
        {
            return items.Where(condition).ToList();
        }

        public List<T> GetAll()
        {
            return items;
        }
    }
}