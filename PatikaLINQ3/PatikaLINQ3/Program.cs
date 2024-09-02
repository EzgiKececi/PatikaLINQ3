using PatikaLINQ3;
using System.ComponentModel.Design;
using System.IO;
using System.Threading.Channels;

public class Program
{
    public static void Main()
    {
        List<Serie> filmList = new List<Serie>();

        bool film = false;

        while (!film)
        {

            Console.WriteLine("Dizi listenizi oluşturmak için aşağıdaki bilgileri giriniz: ");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Dizinin adı: ");
            string serieName = Console.ReadLine();

            Console.Write("Dizinin türü: ");
            string serieType = Console.ReadLine();

            Ask: Console.Write("Dizinin yayınlanma tarihi: ");
            int releasedYear;
            
            if (!int.TryParse(Console.ReadLine(), out releasedYear))
            {
                Console.WriteLine("Yanlış bir değer girdiniz. Tekrar deneyiniz.");
                goto Ask;
            }


            Console.Write("Dizinin yönetmeni: ");
            string director = Console.ReadLine();

            Console.Write("Dizinin yayınlandığı kanal: ");
            string tvChannel = Console.ReadLine();

            Serie newFilm = new Serie(serieName, serieType, releasedYear, director, tvChannel);
            filmList.Add(newFilm);

            Console.WriteLine("Başka bir film eklemek ister misiniz? (E/H)");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "h") 
                film = true;
        }
   

        // "Komedi" türündeki dizileri filtreliyoruz ve yeni liste oluşturuyoruz
        var comedySeries = filmList
            .Where(x => x.SerieType.Equals("Komedi", StringComparison.OrdinalIgnoreCase))
            .Select(x => new SerieInfo(x.SerieName, x.SerieType, x.Director))
            .ToList();

       
        // Listeyi dizi isimlerine ve yönetmen isimlerine göre sıralıyoruz
        var sortedComedySeries = comedySeries
            .OrderBy(x => x.SerieName)
            .ThenBy(x => x.Director)
            .ToList();


        Console.WriteLine("------------------------------------------------------------");

        Console.WriteLine("Komedi türündeki diziler:");
        foreach (var serie in sortedComedySeries)
        {
            Console.WriteLine($"Dizi Adı: {serie.SerieName}, Yönetmen: {serie.Director}");
        }

    }
}