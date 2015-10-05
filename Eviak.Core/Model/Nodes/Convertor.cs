using Eviak.Core.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Nodes
{
    internal static class Convertor
    {
        public static T ConvertTo<T>(string value)
        {
            if (typeof(T) == typeof(int))
                return (T)(object)int.Parse(value);

            if (typeof(T) == typeof(string))
                return (T)(object)value;

            throw new UnknownFieldType();
        }
    }
}