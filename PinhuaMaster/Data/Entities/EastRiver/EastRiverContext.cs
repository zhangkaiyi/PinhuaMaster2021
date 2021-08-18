using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PinhuaMaster.Data.Entities.EastRiver
{
    public partial class EastRiverContext : DbContext
    {
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AdJustHrsD> AdJustHrsD { get; set; }
        public virtual DbSet<AdJustHrsM> AdJustHrsM { get; set; }
        public virtual DbSet<AdJustRestD> AdJustRestD { get; set; }
        public virtual DbSet<AdJustRestM> AdJustRestM { get; set; }
        public virtual DbSet<AllowanceTempD> AllowanceTempD { get; set; }
        public virtual DbSet<AllowanceTempM> AllowanceTempM { get; set; }
        public virtual DbSet<Archs> Archs { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AreaConfig> AreaConfig { get; set; }
        public virtual DbSet<AssignEmp> AssignEmp { get; set; }
        public virtual DbSet<BatchCard> BatchCard { get; set; }
        public virtual DbSet<BlackCardTask> BlackCardTask { get; set; }
        public virtual DbSet<BlackCardTaskClockState> BlackCardTaskClockState { get; set; }
        public virtual DbSet<BookInfoLog> BookInfoLog { get; set; }
        public virtual DbSet<BookLog> BookLog { get; set; }
        public virtual DbSet<BusinessTolReport> BusinessTolReport { get; set; }
        public virtual DbSet<CardAppType> CardAppType { get; set; }
        public virtual DbSet<CardType> CardType { get; set; }
        public virtual DbSet<CardTypeConfig> CardTypeConfig { get; set; }
        public virtual DbSet<Citys> Citys { get; set; }
        public virtual DbSet<ClockBlackCard> ClockBlackCard { get; set; }
        public virtual DbSet<ClockDefaultParam> ClockDefaultParam { get; set; }
        public virtual DbSet<ClockMallowanceCard> ClockMallowanceCard { get; set; }
        public virtual DbSet<ClockParams> ClockParams { get; set; }
        public virtual DbSet<ClockParamTask> ClockParamTask { get; set; }
        public virtual DbSet<ClockPassCard> ClockPassCard { get; set; }
        public virtual DbSet<Clocks> Clocks { get; set; }
        public virtual DbSet<ClocksDayAccountBook> ClocksDayAccountBook { get; set; }
        public virtual DbSet<ClockWhiteCard> ClockWhiteCard { get; set; }
        public virtual DbSet<ClosingAccount> ClosingAccount { get; set; }
        public virtual DbSet<CommMsg> CommMsg { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<DataBaseConfig> DataBaseConfig { get; set; }
        public virtual DbSet<DataMoveDetails> DataMoveDetails { get; set; }
        public virtual DbSet<DataMoveRecords> DataMoveRecords { get; set; }
        public virtual DbSet<Degrees> Degrees { get; set; }
        public virtual DbSet<Departs> Departs { get; set; }
        public virtual DbSet<DepositConfig> DepositConfig { get; set; }
        public virtual DbSet<DeviceType> DeviceType { get; set; }
        public virtual DbSet<DimissionTypes> DimissionTypes { get; set; }
        public virtual DbSet<DinClockConfig> DinClockConfig { get; set; }
        public virtual DbSet<DinLev> DinLev { get; set; }
        public virtual DbSet<DinRoom> DinRoom { get; set; }
        public virtual DbSet<DinRoomDayAccountBook> DinRoomDayAccountBook { get; set; }
        public virtual DbSet<DinRoomMonthAccountBook> DinRoomMonthAccountBook { get; set; }
        public virtual DbSet<DinRoomRecords> DinRoomRecords { get; set; }
        public virtual DbSet<DoorAndEmp> DoorAndEmp { get; set; }
        public virtual DbSet<DoorAndMachine> DoorAndMachine { get; set; }
        public virtual DbSet<DoorCardAndMachine> DoorCardAndMachine { get; set; }
        public virtual DbSet<DoorConnected> DoorConnected { get; set; }
        public virtual DbSet<DoorInfo> DoorInfo { get; set; }
        public virtual DbSet<DoorListGroup> DoorListGroup { get; set; }
        public virtual DbSet<DoorListMember> DoorListMember { get; set; }
        public virtual DbSet<DoorTimeBound> DoorTimeBound { get; set; }
        public virtual DbSet<Dorm> Dorm { get; set; }
        public virtual DbSet<EmealRecords> EmealRecords { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeAccount> EmployeeAccount { get; set; }
        public virtual DbSet<EmployeeCard> EmployeeCard { get; set; }
        public virtual DbSet<EmpPicArc> EmpPicArc { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<Idcard> Idcard { get; set; }
        public virtual DbSet<InitTransRecords> InitTransRecords { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<LeaveD> LeaveD { get; set; }
        public virtual DbSet<LeaveM> LeaveM { get; set; }
        public virtual DbSet<LeaveType> LeaveType { get; set; }
        public virtual DbSet<LoginCard> LoginCard { get; set; }
        public virtual DbSet<LookUpConfig> LookUpConfig { get; set; }
        public virtual DbSet<Mallowance> Mallowance { get; set; }
        public virtual DbSet<MallowanceCardTask> MallowanceCardTask { get; set; }
        public virtual DbSet<MapDots> MapDots { get; set; }
        public virtual DbSet<Maps> Maps { get; set; }
        public virtual DbSet<McardCost> McardCost { get; set; }
        public virtual DbSet<MchangeCard> MchangeCard { get; set; }
        public virtual DbSet<MchargeRecords> MchargeRecords { get; set; }
        public virtual DbSet<MealMonth> MealMonth { get; set; }
        public virtual DbSet<MealRecords> MealRecords { get; set; }
        public virtual DbSet<MealSecondRecords> MealSecondRecords { get; set; }
        public virtual DbSet<MeetingBackground> MeetingBackground { get; set; }
        public virtual DbSet<MeetingD> MeetingD { get; set; }
        public virtual DbSet<MeetingGroupsD> MeetingGroupsD { get; set; }
        public virtual DbSet<MeetingGroupsM> MeetingGroupsM { get; set; }
        public virtual DbSet<MeetingM> MeetingM { get; set; }
        public virtual DbSet<MeetingRoom> MeetingRoom { get; set; }
        public virtual DbSet<MeetSignCardD> MeetSignCardD { get; set; }
        public virtual DbSet<MeetSignCardM> MeetSignCardM { get; set; }
        public virtual DbSet<ModifyShiftD> ModifyShiftD { get; set; }
        public virtual DbSet<ModifyShiftM> ModifyShiftM { get; set; }
        public virtual DbSet<MotherCard> MotherCard { get; set; }
        public virtual DbSet<Mrefund> Mrefund { get; set; }
        public virtual DbSet<MsgManager> MsgManager { get; set; }
        public virtual DbSet<MuserSql> MuserSql { get; set; }
        public virtual DbSet<Nations> Nations { get; set; }
        public virtual DbSet<Natives> Natives { get; set; }
        public virtual DbSet<OnLineId> OnLineId { get; set; }
        public virtual DbSet<OnlineRecords> OnlineRecords { get; set; }
        public virtual DbSet<OnlineRules> OnlineRules { get; set; }
        public virtual DbSet<OpLog> OpLog { get; set; }
        public virtual DbSet<OrderDinOp> OrderDinOp { get; set; }
        public virtual DbSet<OrderDinTab> OrderDinTab { get; set; }
        public virtual DbSet<OrderdintabE> OrderdintabE { get; set; }
        public virtual DbSet<Outcarddata> Outcarddata { get; set; }
        public virtual DbSet<OutWorkD> OutWorkD { get; set; }
        public virtual DbSet<OutWorkM> OutWorkM { get; set; }
        public virtual DbSet<OverTimeDetail> OverTimeDetail { get; set; }
        public virtual DbSet<PassTime> PassTime { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<RealCardState> RealCardState { get; set; }
        public virtual DbSet<RealErrCodeTb> RealErrCodeTb { get; set; }
        public virtual DbSet<RealMealInfo> RealMealInfo { get; set; }
        public virtual DbSet<RealTime> RealTime { get; set; }
        public virtual DbSet<RefuseRegD> RefuseRegD { get; set; }
        public virtual DbSet<RefuseRegM> RefuseRegM { get; set; }
        public virtual DbSet<RegOverTime> RegOverTime { get; set; }
        public virtual DbSet<Reminds> Reminds { get; set; }
        public virtual DbSet<RemindsBak> RemindsBak { get; set; }
        public virtual DbSet<RepairTransRecords> RepairTransRecords { get; set; }
        public virtual DbSet<ReplaceRegD> ReplaceRegD { get; set; }
        public virtual DbSet<ReplaceRegM> ReplaceRegM { get; set; }
        public virtual DbSet<ReportDay> ReportDay { get; set; }
        public virtual DbSet<ReportMonth> ReportMonth { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ReturnCard> ReturnCard { get; set; }
        public virtual DbSet<Rules> Rules { get; set; }
        public virtual DbSet<Scheme> Scheme { get; set; }
        public virtual DbSet<ShellTable> ShellTable { get; set; }
        public virtual DbSet<Shifts> Shifts { get; set; }
        public virtual DbSet<ShiftsRule> ShiftsRule { get; set; }
        public virtual DbSet<ShutDownD> ShutDownD { get; set; }
        public virtual DbSet<ShutDownM> ShutDownM { get; set; }
        public virtual DbSet<SignCardD> SignCardD { get; set; }
        public virtual DbSet<SignCardM> SignCardM { get; set; }
        public virtual DbSet<SignInRecord> SignInRecord { get; set; }
        public virtual DbSet<SmealRecords> SmealRecords { get; set; }
        public virtual DbSet<Smsconfig> Smsconfig { get; set; }
        public virtual DbSet<Sysparams> Sysparams { get; set; }
        public virtual DbSet<TaskLogs> TaskLogs { get; set; }
        public virtual DbSet<TbDoorConfigFor988> TbDoorConfigFor988 { get; set; }
        public virtual DbSet<TextType> TextType { get; set; }
        public virtual DbSet<TimePicRecords> TimePicRecords { get; set; }
        public virtual DbSet<TimePicRecordsHis> TimePicRecordsHis { get; set; }
        public virtual DbSet<TimeRecords> TimeRecords { get; set; }
        public virtual DbSet<TransCorrect> TransCorrect { get; set; }
        public virtual DbSet<TranslateD> TranslateD { get; set; }
        public virtual DbSet<TranslateM> TranslateM { get; set; }
        public virtual DbSet<TransRecords> TransRecords { get; set; }
        public virtual DbSet<Uimkey> Uimkey { get; set; }
        public virtual DbSet<UserDayAccountBook> UserDayAccountBook { get; set; }
        public virtual DbSet<UserLog> UserLog { get; set; }
        public virtual DbSet<UserMonthAccountBook> UserMonthAccountBook { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WhiteCardTask> WhiteCardTask { get; set; }

        // Unable to generate entity type for table 'dbo.Countys'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.delemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PriceHistory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DoorEvent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.timehelprecords'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TransCheckRule'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NumberPool'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TimeReport2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RealStateInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UpLoadTable'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.UpLoadTable_comp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TransTest'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MultiCard'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TDeparts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MReplaceCard'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CardKeyInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RemoveData'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.leaved_emps'. Please see the warning messages.

        public EastRiverContext(DbContextOptions<EastRiverContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.Ym);

                entity.Property(e => e.Ym)
                    .HasColumnName("ym")
                    .HasMaxLength(7)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .HasColumnName("account_name")
                    .HasMaxLength(20);

                entity.Property(e => e.BeginDate)
                    .HasColumnName("begin_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AdJustHrsD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId });

                entity.ToTable("adJustHrs_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CurDate)
                    .HasColumnName("cur_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HrsNum)
                    .HasColumnName("hrs_num")
                    .HasColumnType("numeric(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kind).HasColumnName("kind");

                entity.Property(e => e.LaterBTime)
                    .IsRequired()
                    .HasColumnName("later_bTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LaterDate)
                    .HasColumnName("later_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LaterETime)
                    .IsRequired()
                    .HasColumnName("later_eTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdJustHrsM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("adJustHrs_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HrsCause)
                    .HasColumnName("hrs_cause")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HrsNo)
                    .IsRequired()
                    .HasColumnName("hrs_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdJustRestD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId, e.RestDate });

                entity.ToTable("adJustRest_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32);

                entity.Property(e => e.RestDate)
                    .HasColumnName("rest_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OriBtime)
                    .HasColumnName("ori_btime")
                    .HasMaxLength(5);

                entity.Property(e => e.OriDate)
                    .HasColumnName("ori_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OriEtime)
                    .HasColumnName("ori_etime")
                    .HasMaxLength(5);

                entity.Property(e => e.RestBtime)
                    .HasColumnName("rest_btime")
                    .HasMaxLength(5);

                entity.Property(e => e.RestEtime)
                    .HasColumnName("rest_etime")
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<AdJustRestM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("adJustRest_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12);

                entity.Property(e => e.RestCause)
                    .HasColumnName("rest_cause")
                    .HasMaxLength(50);

                entity.Property(e => e.RestNo)
                    .IsRequired()
                    .HasColumnName("rest_no")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AllowanceTempD>(entity =>
            {
                entity.HasKey(e => new { e.TempCode, e.IndexId });

                entity.ToTable("AllowanceTemp_D");

                entity.Property(e => e.TempCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Deposit)
                    .HasColumnName("deposit")
                    .HasColumnType("money");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AllowanceTempM>(entity =>
            {
                entity.HasKey(e => e.TempCode);

                entity.ToTable("AllowanceTemp_M");

                entity.Property(e => e.TempCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TempName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Wallets)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Archs>(entity =>
            {
                entity.HasKey(e => e.ArchId);

                entity.Property(e => e.ArchId)
                    .HasColumnName("arch_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.ArchName)
                    .HasColumnName("arch_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.AreaId)
                    .HasColumnName("Area_id")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId1)
                    .HasColumnName("AreaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AreaName).HasMaxLength(30);

                entity.Property(e => e.Kind).HasDefaultValueSql("((0))");

                entity.Property(e => e.PareaId)
                    .HasColumnName("PAreaID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark).HasMaxLength(50);
            });

            modelBuilder.Entity<AreaConfig>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("char(4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssignEmp>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AreaId)
                    .HasColumnName("Area_id")
                    .HasMaxLength(12);

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("Card_id")
                    .HasMaxLength(16);

                entity.Property(e => e.ClockId).HasColumnName("Clock_id");

                entity.Property(e => e.Doors).HasMaxLength(10);

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kind).HasDefaultValueSql("((0))");

                entity.Property(e => e.Level).HasDefaultValueSql("((0))");

                entity.Property(e => e.LossMoney).HasColumnName("Loss_money");

                entity.Property(e => e.OpDate).HasColumnType("datetime");

                entity.Property(e => e.OpUser).HasMaxLength(20);

                entity.Property(e => e.PassTime).HasMaxLength(30);

                entity.Property(e => e.PassWord).HasMaxLength(12);

                entity.Property(e => e.SegTime).HasMaxLength(50);
            });

            modelBuilder.Entity<BatchCard>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.Property(e => e.LoginId).HasColumnName("Login_id");

                entity.Property(e => e.BeginCard)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CardLen).HasDefaultValueSql("((10))");

                entity.Property(e => e.LoginNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpDate)
                    .HasColumnName("opDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("opUser")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<BlackCardTask>(entity =>
            {
                entity.HasIndex(e => e.CardId)
                    .HasName("IX_BlackCardTask_Card_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BlackSequ)
                    .HasColumnName("Black_Sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_Sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cardtypecode)
                    .HasColumnName("cardtypecode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExecuteDate).HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Opdate)
                    .HasColumnName("opdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BlackCardTaskClockState>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.ClockId });

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.ClockId).HasColumnName("Clock_id");

                entity.Property(e => e.ExecuteDate).HasColumnType("datetime");

                entity.Property(e => e.RealCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookInfoLog>(entity =>
            {
                entity.HasIndex(e => e.CReceiver);

                entity.HasIndex(e => e.DLogTime);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CLogMsg)
                    .HasColumnName("cLogMsg")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CReceiver)
                    .HasColumnName("cReceiver")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CSender)
                    .HasColumnName("cSender")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DLogTime)
                    .HasColumnName("dLogTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DOpTime)
                    .HasColumnName("dOpTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.NLogType).HasColumnName("nLogType");
            });

            modelBuilder.Entity<BookLog>(entity =>
            {
                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.DOperateTime);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CDescription)
                    .HasColumnName("cDescription")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.COperator)
                    .HasColumnName("cOperator")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DOperateTime)
                    .HasColumnName("dOperateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.NBookType).HasColumnName("nBookType");

                entity.Property(e => e.NDinRoomBalance)
                    .HasColumnName("nDinRoomBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NUserBalance)
                    .HasColumnName("nUserBalance")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<BusinessTolReport>(entity =>
            {
                entity.HasKey(e => e.DAccDate);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardCost).HasColumnType("money");

                entity.Property(e => e.CardCostOut).HasColumnType("money");

                entity.Property(e => e.CloseCardCost).HasColumnType("money");

                entity.Property(e => e.CloseMaintenance).HasColumnType("money");

                entity.Property(e => e.DPrevAccDate)
                    .HasColumnName("dPrevAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Maintenance).HasColumnType("money");

                entity.Property(e => e.MaintenanceOut).HasColumnType("money");

                entity.Property(e => e.NAllowMeal)
                    .HasColumnName("nAllowMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NCardCharge)
                    .HasColumnName("nCardCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NCardInit)
                    .HasColumnName("nCardInit")
                    .HasColumnType("money");

                entity.Property(e => e.NCardReturn)
                    .HasColumnName("nCardReturn")
                    .HasColumnType("money");

                entity.Property(e => e.NCashPay)
                    .HasColumnName("nCashPay")
                    .HasColumnType("money");

                entity.Property(e => e.NCashReceive)
                    .HasColumnName("nCashReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeAllow)
                    .HasColumnName("nChargeAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeBatch)
                    .HasColumnName("nChargeBatch")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeBounds)
                    .HasColumnName("nChargeBounds")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeFix)
                    .HasColumnName("nChargeFix")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeGrayCash)
                    .HasColumnName("nChargeGrayCash")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeReceive)
                    .HasColumnName("nChargeReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeReturn)
                    .HasColumnName("nChargeReturn")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NCountMeal).HasColumnName("nCountMeal");

                entity.Property(e => e.NEveningAmount)
                    .HasColumnName("nEveningAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NInFixCharge)
                    .HasColumnName("nInFixCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayAllowCash)
                    .HasColumnName("nInGrayAllowCash")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayMealCash)
                    .HasColumnName("nInGrayMealCash")
                    .HasColumnType("money");

                entity.Property(e => e.NLoseAmount)
                    .HasColumnName("nLoseAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvAmount)
                    .HasColumnName("nMealEvAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvening).HasColumnName("nMealEvening");

                entity.Property(e => e.NMealMoAmount)
                    .HasColumnName("nMealMoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealMorning).HasColumnName("nMealMorning");

                entity.Property(e => e.NMealNiAmount)
                    .HasColumnName("nMealNiAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNight).HasColumnName("nMealNight");

                entity.Property(e => e.NMealNoAmount)
                    .HasColumnName("nMealNoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNoon).HasColumnName("nMealNoon");

                entity.Property(e => e.NMealOtAmount)
                    .HasColumnName("nMealOtAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealOther).HasColumnName("nMealOther");

                entity.Property(e => e.NMorningAmount)
                    .HasColumnName("nMorningAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NMorningTimes).HasColumnName("nMorningTimes");

                entity.Property(e => e.NNightAmount)
                    .HasColumnName("nNightAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NNightTimes).HasColumnName("nNightTimes");

                entity.Property(e => e.NNoonAmount)
                    .HasColumnName("nNoonAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NNoonTimes).HasColumnName("nNoonTimes");

                entity.Property(e => e.NOpenBalance)
                    .HasColumnName("nOpenBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NOrderMeal)
                    .HasColumnName("nOrderMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherAmount)
                    .HasColumnName("nOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherTimes).HasColumnName("nOtherTimes");

                entity.Property(e => e.NOutCard)
                    .HasColumnName("nOutCard")
                    .HasColumnType("money");

                entity.Property(e => e.NOutCountMeal).HasColumnName("nOutCountMeal");

                entity.Property(e => e.NOutFixMeal)
                    .HasColumnName("nOutFixMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutGrayMeal)
                    .HasColumnName("nOutGrayMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NQuanCash)
                    .HasColumnName("nQuanCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NReIssueCash)
                    .HasColumnName("nReIssueCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeveningTimes).HasColumnName("NEveningTimes");

                entity.Property(e => e.OpenCardCost).HasColumnType("money");

                entity.Property(e => e.OpenMaintenance).HasColumnType("money");
            });

            modelBuilder.Entity<CardAppType>(entity =>
            {
                entity.HasKey(e => e.AppIdx);

                entity.Property(e => e.AppIdx).ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BalanceValidity).HasDefaultValueSql("((3))");

                entity.Property(e => e.BalanceValidityFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardAppType1).HasColumnName("CardAppType");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser).HasMaxLength(32);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.MaxDebit)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpDate).HasColumnType("datetime");

                entity.Property(e => e.OpUser).HasMaxLength(32);

                entity.Property(e => e.WalletBalType).HasDefaultValueSql("((1))");

                entity.Property(e => e.WalletOverLimit).HasColumnType("money");
            });

            modelBuilder.Entity<CardType>(entity =>
            {
                entity.HasKey(e => e.CardType1);

                entity.Property(e => e.CardType1)
                    .HasColumnName("CardType")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttendFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DoorFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.OffLineMealFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CardTypeConfig>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("char(4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Citys>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CityName)
                    .HasColumnName("city_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClockBlackCard>(entity =>
            {
                entity.HasKey(e => new { e.ClockId, e.CardId });

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BlackSequ).HasColumnName("Black_Sequ");

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_Sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype).HasColumnName("cardtype");

                entity.Property(e => e.Cardtypecode)
                    .HasColumnName("cardtypecode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClockDefaultParam>(entity =>
            {
                entity.HasKey(e => e.Model);

                entity.Property(e => e.Model).ValueGeneratedNever();

                entity.Property(e => e.DefaultParam).HasColumnType("ntext");

                entity.Property(e => e.ListFmt)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecordFmt)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClockMallowanceCard>(entity =>
            {
                entity.HasKey(e => new { e.ClockId, e.CardId });

                entity.ToTable("ClockMAllowanceCard");

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype).HasColumnName("cardtype");

                entity.Property(e => e.Cardtypecode)
                    .HasColumnName("cardtypecode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeVer)
                    .HasColumnName("Charge_ver")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deposit).HasColumnType("money");

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ValidateBegin).HasColumnType("datetime");

                entity.Property(e => e.ValidateEnd).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClockParams>(entity =>
            {
                entity.HasKey(e => e.ClockId);

                entity.Property(e => e.ClockId)
                    .HasColumnName("Clock_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Groups)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RingTime)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TimePeriods)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClockParamTask>(entity =>
            {
                entity.HasIndex(e => new { e.ClockId, e.ExecuteDate })
                    .HasName("IX_ClockParamTask_ExecuteDate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.ExecuteDate).HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Opdate)
                    .HasColumnName("opdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.XmlParam)
                    .HasColumnName("xmlParam")
                    .HasColumnType("ntext");

                entity.Property(e => e.XmlResult)
                    .HasColumnName("xmlResult")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ClockPassCard>(entity =>
            {
                entity.HasKey(e => new { e.Clockid, e.CardId });

                entity.Property(e => e.Clockid).HasColumnName("clockid");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype).HasColumnName("cardtype");

                entity.Property(e => e.Cardtypecode)
                    .HasColumnName("cardtypecode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Opendoorpw)
                    .HasColumnName("opendoorpw")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Right)
                    .IsRequired()
                    .HasColumnName("right")
                    .HasColumnType("char(2)")
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.Timebound)
                    .HasColumnName("timebound")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Clocks>(entity =>
            {
                entity.HasKey(e => e.ClockId);

                entity.Property(e => e.ClockId)
                    .HasColumnName("Clock_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowanceId)
                    .HasColumnName("allowanceId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AreaId)
                    .HasColumnName("Area_id")
                    .HasMaxLength(12);

                entity.Property(e => e.BlackcardId)
                    .HasColumnName("blackcardId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardFormat).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClockModel)
                    .HasColumnName("Clock_Model")
                    .HasMaxLength(20);

                entity.Property(e => e.ClockName)
                    .HasColumnName("Clock_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ClockType)
                    .HasColumnName("Clock_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Consumetype)
                    .HasColumnName("consumetype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DinRoomId)
                    .HasColumnName("DinRoom_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Done)
                    .HasColumnName("done")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DoorType).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupParam).HasColumnType("ntext");

                entity.Property(e => e.Groups)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HolidSegTime).HasColumnType("ntext");

                entity.Property(e => e.IsCount).HasColumnName("isCount");

                entity.Property(e => e.Isic).HasColumnName("isic");

                entity.Property(e => e.Listfmt)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("Machine_ID")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MealParam).HasColumnType("ntext");

                entity.Property(e => e.NLogicalId).HasColumnName("nLogicalID");

                entity.Property(e => e.OutInType).HasMaxLength(10);

                entity.Property(e => e.ParityKind).HasColumnName("Parity_Kind");

                entity.Property(e => e.PassSegTime).HasColumnType("ntext");

                entity.Property(e => e.PointState).HasColumnType("ntext");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SetHolidDay).HasColumnType("ntext");

                entity.Property(e => e.Settingxml)
                    .HasColumnName("settingxml")
                    .HasColumnType("ntext");

                entity.Property(e => e.StateTime).HasColumnType("ntext");

                entity.Property(e => e.SupSegTime).HasColumnType("ntext");

                entity.Property(e => e.SupUser).HasColumnType("ntext");

                entity.Property(e => e.TcpipAddress)
                    .HasColumnName("TCPIP_Address")
                    .HasMaxLength(15);

                entity.Property(e => e.TcpipModel).HasColumnName("TCPIP_Model");

                entity.Property(e => e.TcpipPassWord)
                    .HasColumnName("TCPIP_PassWord")
                    .HasMaxLength(12);

                entity.Property(e => e.TcpipPort).HasColumnName("TCPIP_Port");

                entity.Property(e => e.TcpipType).HasColumnName("TCPIP_type");

                entity.Property(e => e.UseType).HasMaxLength(20);

                entity.Property(e => e.VerNo)
                    .HasColumnName("verNo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhitecardId)
                    .HasColumnName("whitecardId")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wrparam)
                    .HasColumnName("WRParam")
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ClocksDayAccountBook>(entity =>
            {
                entity.HasKey(e => new { e.CDinRoomId, e.NClockId, e.DAccDate });

                entity.HasIndex(e => e.DAccDate);

                entity.Property(e => e.CDinRoomId)
                    .HasColumnName("cDinRoomID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NClockId).HasColumnName("nClockID");

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardCost).HasColumnType("money");

                entity.Property(e => e.CardCostOut).HasColumnType("money");

                entity.Property(e => e.CloseCardCost).HasColumnType("money");

                entity.Property(e => e.CloseMaintenance).HasColumnType("money");

                entity.Property(e => e.DPrevAccDate)
                    .HasColumnName("dPrevAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Maintenance).HasColumnType("money");

                entity.Property(e => e.MaintenanceOut).HasColumnType("money");

                entity.Property(e => e.NAllowMeal)
                    .HasColumnName("nAllowMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NCardCharge)
                    .HasColumnName("nCardCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NCardInit)
                    .HasColumnName("nCardInit")
                    .HasColumnType("money");

                entity.Property(e => e.NCardReturn)
                    .HasColumnName("nCardReturn")
                    .HasColumnType("money");

                entity.Property(e => e.NCashPay)
                    .HasColumnName("nCashPay")
                    .HasColumnType("money");

                entity.Property(e => e.NCashReceive)
                    .HasColumnName("nCashReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeAllow)
                    .HasColumnName("nChargeAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeBatch)
                    .HasColumnName("nChargeBatch")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeBounds)
                    .HasColumnName("nChargeBounds")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeFix)
                    .HasColumnName("nChargeFix")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeReceive)
                    .HasColumnName("nChargeReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeReturn)
                    .HasColumnName("nChargeReturn")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NCountMeal).HasColumnName("nCountMeal");

                entity.Property(e => e.NEveningAmount)
                    .HasColumnName("nEveningAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NInFixCharge)
                    .HasColumnName("nInFixCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayMealCash)
                    .HasColumnName("nInGrayMealCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvAmount)
                    .HasColumnName("nMealEvAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvening).HasColumnName("nMealEvening");

                entity.Property(e => e.NMealMoAmount)
                    .HasColumnName("nMealMoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealMorning).HasColumnName("nMealMorning");

                entity.Property(e => e.NMealNiAmount)
                    .HasColumnName("nMealNiAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNight).HasColumnName("nMealNight");

                entity.Property(e => e.NMealNoAmount)
                    .HasColumnName("nMealNoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNoon).HasColumnName("nMealNoon");

                entity.Property(e => e.NMealOtAmount)
                    .HasColumnName("nMealOtAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealOther).HasColumnName("nMealOther");

                entity.Property(e => e.NMorningAmount)
                    .HasColumnName("nMorningAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NMorningTimes).HasColumnName("nMorningTimes");

                entity.Property(e => e.NNightAmount)
                    .HasColumnName("nNightAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NNightTimes).HasColumnName("nNightTimes");

                entity.Property(e => e.NNoonAmount)
                    .HasColumnName("nNoonAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NNoonTimes).HasColumnName("nNoonTimes");

                entity.Property(e => e.NOpenBalance)
                    .HasColumnName("nOpenBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NOrderMeal)
                    .HasColumnName("nOrderMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherAmount)
                    .HasColumnName("nOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherTimes).HasColumnName("nOtherTimes");

                entity.Property(e => e.NOutCard)
                    .HasColumnName("nOutCard")
                    .HasColumnType("money");

                entity.Property(e => e.NOutCountMeal).HasColumnName("nOutCountMeal");

                entity.Property(e => e.NOutFixMeal)
                    .HasColumnName("nOutFixMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutGrayMeal)
                    .HasColumnName("nOutGrayMeal")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NQuanCash)
                    .HasColumnName("nQuanCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NReIssueCash)
                    .HasColumnName("nReIssueCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeveningTimes).HasColumnName("NEveningTimes");

                entity.Property(e => e.OpenCardCost).HasColumnType("money");

                entity.Property(e => e.OpenMaintenance).HasColumnType("money");
            });

            modelBuilder.Entity<ClockWhiteCard>(entity =>
            {
                entity.HasKey(e => new { e.ClockId, e.CardId });

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_Sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype).HasColumnName("cardtype");

                entity.Property(e => e.Cardtypecode)
                    .HasColumnName("cardtypecode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Timebound)
                    .HasColumnName("timebound")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClosingAccount>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.CardId, e.AccountId, e.ClosingDate });

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClosingDate)
                    .HasColumnName("closing_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeTotal)
                    .HasColumnName("charge_total")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsumeTotal)
                    .HasColumnName("consume_total")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatDate)
                    .HasColumnName("creat_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreBalance)
                    .HasColumnName("pre_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SequTotal)
                    .HasColumnName("sequ_total")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TimesTotal)
                    .HasColumnName("times_total")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CommMsg>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId)
                    .HasColumnName("company_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.BBusinessState).HasColumnName("bBusinessState");

                entity.Property(e => e.BTakeMoneyCheck).HasColumnName("bTakeMoneyCheck");

                entity.Property(e => e.BackupDb)
                    .HasColumnName("BackupDB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuildDate)
                    .HasColumnName("build_date")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CBookTime)
                    .HasColumnName("cBookTime")
                    .HasColumnType("char(5)");

                entity.Property(e => e.CompanyAddress)
                    .HasColumnName("company_address")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyChName)
                    .HasColumnName("company_ch_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyEnName)
                    .HasColumnName("company_en_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyHttp)
                    .HasColumnName("company_http")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyLoginName)
                    .HasColumnName("company_login_name")
                    .HasMaxLength(255);

                entity.Property(e => e.CpucardParam)
                    .HasColumnName("CPUCardParam")
                    .HasColumnType("ntext");

                entity.Property(e => e.DCurrAccDate)
                    .HasColumnName("dCurrAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DInitDate)
                    .HasColumnName("dInitDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DNextAccDate)
                    .HasColumnName("dNextAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DPrevAccDate)
                    .HasColumnName("dPrevAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaxCode)
                    .HasColumnName("fax_code")
                    .HasMaxLength(50);

                entity.Property(e => e.FreqInterval)
                    .HasColumnName("freq_interval")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FreqRecurrenceFactor)
                    .HasColumnName("freq_recurrence_factor")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FreqType)
                    .HasColumnName("freq_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageSize)
                    .HasColumnName("image_size")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRealMeal).HasColumnName("is_real_meal");

                entity.Property(e => e.LateImage)
                    .HasColumnName("late_image")
                    .HasColumnType("image");

                entity.Property(e => e.LeaveImage)
                    .HasColumnName("leave_image")
                    .HasColumnType("image");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasColumnType("image");

                entity.Property(e => e.MachineCode)
                    .HasColumnName("machine_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Manager)
                    .HasColumnName("manager")
                    .HasMaxLength(20);

                entity.Property(e => e.MultiDoorCardNoRule).HasDefaultValueSql("((0))");

                entity.Property(e => e.NAcceptDiffDays).HasColumnName("nAcceptDiffDays");

                entity.Property(e => e.NAccountPeriod)
                    .HasColumnName("nAccountPeriod")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NBookType).HasColumnName("nBookType");

                entity.Property(e => e.NMaxLost).HasColumnName("nMaxLost");

                entity.Property(e => e.NReIssueDelay).HasColumnName("nReIssueDelay");

                entity.Property(e => e.NocardImage)
                    .HasColumnName("nocard_image")
                    .HasColumnType("image");

                entity.Property(e => e.Parameters)
                    .HasColumnName("parameters")
                    .HasColumnType("ntext");

                entity.Property(e => e.PhoneCode)
                    .HasColumnName("phone_code")
                    .HasMaxLength(50);

                entity.Property(e => e.Principal)
                    .HasColumnName("principal")
                    .HasMaxLength(50);

                entity.Property(e => e.RealColor)
                    .HasColumnName("real_color")
                    .HasColumnType("ntext");

                entity.Property(e => e.SerialNo)
                    .HasColumnName("serial_no")
                    .HasMaxLength(50);

                entity.Property(e => e.SetColor)
                    .HasColumnName("set_color")
                    .HasMaxLength(50);

                entity.Property(e => e.SetFont)
                    .HasColumnName("set_font")
                    .HasColumnType("ntext");

                entity.Property(e => e.StartTime)
                    .HasColumnName("Start_Time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('1900-1-1 00:00:00')");

                entity.Property(e => e.SystemList)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Textfmt)
                    .HasColumnName("textfmt")
                    .HasColumnType("ntext");

                entity.Property(e => e.Timeparam)
                    .HasColumnName("timeparam")
                    .HasColumnType("ntext");

                entity.Property(e => e.VersionId)
                    .HasColumnName("version_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataBaseConfig>(entity =>
            {
                entity.HasKey(e => e.DbId);

                entity.Property(e => e.DbId)
                    .HasColumnName("DbID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DbName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.IsTrust).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataMoveDetails>(entity =>
            {
                entity.HasKey(e => e.NDetSeq);

                entity.Property(e => e.NDetSeq).HasColumnName("nDetSeq");

                entity.Property(e => e.CDateField)
                    .HasColumnName("cDateField")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CDestDb)
                    .HasColumnName("cDestDB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CDestTable)
                    .HasColumnName("cDestTable")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CSrcTabel)
                    .HasColumnName("cSrcTabel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DAccDateMax)
                    .HasColumnName("dAccDate_Max")
                    .HasColumnType("datetime");

                entity.Property(e => e.DAccDateMin)
                    .HasColumnName("dAccDate_Min")
                    .HasColumnType("datetime");

                entity.Property(e => e.NRecSeq).HasColumnName("nRecSeq");

                entity.Property(e => e.OpDate)
                    .HasColumnName("Op_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DataMoveRecords>(entity =>
            {
                entity.HasKey(e => e.NRecSeq);

                entity.Property(e => e.NRecSeq).HasColumnName("nRecSeq");

                entity.Property(e => e.CDescription)
                    .HasColumnName("cDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.COperator)
                    .HasColumnName("cOperator")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DDmdate)
                    .HasColumnName("dDMDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DOperateTime)
                    .HasColumnName("dOperateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NOpFlag)
                    .HasColumnName("nOpFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOpState)
                    .HasColumnName("nOpState")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOpTime)
                    .HasColumnName("nOpTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Degrees>(entity =>
            {
                entity.HasKey(e => e.DegreeId);

                entity.Property(e => e.DegreeId)
                    .HasColumnName("degree_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.DegreeName)
                    .HasColumnName("degree_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Departs>(entity =>
            {
                entity.HasKey(e => e.DepartId);

                entity.Property(e => e.DepartId)
                    .HasColumnName("depart_id")
                    .HasMaxLength(30)
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartName)
                    .IsRequired()
                    .HasColumnName("depart_name")
                    .HasMaxLength(50);

                entity.Property(e => e.EmpPrefix)
                    .HasColumnName("emp_prefix")
                    .HasMaxLength(8);

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasMaxLength(8);

                entity.Property(e => e.InsideId)
                    .HasColumnName("inside_id")
                    .HasMaxLength(30);

                entity.Property(e => e.Principal)
                    .HasColumnName("principal")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<DepositConfig>(entity =>
            {
                entity.HasKey(e => new { e.Flag, e.RefId });

                entity.Property(e => e.RefId)
                    .HasColumnName("RefID")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.HasKey(e => e.DeviceType1);

                entity.Property(e => e.DeviceType1)
                    .HasColumnName("DeviceType")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.DeviceDesc)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<DimissionTypes>(entity =>
            {
                entity.HasKey(e => e.DimissionTypeId);

                entity.Property(e => e.DimissionTypeId)
                    .HasColumnName("dimission_type_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.DimissionType)
                    .HasColumnName("dimission_type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DinClockConfig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.BegTime)
                    .IsRequired()
                    .HasColumnName("beg_time")
                    .HasMaxLength(8);

                entity.Property(e => e.ClockId)
                    .IsRequired()
                    .HasColumnName("Clock_id")
                    .HasMaxLength(10);

                entity.Property(e => e.DinLevId)
                    .IsRequired()
                    .HasColumnName("DinLev_id")
                    .HasMaxLength(10);

                entity.Property(e => e.DinLevName)
                    .HasColumnName("DinLev_name")
                    .HasMaxLength(20);

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<DinLev>(entity =>
            {
                entity.Property(e => e.DinLevId)
                    .HasColumnName("DinLev_id")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.BegTime)
                    .IsRequired()
                    .HasColumnName("beg_time")
                    .HasMaxLength(8);

                entity.Property(e => e.DinLevAmount).HasColumnType("money");

                entity.Property(e => e.DinLevName)
                    .HasColumnName("DinLev_name")
                    .HasMaxLength(20);

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time")
                    .HasMaxLength(8);

                entity.Property(e => e.Iscount).HasColumnName("iscount");

                entity.Property(e => e.Isvalid).HasColumnName("isvalid");

                entity.Property(e => e.Mem).HasMaxLength(50);
            });

            modelBuilder.Entity<DinRoom>(entity =>
            {
                entity.Property(e => e.DinRoomId)
                    .HasColumnName("DinRoom_id")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.BBookCenter).HasColumnName("bBookCenter");

                entity.Property(e => e.DinRoomName)
                    .HasColumnName("DinRoom_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Mem).HasMaxLength(50);

                entity.Property(e => e.NAccountBalance)
                    .HasColumnName("nAccountBalance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NTransTimes)
                    .HasColumnName("nTransTimes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DinRoomDayAccountBook>(entity =>
            {
                entity.HasKey(e => new { e.DAccDate, e.CDinRoomId });

                entity.HasIndex(e => e.DAccDate);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CDinRoomId)
                    .HasColumnName("cDinRoomID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardCost).HasColumnType("money");

                entity.Property(e => e.CardCostOut).HasColumnType("money");

                entity.Property(e => e.CloseCardCost).HasColumnType("money");

                entity.Property(e => e.CloseMaintenance).HasColumnType("money");

                entity.Property(e => e.DPrevAccDate)
                    .HasColumnName("dPrevAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Maintenance).HasColumnType("money");

                entity.Property(e => e.MaintenanceOut).HasColumnType("money");

                entity.Property(e => e.NAllowMeal)
                    .HasColumnName("nAllowMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NCardCharge)
                    .HasColumnName("nCardCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NCardInit)
                    .HasColumnName("nCardInit")
                    .HasColumnType("money");

                entity.Property(e => e.NCardReturn)
                    .HasColumnName("nCardReturn")
                    .HasColumnType("money");

                entity.Property(e => e.NCashPay)
                    .HasColumnName("nCashPay")
                    .HasColumnType("money");

                entity.Property(e => e.NCashReceive)
                    .HasColumnName("nCashReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeAllow)
                    .HasColumnName("nChargeAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeBatch)
                    .HasColumnName("nChargeBatch")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeBounds)
                    .HasColumnName("nChargeBounds")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeFix)
                    .HasColumnName("nChargeFix")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeReceive)
                    .HasColumnName("nChargeReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeReturn)
                    .HasColumnName("nChargeReturn")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NCountMeal).HasColumnName("nCountMeal");

                entity.Property(e => e.NEveningAmount)
                    .HasColumnName("nEveningAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NInFixCharge)
                    .HasColumnName("nInFixCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayMealCash)
                    .HasColumnName("nInGrayMealCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NIncome)
                    .HasColumnName("nIncome")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvAmount)
                    .HasColumnName("nMealEvAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvening).HasColumnName("nMealEvening");

                entity.Property(e => e.NMealMoAmount)
                    .HasColumnName("nMealMoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealMorning).HasColumnName("nMealMorning");

                entity.Property(e => e.NMealNiAmount)
                    .HasColumnName("nMealNiAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNight).HasColumnName("nMealNight");

                entity.Property(e => e.NMealNoAmount)
                    .HasColumnName("nMealNoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNoon).HasColumnName("nMealNoon");

                entity.Property(e => e.NMealOtAmount)
                    .HasColumnName("nMealOtAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealOther).HasColumnName("nMealOther");

                entity.Property(e => e.NMorningAmount)
                    .HasColumnName("nMorningAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NMorningTimes).HasColumnName("nMorningTimes");

                entity.Property(e => e.NNightAmount)
                    .HasColumnName("nNightAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NNightTimes).HasColumnName("nNightTimes");

                entity.Property(e => e.NNoonAmount)
                    .HasColumnName("nNoonAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NNoonTimes).HasColumnName("nNoonTimes");

                entity.Property(e => e.NOpenBalance)
                    .HasColumnName("nOpenBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NOrderMeal)
                    .HasColumnName("nOrderMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherAmount)
                    .HasColumnName("nOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherTimes).HasColumnName("nOtherTimes");

                entity.Property(e => e.NOutCard)
                    .HasColumnName("nOutCard")
                    .HasColumnType("money");

                entity.Property(e => e.NOutCountMeal).HasColumnName("nOutCountMeal");

                entity.Property(e => e.NOutFixMeal)
                    .HasColumnName("nOutFixMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutGrayMeal)
                    .HasColumnName("nOutGrayMeal")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NQuanCash)
                    .HasColumnName("nQuanCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NReIssueCash)
                    .HasColumnName("nReIssueCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeveningTimes).HasColumnName("NEveningTimes");

                entity.Property(e => e.OpenCardCost).HasColumnType("money");

                entity.Property(e => e.OpenMaintenance).HasColumnType("money");
            });

            modelBuilder.Entity<DinRoomMonthAccountBook>(entity =>
            {
                entity.HasKey(e => new { e.CDinRoomId, e.CAccMonth });

                entity.Property(e => e.CDinRoomId)
                    .HasColumnName("cDinRoomID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CAccMonth)
                    .HasColumnName("cAccMonth")
                    .HasColumnType("char(6)");

                entity.Property(e => e.CardCost).HasColumnType("money");

                entity.Property(e => e.CardCostOut).HasColumnType("money");

                entity.Property(e => e.CloseCardCost).HasColumnType("money");

                entity.Property(e => e.CloseMaintenance).HasColumnType("money");

                entity.Property(e => e.DBeginDate)
                    .HasColumnName("dBeginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DEndDate)
                    .HasColumnName("dEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Maintenance).HasColumnType("money");

                entity.Property(e => e.MaintenanceOut).HasColumnType("money");

                entity.Property(e => e.NAllowMeal)
                    .HasColumnName("nAllowMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NCardCharge)
                    .HasColumnName("nCardCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NCardInit)
                    .HasColumnName("nCardInit")
                    .HasColumnType("money");

                entity.Property(e => e.NCardReturn)
                    .HasColumnName("nCardReturn")
                    .HasColumnType("money");

                entity.Property(e => e.NCashPay)
                    .HasColumnName("nCashPay")
                    .HasColumnType("money");

                entity.Property(e => e.NCashReceive)
                    .HasColumnName("nCashReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeAllow)
                    .HasColumnName("nChargeAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeBatch)
                    .HasColumnName("nChargeBatch")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeBounds)
                    .HasColumnName("nChargeBounds")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeFix)
                    .HasColumnName("nChargeFix")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeReceive)
                    .HasColumnName("nChargeReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NChargeReturn)
                    .HasColumnName("nChargeReturn")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NCountMeal).HasColumnName("nCountMeal");

                entity.Property(e => e.NEveningAmount)
                    .HasColumnName("nEveningAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NMealEvAmount)
                    .HasColumnName("nMealEvAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvening).HasColumnName("nMealEvening");

                entity.Property(e => e.NMealMoAmount)
                    .HasColumnName("nMealMoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealMorning).HasColumnName("nMealMorning");

                entity.Property(e => e.NMealNiAmount)
                    .HasColumnName("nMealNiAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNight).HasColumnName("nMealNight");

                entity.Property(e => e.NMealNoAmount)
                    .HasColumnName("nMealNoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNoon).HasColumnName("nMealNoon");

                entity.Property(e => e.NMealOtAmount)
                    .HasColumnName("nMealOtAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealOther).HasColumnName("nMealOther");

                entity.Property(e => e.NMorningAmount)
                    .HasColumnName("nMorningAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NMorningTimes).HasColumnName("nMorningTimes");

                entity.Property(e => e.NNightAmount)
                    .HasColumnName("nNightAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NNightTimes).HasColumnName("nNightTimes");

                entity.Property(e => e.NNoonAmount)
                    .HasColumnName("nNoonAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NNoonTimes).HasColumnName("nNoonTimes");

                entity.Property(e => e.NOpenBalance)
                    .HasColumnName("nOpenBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NOrderMeal)
                    .HasColumnName("nOrderMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherAmount)
                    .HasColumnName("nOtherAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherTimes).HasColumnName("nOtherTimes");

                entity.Property(e => e.NOutCard)
                    .HasColumnName("nOutCard")
                    .HasColumnType("money");

                entity.Property(e => e.NOutCountMeal).HasColumnName("nOutCountMeal");

                entity.Property(e => e.NOutFixMeal)
                    .HasColumnName("nOutFixMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NQuanCash)
                    .HasColumnName("nQuanCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NReIssueCash)
                    .HasColumnName("nReIssueCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NeveningTimes).HasColumnName("NEveningTimes");

                entity.Property(e => e.OpenCardCost).HasColumnType("money");

                entity.Property(e => e.OpenMaintenance).HasColumnType("money");
            });

            modelBuilder.Entity<DinRoomRecords>(entity =>
            {
                entity.HasKey(e => new { e.CDinRoomId, e.NTransTimes });

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.NRecSeq);

                entity.Property(e => e.CDinRoomId)
                    .HasColumnName("cDinRoomID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NTransTimes).HasColumnName("nTransTimes");

                entity.Property(e => e.BAudit).HasColumnName("bAudit");

                entity.Property(e => e.BprintVoucher).HasColumnName("bprintVoucher");

                entity.Property(e => e.CAuditor)
                    .HasColumnName("cAuditor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.COperator)
                    .HasColumnName("cOperator")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CRemark)
                    .HasColumnName("cRemark")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CTransCode)
                    .HasColumnName("cTransCode")
                    .HasColumnType("char(4)");

                entity.Property(e => e.CVoucherNo)
                    .IsRequired()
                    .HasColumnName("cVoucherNo")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DAuditDate)
                    .HasColumnName("dAuditDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DTransTime)
                    .HasColumnName("dTransTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.NAmount)
                    .HasColumnName("nAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<DoorAndEmp>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.DoorId });

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.DoorId).HasColumnName("DoorID");

                entity.Property(e => e.TimeBoundId).HasColumnName("TimeBoundID");

                entity.HasOne(d => d.Door)
                    .WithMany(p => p.DoorAndEmp)
                    .HasForeignKey(d => d.DoorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOORANDEMP_DoorID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.DoorAndEmp)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOORANDEMP_GroupID");

                entity.HasOne(d => d.TimeBound)
                    .WithMany(p => p.DoorAndEmp)
                    .HasForeignKey(d => d.TimeBoundId)
                    .HasConstraintName("FK_DOORANDE_REFERENCE_DOORTIME");
            });

            modelBuilder.Entity<DoorAndMachine>(entity =>
            {
                entity.HasKey(e => new { e.DoorId, e.ClockId, e.ReadNo });

                entity.Property(e => e.DoorId).HasColumnName("DoorID");

                entity.Property(e => e.ClockId).HasColumnName("ClockID");

                entity.Property(e => e.ReadNo).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Door)
                    .WithMany(p => p.DoorAndMachine)
                    .HasForeignKey(d => d.DoorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOORANDMachine_DoorID");
            });

            modelBuilder.Entity<DoorCardAndMachine>(entity =>
            {
                entity.HasIndex(e => e.CardId)
                    .HasName("IX_DoorCardAndMachine_Card_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cardtypecode)
                    .HasColumnName("cardtypecode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Clockid).HasColumnName("clockid");

                entity.Property(e => e.Delflag)
                    .HasColumnName("delflag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExecuteDate).HasColumnType("datetime");

                entity.Property(e => e.Opdate)
                    .HasColumnName("opdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Opendoorpw)
                    .HasColumnName("opendoorpw")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReadNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.RealCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Right)
                    .IsRequired()
                    .HasColumnName("right")
                    .HasColumnType("char(2)")
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.Timebound)
                    .HasColumnName("timebound")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DoorConnected>(entity =>
            {
                entity.HasKey(e => new { e.DoorId1, e.DoorId2 });

                entity.Property(e => e.DoorId1).HasColumnName("DoorID1");

                entity.Property(e => e.DoorId2).HasColumnName("DoorID2");

                entity.HasOne(d => d.DoorId1Navigation)
                    .WithMany(p => p.DoorConnectedDoorId1Navigation)
                    .HasForeignKey(d => d.DoorId1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOORCONNNCTED_DoorID1");

                entity.HasOne(d => d.DoorId2Navigation)
                    .WithMany(p => p.DoorConnectedDoorId2Navigation)
                    .HasForeignKey(d => d.DoorId2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOORCONNNCTED_DoorID2");
            });

            modelBuilder.Entity<DoorInfo>(entity =>
            {
                entity.HasKey(e => e.DoorId);

                entity.Property(e => e.DoorId)
                    .HasColumnName("DoorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("AreaID");

                entity.Property(e => e.DoorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListMode).HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<DoorListGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardClass).HasDefaultValueSql("((-1))");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Right)
                    .IsRequired()
                    .HasColumnType("char(2)")
                    .HasDefaultValueSql("('01')");
            });

            modelBuilder.Entity<DoorListMember>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.EmpId });

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.DoorListMember)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DOORLISTMember_GroupID");
            });

            modelBuilder.Entity<DoorTimeBound>(entity =>
            {
                entity.HasKey(e => e.TimeBoundId);

                entity.Property(e => e.TimeBoundId)
                    .HasColumnName("TimeBoundID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DayTime)
                    .IsRequired()
                    .HasColumnType("char(12)");

                entity.Property(e => e.TimeBoundName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeDesc)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.WeekDay)
                    .IsRequired()
                    .HasColumnType("char(2)");
            });

            modelBuilder.Entity<Dorm>(entity =>
            {
                entity.Property(e => e.DormId)
                    .HasColumnName("dorm_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(8);

                entity.Property(e => e.DormName)
                    .HasColumnName("dorm_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmealRecords>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("EMealRecords");

                entity.Property(e => e.RecordId).HasColumnName("record_id");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BusiStyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusiType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardConsume)
                    .HasColumnName("card_consume")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardFormat).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("card_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CardSequ).HasColumnName("card_sequ");

                entity.Property(e => e.CardTimes).HasColumnName("card_times");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.CommonEmpId)
                    .HasColumnName("CommonEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmpId)
                    .HasColumnName("CompanyEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DifineSequ).HasColumnName("difine_sequ");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ErrCode)
                    .HasColumnName("errCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark).HasColumnName("mark");

                entity.Property(e => e.Mealtype).HasColumnName("mealtype");

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpYmd)
                    .HasColumnName("op_ymd")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpcardId)
                    .HasColumnName("opcard_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherId).HasColumnName("other_id");

                entity.Property(e => e.Passed).HasColumnName("passed");

                entity.Property(e => e.PosSequ).HasColumnName("pos_sequ");

                entity.Property(e => e.PsamappSn)
                    .HasColumnName("PSAMAppSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tac)
                    .HasColumnName("TAC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VerId)
                    .HasColumnName("ver_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessLevel)
                    .HasColumnName("access_level")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AccessPwd)
                    .HasColumnName("access_pwd")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.AuotShift).HasColumnName("Auot_shift");

                entity.Property(e => e.BalanceTime)
                    .HasColumnName("balance_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BankNo)
                    .HasColumnName("Bank_No")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BeRegularDate)
                    .HasColumnName("be_regular_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BedId)
                    .HasColumnName("bed_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-1')");

                entity.Property(e => e.CardKind).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContractDate)
                    .HasColumnName("contract_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractLabour)
                    .HasColumnName("contract_labour")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractOverDate)
                    .HasColumnName("contract_over_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DayConsume)
                    .HasColumnName("day_consume")
                    .HasColumnType("money");

                entity.Property(e => e.DayMaxMoney)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DayTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.DayTotalMoney)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DayTotalTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartId)
                    .IsRequired()
                    .HasColumnName("depart_id")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DimissionTypeId)
                    .HasColumnName("dimission_type_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DormBuilding)
                    .HasColumnName("dorm_building")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DormId)
                    .HasColumnName("dorm_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EduId)
                    .HasColumnName("edu_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFname)
                    .IsRequired()
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Foodtype)
                    .HasColumnName("foodtype")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GraduateCollege)
                    .HasColumnName("graduate_college")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasColumnName("hire_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Icid).HasColumnName("icid");

                entity.Property(e => e.IdCard)
                    .HasColumnName("id_card")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idtype)
                    .HasColumnName("IDType")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Introducer)
                    .HasColumnName("introducer")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.InworkAge).HasColumnName("Inwork_Age");

                entity.Property(e => e.IsBlack).HasColumnName("is_black");

                entity.Property(e => e.IsOverTime).HasColumnName("isOver_time");

                entity.Property(e => e.IsWhite).HasColumnName("is_white");

                entity.Property(e => e.JobId)
                    .HasColumnName("job_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveCause)
                    .HasColumnName("leave_cause")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveDate)
                    .HasColumnName("leave_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkMan)
                    .HasColumnName("link_man")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LongHolidayDate)
                    .HasColumnName("Long_Holiday_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Marriage)
                    .HasColumnName("marriage")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NationId)
                    .HasColumnName("nation_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NativeId)
                    .HasColumnName("native_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NoSign).HasColumnName("no_sign");

                entity.Property(e => e.PassWord)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCode)
                    .HasColumnName("phone_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("image");

                entity.Property(e => e.PostCode)
                    .HasColumnName("post_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PreBalance)
                    .HasColumnName("pre_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PreSequ)
                    .HasColumnName("pre_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PutUp).HasColumnName("put_up");

                entity.Property(e => e.RedeployDate)
                    .HasColumnName("redeploy_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RedeployDate2)
                    .HasColumnName("redeploy_date2")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RestDays)
                    .HasColumnName("rest_days")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RestKind)
                    .HasColumnName("rest_kind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RuleId)
                    .HasColumnName("rule_id")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('001')");

                entity.Property(e => e.SalaryAcount)
                    .HasColumnName("salary_Acount")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shift_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Shifts)
                    .HasColumnName("shifts")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SocialInsuranceDate)
                    .HasColumnName("social_insurance_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SocialInsuranceMoney)
                    .HasColumnName("social_insurance_money")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Specialty)
                    .HasColumnName("specialty")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StopJobDate)
                    .HasColumnName("Stop_Job_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.StopSocialInsuranceDate)
                    .HasColumnName("Stop_social_insurance_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimeMaxMoney)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkAge)
                    .HasColumnName("work_age")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.WorkHrs)
                    .HasColumnName("work_hrs")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WorkStatus)
                    .HasColumnName("work_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorktimeKind).HasColumnName("worktime_kind");

                entity.Property(e => e.ZlgputUp).HasColumnName("zlgput_up");
            });

            modelBuilder.Entity<EmployeeAccount>(entity =>
            {
                entity.HasKey(e => new { e.CardId, e.AccountId });

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.AllowEndDate).HasColumnType("datetime");

                entity.Property(e => e.AllowanceBalance).HasColumnType("money");

                entity.Property(e => e.AppState).HasDefaultValueSql("((0))");

                entity.Property(e => e.BOverDiffPeriod).HasColumnName("bOverDiffPeriod");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardSequ)
                    .HasColumnName("card_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeDate)
                    .HasColumnName("charge_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChargeMoney)
                    .HasColumnName("charge_money")
                    .HasColumnType("money");

                entity.Property(e => e.DayConsume)
                    .HasColumnName("day_consume")
                    .HasColumnType("money");

                entity.Property(e => e.DayCount)
                    .HasColumnName("Day_Count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DayMaxMoney).HasColumnType("money");

                entity.Property(e => e.DayMoney)
                    .HasColumnName("day_money")
                    .HasColumnType("money");

                entity.Property(e => e.DayTimes).HasColumnName("day_times");

                entity.Property(e => e.DayTotalCount)
                    .HasColumnName("Day_TotalCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DayTotalDate)
                    .HasColumnName("Day_TotalDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DayTotalMoney).HasColumnType("money");

                entity.Property(e => e.DayTotalMoney1)
                    .HasColumnName("Day_TotalMoney")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.EpOverDraft)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.IsLock).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOverTime).HasColumnName("isOver_time");

                entity.Property(e => e.IsWash).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastAccountDate).HasColumnType("datetime");

                entity.Property(e => e.LastBalance)
                    .HasColumnName("last_balance")
                    .HasColumnType("money");

                entity.Property(e => e.LastBalance1)
                    .HasColumnName("LastBalance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDate)
                    .HasColumnName("last_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastTransTimes).HasDefaultValueSql("((0))");

                entity.Property(e => e.MealMoney)
                    .HasColumnName("meal_money")
                    .HasColumnType("money");

                entity.Property(e => e.MealOrder).HasColumnName("meal_order");

                entity.Property(e => e.MealTimes).HasColumnName("meal_times");

                entity.Property(e => e.NAccountBalance)
                    .HasColumnName("nAccountBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NReturnTimes)
                    .HasColumnName("nReturnTimes")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.OnLineMaxJe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OverPwd)
                    .HasColumnName("over_pwd")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PreBalance)
                    .HasColumnName("pre_balance")
                    .HasColumnType("money");

                entity.Property(e => e.PreSequ).HasColumnName("pre_sequ");

                entity.Property(e => e.TimeMaxMoney).HasColumnType("money");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.EmployeeAccount)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpAccount_EmpCard_CardID");
            });

            modelBuilder.Entity<EmployeeCard>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.HasIndex(e => e.CardSn)
                    .HasName("IX_EmployeeCard_CardSn");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowanceSequ)
                    .HasColumnName("Allowance_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AreaCode).HasColumnType("char(4)");

                entity.Property(e => e.BlackSequ)
                    .HasColumnName("black_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardBegDate).HasColumnType("datetime");

                entity.Property(e => e.CardEndDate).HasColumnType("datetime");

                entity.Property(e => e.CardSn)
                    .IsRequired()
                    .HasColumnName("card_sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardSnBak)
                    .HasColumnName("Card_SnBak")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardState).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardType).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CardTypeCode).HasColumnType("char(4)");

                entity.Property(e => e.CardVerifyCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ChPwdTimes).HasColumnName("CH_pwdTimes");

                entity.Property(e => e.CustomerType).HasDefaultValueSql("((0))");

                entity.Property(e => e.DepositValue)
                    .HasColumnType("decimal(14, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Eeseq).HasColumnName("EESEQ");

                entity.Property(e => e.EmpFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.GroupInfo)
                    .HasColumnName("group_info")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsBlack).HasColumnName("is_black");

                entity.Property(e => e.IsWhite).HasColumnName("is_white");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issue_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Issued).HasColumnName("issued");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NewCardId)
                    .HasColumnName("NewCard_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NewMobilePhone)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.ReIssueDate).HasColumnType("datetime");

                entity.Property(e => e.UseFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.VQueryPwd)
                    .HasColumnName("vQueryPwd")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<EmpPicArc>(entity =>
            {
                entity.HasKey(e => e.SerialId);

                entity.Property(e => e.SerialId).HasColumnName("SerialID");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnName("Card_No")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasColumnType("image");

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupInfo)
                    .HasColumnName("Group_info")
                    .HasMaxLength(20);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.HasKey(e => new { e.HdDate, e.HdEnd, e.DepartId });

                entity.Property(e => e.HdDate)
                    .HasColumnName("hd_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HdEnd)
                    .HasColumnName("hd_end")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DepartId)
                    .HasColumnName("depart_id")
                    .HasMaxLength(30);

                entity.Property(e => e.AlwayUse).HasColumnName("alway_use");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("begin_time")
                    .HasMaxLength(5);

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasMaxLength(5);

                entity.Property(e => e.HdKind).HasColumnName("hd_kind");

                entity.Property(e => e.HdName)
                    .IsRequired()
                    .HasColumnName("hd_name")
                    .HasMaxLength(20);

                entity.Property(e => e.HdRate)
                    .HasColumnName("hd_rate")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.SubDepart).HasColumnName("sub_depart");
            });

            modelBuilder.Entity<Idcard>(entity =>
            {
                entity.HasKey(e => e.CardNo);

                entity.ToTable("IDCard");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.LoginId).HasColumnName("login_id");

                entity.Property(e => e.UseState)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InitTransRecords>(entity =>
            {
                entity.HasKey(e => new { e.CCardId, e.NAccountId });

                entity.Property(e => e.CCardId)
                    .HasColumnName("cCardID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NAccountId).HasColumnName("nAccountID");

                entity.Property(e => e.BAudit).HasColumnName("bAudit");

                entity.Property(e => e.CDinRoomId)
                    .HasColumnName("cDinRoomID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CEmpId)
                    .HasColumnName("cEmpID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CTransCode)
                    .IsRequired()
                    .HasColumnName("cTransCode")
                    .HasColumnType("char(4)");

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DSignTime)
                    .HasColumnName("dSignTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.NAmount)
                    .HasColumnName("nAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NClockId).HasColumnName("nClockID");

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NLogicalId).HasColumnName("nLogicalID");

                entity.Property(e => e.NPosSeq).HasColumnName("nPosSeq");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NTransTimes).HasColumnName("nTransTimes");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobId)
                    .HasColumnName("job_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.JobLevel).HasColumnName("Job_Level");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("job_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LeaveD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId, e.BeginTime, e.EndTime });

                entity.ToTable("Leave_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.BeginTime)
                    .HasColumnName("begin_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LeaveDays)
                    .HasColumnName("leave_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveId)
                    .HasColumnName("leave_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LeaveM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("Leave_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10);

                entity.Property(e => e.LeaveCause)
                    .HasColumnName("leave_cause")
                    .HasMaxLength(50);

                entity.Property(e => e.LeaveNo)
                    .IsRequired()
                    .HasColumnName("leave_no")
                    .HasMaxLength(20);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.HasKey(e => e.LeaveId);

                entity.Property(e => e.LeaveId)
                    .HasColumnName("leave_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Disabled).HasColumnName("disabled");

                entity.Property(e => e.LeaveCode)
                    .HasColumnName("leave_code")
                    .HasMaxLength(1);

                entity.Property(e => e.LeaveName)
                    .HasColumnName("leave_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.PayRate)
                    .HasColumnName("pay_rate")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LoginCard>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.Property(e => e.LoginId).HasColumnName("Login_id");

                entity.Property(e => e.BeginCard)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CardLen).HasDefaultValueSql("((10))");

                entity.Property(e => e.LoginNum).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpDate)
                    .HasColumnName("opDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("opUser")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<LookUpConfig>(entity =>
            {
                entity.HasKey(e => new { e.KeyId, e.Id });

                entity.Property(e => e.KeyId)
                    .HasColumnName("KeyID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.Note).HasMaxLength(255);
            });

            modelBuilder.Entity<Mallowance>(entity =>
            {
                entity.ToTable("MAllowance");

                entity.HasIndex(e => e.BatchNo);

                entity.HasIndex(e => e.OpDate)
                    .HasName("IX_MAllowance_Op_Date");

                entity.HasIndex(e => new { e.CardId, e.Charged, e.Kind, e.ChargeVer, e.Deposit })
                    .HasName("IX_MAllowance_CidKindVerPosit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowEndDate).HasColumnType("datetime");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeDate)
                    .HasColumnName("charge_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChargeMoney)
                    .HasColumnName("charge_money")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeVer)
                    .HasColumnName("charge_ver")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Charged).HasColumnName("charged");

                entity.Property(e => e.ClockId)
                    .HasColumnName("clock_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deposit)
                    .HasColumnName("deposit")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Downed)
                    .HasColumnName("downed")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidateEnd)
                    .HasColumnName("validateEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Validatebegin)
                    .HasColumnName("validatebegin")
                    .HasColumnType("datetime");

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MallowanceCardTask>(entity =>
            {
                entity.ToTable("MAllowanceCardTask");

                entity.HasIndex(e => e.CardId)
                    .HasName("IX_MAllowanceCardTask_Card_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowEndDate).HasColumnType("datetime");

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("card_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cardtypecode)
                    .HasColumnName("cardtypecode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeVer)
                    .HasColumnName("charge_ver")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.Deposit)
                    .HasColumnName("deposit")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpFName)
                    .HasColumnName("emp_fName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Executedate).HasColumnType("datetime");

                entity.Property(e => e.Flag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Opdate)
                    .HasColumnName("opdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.ValidateEnd)
                    .HasColumnName("validateEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.Validatebegin)
                    .HasColumnName("validatebegin")
                    .HasColumnType("datetime");

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MapDots>(entity =>
            {
                entity.HasKey(e => new { e.MapId, e.DoorId, e.DotId });

                entity.Property(e => e.MapId).HasColumnName("Map_id");

                entity.Property(e => e.DoorId).HasColumnName("Door_id");

                entity.Property(e => e.DotId).HasColumnName("Dot_id");

                entity.Property(e => e.ClosePic).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenPic).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Maps>(entity =>
            {
                entity.HasKey(e => e.MapId);

                entity.Property(e => e.MapId)
                    .HasColumnName("Map_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Content).HasColumnType("image");

                entity.Property(e => e.MapName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<McardCost>(entity =>
            {
                entity.ToTable("MCardCost");

                entity.HasIndex(e => e.DAccDate);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BIsInvalid).HasColumnName("bIsInvalid");

                entity.Property(e => e.BObsolete).HasColumnName("bObsolete");

                entity.Property(e => e.BPassCheck).HasColumnName("bPassCheck");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ClockId).HasColumnName("Clock_id");

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.InMoney)
                    .HasColumnName("in_money")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(50);

                entity.Property(e => e.OpYmd)
                    .HasColumnName("op_ymd")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutMoney)
                    .HasColumnName("out_money")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MchangeCard>(entity =>
            {
                entity.ToTable("MChangeCard");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BTransferFlag).HasColumnName("bTransferFlag");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardCost)
                    .HasColumnName("card_cost")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardSequ)
                    .HasColumnName("card_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DTransferDate)
                    .HasColumnName("dTransferDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.NTransferMoney)
                    .HasColumnName("nTransferMoney")
                    .HasColumnType("money");

                entity.Property(e => e.NewCardId)
                    .IsRequired()
                    .HasColumnName("new_card_id")
                    .HasMaxLength(16);

                entity.Property(e => e.OldCardId)
                    .IsRequired()
                    .HasColumnName("old_card_id")
                    .HasMaxLength(16);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MchargeRecords>(entity =>
            {
                entity.HasKey(e => new { e.CardId, e.WalletFlag, e.CardTimes, e.CardSequ, e.OpDate });

                entity.ToTable("MChargeRecords");

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.NRecSeq);

                entity.HasIndex(e => e.OpDate);

                entity.HasIndex(e => e.OpYmd);

                entity.HasIndex(e => new { e.CardId, e.WalletFlag, e.CardSequ })
                    .HasName("IX_MChargeRecords_Card_Sequ");

                entity.HasIndex(e => new { e.CardId, e.WalletFlag, e.OpDate })
                    .HasName("IX_MChargeRecords_CidWltStime");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardSequ)
                    .HasColumnName("card_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AllowanceBalance).HasColumnType("money");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BIsInvalid).HasColumnName("bIsInvalid");

                entity.Property(e => e.BObsolete).HasColumnName("bObsolete");

                entity.Property(e => e.BPassCheck).HasColumnName("bPassCheck");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeMoney)
                    .HasColumnName("charge_money")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChargeState)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId)
                    .HasColumnName("clock_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartId)
                    .HasColumnName("Depart_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DifineSequ).HasColumnName("difine_sequ");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Kind).HasDefaultValueSql("((0))");

                entity.Property(e => e.NInBounds)
                    .HasColumnName("nInBounds")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NPosSequ).HasColumnName("nPos_Sequ");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpYmd)
                    .HasColumnName("op_ymd")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tac)
                    .HasColumnName("TAC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VerId)
                    .HasColumnName("ver_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WriteCardMoney).HasColumnType("money");
            });

            modelBuilder.Entity<MealMonth>(entity =>
            {
                entity.HasKey(e => e.AccountMonth);

                entity.Property(e => e.AccountMonth)
                    .HasColumnName("account_month")
                    .HasMaxLength(7)
                    .ValueGeneratedNever();

                entity.Property(e => e.Allowance)
                    .HasColumnName("allowance")
                    .HasColumnType("money");

                entity.Property(e => e.AllowanceStar)
                    .HasColumnName("allowance_star")
                    .HasColumnType("money");

                entity.Property(e => e.Allowanceper).HasColumnName("allowanceper");

                entity.Property(e => e.AllowanceperStar).HasColumnName("allowanceper_star");

                entity.Property(e => e.Balance)
                    .HasColumnName("balance")
                    .HasColumnType("money");

                entity.Property(e => e.BalanceStar)
                    .HasColumnName("balance_star")
                    .HasColumnType("money");

                entity.Property(e => e.BlackPer).HasColumnName("blackPer");

                entity.Property(e => e.BlackPerStar).HasColumnName("blackPer_star");

                entity.Property(e => e.Cardcost)
                    .HasColumnName("cardcost")
                    .HasColumnType("money");

                entity.Property(e => e.CardcostStar)
                    .HasColumnName("cardcost_star")
                    .HasColumnType("money");

                entity.Property(e => e.ChangecardPer).HasColumnName("changecardPer");

                entity.Property(e => e.ChangecardPerStar).HasColumnName("changecardPer_star");

                entity.Property(e => e.Chargemoney)
                    .HasColumnName("chargemoney")
                    .HasColumnType("money");

                entity.Property(e => e.ChargemoneyStar)
                    .HasColumnName("chargemoney_star")
                    .HasColumnType("money");

                entity.Property(e => e.Chargeper).HasColumnName("chargeper");

                entity.Property(e => e.ChargeperStar).HasColumnName("chargeper_star");

                entity.Property(e => e.Consume)
                    .HasColumnName("consume")
                    .HasColumnType("money");

                entity.Property(e => e.ConsumeStar)
                    .HasColumnName("consume_star")
                    .HasColumnType("money");

                entity.Property(e => e.Consumeper).HasColumnName("consumeper");

                entity.Property(e => e.ConsumeperStar).HasColumnName("consumeper_star");

                entity.Property(e => e.Dinmeal)
                    .HasColumnName("dinmeal")
                    .HasColumnType("money");

                entity.Property(e => e.DinmealStar)
                    .HasColumnName("dinmeal_star")
                    .HasColumnType("money");

                entity.Property(e => e.Dinmealper).HasColumnName("dinmealper");

                entity.Property(e => e.DinmealperStar).HasColumnName("dinmealper_star");

                entity.Property(e => e.NewaccountPer).HasColumnName("newaccountPer");

                entity.Property(e => e.NewaccountPerStar).HasColumnName("newaccountPer_star");

                entity.Property(e => e.Refund)
                    .HasColumnName("refund")
                    .HasColumnType("money");

                entity.Property(e => e.RefundStar)
                    .HasColumnName("refund_star")
                    .HasColumnType("money");

                entity.Property(e => e.Refundper).HasColumnName("refundper");

                entity.Property(e => e.RefundperStar).HasColumnName("refundper_star");

                entity.Property(e => e.TotalPerStar).HasColumnName("TotalPer_star");

                entity.Property(e => e.Users)
                    .HasColumnName("users")
                    .HasMaxLength(50);

                entity.Property(e => e.WhitePer).HasColumnName("whitePer");

                entity.Property(e => e.WhitePerStar).HasColumnName("whitePer_star");
            });

            modelBuilder.Entity<MealRecords>(entity =>
            {
                entity.HasKey(e => new { e.ClockId, e.PosSequ, e.CardId, e.WalletFlag, e.CardTimes, e.SignTime, e.CardBalance });

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.DepartId);

                entity.HasIndex(e => e.EmpId)
                    .HasName("IX_MealRecords_Emp_id");

                entity.HasIndex(e => e.NRecSeq);

                entity.HasIndex(e => e.OnLineId)
                    .HasName("IX_MealRecordsOnlineID");

                entity.HasIndex(e => e.OpYmd);

                entity.HasIndex(e => e.SignTime)
                    .HasName("IX_MealRecords_Sign_time");

                entity.HasIndex(e => new { e.CardId, e.WalletFlag, e.CardSequ })
                    .HasName("IX_MealRecords_Card_Sequ");

                entity.HasIndex(e => new { e.CardId, e.WalletFlag, e.SignTime })
                    .HasName("IX_MealRecordsCidWltStime");

                entity.Property(e => e.ClockId)
                    .HasColumnName("clock_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PosSequ)
                    .HasColumnName("pos_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(16);

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AllowanceBalance).HasColumnType("money");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BIsInvalid).HasColumnName("bIsInvalid");

                entity.Property(e => e.BObsolete).HasColumnName("bObsolete");

                entity.Property(e => e.BPassCheck).HasColumnName("bPassCheck");

                entity.Property(e => e.BusiStyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusiType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardConsume)
                    .HasColumnName("card_consume")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardFormat).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardOldbalance)
                    .HasColumnName("card_oldbalance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardSequ)
                    .HasColumnName("card_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CommonEmpId)
                    .HasColumnName("CommonEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmpId)
                    .HasColumnName("CompanyEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartId)
                    .HasColumnName("Depart_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DifineSequ).HasColumnName("difine_sequ");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mealtype)
                    .HasColumnName("mealtype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifyBalance)
                    .HasColumnName("Modify_balance")
                    .HasColumnType("money");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpYmd)
                    .HasColumnName("op_ymd")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpcardId)
                    .HasColumnName("opcard_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherId)
                    .HasColumnName("other_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Passed).HasColumnName("passed");

                entity.Property(e => e.PsamappSn)
                    .HasColumnName("PSAMAppSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Tac)
                    .HasColumnName("TAC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VerId)
                    .HasColumnName("ver_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MealSecondRecords>(entity =>
            {
                entity.HasKey(e => new { e.CardId, e.WalletFlag, e.CardSequ, e.CardTimes, e.SignTime, e.CardBalance });

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.NRecSeq);

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardSequ).HasColumnName("card_sequ");

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BIsInvalid).HasColumnName("bIsInvalid");

                entity.Property(e => e.BObsolete).HasColumnName("bObsolete");

                entity.Property(e => e.BPassCheck).HasColumnName("bPassCheck");

                entity.Property(e => e.BusiStyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusiType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardConsume)
                    .HasColumnName("card_consume")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardFormat).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardOldbalance)
                    .HasColumnName("card_oldbalance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.CommonEmpId)
                    .HasColumnName("CommonEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmpId)
                    .HasColumnName("CompanyEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DifineSequ).HasColumnName("difine_sequ");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mealtype).HasColumnName("mealtype");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpYmd)
                    .HasColumnName("op_ymd")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpcardId)
                    .HasColumnName("opcard_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherId)
                    .HasColumnName("other_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Passed).HasColumnName("passed");

                entity.Property(e => e.PosSequ).HasColumnName("pos_sequ");

                entity.Property(e => e.PsamappSn)
                    .HasColumnName("PSAMAppSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Tac)
                    .HasColumnName("TAC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VerId)
                    .HasColumnName("ver_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeetingBackground>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnType("image");
            });

            modelBuilder.Entity<MeetingD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId });

                entity.ToTable("Meeting_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Kind).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SeatNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MeetingGroupsD>(entity =>
            {
                entity.HasKey(e => new { e.GroupsCode, e.EmpId });

                entity.ToTable("MeetingGroups_D");

                entity.Property(e => e.GroupsCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeetingGroupsM>(entity =>
            {
                entity.HasKey(e => e.GroupsCode);

                entity.ToTable("MeetingGroups_M");

                entity.Property(e => e.GroupsCode)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Groups)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeetingM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("Meeting_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AheadMin).HasDefaultValueSql("((30))");

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FroMin).HasDefaultValueSql("((30))");

                entity.Property(e => e.InLess)
                    .HasColumnName("in_less")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Meeting)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageState).HasDefaultValueSql("((0))");

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_User")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutLess)
                    .HasColumnName("out_less")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Outchecked).HasColumnName("outchecked");

                entity.Property(e => e.Presider)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoomCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeetingRoom>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.InClocks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PerNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Room)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeetSignCardD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId, e.InOutFlag });

                entity.ToTable("MeetSignCard_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.InOutFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MeetSignCardM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("MeetSignCard_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_User")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModifyShiftD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId, e.ShiftDate, e.ShiftId });

                entity.ToTable("ModifyShift_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.ShiftDate)
                    .HasColumnName("shift_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shift_id")
                    .HasMaxLength(8);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ModifyShiftM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("ModifyShift_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyCause)
                    .HasColumnName("modify_cause")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifyNo)
                    .IsRequired()
                    .HasColumnName("modify_no")
                    .HasMaxLength(20);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<MotherCard>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.CardKind)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("CompanyID")
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DeviceNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Pin1)
                    .IsRequired()
                    .HasColumnName("PIN1")
                    .HasMaxLength(20);

                entity.Property(e => e.Pin2)
                    .IsRequired()
                    .HasColumnName("PIN2")
                    .HasMaxLength(20);

                entity.Property(e => e.UseType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.VerId)
                    .HasColumnName("VerID")
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<Mrefund>(entity =>
            {
                entity.ToTable("MRefund");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackMoney)
                    .HasColumnName("back_money")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardCost)
                    .HasColumnName("card_cost")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(20);

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OldCardBalance)
                    .HasColumnName("old_card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(20);

                entity.Property(e => e.Quit).HasColumnName("quit");

                entity.Property(e => e.Verified).HasColumnName("verified");
            });

            modelBuilder.Entity<MsgManager>(entity =>
            {
                entity.HasKey(e => e.Mid);

                entity.Property(e => e.Mid)
                    .HasColumnName("MID")
                    .HasMaxLength(14)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppIdx).HasMaxLength(2);

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUser).HasMaxLength(20);

                entity.Property(e => e.DealState).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Details)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.EmpNo)
                    .IsRequired()
                    .HasColumnName("Emp_No")
                    .HasMaxLength(24);

                entity.Property(e => e.Mcode)
                    .HasColumnName("MCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MobilePhone)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.SendState).HasDefaultValueSql("((0))");

                entity.Property(e => e.SendTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TransId)
                    .HasColumnName("TransID")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MuserSql>(entity =>
            {
                entity.ToTable("MUserSQL");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Param).HasMaxLength(200);

                entity.Property(e => e.Sql)
                    .IsRequired()
                    .HasColumnName("SQL")
                    .HasColumnType("ntext");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.Property(e => e.Width).HasMaxLength(200);
            });

            modelBuilder.Entity<Nations>(entity =>
            {
                entity.HasKey(e => e.NationId);

                entity.Property(e => e.NationId)
                    .HasColumnName("nation_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.NationName)
                    .HasColumnName("nation_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Natives>(entity =>
            {
                entity.HasKey(e => e.NativeId);

                entity.Property(e => e.NativeId)
                    .HasColumnName("native_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.NativeName)
                    .HasColumnName("native_name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<OnLineId>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<OnlineRecords>(entity =>
            {
                entity.HasKey(e => e.OnLineId);

                entity.Property(e => e.OnLineId).ValueGeneratedNever();

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BusiStyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusiType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardConsume)
                    .HasColumnName("card_consume")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardFormat).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("card_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CardOldbalance)
                    .HasColumnName("card_oldbalance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.CommonEmpId)
                    .HasColumnName("CommonEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmpId)
                    .HasColumnName("CompanyEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DifineSequ).HasColumnName("difine_sequ");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mealtype).HasColumnName("mealtype");

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpYmd)
                    .HasColumnName("op_ymd")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpcardId)
                    .HasColumnName("opcard_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Passed).HasColumnName("passed");

                entity.Property(e => e.PosSequ).HasColumnName("pos_sequ");

                entity.Property(e => e.PsamappSn)
                    .HasColumnName("PSAMAppSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tac)
                    .HasColumnName("TAC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VerId)
                    .HasColumnName("ver_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OnlineRules>(entity =>
            {
                entity.HasKey(e => new { e.OnlineRuleId, e.DinLevId });

                entity.HasIndex(e => e.OnlineRuleId)
                    .HasName("IX_OnlineRules_Id");

                entity.Property(e => e.OnlineRuleId)
                    .HasColumnName("OnlineRule_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DinLevId)
                    .HasColumnName("DinLev_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId)
                    .HasColumnName("Group_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MaxConsume).HasColumnType("money");

                entity.Property(e => e.OnlineRuleName)
                    .HasColumnName("OnlineRule_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BeWrite).HasMaxLength(100);

                entity.Property(e => e.OpComPuter)
                    .HasColumnName("opComPuter")
                    .HasMaxLength(20);

                entity.Property(e => e.OpTime)
                    .HasColumnName("opTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("opUser")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OrderDinOp>(entity =>
            {
                entity.HasIndex(e => new { e.CardNo, e.WalletFlag, e.OrderTime })
                    .HasName("IX_OrderDinOpCidWltOtime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("Card_Balance")
                    .HasColumnType("money");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnName("Card_No")
                    .HasMaxLength(20);

                entity.Property(e => e.CardSequ).HasColumnName("Card_Sequ");

                entity.Property(e => e.CardTimes).HasColumnName("Card_Times");

                entity.Property(e => e.ClockId).HasColumnName("Clock_id");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DinDate)
                    .HasColumnName("Din_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DinPrice)
                    .HasColumnName("Din_Price")
                    .HasColumnType("money");

                entity.Property(e => e.DinTab)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("emp_id")
                    .HasMaxLength(20);

                entity.Property(e => e.OpDate)
                    .HasColumnName("OP_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpType)
                    .HasColumnName("Op_Type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpUser)
                    .HasColumnName("OP_User")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.PosSequ).HasColumnName("Pos_Sequ");
            });

            modelBuilder.Entity<OrderDinTab>(entity =>
            {
                entity.HasKey(e => e.NRecSeq);

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.NRecSeq);

                entity.HasIndex(e => new { e.CardId, e.DinDate, e.Dins })
                    .HasName("IX_OrderDinTabCidOtimeDins");

                entity.Property(e => e.NRecSeq).HasColumnName("nRecSeq");

                entity.Property(e => e.BIsInvalid).HasColumnName("bIsInvalid");

                entity.Property(e => e.BObsolete).HasColumnName("bObsolete");

                entity.Property(e => e.BPassCheck).HasColumnName("bPassCheck");

                entity.Property(e => e.CancelDate).HasColumnType("datetime");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money");

                entity.Property(e => e.CardConsume)
                    .HasColumnName("card_consume")
                    .HasColumnType("money");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("Card_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardTimes).HasColumnName("card_times");

                entity.Property(e => e.ClockId).HasColumnName("Clock_id");

                entity.Property(e => e.Consumed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsumedClockId).HasColumnName("Consumed_ClockID");

                entity.Property(e => e.ConsumedTime)
                    .HasColumnName("Consumed_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DinDate).HasColumnType("datetime");

                entity.Property(e => e.DinPrice)
                    .HasColumnName("Din_Price")
                    .HasColumnType("money");

                entity.Property(e => e.Dins).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("Emp_id")
                    .HasMaxLength(50);

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OrderdintabE>(entity =>
            {
                entity.HasKey(e => new { e.CardId, e.DinDate, e.Dins, e.OrderTime });

                entity.ToTable("orderdintabE");

                entity.Property(e => e.CardId)
                    .HasColumnName("Card_id")
                    .HasMaxLength(50);

                entity.Property(e => e.DinDate).HasColumnType("datetime");

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money");

                entity.Property(e => e.CardConsume)
                    .HasColumnName("card_consume")
                    .HasColumnType("money");

                entity.Property(e => e.CardTimes).HasColumnName("card_times");

                entity.Property(e => e.Consumed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConsumedClockId).HasColumnName("Consumed_ClockID");

                entity.Property(e => e.ConsumedTime)
                    .HasColumnName("Consumed_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DinPrice)
                    .HasColumnName("Din_Price")
                    .HasColumnType("money");

                entity.Property(e => e.EmpId)
                    .HasColumnName("Emp_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Kind).HasColumnName("kind");
            });

            modelBuilder.Entity<Outcarddata>(entity =>
            {
                entity.HasKey(e => new { e.ClockId, e.PosSequ, e.CardId, e.WalletFlag, e.CardSequ, e.CardTimes, e.SignTime, e.CardBalance });

                entity.ToTable("outcarddata");

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.NRecSeq);

                entity.HasIndex(e => e.SignTime)
                    .HasName("IX_OutCardData_Sign_time");

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.PosSequ)
                    .HasColumnName("pos_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardSequ).HasColumnName("card_sequ");

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BIsInvalid).HasColumnName("bIsInvalid");

                entity.Property(e => e.BIsNotShow).HasColumnName("bIsNotShow");

                entity.Property(e => e.BObsolete).HasColumnName("bObsolete");

                entity.Property(e => e.BPassCheck).HasColumnName("bPassCheck");

                entity.Property(e => e.BusiStyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusiType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardConsume)
                    .HasColumnName("card_consume")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardFormat).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardOldbalance)
                    .HasColumnName("card_oldbalance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CommonEmpId)
                    .HasColumnName("CommonEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmpId)
                    .HasColumnName("CompanyEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datatype).HasColumnName("datatype");

                entity.Property(e => e.DifineSequ).HasColumnName("difine_sequ");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mealtype).HasColumnName("mealtype");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpYmd)
                    .HasColumnName("op_ymd")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpcardId)
                    .HasColumnName("opcard_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherId)
                    .HasColumnName("other_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Passed).HasColumnName("passed");

                entity.Property(e => e.PsamappSn)
                    .HasColumnName("PSAMAppSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Tac)
                    .HasColumnName("TAC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VerId)
                    .HasColumnName("ver_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutWorkD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId });

                entity.ToTable("OutWork_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.BeginTime)
                    .HasColumnName("begin_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkDays)
                    .HasColumnName("work_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OutWorkM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("OutWork_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12);

                entity.Property(e => e.WorkCause)
                    .HasColumnName("work_cause")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkNo)
                    .IsRequired()
                    .HasColumnName("work_no")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<OverTimeDetail>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId, e.SignDate });

                entity.ToTable("OverTime_Detail");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.SignDate)
                    .HasColumnName("sign_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BeginTime)
                    .HasColumnName("begin_time")
                    .HasMaxLength(5);

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasMaxLength(5);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsOt).HasColumnName("is_ot");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rest)
                    .HasColumnName("rest")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PassTime>(entity =>
            {
                entity.HasKey(e => new { e.EvenFlag, e.CardId, e.EmpId, e.DoorId, e.PassTime1 });

                entity.HasIndex(e => new { e.DoorId, e.CardId, e.PassTime1 })
                    .HasName("IX_PassTimeCidTime");

                entity.Property(e => e.EvenFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(16);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PassTime1)
                    .HasColumnName("passTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cardresult)
                    .HasColumnName("cardresult")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Readno)
                    .HasColumnName("readno")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.HasKey(e => e.PicId);

                entity.Property(e => e.PicId)
                    .HasColumnName("Pic_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content).HasColumnType("image");

                entity.Property(e => e.PicName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<RealCardState>(entity =>
            {
                entity.HasKey(e => new { e.CardId, e.ClockId });

                entity.Property(e => e.CardId)
                    .HasColumnName("Card_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId).HasColumnName("Clock_ID");

                entity.Property(e => e.CardState).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<RealErrCodeTb>(entity =>
            {
                entity.HasKey(e => e.ErrCode);

                entity.Property(e => e.ErrCode).ValueGeneratedNever();

                entity.Property(e => e.ErrMsg)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RealMealInfo>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.Property(e => e.CardId)
                    .HasColumnName("Card_ID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.RealValue).HasColumnType("decimal(14, 2)");
            });

            modelBuilder.Entity<RealTime>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardId)
                    .IsRequired()
                    .HasColumnName("card_id")
                    .HasMaxLength(16);

                entity.Property(e => e.Cardresult)
                    .HasColumnName("cardresult")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoorId)
                    .HasColumnName("door_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.PassTime)
                    .HasColumnName("passTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Readno)
                    .HasColumnName("readno")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RefuseRegD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId });

                entity.ToTable("RefuseReg_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefuseRegM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("RefuseReg_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_User")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegOverTime>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("Reg_OverTime");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10);

                entity.Property(e => e.OtCause)
                    .HasColumnName("ot_cause")
                    .HasMaxLength(50);

                entity.Property(e => e.OvertimeNo)
                    .IsRequired()
                    .HasColumnName("overtime_no")
                    .HasMaxLength(20);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12);
            });

            modelBuilder.Entity<Reminds>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoTime).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Kind).HasDefaultValueSql("((0))");

                entity.Property(e => e.Messages)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCode)
                    .HasColumnName("phone_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Sponsor).HasDefaultValueSql("((0))");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RemindsBak>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoTime).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Messages)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCode)
                    .HasColumnName("phone_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegDate).HasColumnType("datetime");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Sponsor).HasDefaultValueSql("((0))");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RepairTransRecords>(entity =>
            {
                entity.HasKey(e => new { e.CCardId, e.NAccountId, e.NTransTimes, e.CDinRoomId, e.NCloseBalance });

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.NRecSeq);

                entity.Property(e => e.CCardId)
                    .HasColumnName("cCardID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NAccountId).HasColumnName("nAccountID");

                entity.Property(e => e.NTransTimes).HasColumnName("nTransTimes");

                entity.Property(e => e.CDinRoomId)
                    .HasColumnName("cDinRoomID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.BCheckFlag).HasColumnName("bCheckFlag");

                entity.Property(e => e.CAutoRemark)
                    .HasColumnName("cAutoRemark")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CChecker)
                    .HasColumnName("cChecker")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CEmpId)
                    .HasColumnName("cEmpID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CManualRemark)
                    .HasColumnName("cManualRemark")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CTransCode)
                    .IsRequired()
                    .HasColumnName("cTransCode")
                    .HasColumnType("char(4)");

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCheckDate)
                    .HasColumnName("dCheckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DOldAccDate)
                    .HasColumnName("dOldAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NAmount)
                    .HasColumnName("nAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NClockId).HasColumnName("nClockID");

                entity.Property(e => e.NKind).HasColumnName("nKind");

                entity.Property(e => e.NLogicalId).HasColumnName("nLogicalID");

                entity.Property(e => e.NPosSeq).HasColumnName("nPosSeq");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReplaceRegD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId });

                entity.ToTable("ReplaceReg_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Replacer)
                    .IsRequired()
                    .HasColumnName("replacer")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReplaceRegM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("ReplaceReg_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_User")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportDay>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.SignDate });

                entity.ToTable("Report_Day");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32);

                entity.Property(e => e.SignDate)
                    .HasColumnName("sign_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.AbsentDays)
                    .HasColumnName("absent_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AbsentHrs)
                    .HasColumnName("absent_hrs")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.AbsentHrs1)
                    .HasColumnName("absent_hrs1")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.AbsentHrs2)
                    .HasColumnName("absent_hrs2")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.Adjusted).HasColumnName("adjusted");

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.BasicHrs)
                    .HasColumnName("basic_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DutyDays)
                    .HasColumnName("duty_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FactHrs)
                    .HasColumnName("fact_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HdDays)
                    .HasColumnName("hd_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HdHrs)
                    .HasColumnName("hd_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.In1)
                    .HasColumnName("in1")
                    .HasMaxLength(5);

                entity.Property(e => e.In2)
                    .HasColumnName("in2")
                    .HasMaxLength(5);

                entity.Property(e => e.In3)
                    .HasColumnName("in3")
                    .HasMaxLength(5);

                entity.Property(e => e.In4)
                    .HasColumnName("in4")
                    .HasMaxLength(5);

                entity.Property(e => e.In5)
                    .HasColumnName("in5")
                    .HasMaxLength(5);

                entity.Property(e => e.L0hrs)
                    .HasColumnName("l0hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L1hrs)
                    .HasColumnName("l1hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L2hrs)
                    .HasColumnName("l2hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L3hrs)
                    .HasColumnName("l3hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L4hrs)
                    .HasColumnName("l4hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L5hrs)
                    .HasColumnName("l5hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L6hrs)
                    .HasColumnName("l6hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L7hrs)
                    .HasColumnName("l7hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L8hrs)
                    .HasColumnName("l8hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L9hrs)
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LateCount)
                    .HasColumnName("late_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LateMins)
                    .HasColumnName("late_mins")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LateMins1)
                    .HasColumnName("late_mins1")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.LateMins2)
                    .HasColumnName("late_mins2")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.LeaveCount)
                    .HasColumnName("leave_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveDays)
                    .HasColumnName("leave_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveMins)
                    .HasColumnName("leave_mins")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveMins1)
                    .HasColumnName("leave_mins1")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.LeaveMins2)
                    .HasColumnName("leave_mins2")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.Marks)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.MidCount)
                    .HasColumnName("mid_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MidHrs)
                    .HasColumnName("mid_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(50);

                entity.Property(e => e.NsCount)
                    .HasColumnName("ns_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NsHrs)
                    .HasColumnName("ns_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OnwatchHrs)
                    .HasColumnName("onwatch_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtCount)
                    .HasColumnName("ot_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtHrs)
                    .HasColumnName("ot_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Out1)
                    .HasColumnName("out1")
                    .HasMaxLength(5);

                entity.Property(e => e.Out2)
                    .HasColumnName("out2")
                    .HasMaxLength(5);

                entity.Property(e => e.Out3)
                    .HasColumnName("out3")
                    .HasMaxLength(5);

                entity.Property(e => e.Out4)
                    .HasColumnName("out4")
                    .HasMaxLength(5);

                entity.Property(e => e.Out5)
                    .HasColumnName("out5")
                    .HasMaxLength(5);

                entity.Property(e => e.OutworkDays)
                    .HasColumnName("outwork_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutworkHrs)
                    .HasColumnName("outwork_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlanDays)
                    .HasColumnName("plan_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftHrs)
                    .HasColumnName("shift_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shift_id")
                    .HasMaxLength(8);

                entity.Property(e => e.ShutdownDays)
                    .HasColumnName("shutdown_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShutdownHrs)
                    .HasColumnName("shutdown_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SignCount)
                    .HasColumnName("sign_count")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SunDays)
                    .HasColumnName("sun_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SunHrs)
                    .HasColumnName("sun_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkDays)
                    .HasColumnName("work_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ReportMonth>(entity =>
            {
                entity.HasKey(e => new { e.Ym, e.EmpId });

                entity.ToTable("Report_Month");

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasMaxLength(7);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32);

                entity.Property(e => e.AbsentDays)
                    .HasColumnName("absent_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AbsentHrs)
                    .HasColumnName("absent_hrs")
                    .HasColumnType("numeric(9, 3)");

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.AuditDate)
                    .HasColumnName("audit_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Auditor)
                    .HasColumnName("auditor")
                    .HasMaxLength(20);

                entity.Property(e => e.BasicHrs)
                    .HasColumnName("basic_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CalDays)
                    .HasColumnName("cal_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DutyDays)
                    .HasColumnName("duty_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FactHrs)
                    .HasColumnName("fact_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HdDays)
                    .HasColumnName("hd_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HdHrs)
                    .HasColumnName("hd_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L0hrs)
                    .HasColumnName("l0hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L1hrs)
                    .HasColumnName("l1hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L2hrs)
                    .HasColumnName("l2hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L3hrs)
                    .HasColumnName("l3hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L4hrs)
                    .HasColumnName("l4hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L5hrs)
                    .HasColumnName("l5hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L6hrs)
                    .HasColumnName("l6hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L7hrs)
                    .HasColumnName("l7hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L8hrs)
                    .HasColumnName("l8hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.L9hrs)
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LateCount)
                    .HasColumnName("late_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LateMins)
                    .HasColumnName("late_mins")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveCount)
                    .HasColumnName("leave_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveDays)
                    .HasColumnName("leave_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveMins)
                    .HasColumnName("leave_mins")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MidCount)
                    .HasColumnName("mid_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MidHrs)
                    .HasColumnName("mid_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MonthDays)
                    .HasColumnName("month_days")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NsCount)
                    .HasColumnName("ns_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NsHrs)
                    .HasColumnName("ns_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OnwatchHrs)
                    .HasColumnName("onwatch_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtCount)
                    .HasColumnName("ot_count")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtHrs)
                    .HasColumnName("ot_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutworkDays)
                    .HasColumnName("outwork_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutworkHrs)
                    .HasColumnName("outwork_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OverDays).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.PlanDays)
                    .HasColumnName("plan_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelaxDays).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ShiftHrs)
                    .HasColumnName("shift_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShutdownDays)
                    .HasColumnName("shutdown_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShutdownHrs)
                    .HasColumnName("shutdown_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SunDays)
                    .HasColumnName("sun_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SunHrs)
                    .HasColumnName("sun_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.WorkDays)
                    .HasColumnName("work_days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Content).HasColumnType("image");

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LanCode).HasMaxLength(20);

                entity.Property(e => e.RepName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ReturnCard>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.CardId });

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32);

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money");

                entity.Property(e => e.CardSequ).HasColumnName("card_sequ");

                entity.Property(e => e.CardTime).HasColumnName("card_time");

                entity.Property(e => e.EmpName)
                    .HasColumnName("emp_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(20);

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("return_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Rules>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.Property(e => e.RuleId)
                    .HasColumnName("rule_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.DaysMonth)
                    .HasColumnName("days/month")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HdRate)
                    .HasColumnName("hd_rate")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HoursDay)
                    .HasColumnName("hours/day")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.OtRate)
                    .HasColumnName("ot_rate")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RelaxDays).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RuleName)
                    .HasColumnName("rule_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Rules1)
                    .HasColumnName("rules")
                    .HasColumnType("ntext");

                entity.Property(e => e.SunRate)
                    .HasColumnName("sun_rate")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Scheme>(entity =>
            {
                entity.HasKey(e => new { e.Ym, e.EmpId });

                entity.Property(e => e.Ym)
                    .HasColumnName("YM")
                    .HasMaxLength(7);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shift_id")
                    .HasMaxLength(8);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e._1)
                    .HasColumnName("1")
                    .HasMaxLength(8);

                entity.Property(e => e._10)
                    .HasColumnName("10")
                    .HasMaxLength(8);

                entity.Property(e => e._11)
                    .HasColumnName("11")
                    .HasMaxLength(8);

                entity.Property(e => e._12)
                    .HasColumnName("12")
                    .HasMaxLength(8);

                entity.Property(e => e._13)
                    .HasColumnName("13")
                    .HasMaxLength(8);

                entity.Property(e => e._14)
                    .HasColumnName("14")
                    .HasMaxLength(8);

                entity.Property(e => e._15)
                    .HasColumnName("15")
                    .HasMaxLength(8);

                entity.Property(e => e._16)
                    .HasColumnName("16")
                    .HasMaxLength(8);

                entity.Property(e => e._17)
                    .HasColumnName("17")
                    .HasMaxLength(8);

                entity.Property(e => e._18)
                    .HasColumnName("18")
                    .HasMaxLength(8);

                entity.Property(e => e._19)
                    .HasColumnName("19")
                    .HasMaxLength(8);

                entity.Property(e => e._2)
                    .HasColumnName("2")
                    .HasMaxLength(8);

                entity.Property(e => e._20)
                    .HasColumnName("20")
                    .HasMaxLength(8);

                entity.Property(e => e._21)
                    .HasColumnName("21")
                    .HasMaxLength(8);

                entity.Property(e => e._22)
                    .HasColumnName("22")
                    .HasMaxLength(8);

                entity.Property(e => e._23)
                    .HasColumnName("23")
                    .HasMaxLength(8);

                entity.Property(e => e._24)
                    .HasColumnName("24")
                    .HasMaxLength(8);

                entity.Property(e => e._25)
                    .HasColumnName("25")
                    .HasMaxLength(8);

                entity.Property(e => e._26)
                    .HasColumnName("26")
                    .HasMaxLength(8);

                entity.Property(e => e._27)
                    .HasColumnName("27")
                    .HasMaxLength(8);

                entity.Property(e => e._28)
                    .HasColumnName("28")
                    .HasMaxLength(8);

                entity.Property(e => e._29)
                    .HasColumnName("29")
                    .HasMaxLength(8);

                entity.Property(e => e._3)
                    .HasColumnName("3")
                    .HasMaxLength(8);

                entity.Property(e => e._30)
                    .HasColumnName("30")
                    .HasMaxLength(8);

                entity.Property(e => e._31)
                    .HasColumnName("31")
                    .HasMaxLength(8);

                entity.Property(e => e._4)
                    .HasColumnName("4")
                    .HasMaxLength(8);

                entity.Property(e => e._5)
                    .HasColumnName("5")
                    .HasMaxLength(8);

                entity.Property(e => e._6)
                    .HasColumnName("6")
                    .HasMaxLength(8);

                entity.Property(e => e._7)
                    .HasColumnName("7")
                    .HasMaxLength(8);

                entity.Property(e => e._8)
                    .HasColumnName("8")
                    .HasMaxLength(8);

                entity.Property(e => e._9)
                    .HasColumnName("9")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<ShellTable>(entity =>
            {
                entity.HasKey(e => e.SFileNameEn);

                entity.ToTable("Shell_Table");

                entity.Property(e => e.SFileNameEn)
                    .HasColumnName("sFileName_En")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.SFileName)
                    .HasColumnName("sFileName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shifts>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shift_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartId)
                    .HasColumnName("depart_id")
                    .HasMaxLength(8);

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.NeedHrs)
                    .HasColumnName("need_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftKind)
                    .HasColumnName("shift_kind")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShiftName)
                    .HasColumnName("shift_name")
                    .HasMaxLength(50);

                entity.Property(e => e.Shifts1)
                    .HasColumnName("shifts")
                    .HasColumnType("ntext");

                entity.Property(e => e.WorkHrs)
                    .HasColumnName("work_hrs")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ShiftsRule>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.ToTable("Shifts_Rule");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shift_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasColumnType("ntext");

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasColumnName("shift_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Shifts)
                    .HasColumnName("shifts")
                    .HasColumnType("ntext");

                entity.Property(e => e.ShiftsCyc).HasColumnName("shifts_cyc");

                entity.Property(e => e.ShiftsCycUnit)
                    .IsRequired()
                    .HasColumnName("shifts_cyc_unit")
                    .HasMaxLength(10);

                entity.Property(e => e.Start).HasColumnName("start");
            });

            modelBuilder.Entity<ShutDownD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId });

                entity.ToTable("ShutDown_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32);

                entity.Property(e => e.BeginTime)
                    .HasColumnName("begin_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime)
                    .HasColumnName("end_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("numeric(9, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ShutDownM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("ShutDown_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12);

                entity.Property(e => e.ShutdownCause)
                    .HasColumnName("shutdown_cause")
                    .HasMaxLength(50);

                entity.Property(e => e.ShutdownNo)
                    .IsRequired()
                    .HasColumnName("shutdown_no")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SignCardD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId, e.SignTime });

                entity.ToTable("SignCard_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32);

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SignCardM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("SignCard_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12);

                entity.Property(e => e.SignCause)
                    .HasColumnName("sign_cause")
                    .HasMaxLength(50);

                entity.Property(e => e.SignPersons).HasColumnName("sign_persons");

                entity.Property(e => e.SigncardNo)
                    .IsRequired()
                    .HasColumnName("signcard_no")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<SignInRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InOutFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.MeetingCode)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SmealRecords>(entity =>
            {
                entity.HasKey(e => new { e.ClockId, e.PosSequ, e.CardId, e.WalletFlag, e.SignTime, e.CardTimes, e.CardBalance });

                entity.ToTable("SMealRecords");

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.NRecSeq);

                entity.HasIndex(e => e.OnLineId)
                    .HasName("IX_SMealRecordsOnlineID");

                entity.HasIndex(e => e.SignTime)
                    .HasName("IX_SMealRecords_Sign_time");

                entity.HasIndex(e => new { e.CardId, e.WalletFlag, e.CardSequ })
                    .HasName("IX_SMealRecords_Card_Sequ");

                entity.Property(e => e.ClockId)
                    .HasColumnName("clock_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PosSequ)
                    .HasColumnName("pos_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(16);

                entity.Property(e => e.WalletFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CardTimes)
                    .HasColumnName("card_times")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardBalance)
                    .HasColumnName("card_balance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AllowanceBalance).HasColumnType("money");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BIsInvalid).HasColumnName("bIsInvalid");

                entity.Property(e => e.BObsolete).HasColumnName("bObsolete");

                entity.Property(e => e.BPassCheck).HasColumnName("bPassCheck");

                entity.Property(e => e.BusiStyle).HasDefaultValueSql("((0))");

                entity.Property(e => e.BusiType).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardConsume)
                    .HasColumnName("card_consume")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardFormat).HasDefaultValueSql("((1))");

                entity.Property(e => e.CardOldbalance)
                    .HasColumnName("card_oldbalance")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardSequ)
                    .HasColumnName("card_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CommonEmpId)
                    .HasColumnName("CommonEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyEmpId)
                    .HasColumnName("CompanyEmpID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartId)
                    .HasColumnName("Depart_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DifineSequ).HasColumnName("difine_sequ");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Failed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kind)
                    .HasColumnName("kind")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mealtype)
                    .HasColumnName("mealtype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpYmd)
                    .HasColumnName("op_ymd")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpcardId)
                    .HasColumnName("opcard_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OtherId)
                    .HasColumnName("other_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Passed).HasColumnName("passed");

                entity.Property(e => e.PsamappSn)
                    .HasColumnName("PSAMAppSN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Tac)
                    .HasColumnName("TAC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.VerId)
                    .HasColumnName("ver_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smsconfig>(entity =>
            {
                entity.HasKey(e => e.Smscode);

                entity.ToTable("SMSConfig");

                entity.Property(e => e.Smscode)
                    .HasColumnName("SMSCode")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Clocks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CurNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cyclostyle).HasColumnType("ntext");
            });

            modelBuilder.Entity<Sysparams>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).ValueGeneratedNever();

                entity.Property(e => e.Items)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Val)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaskLogs>(entity =>
            {
                entity.HasIndex(e => e.TaskTime);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClockId).HasColumnName("Clock_id");

                entity.Property(e => e.TaskLog)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TaskTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbDoorConfigFor988>(entity =>
            {
                entity.ToTable("tbDoorConfigFor988");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clocks).HasColumnType("ntext");

                entity.Property(e => e.ConfigData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TextType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Textmemo)
                    .HasColumnName("textmemo")
                    .HasColumnType("ntext");

                entity.Property(e => e.Texttypename)
                    .IsRequired()
                    .HasColumnName("texttypename")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimePicRecords>(entity =>
            {
                entity.HasKey(e => e.SerialId);

                entity.ToTable("timePicRecords");

                entity.Property(e => e.SerialId).HasColumnName("SerialID");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnName("Card_No")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId)
                    .HasColumnName("Clock_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasColumnType("image");

                entity.Property(e => e.PosSequ)
                    .HasColumnName("Pos_sequ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SignTime)
                    .HasColumnName("Sign_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TimePicRecordsHis>(entity =>
            {
                entity.HasKey(e => e.SerialId);

                entity.ToTable("timePicRecordsHis");

                entity.Property(e => e.SerialId).HasColumnName("SerialID");

                entity.Property(e => e.CardNo)
                    .IsRequired()
                    .HasColumnName("Card_No")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasColumnName("picture")
                    .HasColumnType("image");

                entity.Property(e => e.SignTime)
                    .HasColumnName("Sign_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TimeRecords>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CardId, e.SignTime });

                entity.HasIndex(e => e.SignTime)
                    .HasName("IX_TimeRecords_Sign_time");

                entity.HasIndex(e => new { e.ClockId, e.PosSequ })
                    .HasName("IX_TimePicRecordsClockIdPosSequ");

                entity.HasIndex(e => new { e.ClockId, e.CardId, e.SignTime })
                    .HasName("IX_TimeRecordsCidTime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(16);

                entity.Property(e => e.SignTime)
                    .HasColumnName("sign_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.ClockId)
                    .HasColumnName("clock_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DCollectTime)
                    .HasColumnName("dCollectTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32);

                entity.Property(e => e.EventName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mark)
                    .HasColumnName("mark")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PosSequ).HasColumnName("Pos_sequ");
            });

            modelBuilder.Entity<TransCorrect>(entity =>
            {
                entity.HasKey(e => new { e.CCardId, e.NAccountId, e.NTransTimes, e.CTransCode });

                entity.HasIndex(e => e.DTransDate);

                entity.HasIndex(e => e.NTransSeq);

                entity.Property(e => e.CCardId)
                    .HasColumnName("cCard_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NAccountId).HasColumnName("nAccountID");

                entity.Property(e => e.NTransTimes).HasColumnName("nTransTimes");

                entity.Property(e => e.CTransCode)
                    .HasColumnName("cTransCode")
                    .HasColumnType("char(4)");

                entity.Property(e => e.CEmpId)
                    .HasColumnName("cEmp_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DTransDate)
                    .HasColumnName("dTransDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.NAllow)
                    .HasColumnName("nAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NCharge)
                    .HasColumnName("nCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NTransAmount)
                    .HasColumnName("nTransAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NTransSeq).HasColumnName("nTransSeq");
            });

            modelBuilder.Entity<TranslateD>(entity =>
            {
                entity.HasKey(e => new { e.BillId, e.EmpId });

                entity.ToTable("Translate_D");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(30);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OldDepart)
                    .IsRequired()
                    .HasColumnName("old_depart")
                    .HasMaxLength(30);

                entity.Property(e => e.TranslateTime)
                    .HasColumnName("translate_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrnaslateDepart)
                    .IsRequired()
                    .HasColumnName("trnaslate_depart")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TranslateM>(entity =>
            {
                entity.HasKey(e => e.BillId);

                entity.ToTable("Translate_M");

                entity.Property(e => e.BillId)
                    .HasColumnName("bill_id")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Audit).HasColumnName("audit");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("check_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checker)
                    .HasColumnName("checker")
                    .HasMaxLength(10);

                entity.Property(e => e.Memo)
                    .HasColumnName("memo")
                    .HasMaxLength(50);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(10);

                entity.Property(e => e.Requirer)
                    .HasColumnName("requirer")
                    .HasMaxLength(12);

                entity.Property(e => e.TranslateCause)
                    .HasColumnName("Translate_cause")
                    .HasMaxLength(50);

                entity.Property(e => e.TranslateNo)
                    .IsRequired()
                    .HasColumnName("Translate_no")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TransRecords>(entity =>
            {
                entity.HasKey(e => new { e.NClockId, e.NPosSeq, e.DSignTime, e.CCardId, e.NAccountId, e.NTransTimes, e.CTransCode, e.CDinRoomId, e.NCloseBalance });

                entity.HasIndex(e => e.BreakStat);

                entity.HasIndex(e => e.DAccDate);

                entity.HasIndex(e => e.DSignTime);

                entity.HasIndex(e => e.NRecSeq);

                entity.HasIndex(e => new { e.CCardId, e.NAccountId, e.NTransTimes })
                    .HasName("IX_TransRecords_CardIdSequ");

                entity.Property(e => e.NClockId).HasColumnName("nClockID");

                entity.Property(e => e.NPosSeq).HasColumnName("nPosSeq");

                entity.Property(e => e.DSignTime)
                    .HasColumnName("dSignTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CCardId)
                    .HasColumnName("cCardID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NAccountId).HasColumnName("nAccountID");

                entity.Property(e => e.NTransTimes).HasColumnName("nTransTimes");

                entity.Property(e => e.CTransCode)
                    .HasColumnName("cTransCode")
                    .HasColumnType("char(4)");

                entity.Property(e => e.CDinRoomId)
                    .HasColumnName("cDinRoomID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.BCorrect).HasColumnName("bCorrect");

                entity.Property(e => e.BLoseFlag).HasColumnName("bLoseFlag");

                entity.Property(e => e.BNotWriteCard).HasColumnName("bNotWriteCard");

                entity.Property(e => e.BTransFlag).HasColumnName("bTransFlag");

                entity.Property(e => e.BreakStat).HasDefaultValueSql("((0))");

                entity.Property(e => e.CEmpId)
                    .HasColumnName("cEmpID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DCorrectDate)
                    .HasColumnName("dCorrectDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartId)
                    .HasColumnName("Depart_id")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.InTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Invalid).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDmoreTimes).HasColumnName("IsDMoreTimes");

                entity.Property(e => e.Mark)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NAmount)
                    .HasColumnName("nAmount")
                    .HasColumnType("money");

                entity.Property(e => e.NBookType).HasColumnName("nBookType");

                entity.Property(e => e.NInBounds)
                    .HasColumnName("nInBounds")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NKind).HasColumnName("nKind");

                entity.Property(e => e.NLogicalId).HasColumnName("nLogicalID");

                entity.Property(e => e.NOrigRecSeq).HasColumnName("nOrigRecSeq");

                entity.Property(e => e.NRecSeq)
                    .HasColumnName("nRecSeq")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NRevertTransSeq).HasColumnName("nRevertTransSeq");

                entity.Property(e => e.NSavedTransTimes).HasColumnName("nSavedTransTimes");

                entity.Property(e => e.NSrcType).HasColumnName("nSrcType");

                entity.Property(e => e.NTransSeq).HasColumnName("nTransSeq");

                entity.Property(e => e.NWriteCardMoney)
                    .HasColumnName("nWriteCardMoney")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Uimkey>(entity =>
            {
                entity.HasKey(e => new { e.Vendor, e.AppId });

                entity.ToTable("UIMKey");

                entity.Property(e => e.Vendor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppId)
                    .HasColumnName("AppID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AppKey)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDayAccountBook>(entity =>
            {
                entity.HasKey(e => new { e.CCardId, e.NAccountId, e.DAccDate });

                entity.HasIndex(e => e.DAccDate);

                entity.Property(e => e.CCardId)
                    .HasColumnName("cCardID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NAccountId).HasColumnName("nAccountID");

                entity.Property(e => e.DAccDate)
                    .HasColumnName("dAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CEmpId)
                    .HasColumnName("cEmpID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CEmpName)
                    .HasColumnName("cEmpName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardCost).HasColumnType("money");

                entity.Property(e => e.CardCostOut).HasColumnType("money");

                entity.Property(e => e.CloseCardCost).HasColumnType("money");

                entity.Property(e => e.CloseMaintenance).HasColumnType("money");

                entity.Property(e => e.DPrevAccDate)
                    .HasColumnName("dPrevAccDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartId)
                    .HasColumnName("depart_id")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.LastBalance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastTransTimes).HasDefaultValueSql("((0))");

                entity.Property(e => e.Maintenance).HasColumnType("money");

                entity.Property(e => e.MaintenanceOut).HasColumnType("money");

                entity.Property(e => e.NAllowMeal)
                    .HasColumnName("nAllowMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NCountMeal).HasColumnName("nCountMeal");

                entity.Property(e => e.NEveningAmount)
                    .HasColumnName("nEveningAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NEveningTimes)
                    .HasColumnName("nEveningTimes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NInAllow)
                    .HasColumnName("nInAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NInBatch)
                    .HasColumnName("nInBatch")
                    .HasColumnType("money");

                entity.Property(e => e.NInBounds)
                    .HasColumnName("nInBounds")
                    .HasColumnType("money");

                entity.Property(e => e.NInCash)
                    .HasColumnName("nInCash")
                    .HasColumnType("money");

                entity.Property(e => e.NInClear)
                    .HasColumnName("nInClear")
                    .HasColumnType("money");

                entity.Property(e => e.NInFixCharge)
                    .HasColumnName("nInFixCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayAllow)
                    .HasColumnName("nInGrayAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayAllowCash)
                    .HasColumnName("nInGrayAllowCash")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayMealCash)
                    .HasColumnName("nInGrayMealCash")
                    .HasColumnType("money");

                entity.Property(e => e.NInInit)
                    .HasColumnName("nInInit")
                    .HasColumnType("money");

                entity.Property(e => e.NInReceive)
                    .HasColumnName("nInReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NLoseAmount)
                    .HasColumnName("nLoseAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvAmount)
                    .HasColumnName("nMealEvAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealEvening)
                    .HasColumnName("nMealEvening")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealMoAmount)
                    .HasColumnName("nMealMoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealMorning)
                    .HasColumnName("nMealMorning")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNiAmount)
                    .HasColumnName("nMealNiAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNight)
                    .HasColumnName("nMealNight")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNoAmount)
                    .HasColumnName("nMealNoAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealNoon)
                    .HasColumnName("nMealNoon")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealOtAmount)
                    .HasColumnName("nMealOtAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMealOther)
                    .HasColumnName("nMealOther")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMorningAmount)
                    .HasColumnName("nMorningAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NMorningTimes)
                    .HasColumnName("nMorningTimes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NNightAmount)
                    .HasColumnName("nNightAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NNightTimes)
                    .HasColumnName("nNightTimes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NNoonAmount)
                    .HasColumnName("nNoonAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NNoonTimes)
                    .HasColumnName("nNoonTimes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOffLine)
                    .HasColumnName("nOffLine")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOnLine)
                    .HasColumnName("nOnLine")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOpenBalance)
                    .HasColumnName("nOpenBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NOrderMeal)
                    .HasColumnName("nOrderMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOtherAmount)
                    .HasColumnName("nOtherAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOtherTimes)
                    .HasColumnName("nOtherTimes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOutCancelMeal)
                    .HasColumnName("nOutCancelMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutCash)
                    .HasColumnName("nOutCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOutConsume)
                    .HasColumnName("nOutConsume")
                    .HasColumnType("money");

                entity.Property(e => e.NOutFixMeal)
                    .HasColumnName("nOutFixMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutGrayMeal)
                    .HasColumnName("nOutGrayMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutInput)
                    .HasColumnName("nOutInput")
                    .HasColumnType("money");

                entity.Property(e => e.NOutModify)
                    .HasColumnName("nOutModify")
                    .HasColumnType("money");

                entity.Property(e => e.NOutOrderConsume)
                    .HasColumnName("nOutOrderConsume")
                    .HasColumnType("money");

                entity.Property(e => e.NOutReturnCash)
                    .HasColumnName("nOutReturnCash")
                    .HasColumnType("money");

                entity.Property(e => e.NOuterConsume)
                    .HasColumnName("nOuterConsume")
                    .HasColumnType("money");

                entity.Property(e => e.NOuterCountMeal).HasColumnName("nOuterCountMeal");

                entity.Property(e => e.NQuanCash)
                    .HasColumnName("nQuanCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NReIssueCash)
                    .HasColumnName("nReIssueCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenCardCost).HasColumnType("money");

                entity.Property(e => e.OpenMaintenance).HasColumnType("money");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.ToTable("user_log");

                entity.HasIndex(e => new { e.OpDate, e.Kind })
                    .HasName("IX_user_log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardId)
                    .HasColumnName("Card_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kind)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OpDate)
                    .HasColumnName("op_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpUser)
                    .HasColumnName("op_user")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMonthAccountBook>(entity =>
            {
                entity.HasKey(e => new { e.CCardId, e.NAccountId, e.CAccMonth });

                entity.Property(e => e.CCardId)
                    .HasColumnName("cCardID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NAccountId).HasColumnName("nAccountID");

                entity.Property(e => e.CAccMonth)
                    .HasColumnName("cAccMonth")
                    .HasColumnType("char(6)");

                entity.Property(e => e.CEmpId)
                    .HasColumnName("cEmpID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CEmpName)
                    .HasColumnName("cEmpName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardCost).HasColumnType("money");

                entity.Property(e => e.CardCostOut).HasColumnType("money");

                entity.Property(e => e.CloseCardCost).HasColumnType("money");

                entity.Property(e => e.CloseMaintenance).HasColumnType("money");

                entity.Property(e => e.DBeginDate)
                    .HasColumnName("dBeginDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DEndDate)
                    .HasColumnName("dEndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartId)
                    .HasColumnName("depart_id")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Maintenance).HasColumnType("money");

                entity.Property(e => e.MaintenanceOut).HasColumnType("money");

                entity.Property(e => e.NAllowMeal)
                    .HasColumnName("nAllowMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NCloseBalance)
                    .HasColumnName("nCloseBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NCountMeal).HasColumnName("nCountMeal");

                entity.Property(e => e.NInAllow)
                    .HasColumnName("nInAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NInBatch)
                    .HasColumnName("nInBatch")
                    .HasColumnType("money");

                entity.Property(e => e.NInBounds)
                    .HasColumnName("nInBounds")
                    .HasColumnType("money");

                entity.Property(e => e.NInCash)
                    .HasColumnName("nInCash")
                    .HasColumnType("money");

                entity.Property(e => e.NInClear)
                    .HasColumnName("nInClear")
                    .HasColumnType("money");

                entity.Property(e => e.NInFixCharge)
                    .HasColumnName("nInFixCharge")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayAllow)
                    .HasColumnName("nInGrayAllow")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayAllowCash)
                    .HasColumnName("nInGrayAllowCash")
                    .HasColumnType("money");

                entity.Property(e => e.NInGrayMealCash)
                    .HasColumnName("nInGrayMealCash")
                    .HasColumnType("money");

                entity.Property(e => e.NInInit)
                    .HasColumnName("nInInit")
                    .HasColumnType("money");

                entity.Property(e => e.NInReceive)
                    .HasColumnName("nInReceive")
                    .HasColumnType("money");

                entity.Property(e => e.NLoseAmount)
                    .HasColumnName("nLoseAmount")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOffLine)
                    .HasColumnName("nOffLine")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOnLine)
                    .HasColumnName("nOnLine")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOpenBalance)
                    .HasColumnName("nOpenBalance")
                    .HasColumnType("money");

                entity.Property(e => e.NOrderMeal)
                    .HasColumnName("nOrderMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutCancelMeal)
                    .HasColumnName("nOutCancelMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutCash)
                    .HasColumnName("nOutCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NOutConsume)
                    .HasColumnName("nOutConsume")
                    .HasColumnType("money");

                entity.Property(e => e.NOutFixMeal)
                    .HasColumnName("nOutFixMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutGrayMeal)
                    .HasColumnName("nOutGrayMeal")
                    .HasColumnType("money");

                entity.Property(e => e.NOutInput)
                    .HasColumnName("nOutInput")
                    .HasColumnType("money");

                entity.Property(e => e.NOutModify)
                    .HasColumnName("nOutModify")
                    .HasColumnType("money");

                entity.Property(e => e.NOutOrderConsume)
                    .HasColumnName("nOutOrderConsume")
                    .HasColumnType("money");

                entity.Property(e => e.NOutReturnCash)
                    .HasColumnName("nOutReturnCash")
                    .HasColumnType("money");

                entity.Property(e => e.NOuterConsume)
                    .HasColumnName("nOuterConsume")
                    .HasColumnType("money");

                entity.Property(e => e.NOuterCountMeal).HasColumnName("nOuterCountMeal");

                entity.Property(e => e.NQuanCash)
                    .HasColumnName("nQuanCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NReIssueCash)
                    .HasColumnName("nReIssueCash")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpenCardCost).HasColumnType("money");

                entity.Property(e => e.OpenMaintenance).HasColumnType("money");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_id")
                    .HasMaxLength(12)
                    .ValueGeneratedNever();

                entity.Property(e => e.Access).HasColumnType("ntext");

                entity.Property(e => e.Clocks).HasColumnType("ntext");

                entity.Property(e => e.Departs)
                    .HasColumnName("departs")
                    .HasColumnType("ntext");

                entity.Property(e => e.GroupName).HasMaxLength(20);

                entity.Property(e => e.IssueEmpId).HasColumnName("IssueEmpID");

                entity.Property(e => e.LoginComputer)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.LoginIp)
                    .HasColumnName("LoginIP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginMachineCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.MaxcardempId).HasColumnName("maxcardempID");

                entity.Property(e => e.Maxcardno).HasColumnName("maxcardno");

                entity.Property(e => e.MincardempId).HasColumnName("mincardempID");

                entity.Property(e => e.Mincardno).HasColumnName("mincardno");

                entity.Property(e => e.PassWord).HasMaxLength(18);

                entity.Property(e => e.RealClocks).HasColumnType("ntext");

                entity.Property(e => e.UserName).HasMaxLength(20);
            });

            modelBuilder.Entity<WhiteCardTask>(entity =>
            {
                entity.HasIndex(e => e.CardId)
                    .HasName("IX_WhiteCardTask_Card_id");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Areacode)
                    .HasColumnName("areacode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CardId)
                    .HasColumnName("card_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CardSn)
                    .HasColumnName("card_Sn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype)
                    .HasColumnName("cardtype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cardtypecode)
                    .HasColumnName("cardtypecode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ClockId).HasColumnName("clock_id");

                entity.Property(e => e.DeptName)
                    .HasColumnName("deptName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpFname)
                    .HasColumnName("emp_fname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasColumnName("emp_id")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ExecuteDate).HasColumnType("datetime");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Opdate)
                    .HasColumnName("opdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RealCardNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timebound)
                    .HasColumnName("timebound")
                    .HasMaxLength(14)
                    .IsUnicode(false);
            });
        }
    }
}
