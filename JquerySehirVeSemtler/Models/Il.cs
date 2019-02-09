using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JquerySehirVeSemtler.Models
{
    public class Il
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<Ilceler> Ilceler { get; set; }
    }
}