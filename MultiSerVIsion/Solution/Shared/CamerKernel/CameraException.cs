using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSerVIsion.Solution.Shared.CamerKernel
{
    public class CameraException:Exception
    {
        public int ErrorCode { get; }

        public CameraException(string msg,int code = -1) : base(msg)
        {
            ErrorCode = code;
        }
    }
}
