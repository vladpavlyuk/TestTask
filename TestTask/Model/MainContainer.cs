using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class MainContainer<T> : PMCDataModel<Container<T>> where T : struct
    {
       public static Container<T>[] ContainerFactory(int count)
       {
            Container<T>[] containers = new Container<T>[count];
            for (int i = 0; i < count; i++)
            {
                containers[i] = new Container<T>();
            }
            return containers;
        }
    }
}
