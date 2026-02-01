using System;
namespace RoleBasedAccessDemo{
    [RoleAllowed("ADMIN")]
    public class AdminService
    {
        public void DeleteUser()
        {
            Console.WriteLine("User deleted successfully");
        }
        public void UpdateSystem()
        {
            Console.WriteLine("System get updated");
        }
    }
}