using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyStore.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }
        [Range(1, 5, ErrorMessage = "Ocijena mora biti u rasponu od 1 do 5")]
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public Korisnik Korisnik { get; set; }

        public DateTime Datum { get; set; }
    }
}
