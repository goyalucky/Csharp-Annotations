/*Implement a Custom Serialization Attribute JsonField
Problem Statement: Define an attribute JsonField to mark fields for JSON serialization.
Requirements:
● [JsonField(Name = "user_name")] should map field names to custom JSON keys.
● Apply it on a User class.
● Write a method to convert an object to a JSON string by reading the attributes. */

using System;
namespace CustomJsonSerialization
{
public class JsonMain{
    public static void Execute(){
        User user = new User("Lucky", 21, "lucky@gmail.com");
        string json = JsonSerializer.Serialize(user);
        Console.WriteLine(json);
    }
}    
}
