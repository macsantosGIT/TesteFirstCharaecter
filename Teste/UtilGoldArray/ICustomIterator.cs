﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.UtilGoldArray
{
    public interface ICustomIterator
    {
        bool HasNext();
        object Next();
    }
}
