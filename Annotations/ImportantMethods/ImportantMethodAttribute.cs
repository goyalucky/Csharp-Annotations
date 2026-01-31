using System;
using System.ComponentModel;

namespace ImportantMethods
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ImportantMethodAttribute: Attribute
    {
        public string Level{get;}
        // paramter with default value
        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }
}