using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyStore.Models
{
    public class Narudzba
    {
        [Key]
        public int NarudzbaId { get; set; }
        public  RegistrovaniKorisnik Kupac { get; set; }
        public  List<Artikal> Artikli { get; set; }

        public double Cijena { get; set; }
        public DateTime Datum { get; set; }
    }
}
