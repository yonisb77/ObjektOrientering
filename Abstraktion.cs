namespace Objektorientering
{

    //abstraktion
    //Vi skapar en abstrakt klass som heter Fordon som är väldigt simpel och enkel

    public abstract class Fordon
    {
        public abstract void Stanna();
    }

    //Här ärver sub klassen från Fordon klassen
    //override ersätter den abstrakta metoden
    public class Bil : Fordon 
    {
        public override void Stanna()
        {
         
         Console.WriteLine("Bilen stannar");
        }
        //Abstraktion metoden fokuserar och visar bara det som är viktigt
        // Jag tog ett väldigt enkelt exempes
    }
}
