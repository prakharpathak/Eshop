using AutoMapper;
using Eshop.Services.CouponAPI.Data;
using Eshop.Services.CouponAPI.Models;
using Eshop.Services.CouponAPI.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;

namespace Eshop.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;

        private ResponseDto _responseDto;

        private IMapper _mapper;

        public CouponAPIController(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _responseDto = new ResponseDto();
        }

        [HttpGet]
        public IActionResult GetAll() 
        {

            try
            {
                  IEnumerable<Coupon> couponslist=_dbContext.Coupons.ToList();
                  _responseDto.result = _mapper.Map<IEnumerable<CouponDto>>(couponslist);
                  return Ok(_responseDto);
            }
            catch (Exception ex)
            {
                _responseDto.errorMessage = ex.Message;
                _responseDto.isSuccessful = false;
                Console.WriteLine(ex.Message);
                return NotFound(_responseDto);
            }

        }

        [HttpGet]
        [Route("id")]
        public IActionResult GetById(int id)
        {

            try
            {
                Coupon coupon = _dbContext.Coupons.First(u=>u.CouponId==id);
                _responseDto.result= _mapper.Map<Coupon>(coupon);
                return Ok(_responseDto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("This id not found in Database\n" + ex.Message);
                _responseDto.errorMessage = ex.Message;
                _responseDto.isSuccessful = false;
                return NotFound(_responseDto);
            }

        }




    }
}
