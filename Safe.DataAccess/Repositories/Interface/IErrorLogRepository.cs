using Safe.DataAccess.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Repositories.Interface
{
    public interface IErrorLogRepository
    {
        List<ErrorLogDto> GetAllErrors();
        ErrorLogDto GetErrorById(int Id);
        void CreateErrorLog(ErrorLogDto errorLogDto);
    }
}
