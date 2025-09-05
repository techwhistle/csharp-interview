using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Box<T>
    {
        public required T Value { get; set; }
    }

    public class IntBox
    {
        public int Value { get; set; }
    }
    public class StringBox
    {
        public required string Value { get; set; }
    }
}
