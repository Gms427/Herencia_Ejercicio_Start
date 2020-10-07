namespace Library
{
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