namespace objektorientering3
{
    public class vehicle
    {
        static void Main(string[] args)
        {
           Vehicle vehicle = new Vehicle();
              vehicle.Kör();

            Car car = new Car();
            car.Bromsa();

            Car car2 = new Car();
            car2.Starta();


        }
    }
}
