using System;
using System.Collections.Generic;
using System.Text;

namespace Programmerings_Prøve
{
    class Egon_the_Red_Moose
    {
        private int EgonHp = 90;
        private int EgonDef = 4;
        Random rndDmg = new Random();
        public void DamageRange()
        {
           rndDmg.Next(5, 12);
        }
        public Egon_the_Red_Moose()
        {
            EgonHp -= (EgonDef - Attack);
        }
    }
}
