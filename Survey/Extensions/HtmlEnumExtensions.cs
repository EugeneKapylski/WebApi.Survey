using System;
using System.Linq;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace Survey.Extensions
{
    public static class HtmlEnumExtensions
    {
        public static HtmlString EnumToString<T>(this HtmlHelper helper)
        {
            return new HtmlString(EnumToString<T>());
        }
        private static string EnumToString<T>()
        {
            return EnumToString(typeof(T));
        }
        private static string EnumToString(Type enumType)
        {
            var values = Enum.GetValues(enumType).Cast<int>();
            var enumDictionary = values.ToDictionary(value => Enum.GetName(enumType, value)); return JsonConvert.SerializeObject(enumDictionary);
        }
    }
}
