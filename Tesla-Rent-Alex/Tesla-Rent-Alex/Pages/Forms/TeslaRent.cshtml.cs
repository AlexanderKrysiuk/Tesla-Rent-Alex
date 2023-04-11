using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tesla_Rent_Alex.Models;

namespace Tesla_Rent_Alex.Pages.Forms;

public class TeslaRent : PageModel
{
    [BindProperty]
    public TeslasModel Tesla { get; set; }
    public int RentPrice { get; set; }
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        RentPrice = Tesla.BasePrice;
        var startDate = DateTime.Parse(Tesla.StartDate);
        var endDate = DateTime.Parse(Tesla.EndDate);
        var dateLapse = (endDate - startDate).TotalDays;
        RentPrice = Tesla.BasePrice + (int)dateLapse;

        return RedirectToPage("/ConfirmOrder", new
        {
            Tesla.StartDate,
            Tesla.EndDate,
            Tesla.StartLocation,
            Tesla.EndLocation,
            Tesla.Model,
            RentPrice
        });
    }
}