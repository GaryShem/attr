using System;
using System.Reflection;

namespace oct_attributes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			foreach (var property in (typeof(FirstClass)).GetProperties())
			{
				var attr = (NameAttribute)property.GetCustomAttribute(typeof(NameAttribute), false);
				Console.WriteLine ("{0} : {1}", property.Name, attr.Description);
			}
		}
	}
}
