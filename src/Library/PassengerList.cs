using System;
using System.Collections.Generic;

namespace PII_Herencia
{
    class PassengerList: Passenger
    {
       private List<Passenger> passengers; 
        public PassengerList(List<Passenger> passengers)
        {
            this.PassengersL=passengers;
        }
        public List<Passenger> PassengersL
            {
                get
                {
                    return this.passengers;
                }
                set
                {
                    foreach(Passenger p in value)
                    {
                        RegisterPassenger(p);
                    }
                }
            }
        public void RegisterPassenger()
        {
            foreach(Passenger pass in this.PassengersL)
                {
                    if (!this.PassengersL.Contains(pass))
                    {
                        this.passengers.Add(pass);
                        TwitterPublisher.instance.PublishPassenger(pass);
                    }
                }
        }
    }
}