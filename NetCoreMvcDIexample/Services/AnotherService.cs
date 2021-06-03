using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcDIExample.Services
{
    /// <summary>
    /// Example another service
    /// </summary>
    public class AnotherService : IAnotherService
    {
        private DateTime _creationDate;

        public AnotherService() {
            _creationDate = DateTime.Now;
        }
        public DateTime GetCreationDate()
        {
            return _creationDate;
        }
    }
}
