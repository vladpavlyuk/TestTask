using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestTask.Model
{
    public class Position : IAddingItem<Point<int>>, IEnumerable
    {
        private List<Point<int>> points = new List<Point<int>>();

        public void AddItem(Point<int> obj)
        {
            points.Add(obj);
        }

        public IEnumerator GetEnumerator()
        {
            return points.GetEnumerator();
        }
    }
}
