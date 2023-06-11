using System;
using System.ComponentModel.DataAnnotations;

namespace ToyStore.Models
{
    public class Uposlenik : Korisnik
    {
        [Range(1, Double.MaxValue, ErrorMessage = "Plata ne smije biti negativna")]
        public double Plata { get; set; }  
    }
}
