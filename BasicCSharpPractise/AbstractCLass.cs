//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasicCSharpPractise
//{
//    public abstract class Arithmatic

//    {
//        public abstract int Addition(int a, int b);

//        public abstract int Mul(int a, int b);

//        public abstract int Division(int a, int b);



//        public void Substraction(int a, int b)
//        {
//            int Sub = a-b;
//            Console.WriteLine("Substraction of a and b is : {0}", Sub);

//        }
//    }

//    public class Additions : Arithmatic
//    {
//        public override int Addition(int a, int b)
//        {

//            return a+b;
//        }

//        public override int Mul(int a, int b)
//        {
//            return a*b;
//        }
//        public override int Division(int a, int b)
//        {
//            return a/b;
//        }
//    }


//    public class Divisions : Arithmatic
//    {
//        public override int Division(int a, int b)
//        {
//            return a/b;
//        }
//        public override int Addition(int a, int b)
//        {

//            return a+b;
//        }

//        public override int Mul(int a, int b)
//        {
//            return a*b;
//        }

//    }

//}
