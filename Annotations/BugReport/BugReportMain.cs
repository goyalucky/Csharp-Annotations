/* Create and Use a Repeatable Attribute
Problem Statement: Define an attribute BugReport that can be applied multiple times on a method.
Steps to Follow:
1. Define BugReport with a Description field.
2. Use AllowMultiple = true to allow multiple bug reports.
3. Apply it twice on a method.
4. Retrieve and print all bug reports */

using System;
using System.Reflection;

namespace BugReport
{
    public class BugReportMain
    {
        public static void Execute()
        {
            Type type = typeof(IssueTracker);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
            foreach (MethodInfo method in methods)
            {
                // retrieve all BugReport attributes
                System.Console.WriteLine(method.Name);
                BugReportAttribute[] atts = (BugReportAttribute[])method.GetCustomAttributes<BugReportAttribute>();
                foreach (BugReportAttribute item in atts)
                {
                    System.Console.WriteLine(item.Description);
                }

            }
        }
    }
}