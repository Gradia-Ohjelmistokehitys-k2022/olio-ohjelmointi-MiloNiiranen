using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    internal class Tool
    {
        static Random rnd= new Random();
        public static int GiveNumber(int max,int min = 0)
        { 
            int luku = rnd.Next(min,max);
            return luku;
            
        }
    }
}
