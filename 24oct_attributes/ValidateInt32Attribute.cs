using System;

namespace oct_attributes
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ValidateInt32Attribute : System.Attribute
	{
		public Int32 MinValue {get; private set;}
		public Int32 MaxValue{ get; private set;}
		public bool ZeroEnabled{ get; private set; }
		public ValidateInt32Attribute (Int32 minValue, Int32 maxValue, bool zeroEnabled)
		{
			MinValue = minValue;
			MaxValue = maxValue;
			ZeroEnabled = zeroEnabled;
		}
	}
}

