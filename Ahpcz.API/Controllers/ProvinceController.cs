using Ahpcz.Domain.Entities;
using Ahpcz.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ahpcz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProvinceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var provincesFromRepo = _unitOfWork.Province.GetAll();
            return Ok(provincesFromRepo);
        }
        [HttpGet("{id}")]
        public ActionResult Getbycode(int id)
        {
            var provincesFromRepo = _unitOfWork.Province.GetById(id);
            return Ok(provincesFromRepo);
        }
        [HttpPost("Create")]
        public ActionResult Post(Province data)
        {
            _unitOfWork.Province.Add(data);

            return Ok();
        }
        [HttpPut("Update")]
        public ActionResult Put(Province data)
        {
            _unitOfWork.Province.Update(data);

            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _unitOfWork.Province.Remove(id);

            return Ok();
        }
    }
}
