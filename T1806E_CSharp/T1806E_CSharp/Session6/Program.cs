using System;

namespace T1806E_CSharp.Session6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int x = 1;
                x++;
                int y = x / 0;
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("khong the chia cho 0 "+ e.Message);
            }catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine("Error "+e.Message);
            }
            finally
            {
                Console.WriteLine("finish..");
            }
        }

    }

}

namespace Session6_2
{
    public class Demo
    {

    }

    public class Home
    {

    }

    namespace HomeDemo
    {
        public class HomeDemo
        {

        }
    }
}
