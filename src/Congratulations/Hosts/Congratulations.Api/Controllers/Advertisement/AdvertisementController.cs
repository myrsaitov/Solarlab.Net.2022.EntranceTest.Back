using Microsoft.AspNetCore.Mvc;
using Sev1.Congratulations.AppServices.Services.Congratulation.Interfaces;

namespace Sev1.Congratulations.Api.Controllers.Congratulation
{
    // Calls to this controller will only succeed
    // if the client provides Content-Type header of "application/json".
    // Otherwise a 415 (Unsupported Media Type) will be returned.
    //[Consumes("application/json")]

    // Attribute routing for REST APIs
    // https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-5.0
    [Route("api/v1/congratulations")]

    // The[ApiController] attribute can be applied to
    // a controller class to enable API-specific behaviors
    [ApiController]
    public partial class CongratulationController : ControllerBase
    {
        private readonly ICongratulationService _advertisementService;

        public CongratulationController(
            ICongratulationService advertisementService)
        { 
            _advertisementService = advertisementService;
        }
    }
}