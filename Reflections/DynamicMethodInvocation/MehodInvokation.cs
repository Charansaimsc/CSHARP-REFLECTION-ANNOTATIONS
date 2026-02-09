using System;
using System.Reflection;
namespace DynamicMethodInvocation
{
    public class DynamicMethodInvocate
    {

        public static int Invoke(object target, string methodName, int a, int b)
        {
            Type t = target.GetType();
            MethodInfo? method = t.GetMethod(methodName,BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if(method == null)
            {
                throw new Exception("notfound");
            }
            object? result = method.Invoke(target,new object[] {a,b});
            return result is int value ?value :0;

        }
    }
}