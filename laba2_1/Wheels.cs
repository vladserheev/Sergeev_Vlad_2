
namespace laba2_1
{
    internal class Wheels
    {
        private int _diameter;
        private string _model;

        public int Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Wheels(int diameter, string model)
        {
            _diameter = diameter;
            _model = model;
        }

        public Wheels()
        {
            _diameter = 68;
            _model = "Michelin";
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
