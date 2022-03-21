﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace _1911064981_NguyenNgoThanhSinh_BigSchool.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        private DateTime dateTime;

        public override bool IsValid(Object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "dd/M/yyyy", CultureInfo.CurrentCulture,
                DateTimeStyles.None, out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}