using System;
namespace MaxLengthAttribute
{
//  define the custom attribute
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class MaxLengthAttribute : Attribute
{
    public int Length { get; }
    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}   
}
