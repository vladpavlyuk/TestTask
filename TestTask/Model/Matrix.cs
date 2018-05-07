using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Matrix : IAddingItem<Position>, IEnumerable
    {
        List<Position> positions = new List<Position>();

        public void AddItem(Position obj)
        {
            positions.Add(obj);
        }

        public IEnumerator GetEnumerator()
        {
            return positions.GetEnumerator();
        }
    }
}
