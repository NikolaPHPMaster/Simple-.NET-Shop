using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NasaProdavnica.Models
{
    public class MainModel
    {
        public Proizvodjac Proizvodjaci { get; set; }
        public Tastatura Tastature { get; set; }
        public Laptop Laptopovi { get; set; }
    }
}