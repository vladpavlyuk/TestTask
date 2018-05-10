using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask.CustomException;
using TestTask.Model;

namespace PMCUnitTest
{
    [TestClass]
    public class DataModelUnitTest
    {
        [TestMethod]
        public void CanAddMatricesCorrectly()
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
            for (int i = 0; i < 10; i++)
            {
                matrices[1].Add(new Position<int>());
            }

            //act
            container1.AddRange(matrices);
            container2.AddRange(matrices);

            //assert
            Assert.IsTrue(container1.check);
            Assert.IsTrue(container2.check);
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
        
        [TestMethod]
        public void CanThrowException()
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

            //assert
            Assert.ThrowsException<InvalidMatrixCountException>(() => { container1.AddRange(matrices); });
        }
    }
}
