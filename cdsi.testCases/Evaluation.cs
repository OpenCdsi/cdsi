﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cdsi.testCases
{
    public class Evaluation
    {
        public string Series_Status { get; set; }
        public IEnumerable<Dose> AdministeredDoses { get; set; }
    }
}
