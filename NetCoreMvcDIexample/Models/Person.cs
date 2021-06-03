using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcDIExample.Models
{
    /// <summary>
    /// Person model
    /// </summary>
    public class Person
    {        
        /// <summary>
        /// FullName
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Age of person
        /// </summary>
        public int Age { get; set; }

        public Person() { }

        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
    }
}
