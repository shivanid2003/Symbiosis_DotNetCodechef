
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLab
{
    public class Reflect
    {
        public int Field1;
        private string Field2;

        public Reflect() {}
   
        public Reflect(int field1)
        {
            Field1 = field1;
        }

        public string Property1 { get; set; }
        private int Property2 { get; set; }

        public void Method1()
        {
            Console.WriteLine("Method1 called");
        }

        private void Method2(string message)
        {
            Console.WriteLine("Method2 called with message: " + message);
        }
    }

    public interface ISampleInterface
    {
        void InterfaceMethod();
    }

    public class ReflectionExample
    {
        public static void Test()
        {
            // Type to be inspected
            Type type = typeof(Reflect);
            Console.WriteLine("Type: " + type.FullName);

            // Get and display constructors
            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }

            // Get and display methods
            Console.WriteLine("\nMethods:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ToString());
            }

            // Get and display properties
            Console.WriteLine("\nProperties:");
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.ToString());
            }

            // Get and display fields
            Console.WriteLine("\nFields:");
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.ToString());
            }

            // Get and display interfaces
            Console.WriteLine("\nInterfaces:");
            Type[] interfaces = type.GetInterfaces();
            if (interfaces.Length == 0)
            {
                Console.WriteLine("No interfaces found.");
            }
            else
            {
                foreach (Type iface in interfaces)
                {
                    Console.WriteLine(iface.ToString());
                }
            }

            // Get and display nested types
            Console.WriteLine("\nNested Types:");
            Type[] nestedTypes = type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic);

            foreach (Type nestedType in nestedTypes)
            {
                Console.WriteLine(nestedType.ToString());
            }
        }
	public static void Main(string [] args)
	{
		ReflectionExample.Test();
		Console.ReadLine();
	}
    }
}

