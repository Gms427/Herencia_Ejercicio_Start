using System;
using System.Collections.Generic;

namespace PII_Herencia
{
    class DriverList: Driver
    {
       private List<Driver> drivers; 
        public DriverList(List<Driver> drivers)
        {
            this.DriversL=drivers;
        }
        public List<Driver> DriversL
            {
                get
                {
                    return this.drivers;
                }
                set
                {
                    foreach(Driver d in value)
                    {
                        RegisterDriver(d);
                    }
                }
            }
        public void RegisterDriver(Driver driv)
        {
            if (!this.DriversL.Contains(driv))
            {
                this.drivers.Add(driv);
                TwitterPublisher.instance.PublishDriver(driv);
            }
        }
    }
}
        