namespace Uppgift_Vecka_3
{
    // Polymorphism exempel

    public class Rider
    {
        public string Name;

        public int Age;

        public virtual void StartLesson()
        {
            Console.WriteLine("This rider takes riding lessons");
        }
    }

    public class Owner : Rider
    {
        public override void StartLesson()
        {
            Console.WriteLine("This person owns the horse");
        }
    }

    public class Caretaker : Rider
    {

        public override void StartLesson()
        {
            Console.WriteLine("This person does not ride the horse");
        }
    }
}
