namespace Uppgift_Vecka_3
{
    // Abstraktion
    public abstract class RidingLesson
    {
        public abstract void Time();
    }

    public class LessonAdult : RidingLesson
    {
        public override void Time()
        {
            Console.WriteLine("Evening");
        }
            
    }

}
