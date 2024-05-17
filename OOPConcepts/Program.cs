namespace OOPConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car mycar = new Car();
            //mycar.Name = "MyAudiA3"; // Set the name variable
            Console.WriteLine("Get name : {0}",mycar.Name);
            mycar.Horse = 100;

            mycar.Drive();
         
            mycar.CarDetail();

        }
    }
}
