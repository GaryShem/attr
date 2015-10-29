using System;
using System.Reflection;

namespace oct_attributes
{
	public static class Int32Validate
	{
		public static bool Validate(object obj)
		{
			foreach (FieldInfo field in obj.GetType().GetFields())
			{
				if (field.FieldType.AssemblyQualifiedName == typeof(Int32).AssemblyQualifiedName)
					continue;
				Int32 n = (Int32)field.GetValue (obj);
				var attrField = (ValidateInt32Attribute)field.GetCustomAttribute (ValidateInt32Attribute, false);
				if ((n < attrField.MinValue || n > attrField.MaxValue) || (n == 0 && attrField.ZeroEnabled == false))
					throw new ArgumentException("VSE OCEN PLOHO");

			}

			foreach (var property in obj.GetType().GetProperties())
			{
				var attr = (NameAttribute)property.GetCustomAttribute(typeof(NameAttribute), false);
				if (property.PropertyType is Int32 == false)
					continue;
				Int32 n = (Int32)property.GetValue (property);
				var attrProp = (ValidateInt32Attribute)property.GetCustomAttribute (ValidateInt32Attribute, false);
				if ((n < attrProp.MinValue || n > attrProp.MaxValue) || (n == 0 && attrProp.ZeroEnabled == false))
					throw new ArgumentException("VSE OCEN PLOHO");
			}
		}
	}
}

