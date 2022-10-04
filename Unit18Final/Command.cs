using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit18Final
{
    public abstract class Command
    {
        public abstract Task Run();
    }
}
