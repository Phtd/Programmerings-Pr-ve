using System;
using System.Collections.Generic;
using System.Text;

namespace Programmerings_Prøve
{
    class KongFuHarry
    {
        public string Name;
        private int Health = 120;
        private int Attack = 2;
        private int Defense = 5;
        public KongFuHarry(string name, int health, int defense, int attack)
        {
            Name = name;
            Health = health;
            Defense = defense;
            Attack = attack;
        }
    }
}
