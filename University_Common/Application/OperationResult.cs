using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Common.Application
{
    public class OperationResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public int Code { get; set; }

        public OperationResult()
        {
            this.IsSuccess = false;
        }

        public OperationResult Success(int Code, string Message = "عملیات با موفقیت انجام شد .")
        {
            this.IsSuccess = true;
            this.Code = Code;
            this.Message = Message;
            return this;
        }


        public OperationResult Failed(int Code, string Message = "خطا در انجام عملیات .")
        {
            this.IsSuccess = false;
            this.Code = Code;
            this.Message = Message;
            return this;
        }

    }
}
