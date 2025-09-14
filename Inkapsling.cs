namespace objektorientering4
{
    public class Student
    {
        // Inkapsling metoden innebär att den döljer information inom en klass
        private string name;
        private string lastName;

        // Konstruktor – Man måste vara tydlig med vilka attribut man vill använda när man skapar ett objekt.

        public Student(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        // För att komma åt de dolda behöver vi använda oss av metoden som gör det offentligt (public)

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        // Jag tog hjälp av dina inspelningar för att få insparation.
    }
}
