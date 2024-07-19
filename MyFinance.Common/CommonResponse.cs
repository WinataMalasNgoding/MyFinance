using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Common
{
    public class CommonResponse
    {
        public int Code { get; set; }
        public required string Status { get; set; }
        public required string Message { get; set; }
        public object? Data { get; set; }
        public string? Error { get; set; }
    }
}
