namespace Eshop.Services.CouponAPI.Models
{
    public class ResponseDto
    {
        public object? result { get; set; }

        public bool isSuccessful { get; set; } = true;

        public string errorMessage { get; set; } = string.Empty;

    }
}
