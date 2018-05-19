using System;
namespace lab13_rockpaperscissors
{
	// a derived/subclass/ child class (will inherit all of the members: name & roshambo)
    public class RockPlayer : Members
    {

        public RockPlayer(string _name, Roshambo _choice) : base(_name, _choice)
        {
            Name = _name;
            Choice = _choice;
        }

		// generates a random roshambo value
        public override Roshambo generateRoshambo()
        {
			return Roshambo.rock;

        }
    }
}
