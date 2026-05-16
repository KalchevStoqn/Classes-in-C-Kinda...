using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Devil
    {
        // Properties of a Devil! (Also means "what your class has.For example a devil has a name,
        // Horns,idk why i put color here but also a color, and definitely aura.  ")

        public bool Horns { get; set; }
        public string Colour { get; set; }
        public string Name { get; set; }
        public int Aura { get; set; }
        public bool ShootFireBalls { get;  private set; }  // 'private set' means it can only be changed inside this class

        // 2. Constructor (The blueprint's setup instructions)

        public Devil(bool horns, string colour, string name, int aura) 
        {

            Horns = horns;
            Colour = colour;
            Name = name;
            Aura = aura;

        }
        

        // 3. Methods ( think of it as like actions a devil can perform.)

        public void Destruction(int fireballPower)
        {
            fireballPower = 10000000;
            ShootFireBalls = true;
        }
    }
}
