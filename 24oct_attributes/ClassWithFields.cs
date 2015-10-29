using System;

namespace oct_attributes
{
	public class ClassWithFields
	{
		public ClassWithFields ()
		{
			
		}
		public string Name {get; set;}
		[ValidateInt32Attribute(-10, 10, true)]
		public string SecondName{get;set;}
		public Int32 FirstNumber{ get; set;}
		[ValidateInt32Attribute(-10, 10, true)]
		public Int32 SecondNumber{get;set;}
	}
}

