using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace ToyStore.Models
{
    public class Admin : Korisnik
    {
        [DisplayName("Lista Uposlenika")]
        public List<Uposlenik> ListaUposlenika { get; set; }
    }
}
