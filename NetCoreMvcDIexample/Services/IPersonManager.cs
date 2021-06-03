using NetCoreMvcDIExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcDIExample.Services
{
    /// <summary>
    /// Manager for CRUD of Persons
    /// </summary>
    public interface IPersonManager
    {
        /// <summary>
        /// Get all stored person
        /// </summary>
        /// <returns></returns>
        IList<Person> FindAll();

        /// <summary>
        /// Find person by FullName / Age
        /// </summary>
        /// <returns></returns>
        IList<Person> Find(string fullName, int? age);

        /// <summary>
        /// Add person to storage
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        void Add(Person person);

        /// <summary>
        /// Delete person from storage (equal by name and age)
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        void Delete(Person person);

        /// <summary>
        /// Object creation Date
        /// </summary>
        /// <returns></returns>
        DateTime GetCreationDate();
    }
}
