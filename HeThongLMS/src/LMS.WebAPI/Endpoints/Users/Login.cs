using System.Threading;
using Ardalis.ApiEndpoints;
using LMS.Core.Entities;
using LMS.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using LMS.Core.Interfaces;
using LMS.WebAPI.ApiModels;

namespace LMS.WebAPI.Endpoints.Users
{
    public class Login : BaseAsyncEndpoint<LoginRequest, UserResponse>
    {
        private readonly IUserServices _userservice;

        public Login(IUserServices userService)
        {
            _userservice = userService;
        }

        [HttpPost("/Login")]
        [SwaggerOperation(
            Summary = "Login with authentication",
            Description = "Login with authentication",
            OperationId = "User.Login",
            Tags = new[] { "UserEndpoints" })
        ]
        public override async Task<ActionResult<UserResponse>> HandleAsync([FromForm] LoginRequest loginRequest, CancellationToken cancellationToken)
        {
            var user = await _userservice.Login(loginRequest.Email, loginRequest.Password);

            if (user != null)
            {
                var token = await _userservice.GenerateJSONWebToken(user, HttpContext);
                return Ok(token);
            }

            return Unauthorized();
        }
    }
}
