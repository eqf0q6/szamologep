using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CalculatorApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public double Number1 { get; set; }
        [BindProperty]
        public double Number2 { get; set; }
        [BindProperty]
        public string Operator { get; set; }
        public double Result { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            switch (Operator)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    if (Number2 != 0)
                    {
                        Result = Number1 / Number2;
                    }
                    else
                    {
                        Result = double.NaN; // Not a Number
                    }
                    break;
                default:
                    Result = double.NaN; // Not a Number
                    break;
            }
        }
    }
}