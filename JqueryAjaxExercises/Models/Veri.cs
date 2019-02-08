using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryAjaxExercises.Models
{
    public class Veri
    {
        private static List<Urun> _urunler;

        public static List<Urun> Urunler
        {
            get
            {
                if (_urunler == null)
                {
                    _urunler = new List<Urun>
                    {
                        new Urun
                        {
                            Id = 1, Ad = "Bilgisayar", Fiyat = 1200
                        },
                        new Urun
                        {
                            Id = 2, Ad = "Notebook", Fiyat = 2200
                        },
                        new Urun
                        {
                            Id = 3, Ad = "Tablet PC", Fiyat = 800
                        },
                        new Urun
                        {
                            Id = 4, Ad = "Netbook", Fiyat = 600
                        },
                        new Urun
                        {
                            Id = 5, Ad = "Akıllı Telefon", Fiyat = 1750
                        }
                    };
                }
                return _urunler;
            }
        }
    }
}