using System;
namespace lab13_rockpaperscissors
{

	// base abstract class
	public abstract class Members
	{
		//declares members (properties) & giving public access
		public Roshambo Choice { get; set; }
		public string Name { get; set; }

		public Members(string _name, Roshambo _choice)
		{
			Name = _name;
			Choice = _choice;
		}

		public abstract Roshambo generateRoshambo();
	}
}