using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using $projectname$.Application.Domain.Queries.SampleQuery.V1;

namespace $projectname$.Presentation.Rest.Api.Controllers
{
    [ApiController]
    [Route("api")]
    public class Controller : ControllerBase
    {
        private readonly IMediator _mediator;

        public Controller(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> SampleGet()
        {
            var result = await _mediator.Send(new SampleQueryV1());
            return Ok(result);
        }
    }
}