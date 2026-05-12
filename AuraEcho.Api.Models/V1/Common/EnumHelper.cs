using System.ComponentModel;

namespace AuraEcho.Api.Models.V1.Common;

public static class EnumHelper
{
    public static string GetDescription(Enum value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        return Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute), false) is DescriptionAttribute targetAttribute 
            ? targetAttribute.Description
            : value.ToString();
    }
}
