
namespace SearchAPI.ViewModel
{
    public class IndividualContractViewModel
    {
        public IndividualViewModel Individual { get; set; }
        public ContractViewModel Contract { get; set; }
    }

    public class IndividualViewModel
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
    }

    public class ContractViewModel
    {
        public int IndividualNationalId { get; set; }
        public string RoleOfCustomer { get; set; }
        public string PhaseOfContract { get; set; }
        public string OriginalAmountValue { get; set; }
        public string OriginalAmountCurrency { get; set; }
        public string InstallmentAmountValue { get; set; }
        public string InstallmentAmountCurrency { get; set; }
    }
}
