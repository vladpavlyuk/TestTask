using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Point<T> where T : struct
    {
        public T XPoint { get { return xPoint; } }
        private readonly T xPoint;

        public T YPoint { get { return yPoint; } }
        private readonly T yPoint;

        public T ZPoint { get { return zPoint; } }
        private readonly T zPoint;

        public Point(T x):this(x, default(T), default(T))
        {

        }

        public Point(T x, T y):this(x, y, default(T))
        {

        }

        public Point(T x, T y, T z)
        {
            xPoint = x;
            yPoint = y;
            zPoint = z;
        }
    }
}
