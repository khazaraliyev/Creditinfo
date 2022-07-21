using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Individual
    {
        [Key]
        public int NationalId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }

        public Contract Contract { get; set; }
    }
}
