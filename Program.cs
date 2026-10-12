using System.Security.Cryptography.X509Certificates;

namespace Exercises_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //Uppgift: Skriv en metod som tar en lista med heltal och returnerar en ny lista med elementen i omvänd ordning.
            //    List<int> Heltal = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //    List<int> HeltalOmvändordning = MetodSomOmvandlar(Heltal);
            //    HeltalOmvändordning.ForEach(siffra => Console.WriteLine(siffra));
            //    static List<int> MetodSomOmvandlar(List<int> Heltal)
            //{
            //    List<int> OmvandladeTal = new List<int>(Heltal);
            //    OmvandladeTal.Reverse();
            //    return OmvandladeTal;
            //}



            //Uppgift: Skriv en metod som tar en lista med heltal, tar bort dubbletter och returnerar en ny lista med endast distinkta element.
            //List<int> Heltal2 = new List<int> { 1, 2, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 8, 9 };
            //List<int> TaBortDubbletter = MetodSomTarBortDubbletter(Heltal2);
            //TaBortDubbletter.ForEach(siffra2 => Console.WriteLine(siffra2));
            //static List<int> MetodSomTarBortDubbletter(List<int> Heltal2)
            //{
            //    return Heltal2.Distinct().ToList();
            //}


            ////Uppgift: Skriv en metod som sorterar en lista med strängar baserat på deras längd (kortast till längst).
            ////Användmetoden Sort med en anpassad jämförelse.
            //List<string> OlikaLångaString = new List<string> { "hej", "Hejsan", "Tjenare", "Hello" };
            //List<string> SorteraBaseratPåLängd = MetodSomSorterarBaseratPåLängd(OlikaLångaString);
            //SorteraBaseratPåLängd.ForEach(sträng => Console.WriteLine(sträng));

            //static List<string> MetodSomSorterarBaseratPåLängd(List<string> OlikaLångaString)
            //{
            //    List<string> Sorterad = new List<string>(OlikaLångaString); // kopia
            //    Sorterad.Sort((KortareSträng, LängreSträng) => KortareSträng.Length.CompareTo(LängreSträng.Length));
            //    return Sorterad;
            //}

            ////Uppgift: Givet en lista med heltal, ta bort alla jämna tal med RemoveAll() och sortera sedan de återstående
            ////talen i stigande ordning med hjälp av LINQ.
            //List<int> Heltal = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> TaBortAllaHeltal = MetodSomTarBortAllaHeltal(Heltal);
            //TaBortAllaHeltal.ForEach(Tal => Console.WriteLine(Tal));

            //static List<int> MetodSomTarBortAllaHeltal(List<int> Heltal)
            //{
            //    List<int> SorteraTaBort = new List<int>(Heltal); //kopia
            //    SorteraTaBort.RemoveAll(Tal => Tal % 2 == 0);
            //    return SorteraTaBort.OrderBy(Tal => Tal).ToList();
            //}

            //Uppgift: Givet en lista med produkter(med egenskaperna Namn och Pris), skriv en LINQ - fråga
            //som filtrerar produkter med ett pris över 50 och sorterar dem i fallande ordning efter pris.

            //List<Produkt> Produkter = new List<Produkt>
            //{
            //    new Produkt { ProduktNamn = "Tangentbord", ProduktPris = 499 },
            //    new Produkt { ProduktNamn = "Penna", ProduktPris = 20 },
            //    new Produkt { ProduktNamn = "Mus", ProduktPris = 250 },
            //    new Produkt { ProduktNamn = "Suddgummi", ProduktPris = 10 },
            //    new Produkt { ProduktNamn = "Skärm", ProduktPris = 1500 }
            //};

            //var SorteraProdukter = Produkter
            //    .Where(ProdukterPris => ProdukterPris.ProduktPris > 50)
            //    .OrderByDescending(ProdukterPris => ProdukterPris.ProduktPris)
            //    .ToList();

            //SorteraProdukter.ForEach(ProdukterPris => Console.WriteLine($"{ProdukterPris.ProduktNamn}: {ProdukterPris.ProduktPris} kr"));


            //Givet en lista med studenter med egenskaperna Namn och Betyg, gruppera dem
            //efter betyg och räkna hur många studenter som finns i varje betyg.

            List<Studenter> ElevLista = new List<Studenter>
            {
                new Studenter { ElevNamn = "Tim", ElevBetyg = "A"},
                new Studenter { ElevNamn = "Nemo", ElevBetyg = "A"},
                new Studenter { ElevNamn = "Adam", ElevBetyg = "B"},
                new Studenter { ElevNamn = "Nils", ElevBetyg = "C"},
                new Studenter { ElevNamn = "Alex", ElevBetyg = "D"},
                new Studenter { ElevNamn = "Freja", ElevBetyg = "A"},
                new Studenter { ElevNamn = "Alvin", ElevBetyg = "F"},
                new Studenter { ElevNamn = "Isac", ElevBetyg = "D"},
                new Studenter { ElevNamn = "Hannes", ElevBetyg = "E"},
                new Studenter { ElevNamn = "Selma", ElevBetyg = "D"},
                new Studenter { ElevNamn = "Måns", ElevBetyg = "F"}

            };

            var SorteraElever = ElevLista
                .GroupBy(elev => elev.ElevBetyg[0])
                .OrderBy(grupp => grupp.Key);

            foreach (var BetygsGrupper in SorteraElever)
            {
                Console.WriteLine($"Betygen: {BetygsGrupper.Key}; {BetygsGrupper.Count()} studenter");
            }



        }
    }
 }
