using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Etkinlik
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public DateTime Tarih { get; set; }
    public int Kapasite { get; set; }
    public List<Katilim> Katilimci { get; set; } = new List<Katilim>();

    public bool KatilimciEkle(Katilim katilim)
    {
        if (Katilimci.Count < Kapasite)
        {
            Katilimci.Add(katilim);
            return true;
        }
        return false;
    }
}
