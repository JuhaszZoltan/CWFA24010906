using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsevegesCLI
{
    internal class Idoszak
    {
        private readonly string _datePattern = "yy.MM.dd-HH:mm:ss";
        public DateTime Kezdet { get; set; }
        public DateTime Veg { get; set; }
        public TimeSpan Hossz => Veg - Kezdet;
    }
}
