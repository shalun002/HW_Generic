using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW_Generics.EnumCart;

namespace HW_Generics
{
    class Karta
    {
        public KartSuit suit { get; set; }
        public KartType type { get; set; }

        public Karta(KartSuit suit, KartType type)
        {
            this.suit = suit;
            this.type = type;
        }

        public int Comparer(Karta karta)
        {
            return type > karta.type ? 1 : ((type < karta.type) ? -1 : 0);
        }
    }
}
