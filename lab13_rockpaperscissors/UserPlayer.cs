using System;
namespace lab13_rockpaperscissors
{
	//user class
    public class UserPlayer : Members
    {
        public UserPlayer(string _name, Roshambo _choice) : base(_name, _choice)
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
