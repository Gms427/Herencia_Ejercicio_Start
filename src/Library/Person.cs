namespace PII_Herencia
{

    /// <summary>
    /// Clase padre de los conductores y los pasajeros, contiene la info común entre esas sub-entidades
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CI { get; }
        public string Image { get; set; }
        public Person (string name, string surname, int ci, string image)
        {
            this.Name = name;
            this.Surname  = surname;
            this.CI = ci;
            this.Image = image;
        }
    }
}