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
    public class ClientsController : ControllerBase
    {
        private readonly IClientRepository _IClientRepository;

        public ClientsController(IClientRepository iClientRepository)
        {
            _IClientRepository = iClientRepository;
        }

        [HttpGet("GetAllClients")]
        public IActionResult GetAllClients()
        {
            try
            {
                var client = _IClientRepository.GetAllClients();
                return Ok(client);
            }
            catch (Exception ex)
            {
                var errorresponse = new ErrorResponseDto
                {
                    ResponseCode = "01",
                    ResponseMessage = ex.Message == null ? null : ex.Message.ToString(),
                    StackTrace = ex.StackTrace
                };

                return BadRequest(errorresponse);
            }
        }
        [HttpGet("GetClientById")]
        public IActionResult GetClientById(int Id)
        {
            try
            {
                var client = _IClientRepository.GetClientById(Id);
                return Ok(client);
            }
            catch (Exception ex)
            {
                var errorResponnse = new ErrorResponseDto
                {
                    ResponseCode = "01",
                    ResponseMessage = ex.Message == null ? null : ex.Message.ToString(),
                    StackTrace = ex.StackTrace
                };

                return BadRequest(errorResponnse);
            }
        }

        [HttpPost("CreateClient")]
        public IActionResult CreateClient(ClientDto clientDto)
        {
            try
            {
                _IClientRepository.CreateClient(clientDto);
                return Ok(clientDto);
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


        [HttpPut("UpdateClient")]
        public IActionResult UpdateClient(ClientDto clientDto)
        {
            try
            {
                _IClientRepository.UpdateClient(clientDto);
                return Ok(clientDto);
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

        [HttpDelete("DeleteClient")]
        public IActionResult DeleteClient(int Id)
        {
            try
            {
               _IClientRepository.DeleteClient(Id);
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
