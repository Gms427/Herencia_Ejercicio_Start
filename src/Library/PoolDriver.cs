using System;
using System.Collections;

namespace PII_Herencia
{
    /// <summary>
    /// Clase que representa a los conductores pool, hereda de Driver que contiene información común para conductores
    /// </summary>
    class PoolDriver: Driver
    {
        private int capacity;
        public PoolDriver(string name, string surname, int ci, string image, string vehicle, int capacity, string biography, int driverCalification)
        : base(name, surname, ci, image, vehicle, biography, driverCalification)
        {
            this.Capacity=capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value>0)
                {
                    this.capacity = value;
                }
            }
        }
    }
}
        