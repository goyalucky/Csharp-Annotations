using System;

namespace RoleBasedAccessDemo
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RoleAllowedAttribute: Attribute
    {
    public string Role {get;}
    public RoleAllowedAttribute(string role)
        {
            Role = role;        
        }
    }
}