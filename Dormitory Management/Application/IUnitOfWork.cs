
using Application.Abstractions.IRepository;

namespace Application.Abstractions;

public interface IUnitOfWork
{
    public IFacRoomRepository roomRepository { get; }
    public IGenDocumentRepository documentRepository { get; }
    public IGenEmployeePositionRepository employeePositionRepository { get; }
    public IGenEthnicityRepository ethnicityRepository { get; }
    public IGenItemStatusRepository itemStatusRepository { get; }
    public IGenModuleTypeRepository moduleTypeRepository { get; }
    public IGenModuleTypeRepository moduleRepository { get; }
    public IGenPayTypeRepository payTypeRepository { get; }
    public IGenProvinceRepository provinceRepository { get; }
    public IGenPunishmentTypeRepository punishmentTypeRepository { get; }
    public IGenRoomStatusRepository roomStatusRepository { get; }
    public IGenRoomTypeRepository roomTypeRepository { get; }
    public IGenServiceRepository serviceRepository { get; }
    public IGenServicePricingRepository servicePricingRepository { get; }
    public IGenSocialStatusTypeRepository socialStatusTypeRepository { get; }
    public IGenStudentRepository studentRepository { get; }
    public IGenWardRepository wardRepository { get; }
    public ITkIssueTicketTypeRepository issueTicketTypeRepository { get; }
    public ITkIssueTicketStatusRepository issueTicketStatusRepository { get; }
    public ITkIssueTicketDetailRepository issueTicketDetailRepository { get; }
    public ITkIssueTicketPhotoRepository issueTicketPhotoRepository { get; }
    public IAccRoomRequestRepository roomRequestRepository { get; }
    public IAccRoomMonthlyRepository roomMonthlyRepository { get; }
    public IAccRoomStudentMonthlyRepository roomStudentMonthlyRepository { get; }
    Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    void Dispose();
}