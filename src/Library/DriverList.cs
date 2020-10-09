using System;
using System.Collections.Generic;

namespace PII_Herencia
{
    /// <summary>
    /// Clase con la responsabilidad de guardar y publicar a los conductores
    /// </summary>
    public class DriverList
    {
        private List<Driver> drivers = new List<Driver>();
        
        public DriverList()
        {

        }

        public List<Driver> DriversL
            {
                get
                {
                    return this.drivers;
                }
            }

        /// <summary>
        /// En este método recibimos un IPublisher para poder publicar de otras formas
        /// </summary>
        /// <param name="driv"></param>
        /// <param name="publisher"></param>
        public void RegisterDriver(Driver driv, IPublisher publisher)
        {
            if (!this.DriversL.Contains(driv))
            {
                this.drivers.Add(driv);
                publisher.PublishDriver(driv);
            }
        }
    }
}
        