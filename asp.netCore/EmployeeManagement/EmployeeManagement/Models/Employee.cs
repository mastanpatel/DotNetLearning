using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string? EncryptedId { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public Dept? Department { get; set; }
        public string? PhotoPath { get; set; }
    }
}
