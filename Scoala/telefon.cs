using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    class Telefon
    {
        public string Model;
        public bool IsSmart;
        public bool EcranDe6;
        public Telefon( string model,bool isSmart, bool ecranDe6)
        {
            Model = model;
            IsSmart = isSmart;
            EcranDe6 = ecranDe6;
            
        }
    }
}
