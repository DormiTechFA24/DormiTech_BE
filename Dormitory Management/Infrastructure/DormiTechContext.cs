using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Domain.Model;

public partial class DormiTechContext : DbContext
{
    public DormiTechContext()
    {
    }

    public DormiTechContext(DbContextOptions<DormiTechContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccDisciplineTicket> AccDisciplineTickets { get; set; }

    public virtual DbSet<AccDisciplineTicketDocument> AccDisciplineTicketDocuments { get; set; }

    public virtual DbSet<AccRoomApplicationDocument> AccRoomApplicationDocuments { get; set; }

    public virtual DbSet<AccRoomMonthly> AccRoomMonthlies { get; set; }

    public virtual DbSet<AccRoomRealTime> AccRoomRealTimes { get; set; }

    public virtual DbSet<AccRoomRequest> AccRoomRequests { get; set; }

    public virtual DbSet<AccRoomStudentMonthly> AccRoomStudentMonthlies { get; set; }

    public virtual DbSet<BilBilling> BilBillings { get; set; }

    public virtual DbSet<FacBuilding> FacBuildings { get; set; }

    public virtual DbSet<FacItem> FacItems { get; set; }

    public virtual DbSet<FacRoom> FacRooms { get; set; }

    public virtual DbSet<FacRoomItem> FacRoomItems { get; set; }

    public virtual DbSet<GenAmenity> GenAmenities { get; set; }

    public virtual DbSet<GenBillType> GenBillTypes { get; set; }

    public virtual DbSet<GenDistanceType> GenDistanceTypes { get; set; }

    public virtual DbSet<GenDistrict> GenDistricts { get; set; }

    public virtual DbSet<GenDocument> GenDocuments { get; set; }

    public virtual DbSet<GenEmployee> GenEmployees { get; set; }

    public virtual DbSet<GenEmployeePosition> GenEmployeePositions { get; set; }

    public virtual DbSet<GenEthnicity> GenEthnicities { get; set; }

    public virtual DbSet<GenItemStatus> GenItemStatuses { get; set; }

    public virtual DbSet<GenModuleType> GenModuleTypes { get; set; }

    public virtual DbSet<GenPayType> GenPayTypes { get; set; }

    public virtual DbSet<GenProvince> GenProvinces { get; set; }

    public virtual DbSet<GenPunishmentType> GenPunishmentTypes { get; set; }

    public virtual DbSet<GenRoomStatus> GenRoomStatuses { get; set; }

    public virtual DbSet<GenRoomType> GenRoomTypes { get; set; }

    public virtual DbSet<GenService> GenServices { get; set; }

    public virtual DbSet<GenServicePricing> GenServicePricings { get; set; }

    public virtual DbSet<GenSocialStatusType> GenSocialStatusTypes { get; set; }

    public virtual DbSet<GenStudent> GenStudents { get; set; }

    public virtual DbSet<GenWard> GenWards { get; set; }

    public virtual DbSet<HisItemMaintenance> HisItemMaintenances { get; set; }

    public virtual DbSet<LogRoomApplication> LogRoomApplications { get; set; }

    public virtual DbSet<SysAccount> SysAccounts { get; set; }

    public virtual DbSet<SysDocumentSetUp> SysDocumentSetUps { get; set; }

    public virtual DbSet<SysPermission> SysPermissions { get; set; }

    public virtual DbSet<SysRole> SysRoles { get; set; }

    public virtual DbSet<TkIssueTicket> TkIssueTickets { get; set; }

    public virtual DbSet<TkIssueTicketDetail> TkIssueTicketDetails { get; set; }

    public virtual DbSet<TkIssueTicketPhoto> TkIssueTicketPhotos { get; set; }

    public virtual DbSet<TkIssueTicketStatus> TkIssueTicketStatuses { get; set; }

    public virtual DbSet<TkIssueTicketType> TkIssueTicketTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
        }
    }

    private string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        var strConn = config["ConnectionStrings:DormiTechDB"];
        return strConn;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccDisciplineTicket>(entity =>
        {
            entity.HasKey(e => e.DisciplineTicketId).HasName("PK__ACC_Disc__588CD86471EAC9B4");

            entity.ToTable("ACC_DisciplineTicket");

            entity.Property(e => e.DisciplineTicketId)
                .ValueGeneratedNever()
                .HasColumnName("DisciplineTicketID");
            entity.Property(e => e.BillingId).HasColumnName("BillingID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Billing).WithMany(p => p.AccDisciplineTickets)
                .HasForeignKey(d => d.BillingId)
                .HasConstraintName("FK__ACC_Disci__Billi__65AC084E");

            entity.HasOne(d => d.Student).WithMany(p => p.AccDisciplineTickets)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__ACC_Disci__Stude__4BEC364B");

            entity.HasOne(d => d.Ticket).WithMany(p => p.AccDisciplineTickets)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK__ACC_Disci__Ticke__490FC9A0");

            entity.HasMany(d => d.PunishmentTypes).WithMany(p => p.Tickets)
                .UsingEntity<Dictionary<string, object>>(
                    "AccDisciplineTicketPunishment",
                    r => r.HasOne<GenPunishmentType>().WithMany()
                        .HasForeignKey("PunishmentTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ACC_Disci__Punis__4A03EDD9"),
                    l => l.HasOne<AccDisciplineTicket>().WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ACC_Disci__Ticke__4AF81212"),
                    j =>
                    {
                        j.HasKey("TicketId", "PunishmentTypeId").HasName("PK__ACC_Disc__8C4E5B9FC0FAF0E3");
                        j.ToTable("ACC_DisciplineTicketPunishment");
                        j.IndexerProperty<Guid>("TicketId").HasColumnName("TicketID");
                        j.IndexerProperty<int>("PunishmentTypeId").HasColumnName("PunishmentTypeID");
                    });
        });

        modelBuilder.Entity<AccDisciplineTicketDocument>(entity =>
        {
            entity.HasKey(e => new { e.DisciplineTicketId, e.OrderIndex }).HasName("PK__ACC_Disc__BC19B7735B0E5470");

            entity.ToTable("ACC_DisciplineTicketDocument");

            entity.Property(e => e.DisciplineTicketId).HasColumnName("DisciplineTicketID");
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.FileLink).HasMaxLength(1000);

            entity.HasOne(d => d.DisciplineTicket).WithMany(p => p.AccDisciplineTicketDocuments)
                .HasForeignKey(d => d.DisciplineTicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_Disci__Disci__5A3A55A2");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.AccDisciplineTicketDocuments)
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("FK__ACC_Disci__Docum__538D5813");
        });

        modelBuilder.Entity<AccRoomApplicationDocument>(entity =>
        {
            entity.HasKey(e => new { e.OrderIndex, e.RequestId }).HasName("PK__ACC_Room__FA6C74666E726812");

            entity.ToTable("ACC_RoomApplicationDocument");

            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.FileLink).HasMaxLength(1000);
            entity.Property(e => e.StatusChangedOn).HasColumnType("datetime");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.AccRoomApplicationDocuments)
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("FK__ACC_RoomA__Docum__4727812E");

            entity.HasOne(d => d.Request).WithMany(p => p.AccRoomApplicationDocuments)
                .HasForeignKey(d => d.RequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomA__Reque__416EA7D8");
        });

        modelBuilder.Entity<AccRoomMonthly>(entity =>
        {
            entity.HasKey(e => new { e.RoomId, e.Month, e.Year }).HasName("PK__ACC_Room__49FBCE6F6269676A");

            entity.ToTable("ACC_RoomMonthly");

            entity.HasIndex(e => e.AccRoomId, "UQ__ACC_Room__FCBE09E9D9F1892C").IsUnique();

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.AccRoomId)
                .IsRequired()
                .HasColumnName("AccRoomID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ElectricityAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ElectricityUnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Note).HasMaxLength(300);
            entity.Property(e => e.PricePerStudent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServiceFee).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WaterAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WaterUnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Room).WithMany(p => p.AccRoomMonthlies)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomM__RoomI__54817C4C");
        });

        modelBuilder.Entity<AccRoomRealTime>(entity =>
        {
            entity.HasKey(e => new { e.RoomId, e.StudentId }).HasName("PK__ACC_Room__B1AA6BBE30200098");

            entity.ToTable("ACC_RoomRealTime");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Note).HasMaxLength(300);

            entity.HasOne(d => d.Room).WithMany(p => p.AccRoomRealTimes)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomR__RoomI__37E53D9E");

            entity.HasOne(d => d.Student).WithMany(p => p.AccRoomRealTimes)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomR__Stude__3BB5CE82");
        });

        modelBuilder.Entity<AccRoomRequest>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PK__ACC_Room__33A8519A7D5F7B87");

            entity.ToTable("ACC_RoomRequest");

            entity.Property(e => e.RequestId)
                .ValueGeneratedNever()
                .HasColumnName("RequestID");
            entity.Property(e => e.AppliedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployerNote).HasMaxLength(300);
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
            entity.Property(e => e.StatusChangedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentNote).HasMaxLength(300);

            entity.HasOne(d => d.AppliedByNavigation).WithMany(p => p.AccRoomRequestAppliedByNavigations)
                .HasForeignKey(d => d.AppliedBy)
                .HasConstraintName("FK__ACC_RoomR__Appli__453F38BC");

            entity.HasOne(d => d.RoomType).WithMany(p => p.AccRoomRequests)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK__ACC_RoomR__RoomT__3E923B2D");

            entity.HasOne(d => d.StatusChangedByNavigation).WithMany(p => p.AccRoomRequestStatusChangedByNavigations)
                .HasForeignKey(d => d.StatusChangedBy)
                .HasConstraintName("FK__ACC_RoomR__Statu__3F865F66");
        });

        modelBuilder.Entity<AccRoomStudentMonthly>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.AccRoomId }).HasName("PK__ACC_Room__AD0ECAE7B7CA1FB9");

            entity.ToTable("ACC_RoomStudentMonthly");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.AccRoomId).HasColumnName("AccRoomID");
            entity.Property(e => e.BillingId).HasColumnName("BillingID");

            entity.HasOne(d => d.AccRoom).WithMany(p => p.AccRoomStudentMonthlies)
                .HasPrincipalKey(p => p.AccRoomId)
                .HasForeignKey(d => d.AccRoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomS__AccRo__62CF9BA3");

            entity.HasOne(d => d.Billing).WithMany(p => p.AccRoomStudentMonthlies)
                .HasForeignKey(d => d.BillingId)
                .HasConstraintName("FK__ACC_RoomS__Billi__64B7E415");

            entity.HasOne(d => d.Student).WithMany(p => p.AccRoomStudentMonthlies)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomS__Stude__61DB776A");
        });

        modelBuilder.Entity<BilBilling>(entity =>
        {
            entity.HasKey(e => e.BillingId).HasName("PK__BIL_Bill__F1656D131012691C");

            entity.ToTable("BIL_Billing");

            entity.Property(e => e.BillingId)
                .ValueGeneratedNever()
                .HasColumnName("BillingID");
            entity.Property(e => e.BillTypeId).HasColumnName("BillTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(1);
            entity.Property(e => e.PaidOn).HasColumnType("datetime");
            entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");
            entity.Property(e => e.PaymentDeadline).HasColumnType("datetime");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");

            entity.HasOne(d => d.BillType).WithMany(p => p.BilBillings)
                .HasForeignKey(d => d.BillTypeId)
                .HasConstraintName("FK__BIL_Billi__BillT__5575A085");

            entity.HasOne(d => d.PayType).WithMany(p => p.BilBillings)
                .HasForeignKey(d => d.PayTypeId)
                .HasConstraintName("FK__BIL_Billi__PayTy__5D16C24D");

            entity.HasOne(d => d.Student).WithMany(p => p.BilBillingStudents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__BIL_Billi__Stude__3CA9F2BB");

            entity.HasOne(d => d.VerifiedByNavigation).WithMany(p => p.BilBillingVerifiedByNavigations)
                .HasForeignKey(d => d.VerifiedBy)
                .HasConstraintName("FK__BIL_Billi__Verif__59463169");
        });

        modelBuilder.Entity<FacBuilding>(entity =>
        {
            entity.HasKey(e => e.BuildingId).HasName("PK__FAC_Buil__5463CDE43414F1AA");

            entity.ToTable("FAC_Building");

            entity.Property(e => e.BuildingId)
                .ValueGeneratedNever()
                .HasColumnName("BuildingID");
            entity.Property(e => e.BuildingDescription).HasMaxLength(500);
            entity.Property(e => e.BuildingName).HasMaxLength(200);
        });

        modelBuilder.Entity<FacItem>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__FAC_Item__727E83EBEDB45555");

            entity.ToTable("FAC_Item");

            entity.Property(e => e.ItemId)
                .ValueGeneratedNever()
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<FacRoom>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__FAC_Room__328639196364B3A3");

            entity.ToTable("FAC_Room");

            entity.Property(e => e.RoomId)
                .ValueGeneratedNever()
                .HasColumnName("RoomID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

            entity.HasOne(d => d.Building).WithMany(p => p.FacRooms)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK__FAC_Room__Buildi__39CD8610");

            entity.HasOne(d => d.RoomStatusNavigation).WithMany(p => p.FacRooms)
                .HasForeignKey(d => d.RoomStatus)
                .HasConstraintName("FK__FAC_Room__RoomSt__5669C4BE");

            entity.HasOne(d => d.RoomType).WithMany(p => p.FacRooms)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK__FAC_Room__RoomTy__38D961D7");
        });

        modelBuilder.Entity<FacRoomItem>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__FAC_Room__32863919E2436D8F");

            entity.ToTable("FAC_RoomItem");

            entity.Property(e => e.RoomId)
                .ValueGeneratedNever()
                .HasColumnName("RoomID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Item).WithMany(p => p.FacRoomItems)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__FAC_RoomI__ItemI__3508D0F3");

            entity.HasOne(d => d.Room).WithOne(p => p.FacRoomItem)
                .HasForeignKey<FacRoomItem>(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FAC_RoomI__RoomI__3AC1AA49");
        });

        modelBuilder.Entity<GenAmenity>(entity =>
        {
            entity.HasKey(e => e.AmenityId).HasName("PK__GEN_Amen__842AF52B67051004");

            entity.ToTable("GEN_Amenity");

            entity.Property(e => e.AmenityId)
                .ValueGeneratedNever()
                .HasColumnName("AmenityID");
            entity.Property(e => e.AmenityName).HasMaxLength(200);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<GenBillType>(entity =>
        {
            entity.HasKey(e => e.BillTypeId).HasName("PK__GEN_Bill__42D50723F145A907");

            entity.ToTable("GEN_BillType");

            entity.Property(e => e.BillTypeId)
                .ValueGeneratedNever()
                .HasColumnName("BillTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenDistanceType>(entity =>
        {
            entity.HasKey(e => e.DistanceTypeId).HasName("PK__GEN_Dist__B0EA8BB1AA104DA5");

            entity.ToTable("GEN_DistanceType");

            entity.Property(e => e.DistanceTypeId)
                .ValueGeneratedNever()
                .HasColumnName("DistanceTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId).HasName("PK__GEN_Dist__85FDA4A6CA1DD7F5");

            entity.ToTable("GEN_District");

            entity.Property(e => e.DistrictId)
                .ValueGeneratedNever()
                .HasColumnName("DistrictID");
            entity.Property(e => e.DistrictName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__GEN_Docu__1ABEEF6FAECAD577");

            entity.ToTable("GEN_Document");

            entity.Property(e => e.DocumentId)
                .ValueGeneratedNever()
                .HasColumnName("DocumentID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DocumentName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__GEN_Empl__7AD04FF185452445");

            entity.ToTable("GEN_Employee");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployeeName).HasMaxLength(20);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.PositionId).HasColumnName("PositionID");

            entity.HasOne(d => d.Position).WithMany(p => p.GenEmployees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK__GEN_Emplo__Posit__575DE8F7");
        });

        modelBuilder.Entity<GenEmployeePosition>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("PK__GEN_Empl__60BB9A592202F4B2");

            entity.ToTable("GEN_EmployeePosition");

            entity.Property(e => e.PositionId)
                .ValueGeneratedNever()
                .HasColumnName("PositionID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PositionName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenEthnicity>(entity =>
        {
            entity.HasKey(e => e.EthnicityId).HasName("PK__GEN_Ethn__A243ECE0716DB412");

            entity.ToTable("GEN_Ethnicity");

            entity.Property(e => e.EthnicityId)
                .ValueGeneratedNever()
                .HasColumnName("EthnicityID");
            entity.Property(e => e.EthnicityName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenItemStatus>(entity =>
        {
            entity.HasKey(e => e.ItemStatusId).HasName("PK__GEN_Item__80C77583293C3AD9");

            entity.ToTable("GEN_ItemStatus");

            entity.Property(e => e.ItemStatusId)
                .ValueGeneratedNever()
                .HasColumnName("ItemStatusID");
            entity.Property(e => e.StatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenModuleType>(entity =>
        {
            entity.HasKey(e => e.ModuleTypeId).HasName("PK__GEN_Modu__5EBC4F2C82CABDD0");

            entity.ToTable("GEN_ModuleType");

            entity.Property(e => e.ModuleTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ModuleTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ModuleName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenPayType>(entity =>
        {
            entity.HasKey(e => e.PayTypeId).HasName("PK__GEN_PayT__4CA963B2A77E1B08");

            entity.ToTable("GEN_PayType");

            entity.Property(e => e.PayTypeId)
                .ValueGeneratedNever()
                .HasColumnName("PayTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceId).HasName("PK__GEN_Prov__FD0A6FA3B716A86F");

            entity.ToTable("GEN_Province");

            entity.Property(e => e.ProvinceId)
                .ValueGeneratedNever()
                .HasColumnName("ProvinceID");
            entity.Property(e => e.ProvinceName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenPunishmentType>(entity =>
        {
            entity.HasKey(e => e.PunishmentTypeId).HasName("PK__GEN_Puni__D629DB8E40618127");

            entity.ToTable("GEN_PunishmentType");

            entity.Property(e => e.PunishmentTypeId)
                .ValueGeneratedNever()
                .HasColumnName("PunishmentTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PunishmentName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenRoomStatus>(entity =>
        {
            entity.HasKey(e => e.RoomStatusId).HasName("PK__GEN_Room__D29DF53648F5F429");

            entity.ToTable("GEN_RoomStatus");

            entity.Property(e => e.RoomStatusId)
                .ValueGeneratedNever()
                .HasColumnName("RoomStatusID");
            entity.Property(e => e.StatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenRoomType>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK__GEN_Room__BCC8961195927AE0");

            entity.ToTable("GEN_RoomType");

            entity.Property(e => e.RoomTypeId)
                .ValueGeneratedNever()
                .HasColumnName("RoomTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PricePerStudent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TypeName).HasMaxLength(200);

            entity.HasMany(d => d.Amenities).WithMany(p => p.RoomTypes)
                .UsingEntity<Dictionary<string, object>>(
                    "FacRoomAmenity",
                    r => r.HasOne<GenAmenity>().WithMany()
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__FAC_RoomA__Ameni__3414ACBA"),
                    l => l.HasOne<GenRoomType>().WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__FAC_RoomA__RoomT__407A839F"),
                    j =>
                    {
                        j.HasKey("RoomTypeId", "AmenityId").HasName("PK__FAC_Room__148A394368928C17");
                        j.ToTable("FAC_RoomAmenity");
                        j.IndexerProperty<int>("RoomTypeId").HasColumnName("RoomTypeID");
                        j.IndexerProperty<int>("AmenityId").HasColumnName("AmenityID");
                    });
        });

        modelBuilder.Entity<GenService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__GEN_Serv__C51BB0EAE1DB4E78");

            entity.ToTable("GEN_Service");

            entity.Property(e => e.ServiceId)
                .ValueGeneratedNever()
                .HasColumnName("ServiceID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ServiceName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenServicePricing>(entity =>
        {
            entity.HasKey(e => new { e.ServiceId, e.MaxRoomCapacity, e.MaxUnitCount })
                .HasName("PK__GEN_Serv__578C642EF80B27DD");

            entity.ToTable("GEN_ServicePricing");

            entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            entity.Property(e => e.MaxUnitCount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Service).WithMany(p => p.GenServicePricings)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GEN_Servi__Servi__63C3BFDC");
        });

        modelBuilder.Entity<GenSocialStatusType>(entity =>
        {
            entity.HasKey(e => e.SocialTypeId).HasName("PK__GEN_Soci__A4609E91EF40AA7C");

            entity.ToTable("GEN_SocialStatusType");

            entity.Property(e => e.SocialTypeId)
                .ValueGeneratedNever()
                .HasColumnName("SocialTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PrimaryPaytypeId).HasColumnName("PrimaryPaytypeID");
            entity.Property(e => e.TypeName).HasMaxLength(200);

            entity.HasOne(d => d.PrimaryPaytype).WithMany(p => p.GenSocialStatusTypes)
                .HasForeignKey(d => d.PrimaryPaytypeId)
                .HasConstraintName("FK__GEN_Socia__Prima__58520D30");
        });

        modelBuilder.Entity<GenStudent>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__GEN_Stud__32C52A7999C585E0");

            entity.ToTable("GEN_Student");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("StudentID");
            entity.Property(e => e.Address).HasMaxLength(1);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DistanceTypeId).HasColumnName("DistanceTypeID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.DoB).HasColumnType("date");
            entity.Property(e => e.EnrolledOn).HasColumnType("date");
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.MajorName).HasMaxLength(20);
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.SocialTypeId).HasColumnName("SocialTypeID");
            entity.Property(e => e.StudentName).HasMaxLength(20);
            entity.Property(e => e.WardId).HasColumnName("WardID");

            entity.HasOne(d => d.DistanceType).WithMany(p => p.GenStudents)
                .HasForeignKey(d => d.DistanceTypeId)
                .HasConstraintName("FK__GEN_Stude__Dista__5E0AE686");

            entity.HasOne(d => d.District).WithMany(p => p.GenStudents)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK__GEN_Stude__Distr__60E75331");

            entity.HasOne(d => d.EthnicityNavigation).WithMany(p => p.GenStudents)
                .HasForeignKey(d => d.Ethnicity)
                .HasConstraintName("FK__GEN_Stude__Ethni__5C229E14");

            entity.HasOne(d => d.Province).WithMany(p => p.GenStudents)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK__GEN_Stude__Provi__5EFF0ABF");

            entity.HasOne(d => d.SocialType).WithMany(p => p.GenStudents)
                .HasForeignKey(d => d.SocialTypeId)
                .HasConstraintName("FK__GEN_Stude__Socia__5B2E79DB");

            entity.HasOne(d => d.Ward).WithMany(p => p.GenStudents)
                .HasForeignKey(d => d.WardId)
                .HasConstraintName("FK__GEN_Stude__WardI__5FF32EF8");
        });

        modelBuilder.Entity<GenWard>(entity =>
        {
            entity.HasKey(e => e.WardId).HasName("PK__GEN_Ward__C6BD9BEACFD43B67");

            entity.ToTable("GEN_Ward");

            entity.Property(e => e.WardId)
                .ValueGeneratedNever()
                .HasColumnName("WardID");
            entity.Property(e => e.WardName).HasMaxLength(200);
        });

        modelBuilder.Entity<HisItemMaintenance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HIS_ItemMaintenance");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.MaintenanceFee).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReportedAt).HasColumnType("datetime");
            entity.Property(e => e.ResolvedAt).HasColumnType("datetime");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Item).WithMany()
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__HIS_ItemM__ItemI__4EC8A2F6");

            entity.HasOne(d => d.ItemStatusAfterNavigation).WithMany()
                .HasForeignKey(d => d.ItemStatusAfter)
                .HasConstraintName("FK__HIS_ItemM__ItemS__50B0EB68");

            entity.HasOne(d => d.ItemStatusBeforeNavigation).WithMany()
                .HasForeignKey(d => d.ItemStatusBefore)
                .HasConstraintName("FK__HIS_ItemM__ItemS__4DD47EBD");

            entity.HasOne(d => d.ReportedByNavigation).WithMany()
                .HasForeignKey(d => d.ReportedBy)
                .HasConstraintName("FK__HIS_ItemM__Repor__51A50FA1");

            entity.HasOne(d => d.ResolvedByNavigation).WithMany()
                .HasForeignKey(d => d.ResolvedBy)
                .HasConstraintName("FK__HIS_ItemM__Resol__529933DA");

            entity.HasOne(d => d.Ticket).WithMany()
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK__HIS_ItemM__Ticke__4FBCC72F");
        });

        modelBuilder.Entity<LogRoomApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOG_RoomApplication");

            entity.Property(e => e.LogNote).HasMaxLength(200);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.StatusChangedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Request).WithMany()
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK__LOG_RoomA__Reque__4262CC11");
        });

        modelBuilder.Entity<SysAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__SYS_Acco__349DA5860AFD6742");

            entity.ToTable("SYS_Account");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("AccountID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
        });

        modelBuilder.Entity<SysDocumentSetUp>(entity =>
        {
            entity.HasKey(e => new { e.DocumentTypeId, e.ModuleTypeId }).HasName("PK__SYS_Docu__0E485433BD6D29CD");

            entity.ToTable("SYS_DocumentSetUp");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.ModuleTypeId).HasColumnName("ModuleTypeID");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.SysDocumentSetUps)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SYS_Docum__Docum__481BA567");

            entity.HasOne(d => d.ModuleType).WithMany(p => p.SysDocumentSetUps)
                .HasForeignKey(d => d.ModuleTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SYS_Docum__Modul__46335CF5");
        });

        modelBuilder.Entity<SysPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__SYS_Perm__EFA6FB0F434F8D8E");

            entity.ToTable("SYS_Permission");

            entity.Property(e => e.PermissionId)
                .ValueGeneratedNever()
                .HasColumnName("PermissionID");
            entity.Property(e => e.PermissionName).HasMaxLength(200);
        });

        modelBuilder.Entity<SysRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__SYS_Role__8AFACE3A7EDA9472");

            entity.ToTable("SYS_Role");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(200);

            entity.HasMany(d => d.Accounts).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "SysAccountRole",
                    r => r.HasOne<SysAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SYS_Accou__Accou__29971E47"),
                    l => l.HasOne<SysRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SYS_Accou__RoleI__2A8B4280"),
                    j =>
                    {
                        j.HasKey("RoleId", "AccountId").HasName("PK__SYS_Acco__F9B31462D0BBBB6D");
                        j.ToTable("SYS_AccountRole");
                        j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");
                        j.IndexerProperty<Guid>("AccountId").HasColumnName("AccountID");
                    });

            entity.HasMany(d => d.Permissions).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "SysRolePermission",
                    r => r.HasOne<SysPermission>().WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SYS_RoleP__Permi__2C738AF2"),
                    l => l.HasOne<SysRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SYS_RoleP__RoleI__2B7F66B9"),
                    j =>
                    {
                        j.HasKey("RoleId", "PermissionId").HasName("PK__SYS_Role__6400A18AFC366A07");
                        j.ToTable("SYS_RolePermission");
                        j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");
                        j.IndexerProperty<Guid>("PermissionId").HasColumnName("PermissionID");
                    });
        });

        modelBuilder.Entity<TkIssueTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__TK_Issue__712CC62751011FED");

            entity.ToTable("TK_IssueTicket");

            entity.Property(e => e.TicketId)
                .ValueGeneratedNever()
                .HasColumnName("TicketID");
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.Content).HasMaxLength(1000);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Header).HasMaxLength(300);
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.TicketStatusId).HasColumnName("TicketStatusID");
            entity.Property(e => e.TicketTypeId).HasColumnName("TicketTypeID");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.TkIssueTicketApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK__TK_IssueT__Appro__3D9E16F4");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TkIssueTicketCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__TK_IssueT__Creat__30441BD6");

            entity.HasOne(d => d.Room).WithMany(p => p.TkIssueTickets)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__TK_IssueT__RoomI__4CE05A84");

            entity.HasOne(d => d.TicketStatus).WithMany(p => p.TkIssueTickets)
                .HasForeignKey(d => d.TicketStatusId)
                .HasConstraintName("FK__TK_IssueT__Ticke__2F4FF79D");

            entity.HasOne(d => d.TicketType).WithMany(p => p.TkIssueTickets)
                .HasForeignKey(d => d.TicketTypeId)
                .HasConstraintName("FK__TK_IssueT__Ticke__2D67AF2B");

            entity.HasMany(d => d.Students).WithMany(p => p.Tickets)
                .UsingEntity<Dictionary<string, object>>(
                    "TkIssueTicketStudent",
                    r => r.HasOne<GenStudent>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__TK_IssueT__Stude__33208881"),
                    l => l.HasOne<TkIssueTicket>().WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__TK_IssueT__Ticke__322C6448"),
                    j =>
                    {
                        j.HasKey("TicketId", "StudentId").HasName("PK__TK_Issue__F2009480212E7B42");
                        j.ToTable("TK_IssueTicketStudent");
                        j.IndexerProperty<Guid>("TicketId").HasColumnName("TicketID");
                        j.IndexerProperty<Guid>("StudentId").HasColumnName("StudentID");
                    });
        });

        modelBuilder.Entity<TkIssueTicketDetail>(entity =>
        {
            entity.HasKey(e => new { e.TicketId, e.OrderIndex }).HasName("PK__TK_Issue__95B9A9304E2938E1");

            entity.ToTable("TK_IssueTicketDetails");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemStatusId).HasColumnName("ItemStatusID");

            entity.HasOne(d => d.Item).WithMany(p => p.TkIssueTicketDetails)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__TK_IssueT__ItemI__36F11965");

            entity.HasOne(d => d.ItemStatus).WithMany(p => p.TkIssueTicketDetails)
                .HasForeignKey(d => d.ItemStatusId)
                .HasConstraintName("FK__TK_IssueT__ItemS__35FCF52C");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TkIssueTicketDetails)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TK_IssueT__Ticke__3138400F");
        });

        modelBuilder.Entity<TkIssueTicketPhoto>(entity =>
        {
            entity.HasKey(e => new { e.TicketId, e.PhotoIndex }).HasName("PK__TK_Issue__58E036EF0209C189");

            entity.ToTable("TK_IssueTicketPhoto");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.PhotoLink).HasMaxLength(1000);

            entity.HasOne(d => d.Ticket).WithMany(p => p.TkIssueTicketPhotos)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TK_IssueT__Ticke__2E5BD364");
        });

        modelBuilder.Entity<TkIssueTicketStatus>(entity =>
        {
            entity.HasKey(e => e.TicketStatusId).HasName("PK__TK_Issue__76E509E1D50ABF9C");

            entity.ToTable("TK_IssueTicketStatus");

            entity.Property(e => e.TicketStatusId)
                .ValueGeneratedNever()
                .HasColumnName("TicketStatusID");
            entity.Property(e => e.StatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<TkIssueTicketType>(entity =>
        {
            entity.HasKey(e => e.TicketTypeId).HasName("PK__TK_Issue__6CD68451D653A159");

            entity.ToTable("TK_IssueTicketType");

            entity.Property(e => e.TicketTypeId)
                .ValueGeneratedNever()
                .HasColumnName("TicketTypeID");
            entity.Property(e => e.TypeName).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}