/* Implement a Custom Serialization Attribute JsonField
Problem Statement: Define an attribute JsonField to mark fields for JSON serialization.
Requirements:
● [JsonField(Name = "user_name")] should map field names to custom JSON keys.
● Apply it on a User class.
● Write a method to convert an object to a JSON string by reading the attributes. */

using System;
namespace RoleBasedAccessDemo{
    public class RoleMain{
    public static void Execute(){
        User admin = new User("Lucky", "ADMIN");
        User user = new User("client", "USER");

        AdminService service = new AdminService();

        Console.WriteLine("ADMIN accessing method:");
        AccessController.Invoke(admin, service, "DeleteUser");

        Console.WriteLine("\nUSER accessing method:");
        AccessController.Invoke(user, service, "DeleteUser");
    }
}

}

