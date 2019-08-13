using AcutrackFulfillment.Core.OrderAggregate;
using AutoMapper;
using com.Acutrack.Fulfillment.WebAPI.Orders;

namespace AcutrackFulfillmentRWS
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<OrderItemCreateDto, OrderItem>()
                .ForMember(dest => dest.BomId,opt => opt.MapFrom(src => src.BomId))
                ;
            CreateMap<OrderCreateDto, Order>();
        }
    }
}