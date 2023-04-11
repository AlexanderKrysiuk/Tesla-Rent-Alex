namespace Tesla_Rent_Alex.Models;

public class TeslaOrder
{
    public int Id { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string StartLocation { get; set; }
    public string EndLocation { get; set; }
    public string Model { get; set; }
    public int RentPrice { get; set; }
}