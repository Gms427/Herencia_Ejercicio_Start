using System;
using TwitterUCU;

namespace PII_Herencia
{
    /// <summary>
    /// Clase encargada de brindar las operaciones necesarias para publicar pasajeros y conductores en Twitter
    /// </summary>
    public class DriverPublisher
    {
        public void Publish(Driver driver, IPublisher publisher)
        {
            publisher.PublishPerson(driver);
        }
    }
}