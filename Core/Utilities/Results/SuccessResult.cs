using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(bool success) : base(true)
        {
        }
        public SuccessResult(bool success,string message):base(true,message)
        {
            
        }
    }
}