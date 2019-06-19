﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_Layer.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Create(T item);
        T Get(T item);
    }
}
