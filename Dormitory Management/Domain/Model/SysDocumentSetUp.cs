namespace Domain.Model;

public partial class SysDocumentSetUp
{
    public int DocumentTypeId { get; set; }

    public int ModuleTypeId { get; set; }

    public int? MinAmount { get; set; }

    public int? MaxAmount { get; set; }

    public virtual GenDocument DocumentType { get; set; } = null!;

    public virtual GenModuleType ModuleType { get; set; } = null!;
}