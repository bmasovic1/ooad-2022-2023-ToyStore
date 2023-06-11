using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyStore.Models
{
    public  class Artikal
    {
        [Key]
        public int ArtikalId { get; set; }
        public string Naziv { get; set; }
        public Brend Brend { get; set; }
        public string Boja { get; set; }
        public string Dob { get; set; }
        public Pol Pol { get; set; }

        [Range(1, Double.MaxValue, ErrorMessage = "Cijena ne smije biti negativna")]
        public double Cijena { get; set; }
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Broj mora biti cijeli pozitivan broj")]
        public int Kolicina { get; set; }
        public List<Feedback> Feedback { get; set; }

    }

    public enum Brend
    {
        LEGO, Hasbro, Nerf, Funko, Mattel, FisherPrice
    }

    public enum Pol
    {
        M, Z
    }
}
