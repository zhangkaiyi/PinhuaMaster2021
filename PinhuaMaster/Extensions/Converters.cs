using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PinhuaMaster.Extensions.Converters
{
    public class MyDateTimeConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public MyDateTimeConverter() : base()
        {
            base.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }

    public class MyDateConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public MyDateConverter() : base()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }

    public class MyTimeConverter : Newtonsoft.Json.Converters.IsoDateTimeConverter
    {
        public MyTimeConverter() : base()
        {
            base.DateTimeFormat = "HH:mm";
        }
    }

    public class MyDecimalAmountConverter : Newtonsoft.Json.Converters.CustomCreationConverter<decimal>
    {
        public override bool CanWrite
        {
            get
            {
                return true;
            }
        } 

        public override decimal Create(Type objectType)
        {
            return 0.0M;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
                writer.WriteNull();
            else
            {
                var formatted = ((decimal)value).ToString("0.00");
                writer.WriteValue(formatted);
            }
        }
    }

    public class MyDecimalSquareConverter : Newtonsoft.Json.Converters.CustomCreationConverter<decimal>
    {
        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        public override decimal Create(Type objectType)
        {
            return 0.0M;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
                writer.WriteNull();
            else
            {
                var formatted = ((decimal)value).ToString("0.0000");
                writer.WriteValue(formatted);
            }
        }
    }

    public class MyDecimalQtyConverter : Newtonsoft.Json.Converters.CustomCreationConverter<decimal>
    {
        public override bool CanWrite
        {
            get
            {
                return true;
            }
        }

        public override decimal Create(Type objectType)
        {
            return 0.0M;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
                writer.WriteNull();
            else
            {
                var formatted = ((decimal)value).ToString("0.#");
                writer.WriteValue(formatted);
            }
        }
    }
}
