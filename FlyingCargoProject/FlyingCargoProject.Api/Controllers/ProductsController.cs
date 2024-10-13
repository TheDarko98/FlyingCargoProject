using AutoMapper;
using FlyingCargoProject.Api.DTOs;
using FlyingCargoProject.Api.Repositories;
using FlyingCargoProject.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ProductsController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    // Get all products
    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _unitOfWork.Products.GetProductsAsync();
        var productDTOs = _mapper.Map<IEnumerable<ProductDTO>>(products);
        return Ok(productDTOs);
    }

    // Get product by ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        var product = await _unitOfWork.Products.GetProductByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        var productDTO = _mapper.Map<ProductDetailsDTO>(product);
        return Ok(productDTO);
    }

    // Add a new product
    [HttpPost]
    public async Task<IActionResult> AddProduct(ProductDTO productDTO)
    {
        var product = _mapper.Map<Product>(productDTO);
        await _unitOfWork.Products.AddProductAsync(product);
        return Ok();
    }

    // Update an existing product(not sure if this functionality is actually needed
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, ProductUpdateDTO productDTO)
    {
        var product = await _unitOfWork.Products.GetProductByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        _mapper.Map(productDTO, product);
        await _unitOfWork.Products.UpdateProductAsync(product);
        return Ok();
    }

    // Delete a product
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var product = await _unitOfWork.Products.GetProductByIdAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        await _unitOfWork.Products.DeleteProductAsync(id);
        return Ok();
    }
}