using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.API.Data;

public partial class OrigisOperacionesContext : DbContext
{
    public OrigisOperacionesContext()
    {
    }

    public OrigisOperacionesContext(DbContextOptions<OrigisOperacionesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccesoOrigi> AccesoOrigis { get; set; }

    public virtual DbSet<Alumno> Alumnos { get; set; }

    public virtual DbSet<AppParameter> AppParameters { get; set; }

    public virtual DbSet<BkOrigisPendiente> BkOrigisPendientes { get; set; }

    public virtual DbSet<CimoDbtable> CimoDbtables { get; set; }

    public virtual DbSet<ConectionsCheck> ConectionsChecks { get; set; }

    public virtual DbSet<Cuenta> Cuentas { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<DeleteInformationDeliverable> DeleteInformationDeliverables { get; set; }

    public virtual DbSet<DeleteInformationStatus> DeleteInformationStatuses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DimCalendario> DimCalendarios { get; set; }

    public virtual DbSet<ExceptionArea> ExceptionAreas { get; set; }

    public virtual DbSet<ExceptionTarea> ExceptionTareas { get; set; }

    public virtual DbSet<FechasNoLaborable> FechasNoLaborables { get; set; }

    public virtual DbSet<FlokzuActivity> FlokzuActivities { get; set; }

    public virtual DbSet<FlokzuBug> FlokzuBugs { get; set; }

    public virtual DbSet<FlokzuComparacion> FlokzuComparacions { get; set; }

    public virtual DbSet<FlokzuCon> FlokzuCons { get; set; }

    public virtual DbSet<FlokzuCuentasView> FlokzuCuentasViews { get; set; }

    public virtual DbSet<FlokzuEr> FlokzuErs { get; set; }

    public virtual DbSet<FlokzuFecha> FlokzuFechas { get; set; }

    public virtual DbSet<FlokzuHdt> FlokzuHdts { get; set; }

    public virtual DbSet<FlokzuHdtindicadore> FlokzuHdtindicadores { get; set; }

    public virtual DbSet<FlokzuImasd> FlokzuImasds { get; set; }

    public virtual DbSet<FlokzuImt> FlokzuImts { get; set; }

    public virtual DbSet<FlokzuIngesosSac> FlokzuIngesosSacs { get; set; }

    public virtual DbSet<FlokzuIngreso> FlokzuIngresos { get; set; }

    public virtual DbSet<FlokzuLog> FlokzuLogs { get; set; }

    public virtual DbSet<FlokzuMatrizServicio> FlokzuMatrizServicios { get; set; }

    public virtual DbSet<FlokzuMatrizServicios2> FlokzuMatrizServicios2s { get; set; }

    public virtual DbSet<FlokzuOdit> FlokzuOdits { get; set; }

    public virtual DbSet<FlokzuOdt> FlokzuOdts { get; set; }

    public virtual DbSet<FlokzuOwnerIntegration> FlokzuOwnerIntegrations { get; set; }

    public virtual DbSet<FlokzuOwnerIntegrationsLog> FlokzuOwnerIntegrationsLogs { get; set; }

    public virtual DbSet<FlokzuQat> FlokzuQats { get; set; }

    public virtual DbSet<FlokzuRpa> FlokzuRpas { get; set; }

    public virtual DbSet<FlokzuRt> FlokzuRts { get; set; }

    public virtual DbSet<FlokzuSac> FlokzuSacs { get; set; }

    public virtual DbSet<FlokzuSc> FlokzuScs { get; set; }

    public virtual DbSet<FlokzuScdate> FlokzuScdates { get; set; }

    public virtual DbSet<FlokzuScfa> FlokzuScfas { get; set; }

    public virtual DbSet<FlokzuScindicadore> FlokzuScindicadores { get; set; }

    public virtual DbSet<FlokzuSponsor> FlokzuSponsors { get; set; }

    public virtual DbSet<FlokzuSync> FlokzuSyncs { get; set; }

    public virtual DbSet<FlokzuToDo> FlokzuToDos { get; set; }

    public virtual DbSet<FlokzuTpe> FlokzuTpes { get; set; }

    public virtual DbSet<FlokzuVac> FlokzuVacs { get; set; }

    public virtual DbSet<FlokzuViewMaster> FlokzuViewMasters { get; set; }

    public virtual DbSet<HelpDeskActivity> HelpDeskActivities { get; set; }

    public virtual DbSet<InformationArea> InformationAreas { get; set; }

    public virtual DbSet<InformationContractManagement> InformationContractManagements { get; set; }

    public virtual DbSet<InformationEnterprise> InformationEnterprises { get; set; }

    public virtual DbSet<InformationInventory> InformationInventories { get; set; }

    public virtual DbSet<InformationInventoryUser> InformationInventoryUsers { get; set; }

    public virtual DbSet<InformationObject> InformationObjects { get; set; }

    public virtual DbSet<InformationObjectRelationship> InformationObjectRelationships { get; set; }

    public virtual DbSet<InformationObjectSource> InformationObjectSources { get; set; }

    public virtual DbSet<InformationObjectSourceType> InformationObjectSourceTypes { get; set; }

    public virtual DbSet<InformationObjectType> InformationObjectTypes { get; set; }

    public virtual DbSet<JobStep> JobSteps { get; set; }

    public virtual DbSet<MatrizAcceso> MatrizAccesos { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OperationsLog> OperationsLogs { get; set; }

    public virtual DbSet<OrigisPendiente> OrigisPendientes { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<OwnerIntegration> OwnerIntegrations { get; set; }

    public virtual DbSet<OwnerItemProgram> OwnerItemPrograms { get; set; }

    public virtual DbSet<OwnerRequest> OwnerRequests { get; set; }

    public virtual DbSet<OwnersProgram> OwnersPrograms { get; set; }

    public virtual DbSet<Password> Passwords { get; set; }

    public virtual DbSet<Passwordu> Passwordus { get; set; }

    public virtual DbSet<Requeriment> Requeriments { get; set; }

    public virtual DbSet<RulesImpact> RulesImpacts { get; set; }

    public virtual DbSet<RulesImpactV2> RulesImpactV2s { get; set; }

    public virtual DbSet<RulesOrbisRed> RulesOrbisReds { get; set; }

    public virtual DbSet<RulesOrbisRedContent> RulesOrbisRedContents { get; set; }

    public virtual DbSet<RulesOrbisRedContentLog> RulesOrbisRedContentLogs { get; set; }

    public virtual DbSet<RulesOrbisRedLog> RulesOrbisRedLogs { get; set; }

    public virtual DbSet<StatusPending> StatusPendings { get; set; }

    public virtual DbSet<TabDataMart> TabDataMarts { get; set; }

    public virtual DbSet<TabFlokzuActivity> TabFlokzuActivities { get; set; }

    public virtual DbSet<TabFlokzuSc> TabFlokzuScs { get; set; }

    public virtual DbSet<TabFlokzuVac> TabFlokzuVacs { get; set; }

    public virtual DbSet<TabRequest> TabRequests { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserConfiguration> UserConfigurations { get; set; }

    public virtual DbSet<Usersu> Usersus { get; set; }

    public virtual DbSet<UsuariosFlokzuAcceso> UsuariosFlokzuAccesos { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccesoOrigi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AccesoOrigis");

            entity.Property(e => e.HoraEntrada).HasColumnType("datetime");
            entity.Property(e => e.HoraGen).HasColumnType("datetime");
            entity.Property(e => e.HoraSalida).HasColumnType("datetime");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Nombre Usuario");
            entity.Property(e => e.NumeroTarjeta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Numero Tarjeta");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Alumno>(entity =>
        {
            entity.HasKey(e => e.PkId).HasName("PK__alumnos__F4A5475A7E22DC11");

            entity.ToTable("alumnos");

            entity.Property(e => e.PkId).HasColumnName("PK_id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha");
            entity.Property(e => e.Grupo).HasColumnName("grupo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<AppParameter>(entity =>
        {
            entity.HasKey(e => e.ParameterId);

            entity.HasIndex(e => e.ParameterType, "idx_AppParameters_parametertype");

            entity.HasIndex(e => new { e.ParameterType, e.ParameterName }, "idx_AppParameters_parametertypename");

            entity.Property(e => e.ParameterDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ParameterLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ParameterName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ParameterType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParameterValue)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<BkOrigisPendiente>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_OrigisPendientes");

            entity.ToTable("bkOrigisPendientes");

            entity.Property(e => e.Asignacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Cliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DiasRetrasoAbierta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.DiasRetrasoEntregadas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.EjecutivoCuenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.Estimacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("NO");
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaEstimacion).HasColumnType("datetime");
            entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitudAnio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.HorasCuentas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HorasDesarrollo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HorasDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HorasDiseño)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HorasInformacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Solicitante)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Solicitud)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SolicitudActividad)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SolicitudNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.SolicitudPrioridad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SolicitudStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<CimoDbtable>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("cimo_dbtables");

            entity.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("comments");
            entity.Property(e => e.CreateDate)
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.DbName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("db_name");
            entity.Property(e => e.Delete)
                .HasDefaultValue((byte)0)
                .HasColumnName("delete");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("description");
            entity.Property(e => e.IsExternal).HasColumnName("is_external");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("modify_date");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ReferencedEntities)
                .HasDefaultValue((byte)0)
                .HasColumnName("referenced_entities");
            entity.Property(e => e.ReferencingEntities)
                .HasDefaultValue((byte)0)
                .HasColumnName("referencing_entities");
            entity.Property(e => e.SpaceDataMb)
                .HasDefaultValue(0.0)
                .HasColumnName("space_data_MB");
            entity.Property(e => e.SpaceReservedMb)
                .HasDefaultValue(0.0)
                .HasColumnName("space_reserved_MB");
            entity.Property(e => e.Table)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("table");
        });

        modelBuilder.Entity<ConectionsCheck>(entity =>
        {
            entity.HasKey(e => e.IdConectionsChecks).HasName("PK__Conectio__F5CD6D85B347746A");

            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cuenta>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CtaPrograma).HasMaxLength(255);
            entity.Property(e => e.Cuenta1)
                .HasMaxLength(50)
                .HasColumnName("Cuenta");
            entity.Property(e => e.CuentaActive).HasDefaultValueSql("('1')");
            entity.Property(e => e.CuentaId).ValueGeneratedOnAdd();
            entity.Property(e => e.Horas).HasColumnName("horas");
            entity.Property(e => e.Programa).HasMaxLength(150);
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.PkId).HasName("PK__cursos__F4A5475A2BE7C159");

            entity.ToTable("cursos");

            entity.Property(e => e.PkId).HasColumnName("PK_id");
            entity.Property(e => e.Curso1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("curso");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<DeleteInformationDeliverable>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_InformationDeliverables");

            entity.ToTable("DELETE_InformationDeliverables");

            entity.Property(e => e.Active).HasDefaultValue(1);
            entity.Property(e => e.AssignedUserId).HasDefaultValue(0);
            entity.Property(e => e.DeliverDate).HasColumnType("datetime");
            entity.Property(e => e.Deliverable)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DeliverableStatusId).HasDefaultValue(1);
            entity.Property(e => e.OwnerId).HasDefaultValue(0);
            entity.Property(e => e.Period)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Periodicity)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Monthly");
            entity.Property(e => e.Priority)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("Normal");
            entity.Property(e => e.ProgramId).HasDefaultValue(0);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordKey)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RegistrantUserId).HasDefaultValue(0);
            entity.Property(e => e.ScheduledDay).HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<DeleteInformationStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK_[InformationStatus");

            entity.ToTable("DELETE_InformationStatus");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Status)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StatusKey)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StatusValuePercent).HasDefaultValue(0);
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<DimCalendario>(entity =>
        {
            entity.HasKey(e => e.Fecha).HasName("PK_CALENDARIO");

            entity.ToTable("Dim_Calendario");

            entity.Property(e => e.FechaIso).HasColumnName("FechaISO");
        });

        modelBuilder.Entity<ExceptionArea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("exception_Areas");

            entity.Property(e => e.Nombre).HasMaxLength(255);
        });

        modelBuilder.Entity<ExceptionTarea>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("exception_Tareas");

            entity.Property(e => e.Area).HasMaxLength(255);
            entity.Property(e => e.Clasificacion).HasMaxLength(255);
            entity.Property(e => e.NombreTareaOdt)
                .HasMaxLength(255)
                .HasColumnName("NombreTareaODT");
            entity.Property(e => e.Poe)
                .HasMaxLength(255)
                .HasColumnName("POE");
            entity.Property(e => e.Proceso).HasMaxLength(255);
        });

        modelBuilder.Entity<FechasNoLaborable>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaActive).HasDefaultValueSql("('1')");
            entity.Property(e => e.FechaNoLaborableId).ValueGeneratedOnAdd();
            entity.Property(e => e.FechaType).HasDefaultValueSql("('1')");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuActivity>(entity =>
        {
            entity.HasKey(e => e.ActivityId).HasName("PK_ActivityId");

            entity.HasIndex(e => new { e.Usuario, e.AreaEjecucion, e.Fecha }, "nci_wi_FlokzuActivities_3CCA4D5E26880D6E3026AAF35295572D");

            entity.HasIndex(e => new { e.Usuario, e.Fecha }, "nci_wi_FlokzuActivities_57E99AC0686A9EDF8174DA3CE4C9FE45");

            entity.HasIndex(e => e.ProccesType, "nci_wi_FlokzuActivities_6F493DF78A099F48EA6C4B5D1DAB159F");

            entity.HasIndex(e => e.Tarea, "nci_wi_FlokzuActivities_6F761CC5CAA91F235AED496287CF76A9");

            entity.HasIndex(e => new { e.Tarea, e.Odit }, "nci_wi_FlokzuActivities_743E96037D5CD633D153A906C5AB21B3");

            entity.HasIndex(e => e.AreaEjecucion, "nci_wi_FlokzuActivities_76A6E30A89BEE2E44AC9712EFE581D2A");

            entity.HasIndex(e => new { e.Usuario, e.AreaEjecucion }, "nci_wi_FlokzuActivities_9C2D3680C88970311BEC6600BD1AF7A7");

            entity.HasIndex(e => e.FechaActividad, "nci_wi_FlokzuActivities_C6B3E376E1C958A34D8F6A339BA90E42");

            entity.HasIndex(e => e.ProccesType, "nci_wi_FlokzuActivities_C6BCDF1AD33A4183D995D4BD17F17FAB");

            entity.HasIndex(e => e.Proceso, "nci_wi_FlokzuActivities_EF77DA8C45EF23CA1F7CC483F854B418");

            entity.Property(e => e.Actividad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AreaEjecucion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.Bug)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("BUG");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Con)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CON");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Er)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ER");
            entity.Property(e => e.Fecha)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaActividad).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.Hdt)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HDT");
            entity.Property(e => e.Horas).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.Imt)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IMT");
            entity.Property(e => e.Interpretacion).HasColumnType("text");
            entity.Property(e => e.Mes)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasComputedColumnSql("(CONVERT([varchar](6),[FechaActividad],(112)))", false);
            entity.Property(e => e.Odit)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ODIT");
            entity.Property(e => e.Odt)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ODT");
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Proceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Qat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("QAT");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Recordate).HasColumnType("datetime");
            entity.Property(e => e.Rpa)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RPA");
            entity.Property(e => e.Rt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RT");
            entity.Property(e => e.Sc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SC");
            entity.Property(e => e.Scfa)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SCFA");
            entity.Property(e => e.Tarea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Tpe)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("TPE");
            entity.Property(e => e.Usuario)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuBug>(entity =>
        {
            entity.HasKey(e => e.BugId).HasName("PK_Bug");

            entity.ToTable("FlokzuBug");

            entity.Property(e => e.Aplicacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Bug)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Causa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ConfirmacionBug)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionBreve)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Documentacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EvidenciaVisual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Finalizado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.InformacionComplementaria).HasColumnType("text");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IniciadorProceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("BUG");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Severidad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Solucion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TareaActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoBug)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalHoras).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuComparacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuComparacion");

            entity.Property(e => e.Actividad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ActivityId).ValueGeneratedOnAdd();
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaActividad).HasColumnType("datetime");
            entity.Property(e => e.Horas).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Proceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuCon>(entity =>
        {
            entity.HasKey(e => e.ConId).HasName("PK_Con");

            entity.ToTable("FlokzuCon");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCertificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Con)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaApertura)
                .HasColumnType("datetime")
                .HasColumnName("fechaApertura");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.InformacionComplementaria).HasColumnType("text");
            entity.Property(e => e.Periodo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("CON");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalHoras).HasColumnType("decimal(25, 2)");
        });

        modelBuilder.Entity<FlokzuCuentasView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuCuentasView");

            entity.Property(e => e.CtaPrograma).HasMaxLength(255);
            entity.Property(e => e.Cuenta).HasMaxLength(50);
            entity.Property(e => e.CuentaId).ValueGeneratedOnAdd();
            entity.Property(e => e.Horas).HasColumnName("horas");
            entity.Property(e => e.Programa).HasMaxLength(150);
        });

        modelBuilder.Entity<FlokzuEr>(entity =>
        {
            entity.HasKey(e => e.ErId).HasName("PK_Er");

            entity.ToTable("FlokzuEr");

            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.EjecutadoPor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EntregadoPor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Er)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.InformacionRequerida).HasColumnType("text");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IniciadorProceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Medioentrega)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreEntregable)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Periodicidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("ER");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoEntregable)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuFecha>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuFechas");

            entity.Property(e => e.Area1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ScId).ValueGeneratedOnAdd();
            entity.Property(e => e.Tarea1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea9)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuHdt>(entity =>
        {
            entity.HasKey(e => e.HdtId).HasName("PK_Hdt");

            entity.ToTable("FlokzuHdt");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CadenaReferencia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Finalizado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.Hdt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HdtRechazada)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.InformacionComplementaria).HasColumnType("text");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IniciadorProceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MotivoRechazo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("HDT");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReprocesoHdt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TareaActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoHdt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalHoras).HasColumnType("decimal(25, 2)");
        });

        modelBuilder.Entity<FlokzuHdtindicadore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuHDTIndicadores");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CadenaReferencia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCierreCalculada).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Finalizado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Hdt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HdtId).ValueGeneratedOnAdd();
            entity.Property(e => e.HdtRechazada)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.InformacionComplementaria).HasColumnType("text");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IniciadorProceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Mes)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.MotivoRechazo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReprocesoHdt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TareaActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoHdt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalHoras).HasColumnType("decimal(25, 2)");
        });

        modelBuilder.Entity<FlokzuImasd>(entity =>
        {
            entity.HasKey(e => e.ImasdId).HasName("PK_IMASD");

            entity.ToTable("FlokzuImasd");

            entity.Property(e => e.Alcance)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("alcance");
            entity.Property(e => e.Estadoimasd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estadoimasd");
            entity.Property(e => e.Fechaestimadafinalizacion).HasColumnName("fechaestimadafinalizacion");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Imasd)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Implementacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("implementacion");
            entity.Property(e => e.Justificacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("justificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.ProccesType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("IMASD");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Responsable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("responsable");
            entity.Property(e => e.Tipo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<FlokzuImt>(entity =>
        {
            entity.HasKey(e => e.ImtId).HasName("PK_IMT");

            entity.ToTable("FlokzuImt");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CarpetaRequisitos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EjecutivoCuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaTermino).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.Imt)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IMT");
            entity.Property(e => e.Interpretacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MotivoDerivacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("IMT");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoImt)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ResultadoIMT");
            entity.Property(e => e.Rol)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuIngesosSac>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuIngesosSacs");

            entity.Property(e => e.Acceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaBaja)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Perfil)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProcesType)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuIngreso>(entity =>
        {
            entity.HasKey(e => e.IngresoId);

            entity.Property(e => e.AccesoAntivirus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccesoAreaSegura)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccesoCorreo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccesoCuentaAdministrador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AccesoFirewallRed)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccesoFlokzu)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccesoOffice)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccesoPuertaEntrada)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ActiveTask)
                .HasColumnType("text")
                .HasColumnName("Active_Task");
            entity.Property(e => e.AlcaldiaMunicipio)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Calle)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Celular)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Colonia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ContraseniaCorreo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContraseniaFirewall)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EvidenciaCapacitacion).HasColumnType("text");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSac)
                .HasColumnType("datetime")
                .HasColumnName("FechaSAC");
            entity.Property(e => e.FlokzuTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IdPersonal)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdSac)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IdSAC");
            entity.Property(e => e.ImeiCelular)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Ingreso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Iniciador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JefeInmediato)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LockStatus)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LugarNacimiento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NoExpediente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NoExt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NoInt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NoSerie)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreColaborador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreCurso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PerfilAntivirus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PerfilAreaSegura)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PerfilCorreo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PerfilCuentaAdministrador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PerfilFirewall)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PerfilFlokzu)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PerfilOffice)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PerfilPuertaEntrada)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("INGRESO");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Rol)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RolesAsignados)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tags).HasColumnType("text");
            entity.Property(e => e.TareaActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ubkey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("UBKEY");
            entity.Property(e => e.UsuarioFirewall)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UsuariosAsignados)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuLog>(entity =>
        {
            entity.HasKey(e => e.LogsId).HasName("PK_Logs");

            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.Payload).HasColumnType("text");
        });

        modelBuilder.Entity<FlokzuMatrizServicio>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_FlokzuMatrizServiciosNew");

            entity.Property(e => e.RecordId).ValueGeneratedNever();
            entity.Property(e => e.AccountJr).HasColumnName("Account_Jr");
            entity.Property(e => e.AccountMngr).HasColumnName("Account_Mngr");
            entity.Property(e => e.AccountSr).HasColumnName("Account_Sr");
            entity.Property(e => e.AnalystJr).HasColumnName("Analyst_Jr");
            entity.Property(e => e.AnalystMngr).HasColumnName("Analyst_Mngr");
            entity.Property(e => e.Comentarios).HasMaxLength(1);
            entity.Property(e => e.Componente).HasMaxLength(100);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.IActive).HasColumnName("i_Active");
            entity.Property(e => e.IObligatorio).HasColumnName("i_Obligatorio");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OpeBusinessSpclst).HasColumnName("Ope_Business_Spclst");
            entity.Property(e => e.RecordSource).HasMaxLength(1);
            entity.Property(e => e.Servicio).HasMaxLength(50);
            entity.Property(e => e.StrategicConsultanDirector).HasColumnName("Strategic_Consultan_Director");
            entity.Property(e => e.SwEngineerJr).HasColumnName("Sw_Engineer_Jr");
            entity.Property(e => e.SwEngineerMngr).HasColumnName("Sw_Engineer_Mngr");
        });

        modelBuilder.Entity<FlokzuMatrizServicios2>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_FlokzuMatrizServicios");

            entity.ToTable("FlokzuMatrizServicios2");

            entity.Property(e => e.RecordId).ValueGeneratedNever();
            entity.Property(e => e.AccountJr).HasColumnName("Account_Jr");
            entity.Property(e => e.AccountMngr).HasColumnName("Account_Mngr");
            entity.Property(e => e.AccountSr).HasColumnName("Account_Sr");
            entity.Property(e => e.AnalystJr).HasColumnName("Analyst_Jr");
            entity.Property(e => e.AnalystMngr).HasColumnName("Analyst_Mngr");
            entity.Property(e => e.Comentarios).HasMaxLength(1);
            entity.Property(e => e.Componente).HasMaxLength(100);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.IActive).HasColumnName("i_Active");
            entity.Property(e => e.IObligatorio).HasColumnName("i_Obligatorio");
            entity.Property(e => e.NombreComercial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OpeBusinessSpclst).HasColumnName("Ope_Business_Spclst");
            entity.Property(e => e.RecordSource).HasMaxLength(1);
            entity.Property(e => e.Servicio).HasMaxLength(50);
            entity.Property(e => e.StrategicConsultanDirector).HasColumnName("Strategic_Consultan_Director");
            entity.Property(e => e.SwEngineerJr).HasColumnName("Sw_Engineer_Jr");
            entity.Property(e => e.SwEngineerMngr).HasColumnName("Sw_Engineer_Mngr");
        });

        modelBuilder.Entity<FlokzuOdit>(entity =>
        {
            entity.HasKey(e => e.OditId).HasName("PK_Odit");

            entity.ToTable("FlokzuOdit");

            entity.Property(e => e.Actividad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cadena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NoDeNodit)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odit)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("ODIT");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoDeRegistro)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoOdit)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalDeHoras)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuOdt>(entity =>
        {
            entity.HasKey(e => e.OdtId).HasName("PK_Odt");

            entity.ToTable("FlokzuOdt");

            entity.HasIndex(e => new { e.Odt, e.Estatus }, "nci_wi_FlokzuOdt_AA692A07D6FDCE9CFD1BB0C7D02CAC2D");

            entity.HasIndex(e => new { e.Asignacion, e.TareaActual }, "nci_wi_FlokzuOdt_DE5A6458D707B106EF3559F7623F3603");

            entity.Property(e => e.Accion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AjusteHoras).HasColumnType("text");
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CarpetaRequisitos)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DescripcionFuncionalidad).HasColumnType("text");
            entity.Property(e => e.DomicilioMatriz)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DuracionEstimada).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimadaOdt)
                .HasColumnType("decimal(25, 2)")
                .HasColumnName("DuracionEstimadaODT");
            entity.Property(e => e.EjecutivoCuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EnEsperaDe)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Finalizado)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.Interpretacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreCadena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("ODT");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RequisitoTarea).HasColumnType("text");
            entity.Property(e => e.Sc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SeleccionQa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SeleccionQA");
            entity.Property(e => e.SistemaInvolucrado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SituacionActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TareaActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TotalAjuste).HasColumnType("text");
            entity.Property(e => e.TotalHoras).HasColumnType("decimal(25, 2)");
        });

        modelBuilder.Entity<FlokzuOwnerIntegration>(entity =>
        {
            entity.HasKey(e => e.FlokzuOwnerIntegrationsId);

            entity.Property(e => e.AsignationLastDate).HasColumnType("datetime");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ConnectionNameReference)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.ItemOwnerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ItemOwnerProgramName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Proceso)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<FlokzuOwnerIntegrationsLog>(entity =>
        {
            entity.ToTable("FlokzuOwnerIntegrationsLog");

            entity.Property(e => e.AsignationLastDate).HasColumnType("datetime");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ConnectionNameReference)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.ItemOwnerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ItemOwnerProgramName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Proceso)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<FlokzuQat>(entity =>
        {
            entity.HasKey(e => e.QatId).HasName("PK_Qat");

            entity.ToTable("FlokzuQat");

            entity.Property(e => e.AltaDeProductosNuevoConRegla)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AsignacionInstancia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.AsignacionQa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("AsignacionQA");
            entity.Property(e => e.BajaDeBonificacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BajaDeDescuento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Bonificación)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CantidadDeSku)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CantidadDeSKU");
            entity.Property(e => e.CantidadReglas)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CarpetaRequisitos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Conteo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Criterio)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DescripcionBreve)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descuento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EvidenciaQa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("EvidenciaQA");
            entity.Property(e => e.FechaAperturaBug)
                .HasColumnType("datetime")
                .HasColumnName("FechaAperturaBUG");
            entity.Property(e => e.FechaDeSeleccion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.FechaReporteBug).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.Impacto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NoBug)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NoBUG");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("QAT");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Qa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("QA");
            entity.Property(e => e.Qat)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReglasBonificacion).HasDefaultValue(0);
            entity.Property(e => e.ReglasConDesarrollo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ReglasDescartadas)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ReglasDescuento).HasDefaultValue(0);
            entity.Property(e => e.ReglasEnElTop10DelMonitor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ReglasOrdinarias)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Resultado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Severidad)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuRpa>(entity =>
        {
            entity.HasKey(e => e.RpaId).HasName("PK_RPA");

            entity.ToTable("FlokzuRPA");

            entity.Property(e => e.CarpetaReferencia)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ContactoCotizar)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorreoCotizar)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ejecutivo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EjecutivoC)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EjecutivoCuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Etiqueta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FacturarA)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAutorizacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaEstimada).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaRecepcion).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitudDesarrollo).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.IniciadorProceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Laboratorio)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Motivo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("RPA");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Referencia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Rpa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SeleccionQa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SeleccionQA");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Substatus)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuRt>(entity =>
        {
            entity.HasKey(e => e.RtId).HasName("PK_Rt");

            entity.ToTable("FlokzuRt");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CadenaReferencia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Etiquetas)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.Finalizado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IniciadorProceso)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("RT");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RolesAsignados)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Rt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TareaActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TiempoVida)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalHoras).HasColumnType("decimal(25, 2)");
        });

        modelBuilder.Entity<FlokzuSac>(entity =>
        {
            entity.HasKey(e => e.SacId).HasName("PK_FlokzuSAC");

            entity.ToTable("FlokzuSACs");

            entity.Property(e => e.Acceso1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_1");
            entity.Property(e => e.Acceso10)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_10");
            entity.Property(e => e.Acceso11)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_11");
            entity.Property(e => e.Acceso12)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_12");
            entity.Property(e => e.Acceso13)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_13");
            entity.Property(e => e.Acceso14)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_14");
            entity.Property(e => e.Acceso15)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_15");
            entity.Property(e => e.Acceso16)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_16");
            entity.Property(e => e.Acceso17)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_17");
            entity.Property(e => e.Acceso18)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_18");
            entity.Property(e => e.Acceso19)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_19");
            entity.Property(e => e.Acceso2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_2");
            entity.Property(e => e.Acceso20)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_20");
            entity.Property(e => e.Acceso21)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_21");
            entity.Property(e => e.Acceso3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_3");
            entity.Property(e => e.Acceso4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_4");
            entity.Property(e => e.Acceso5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_5");
            entity.Property(e => e.Acceso6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_6");
            entity.Property(e => e.Acceso7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_7");
            entity.Property(e => e.Acceso8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_8");
            entity.Property(e => e.Acceso9)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Acceso_9");
            entity.Property(e => e.AccesosBasicos)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ActiveTask).HasColumnType("text");
            entity.Property(e => e.Aprobado1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_1");
            entity.Property(e => e.Aprobado10)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_10");
            entity.Property(e => e.Aprobado11)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_11");
            entity.Property(e => e.Aprobado12)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_12");
            entity.Property(e => e.Aprobado13)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_13");
            entity.Property(e => e.Aprobado14)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_14");
            entity.Property(e => e.Aprobado15)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_15");
            entity.Property(e => e.Aprobado16)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_16");
            entity.Property(e => e.Aprobado17)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_17");
            entity.Property(e => e.Aprobado18)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_18");
            entity.Property(e => e.Aprobado19)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_19");
            entity.Property(e => e.Aprobado2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_2");
            entity.Property(e => e.Aprobado20)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_20");
            entity.Property(e => e.Aprobado21)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_21");
            entity.Property(e => e.Aprobado3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_3");
            entity.Property(e => e.Aprobado4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_4");
            entity.Property(e => e.Aprobado5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_5");
            entity.Property(e => e.Aprobado6)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_6");
            entity.Property(e => e.Aprobado7)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_7");
            entity.Property(e => e.Aprobado8)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_8");
            entity.Property(e => e.Aprobado9)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Aprobado_9");
            entity.Property(e => e.ContactoAdministracion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CorreoDelColaborador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaAlta1).HasColumnName("FechaAlta_1");
            entity.Property(e => e.FechaAlta10).HasColumnName("FechaAlta_10");
            entity.Property(e => e.FechaAlta11).HasColumnName("FechaAlta_11");
            entity.Property(e => e.FechaAlta12).HasColumnName("FechaAlta_12");
            entity.Property(e => e.FechaAlta13).HasColumnName("FechaAlta_13");
            entity.Property(e => e.FechaAlta14).HasColumnName("FechaAlta_14");
            entity.Property(e => e.FechaAlta15).HasColumnName("FechaAlta_15");
            entity.Property(e => e.FechaAlta16).HasColumnName("FechaAlta_16");
            entity.Property(e => e.FechaAlta17).HasColumnName("FechaAlta_17");
            entity.Property(e => e.FechaAlta18).HasColumnName("FechaAlta_18");
            entity.Property(e => e.FechaAlta19).HasColumnName("FechaAlta_19");
            entity.Property(e => e.FechaAlta2).HasColumnName("FechaAlta_2");
            entity.Property(e => e.FechaAlta20).HasColumnName("FechaAlta_20");
            entity.Property(e => e.FechaAlta21).HasColumnName("FechaAlta_21");
            entity.Property(e => e.FechaAlta3).HasColumnName("FechaAlta_3");
            entity.Property(e => e.FechaAlta4).HasColumnName("FechaAlta_4");
            entity.Property(e => e.FechaAlta5).HasColumnName("FechaAlta_5");
            entity.Property(e => e.FechaAlta6).HasColumnName("FechaAlta_6");
            entity.Property(e => e.FechaAlta7).HasColumnName("FechaAlta_7");
            entity.Property(e => e.FechaAlta8).HasColumnName("FechaAlta_8");
            entity.Property(e => e.FechaAlta9).HasColumnName("FechaAlta_9");
            entity.Property(e => e.FechaBaja1)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_1");
            entity.Property(e => e.FechaBaja10)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_10");
            entity.Property(e => e.FechaBaja11)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_11");
            entity.Property(e => e.FechaBaja12)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_12");
            entity.Property(e => e.FechaBaja13)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_13");
            entity.Property(e => e.FechaBaja14)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_14");
            entity.Property(e => e.FechaBaja15)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_15");
            entity.Property(e => e.FechaBaja16)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_16");
            entity.Property(e => e.FechaBaja17)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_17");
            entity.Property(e => e.FechaBaja18)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_18");
            entity.Property(e => e.FechaBaja19)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_19");
            entity.Property(e => e.FechaBaja2)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_2");
            entity.Property(e => e.FechaBaja20)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_20");
            entity.Property(e => e.FechaBaja21)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_21");
            entity.Property(e => e.FechaBaja3)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_3");
            entity.Property(e => e.FechaBaja4)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_4");
            entity.Property(e => e.FechaBaja5)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_5");
            entity.Property(e => e.FechaBaja6)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_6");
            entity.Property(e => e.FechaBaja7)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_7");
            entity.Property(e => e.FechaBaja8)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_8");
            entity.Property(e => e.FechaBaja9)
                .HasColumnType("datetime")
                .HasColumnName("FechaBaja_9");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp).HasColumnType("datetime");
            entity.Property(e => e.HoraDedicadas).HasColumnType("text");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.JefeInmediato)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LockStatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lockStatus");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreDelColaborador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Observacion1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_1");
            entity.Property(e => e.Observacion10)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_10");
            entity.Property(e => e.Observacion11)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_11");
            entity.Property(e => e.Observacion12)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_12");
            entity.Property(e => e.Observacion13)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_13");
            entity.Property(e => e.Observacion14)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_14");
            entity.Property(e => e.Observacion15)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_15");
            entity.Property(e => e.Observacion16)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_16");
            entity.Property(e => e.Observacion17)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_17");
            entity.Property(e => e.Observacion18)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_18");
            entity.Property(e => e.Observacion19)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_19");
            entity.Property(e => e.Observacion2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_2");
            entity.Property(e => e.Observacion20)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_20");
            entity.Property(e => e.Observacion21)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_21");
            entity.Property(e => e.Observacion3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_3");
            entity.Property(e => e.Observacion4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_4");
            entity.Property(e => e.Observacion5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_5");
            entity.Property(e => e.Observacion6)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_6");
            entity.Property(e => e.Observacion7)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_7");
            entity.Property(e => e.Observacion8)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_8");
            entity.Property(e => e.Observacion9)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Observacion_9");
            entity.Property(e => e.Perfil1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_1");
            entity.Property(e => e.Perfil10)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_10");
            entity.Property(e => e.Perfil11)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_11");
            entity.Property(e => e.Perfil12)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_12");
            entity.Property(e => e.Perfil13)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_13");
            entity.Property(e => e.Perfil14)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_14");
            entity.Property(e => e.Perfil15)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_15");
            entity.Property(e => e.Perfil16)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_16");
            entity.Property(e => e.Perfil17)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_17");
            entity.Property(e => e.Perfil18)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_18");
            entity.Property(e => e.Perfil19)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_19");
            entity.Property(e => e.Perfil2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_2");
            entity.Property(e => e.Perfil20)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_20");
            entity.Property(e => e.Perfil21)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_21");
            entity.Property(e => e.Perfil3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_3");
            entity.Property(e => e.Perfil4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_4");
            entity.Property(e => e.Perfil5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_5");
            entity.Property(e => e.Perfil6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_6");
            entity.Property(e => e.Perfil7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_7");
            entity.Property(e => e.Perfil8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_8");
            entity.Property(e => e.Perfil9)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Perfil_9");
            entity.Property(e => e.PersonalNuevo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("SAC");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Resp1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_1");
            entity.Property(e => e.Resp10)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_10");
            entity.Property(e => e.Resp11)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_11");
            entity.Property(e => e.Resp12)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_12");
            entity.Property(e => e.Resp13)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_13");
            entity.Property(e => e.Resp14)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_14");
            entity.Property(e => e.Resp15)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_15");
            entity.Property(e => e.Resp16)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_16");
            entity.Property(e => e.Resp17)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_17");
            entity.Property(e => e.Resp18)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_18");
            entity.Property(e => e.Resp19)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_19");
            entity.Property(e => e.Resp2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_2");
            entity.Property(e => e.Resp20)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_20");
            entity.Property(e => e.Resp21)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_21");
            entity.Property(e => e.Resp3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_3");
            entity.Property(e => e.Resp4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_4");
            entity.Property(e => e.Resp5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_5");
            entity.Property(e => e.Resp6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_6");
            entity.Property(e => e.Resp7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_7");
            entity.Property(e => e.Resp8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_8");
            entity.Property(e => e.Resp9)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Resp_9");
            entity.Property(e => e.Rol)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sac)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAC");
            entity.Property(e => e.Tipo1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_1");
            entity.Property(e => e.Tipo10)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_10");
            entity.Property(e => e.Tipo11)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_11");
            entity.Property(e => e.Tipo12)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_12");
            entity.Property(e => e.Tipo13)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_13");
            entity.Property(e => e.Tipo14)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_14");
            entity.Property(e => e.Tipo15)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_15");
            entity.Property(e => e.Tipo16)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_16");
            entity.Property(e => e.Tipo17)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_17");
            entity.Property(e => e.Tipo18)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_18");
            entity.Property(e => e.Tipo19)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_19");
            entity.Property(e => e.Tipo2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_2");
            entity.Property(e => e.Tipo20)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_20");
            entity.Property(e => e.Tipo21)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_21");
            entity.Property(e => e.Tipo3)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_3");
            entity.Property(e => e.Tipo4)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_4");
            entity.Property(e => e.Tipo5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_5");
            entity.Property(e => e.Tipo6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_6");
            entity.Property(e => e.Tipo7)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_7");
            entity.Property(e => e.Tipo8)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_8");
            entity.Property(e => e.Tipo9)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_9");
            entity.Property(e => e.VigenciaAccesoTemporal1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_1");
            entity.Property(e => e.VigenciaAccesoTemporal10)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_10");
            entity.Property(e => e.VigenciaAccesoTemporal11)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_11");
            entity.Property(e => e.VigenciaAccesoTemporal12)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_12");
            entity.Property(e => e.VigenciaAccesoTemporal13)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_13");
            entity.Property(e => e.VigenciaAccesoTemporal14)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_14");
            entity.Property(e => e.VigenciaAccesoTemporal15)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_15");
            entity.Property(e => e.VigenciaAccesoTemporal16)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_16");
            entity.Property(e => e.VigenciaAccesoTemporal17)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_17");
            entity.Property(e => e.VigenciaAccesoTemporal18)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_18");
            entity.Property(e => e.VigenciaAccesoTemporal19)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_19");
            entity.Property(e => e.VigenciaAccesoTemporal2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_2");
            entity.Property(e => e.VigenciaAccesoTemporal20)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_20");
            entity.Property(e => e.VigenciaAccesoTemporal21)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_21");
            entity.Property(e => e.VigenciaAccesoTemporal3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_3");
            entity.Property(e => e.VigenciaAccesoTemporal4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_4");
            entity.Property(e => e.VigenciaAccesoTemporal5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_5");
            entity.Property(e => e.VigenciaAccesoTemporal6)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_6");
            entity.Property(e => e.VigenciaAccesoTemporal7)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_7");
            entity.Property(e => e.VigenciaAccesoTemporal8)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_8");
            entity.Property(e => e.VigenciaAccesoTemporal9)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VigenciaAccesoTemporal_9");
        });

        modelBuilder.Entity<FlokzuSc>(entity =>
        {
            entity.HasKey(e => e.ScId).HasName("PK_Sc");

            entity.ToTable("FlokzuSc");

            entity.HasIndex(e => e.Sc, "nci_wi_FlokzuSc_08B3A6C50F840855793192157A48B075");

            entity.Property(e => e.AccionRealizarCadena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ActualizarAdn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ActualizarADN");
            entity.Property(e => e.Adn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADN");
            entity.Property(e => e.AplicacionPlataforma)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CambiosAdn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CambiosADN");
            entity.Property(e => e.CarpetaRequisitos)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClasificacionDesarrollo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorregirRequisitos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cotizacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CotizacionAceptada)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DentroAdn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DentroADN");
            entity.Property(e => e.DentroPoe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DentroPOE");
            entity.Property(e => e.DependenciaAreas)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.DuracionEstimada1).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada2).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada3).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada4).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada5).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada6).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada7).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada8).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada9).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.EnEsperaDe)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDeSolicitudDeAnalisisCambioMayor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaLimiteCambioMayor)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Finalizado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.FrecuenciaReporte)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HoraCitaPatrocinio)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HorasCompletadas).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.HorasContratadas).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.HorasDisponibles).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.HorasEstimadas).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.HorasTotales).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.Identificador).HasDefaultValue(0);
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IntegrarCadena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Interpretacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Medio)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MotivoRechazo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MotivoReestimacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Necesidad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreCadena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesCierre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesRequisitos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Patrocinador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PromedioDeHoras).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.QuienReportoError)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RequisitosConfirmados)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RequisitosTarea1).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea2).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea3).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea4).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea5).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea6).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea7).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea8).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea9).HasColumnType("text");
            entity.Property(e => e.ResponsableEstimacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ResultadoAceptadoSolicitante)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoCorreccionError)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoDeSolicitudEs)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoDelPatrocinio)
                .HasMaxLength(355)
                .IsUnicode(false);
            entity.Property(e => e.Sc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Screferencia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SCReferencia");
            entity.Property(e => e.SeleccionQa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SeleccionQA");
            entity.Property(e => e.SistemaInvolucrado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SituacionActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sla)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SLA");
            entity.Property(e => e.Tarea1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TareaActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoDeAnalisis)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TipoEstimacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TipoSc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TotalHorasOdt1).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt2).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt3).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt4).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt5).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt6).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt7).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt8).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt9).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasSc).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.ValidacionDiferida)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<FlokzuScdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuSCDate");

            entity.Property(e => e.Area1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.HorasTotales).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ScId).ValueGeneratedOnAdd();
            entity.Property(e => e.Tarea1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea9)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuScfa>(entity =>
        {
            entity.HasKey(e => e.ScfaId);

            entity.ToTable("FlokzuScfa");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CarpetaRequisitos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Dependencia)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaBorrador).HasColumnType("datetime");
            entity.Property(e => e.FechaEstimacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEstimada).HasColumnType("datetime");
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.Informacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Proyecto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Scfa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuScindicadore>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuSCIndicadores");

            entity.Property(e => e.AccionRealizarCadena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ActualizarAdn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ActualizarADN");
            entity.Property(e => e.Adn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADN");
            entity.Property(e => e.AplicacionPlataforma)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CambiosAdn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CambiosADN");
            entity.Property(e => e.CarpetaRequisitos)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ClasificacionDesarrollo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorregirRequisitos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cotizacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CotizacionAceptada)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DentroAdn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DentroADN");
            entity.Property(e => e.DentroPoe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DentroPOE");
            entity.Property(e => e.DependenciaAreas)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.DuracionEstimada1).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada2).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada3).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada4).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada5).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada6).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada7).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada8).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.DuracionEstimada9).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.EnEsperaDe)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCargaDeReglas).HasColumnType("datetime");
            entity.Property(e => e.FechaCierreFinal)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitudFinal)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Finalizado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp).HasColumnType("datetime");
            entity.Property(e => e.FrecuenciaReporte)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HoraCitaPatrocinio)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HorasCompletadas).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.HorasContratadas).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.HorasDisponibles).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.HorasEstimadas).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.HorasTotales).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IntegrarCadena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Interpretacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Medio)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Mes)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MotivoRechazo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MotivoReestimacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Necesidad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreCadena)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesCierre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesRequisitos)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Odt9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Patrocinador)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Pr)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PromedioDeHoras).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.QuienReportoError)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RequisitosConfirmados)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RequisitosTarea1).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea2).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea3).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea4).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea5).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea6).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea7).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea8).HasColumnType("text");
            entity.Property(e => e.RequisitosTarea9).HasColumnType("text");
            entity.Property(e => e.ResponsableEstimacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoAceptadoSolicitante)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoCorreccionError)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoDeSolicitudEs)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResultadoDelPatrocinio)
                .HasMaxLength(355)
                .IsUnicode(false);
            entity.Property(e => e.Sc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ScId).ValueGeneratedOnAdd();
            entity.Property(e => e.SeleccionQa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SeleccionQA");
            entity.Property(e => e.SistemaInvolucrado)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SituacionActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea1)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea2)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea3)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea4)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea5)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea6)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea7)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea8)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea9)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TareaActual)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoEstimacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoSc)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotalHorasOdt1).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt2).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt3).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt4).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt5).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt6).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt7).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt8).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasOdt9).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.TotalHorasSc).HasColumnType("decimal(25, 2)");
            entity.Property(e => e.ValidacionDiferida)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuSponsor>(entity =>
        {
            entity.HasKey(e => e.SponsorId).HasName("PK_SponsorId");

            entity.HasIndex(e => e.Sc, "sc_flokzusponsors").IsUnique();

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Comentarios)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaAtencion).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Recordate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Sc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SC");
            entity.Property(e => e.Sponsor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasDefaultValueSql("('1')");
        });

        modelBuilder.Entity<FlokzuSync>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FlokzuSync");

            entity.Property(e => e.Estatus).HasMaxLength(50);
            entity.Property(e => e.FechaDeCierre).HasColumnName("Fecha_de_cierre");
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.Identificador).HasMaxLength(50);
        });

        modelBuilder.Entity<FlokzuToDo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuToDo");

            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaEstimada).HasColumnType("datetime");
            entity.Property(e => e.FechaSoliciud).HasColumnType("datetime");
            entity.Property(e => e.Proceso)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("proceso");
            entity.Property(e => e.Requisito).HasColumnType("text");
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FlokzuTpe>(entity =>
        {
            entity.HasKey(e => e.TpeId).HasName("PK_TPE");

            entity.ToTable("FlokzuTpe");

            entity.Property(e => e.ActividadTpe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ActividadTPE");
            entity.Property(e => e.AlcancePreliminar)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Asignacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Contacto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CorreoSolicitante)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");
            entity.Property(e => e.FilaSmartSheet)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.HorasDedicadas).HasColumnType("text");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Iniciativa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NodePr)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NodePR");
            entity.Property(e => e.NombreProyecto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumeroTpe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NumeroTPE");
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("TPE");
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tarea)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoActividad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoPr)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TipoPR");
            entity.Property(e => e.Tpe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("TPE");
        });

        modelBuilder.Entity<FlokzuVac>(entity =>
        {
            entity.HasKey(e => e.VacId).HasName("PK__FlokzuVA__15F4D6FDB700C3C8");

            entity.ToTable("FlokzuVac");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Colaborador)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ComentariosAdministracion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Conteo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DiasVacaciones)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuTimestamp)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.JefeInmediato)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MotivoRechazo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ObservacionesJefeDirecto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("VAC");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Rol)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Vac)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("VAC");
        });

        modelBuilder.Entity<FlokzuViewMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FlokzuViewMaster");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Año)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Estatus)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaEstimada)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaFinal)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaInicial)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Interpretacion).HasColumnType("text");
            entity.Property(e => e.Mes)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.MotivoCancelacion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Procces)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProccesType)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Programa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Responsable)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Segmento)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.SegmentoEstimado)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HelpDeskActivity>(entity =>
        {
            entity.HasKey(e => e.HelpDeskActivitiesId);

            entity.Property(e => e.ActivityKeyword)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ActivityName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.IActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("i_Active");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<InformationArea>(entity =>
        {
            entity.HasKey(e => e.AreaId);

            entity.Property(e => e.AreaId).ValueGeneratedOnAdd();
            entity.Property(e => e.AreaName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.EnterpriseId).HasDefaultValue((byte)1);
            entity.Property(e => e.RecordDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<InformationContractManagement>(entity =>
        {
            entity.HasKey(e => e.ContractId);

            entity.ToTable("InformationContractManagement");

            entity.Property(e => e.Acondicionamiento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AreaDisponible)
                .HasDefaultValue(0.0m)
                .HasColumnType("decimal(7, 2)");
            entity.Property(e => e.CajonesEstacionamiento).HasColumnName("cajonesEstacionamiento");
            entity.Property(e => e.DepositoGarantia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("depositoGarantia");
            entity.Property(e => e.EmpresaId).HasDefaultValue((byte)0);
            entity.Property(e => e.Estatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FinDeContrato).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Incremento)
                .HasDefaultValue(0.0m)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("Incremento%");
            entity.Property(e => e.IncrementoMonto)
                .HasDefaultValue(0.0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InicioDeContrato).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Inquilino)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Monto)
                .HasDefaultValue(0.0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Piso).HasDefaultValue((byte)0);
            entity.Property(e => e.PolizaResponsabilidadCivil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.PrecioPorMetro)
                .HasDefaultValue(1.0m)
                .HasColumnType("decimal(8, 4)");
            entity.Property(e => e.RecordDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ZonaEdificio)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InformationEnterprise>(entity =>
        {
            entity.HasKey(e => e.EnterpriseId);

            entity.Property(e => e.EnterpriseId).ValueGeneratedOnAdd();
            entity.Property(e => e.EnterpriseName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<InformationInventory>(entity =>
        {
            entity.HasKey(e => e.InventoryId);

            entity.ToTable("InformationInventory");

            entity.Property(e => e.Active).HasDefaultValue(false);
            entity.Property(e => e.AsignationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.AsignationTo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DischargeCause)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DischargeDate).HasDefaultValueSql("('')");
            entity.Property(e => e.IsNew).HasColumnName("isNew");
            entity.Property(e => e.RecordDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RecordKey)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RecordLastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RegistrantUserId).HasDefaultValue(0);
            entity.Property(e => e.Responsive)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("NO");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UpdateUserId).HasDefaultValue(0);
        });

        modelBuilder.Entity<InformationInventoryUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.LastDateLogin)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordKey)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserActive).HasDefaultValue(1);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserProfileId).HasDefaultValue(1);
        });

        modelBuilder.Entity<InformationObject>(entity =>
        {
            entity.HasKey(e => e.ObjectId);

            entity.ToTable("InformationObject");

            entity.Property(e => e.Object)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InformationObjectRelationship>(entity =>
        {
            entity.HasKey(e => e.ObjectRelationshipId).HasName("PK_InformationObjectDependencies");

            entity.ToTable("InformationObjectRelationship");

            entity.Property(e => e.ObjectIdRelationship).HasColumnName("ObjectId_relationship");
            entity.Property(e => e.ObjectIdSource).HasColumnName("ObjectId_source");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InformationObjectSource>(entity =>
        {
            entity.HasKey(e => e.ObjectSourceId).HasName("PK_InformationObjectSources");

            entity.ToTable("InformationObjectSource");

            entity.Property(e => e.ObjectSource)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InformationObjectSourceType>(entity =>
        {
            entity.HasKey(e => e.ObjectSourceTypeId);

            entity.ToTable("InformationObjectSourceType");

            entity.Property(e => e.ObjectSourceType)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ObjectSourceTypeKeyword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<InformationObjectType>(entity =>
        {
            entity.HasKey(e => e.ObjectTypeId).HasName("PK_informationObjectTypes");

            entity.Property(e => e.ObjectKeyword)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.ObjectType)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<JobStep>(entity =>
        {
            entity.HasKey(e => e.JobStepsId);

            entity.Property(e => e.IActive)
                .HasDefaultValue((byte)1)
                .HasColumnName("i_Active");
            entity.Property(e => e.JobDescription)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.JobKeyword)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StatusLayer)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MatrizAcceso>(entity =>
        {
            entity.HasKey(e => e.AccesoId).HasName("PK_MatrizAccess");

            entity.Property(e => e.Acceso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstatusId).HasDefaultValue(1);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FrecuenciaActualizacon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Perfil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reference)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ResponsableActualizacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Servidor)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.TipoAcceso)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationsId);

            entity.Property(e => e.Notification1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Notification");
            entity.Property(e => e.NotificationActive).HasDefaultValue((byte)1);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<OperationsLog>(entity =>
        {
            entity.Property(e => e.CardAffiliationId).HasDefaultValue(0L);
            entity.Property(e => e.CardNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OperationDateBegin)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OperationDateEnd).HasColumnType("datetime");
            entity.Property(e => e.OperationEndFlag).HasDefaultValue(false);
            entity.Property(e => e.OperationErrorId).HasDefaultValue(0);
            entity.Property(e => e.OperationInput).HasColumnType("text");
            entity.Property(e => e.OperationIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OperationIP");
            entity.Property(e => e.OperationOutput)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OperationOutputType)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TransactionId).HasDefaultValue(0L);
            entity.Property(e => e.TransactionNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WebService)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WebServiceKey)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrigisPendiente>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_OrigisPendientesSync");

            entity.Property(e => e.Asignacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Cliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DiasRetrasoAbierta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiasRetrasoEntregadas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EjecutivoCuenta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.Estimacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaEstimacion).HasColumnType("datetime");
            entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitudAnio)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HorasCuentas)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HorasDesarrollo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HorasDireccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HorasDiseño)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.HorasInformacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.Proyecto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("NA");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Solicitante)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Solicitud)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SolicitudActividad)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SolicitudNumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("0");
            entity.Property(e => e.SolicitudPrioridad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SolicitudStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.Property(e => e.OwnerFile)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.OwnerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OwnerPrefix)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<OwnerIntegration>(entity =>
        {
            entity.HasKey(e => e.OwnerIntegrationsId);

            entity.Property(e => e.ConnectionName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IntegrationDate).HasColumnType("datetime");
            entity.Property(e => e.ItemOwnerProgram)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastComment)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.MailSubject)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Mes)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OwnerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordFile)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RecordLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<OwnerItemProgram>(entity =>
        {
            entity.HasKey(e => e.ProgramId);

            entity.ToTable("OwnerItemProgram");

            entity.Property(e => e.ProgramActive).HasDefaultValue((byte)1);
            entity.Property(e => e.ProgramName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<OwnerRequest>(entity =>
        {
            entity.ToTable("OwnerRequest");

            entity.HasIndex(e => e.RequestNumber, "UQ__OwnerReq__9ADA6BE03927C32C").IsUnique();

            entity.Property(e => e.AsignationDate)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.DeliveryDate)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.EstimationDate).HasColumnType("datetime");
            entity.Property(e => e.LastComment)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OwnerRequestSync).HasDefaultValue((byte)0);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ReleasedDate).HasColumnType("datetime");
            entity.Property(e => e.Request)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
            entity.Property(e => e.RequestNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.WorkHours)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OwnersProgram>(entity =>
        {
            entity.HasKey(e => e.Recordid);

            entity.Property(e => e.FlokzuCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FLokzuCliente");
            entity.Property(e => e.FlokzuCuenta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FlokzuPrograma)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OwnerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<Password>(entity =>
        {
            entity.HasKey(e => e.Idpass).HasName("PK__Password__8A5C9C63DEC3E1A0");

            entity.ToTable("Password");

            entity.Property(e => e.Idpass).HasColumnName("IDPass");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("FECHA");
            entity.Property(e => e.Idusuario).HasColumnName("IDUsuario");
            entity.Property(e => e.Password1)
                .HasMaxLength(1)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Recorddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
        });

        modelBuilder.Entity<Passwordu>(entity =>
        {
            entity.HasKey(e => e.Idpassword).HasName("PK__PASSWORD__188C019892F37F72");

            entity.ToTable("PASSWORDU");

            entity.Property(e => e.Idpassword).HasColumnName("IDPASSWORD");
            entity.Property(e => e.Iduser).HasColumnName("IDUSER");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Recorddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");

            entity.HasOne(d => d.IduserNavigation).WithMany(p => p.Passwordus)
                .HasForeignKey(d => d.Iduser)
                .HasConstraintName("FK__PASSWORDU__IDUSE__7B7C1933");
        });

        modelBuilder.Entity<Requeriment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Requeriments");

            entity.Property(e => e.Asignacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comentarios)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.DiasRetrasoAbierta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DiasRetrasoEntregadas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EjecutivoCuenta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Estimacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr10)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Expr11)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr12)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr13)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr14)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Expr15).HasColumnType("datetime");
            entity.Property(e => e.Expr16).HasColumnType("datetime");
            entity.Property(e => e.Expr17).HasColumnType("datetime");
            entity.Property(e => e.Expr18).HasColumnType("datetime");
            entity.Property(e => e.Expr19).HasColumnType("datetime");
            entity.Property(e => e.Expr2).HasColumnType("datetime");
            entity.Property(e => e.Expr20)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr21)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr22)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr23)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr24)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr25)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr26)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr27)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Expr28)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr3)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Expr4)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Expr5)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Expr6)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Expr7)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expr8)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Expr9)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEntrega).HasColumnType("datetime");
            entity.Property(e => e.FechaEstimacion).HasColumnType("datetime");
            entity.Property(e => e.FechaLiberacion).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.FechaSolicitudAnio)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HorasCuentas)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasDesarrollo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasDireccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasDiseño)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HorasInformacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proyecto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Solicitante)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Solicitud)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SolicitudActividad)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.SolicitudNumero)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SolicitudPrioridad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SolicitudStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RulesImpact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RulesImpact");

            entity.Property(e => e.ConnectionName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.FechaFinal)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Final");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Inicio");
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemOwnerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Itemsku)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Regla)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.RulePublishStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoBeneficio)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RulesImpactV2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RulesImpactV2");

            entity.Property(e => e.CardType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ConnectionName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ItemName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ItemOwnerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ItemSku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ItemSKU");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RegistrantUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Regla)
                .HasMaxLength(49)
                .IsUnicode(false);
            entity.Property(e => e.RewardSelect)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RuleActivationDate).HasColumnType("datetime");
            entity.Property(e => e.RuleExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.RuleKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RuleName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RulesOrbisRed>(entity =>
        {
            entity.HasKey(e => e.RulesOrbisRedId).HasName("PK_FRulesOrbisRed");

            entity.ToTable("RulesOrbisRed");

            entity.Property(e => e.AuthorizationDate).HasColumnType("datetime");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CompleteDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.FileReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference01)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RejectedDate).HasColumnType("datetime");
            entity.Property(e => e.RuleInvoice)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RuleTag)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StatusId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RulesOrbisRedContent>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_RulesOrbisRedFile");

            entity.ToTable("RulesOrbisRedContent");

            entity.Property(e => e.Alcance)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Auth)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Division)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HasDev)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hasDev");
            entity.Property(e => e.InicioVigencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IsActive)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("1");
            entity.Property(e => e.ItemExist)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("1");
            entity.Property(e => e.ItemExistFa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ItemExistOrbis)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Limite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LoadRule)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Mecanica)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Opo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlanApegoPropias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RegisterUserId).HasDefaultValueSql("('0')");
            entity.Property(e => e.RuleFa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RuleOrbis)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RulesOrbisRedId).HasDefaultValueSql("('0')");
            entity.Property(e => e.TypeRule)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<RulesOrbisRedContentLog>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_RulesOrbisRedLogId");

            entity.ToTable("RulesOrbisRedContentLog");

            entity.Property(e => e.Alcance)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Auth)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.Division)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FinVigencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InicioVigencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Limite)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mecanica)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasColumnType("text");
            entity.Property(e => e.Opo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PlanApegoPropias)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Proveedor)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.RegisterUserId).HasDefaultValueSql("('0')");
            entity.Property(e => e.RulesOrbisRedLogId).HasDefaultValueSql("('0')");
            entity.Property(e => e.UserId).HasDefaultValueSql("('0')");
        });

        modelBuilder.Entity<RulesOrbisRedLog>(entity =>
        {
            entity.HasKey(e => e.RulesOrbisRedLogId).HasName("PK_FRulesOrbisRedLog");

            entity.ToTable("RulesOrbisRedLog");

            entity.Property(e => e.AuthorizationDate).HasColumnType("datetime");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CompleteDate).HasColumnType("datetime");
            entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
            entity.Property(e => e.FileReference)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference01)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.RejectedDate).HasColumnType("datetime");
            entity.Property(e => e.RuleInvoice)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RuleTag)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StatusId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StatusPending>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("StatusPending");

            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate).HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TabDataMart>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tabDataMart");

            entity.Property(e => e.Actividad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Area)
                .HasMaxLength(20)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.Clasificacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Dependencia).HasDefaultValue(false);
            entity.Property(e => e.EnEsperaDe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Estatus)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaCierre).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaEstimada).HasDefaultValueSql("('')");
            entity.Property(e => e.FechaSolicitud).HasDefaultValueSql("('')");
            entity.Property(e => e.Horas)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Iniciador)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Interpretacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.NombreCadena)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Programa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.ResultadoCorreccionError)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SubTipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SubTipoId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Tarea)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TareaActual)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.TipoId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<TabFlokzuActivity>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK_tabFlokzu");

            entity.ToTable("tabFlokzuActivities");

            entity.Property(e => e.Actividad)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DiasVacaciones).HasDefaultValue((byte)0);
            entity.Property(e => e.Faproyecto)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FAProyecto");
            entity.Property(e => e.Horas).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Proceso)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Programa)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Sc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SC");
            entity.Property(e => e.Scestatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SCEstatus");
            entity.Property(e => e.Scfa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SCFA");
            entity.Property(e => e.ScfechaCierre).HasColumnName("SCFechaCierre");
            entity.Property(e => e.ScfechaEntrega).HasColumnName("SCFechaEntrega");
            entity.Property(e => e.ScfechaEstimada).HasColumnName("SCFechaEstimada");
            entity.Property(e => e.ScfechaSolicitud).HasColumnName("SCFechaSolicitud");
            entity.Property(e => e.Scid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SCId");
            entity.Property(e => e.TipoProceso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Vac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VAC");
        });

        modelBuilder.Entity<TabFlokzuSc>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("tabFlokzuSC");

            entity.Property(e => e.Estatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FechaSolicitud).HasColumnType("datetime");
            entity.Property(e => e.RecordDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RecordSource)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Sc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SC");
            entity.Property(e => e.Scid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SCId");
        });

        modelBuilder.Entity<TabFlokzuVac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tabFlokzuVac");

            entity.Property(e => e.Area)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Fecha).HasDefaultValueSql("('')");
            entity.Property(e => e.Horas)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordId).ValueGeneratedOnAdd();
            entity.Property(e => e.RecordSource)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Vac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<TabRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("tabRequests");

            entity.Property(e => e.AsignationDate)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.DeliveryDate)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstimationDate)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.OwnerName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Priority)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ReleasedDate)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.RequestDate)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.StatusName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Idusuario).HasName("PK__USERS__52311169EC6A994F");

            entity.ToTable("USERS");

            entity.Property(e => e.Idusuario).HasColumnName("IDUsuario");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("FECHA");
            entity.Property(e => e.Password)
                .HasMaxLength(1)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Recorddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
        });

        modelBuilder.Entity<UserConfiguration>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("UserConfiguration");

            entity.Property(e => e.AreaFlokzu)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.FlokzuEmail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GenderId).HasDefaultValueSql("('1')");
            entity.Property(e => e.Horario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("horario");
            entity.Property(e => e.ICalendarPermission)
                .HasDefaultValue((byte)1)
                .HasColumnName("i_CalendarPermission");
            entity.Property(e => e.IContactPermission)
                .HasDefaultValue((byte)1)
                .HasColumnName("i_ContactPermission");
            entity.Property(e => e.ISettlement).HasColumnName("i_settlement");
            entity.Property(e => e.RecordDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordLastDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordSourse)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UserAccess)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserActive).HasDefaultValue((byte)1);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserFlokzu)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserProfileKeyword)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usersu>(entity =>
        {
            entity.HasKey(e => e.Iduser).HasName("PK__USERSU__94F7C0599D6DFC35");

            entity.ToTable("USERSU");

            entity.Property(e => e.Iduser).HasColumnName("IDUSER");
            entity.Property(e => e.Nameu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAMEU");
            entity.Property(e => e.Recorddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("RECORDDATE");
        });

        modelBuilder.Entity<UsuariosFlokzuAcceso>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UsuariosFlokzuAcceso");

            entity.Property(e => e.AreaFlokzu)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Horario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("horario");
            entity.Property(e => e.RecordId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserAccess)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserFlokzu)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserProfileKeyword)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
