﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csci_4711_ess_v0.Entity
{
    public class TORQueue
    {
        // is access control necessary here?
        public Queue<TORequest> Queue { get; set; }
    }
}
