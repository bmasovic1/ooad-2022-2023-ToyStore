using System;
using System.Collections.Generic;

namespace ToyStore.Models
{
    public class Narudzba
    {
        public string Id { get; }
        public RegistrovaniKorisnik Kupac { get; set; }
        public List<Artikal> Artikli { get; set; }
        public double Cijena { get; set; }
        public DateTime Datum { get; set; }
    }
}
