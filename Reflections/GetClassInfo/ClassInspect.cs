using System;
using System.Reflection;
namespace GetClasSInformation{
public class Inspector
{
    public static void Printer(string classname)
    {
        Type t = Type.GetType(classname);
        if (t == null)
        {
            Console.WriteLine("not found");

        }
        PrintMethods(t);
        PrintFields(t);
        PrintConstructors(t);
    }
    public static void PrintFields(Type t)
    {
        Console.WriteLine("fields...///...///...");
        foreach(FieldInfo f in t.GetFields(BindingFlags.Public | BindingFlags.NonPublic |BindingFlags.Instance))
        {
            Console.WriteLine($"{f.FieldType.Name}{f.Name}");
        }
    }
    public static void PrintConstructors(Type t)
    {
        Console.WriteLine("Constructors...///...///...///...//..");
        foreach(ConstructorInfo c in t.GetConstructors())
        {
            Console.WriteLine(c);
        }
    }
    public static void PrintMethods(Type t)
    {
        Console.WriteLine("methodsss////....///.../.././..");
        foreach(MethodInfo m in t.GetMethods(BindingFlags.Public |BindingFlags.NonPublic |BindingFlags.Instance|BindingFlags.DeclaredOnly))
        {
            Console.WriteLine($"{m.ReturnType.Name}{m.Name}");
        }
    }
}
}