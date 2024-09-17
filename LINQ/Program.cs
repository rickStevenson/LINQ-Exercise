namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listOfGames = new List<string> {"Donkey Kong", "Mario Bros", "Space Invaders", "Galaga", "Dig Dug" };

            var orderedNames = listOfGames
                .OrderBy(name => name.Length)
                .ToList();

            
            foreach (var name in orderedNames)
            {
                Console.WriteLine($"{name} - {name.Length} characters");
            }
        }
    }
}
