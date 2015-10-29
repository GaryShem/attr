using System;
using System.Reflection;

namespace oct_attributes
{
	public static class Int32Validate
	{
		public static void Validate(object obj)
		{
		    FieldInfo[] fields = obj.GetType().GetFields();
            foreach (var field in fields)
            {
                if (field.FieldType.AssemblyQualifiedName != typeof(Int32).AssemblyQualifiedName)
                    continue;
                //с этих пор мы знаем, что проперти - Int32
                //проверяем, есть ли на ней аттрибут
                ValidateInt32Attribute attrProp = (ValidateInt32Attribute)field.GetCustomAttribute(typeof(ValidateInt32Attribute), false);
                if (attrProp == null)
                    continue;
                //с этих пор мы знаем, что проперти - Int32, и у неё есть наш аттрибут
                //теперь мы сверяемся с его условиями
                Int32 n = (Int32)field.GetValue(obj);
                if (n < attrProp.MinValue)
                    throw new InvalidValueException(field.Name, attrProp, n, "value < minvalue");
                if (n > attrProp.MaxValue)
                    throw new InvalidValueException(field.Name, attrProp, n, "value > maxvalue");
                if (n == 0 && attrProp.ZeroEnabled == false)
                    throw new InvalidValueException(field.Name, attrProp, n, "value == 0 when zero is disallowed");
            }

		    PropertyInfo[] properties = obj.GetType().GetProperties();
			foreach (var property in properties)
			{
                if (property.PropertyType.AssemblyQualifiedName != typeof(Int32).AssemblyQualifiedName)
                    continue;
                //с этих пор мы знаем, что проперти - Int32
                //проверяем, есть ли на ней аттрибут
				ValidateInt32Attribute attrProp = (ValidateInt32Attribute)property.GetCustomAttribute(typeof(ValidateInt32Attribute), false);
			    if (attrProp == null)
			        continue;
                //с этих пор мы знаем, что проперти - Int32, и у неё есть наш аттрибут
                //теперь мы сверяемся с его условиями
                Int32 n = (Int32)property.GetValue(obj);
                if (n < attrProp.MinValue)
                    throw new InvalidValueException(property.Name, attrProp, n, "value < minvalue");
                if (n > attrProp.MaxValue)
                    throw new InvalidValueException(property.Name, attrProp, n, "value > maxvalue");
                if (n == 0 && attrProp.ZeroEnabled == false)
                    throw new InvalidValueException(property.Name, attrProp, n, "value == 0 when zero is disallowed");
			}
		}
	}
}

