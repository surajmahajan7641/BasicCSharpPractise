using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPractise
{
    public class MethodOverriding
    {
        public virtual int Addition(int a, int b)
        {
            return a + b;

        }

        public virtual int Mul(int a, int b, int c)
        {
            return a * b * c;
        }

    }

    public class DerivedAddition : MethodOverriding
    {
        public override int Addition(int a, int b)
        {
            return a+b;
        }
    }

    public class DerivedMultiplication : MethodOverriding
    {
        public override int Mul(int a, int b, int c)
        {
            return a*b*c;
        }
    }
 
 // Newly added class
 public class DerivedMultiplications : MethodOverriding
    {
        public override int Mul(int a, int b, int c)
        {
            return a*b*c;
        }
    }


}
