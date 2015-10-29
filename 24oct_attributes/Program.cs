using System;
using System.Reflection;

namespace oct_attributes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		    ClassWithFields cwf = new ClassWithFields
		    {
		        FirstNumber = 10,
		        SecondNumber = 10,
		        Name = "alskdhjlaksjd",
		        SecondName = "alskdja"

		    };
            Int32Validate.Validate(cwf);

		    Console.ReadKey();
		}
	}
}
