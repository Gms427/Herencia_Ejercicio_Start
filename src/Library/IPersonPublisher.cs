namespace PII_Herencia
{
    /// <summary>
    /// Interfaz para publicar a las personas
    /// La idea de esta interfaz es poder tener varias implementaciones y asi permitir publicar diferentes personas
    /// 
    /// Por ej:
    /// - DriverPublisher: Publica conductores
    /// - PassengerPublisher: Publica en pasajeros
    /// - etc
    /// 
    /// Con esa interfaz aplicamos polimorfismo, ya que sus métodos son implementados de diferente manera por sus subtipos.
    /// </summary>
    public interface IPersonPublisher
    {
        void PublishPerson(Person person, IPublisher publisher);
    }
}