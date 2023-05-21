using System;
using System.ComponentModel.DataAnnotations;

namespace ToyStore.Models
{
    public class Kartica
    {
        [Key]
        public int KarticaId { get; set; }
        public int BrojKartica { get; set; }
        public int MjesecIsteka { get; set; }
        public int GodinaIsteka { get; set; }
        public int Cvv { get; set; }
    }
}
