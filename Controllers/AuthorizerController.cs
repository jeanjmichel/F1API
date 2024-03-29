﻿using F1API.DTOs;
using F1API.Responses;
using F1API.Services;
using Microsoft.AspNetCore.Mvc;

namespace F1API.Controllers
{
    [Route("f1api/v1/authorizations")]
    [ApiController]
    public class AuthorizerController : ControllerBase
    {
        private readonly IAuthorizerService _authorizerService;

        /// <summary>
        /// This method generate a JWT Token if the credentials is correct.
        /// </summary>
        /// <param name="user">A DTO containing the username and password to authenticate to the API.</param>
        /// <returns>A JWT Token.</returns>
        /// <response code="200">Sucess.</response>
        /// <response code="401">Unauthorized.</response>
        [HttpPost("authorize", Name = "authorize")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Authorize(UserDTO user)
        {
            APIResultData res = new APIResultData();

            string generatedToken = _authorizerService.GenerateToken(user);

            if(! String.IsNullOrEmpty(generatedToken))
            {
                res.ReturnedData = generatedToken;
                res.StatusCode = 200;
                res.StatusMessage = "Authorization completed, the token was generated.";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";
                return Ok(res);
            }
            else 
            {
                res.ReturnedData = null;
                res.StatusCode = 401;
                res.StatusMessage = "Authorization fail. User or password is incorrect.";
                res.Metadata = "Returned by F1 API, a free API for fans of Formula One!";

                return Unauthorized(res);
            }
            
        }
        
        public AuthorizerController(IAuthorizerService authorizerService)
        {
            _authorizerService = authorizerService;
        }
    }
}
