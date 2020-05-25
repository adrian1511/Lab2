﻿using KoreanBeauty.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoreanBeauty.BLL.API
{
    public abstract class API
    {
        protected API(IUnitOfWork database)
        {
            Database = database;
        }
        protected IUnitOfWork Database { get; }

    }
}
