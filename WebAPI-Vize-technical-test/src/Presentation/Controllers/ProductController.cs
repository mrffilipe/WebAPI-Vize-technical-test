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

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ProductResponseDTO>> GetByIdAsync(Guid id)
        {
            try
            {
                var result = await _productAdapter.GetByIdAsync(id);
                return CreateResponse(result);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponseDTO>>> GetAllAsync()
        {
            try
            {
                var result = await _productAdapter.GetAllAsync();
                return CreateResponse(result);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProductResponseDTO>> AddAsync([FromBody] ProductCreateDTO productCreateDto)
        {
            try
            {
                if (productCreateDto == null)
                    return BadRequest(new { message = "Invalid data" });

                var result = await _productAdapter.AddAsync(productCreateDto);
                return CreatedAtAction(nameof(GetByIdAsync), new { id = result.Id }, result);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ProductResponseDTO>> UpdateAsync(Guid id, [FromBody] ProductUpdateDTO productUpdateDto)
        {
            try
            {
                if (productUpdateDto == null || id != productUpdateDto.Id)
                    return BadRequest(new { message = "Invalid data" });

                var result = await _productAdapter.UpdateAsync(productUpdateDto);
                return CreateResponse(result);
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            try
            {
                await _productAdapter.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }
        }
    }
}