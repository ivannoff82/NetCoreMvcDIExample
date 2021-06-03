using Microsoft.AspNetCore.Mvc;
using NetCoreMvcDIExample.Models;
using NetCoreMvcDIExample.Services;
using NetCoreMvcDIExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMvcDIExample.Controllers
{
    public class HomeController : Controller
    {
        private IPersonManager _personManager;

        private IAnotherService _transientExample;

        /// <summary>
        /// ctor with inject personManager
        /// </summary>
        /// <param name="personManager"></param>
        public HomeController(IPersonManager personManager, IAnotherService transientExample)
        {
            _personManager = personManager;
            _transientExample = transientExample;
        }

        public IActionResult Index()
        {
            var model = new IndexModel() { 
                persons = _personManager.FindAll(),
                TransientExampleServiceCreationDate = _transientExample.GetCreationDate(),
                PersonManagerCreateDate = _personManager.GetCreationDate()
            };
            return View(model);
        }

        [HttpPost]
        public string CreatePerson(Person person)
        {
            _personManager.Add(person);
            return "0";
        }

        [HttpPost]
        public string DeletePerson(Person person)
        {
            _personManager.Delete(person);
            return "0";
        }
    }
}
