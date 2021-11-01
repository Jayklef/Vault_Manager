using Safe.DataAccess.Dtos;
using Safe.DataAccess.Repositories.Interface;
using Safe.Domain;
using Safe.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Concrete
{
    public class ErrorLogRepository : IErrorLogRepository
    {
        private readonly SafeContext _context;

        public ErrorLogRepository(SafeContext context)
        {
            _context = context;
        }

        public List<ErrorLogDto> GetAllErrors()
        {
            var errorLogs = _context.ErrorLogs.Select(e => new ErrorLogDto
            {
                Id = e.Id,
                RequestId = e.RequestId,
                ErrorMessage = e.ErrorMessage,
                StackTrace = e.StackTrace,
                InnerException = e.InnerException
            }).ToList();

            return errorLogs;
        }

        ErrorLogDto IErrorLogRepository.GetErrorById(int Id)
        {
            var errorLog = _context.ErrorLogs.Where(e => e.Id == Id).Select(e => new ErrorLogDto
            {
                Id = e.Id,
                RequestId = e.RequestId,
                ErrorMessage = e.ErrorMessage,
                StackTrace = e.StackTrace,
                InnerException = e.InnerException
            }).FirstOrDefault();

            return errorLog;
        }

        void IErrorLogRepository.CreateErrorLog(ErrorLogDto errorLogDto)
        {
            var errorLog = new ErrorLog
            {
                Id = errorLogDto.Id,
                RequestId = errorLogDto.RequestId,
                ErrorMessage = errorLogDto.ErrorMessage,
                StackTrace = errorLogDto.StackTrace,
                InnerException = errorLogDto.InnerException
            };

            _context.Add(errorLog);
            _context.SaveChanges();
        }

    }
}
