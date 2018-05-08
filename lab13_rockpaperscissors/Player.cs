using System;
namespace lab13_rockpaperscissors
{
    
    // base abstract class
    public abstract class Human
    {
        //declares members (properties) & giving public access
        public Roshambo Choice { get; set; }
        public string Name { get; set; }
    }

    // a derived/subclass/ child class (will inherit all of the members: name & roshambo)
    class Player : Human
    {
        //method for printing some info for function verification
        public void Print()
        {
            Console.WriteLine($"{Name}'s choice is {Choice}\n");
        }

        public Player ()
        {}

        public Player(string _name, Roshambo _choice)
        {
            Name = _name;
            Choice = _choice;

        }

        public Roshambo generateRoshambo()
        {
            var v = Enum.GetValues(typeof(Roshambo));
            return (Roshambo)v.GetValue(new Random().Next(v.Length));

        }
    }

}
