using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class MyNode
    {
        public int Value { get; set; }
        public int HowManyBig { get; set; }
        public MyNode Next { get; set; }

        public MyNode(int val)
        {
            this.Value = val;
            this.HowManyBig = 0;
            this.Next = null;
        }
    }
}
