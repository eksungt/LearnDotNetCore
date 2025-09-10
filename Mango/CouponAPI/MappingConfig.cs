using AutoMapper;
using CouponAPI.Models;
using CouponAPI.Models.Dto;

namespace CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mapperCofing = new MapperConfiguration(config =>
            {
                config.CreateMap<couponDto, coupon>();
                config.CreateMap<coupon, couponDto>();

            });
            return mapperCofing;
            
        }
    }
}
