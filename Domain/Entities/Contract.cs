using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        public string RoleOfCustomer { get; set; }
        public string PhaseOfContract { get; set; }
        public string OriginalAmountValue { get; set; }
        public string OriginalAmountCurrency { get; set; }
        public string InstallmentAmountValue { get; set; }
        public string InstallmentAmountCurrency { get; set; }

        public int IndividualNationalId { get; set; }
        public Individual Individual { get; set; }
    }
}
