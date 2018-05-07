﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Model
{
    public class Matrix<T> : DataProvider<Position<T>> where T : struct
    {
        public override void AddItem(Position<T> item)
        {
            Add(item);
        }
    }
}
