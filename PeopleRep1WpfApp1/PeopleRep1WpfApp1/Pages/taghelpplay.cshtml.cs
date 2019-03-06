using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PeopleRep1WpfApp1.Pages
{
    public class taghelpplayModel : PageModel
    {
        [BindProperty]
        public int Number1 { get; set; }

        [BindProperty]
        public int? Number2 { get; set; }

        [BindProperty]
        public double Number3 { get; set; }

        [BindProperty]
        public double? Number4 { get; set; }

        [BindProperty]
        public decimal Number5 { get; set; }

        [BindProperty]
        public decimal?  Number6 { get; set; }

        [BindProperty]
        public float Number7 { get; set; }

        [BindProperty]
        public float Number8 { get; set; }

        [BindProperty]
        public string String9{ get; set; }

        [BindProperty]
        public DateTime Item10 { get; set; }

        [BindProperty]
        public bool Item11 { get; set; }


        public string SeasonMessage { get; set; }
        [BindProperty]
        public int Season2019 { get; set; }
      
        public void OnGet()
        {

        }

        public void OnPost()
        {
            //Message = string.Format("You selected {0}", Season);
            if (Request.Form["Season2019"] == "Spring")
                SeasonMessage = "You selected Spring";
            if (Request.Form["Season2019"] == "Summer")
               SeasonMessage = "You selected Summer";
            if (Request.Form["Season2019"] == "Autumn")
                SeasonMessage = "You selected Autumn";
            if (Request.Form["Season2019"] == "Winter")
                SeasonMessage = "You selected Winter";
        }
    }
}