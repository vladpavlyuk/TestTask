using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Matrix<T> : IAddingItem<Position<T>>, IEnumerable<Position<T>> where T : struct
    {
        List<Position<T>> positions = new List<Position<T>>();

        public void AddItem(Position<T> obj)
        {
            positions.Add(obj);
        }

        public IEnumerator<Position<T>> GetEnumerator()
        {
            return ((IEnumerable<Position<T>>)positions).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Position<T>>)positions).GetEnumerator();
        }
    }
}
