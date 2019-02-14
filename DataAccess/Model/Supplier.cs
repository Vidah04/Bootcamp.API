﻿using Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Supplier : BaseModel

    {
        public String Name { get; set; }
        public DateTimeOffset JoinDate { get; set; }
    }
}
