
namespace laba2_1
{
    class Engine
    {
        private int _capacity;
        private int _power;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; }
        }
        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }
        public Engine()
        {
            _capacity = 5000;
            _power = 151121;
        }
        public Engine(int capacity, int power)
        {
            _capacity = capacity;
            _power = power;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
