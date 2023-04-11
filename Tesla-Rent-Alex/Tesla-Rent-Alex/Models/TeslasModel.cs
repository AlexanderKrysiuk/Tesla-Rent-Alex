namespace Tesla_Rent_Alex.Models;

public class TeslasModel
{
    public int ReservationID { get; set; }
    public string StartLocation { get; set; }
    public string EndLocation { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Model { get; set; }
    public int BasePrice { get; set; } = 5;
    public int FinalPrice { get; set; }
}