using System.Reflection;
namespace calculators
{
    public static class PrivateMethodInvoker
    {
        public static int InvokeAdd(Calculator calculator,int a , int b)
        {
            Type t = typeof(Calculator);
            MethodInfo method = t.GetMethod("Add",BindingFlags.NonPublic | BindingFlags.Instance );
            Object result = method.Invoke(calculator,new object[]{a,b});
            return (int)result;
        }
    }
}