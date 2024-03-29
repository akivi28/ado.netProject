﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado_dz_9.Classes
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public ICollection<Player>? Players { get; set; } 
    }

}
