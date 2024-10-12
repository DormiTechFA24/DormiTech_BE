namespace Domain.Model;

public partial class AccDisciplineTicketDocument
{
    public Guid DisciplineTicketId { get; set; }

    public int OrderIndex { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? FileLink { get; set; }

    public virtual AccDisciplineTicket DisciplineTicket { get; set; } = null!;

    public virtual GenDocument? DocumentType { get; set; }
}