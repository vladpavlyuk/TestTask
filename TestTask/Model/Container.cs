using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Container<T> : IAddingItem<Matrix<T>>, IEnumerable<Matrix<T>> where T : struct
    {
        List<Matrix<T>> matrices = new List<Matrix<T>>();

        public void AddItem(Matrix<T> obj)
        {
            matrices.Add(obj);
        }

        public IEnumerator<Matrix<T>> GetEnumerator()
        {
            return ((IEnumerable<Matrix<T>>)matrices).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Matrix<T>>)matrices).GetEnumerator();
        }
    }
}
