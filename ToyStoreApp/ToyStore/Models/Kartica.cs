using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToyStore.Models
{
    public class Kartica
    {
        [Key]

        public int KarticaId { get; set; }

        [DisplayName("Broj Kartica")]
        [Range(1000000000000000, 9999999999999999, ErrorMessage = "Broj kartice mora sadržavati 16 cifara.")]
        public int BrojKartica { get; set; }

        [DisplayName("Mjesec Isteka")]
        [Range(1.0, 12.0, ErrorMessage = "Mjesec isteka mora biti između 1 i 12!")]
        public int MjesecIsteka { get; set; }

        [DisplayName("Godina Isteka")]
        [Range(2023, Double.MaxValue, ErrorMessage = "Godina isteka mora biti poslije 2023!")]
        public int GodinaIsteka { get; set; }

        [DisplayName("CVV")]
        public int Cvv { get; set; }
    }
}
