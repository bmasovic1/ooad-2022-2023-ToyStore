using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyStore.Models
{
    public abstract class Korisnik
    {
        [Key]
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public string Slika { get; set; }
        public List<Artikal> ListaArtikala { get; set; }
    }
}
