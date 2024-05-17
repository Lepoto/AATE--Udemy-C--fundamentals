namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "RS3"),
                new Suzuki(200, "Red", "Swift GLX"),
            };

            foreach (var car in cars)
            {
                car.Repair();
                //car.ShowDetails();
            }

            Suzuki suzuki = new Suzuki(200, "white", "Celerio");

            suzuki.ShowDetails();

            // to use ShowDetails from base
            Car carb = (Car)suzuki;
            carb.ShowDetails();

            RS3 myrs3 = new RS3(200, "red", "RS3");

            myrs3.ShowDetails();

            Console.ReadKey();
        }
    }
}
