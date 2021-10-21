using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe.DataAccess.Dtos
{
    public class ErrorResponseDto
    {
        public string ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
        public string StackTrace { get; set; }
    }
}
