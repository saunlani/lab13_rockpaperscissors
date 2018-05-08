using System;
namespace lab13_rockpaperscissors
{

	// base abstract class
	public abstract class Members
	{
		//declares members (properties) & giving public access
		public Roshambo Choice { get; set; }
		public string Name { get; set; }
	}

	// a derived/subclass/ child class (will inherit all of the members: name & roshambo)
	class RockPlayer : Members
	{
		//method for printing some info for function verification
		public void Print()
		{
			Console.WriteLine($"{Name}'s choice is {Choice}\n");
		}

		public RockPlayer()
		{ }

		public RockPlayer(string _name, Roshambo _choice)
		{
			Name = _name;
			Choice = _choice;

		}

	}

	// a derived/subclass/ child class (will inherit all of the members: name & roshambo)
	class RandoPlayer : Members
	{
		//method for printing some info for function verification
		public void Print()
		{
			Console.WriteLine($"{Name}'s choice is {Choice}\n");
		}

		public RandoPlayer()
		{ }

		public RandoPlayer(string _name, Roshambo _choice)
		{
			Name = _name;
			Choice = _choice;

		}

		// generates a random roshambo value
		public Roshambo generateRoshambo()
		{
			var v = Enum.GetValues(typeof(Roshambo));
			return (Roshambo)v.GetValue(new Random().Next(v.Length));

		}


	}

	class UserPlayer : Members
	{
		//method for printing some info for function verification
		public void Print()
		{
			Console.WriteLine($"{Name}'s choice is {Choice}\n");
		}

		public UserPlayer()
		{ }

		public UserPlayer(string _name, Roshambo _choice)
		{
			Name = _name;
			Choice = _choice;

		}

		// generates a random roshambo value
		public Roshambo generateRoshambo()
		{
			var v = Enum.GetValues(typeof(Roshambo));
			return (Roshambo)v.GetValue(new Random().Next(v.Length));

		}
	}
}
