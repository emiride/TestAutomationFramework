using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestAutomationFramework.CustomAttributes;

namespace TestAutomationFramework.CustomExtensions
{
    public static class EnumExtensions
    {
        public static string Text(this Enum value)
        {
            return value.GetAttribute<TextAttribute>().Text;
        }

        private static TAttribute GetAttribute<TAttribute>(this Enum enumValue)
            where TAttribute : Attribute
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<TAttribute>();
        }
    }
}
