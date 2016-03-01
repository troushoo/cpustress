using System;

namespace ConsoleApplication
{
    public class Program
    {
        static void mymethod(long l){
           long l1 = 1;
           long l2 = 2;
           long l3;

           while(true){
              l3 = l1 + l2;
              l1 = l2 * l3;
              l2 = l2 + l3;
           }
        }
        public static void Main(string[] args)
        {
            mymethod(1);
        }
    }
}
