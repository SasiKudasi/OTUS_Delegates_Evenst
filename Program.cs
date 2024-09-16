using OTUS_Delegates_Evenst.Events;
using OTUS_Delegates_Evenst.Extention;

namespace OTUS_Delegates_Evenst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ratings = new List<Rating> { 
               new Rating {Name = "Alex", RatingCount = 1},
               new Rating {Name = "Asadasdas", RatingCount = 10},
               new Rating {Name = "Martin", RatingCount = 5},
               new Rating {Name = "Hunter", RatingCount = 17},
               new Rating {Name = "Kent", RatingCount = 11},
            };
            var biggestRating = ratings.GetMax(r => r.RatingCount);
            Console.WriteLine($"{biggestRating.Name} has the highest rating  {biggestRating.RatingCount}\n\n");


            string dir = Directory.GetCurrentDirectory();
            CancellationTokenSource cts = new CancellationTokenSource();

            FileSearcher searcher = new FileSearcher();

            searcher.FileFound += (sender, e) =>
            {
                Console.WriteLine($"File found: {e.FileName}");
                if (e.FileName.Length > 15)
                {
                   cts.Cancel();    
                }
            };
            searcher.Search(dir, cts.Token);
            Console.ReadLine();

        }


    }
}
