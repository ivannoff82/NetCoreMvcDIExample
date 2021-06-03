using NetCoreMvcDIExample.Helpers;
using NetCoreMvcDIExample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcDIExample.Services
{
    /// <summary>
    /// XML storage manager of persons
    /// </summary>
    public class PersonXMLManager : IPersonManager
    {
        /// <summary>
        /// Memory storage of persons
        /// </summary>
        private List<Person> _persons;

        private DateTime _creationDate;

        private object _lockManager = new object();

        private string _path;

        private void SavePersons()
        {
            File.WriteAllText(_path, XMLHelper.Serialize(_persons));
        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="path">Full path to xml file of persons</param>
        public PersonXMLManager(string path = null)
        {
            _creationDate = DateTime.Now;

            if (string.IsNullOrEmpty(path) || Path.IsPathFullyQualified(path))
            {
                //store to executable folder
                path = "persons.xml";
            }

            _path = path;

            if (File.Exists(path))
            {
                _persons = XMLHelper.Deserialize<List<Person>>(File.ReadAllText(path));
            }

            if (_persons == null)
            {
                _persons = new List<Person>();
                SavePersons();
            }
        }       

        public void Add(Person person)
        {
            lock (_lockManager)
            {
                _persons.Add(person);
                SavePersons();
            }
        }

        public void Delete(Person person)
        {
            lock (_lockManager)
            {
                var founded = _persons.Where(xx => xx.Age == person.Age && xx.FullName == person.FullName).FirstOrDefault();
                if (founded != null)
                {
                    _persons.Remove(founded);
                    SavePersons();
                }
            }
        }

        public IList<Person> Find(string fullName, int? age)
        {
            return _persons.Where(xx => (fullName == null || xx.FullName == fullName) && (!age.HasValue || xx.Age == age.Value)).ToList();
        }

        public IList<Person> FindAll()
        {
            return _persons.ToList();
        }

        public DateTime GetCreationDate()
        {
            return _creationDate;
        }
    }
}
