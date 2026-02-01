using System;

namespace CustomJsonSerialization
{
    public class User{
    [JsonField("user_name")]
    public string Username;

    [JsonField("user_age")]
    public int Age;

    [JsonField("user_email")]
    public string Email;

    public User(string username, int age, string email)
    {
        Username = username;
        Age = age;
        Email = email;
    }
}

}