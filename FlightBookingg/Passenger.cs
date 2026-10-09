namespace FlightBookingg
{
    public class Passenger
    {
        private string _name;
        private int _age;
        private int _bagCount;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public int BagCount
        {
            get { return _bagCount; }
            set { _bagCount = value; }
        }

        public Passenger(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public bool AddBag()
        {
            if (_bagCount < 2)
            {
                _bagCount++;
                return true;
            }

            return false;
        }

        public bool IsChild()
        {
            return _age < 12;
        }
    }
}
