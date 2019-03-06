using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PeopleRep1WpfApp1.Pages
{
    public class ws1bModel : PageModel
    {
        public string Message { get; set; }
        [BindProperty]
        public int Number01 { get; set; }
        [BindProperty]
        public int Number02 { get; set; }

        public void OnGet()
        {

        }
        /*
        public void OnPost()
        {
            //Message = String.Format("hello from the post method where number (key) is: {0}", Number01);
            Message = $"{Number01} plus {Number02} equals {Number01 + Number02}";


        }
        */

        public void OnPost(int Number01, int Number02)
        {
            if (Request.Form["sums"] == "Add number")
                Message = "Total of " + Number01 + " and " + Number02 + " is " + (Number01 + Number02);
            if (Request.Form["sums"] == "Subtract number")
                Message = "Total of " + Number01 + " minus " + Number02 + " is " + (Number01 - Number02);
            if (Request.Form["sums"] == "Multiply number")
                Message = "Total of " + Number01 + " by " + Number02 + " is " + (Number01 * Number02);
            if (Request.Form["sums"] == "Divide number")
                Message = "Total of " + Number01 + " divided by " + Number02 + " is " + (Number01 / Number02);
        }
    }
}