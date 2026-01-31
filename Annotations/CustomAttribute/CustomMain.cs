/* Create a Custom Attribute and Use It
Problem Statement: Create a custom attribute TaskInfo to mark tasks with priority and assigned person.
Steps to Follow:
1. Define an attribute TaskInfo with fields Priority and AssignedTo.
2. Apply this attribute to a method in TaskManager class.
3. Retrieve the attribute details using Reflection. */


using System;
using System.Reflection;

namespace CustomAttribute
{
    public class CustomMain
    {
        public static void Execute()
        {
            // Reflection
            Type type = typeof(TaskManager);

            foreach (MethodInfo method in type.GetMethods()){
                TaskInfoAttribute taskInfo = method.GetCustomAttribute<TaskInfoAttribute>();

                if (taskInfo != null)
                {
                    Console.WriteLine($"Method Name - {method.Name}");
                    Console.WriteLine($"Priority - {taskInfo.Priority}");
                    Console.WriteLine($"Assigned To - {taskInfo.AssignedTo}");
                }
            }
        }
    }
}