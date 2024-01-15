using Estoque.Domain.Dtos.Address;
using Estoque.Domain.Interfaces.Service;
using Estoque.Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpGet("{cep}")]
        public async Task<ActionResult<ResponseViewModel<AddressResponseDto>>> GetAddresByCep(string cep)
        {
            try
            {
                return Ok(new ResponseViewModel<AddressResponseDto>(true, null, await _service.GetAddress(cep)));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseViewModel(false, ex.Message, null));
            }
        }
    }
}