using System;

namespace ToyStore.Models
{
    public class Kartica
    {
        public string Id { get; }
        public int BrojKartica { get; set; }
        public int MjesecIsteka { get; set; }
        public int GodinaIsteka { get; set; }
        public int Cvv { get; set; }
    }
}
