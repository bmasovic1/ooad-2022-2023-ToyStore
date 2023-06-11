using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace ToyStore.Models
{
    public class Naplata
    {
        [Key]
        public int NaplataId { get; set; }
        [DisplayName("Registrovani Korisnik")]
        public  RegistrovaniKorisnik RegKorisnik { get; set; }
        public  Kartica Kartica { get; set; }
        public  Narudzba Narudzba { get; set; }

        public Boolean Placeno { get; set; }
        public DateTime Datum { get; set; }
    }
}
