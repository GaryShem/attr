using System;

namespace oct_attributes
{
	[AttributeUsage(AttributeTargets.All)]
	public class NameAttribute : System.Attribute
	{
		private string _description;
		public string Description 
		{
			get { return _description; }
		}
		public NameAttribute (string description)
		{
			_description = description;
		}
	}
}

