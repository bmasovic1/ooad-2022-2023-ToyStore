using System.Collections.Generic;
using System;

namespace ToyStore.Models
{
    public class Admin : Korisnik
    {
        public List<Uposlenik> ListaUposlenika { get; set; }
    }
}
