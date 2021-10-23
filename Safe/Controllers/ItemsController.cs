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
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository _IItemRepository;

        public ItemsController(IItemRepository iItemRepository)
        {
            _IItemRepository = iItemRepository;
        }

        [HttpGet("GetAllItems")]
        public IActionResult GetAllItem()
        {
            try
            {
                var item = _IItemRepository.GetAllItems();
                return Ok();
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

        [HttpGet("GetItemById")]
        public IActionResult GetItemById(int itemId)
        {
            try
            {
                var item = _IItemRepository.GetItemById(itemId);
                return Ok();
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

        [HttpPost("CreateItem")]
        public IActionResult CreateItem(ItemDto itemDto)
        {
            try
            {
                _IItemRepository.CreateItem(itemDto);
                return Ok();
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

        [HttpPut("UpdateItem")]
        public IActionResult UpdateItem(ItemDto itemDto)
        {
            try
            {
                _IItemRepository.UpdateItem(itemDto);
                return Ok();
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

        [HttpDelete("DeleteItem")]
        public IActionResult DeleteItem(int ItemId)
        {
            try
            {
                _IItemRepository.DeleteItem(ItemId);
                return Ok();
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
