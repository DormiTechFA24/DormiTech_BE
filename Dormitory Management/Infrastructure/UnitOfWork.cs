using Application.Abstractions;
using Domain.Model;
using Application.Abstractions.IRepository;
using Infrastructure.Repositories;
namespace Infrastructure;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DormiTechContext _context;
    //public UnitOfWork(DormiTechContext context) => _context = context;

    private bool disposed = false;

    #region demo
    private readonly IFacRoomRepository _roomRepository;
    private readonly IGenDocumentRepository _documentRepository;
    private readonly IGenEmployeePositionRepository _employeePositionRepository;
    private readonly IGenEthnicityRepository _ethnicityRepository;
    private readonly ITkIssueTicketStatusRepository _issueTicketStatusRepository;
    private readonly ITkIssueTicketTypeRepository _issueTicketTypeRepository;
    private readonly IGenItemStatusRepository _itemStatusRepository;
    private readonly IGenModuleTypeRepository _moduleTypeRepository;
    private readonly IGenPayTypeRepository _payTypeRepository;
    private readonly IGenProvinceRepository _provinceRepository;
    private readonly IGenPunishmentTypeRepository _punishmentTypeRepository;
    private readonly IGenRoomStatusRepository _roomStatusRepository;
    private readonly IGenRoomTypeRepository _roomTypeRepository;
    private readonly IGenServiceRepository _serviceRepository;
    private readonly IGenServicePricingRepository _servicePricingRepository;
    private readonly IGenSocialStatusTypeRepository _socialStatusTypeRepository;
    private readonly IGenStudentRepository _studentRepository;
    private readonly IGenWardRepository _wardRepository;
    private readonly ITkIssueTicketDetailRepository _issueTicketDetailRepository;
    private readonly ITkIssueTicketPhotoRepository _issueTicketPhotoRepository;
    private readonly IAccRoomRequestRepository _roomRequestRepository;
    private readonly IAccRoomMonthlyRepository _roomMonthlyRepository;
    private readonly IAccRoomStudentMonthlyRepository _roomStudentMonthlyRepository;
    private readonly IGenAmenityRepository _amenityRepository;
    private readonly IFacBuildingRepository _buildingRepository;
    private readonly IFacItemRepository _itemRepository;
    private readonly ISysRoleRepository _RoleRepository;
    private readonly IFacRoomItemRepository _roomItemRepository;
    private readonly IGenEmployeeRepository _employeeRepository;
    private readonly IAccDisciplineTicketRepository _disciplineTicketRepository;
    private readonly IAccDisciplineTicketDocumentRepository _disciplineTicketDocumentRepository;
    public UnitOfWork(DormiTechContext context, IFacRoomRepository roomRepository)
    {
        _context = context;
        _roomRepository = roomRepository;
    }

    public IFacRoomRepository roomRepository => _roomRepository;
    public IGenDocumentRepository documentRepository => _documentRepository;
    public IGenEmployeePositionRepository employeePositionRepository => _employeePositionRepository;
    public IGenEthnicityRepository ethnicityRepository => _ethnicityRepository;
    public IGenItemStatusRepository itemStatusRepository => _itemStatusRepository;
    public IGenModuleTypeRepository moduleTypeRepository => _moduleTypeRepository;
    public IGenModuleTypeRepository moduleRepository => _moduleTypeRepository;
    public IGenPayTypeRepository payTypeRepository => _payTypeRepository;
    public IGenProvinceRepository provinceRepository => _provinceRepository;
    public IGenPunishmentTypeRepository punishmentTypeRepository => _punishmentTypeRepository;
    public IGenRoomStatusRepository roomStatusRepository => _roomStatusRepository;
    public IGenRoomTypeRepository roomTypeRepository => _roomTypeRepository;
    public IGenServiceRepository serviceRepository => _serviceRepository;
    public IGenServicePricingRepository servicePricingRepository => _servicePricingRepository;
    public IGenSocialStatusTypeRepository socialStatusTypeRepository => _socialStatusTypeRepository;
    public IGenStudentRepository studentRepository => _studentRepository;
    public IGenWardRepository wardRepository => _wardRepository;
    public ITkIssueTicketTypeRepository issueTicketTypeRepository => _issueTicketTypeRepository;
    public ITkIssueTicketDetailRepository issueTicketDetailRepository => _issueTicketDetailRepository;
    public ITkIssueTicketPhotoRepository issueTicketPhotoRepository => _issueTicketPhotoRepository;
    public IAccRoomRequestRepository roomRequestRepository => _roomRequestRepository;
    public IAccRoomMonthlyRepository roomMonthlyRepository => _roomMonthlyRepository;
    public IAccRoomStudentMonthlyRepository roomStudentMonthlyRepository => _roomStudentMonthlyRepository;
    public ITkIssueTicketStatusRepository issueTicketStatusRepository => _issueTicketStatusRepository;
    public IGenAmenityRepository amenityRepository => _amenityRepository;

    public IFacBuildingRepository facBuildingRepository => _buildingRepository;

    public IFacItemRepository facItemRepository => _itemRepository;

    public IFacRoomItemRepository facRoomItemRepository => _roomItemRepository;

    public ISysRoleRepository sysRoleRepository => _RoleRepository;

    public IGenEmployeeRepository employeeRepository => _employeeRepository;

    public IAccDisciplineTicketRepository accDisciplineTicketRepository => _disciplineTicketRepository;

    public IAccDisciplineTicketDocumentRepository accDisciplineTicketDocumentRepository => _disciplineTicketDocumentRepository;

    #endregion
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }



    public Task<int> SaveChangeAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChangesAsync();
    }
}