using System;
using System.Collections.Generic;

namespace ToyStore.Models
{
    public class Korisnik
    {
        public string Id { get; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public List<Artikal> ListaArtikala { get; set; }
    }
}
