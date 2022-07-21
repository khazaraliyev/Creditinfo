using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Xml;

namespace SearchAPI.Utilities
{
    public class XMLLoader
    {
        public static List<Individual> individuals;
        public static List<Contract> contracts;

        public XMLLoader()
        {
            individuals = new List<Individual>();
            contracts = new List<Contract>();
        }
        public List<Individual> LoadIndividualXML()
        {
            var doc = new XmlDocument();

            doc.Load(@"../individual.xml");

            foreach (XmlNode indv in doc.DocumentElement)
            {
                var user = new Individual()
                {
                    NationalId = int.Parse(indv.Attributes[0].Value),
                    Firstname = indv["firstname"].InnerText,
                    Lastname = indv["lastname"].InnerText,
                    DateOfBirth = indv["dateofbirth"].InnerText,
                    Gender = indv["gender"].InnerText,
                };
                individuals.Add(user);
            }

            return individuals;
        }

        public List<Contract> LoadContractXML()
        {
            var doc = new XmlDocument();

            doc.Load(@"../contract.xml");

            foreach (XmlNode ctr in doc.DocumentElement)
            {
                var contract = new Contract()
                {
                    IndividualNationalId = int.Parse(ctr.Attributes[0].Value),
                    RoleOfCustomer = ctr["roleOfCustomer"].InnerText,
                    PhaseOfContract = ctr["phaseOfContract"].InnerText,
                    OriginalAmountValue = ctr["originalAmount.currency"].InnerText,
                    OriginalAmountCurrency = ctr["installmentAmount.value"].InnerText,
                    InstallmentAmountValue = ctr["installmentAmount.value"].InnerText,
                    InstallmentAmountCurrency = ctr["installmentAmount.currency"].InnerText,
                };
                contracts.Add(contract);
            }

            return contracts;
        }
    }
}
