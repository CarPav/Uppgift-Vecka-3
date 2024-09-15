namespace Uppgift_Vecka_3
{

    public class Stable
    {
        //detta är ett privat attribut som skall skyddas
        private string adress;

        // Konstruktör
        public Stable(string adress)
        {
            Adress = adress;
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

    }
}
