using System;
using System.Collections.Generic;
using System.Text;

namespace Programmerings_Prøve
{
    class SpeedyKarl
    {
        private string Name;
        private int Health = 90;
        private int Defense = 3;
        private int LeftAttack = 2;
        private int RightAttack = 5;
        public SpeedyKarl(string name, int health, int defense, int leftAttack, int rightAttack)
        {
            Name = name;
            Defense = defense;
            Health = health;
            LeftAttack = leftAttack;
            RightAttack = rightAttack;

        }
    }
}
