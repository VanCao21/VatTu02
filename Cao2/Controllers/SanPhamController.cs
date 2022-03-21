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
    public class SanPhamController : ControllerBase
    {
        private readonly ISanPhamRepository sanPhamRepository;

        public SanPhamController(ISanPhamRepository sanPhamRepository)
        {
            this.sanPhamRepository = sanPhamRepository;
        }
        //[HttpGet]
        //public async Task<ActionResult> GetDangKi()
        //{
        //    try
        //    {
        //        return Ok(await sanPhamRepository.GetSanPhams());
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Đã có lỗi");
        //        //throw;
        //    }

        //}
        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<SanPham>> GetDangKis(int id)
        //{
        //    try
        //    {
        //        var result = await sanPhamRepository.GetSanPham(id);
        //        if (result == null)
        //        {
        //            return NotFound();
        //        }
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Đã có lỗi");
        //        //throw;
        //    }
        //}
        //[HttpPost]
        //public async Task<ActionResult<SanPham>> CreateDangKis(SanPham sanPham)
        //{
        //    try
        //    {
        //        if (sanPham == null)
        //        {
        //            return BadRequest();
        //        }
        //        var createdDangKi = await sanPhamRepository.AddSanPham(sanPham);
        //        return CreatedAtAction(nameof(GetDangKi), new
        //        {
        //            id = createdDangKi.SanPhamid,
        //            createdDangKi
        //        });
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Đã có lỗi");
        //        //throw;
        //    }
        //}
        //[HttpPut("{id:int}")]
        //public async Task<ActionResult<SanPham>> UpdateDangKis(int id, SanPham sanPham)
        //{
        //    try
        //    {
        //        if (id != sanPham.SanPhamid)
        //        {
        //            return BadRequest("Thông báo");
        //        }
        //        var dangkiUpdate = await sanPhamRepository.GetSanPham(id);
        //        if (dangkiUpdate == null)
        //        {
        //            return NotFound($"dangki id = {id} not found");
        //        }
        //        return await sanPhamRepository.UpdateSanPham(sanPham);
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Đã có lỗi");
        //        //throw;
        //    }

        //}
        //[HttpDelete("{id:int}")]
        //public async Task<ActionResult> DeleteDangKis(int id)
        //{
        //    try
        //    {

        //        var dangkiDelete = await sanPhamRepository.GetSanPham(id);
        //        if (dangkiDelete == null)
        //        {
        //            return NotFound($"dangki id = {id} not found");
        //        }
        //        await sanPhamRepository.DeleteSanPham(id);
        //        return Ok($"dangki id = {id} not found");
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //            "Đã có lỗi");
        //        //throw;
        //    }
        //}
    }
}
