﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestTask
{
    interface IAddingItem<T>
    {
        void AddItem(T obj);
    }
}
