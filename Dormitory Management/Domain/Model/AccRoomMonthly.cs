namespace Domain.Model;

public partial class AccRoomMonthly
{
    public int RoomId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public Guid? AccRoomId { get; set; }

    public decimal? PricePerStudent { get; set; }

    public decimal? ElectricityUnitPrice { get; set; }

    public decimal? WaterUnitPrice { get; set; }

    public decimal? ElectricityAmount { get; set; }

    public decimal? WaterAmount { get; set; }

    public decimal? ServiceFee { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<AccRoomStudentMonthly> AccRoomStudentMonthlies { get; set; } =
        new List<AccRoomStudentMonthly>();

    public virtual FacRoom Room { get; set; } = null!;
}