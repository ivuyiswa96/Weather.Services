﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Services.Models
{
    public class System
    {
        public int Type { get; set; }
        public int Id { get; set; }
        public string Country { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
    }
}
