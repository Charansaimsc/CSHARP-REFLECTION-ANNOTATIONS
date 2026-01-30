using System;
namespace DynamicObjectCreation
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Student() { }
        public Student(int ID)
        {
            this.ID = ID;
        }
        public void Display() { }
        public void Store() { }

    }
}