using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToyStore.Models
{
    public class Admin : Korisnik
    {
        public List<Uposlenik> ListaUposlenika { get; set; }
    }
}
