using System;
using System.Collections.Generic;
using System.Text;

namespace Programmerings_Prøve
{
    class Super_Dog_Dino
    {
        private string Name;
        public int Health = 70;
        private int Defense = 2;
        private int Attack { get; set => Damage; }
        Random rnddmg = new Random();
        public void Damage()
        {
            int Attack = rnddmg.Next(6, 9);
        }
        public Super_Dog_Dino(string name, int health, int defense, int attack)
        {
            Name = name;
            Health = health;
            Defense = defense;
            Attack = attack

        }

    }
}
