using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    class Containers<T> : DataProvider<Container<T>> where T : struct
    {
        public override void AddItem(Container<T> item)
        {
            Add(item);
        }
    }
}
