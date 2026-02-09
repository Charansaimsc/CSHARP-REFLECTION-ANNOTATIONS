using System;
using GetClasSInformation;
using AccessPrivate;
using calculators;
using DynamicObjectCreation;
using DynamicMethodInvocation;
namespace MainProgram
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Console.WriteLine("CLASSNAME");
            // Inspector.Printer(Console.ReadLine());


            // Person person = new Person();
            // int Salary = PrivateFieldAccessor.SetAndGetSalary(person,222);
            // Console.WriteLine(Salary);
            // person.Show();


            // Calculator calc = new Calculator();
            // int result = PrivateMethodInvoker.InvokeAdd(calc, 4, 5);
            // Console.WriteLine("Result: " + result);


            // object s1 = ObjectFactory.CreateStudent();
            // object s2 = ObjectFactory.CreateStudentWithParams(1, "Sai");


 MathOperations math = new MathOperations();

            Console.Write("Enter method (Add/Subtract/Multiply): ");
            string method = Console.ReadLine()!;

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine()!);

            int result = DynamicMethodInvocate.Invoke(
                math, method, a, b
            );

            Console.WriteLine("Result: " + result);


        }
    }
}