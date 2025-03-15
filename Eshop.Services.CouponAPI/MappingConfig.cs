using AutoMapper;
using Eshop.Services.CouponAPI.Models;
using Eshop.Services.CouponAPI.Models.Dto;

namespace Eshop.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration MapRegister()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Coupon, CouponDto>();
                config.CreateMap<CouponDto, Coupon>();
            });
            return mappingConfig;
        }
    }
}
