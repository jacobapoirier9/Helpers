using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class DebuggingHelpers
    {
        public static bool IsDebugging() => System.Diagnostics.Debugger.IsAttached;
    }
}
