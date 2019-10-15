﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ChildClass : BaseClass
    {
        // fields
        protected int childProtectedInt;

        // constructors
        public ChildClass() { }
        public ChildClass(int basePrivateInt, int baseProtectedInt,
            int childProtectedInt)
            : base(basePrivateInt, baseProtectedInt)
        {
            this.childProtectedInt = childProtectedInt;
        }

        // methods
        public void ChildMethod()
        {
            Console.WriteLine("ChildClass.ChildMethod");
        }

        public override void PrintState()
        {
            Console.WriteLine("ChildClass object");
            //Console.WriteLine("\tbasePrivateInt: {0}", basePrivateInt);
            //Console.WriteLine("\tbaseProtectedInt: {0}", baseProtectedInt);
            Console.WriteLine("\tchildProtectedInt: {0}", childProtectedInt);
            base.PrintState();
        }
    }
}
