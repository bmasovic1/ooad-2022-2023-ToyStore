using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyStore.Models
{
    public class Naplata
    {
        [Key]
        public int NaplataId { get; set; }
        public  RegistrovaniKorisnik RegKorisnik { get; set; }
        public  Kartica Kartica { get; set; }
        public  Narudzba Narudzba { get; set; }

        public Boolean Placeno { get; set; }
        public DateTime Datum { get; set; }
    }
}
