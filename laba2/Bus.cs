using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    internal class Bus
    {
        public int _seats_num;
        public string _license_plate; // номерний знак
        public int _fuel_parameter; // споживання палива
        public string _model;

        public Bus(string model, string license_plate, int seats_num, int fuel_parameter)
        {
            _model = model;
            _license_plate = license_plate;
            _seats_num = seats_num;
            _fuel_parameter = fuel_parameter;
        }

        public void Show()
        {
            Console.WriteLine(String.Format("|{0,5}|{1,-8}|{2,-3}|{3,-3}|", _license_plate, _model, _seats_num, _fuel_parameter));
        }
        public int Compare(Bus x, Bus y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x == null)
            {
                return -1;
            }

            if (y == null)
            {
                return 1;
            }

            return x._seats_num.CompareTo(y._seats_num);
        }
    }
}
