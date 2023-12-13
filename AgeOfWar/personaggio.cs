using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfWar
{
    public abstract class  personaggio
    {
         public int puntivita {  get; set; }
        public int puntiForza { get; set; }
        public int squadra { get; set; }
        public int velocita { get; set; }
        public int puntidifesa { get; set; } 
    }
}
