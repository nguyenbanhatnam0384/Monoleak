﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monoleak.Data.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
    }
}
