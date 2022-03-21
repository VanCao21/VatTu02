using Cao1.entities;
using Cao2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cao2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoPhansController : ControllerBase
    {
        private readonly IBoPhanRepository boPhanRepository;

        public BoPhansController(IBoPhanRepository boPhanRepository)
        {
            this.boPhanRepository = boPhanRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetBoPhan()
        {
            try
            {
                return Ok(await boPhanRepository.GetBoPhans());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Đã có lỗi");
                //throw;
            }

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<BoPhan>> GetBoPhans(int id)
        {
            try
            {
                var result = await boPhanRepository.GetBoPhan(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Đã có lỗi");
                //throw;
            }
        }
        [HttpPost]
        public async Task<ActionResult<BoPhan>> CreateBoPhans(BoPhan boPhan)
        {
            try
            {
                if (boPhan == null)
                {
                    return BadRequest();
                }
                var createdBoPhan = await boPhanRepository.AddBoPhan(boPhan);
                return CreatedAtAction(nameof(GetBoPhan), new
                {
                    id = createdBoPhan.BoPhanid,
                    createdBoPhan
                });
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Đã có lỗi");
                //throw;
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<BoPhan>> UpdateBoPhans(int id, BoPhan boPhan)
        {
            try
            {
                if (id != boPhan.BoPhanid)
                {
                    return BadRequest("Thông báo");
                }
                var boPhanUpdate = await boPhanRepository.GetBoPhan(id);
                if (boPhanUpdate == null)
                {
                    return NotFound($"product id = {id} not found");
                }
                return await boPhanRepository.UpdateBoPhan(boPhan);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Đã có lỗi");
                //throw;
            }

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteBoPhans(int id)
        {
            try
            {

                var bophanDelete = await boPhanRepository.GetBoPhan(id);
                if (bophanDelete == null)
                {
                    return NotFound($"product id = {id} not found");
                }
                await boPhanRepository.DeleteBoPhan(id);
                return Ok($"bophan id = {id} not found");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Đã có lỗi");
                //throw;
            }
        }
    }
}
