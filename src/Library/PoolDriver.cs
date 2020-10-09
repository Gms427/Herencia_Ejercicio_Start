using System;
using System.Collections;

namespace PII_Herencia
{
    class PoolDriver: Driver
    {
        private int capacity;
        public PoolDriver(int capacity)
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
        