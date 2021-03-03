using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaProdavnica.Models
{
    public class Proizvodjac
    {
        public string naziv;
        public string vebSajt;
        public Proizvodjac(string naziv,string vebSajt)
        {
            this.naziv = naziv;
            this.vebSajt = vebSajt;
        }
    }
}