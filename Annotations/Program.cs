using System;
using OveridingExample;
using ObseleteAttribute;
using Warnings;
using CustomAttribute;
using BugReport;
using ImportantMethods;
using TodoMethod;
using LogExecutionDemo;
using MaxLengthAttribute;
using RoleBasedAccessDemo;
using CustomJsonSerialization;

namespace Annotations
{
    class Program
    {
        static void Main(string[] args){

            JsonMain.Execute();

            // RoleMain.Execute();

            // MaxLengthMain.Execute();

            // LogMain.Execute();

            // TodoMain.Execute();

            // ImportantMain.Execute();

            // BugReportMain.Execute();

            // CustomMain.Execute();

           /*  WarningDemo w = new WarningDemo();
            w.UseArrayList(); */

            /*
            LegacyApi api = new LegacyApi();
            api.OldFeature();
            api.NewFeature();
            */

            /*
            Dog dog = new Dog();
            dog.MakeSound();
            */
        }
    }
}
