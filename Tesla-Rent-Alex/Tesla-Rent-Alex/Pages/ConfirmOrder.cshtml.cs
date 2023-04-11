using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Tesla_Rent_Alex.Data;
using Tesla_Rent_Alex.Models;

namespace Tesla_Rent_Alex.Pages;

[BindProperties (SupportsGet = true)]
public class ConfirmOrder : PageModel
{
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string StartLocation { get; set; }
    public string EndLocation { get; set; }
    public int RentPrice { get; set; }
    public string Model { get; set; }

    private readonly ApplicationDbContext _context;
    public ConfirmOrder(ApplicationDbContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        TeslaOrder teslaOrder = new TeslaOrder();
        teslaOrder.StartDate = StartDate;
        teslaOrder.EndDate = EndDate;
        teslaOrder.StartLocation = StartLocation;
        teslaOrder.EndLocation = EndLocation;
        teslaOrder.RentPrice = RentPrice;
        teslaOrder.Model = Model;

        _context.TeslaOrders.Add(teslaOrder);
        _context.SaveChanges();
    }
}