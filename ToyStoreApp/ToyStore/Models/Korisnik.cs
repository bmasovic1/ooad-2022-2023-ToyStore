using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Korisnicko Ime")]
        public string KorisnickoIme { get; set; }
        [EmailAddress(ErrorMessage = "Unesite ispravnu email adresu.")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W)[a-zA-Z\d\W]{8,}$", ErrorMessage = "Šifra mora imati minimalno 8 karaktera, bar 1 veliko slovo, bar 1 znak i bar jedan broj.")]
        public string Lozinka { get; set; }
        public string Slika { get; set; }
        [DisplayName("Lista Artikala")]
        public List<Artikal> ListaArtikala { get; set; }
    }
}
