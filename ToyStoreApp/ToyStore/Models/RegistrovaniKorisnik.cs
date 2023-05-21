using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyStore.Models
{
    public class RegistrovaniKorisnik : Korisnik
    {
        public List<Artikal> Korpa { get; set; }
        public List<Narudzba> Narudzbe { get; set; }
        public string BrojKartice { get; set; }
    }
}
