using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Model;

namespace Example
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            MainContainer<int> mainContainer = new MainContainer<int>();

            
            Container<int>[] container = new Container<int>[3];
            for (int i = 0; i < container.Length; i++)
            {
                container[i] = new Container<int>();
            }

            Matrix<int>[] matrices = new Matrix<int>[2];
            for (int i = 0; i < matrices.Length; i++)
            {
                matrices[i] = new Matrix<int>();
            }

            Position<int>[] positionXY = new Position<int>[100];
            for (int i = 0; i < positionXY.Length; i++)
            {
                positionXY[i] = new Position<int>();
            }

            Position<int>[] positionX = new Position<int>[100];
            for (int i = 0; i < positionX.Length; i++)
            {
                positionX[i] = new Position<int>();
            }

            for (int i = 0; i < 50; i++)
            {
                positionXY[0].Add(new Point<int>(random.Next(10), random.Next(10)));
            }
            for (int i = 0; i < 200; i++)
            {
                positionXY[1].Add(new Point<int>(random.Next(10), random.Next(10)));
            }

            positionX[0].Add(new Point<int>(1));
            positionX[1].Add(new Point<int>(2));

            matrices[0].AddRange(positionXY);
            matrices[1].AddRange(positionX);

            for (int i = 0; i < 3; i++)
            {
                container[i].AddRange(matrices);
            }

            mainContainer.AddRange(container);

            int count = 0;
            foreach (var cont in mainContainer)
            {
                foreach (var matr in cont)
                {
                    foreach (var pos in matr)
                    {
                        foreach (var point in pos)
                        {
                            
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count); //756
            Console.ReadLine();
          
        }

    }
}
