namespace eShop.Product.RestService.MappingProfiles;

using System.Collections.Generic;
using AutoMapper;
using eShop.Product.ApplicationLogic.ResponseMessages;
using eShop.Product.ApplicationLogic.UseCases.Models;
using eShop.Product.RestService.Responses.Models;
//using eShop.Product.RestService.Responses.Models;

/// <summary>
/// Automapper configuration for mapping between the application logic and the rest service models.
/// Automatically used by Automapper.
/// </summary>
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {

        //this.CreateMap<Types.IPledgeData, Contracts.IPledgeData>()
        //    .ConstructUsing(src => new Models.PledgeData());

        //this.CreateMap<ILoadPledgeDataResponseMessage, LoadPledgeDataResponse>()
        //    .ForMember(dest => dest.PledgeData, opt => opt.MapFrom(src => src.PledgeData));

        this.CreateMap<Types.IProduct, Contracts.IProduct>()
            .ConstructUsing(src => new Models.Product());

        this.CreateMap<IProductByIdResponseMsg, GetProductByIdResponse>()
            .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));


        //this.CreateMap<IProductByIdResponseMsg, eShop.Product.Contracts.Responses.I
        //ProductResponse>()
        //    .ConstructUsing(src => new GetProductsResponse());

        //this.CreateMap<IProductsResponseMsg, GetProductsResponse>();
        //this.CreateMap<eShop.Product.Contracts.IProduct, eShop.Product.Types.IProduct>();
        //this.CreateMap<IProductByIdResponseMsg, GetProductByIdResponse>()
        //     .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));
    }
}
