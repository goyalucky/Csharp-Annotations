/* Create a Todo Attribute for Pending Tasks
Problem Statement: Define an attribute Todo to mark pending features in a project.
Requirements:
● The attribute should have fields:
    o Task (string) → Description of the task
    o AssignedTo (string) → Developer responsible
    o Priority (default: "MEDIUM")
● Apply it to multiple methods.
● Retrieve and print all pending tasks using Reflection. */



using System;
using System.Reflection;

namespace TodoMethod
{
    public class TodoMain{
        public static void Execute(){
            Type type = typeof(FeatureManager);

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)){
                var todos = method.GetCustomAttributes<TodoAttribute>();

                foreach (var todo in todos)
                {
                    Console.WriteLine($"Method - {method.Name}");
                    Console.WriteLine($"Task - {todo.Task}");
                    Console.WriteLine($"AssignedTo - {todo.AssignedTo}");
                    Console.WriteLine($"Priority - {todo.Priority}");
                }
            }
        }
    }
}
