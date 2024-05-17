namespace GenericsT1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Logger loggw = new Logger();
            loggw.Log<string>("Good Day");

            loggw.Log<int>(200);

            loggw.Log(new {Name="John"});


            // Multiple Generic types of a class
            /*TableBox<int, string> boxTable = new TableBox<int, string>(100, "One hundred");

            boxTable.Display();*/


            /*Box<string> box = new Box<string>("Hi, Alfred");

            box.UpdateContent("Hi, there Alfred");

            Console.WriteLine(box.GetContent());*/
        }
    }
}
