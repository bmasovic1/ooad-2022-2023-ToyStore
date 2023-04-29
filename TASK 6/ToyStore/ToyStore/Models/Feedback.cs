using Microsoft.VisualBasic;
using System;

namespace ToyStore.Models
{
    public class Feedback
    {
        public string Id { get; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public Korisnik Korisnik { get; set; }
        public DateTime Datum { get; set; }
    }
}
