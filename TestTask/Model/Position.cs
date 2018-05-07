using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestTask.Model
{
    public class Position<T> : DataProvider<Point<T>> where T : struct
    {
        public override void AddItem(Point<T> item)
        {
            Add(item);
        }
    }
}
