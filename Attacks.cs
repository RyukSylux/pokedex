using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PokedexApp
{
    public class Attacks
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int lowDamage { get; set; }
        public int highDamage { get; set; } 
        public string BonusType { get; set; } 
        public string MalusType { get; set; }


    }
}


