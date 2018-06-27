using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPlayerLogics
{
    public class GetURLException : Exception
    {
        public GetURLException(string message) : base(message)
        {
        }
    }
}
