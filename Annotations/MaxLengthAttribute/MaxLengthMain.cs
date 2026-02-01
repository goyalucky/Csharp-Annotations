/* Create a MaxLength Attribute for Field Validation
Problem Statement: Define a field-level attribute MaxLength(int value) that restricts the
maximum length of a string field.
Requirements:
● Apply it to a User class field (Username).
● Validate length in the constructor.
● Throw ArgumentException if the limit is exceeded. */


using System;
using System.Reflection;

namespace MaxLengthAttribute{
public class MaxLengthMain{
    public static void Execute(){
        try
        {
            User user1 = new User("Lucky"); // Valid
            Console.WriteLine($"User created {user1.Username}");

            User user2 = new User("GLAUniversity"); // invalid, exceeds 10 chars
            Console.WriteLine($"User created {user2.Username}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error {ex.Message}");
        }
    }
}   
}