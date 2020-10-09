using System;
using System.Collections.Generic;

namespace PII_Herencia
{
    /// <summary>
    /// Clase con la responsabilidad de guardar y publicar a los pasajeros
    /// </summary>
    public class PassengerList
    {
        private List<Passenger> passengers = new List<Passenger>();

        public PassengerList()
        {

        }
        public List<Passenger> PassengersL
        {
            get
            {
                return this.passengers;
            }
        }

        /// <summary>
        /// En este método recibimos un IPublisher para poder publicar de otras formas
        /// </summary>
        /// <param name="driv"></param>
        /// <param name="publisher"></param>
        public void RegisterPassenger(Passenger pass, IPublisher publisher)
        {
            if (!this.PassengersL.Contains(pass))
            {
                this.passengers.Add(pass);
                publisher.PublishPassenger(pass);
            }
        }
    }
}