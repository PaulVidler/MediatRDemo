using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    public class PersonController : Controller
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        [Route("GetPeople")]
        public async Task<List<PersonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        [HttpGet]
        [Route("GetPeople{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }


        [HttpPost]
        [Route("CreatePeople")]
        public async Task<PersonModel> Post([FromBody] PersonModel value)
        {
            var model = new InsertPersonCommand(value.FirstName, value.LastName);
            return await _mediator.Send(model);
        }

    }
}
