using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpPractise
{
    public class SealedClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public sealed class Sealed2 : SealedClass
    {

        public int Sub(int a, int b)
        {
            return a - b;
        }

    }

}
