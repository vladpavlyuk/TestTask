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
       
    }
}
