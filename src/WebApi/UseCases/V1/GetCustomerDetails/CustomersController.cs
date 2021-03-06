namespace WebApi.UseCases.V1.GetCustomerDetails
{
    using System.Threading.Tasks;
    using Application.Boundaries.GetCustomerDetails;
    using FluentMediator;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public sealed class CustomersController : ControllerBase
    {
        /// <summary>
        ///     Get the Customer details.
        /// </summary>
        /// <returns>An asynchronous <see cref="IActionResult" />.</returns>
        [HttpGet(Name = "GetCustomer")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetCustomerDetailsResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCustomer(
            [FromServices] IMediator mediator,
            [FromServices] GetCustomerDetailsPresenter presenter)
        {
            var input = new GetCustomerDetailsInput();
            await mediator.PublishAsync(input);
            return presenter.ViewModel;
        }
    }
}
