namespace Uppgift_Vecka_3
{
    // Exempel för arv

    public class Horse
    {
        // Attribut
        public string Breed;

        public string Discipline;

        // Metoder
        public void Saddle()
        {
            Console.WriteLine("This horse can be ridden");
        }
        public void Wagon()
        {
            Console.WriteLine("This horse can pull a wagon");
        }
    }

    public class Foal : Horse
    {
        // Attribut för ny klass som också ärver från House
        public int Age;

        // Metoder för ny klass som också ärver från House
        public new void Saddle()
        {
            Console.WriteLine("This foal is too young to be ridden");
        }
    }
}
