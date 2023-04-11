using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tesla_Rent_Alex.Data;
using Tesla_Rent_Alex.Models;

namespace Tesla_Rent_Alex.Pages;

public class ShowRents : PageModel
{

    public List<TeslaOrder> TeslaOrders = new List<TeslaOrder>();

    private readonly ApplicationDbContext _context;
    public ShowRents(ApplicationDbContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        TeslaOrders = _context.TeslaOrders.ToList();
    }
}