using System;
namespace lab13_rockpaperscissors
{
	// a derived/subclass/ child class (will inherit all of the members: name & roshambo)
    public class RandoPlayer : Members
    {
		public RandoPlayer(string _name, Roshambo _choice) : base(_name, _choice)
		{
			Name = _name;
			Choice = _choice;
		}

        // generates a random roshambo value
        public override Roshambo generateRoshambo()
        {
            var v = Enum.GetValues(typeof(Roshambo));
            return (Roshambo)v.GetValue(new Random().Next(v.Length));
        }
    }
}
