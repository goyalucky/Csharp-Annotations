using System;

namespace LogExecutionDemo
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogExecutionTimeAttribute: Attribute
    {
        
    }
}