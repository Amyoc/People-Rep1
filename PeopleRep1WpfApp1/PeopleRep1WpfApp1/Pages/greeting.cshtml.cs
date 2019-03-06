using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PeopleRep1WpfApp1.Pages
{
    public class greetingModel : PageModel
    {
        public void OnGet()
        {
            if (DateTime.Now.Hour >= 12)
            {
                Message = "Top of the afternoon to ya!";
            }
            else
            {
                Message = "Top of the morning to ya!";
            }
        }

        public string Message { get; set; } = "Hello";
    }
}
