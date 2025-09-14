namespace Objektorientering1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Djur djur1 = new Djur();
              djur1.Ljud();

             Djur hund1 = new Djur.Hund();
                hund1.Ljud();

                Djur fågel1 = new Djur.Fågel();
                fågel1.Ljud();
        }
    }
}
