namespace PII_Herencia
{
    public class Driver : Person
    {
        public int DriverCalification { get; set; }
        public string Biography { get; set; }
        public string Vehicle { get; set; }
        public Driver (string name, string surname, int ci, string image, string vehicle)
        : base(name,surname,ci,image)
        {
            this.Vehicle = vehicle;
        }
    }
}