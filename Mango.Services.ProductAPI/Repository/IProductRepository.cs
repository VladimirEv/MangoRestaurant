using Mango.Services.ProductAPI.Models.Dto;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();                       //получаем список всех товаров
        Task<ProductDto> GetProductById(int productId);                    //получаем ссылку на один из товаров
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);       //создаём или обновляем продукт
        Task<bool> DeleteProduct(int productId);                           //удаляем продукт
    }
}
