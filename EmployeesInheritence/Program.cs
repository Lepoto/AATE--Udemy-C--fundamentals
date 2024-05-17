namespace EmployeesInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee percy = new Employee("Percy", "Masekwameng", 15000);
            percy.Work();
            percy.Pause();

            Boss lepoto = new Boss("Lepoto", "Masekwameng", 50000, "Hyundai Grand i10");
            lepoto.Lead();

            Trainee alfred = new Trainee("Alfred", "Masekwameng", 50000, 32, 8);

            alfred.Learn();
            alfred.Work();

            Console.ReadKey();
        }
    }
}
