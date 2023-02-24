using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult(bool success) : base(false)
        {
        }

        public ErrorResult(bool success, string message) : base(false, message)
        {
        }
    }
}