using System;

namespace BugReport
{
    public class IssueTracker
    {
        [BugReport("hello")]
        [BugReport("bye")]
        public void ProcessData()
        {
            Console.WriteLine("Processing Data..");
        }
    }
}