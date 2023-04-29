using System.Collections.Generic;

namespace ToyStore.Models
{
    public class Artikal
    {
        public string Id { get; }
        public string Naziv { get; set; }
        public Brend Brend { get; set; }
        public string Boja { get; set; }
        public string Dob { get; set; }
        public Pol Pol { get; set; }
        public double Cijena { get; set; }
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
