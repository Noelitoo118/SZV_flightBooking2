using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingg
{
    public class Flight
    {
        private string _code;
        private string _destination;
        private int _basePrice;
        private int _freeseats;

        public string Code { get { return _code; } set { _code = value; } }
        public string Destination { get { return _destination; } set { _destination = value; } }
        public int BasePrice { get { return _basePrice; } set { _basePrice = value; } }
        public int FreeSeats { get { return _freeseats; } set { _freeseats = value; } }

        public Flight(string code, string destination, int basePrice, int freeSeats)
        {
            _code = code;
            _destination = destination;
            _basePrice = basePrice;
            _freeseats = freeSeats;
        }
        public bool BookSeat()
        {
            if (_freeseats >= 1)
            {
                _freeseats -= 1;
                return true;
            }
            return false;
        }
        public string Describe()
        {
            if (_freeseats <= 1)
            {
                return "telt ház";
            }
            else
            {
                return $"{Code}:{Destination}:{BasePrice}:{_freeseats}";
            }
        }

    }
}

