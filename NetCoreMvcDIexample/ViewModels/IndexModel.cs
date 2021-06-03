using NetCoreMvcDIExample.Models;
using NetCoreMvcDIExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcDIExample.ViewModels
{
    public class IndexModel
    {
        /// <summary>
        /// All persons
        /// </summary>
        public IList<Person> persons { get; set; }

        /// <summary>
        /// Creation date of PersonManager - Singleton dependency
        /// </summary>
        public DateTime PersonManagerCreateDate { get; set; }

        /// <summary>
        /// Creation date of TransientExample - Transient dependency 
        /// </summary>
        public DateTime TransientExampleServiceCreationDate { get; set; }

    }
}
