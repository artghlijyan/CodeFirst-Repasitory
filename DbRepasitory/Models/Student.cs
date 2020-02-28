namespace DbRepasitory.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Firstname: {FirstName}, Lastname: {LastName}, Age: {Age}";
        }
    }
}
