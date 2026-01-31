using System;

namespace CustomAttribute
{
    // define custom attribute
    [AttributeUsage(AttributeTargets.Method)]
    public class TaskInfoAttribute: Attribute
    {
        public string Priority;
        public string AssignedTo;
        public TaskInfoAttribute(string priority,string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }
}