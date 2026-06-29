using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Shared.Models
{
    public class OperationResult<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public string GroupTag { get; set; }
        public static OperationResult<T> Succes(T data, string groupTag = "")
        {
            return new OperationResult<T>
            {
                Success = true,
                Data = data,
                GroupTag = groupTag
            };
        }
        public static OperationResult<T> Fail(string message)
        {
            return new OperationResult<T>
            {
                Success = false,
                Message = message
            };
        }
    }
}
