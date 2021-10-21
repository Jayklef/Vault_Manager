using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safe.DataAccess.Dtos;
using Safe.DataAccess.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Safe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _ICategoryRepository;

        public CategoriesController(ICategoryRepository iCategoryRepository)
        {
            _ICategoryRepository = iCategoryRepository;
        }

        [HttpGet("GetAllCategories")]
        public IActionResult GetAllCategories()
        {
            try
            {
                var categories = _ICategoryRepository.GetAllCategories();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                var errorResponse = new ErrorResponseDto
                {
                    ResponseCode = "01",
                    ResponseMessage = ex.Message == null ? null : ex.Message.ToString(),
                    StackTrace = ex.StackTrace
                };

                return BadRequest(errorResponse);
            }
        }

        [HttpGet("GetCategoryById")]
        public IActionResult GetCategoryById(int id)
        {
            try
            {
                var category = _ICategoryRepository.GetCategoryById(id);
                return Ok(category);
            }
            catch (Exception ex)
            {
                var errorResponse = new ErrorResponseDto
                {
                    ResponseCode = "01",
                    ResponseMessage = ex.Message == null ? null : ex.Message.ToString(),
                    StackTrace = ex.StackTrace
                };

                return BadRequest(errorResponse);
            }
        }

        [HttpPost("CreateCategory")]
        public IActionResult CreateCategory(CategoryDto categoryDto)
        {
            try
            {
                _ICategoryRepository.CreateCategory(categoryDto);
                return Ok(categoryDto);
            }
            catch (Exception ex)
            {
                var errorResponse = new ErrorResponseDto
                {
                    ResponseCode = "01",
                    ResponseMessage = ex.Message == null ? null : ex.Message.ToString(),
                    StackTrace = ex.StackTrace
                };

                return BadRequest(errorResponse);
            }
        }
    }

}
