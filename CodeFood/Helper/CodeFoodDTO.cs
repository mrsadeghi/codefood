using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFood.Helper
{
    public class DTO<T>
    {
        public DTO(T value, bool isSuccess = true, string message = "")
        {
            Value = value;
            IsSuccess = isSuccess;
            Message = message;
        }
        public T Value { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}
