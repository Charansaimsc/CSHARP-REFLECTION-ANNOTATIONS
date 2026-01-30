using System;
using System.Reflection;
namespace AccessPrivate
{
    public static class PrivateFieldAccessor
    {
        public static int SetAndGetSalary(Person person, int newSalary)
        {
            Type t = typeof(Person);
            FieldInfo f = t.GetField("Salary", BindingFlags.NonPublic | BindingFlags.Instance);
            f.SetValue(person, newSalary);
            return (int)f.GetValue(person);
        }
    }
}