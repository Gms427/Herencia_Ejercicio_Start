using System;
using System.Collections.Generic;

namespace PII_Herencia
{
    /// <summary>
    /// clase que representa a los pasajeros, hereda de person que contiene información común tanto para conductores como pasajeros
    /// </summary>
    public class Passenger: Person
    {
        public int PassengerCalification { get; set; }

        public Passenger (string name, string surname, int ci, string image, int passengerCalification)
        : base(name,surname,ci,image)
        {
            this.PassengerCalification = passengerCalification;
        }
    }
}