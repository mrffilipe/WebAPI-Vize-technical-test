using AutoMapper;
using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResponseDTO>()
                .ConstructUsing(s => new ProductResponseDTO(
                    s.Id,
                    s.Name,
                    s.Type,
                    s.UnitPrice,
                    s.CreatedAt,
                    s.UpdatedAt
                    ));

            CreateMap<ProductCreateDTO, Product>()
                .ConstructUsing(s => new Product(
                    s.Name,
                    s.Type,
                    s.UnitPrice
                    ));

            CreateMap<ProductUpdateDTO, Product>()
                .ConstructUsing(s => new Product(
                    s.Id,
                    s.Name,
                    s.Type,
                    s.UnitPrice,
                    s.CreatedAt,
                    s.UpdatedAt
                    ));
        }
    }
}