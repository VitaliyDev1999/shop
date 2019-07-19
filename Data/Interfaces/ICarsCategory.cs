﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.Data.Interfaces
{
    interface ICarsCategory
    {
        IEnumerable<Category> AllCateories { get; }

    }
}