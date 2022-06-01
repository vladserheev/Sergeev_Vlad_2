using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    internal class BusPark
    {
        public Bus[] busses;

        public BusPark(Bus[] busses)
        {
            this.busses = busses;
        }

        public int GetBussesNum()
        {
            return busses.Length;
        }

        public void SortBussesBySeatsNum()
        {
            var a = busses.OrderBy(x => x._seats_num).ToArray();
            busses = a;
            foreach (Bus bus in busses)
            {
                bus.Show();
            }
        }

        public void ShowAllBusses()
        {
            foreach (Bus bus in busses)
            {
                bus.Show();
            }
        }

        public Bus GetBusByPlate(string license_plate)
        {
            foreach (Bus bus in busses)
            {
                if (bus._license_plate == license_plate)
                {
                    return bus;
                }
            }
            return null;
        }
        public Bus GetBusByFuelParameter(int fuel_parameter)
        {
            foreach (Bus bus in busses)
            {
                if (bus._fuel_parameter == fuel_parameter)
                {
                    return bus;
                }
            }
            return null;
        }
    }
}
