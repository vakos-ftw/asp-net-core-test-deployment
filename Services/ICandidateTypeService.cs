using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WorkingWithData.Services
{
    public interface ICandidateTypeService
    {
        IEnumerable<SelectListItem> GetAll();
    }

    public class CandidateTypeService : ICandidateTypeService
    {
        public IEnumerable<SelectListItem> GetAll()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Junior Developer" },
                new SelectListItem { Value = "2", Text = "Middle Developer" },
                new SelectListItem { Value = "3", Text = "Senior Developer" },
                new SelectListItem { Value = "4", Text = "Quality Assurance" }
            };
        }
    }
}
