using System;
using System.Collections.Generic;
using System.Text;

namespace Programmerings_Prøve
{
    class Minimouse_Mikkel
    {
        private string Name;
        private int Health = 40;
        private int Defense = 9;
        private int Attack = 9;
        public Minimouse_Mikkel(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            Defense = defense;
            Attack = attack;
        }
    }
}
