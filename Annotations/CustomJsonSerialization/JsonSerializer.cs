using System;
using System.Text;
using System.Reflection;

namespace CustomJsonSerialization{
    public static class JsonSerializer{
    public static string Serialize(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields();

        StringBuilder json = new StringBuilder();
        json.Append("{");

        bool first = true;

        foreach (FieldInfo field in fields)
        {
            var attr = (JsonFieldAttribute)
                Attribute.GetCustomAttribute(field, typeof(JsonFieldAttribute));

            if (attr != null)
            {
                if (!first)
                    json.Append(", ");

                string key = attr.Name;
                object value = field.GetValue(obj);

                json.Append($"\"{key}\": ");

                if (value is string)
                    json.Append($"\"{value}\"");
                else
                    json.Append(value);
                first = false;
            }
        }
        json.Append("}");
        return json.ToString();
    }
}
}