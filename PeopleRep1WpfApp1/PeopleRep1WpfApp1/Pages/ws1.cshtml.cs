using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PeopleRep1WpfApp1.Pages
{
    public class ws1Model : PageModel
    {
        public string Message { get; set; } = "";

        [BindProperty]
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public void OnPost(string ForeName)
        { Message = string.Format("Hello {0}", ForeName);
        }

        public void OnGet()
        {

        }

        public string[] MyTestArray { get; set; } = { "England", "Ireland", "Scotlant", "Wales" };
    }
}