using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oct_attributes
{
    class InvalidValueException : System.Exception
    {
        public string Name { get; set; }
        public ValidateInt32Attribute Limits { get; set; }
        public Int32 Value { get; set; }
        public string Description { get; set; }

        public InvalidValueException(string name, ValidateInt32Attribute limits, Int32 value, string description)
        {
            Name = name;
            Limits = limits;
            Value = value;
            Description = description;
        }
    }
}
