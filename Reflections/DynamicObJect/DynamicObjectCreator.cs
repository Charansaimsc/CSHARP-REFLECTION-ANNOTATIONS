using System;

namespace DynamicObjectCreation
{
    public static class ObjectFactory
    {
        public static object CreateStudent()
        {
            Type type = typeof(Student);
            return Activator.CreateInstance(type);
        }

        public static object CreateStudentWithParams(int id, string name)
        {
            Type type = typeof(Student);

            return Activator.CreateInstance(type,new object[] { id, name });
        }
    }
}
