using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    public class Nisakkaat : Elain
    {
        public Nisakkaat(int maksimiIka) : base(maksimiIka)
        {

        }

        public Nisakkaat(string nimi, int ika, bool lihis) : base(nimi, ika, lihis)
        {

        }
    }
}
