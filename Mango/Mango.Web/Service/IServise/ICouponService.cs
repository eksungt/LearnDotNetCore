using Mango.Web.Models;

namespace Mango.Web.Service.IServise
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string couponCode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponByIdAsync(int id);
        Task<ResponseDto?> CreateCouponsAsync(couponDto couponDto);
        Task<ResponseDto?> UpdateCouponsAsync(couponDto couponDto);
        Task<ResponseDto?> DeleteCouponsAsync(int id);
        Task<ResponseDto?> GetAllCoupondAsync();
    }
}
