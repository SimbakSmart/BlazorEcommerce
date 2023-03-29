namespace BlazorEcommerce.Server.Services.ProductService.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
