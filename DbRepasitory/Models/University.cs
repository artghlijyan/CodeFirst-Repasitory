using System;

namespace DbRepasitory.Models
{
    public class University
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public string Address { get; set; }

        public DateTime? DestroyDate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Phone Number: {PhoneNumber}, Address: {Address}, Closed Date: {DestroyDate}";
        }
    }
}
