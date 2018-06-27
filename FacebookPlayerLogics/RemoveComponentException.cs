using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPlayerLogics
{
    internal class RemoveComponentException : Exception
    {
        public RemoveComponentException(string message) : base(message)
        {
        }
    }
}
