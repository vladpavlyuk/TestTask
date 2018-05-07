using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Container<T> : DataProvider<Matrix<int>> where T : struct
    {
        public override void AddItem(Matrix<int> item)
        {
            Add(item);
        }
    }
}
