/* Create an Attribute for Logging Method Execution Time
Problem Statement: Define an attribute LogExecutionTime to measure method execution time.
Requirements:
● Apply LogExecutionTime to a method.
● Use Stopwatch before and after execution.
● Print execution time.
● Apply it to different methods and compare the time taken. */


using System;
using System.Reflection;
using System.Diagnostics;

namespace LogExecutionDemo
{
    public class LogMain
    {
        public static void Execute(){
            PerformanceTest test = new PerformanceTest();
            Type type = typeof(PerformanceTest);

            foreach (MethodInfo method in type.GetMethods(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
                // Check if method has LogExecutionTime attribute
                if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
                {
                    Stopwatch sw = Stopwatch.StartNew();

                    // Invoke the method
                    method.Invoke(test, null);

                    sw.Stop();

                    Console.WriteLine($"Method - {method.Name}");
                    Console.WriteLine($"Time - {sw.ElapsedMilliseconds}");
                }
            }
        }
    }
}