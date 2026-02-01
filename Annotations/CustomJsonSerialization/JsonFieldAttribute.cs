using System;
namespace CustomJsonSerialization{
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}   
}

