using System;

namespace TodoMethod
{
    public class FeatureManager
    {
        [Todo("Implement authentication", "Lucky", "HIGH")]
        [Todo("Add input validation", "Abhay")]
        public void LoginFeature()
        {
            Console.WriteLine("Login feature executed");
        }

        [Todo("Optimize database queries", "Rishabh", "LOW")]
        public void ReportFeature()
        {
            Console.WriteLine("Report feature executed");
        }

        public void Dashboard()
        {
            Console.WriteLine("Dashboard loaded");
        }
    }
}
