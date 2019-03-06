using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PeopleRep1WpfApp1.Pages
{
    public class timeModel : PageModel
    {

        public string[] daysOfWeek { get; set; }
            = { "monday", "muesday", "wednesday", "thursday", "firday", "saturday", "sunday" };

        [BindProperty]
        public bool[] daySelected { get; set; } = new bool[7];

        [BindProperty]
        public string[] choosenMonths { get; set; } = { };

        public List<SelectListItem> selectedMonths { get; set; } =
        new List<SelectListItem>
            {
                new SelectListItem ("january", "january"),
                new SelectListItem ("febuary", "febuary"),
                new SelectListItem ("march", "march"),
                new SelectListItem ("april", "april"),
                new SelectListItem ("may", "may"),
                new SelectListItem ("june", "june"),
                new SelectListItem ("july", "july"),
                new SelectListItem ("august", "august"),
                new SelectListItem ("september", "september"),
                new SelectListItem ("october", "october"),
                new SelectListItem ("november", "november"),
                new SelectListItem ("december", "december"),
            };

        public void OnGet()
        {
        }
    }
}