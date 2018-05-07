using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestTask.Model
{
    public class Position<T> : IAddingItem<Point<T>>, IEnumerable<Point<T>> where T : struct
    {
        private List<Point<T>> points = new List<Point<T>>();
        
        public void AddItem(Point<T> obj)
        {
            points.Add(obj);
        }

        public IEnumerator<Point<T>> GetEnumerator()
        {
            return ((IEnumerable<Point<T>>)points).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Point<T>>)points).GetEnumerator();
        }
    }
}
