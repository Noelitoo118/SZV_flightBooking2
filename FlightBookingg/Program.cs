namespace FlightBookingg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //egyik teszt

            //másik teszt

            Passenger passenger1 = new Passenger("young John Doe", 7);
            Passenger passenger2 = new Passenger("adoult John Doe", 26);

            if (passenger2.AddBag()) Console.WriteLine("sikeres a poggyász hozzáadása");
            else Console.WriteLine("a poggyász hozzáadása nem volt sikeres");

            if (passenger2.AddBag()) Console.WriteLine("sikeres a poggyász hozzáadása");
            else Console.WriteLine("a poggyász hozzáadása nem volt sikeres");

            if (passenger2.AddBag()) Console.WriteLine("sikeres a poggyász hozzáadása");
            else Console.WriteLine("a poggyász hozzáadása nem volt sikeres");

            Console.WriteLine($"{passenger1.Name}, {passenger1.BagCount} db poggyász, {passenger1.Age} éves és {passenger1.IsChild()} gyerek");
            Console.WriteLine($"{passenger2.Name}, {passenger2.BagCount} db poggyász, {passenger2.Age} éves és {passenger2.IsChild()} gyerek");

           Flight flight = new Flight("asd", "asd", 11, 1);
           Flight flight1 = new Flight("asd", "asd", 11, 1);

            Console.WriteLine(flight.Describe());
           //másik teszt
        }
    }
}
