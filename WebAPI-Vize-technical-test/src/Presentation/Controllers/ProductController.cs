using Microsoft.AspNetCore.Mvc;
using WebAPI_Vize_technical_test.src.Application;

namespace WebAPI_Vize_technical_test.src.Presentation
{
    public class ProductController : BaseController
    {
        private readonly IProductAdapter _productAdapter;

        public ProductController(IProductAdapter productAdapter)
        {
            _productAdapter = productAdapter;
        }

        [HttpGet]
        [Route("get-by-id")]
        public async Task<ActionResult<ProductResponseDTO>> GetByIdAsync([FromQuery] Guid id)
        {
            return Ok(await _productAdapter.GetByIdAsync(id));
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<ActionResult<IEnumerable<ProductResponseDTO>>> GetAllAsync()
        {
            return Ok(await _productAdapter.GetAllAsync());
        }

        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<ProductResponseDTO>> AddAsync([FromBody] ProductCreateDTO product)
        {
            return Ok(await _productAdapter.AddAsync(product));
        }

        [HttpPut]
        [Route("update")]
        public async Task<ActionResult<ProductResponseDTO>> UpdateAsync([FromBody] ProductUpdateDTO product)
        {
            return Ok(await _productAdapter.UpdateAsync(product));
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult> DeleteAsync([FromQuery] Guid id)
        {
            await _productAdapter.DeleteAsync(id);

            return NoContent();
        }
    }
}