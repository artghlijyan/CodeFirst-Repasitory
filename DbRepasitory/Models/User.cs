namespace DbRepasitory.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"UserId - {UserId}, Name - {Name}, Age - {Age}";
        }
    }
}
