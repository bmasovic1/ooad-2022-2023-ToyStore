using System.Collections.Generic;
using System;

namespace ToyStore.Models
{
    public class Naplata
    {
        public string Id { get; }
        public RegistrovaniKorisnik RegKorisnik { get; set; }
        public Kartica Kartica { get; set; }
        public Narudzba Narudzba { get; set; }
        public Boolean Placeno { get; set; }
        public DateTime Datum { get; set; }
    }
}
