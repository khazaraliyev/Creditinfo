using Domain.Entities;
using SearchAPI.ViewModel;

namespace SearchAPI.Mappers
{
    public static class Mapper
    {

        public static Individual ToDB(this IndividualViewModel individualviewmodel)
        {
            return new Individual()
            {
                Firstname = individualviewmodel.Firstname,
                Lastname = individualviewmodel.Lastname,
                DateOfBirth = individualviewmodel.DateOfBirth,
                Gender = individualviewmodel.Gender
            };
        }

        public static IndividualViewModel ToView(this Individual individual)
        {

            return new IndividualViewModel()
            {
                Firstname = individual.Firstname,
                Lastname = individual.Lastname,
                DateOfBirth = individual.DateOfBirth,
                Gender = individual.Gender
            };
        }

        public static Contract ToDB(this ContractViewModel viewmodel)
        {

            return new Contract()
            {
                RoleOfCustomer = viewmodel.RoleOfCustomer,
                PhaseOfContract = viewmodel.PhaseOfContract,
                OriginalAmountValue = viewmodel.OriginalAmountValue,
                OriginalAmountCurrency = viewmodel.OriginalAmountCurrency,
                InstallmentAmountValue = viewmodel.InstallmentAmountValue,
                InstallmentAmountCurrency = viewmodel.InstallmentAmountCurrency,
                IndividualNationalId = viewmodel.IndividualNationalId,
            };
        }

        public static ContractViewModel ToView(this Contract contract)
        {

            return new ContractViewModel()
            {
                RoleOfCustomer = contract.RoleOfCustomer,
                PhaseOfContract = contract.PhaseOfContract,
                OriginalAmountValue = contract.OriginalAmountValue,
                OriginalAmountCurrency = contract.OriginalAmountCurrency,
                InstallmentAmountValue = contract.InstallmentAmountValue,
                InstallmentAmountCurrency = contract.InstallmentAmountCurrency,
                IndividualNationalId = contract.IndividualNationalId,
            };
        }

        public static IndividualContractViewModel IndividualContarctToView(Individual individual, Contract contract)
        {
            var model = new IndividualContractViewModel()
            {
                Individual = new IndividualViewModel()
                {
                    Firstname = individual.Firstname,
                    Lastname = individual.Lastname,
                    DateOfBirth = individual.DateOfBirth,
                    Gender = individual.Gender,
                },
                Contract = new ContractViewModel()
                {
                    RoleOfCustomer = contract.RoleOfCustomer,
                    PhaseOfContract = contract.PhaseOfContract,
                    OriginalAmountValue = contract.OriginalAmountValue,
                    OriginalAmountCurrency = contract.OriginalAmountCurrency,
                    InstallmentAmountValue = contract.InstallmentAmountValue,
                    InstallmentAmountCurrency = contract.InstallmentAmountCurrency,
                }
            };

            return model;
        }

    }
}
