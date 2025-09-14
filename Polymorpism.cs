namespace Objektorientering1
{
    //polymorphism metod

    //virtual innebär huvudklass
    //override innebär subklass

    // här skapar vi en klass som heter Djur 

    public class Djur
    {
        public string name;
        
        public virtual void Ljud()
        {
            Console.WriteLine("Djuret låter");
        }


        // här skapar vi en subklass som heter Hund som ärver från Djur
        public class Hund : Djur
        {
            public override void Ljud()
            {
                Console.WriteLine("hunden skäller");
            }
        }
        // här skapar vi en subklass som heter Fågel som ärver från huvudklassen Djur
        public class Fågel : Djur
        {
            public override void Ljud()
            {
                Console.WriteLine("fågeln kvittrar");
            }
        }
        // En metod som kan visa ljud från olika djur
        // jag tog insparation från dina inspelningar då programmering är nytt för mig
    }

}
