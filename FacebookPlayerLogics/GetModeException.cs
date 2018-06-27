using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPlayerLogics
{
    public class GetModeException : Exception
    {
        public GetModeException(string message) : base(message)
        {
        }
    }
}
