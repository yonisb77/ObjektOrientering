namespace objektorientering3
{

    //Arv Metoden
    //Här skapar jag en klass som heter Vehicle
    //Här ska man visa hur man kan ärva från en klass

    public class Vehicle
        {
            public string Name;

        // Attributer - Egenskaper
        public void Kör()
            {
                Console.WriteLine("bilen kör");
            }
            public void Bromsa()
            {
                Console.WriteLine("bilen bromsar");
            }

        }

    //Car ärver från Vehicle som är basklassen
    public class Car : Vehicle
    {
            public new void Starta()
            {
                Console.WriteLine("bilen startar inte");
            }

        }

    // Detta är nytt för mig så jag kollade på dina inspelningar och tog hjälp.
}

