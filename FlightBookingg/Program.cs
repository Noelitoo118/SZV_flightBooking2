namespace FlightBookingg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egyik teszt
           Flight flight = new Flight("asd", "asd", 11, 1);
           Flight flight1 = new Flight("asd", "asd", 11, 1);

            Console.WriteLine(flight.Describe());
           //másik teszt
        }
    }
}
