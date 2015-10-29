using System;

namespace oct_attributes
{
	public class ClassWithFields
	{
	    public string string1 = "Dhaz-Dingo!";
        [ValidateInt32Attribute(-10, 10, true)]
	    public string string2 = "Adun Toridas!";

	    public Int32 int1 = 3;

        [ValidateInt32Attribute(-10, 10, false)]
	    public Int32 int2 = 0;

		public string Name {get; set;}
		[ValidateInt32Attribute(-10, 10, true)]
		public string SecondName{get;set;}
		public Int32 FirstNumber{ get; set;}
		[ValidateInt32Attribute(-30, 10, true)]
		public Int32 SecondNumber{get;set;}
	}
}

