using System;
using System.Reflection;
namespace RoleBasedAccessDemo{
    public static class AccessController{
    public static void Invoke(User user, object service, string methodName)
    {
        Type type = service.GetType();
        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found!");
            return;
        }

        var roleAttr = (RoleAllowedAttribute)
            Attribute.GetCustomAttribute(type, typeof(RoleAllowedAttribute));

        if (roleAttr != null && roleAttr.Role != user.Role)
        {
            Console.WriteLine("Access Denied!");
            return;
        }
        method.Invoke(service, null);
    }
}
}
