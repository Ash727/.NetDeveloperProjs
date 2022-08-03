using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkLibary
{
    public class Generators
    {
        public string WelecomMessage(string prefix, string lastName)
        {
            return $"Welcome to our Demo App {prefix}.{lastName}";
        }

        public string FarewellMessage(string prefix, string lastName)
        {
            return $"I Hope you enjoyed your time with us {prefix}.{lastName} please come back soon";
        }
    }
}
