using System;
using System.Collections;
using System.Collections.Generic;
namespace T1806E_CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("nhap n=");
            int n = Console.Read();

            Console.WriteLine("nhap 1 chuoi:");
            string str = Console.ReadLine();

            Console.WriteLine("nhap 1 so thuc:");
            float f = float.Parse(Console.ReadLine());

            int[] arr = { 1, 2, 3, 4 };
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("hello");

            List<string> ls = new List<string>();
            ls.Add("hello");
            ls.Add("world");
            ls.Add("welcome");
            Console.WriteLine(ls.Count);
            foreach(string x in ls)
            {
                Console.WriteLine(x);
            }

        }
    }
}
