using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsevegesCLI
{
    internal class Beszelgetes
    {
        private readonly string _datePattern = "yy.MM.dd-HH:mm:ss";

        public DateTime Kezdet { get; set; }
        public DateTime Veg { get; set; }
        public string Kezdemenyezo { get; set; }
        public string Fogado { get; set; }

        public override string ToString()
        {
            return 
                $"\tKezdeményező: {Kezdemenyezo}\n" +
                $"\tFogadó:       {Fogado}\n" +
                $"\tKezdet:       {Kezdet.ToString(_datePattern)}\n" +
                $"\tVége:         {Veg.ToString(_datePattern)}\n" +
                $"\tHossz:        {(Veg - Kezdet).TotalSeconds} mp";
        }

        public Beszelgetes(string sor)
        {
            var v = sor.Split(';');
            Kezdet = DateTime.ParseExact(v[0], _datePattern, null);
            Veg = DateTime.ParseExact(v[1], _datePattern, null);
            Kezdemenyezo = v[2];
            Fogado = v[3];
        }
    }
}
