using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectWEBAPI.Models
{
    public class DateConverter :IsoDateTimeConverter
    {
        public DateConverter()
        {
            base.DateTimeFormat = "dd/MM/yyyy HH:mm:ss";
        }
    }
}