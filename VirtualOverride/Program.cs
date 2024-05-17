namespace VirtualOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Jerry", 15);

            Console.WriteLine("{0} is {1} years old.", dog.Name, dog.Age);

            dog.Play();
            dog.MakeSound();
            dog.Eat();
        }
    }
}
