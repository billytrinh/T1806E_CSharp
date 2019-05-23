using System;
namespace T1806E_CSharp.Session9
{
    public delegate void NumberChange(int x);
    public class Program
    {
        public static void Main(string[] args)
        {
            NumberChange n = new NumberChange(changeInt);
            n(9);

            NumberChange n2 = delegate (int b) {
                Console.WriteLine(b--);
            };

            n2(9);

            NumberChange n3 = delegate (int x){
               Console.WriteLine(x * x);
           };

            n3(99);
        }

        public static void changeInt(int a)
        {
            Console.WriteLine(a++);
        }
    }
}
