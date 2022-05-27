using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public enum Calitate
    {
        BUNA = 2, MEDIE = 1, PROASTA = 0
    }

    public class CalitateHelp
    {
        public static Calitate transformNumberToCalitate(int nr)
        {
            switch(nr)
            {
                case 2: return Calitate.BUNA;
                case 1: return Calitate.MEDIE;
                case 0: return Calitate.PROASTA;
                default: return Calitate.BUNA;
            }
        }
    }
}
