namespace PII_Herencia
{
    /// <summary>
    /// Interfaz para publicar a los conductores y pasajeros
    /// La idea de esta interfaz es poder tener varias implementaciones y asi permitir publicar en diferentes plataformas
    /// 
    /// Por ej:
    /// - TwitterPublisher: Publica en Twitter
    /// - FacebookPublisher: Publica en Facebook
    /// - etc
    /// 
    /// Con esa interfaz aplicamos polimorfismo, ya que sus métodos son implementados de diferente manera por sus subtipos, en nuestro caso tenemos
    /// solo uno que es el TwitterPublisher
    /// </summary>
    public interface IPublisher
    {
        void PublishDriver(Driver driver);
        void PublishPassenger(Passenger passenger);
    }
}