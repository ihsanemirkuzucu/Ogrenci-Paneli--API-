using System;

namespace StudentManagement.DomainModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAdress { get; set; }
        public string PostalAdress { get; set; }
        public Guid StudentId { get; set; }
    }
}
