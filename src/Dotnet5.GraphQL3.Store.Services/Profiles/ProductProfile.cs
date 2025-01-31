using AutoMapper;
using Dotnet5.GraphQL3.Store.Domain.Entities.Products.Backpacks;
using Dotnet5.GraphQL3.Store.Domain.Entities.Products.Boots;
using Dotnet5.GraphQL3.Store.Domain.Entities.Products.Kayaks;
using Dotnet5.GraphQL3.Store.Services.Models.Products;
using Dotnet5.GraphQL3.Store.Services.Profiles.Converters;

namespace Dotnet5.GraphQL3.Store.Services.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<KayakModel, Kayak>()
                .ConvertUsing<KayakModelToDomainConverter>();

            CreateMap<BootModel, Boot>()
                .ConvertUsing<BootModelToDomainConverter>();

            CreateMap<BackpackModel, Backpack>()
                .ConvertUsing<BackpackModelToDomainConverter>();
        }
    }
}