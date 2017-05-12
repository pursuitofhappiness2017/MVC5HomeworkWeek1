using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVC5HomeworkWeek1.Models.ValidationAttributes
{
    public class 驗證手機的電話格式Attribute : DataTypeAttribute
    {
        public 驗證手機的電話格式Attribute() : base(DataType.Text)
        {

        }

        public override bool IsValid(object value)
        {
            var str = (string)value;

            Regex regex = new Regex(@"\d{4}-\d{6}");
            Match match = regex.Match(str);

            return base.IsValid(match.Success);
        }
    }
}