using System;

namespace ImportantMethods
{
    public class ServiceManager
    {
        [ImportantMethod]
        public void StartService()
        {
            Console.WriteLine("Service started");
        }
        [ImportantMethod("LOW")]
        public void StopService()
        {
            Console.WriteLine("Services stopped");
        }
        public void HealthCheck()
        {
            Console.WriteLine("helath check is running");
        }
    }
}