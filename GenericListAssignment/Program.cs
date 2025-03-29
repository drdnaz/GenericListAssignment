
using System.Threading.Channels;
using System.Xml.Schema;
using GenericListAssignment;

public class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new();
        //<Tip>
        while (arabalar.Count < 3 || DevamEtmekIstiyorMu())
        {
            Console.Write("Marka Adı: ");
            string markaAdi = Console.ReadLine();

             Console.Write("model Adı: " );
            string modelAdi = Console.ReadLine();

            Console.WriteLine("100mkm de yaktığı yakıt (l): ");
            double benzinHarcamasi =double.Parse(Console.ReadLine());

            Console.WriteLine("Toplam gidilen mesafe : ");
            int toplamMesafe =int.Parse(Console.ReadLine());

            Marka marka = new Marka { Id = arabalar.Count + 1, Name = markaAdi, ImageUrl =$"{markaAdi.ToLower()}.jpg" };

            Model model = new Model { Id = arabalar.Count + 1, Name = modelAdi, ImageUUrl = $"{modelAdi.ToLower()}.jpg" };

            Araba araba = new Araba(marka, model,benzinHarcamasi,toplamMesafe );
            arabalar.Add(araba);

        }

        Console.WriteLine("\n---Eklenen Arabalar ----");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Marka: {araba.Marka.Name},Model: {araba.Model.Name}, 100 km'de yaktığı yakıt: {araba.BenzinHarcamasi}, Toplam Mesafe: {araba.ToplamMesafe}, Toplam yakıt tüketimi: {araba.Hesapla(): 0.00}");
        }
    }
    public static bool DevamEtmekIstiyorMu()
    {
        Console.WriteLine("yeni bir araba eklemek ister misin? (y/n)");
        string cevap = Console.ReadLine().ToLower();
        return cevap == "y";


    }
}
