namespace PII_Herencia
{
    /// <summary>
    /// Clase que representa a los conductores, hereda de person que contiene información común tanto para conductores como pasajeros
    /// </summary>
    public class Driver : Person
    {
        public int DriverCalification { get; set; }
        public string Biography { get; set; }
        public string Vehicle { get; set; }
        public Driver (string name, string surname, int ci, string image, string vehicle, string biography, int driverCalification)
        : base(name,surname,ci,image)
        {
            this.Vehicle = vehicle;
            this.Biography = biography;
            this.DriverCalification = driverCalification;
        }
    }
}