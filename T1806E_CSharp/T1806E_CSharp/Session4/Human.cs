using System;
namespace T1806E_CSharp.Session4
{
    public class Human
    {
        private int id;
        private string name;
        private int age;
        public int[] mark = new int[3];


        public Human()
        {
        }

        public int this[int index]
        {
            get
            {   
                return mark[index];
            }
            set
            {
                mark[index] = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
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
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public virtual void Run()
        {

        }

        public void Run(int number)
        {

        }

        public void Run(string str)
        {

        }

    }
}
