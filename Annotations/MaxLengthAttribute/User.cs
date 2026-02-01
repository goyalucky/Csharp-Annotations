using System;

namespace MaxLengthAttribute{    
// User class applying the MaxLength attribute
public class User{
    [MaxLength(10)] // Maximum 10 characters allowed
    public string Username;
    public User(string username)
    {
        // validate attribute
        var fieldInfo = typeof(User).GetField(nameof(Username));
        var maxLengthAttr = (MaxLengthAttribute)Attribute.GetCustomAttribute(fieldInfo, typeof(MaxLengthAttribute));

        if (maxLengthAttr != null && username.Length > maxLengthAttr.Length)
        {
            throw new ArgumentException($"username cannot exceed {maxLengthAttr.Length} characters.");
        }
        Username = username;
    }
}
}