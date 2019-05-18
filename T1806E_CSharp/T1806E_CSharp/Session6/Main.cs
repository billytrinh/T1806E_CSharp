using System;
namespace DelegateDemo
{
    public delegate void MyEventHandler(string msg);
    public class Window
    {
        public event MyEventHandler Click;

        // mô phỏng vẽ cửa sổ

        public void FireEvent()
        {
            if (Click != null)
                Click("Event Fire.");
        }

    }

    public class Tester
    {
        public static void Main()
        {
            //Window w = new Window();
            //w.Click += w_Click;
            //w.FireEvent(); // phát sinh sự kiện
            //Console.ReadLine();
            MyEventHandler meh = new MyEventHandler(w_Click);
            meh += new MyEventHandler(e_Click);
            meh("hahaha");


        }

        static void w_Click(string msg)
        {
            Console.WriteLine(msg);
        }

        static void e_Click(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}