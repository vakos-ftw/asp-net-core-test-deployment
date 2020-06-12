using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WorkingWithData.Models;
using WorkingWithData.Services;

namespace WorkingWithData.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly ICandidateTypeService _candidateTypeService;

        public UserController(ILogger<UserController> logger, ICandidateTypeService candidateTypeService)
        {
            _logger = logger;
            _candidateTypeService = candidateTypeService;
        }

        // GET: User/Create
        public ActionResult Register()
        {
            var model = new UserInputModel
            {
                CandidateTypes = _candidateTypeService.GetAll()
            };
            return View(model);
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserInputModel input)
        {
            foreach (var item in ModelState)
            {
                _logger.LogInformation($"{item.Key} : \n");

                foreach (var error in item.Value.Errors)
                {
                    _logger.LogInformation(error.ErrorMessage);
                }
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError(System.Text.Json.JsonSerializer.Serialize(ModelState));

                input.CandidateTypes = _candidateTypeService.GetAll();
                return View(input);
            }

            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller", string.Empty));
        }
    }
}
