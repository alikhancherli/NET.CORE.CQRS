using AppService.Cqrs.Api.Commands.User;
using AppService.Cqrs.Api.Queries.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Cqrs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(string name,string family,string nationalCode)
        {
            var command = new AddUserCommand(name, family, nationalCode);
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("user/list")]
        public async Task<IActionResult> GetUserList()
        {
            var response = await _mediator.Send(new GetUserListQuery());
            return Ok(response);
        }
    }
}
