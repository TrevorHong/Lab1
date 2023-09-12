using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab1.Models;
using Microsoft.VisualBasic;

namespace Lab1.Pages
{
    public class ZodiacModel : PageModel
    {
        [BindProperty]
        [Display (Name = "year")]
        public int year {get; set;}


        public void OnPost() {
            if (year < 1900 || year > 2024) {
                ViewData["Error"] = "Year must be between 1900 and next year, please try again.";
            } else {
                ViewData["Zodiac"] = "Your Zodiac is: " + Utils.GetZodiac(year);
                ViewData["Image"] = "\\images\\" + Utils.GetZodiac(year) + ".png";
            }
        }

        public void OnGet()
        {
            ViewData["Zodiac"] = "";
        }
    }
}
