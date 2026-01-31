/* Suppress Warnings for Unchecked Operations
Problem Statement: Create an ArrayList without generics and use #pragma warning disables
to hide compilation warnings. */


using System;
using System.Collections;

namespace Warnings
{
    public class WarningDemo
    {
        public void UseArrayList(){
#pragma warning disable CS0618, CS8600, CS8602, CS8604
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("c#");
            list.Add(10.5);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
#pragma warning restore CS0618, CS8600, CS8602, CS8604
        }
    }
}
