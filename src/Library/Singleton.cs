using System;

namespace PII_Herencia
{

    /// <summary>
    /// Clase Singleton genérica para poder tener los Publisher como singleton sin hacer la implementación dentro de cada una de las clases
    /// De esta manera podemos tener una única instancia global de cada uno de los publishers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T: new()
    {
        private Singleton()
        {
        }

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }

                return instance;
            }
        }
    }
}
