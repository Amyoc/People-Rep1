using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PeopleRep1WpfApp1.Pages
{
    public class page1Model : PageModel
    {
        public string Message { get; set; }

    
        [BindProperty]
        public int Number01 { get; set; }
        [BindProperty]
        [Display(Name="Second Name")]
        public int? Number02 { get; set; }
        public void OnGet()
        {
            Message = "hello world from the get method";
        }
        //example 1
        //public void OnPost()
        //{
        //    Message = "hello from the post method";
        //}

        //example 2
        //public void OnPost(int number1)
        //{
        //    Message= String.Format("hello from the post method where number (key) is: {0}", number1);
        //}

        //example 3
        public void OnPost()
        {
            //Message = String.Format("hello from the post method where number (key) is: {0}", Number01);
            Message = $"{Number01} plus {Number02} equals {Number01 + Number02}";
        }
}
}