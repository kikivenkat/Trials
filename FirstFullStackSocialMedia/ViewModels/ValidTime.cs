﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace FirstFullStackSocialMedia.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            return DateTime.TryParseExact(Convert.ToString(value),
                                   "HH:mm",
                                   CultureInfo.CurrentCulture,
                                   DateTimeStyles.None,
                                   out dateTime);
        }
    }
}