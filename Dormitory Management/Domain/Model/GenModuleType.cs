namespace Domain.Model;

public partial class GenModuleType
{
    public int ModuleTypeId { get; set; }

    public string? ModuleName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public virtual ICollection<SysDocumentSetUp> SysDocumentSetUps { get; set; } = new List<SysDocumentSetUp>();
}