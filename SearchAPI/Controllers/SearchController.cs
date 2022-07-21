using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SearchAPI.Mappers;
using SearchAPI.Utilities;
using SearchAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly XMLLoader xML;

        public SearchController(XMLLoader xML)
        {
            this.xML = xML;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Search(int id)
        {
            var individuals = xML.LoadIndividualXML();

            var individual = individuals.Where(i => i.NationalId == id).FirstOrDefault();

            if (individual is null)
            {
                return NotFound($"Could not find individual with id: {id}");
            }


            return Ok(new IndividualViewModel()
            {
                Firstname = individual.Firstname,
                Lastname = individual.Lastname,
                DateOfBirth = individual.DateOfBirth,
                Gender = individual.Gender,
            });
        }

        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult Details(int id)
        {
            var individuals = xML.LoadIndividualXML();
            var contracts = xML.LoadContractXML();

            var individual = individuals.Where(i => i.NationalId == id).FirstOrDefault();


            if (individual is null)
            {
                return NotFound($"Could not find individual with id: {id}");
            }

            var contract = contracts.Where(c => c.IndividualNationalId == id).FirstOrDefault();
            if (contract is null)
            {
                return NotFound("Could not find contract");
            }



            return Ok(Mapper.IndividualContarctToView(individual, contract));
        }

    }
}
