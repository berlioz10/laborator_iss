using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaAppGui.Models
{
    public enum StareRetur
    {
        NERETURNAT, ASTEPTARE, RETURNAT
    }

    public class StareReturHelp
    {
        public static StareRetur transformNumberToStareRetur(int nr)
        {
            switch (nr)
            {
                case 2: return StareRetur.NERETURNAT;
                case 1: return StareRetur.ASTEPTARE;
                case 0: return StareRetur.RETURNAT;
                default: return StareRetur.NERETURNAT;
            }
        }
    }
}
