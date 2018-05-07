using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Container : IAddingItem<Matrix>, IEnumerable
    {
        List<Matrix> matrices = new List<Matrix>();

        public void AddItem(Matrix obj)
        {
            matrices.Add(obj);
        }

        public IEnumerator GetEnumerator()
        {
            return matrices.GetEnumerator();
        }
    }
}
