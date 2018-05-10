using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.CustomException;
using TestTask.Model;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                MainContainer<decimal> mainContainer = FillData(3, 2, 100);
                
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
            }
            catch(InvalidMatrixCountException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine(count); //756
            Console.ReadLine();
          
        }

        public static MainContainer<decimal> FillData(int containerCount, int matrixCount, int possitionCount)
        {
            Random random = new Random();

            MainContainer<decimal> mainContainer = new MainContainer<decimal>();
            mainContainer.AddRange(MainContainer<decimal>.ContainerFactory(containerCount));


            Matrix<decimal>[] matrices = new Matrix<decimal>[matrixCount];
            for (int i = 0; i < matrices.Length; i++)
            {
                matrices[i] = new Matrix<decimal>();
            }

            Position<decimal>[] positionXY = new Position<decimal>[possitionCount];
            for (int i = 0; i < positionXY.Length; i++)
            {
                positionXY[i] = new Position<decimal>();
            }

            Position<decimal>[] positionX = new Position<decimal>[possitionCount];
            for (int i = 0; i < positionX.Length; i++)
            {
                positionX[i] = new Position<decimal>();
            }

            for (int i = 0; i < 50; i++)
            {
                positionXY[0].Add(new Point<decimal>(random.Next(10), random.Next(10)));
            }
            for (int i = 0; i < 200; i++)
            {
                positionXY[1].Add(new Point<decimal>(random.Next(10), random.Next(10)));
            }

            positionX[0].Add(new Point<Decimal>(1));
            positionX[1].Add(new Point<decimal>(2));

            matrices[0].AddRange(positionXY);
            matrices[1].AddRange(positionX);

            for (int i = 0; i < mainContainer.Count; i++)
            {
                mainContainer[i].AddRange(matrices);
            }

            return mainContainer;
        }
    }
}
