using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    //baseklassen gøres abstract så denne ikke kan instancieres
    public abstract class Vehicle
    {
        //instansfelter. Protected så de kun kan kaldes af de afledte klasser
        protected string _licensePlate;
        protected DateTime _date;

        //properties
        public string LicensePlate
        {
            get { return _licensePlate; }
            set {
                if(value.Length > 7)
                {
                    throw new ArgumentException("License plate cannot be longer than 7 characters.");
                }
                _licensePlate = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        //constructor for Vehicle klassen. Protected så de kun kan kaldes af de afledte klasser. Benytter properties til at oprette en enstans af klassen.
        protected Vehicle(string licensePlate, DateTime date)
        {
            LicensePlate = licensePlate;
            Date = date;
        }

        //Abstrakte metoder til override i chileklasserne
        public abstract double Price();
        public abstract string VehicleType();
    }
}
