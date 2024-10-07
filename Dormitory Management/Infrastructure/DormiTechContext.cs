using System;
using System.Collections.Generic;
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

    public virtual DbSet<AccDisciplineTicketPunishment> AccDisciplineTicketPunishments { get; set; }

    public virtual DbSet<AccMonthlyConsumption> AccMonthlyConsumptions { get; set; }

    public virtual DbSet<AccMonthlyRoomBill> AccMonthlyRoomBills { get; set; }

    public virtual DbSet<AccRoomApplication> AccRoomApplications { get; set; }

    public virtual DbSet<AccRoomApplicationDocument> AccRoomApplicationDocuments { get; set; }

    public virtual DbSet<AccRoomMonthly> AccRoomMonthlies { get; set; }

    public virtual DbSet<AccRoomRealTime> AccRoomRealTimes { get; set; }

    public virtual DbSet<BilBilling> BilBillings { get; set; }

    public virtual DbSet<FacBuilding> FacBuildings { get; set; }

    public virtual DbSet<FacItem> FacItems { get; set; }

    public virtual DbSet<FacRoom> FacRooms { get; set; }

    public virtual DbSet<FacRoomItem> FacRoomItems { get; set; }

    public virtual DbSet<GenAmenity> GenAmenities { get; set; }

    public virtual DbSet<GenBillType> GenBillTypes { get; set; }

    public virtual DbSet<GenDocument> GenDocuments { get; set; }

    public virtual DbSet<GenEmployee> GenEmployees { get; set; }

    public virtual DbSet<GenEmployeePosition> GenEmployeePositions { get; set; }

    public virtual DbSet<GenEthnicity> GenEthnicities { get; set; }

    public virtual DbSet<GenItemStatus> GenItemStatuses { get; set; }

    public virtual DbSet<GenModuleType> GenModuleTypes { get; set; }

    public virtual DbSet<GenPayType> GenPayTypes { get; set; }

    public virtual DbSet<GenPunishmentType> GenPunishmentTypes { get; set; }

    public virtual DbSet<GenRoomStatus> GenRoomStatuses { get; set; }

    public virtual DbSet<GenRoomType> GenRoomTypes { get; set; }

    public virtual DbSet<GenSocialStatusType> GenSocialStatusTypes { get; set; }

    public virtual DbSet<GenStudent> GenStudents { get; set; }

    public virtual DbSet<GenWaterPricing> GenWaterPricings { get; set; }

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

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=.\\NHHAO;Database=DormiTech;uid=sa;pwd=123456789;trustServerCertificate=true");

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
            entity.HasKey(e => new { e.TicketId, e.StudentId }).HasName("PK__ACC_Disc__F2009480A28121AA");

            entity.ToTable("ACC_DisciplineTicket");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(16, 2)");

            entity.HasOne(d => d.Student).WithMany(p => p.AccDisciplineTickets)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_Disci__Stude__04E4BC85");

            entity.HasOne(d => d.Ticket).WithMany(p => p.AccDisciplineTickets)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_Disci__Ticke__05D8E0BE");
        });

        modelBuilder.Entity<AccDisciplineTicketDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACC_DisciplineTicketDocument");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.DocumentType).WithMany()
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("FK__ACC_Disci__Docum__06CD04F7");
        });

        modelBuilder.Entity<AccDisciplineTicketPunishment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACC_DisciplineTicketPunishment");

            entity.Property(e => e.PunishmentTypeId).HasColumnName("PunishmentTypeID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.PunishmentType).WithMany()
                .HasForeignKey(d => d.PunishmentTypeId)
                .HasConstraintName("FK_ACC_DisciplineTicketPunishment_GEN_PunishmentType");

            entity.HasOne(d => d.Ticket).WithMany()
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK_ACC_DisciplineTicketPunishment_TK_IssueTicket");
        });

        modelBuilder.Entity<AccMonthlyConsumption>(entity =>
        {
            entity.HasKey(e => new { e.RoomId, e.Month, e.Year }).HasName("PK__ACC_Mont__49FBCE6F26EE095C");

            entity.ToTable("ACC_MonthlyConsumption");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ElectricityAmount).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.ElectricityUnitPrice).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.ServiceFee).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.WaterAmount).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.WaterUnitPrice).HasColumnType("decimal(16, 2)");

            entity.HasOne(d => d.Room).WithMany(p => p.AccMonthlyConsumptions)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_Month__RoomI__09A971A2");
        });

        modelBuilder.Entity<AccMonthlyRoomBill>(entity =>
        {
            entity.HasKey(e => new { e.RoomId, e.Month, e.Year }).HasName("PK__ACC_Mont__49FBCE6F71DCD684");

            entity.ToTable("ACC_MonthlyRoomBill");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PricePerStudent).HasColumnType("decimal(16, 2)");

            entity.HasOne(d => d.Room).WithMany(p => p.AccMonthlyRoomBills)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_Month__RoomI__0A9D95DB");
        });

        modelBuilder.Entity<AccRoomApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PK__ACC_Room__C93A4F7900005892");

            entity.ToTable("ACC_RoomApplication");

            entity.Property(e => e.ApplicationId)
                .ValueGeneratedNever()
                .HasColumnName("ApplicationID");
            entity.Property(e => e.AppliedOn).HasColumnType("datetime");
            entity.Property(e => e.EmployerNote).HasMaxLength(200);
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");
            entity.Property(e => e.StatusChangedOn).HasColumnType("datetime");
            entity.Property(e => e.StudentNote).HasMaxLength(200);

            entity.HasOne(d => d.AppliedByNavigation).WithMany(p => p.AccRoomApplicationAppliedByNavigations)
                .HasForeignKey(d => d.AppliedBy)
                .HasConstraintName("FK__ACC_RoomA__Appli__0B91BA14");

            entity.HasOne(d => d.RoomType).WithMany(p => p.AccRoomApplications)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK__ACC_RoomA__RoomT__0C85DE4D");

            entity.HasOne(d => d.StatusChangedByNavigation).WithMany(p => p.AccRoomApplicationStatusChangedByNavigations)
                .HasForeignKey(d => d.StatusChangedBy)
                .HasConstraintName("FK__ACC_RoomA__Statu__0D7A0286");
        });

        modelBuilder.Entity<AccRoomApplicationDocument>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.OrderIndex }).HasName("PK__ACC_Room__2DAF206EA343B839");

            entity.ToTable("ACC_RoomApplicationDocument");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.StatusChangedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Application).WithMany(p => p.AccRoomApplicationDocuments)
                .HasForeignKey(d => d.ApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomA__Appli__0E6E26BF");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.AccRoomApplicationDocuments)
                .HasForeignKey(d => d.DocumentTypeId)
                .HasConstraintName("FK__ACC_RoomA__Docum__0F624AF8");
        });

        modelBuilder.Entity<AccRoomMonthly>(entity =>
        {
            entity.HasKey(e => new { e.RoomId, e.StudentId, e.Month, e.Year }).HasName("PK__ACC_Room__D61DB4C9E1BE0B0B");

            entity.ToTable("ACC_RoomMonthly");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Note).HasMaxLength(200);

            entity.HasOne(d => d.Room).WithMany(p => p.AccRoomMonthlies)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomM__RoomI__10566F31");

            entity.HasOne(d => d.Student).WithMany(p => p.AccRoomMonthlies)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomM__Stude__114A936A");
        });

        modelBuilder.Entity<AccRoomRealTime>(entity =>
        {
            entity.HasKey(e => new { e.RoomId, e.StudentId }).HasName("PK__ACC_Room__B1AA6BBE860C6B63");

            entity.ToTable("ACC_RoomRealTime");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Note).HasMaxLength(200);

            entity.HasOne(d => d.Room).WithMany(p => p.AccRoomRealTimes)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomR__RoomI__123EB7A3");

            entity.HasOne(d => d.Student).WithMany(p => p.AccRoomRealTimes)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ACC_RoomR__Stude__1332DBDC");
        });

        modelBuilder.Entity<BilBilling>(entity =>
        {
            entity.HasKey(e => e.BillingId).HasName("PK__BIL_Bill__F1656D13D264C5E6");

            entity.ToTable("BIL_Billing");

            entity.Property(e => e.BillingId)
                .ValueGeneratedNever()
                .HasColumnName("BillingID");
            entity.Property(e => e.BillTypeId).HasColumnName("BillTypeID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.PaidOn).HasColumnType("datetime");
            entity.Property(e => e.PayTypeId).HasColumnName("PayTypeID");
            entity.Property(e => e.PaymentDeadline).HasColumnType("datetime");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.BillType).WithMany(p => p.BilBillings)
                .HasForeignKey(d => d.BillTypeId)
                .HasConstraintName("FK__BIL_Billi__BillT__14270015");

            entity.HasOne(d => d.Room).WithMany(p => p.BilBillings)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__BIL_Billi__RoomI__151B244E");

            entity.HasOne(d => d.Student).WithMany(p => p.BilBillingStudents)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__BIL_Billi__Stude__160F4887");

            entity.HasOne(d => d.VerifiedByNavigation).WithMany(p => p.BilBillingVerifiedByNavigations)
                .HasForeignKey(d => d.VerifiedBy)
                .HasConstraintName("FK__BIL_Billi__Verif__17036CC0");
        });

        modelBuilder.Entity<FacBuilding>(entity =>
        {
            entity.HasKey(e => e.BuildingId).HasName("PK__FAC_Buil__5463CDE4A73023E7");

            entity.ToTable("FAC_Building");

            entity.Property(e => e.BuildingId)
                .ValueGeneratedNever()
                .HasColumnName("BuildingID");
            entity.Property(e => e.BuildingName).HasMaxLength(200);
        });

        modelBuilder.Entity<FacItem>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__FAC_Item__727E83EBA1EB58A6");

            entity.ToTable("FAC_Item");

            entity.Property(e => e.ItemId)
                .ValueGeneratedNever()
                .HasColumnName("ItemID");
            entity.Property(e => e.ItemName).HasMaxLength(200);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
        });

        modelBuilder.Entity<FacRoom>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__FAC_Room__32863919E1F3C552");

            entity.ToTable("FAC_Room");

            entity.Property(e => e.RoomId)
                .ValueGeneratedNever()
                .HasColumnName("RoomID");
            entity.Property(e => e.BuildingId).HasColumnName("BuildingID");
            entity.Property(e => e.RoomTypeId).HasColumnName("RoomTypeID");

            entity.HasOne(d => d.Building).WithMany(p => p.FacRooms)
                .HasForeignKey(d => d.BuildingId)
                .HasConstraintName("FK__FAC_Room__Buildi__17F790F9");

            entity.HasOne(d => d.RoomStatusNavigation).WithMany(p => p.FacRooms)
                .HasForeignKey(d => d.RoomStatus)
                .HasConstraintName("FK__FAC_Room__RoomSt__18EBB532");

            entity.HasOne(d => d.RoomType).WithMany(p => p.FacRooms)
                .HasForeignKey(d => d.RoomTypeId)
                .HasConstraintName("FK__FAC_Room__RoomTy__19DFD96B");
        });

        modelBuilder.Entity<FacRoomItem>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__FAC_Room__32863919D1E66A4F");

            entity.ToTable("FAC_RoomItem");

            entity.Property(e => e.RoomId)
                .ValueGeneratedNever()
                .HasColumnName("RoomID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");

            entity.HasOne(d => d.Item).WithMany(p => p.FacRoomItems)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__FAC_RoomI__ItemI__1CBC4616");

            entity.HasOne(d => d.Room).WithOne(p => p.FacRoomItem)
                .HasForeignKey<FacRoomItem>(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__FAC_RoomI__RoomI__1DB06A4F");
        });

        modelBuilder.Entity<GenAmenity>(entity =>
        {
            entity.HasKey(e => e.AmenityId).HasName("PK__GEN_Amen__842AF52BA79FE54B");

            entity.ToTable("GEN_Amenity");

            entity.Property(e => e.AmenityId)
                .ValueGeneratedNever()
                .HasColumnName("AmenityID");
            entity.Property(e => e.AmenityName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenBillType>(entity =>
        {
            entity.HasKey(e => e.BillTypeId).HasName("PK__GEN_Bill__42D507232B203607");

            entity.ToTable("GEN_BillType");

            entity.Property(e => e.BillTypeId)
                .ValueGeneratedNever()
                .HasColumnName("BillTypeID");
            entity.Property(e => e.TypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PK__GEN_Docu__1ABEEF6F8167D6F7");

            entity.ToTable("GEN_Document");

            entity.Property(e => e.DocumentId)
                .ValueGeneratedNever()
                .HasColumnName("DocumentID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DocumentName).HasMaxLength(500);
        });

        modelBuilder.Entity<GenEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__GEN_Empl__7AD04FF16AACB1F9");

            entity.ToTable("GEN_Employee");

            entity.Property(e => e.EmployeeId)
                .ValueGeneratedNever()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeCode).HasMaxLength(20);
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.PositionId).HasColumnName("PositionID");

            entity.HasOne(d => d.Position).WithMany(p => p.GenEmployees)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK__GEN_Emplo__Posit__1EA48E88");
        });

        modelBuilder.Entity<GenEmployeePosition>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("PK__GEN_Empl__60BB9A5966E9FF74");

            entity.ToTable("GEN_EmployeePosition");

            entity.Property(e => e.PositionId)
                .ValueGeneratedNever()
                .HasColumnName("PositionID");
            entity.Property(e => e.PositionName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenEthnicity>(entity =>
        {
            entity.HasKey(e => e.EthnicityId).HasName("PK__GEN_Ethn__A243ECE02B7F9FB1");

            entity.ToTable("GEN_Ethnicity");

            entity.Property(e => e.EthnicityId)
                .ValueGeneratedNever()
                .HasColumnName("EthnicityID");
            entity.Property(e => e.EthnicityName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenItemStatus>(entity =>
        {
            entity.HasKey(e => e.ItemStatusId).HasName("PK__GEN_Item__80C775837D38EA5C");

            entity.ToTable("GEN_ItemStatus");

            entity.Property(e => e.ItemStatusId)
                .ValueGeneratedNever()
                .HasColumnName("ItemStatusID");
            entity.Property(e => e.StatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenModuleType>(entity =>
        {
            entity.HasKey(e => e.ModuleTypeId).HasName("PK__GEN_Modu__5EBC4F2CEA2E8746");

            entity.ToTable("GEN_ModuleType");

            entity.Property(e => e.ModuleTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ModuleTypeID");
            entity.Property(e => e.ModuleName).HasMaxLength(500);
        });

        modelBuilder.Entity<GenPayType>(entity =>
        {
            entity.HasKey(e => e.PayTypeId).HasName("PK__GEN_PayT__4CA963B23A710812");

            entity.ToTable("GEN_PayType");

            entity.Property(e => e.PayTypeId)
                .ValueGeneratedNever()
                .HasColumnName("PayTypeID");
            entity.Property(e => e.TypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenPunishmentType>(entity =>
        {
            entity.HasKey(e => e.PunishmentTypeId);

            entity.ToTable("GEN_PunishmentType");

            entity.Property(e => e.PunishmentTypeId)
                .ValueGeneratedNever()
                .HasColumnName("PunishmentTypeID");
            entity.Property(e => e.PunishmentName).HasMaxLength(500);
        });

        modelBuilder.Entity<GenRoomStatus>(entity =>
        {
            entity.HasKey(e => e.RoomStatusId).HasName("PK__GEN_Room__D29DF536F886B908");

            entity.ToTable("GEN_RoomStatus");

            entity.Property(e => e.RoomStatusId)
                .ValueGeneratedNever()
                .HasColumnName("RoomStatusID");
            entity.Property(e => e.StatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<GenRoomType>(entity =>
        {
            entity.HasKey(e => e.RoomTypeId).HasName("PK__GEN_Room__BCC8961142A9839F");

            entity.ToTable("GEN_RoomType");

            entity.Property(e => e.RoomTypeId)
                .ValueGeneratedNever()
                .HasColumnName("RoomTypeID");
            entity.Property(e => e.PricePerStudent).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.TypeName).HasMaxLength(200);

            entity.HasMany(d => d.Amenities).WithMany(p => p.RoomTypes)
                .UsingEntity<Dictionary<string, object>>(
                    "FacRoomAmenity",
                    r => r.HasOne<GenAmenity>().WithMany()
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__FAC_RoomA__Ameni__1AD3FDA4"),
                    l => l.HasOne<GenRoomType>().WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__FAC_RoomA__RoomT__1BC821DD"),
                    j =>
                    {
                        j.HasKey("RoomTypeId", "AmenityId").HasName("PK__FAC_Room__148A3943B2F6A8D5");
                        j.ToTable("FAC_RoomAmenity");
                        j.IndexerProperty<int>("RoomTypeId").HasColumnName("RoomTypeID");
                        j.IndexerProperty<int>("AmenityId").HasColumnName("AmenityID");
                    });
        });

        modelBuilder.Entity<GenSocialStatusType>(entity =>
        {
            entity.HasKey(e => e.SocialTypeId).HasName("PK__GEN_Soci__A4609E919DC6181B");

            entity.ToTable("GEN_SocialStatusType");

            entity.Property(e => e.SocialTypeId)
                .ValueGeneratedNever()
                .HasColumnName("SocialTypeID");
            entity.Property(e => e.PrimaryPaytypeId).HasColumnName("PrimaryPaytypeID");
            entity.Property(e => e.TypeName).HasMaxLength(200);

            entity.HasOne(d => d.PrimaryPaytype).WithMany(p => p.GenSocialStatusTypes)
                .HasForeignKey(d => d.PrimaryPaytypeId)
                .HasConstraintName("FK__GEN_Socia__Prima__1F98B2C1");
        });

        modelBuilder.Entity<GenStudent>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__GEN_Stud__32C52A793A32F5E9");

            entity.ToTable("GEN_Student");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("StudentID");
            entity.Property(e => e.DistanceTypeId).HasColumnName("DistanceTypeID");
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.MajorId).HasColumnName("MajorID");
            entity.Property(e => e.SocialTypeId).HasColumnName("SocialTypeID");
            entity.Property(e => e.StudentCode).HasMaxLength(20);

            entity.HasOne(d => d.EthnicityNavigation).WithMany(p => p.GenStudents)
                .HasForeignKey(d => d.Ethnicity)
                .HasConstraintName("FK_GEN_Student_GEN_Ethnicity");

            entity.HasOne(d => d.SocialType).WithMany(p => p.GenStudents)
                .HasForeignKey(d => d.SocialTypeId)
                .HasConstraintName("FK_GEN_Student_GEN_SocialStatusType");

            entity.HasOne(d => d.Student).WithOne(p => p.GenStudent)
                .HasForeignKey<GenStudent>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GEN_Stude__Stude__208CD6FA");
        });

        modelBuilder.Entity<GenWaterPricing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GEN_WaterPricing");

            entity.Property(e => e.MaxUnitCount).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(16, 2)");
        });

        modelBuilder.Entity<HisItemMaintenance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HIS_ItemMaintenance");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.MaintenanceFee).HasColumnType("decimal(16, 2)");
            entity.Property(e => e.ReportedAt).HasColumnType("datetime");
            entity.Property(e => e.ResolvedAt).HasColumnType("datetime");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Item).WithMany()
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__HIS_ItemM__ItemI__236943A5");

            entity.HasOne(d => d.ItemStatusAfterNavigation).WithMany()
                .HasForeignKey(d => d.ItemStatusAfter)
                .HasConstraintName("FK__HIS_ItemM__ItemS__25518C17");

            entity.HasOne(d => d.ItemStatusBeforeNavigation).WithMany()
                .HasForeignKey(d => d.ItemStatusBefore)
                .HasConstraintName("FK__HIS_ItemM__ItemS__245D67DE");

            entity.HasOne(d => d.ReportedByNavigation).WithMany()
                .HasForeignKey(d => d.ReportedBy)
                .HasConstraintName("FK__HIS_ItemM__Repor__2645B050");

            entity.HasOne(d => d.ResolvedByNavigation).WithMany()
                .HasForeignKey(d => d.ResolvedBy)
                .HasConstraintName("FK__HIS_ItemM__Resol__2739D489");

            entity.HasOne(d => d.Ticket).WithMany()
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK__HIS_ItemM__Ticke__282DF8C2");
        });

        modelBuilder.Entity<LogRoomApplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOG_RoomApplication");

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");
            entity.Property(e => e.LogNote).HasMaxLength(200);
            entity.Property(e => e.StatusChangedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Application).WithMany()
                .HasForeignKey(d => d.ApplicationId)
                .HasConstraintName("FK__LOG_RoomA__Appli__29221CFB");
        });

        modelBuilder.Entity<SysAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__SYS_Acco__349DA5863A0F7BAE");

            entity.ToTable("SYS_Account");

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("AccountID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Password).HasMaxLength(200);

            entity.HasOne(d => d.Account).WithOne(p => p.SysAccount)
                .HasForeignKey<SysAccount>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SYS_Accou__Accou__2A164134");
        });

        modelBuilder.Entity<SysDocumentSetUp>(entity =>
        {
            entity.HasKey(e => new { e.DocumentTypeId, e.ModuleTypeId }).HasName("PK__SYS_Docu__0E4854335E195DB0");

            entity.ToTable("SYS_DocumentSetUp");

            entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");
            entity.Property(e => e.ModuleTypeId).HasColumnName("ModuleTypeID");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.SysDocumentSetUps)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SYS_Docum__Docum__2CF2ADDF");

            entity.HasOne(d => d.ModuleType).WithMany(p => p.SysDocumentSetUps)
                .HasForeignKey(d => d.ModuleTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SYS_Docum__Modul__2DE6D218");
        });

        modelBuilder.Entity<SysPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PK__SYS_Perm__EFA6FB0FF8EEB03C");

            entity.ToTable("SYS_Permission");

            entity.Property(e => e.PermissionId)
                .ValueGeneratedNever()
                .HasColumnName("PermissionID");
            entity.Property(e => e.PermissionCode).HasMaxLength(255);
            entity.Property(e => e.PermissionName).HasMaxLength(200);
        });

        modelBuilder.Entity<SysRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__SYS_Role__8AFACE3AA1652DAD");

            entity.ToTable("SYS_Role");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("RoleID");
            entity.Property(e => e.RoleCode).HasMaxLength(255);
            entity.Property(e => e.RoleName).HasMaxLength(255);

            entity.HasMany(d => d.Accounts).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "SysAccountRole",
                    r => r.HasOne<SysAccount>().WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SYS_Accou__Accou__2B0A656D"),
                    l => l.HasOne<SysRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SYS_Accou__RoleI__2BFE89A6"),
                    j =>
                    {
                        j.HasKey("RoleId", "AccountId").HasName("PK__SYS_Acco__F9B314620CEE1A25");
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
                        .HasConstraintName("FK__SYS_RoleP__Permi__2EDAF651"),
                    l => l.HasOne<SysRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SYS_RoleP__RoleI__2FCF1A8A"),
                    j =>
                    {
                        j.HasKey("RoleId", "PermissionId").HasName("PK__SYS_Role__6400A18ABDD261F2");
                        j.ToTable("SYS_RolePermission");
                        j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");
                        j.IndexerProperty<Guid>("PermissionId").HasColumnName("PermissionID");
                    });
        });

        modelBuilder.Entity<TkIssueTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__TK_Issue__712CC627B44C104E");

            entity.ToTable("TK_IssueTicket");

            entity.Property(e => e.TicketId)
                .ValueGeneratedNever()
                .HasColumnName("TicketID");
            entity.Property(e => e.ApprovedOn).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Header).HasMaxLength(500);
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.TicketStatusId).HasColumnName("TicketStatusID");
            entity.Property(e => e.TicketTypeId).HasColumnName("TicketTypeID");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.TkIssueTicketApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK__TK_IssueT__Appro__30C33EC3");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TkIssueTicketCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__TK_IssueT__Creat__31B762FC");

            entity.HasOne(d => d.Room).WithMany(p => p.TkIssueTickets)
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("FK__TK_IssueT__RoomI__32AB8735");

            entity.HasOne(d => d.TicketStatus).WithMany(p => p.TkIssueTickets)
                .HasForeignKey(d => d.TicketStatusId)
                .HasConstraintName("FK__TK_IssueT__Ticke__3493CFA7");

            entity.HasOne(d => d.TicketType).WithMany(p => p.TkIssueTickets)
                .HasForeignKey(d => d.TicketTypeId)
                .HasConstraintName("FK__TK_IssueT__Ticke__339FAB6E");

            entity.HasMany(d => d.Students).WithMany(p => p.Tickets)
                .UsingEntity<Dictionary<string, object>>(
                    "TkIssueTicketStudent",
                    r => r.HasOne<GenStudent>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__TK_IssueT__Stude__395884C4"),
                    l => l.HasOne<TkIssueTicket>().WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__TK_IssueT__Ticke__3A4CA8FD"),
                    j =>
                    {
                        j.HasKey("TicketId", "StudentId").HasName("PK__TK_Issue__F20094803D611EC0");
                        j.ToTable("TK_IssueTicketStudent");
                        j.IndexerProperty<Guid>("TicketId").HasColumnName("TicketID");
                        j.IndexerProperty<Guid>("StudentId").HasColumnName("StudentID");
                    });
        });

        modelBuilder.Entity<TkIssueTicketDetail>(entity =>
        {
            entity.HasKey(e => new { e.TicketId, e.OrderIndex }).HasName("PK__TK_Issue__95B9A9303485A08E");

            entity.ToTable("TK_IssueTicketDetails");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.ItemStatusId).HasColumnName("ItemStatusID");

            entity.HasOne(d => d.Item).WithMany(p => p.TkIssueTicketDetails)
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("FK__TK_IssueT__ItemI__3587F3E0");

            entity.HasOne(d => d.ItemStatus).WithMany(p => p.TkIssueTicketDetails)
                .HasForeignKey(d => d.ItemStatusId)
                .HasConstraintName("FK__TK_IssueT__ItemS__367C1819");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TkIssueTicketDetails)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TK_IssueT__Ticke__37703C52");
        });

        modelBuilder.Entity<TkIssueTicketPhoto>(entity =>
        {
            entity.HasKey(e => new { e.TicketId, e.PhotoIndex }).HasName("PK__TK_Issue__58E036EFE5D12C25");

            entity.ToTable("TK_IssueTicketPhoto");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Ticket).WithMany(p => p.TkIssueTicketPhotos)
                .HasForeignKey(d => d.TicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TK_IssueT__Ticke__3864608B");
        });

        modelBuilder.Entity<TkIssueTicketStatus>(entity =>
        {
            entity.HasKey(e => e.TicketStatusId).HasName("PK__TK_Issue__76E509E1DA2FA516");

            entity.ToTable("TK_IssueTicketStatus");

            entity.Property(e => e.TicketStatusId)
                .ValueGeneratedNever()
                .HasColumnName("TicketStatusID");
            entity.Property(e => e.StatusName).HasMaxLength(200);
        });

        modelBuilder.Entity<TkIssueTicketType>(entity =>
        {
            entity.HasKey(e => e.TicketTypeId).HasName("PK__TK_Issue__6CD68451F8C0E27F");

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
