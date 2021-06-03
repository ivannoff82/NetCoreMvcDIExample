using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcDIExample.Services
{
    /// <summary>
    /// Another service example
    /// </summary>
    public interface IAnotherService
    {
        /// <summary>
        /// Object creation Date
        /// </summary>
        /// <returns></returns>
        DateTime GetCreationDate();
    }
}
