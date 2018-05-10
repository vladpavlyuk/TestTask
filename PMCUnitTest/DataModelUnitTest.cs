using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask.Model;

namespace PMCUnitTest
{
    [TestClass]
    public class DataModelUnitTest
    {
        [TestMethod]
        public void CanCheckNumbersOfPossitions()
        {
            //arrange
            Container<int> container1 = new Container<int>();
            Container<int> container2 = new Container<int>();

            Matrix<int> matrix1 = new Matrix<int>();
            for (int i = 0; i < 50; i++)
            {
                matrix1.Add(new Position<int>());
            }

            Matrix<int> matrix2 = new Matrix<int>();
            for (int i = 0; i < 150; i++)
            {
                matrix1.Add(new Position<int>());
            }

            //act
            container1.Add(matrix1);
            container1.Add(matrix1);

            container2.Add(matrix2);
            container2.Add(matrix2);

            //assert
            Assert.IsFalse(container2.check);
        }

        [TestMethod]
        public void CanAddRangeOfMatricesCorrectly()
        {
            //arrange
            Container<int> container1 = new Container<int>();
            Container<int> container2 = new Container<int>();

            Matrix<int>[] matrices = new Matrix<int>[2];
            for (int i = 0; i < matrices.Length; i++)
            {
                matrices[i] = new Matrix<int>();
            }

            for (int i = 0; i < 10; i++)
            {
                matrices[0].Add(new Position<int>());
            }
            for (int i = 0; i < 5; i++)
            {
                matrices[1].Add(new Position<int>());
            }

            //act
            container1.AddRange(matrices);
            container2.AddRange(matrices);

            //assert
            Assert.IsFalse(container1.check);
            Assert.IsFalse(container2.check);
        }
        [TestMethod]
        public void CanCreateContainers()
        {
            //arrange
            MainContainer<int> container = new MainContainer<int>();

            //act
            container.AddRange(MainContainer<int>.ContainerFactory(3));

            //assert
            Assert.AreEqual(3, container.Count);
            Assert.IsInstanceOfType(container[0], typeof(Container<int>));
        }
    }
}
