using System;
using Microsoft.VisualBasic;

namespace CustomAttribute
{
    public class TaskManager
    {
        // apply attribute
        [TaskInfo("High","Lucky")]
        public void CompleteTask()
        {
            Console.WriteLine("task completed successfully");
        }
    }
}