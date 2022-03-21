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
    public class DangKiMuBansController : ControllerBase
    {
        
        private readonly IDangKiMuaBanRepository dangKiMuaBanRepository;

        public DangKiMuBansController(IDangKiMuaBanRepository dangKiMuaBanRepository)
        {
            this.dangKiMuaBanRepository = dangKiMuaBanRepository;
        }
        [HttpGet]
        
        public async Task<ActionResult> GetDangKi()
        {
            try
            {
                return Ok(await dangKiMuaBanRepository.GetDangKiMuaBans());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Đã có lỗi");
                //throw;
            }

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<DangKiMuaBan>> GetDangKis(int id)
        {
            try
            {
                var result = await dangKiMuaBanRepository.GetDangKi(id);
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
        public async Task<ActionResult<DangKiMuaBan>> CreateDangKis(DangKiMuaBan dangKiMuaBan)
        {
            try
            {
                if (dangKiMuaBan == null)
                {
                    return BadRequest();
                }
                var createdDangKi = await dangKiMuaBanRepository.AddDangKi(dangKiMuaBan);
                return CreatedAtAction(nameof(GetDangKis), new
                {
                    id = createdDangKi.Orderid,
                    createdDangKi
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
        public async Task<ActionResult<DangKiMuaBan>> UpdateDangKis(int id, DangKiMuaBan dangKiMuaBan)
        {
            try
            {
                if (id != dangKiMuaBan.Orderid)
                {
                    return BadRequest("Thông báo");
                }
                var dangkiUpdate = await dangKiMuaBanRepository.GetDangKi(id);
                if (dangkiUpdate == null)
                {
                    return NotFound($"dangki id = {id} not found");
                }
                return await dangKiMuaBanRepository.UpdateDangKi(dangKiMuaBan);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Đã có lỗi");
                //throw;
            }

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteDangKis(int id)
        {
            try
            {

                var dangkiDelete = await dangKiMuaBanRepository.GetDangKi(id);
                if (dangkiDelete == null)
                {
                    return NotFound($"dangki id = {id} not found");
                }
                await dangKiMuaBanRepository.DeleteDangKi(id);
                return Ok($"dangki id = {id} not found");
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
