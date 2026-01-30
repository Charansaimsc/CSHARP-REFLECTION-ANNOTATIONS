using System;
namespace AccessPrivate
{
    public class Person
    {
        private int number;
        private int Salary;
        public Person()
        {
            
        }
        public void Show()
        {
            Console.WriteLine(number+"   "+Salary);
        }
    }
}