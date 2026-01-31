/* Use Obsolete Attribute to Mark an Old Method
Problem Statement: Create a class LegacyAPI with an old method OldFeature(),which should not be used anymore. Instead, introduce a 
new method NewFeature().
Steps to Follow:
1. Define a class LegacyAPI.
2. Mark OldFeature() as [Obsolete].
3. Call both methods and observe the warning. */

using System;

namespace ObseleteAttribute
{
    public class LegacyApi{
        [Obsolete("Old Feature is deprecated")]
        public void OldFeature()
        {
            Console.WriteLine("this is an old feature");
        }
        public void NewFeature()
        {
            Console.WriteLine("this is an new feature");
        }
    }
}