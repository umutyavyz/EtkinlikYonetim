using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Bilet
{
    public int BiletId { get; set; }
    public Katilim Katilimci { get; set; }
    public Etkinlik Etkinlik { get; set; }

    public string Bilgi()
    {
        return $"{Katilimci.AdSoyad} - {Etkinlik.Ad} - {Etkinlik.Tarih.ToShortDateString()}";
    }
}

