using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Survey.Models;

namespace Survey.Helpers
{
    public static class EnumHelper
    {
        public static IEnumerable<EnumValueViewModel> GetEnumValues<TEnum>()
        {
            var enumValues = (TEnum[])Enum.GetValues(typeof(TEnum));
            return enumValues
                .Select(GetEnumValue)
                .ToList();
        }

        public static EnumValueViewModel GetEnumValue<TEnum>(TEnum value)
        {
            return new EnumValueViewModel
            {
                Id = Convert.ToInt32(value),
                Name = value.ToString(),
                DisplayName = value.GetEnumDescription()
            };
        }

        private static string GetEnumDescription<T>(this T source)
        {
            var fi = source.GetType().GetField(source.ToString());

            var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes[0].Description : source.ToString();
        }
    }
}
