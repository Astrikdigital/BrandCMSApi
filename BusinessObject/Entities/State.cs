﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectsLayer.Entities
{
    public class State : BaseEntity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
