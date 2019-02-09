using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JquerySehirVeSemtler.Models
{
    public class Ilceler
    {
        public int Id { get; set; }
        public int Il_Id { get; set; }
        public string Ad { get; set; }

        public Il Il { get; set; }
    }
}