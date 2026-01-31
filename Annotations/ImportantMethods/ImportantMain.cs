/* Create an Attribute to Mark Important Methods
Problem Statement: Define a custom attribute ImportantMethod that can be applied to
methods to indicate their importance.
Requirements:
1. Define ImportantMethod with an optional Level parameter (default: "HIGH").
2. Apply it to at least two methods.
3. Retrieve and print annotated methods using Reflection. */


using System;
using System.Reflection;

namespace ImportantMethods
{
    public class ImportantMain
    {
        public static void Execute(){
            Type type = typeof(ServiceManager);

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)){
                var attr = method.GetCustomAttribute<ImportantMethodAttribute>();

                if (attr != null)
                {
                    Console.WriteLine($"Method - {method.Name}");
                    Console.WriteLine($"Level - {attr.Level}");
                }
            }
        }
    }
}