using System;
namespace T1806E_CSharp.Session7
{
    public delegate void showString(string s);

    public delegate void Numeric(int a, int b);

    public class EventTest
    {
        public int age =0;
        public event showString Click;

        public void ShowEvent()
        {
            if(Click != null)
            {
                Click("Click here...");
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {   
                if(this.age !=0 && this.age != value)
                {
                    Click("Age was changed");
                }
                this.age = value;
            }
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            EventTest ev = new EventTest();
            ev.Click += showStringProgram;

            ev.Age = 20;
            ev.Age = 22;
            //ev.ShowEvent();

            showString ss = new showString(showStringProgram);
            showString s2 = new showString(showStringPro);
            ss += s2;
            // Cach 1
            ss("hello world");
            // Cach 2
            //ss.Invoke("world hello");

            Numeric n1 = new Numeric(Sum);
            Numeric n2 = new Numeric(Minus);
            Numeric n3 = new Numeric(Multiple);
            Numeric n4 = new Numeric(Divide);

            //n1(3, 2);

            //n1 += n3;

            //n1(5, 6);

            //n3 += n4;
            //n2 += n3;
            //n1 += n2;

            n1 += n2;
            n1 += n3;
            n1 += n4;

            n1(10, 5);
        }

        public static void showStringProgram(string x)
        {
            Console.WriteLine(x);
        }

        public static void showStringPro(string x)
        {
            Console.WriteLine("show String: " + x);
        }

        public static void Sum(int a,int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        public static void Minus(int a, int b)
        {
            Console.WriteLine("Minus: " + (a - b));
        }

        public static void Multiple(int a, int b)
        {
            Console.WriteLine("Mutiple: " + (a * b));
        }

        public static void Divide(int a, int b)
        {
            Console.WriteLine("Divide: " + (a / b));
        }
    }
}
