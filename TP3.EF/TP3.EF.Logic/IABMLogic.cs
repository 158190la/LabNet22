﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.EF.Logic
{
    interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newCategories);

        void Delete(int id);

        void Update(T categories);
    }
}