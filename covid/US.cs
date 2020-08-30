﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid
{
    class US
    {
        public class Estados_Unidos
        {

            public int positive { get; set; }
            public int death { get; set; }
            public int total { get; set; }
            public int positiveIncrease { get; set; }
            public string hash { get; set; }
            public override string ToString()
            {
                return String.Format(hash, total, positive, death, positiveIncrease);
            }
        }
        public class Result
        {
            public IList<Estados_Unidos> data_1 { get; set; }
        }
    }
}
