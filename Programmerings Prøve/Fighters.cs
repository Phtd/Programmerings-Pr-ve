using System;
using System.Collections.Generic;
using System.Text;

namespace Programmerings_Prøve
{
    class Fighter
    {
        private string name;
        private int health;
        private int maxHealth;
        private int attack;
        private int defence;
        private RollingDie die;
        KongFuHarry kongFuHarry = new KongFuHarry();
        Super_Dog_Dino super_Dog_Dino = new Super_Dog_Dino();
        SpeedyKarl speedyKarl = new SpeedyKarl();
        Minimouse_Mikkel minimouse_Mikkel = new Minimouse_Mikkel();
        Gum_Goat_Ivan gum_Goat_Ivan = new Gum_Goat_Ivan();
        Egon_the_Red_Moose egon_The_Red_Moose = new Egon_the_Red_Moose();

        public Fighter(string name, int health, int attack, int defence, RollingDie die)
        {
            this.name = name;
            this.health = health;
        }

        public string HealthCalc()
        {
            string s = "[";
            int total = 20;
            double count = Math.Round(((double)))
        }
    }
}
