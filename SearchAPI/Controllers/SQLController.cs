using Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchAPI.Mappers;
using SearchAPI.ViewModel;

namespace SearchAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SQLController : ControllerBase
    {
        private readonly IIndividualRepository individualRepository;
        private readonly IContractRepository contractRepository;

        public SQLController(IIndividualRepository individualRepository, IContractRepository contractRepository)
        {
            this.individualRepository = individualRepository;
            this.contractRepository = contractRepository;
        }

        [HttpPost]
        [Route("individual")]
        public IActionResult AddIndividual([FromBody] IndividualViewModel model)
        {
            individualRepository.Add(model.ToDB());

            return Ok(model);
        }


        [HttpPost]
        [Route("contract")]
        public IActionResult AddContract([FromBody] ContractViewModel model)
        {
            var individual = individualRepository.GetById(model.IndividualNationalId);

            if (individual == null)
            {
                return NotFound($"Individual with id:{model.IndividualNationalId} does not exist");
            }

            contractRepository.Add(model.ToDB());

            return Ok(model);
        }
    }
}
