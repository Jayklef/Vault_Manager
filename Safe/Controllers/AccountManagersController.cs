using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Safe.DataAccess.Dtos;
using Safe.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Safe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountManagersController : ControllerBase
    {
        private readonly AccountManagerRepository _IAccountManagerRepository;

        public AccountManagersController(AccountManagerRepository iAccountManagerRepository)
        {
            _IAccountManagerRepository = iAccountManagerRepository;
        }

        [HttpGet("GetAllAccountManagers")]
        public IActionResult GetAllAccountManagers()
        {
            try
            {
                var accountManager = _IAccountManagerRepository.GetAllAccountManagers();
                return Ok(accountManager);
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

        [HttpGet("GetAccountManagerById")]
        public IActionResult GetAccountManagerById(int id)
        {
            try
            {
                var accountManager = _IAccountManagerRepository.GetAccountManagerById(id);
                return Ok(accountManager);
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

        [HttpPost("CreateAccountManager")]
        public IActionResult CreateAccountManager(AccountManagerDto accountManagerDto)
        {
            try
            {
                _IAccountManagerRepository.CreateAccountManager(accountManagerDto);
                return Ok(accountManagerDto);
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
