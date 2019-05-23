using System;
using System.Threading;
namespace T1806E_CSharp.Session9
{
    //public delegate void running(Object o);

    public class ThreadDemo
    {
        public static void Main(string[] args)
        {
            RunOnThread("Main");
            Thread t = new Thread(RunOnThread);
            t.Start("Thread 2");
        }

        public static void RunOnThread(Object a)
        {
            String s = (String)a;   
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(s +"--"+ i);
                Thread.Sleep(300);
            }
        }
    }
}
