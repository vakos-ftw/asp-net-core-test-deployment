using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WorkingWithData.ModelBinders;

namespace WorkingWithData.Models
{
    public class UserInputModel
    {
        [MinLength(2)]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [MinLength(2)]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        //[ModelBinder(typeof(AgeModelBinder))]
        [Required]
        [Range(18, int.MaxValue)]
        public int Age { get; set; }

        public int CandidateType { get; set; }

        public IEnumerable<SelectListItem> CandidateTypes { get; set; }
    }
}
