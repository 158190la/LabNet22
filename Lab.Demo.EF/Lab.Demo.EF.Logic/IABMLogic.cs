﻿using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    internal interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T newRegion);

        void Delete(int id);

        void Update(T region);
    }
}