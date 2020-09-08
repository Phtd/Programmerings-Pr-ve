using System;
using System.Collections.Generic;
using System.Text;

namespace Programmerings_Prøve
{
    class Gum_Goat_Ivan
    {
        private int IvanHp = 70;
        private int IvanDef = 8;
        private int Attack = 6;
        public Gum_Goat_Ivan()
        {
            IvanHp -= (IvanDef - Attack);
        }
    }
}
