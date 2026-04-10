using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Application.DTOs;
using SMS.Application.IServices;

namespace SMS.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStores()
        {
            try
            {
                var stores = await _storeService.GetAllStores();
                if (stores == null)
                {
                    return NotFound();
                }
                return Ok(stores);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{storeId}")]
        public async Task<IActionResult> GetStoreById(int storeId)
        {
            try
            {
                var store = await _storeService.GetStoreById(storeId);
                if (store == null)
                {
                    return NotFound();
                }
                return Ok(store);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateStore([FromBody] CreateStoreDto createStoreDto)
        {
            try
            {
                if (createStoreDto == null)
                {
                    return BadRequest();
                }
                var result = await _storeService.AddStore(createStoreDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStore([FromBody] UpdateStoreDto updateStoreDto)
        {
            try
            {
                if (updateStoreDto == null)
                {
                    return BadRequest();
                }
                var result = await _storeService.UpdateStore(updateStoreDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{storeId}")]
        public async Task<IActionResult> DeleteStore(int storeId)
        {
            try
            {
                await _storeService.DeleteStore(storeId);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
