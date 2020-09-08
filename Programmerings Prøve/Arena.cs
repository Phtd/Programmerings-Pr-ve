using System;
using System.Collections.Generic;
using System.Text;

namespace Programmerings_Prøve
{
    class Arena
    {
        private Fighter fighter1; // Makes the Fighter fighter1
        private Fighter fighter2; // Makes the Fighter fighter2
        private Fighter fighter3; // Makes the Fighter fighter3
        private Fighter fighter4; // Makes the Fighter fighter4
        private RollingDie die; // Makes a die in this class
        public Arena(Fighter fighter1, Fighter fighter2, RollingDie die)
        {
            this.fighter1 = fighter1; 
            this.fighter2 = fighter2; 
            this.die = die;
        }
        private void Render()
        {
            Console.Clear();
            Console.WriteLine("---------- Arena ----------\n");
            Console.WriteLine("Warriors health: \n"); 
            Console.WriteLine( "{0} {1}", fighter1, fighter1.HP()); // Will display the Health of figther 1
            Console.WriteLine("{0} {1}", fighter2, fighter2.HP()); // Will display the Health of fighter 2
        }
        public void Fight()
        {
            Console.WriteLine("Welcome to the Arena!");     // Console Writelines that welcomes the player
            Console.WriteLine("Today {0} will have a bloody battle with {1}! \n", fighter1, fighter2);  // Console Writelines that will tell us which fighters will be fighting
            Console.WriteLine("Noooooooow, let the battle commence");   // Console Writelines that tells us the fight will now commence
            while ()
            {
                
            }
        }
    }
}
