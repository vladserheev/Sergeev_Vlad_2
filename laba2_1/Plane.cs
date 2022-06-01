

namespace laba2_1
{
    internal class Plane
    {
        private string _model;
        private string _color;
        private string _name;
        private string _route;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Plane()
        {
            _model = "Boing";
            _color = "Red";
        }

        public Plane(Wheels wheels, Wing wing, Engine engine, string model, string color, string name)
        {
            _model = model;
            _color = color;
            _name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"Літак {_model} {_name} летить за маршрутом {_route}");
        }
        public void CreateRoute(string startPoint, string finishPoint)
        {
            string route = startPoint + " --> " + finishPoint;
            Console.WriteLine("Маршрут створено!");
            _route = route;
        }

        public void ShowRoute()
        {
            Console.WriteLine($"Маршрут: {_route}");
        }

        public override string ToString()
        {
            return $"{_model}{_name}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
