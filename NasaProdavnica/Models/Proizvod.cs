using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaProdavnica.Models
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public string Fotografija{ get; set; }
        public double Cena { get; set; }
        public double Popust { get; set; }
        public string Proizvodjac { get; set; }
        public string Rate { get; set; }
        public bool Akcija { get; set; }
        public string Opis { get; set; }

    }
}