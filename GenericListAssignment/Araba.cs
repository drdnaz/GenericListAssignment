using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListAssignment;

public class Araba
{
    public Marka Marka { get; set; }
    public Model Model { get; set; }
    public double BenzinHarcamasi { get; set; }
    public int ToplamMesafe { get; set; }

    public Araba(Marka marka, Model model, double benzinHarcamasi, int toplamMesafe)
    {
        Marka = marka;
        Model = model;
        BenzinHarcamasi = benzinHarcamasi;
        ToplamMesafe = toplamMesafe;
    }
    public double Hesapla()
    {
        return (BenzinHarcamasi / 100) * ToplamMesafe;
    }
}
