

using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FinanceBillingData.Entities
{
    public partial class Finance_BillingContext : DbContext
    {
        public Finance_BillingContext(DbContextOptions<Finance_BillingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbl4DebitcardTmp> Tbl4DebitcardTmps { get; set; }
        public virtual DbSet<TblBackupReportingExportTable> TblBackupReportingExportTables { get; set; }
        public virtual DbSet<TblBillingInvoiceExport> TblBillingInvoiceExports { get; set; }
        public virtual DbSet<TblBillingInvoiceExportAllQuickBook> TblBillingInvoiceExportAllQuickBooks { get; set; }
        public virtual DbSet<TblBillingInvoiceExportQb> TblBillingInvoiceExportQbs { get; set; }
        public virtual DbSet<TblBkRptExport> TblBkRptExports { get; set; }
        public virtual DbSet<TblConversionAccountStatus> TblConversionAccountStatuses { get; set; }
        public virtual DbSet<TblConversionEmployeeStatus> TblConversionEmployeeStatuses { get; set; }
        public virtual DbSet<TblEdiBillingGroupCount> TblEdiBillingGroupCounts { get; set; }
        public virtual DbSet<TblErrorLog> TblErrorLogs { get; set; }
        public virtual DbSet<TblErrorMsg> TblErrorMsgs { get; set; }
        public virtual DbSet<TblExcludedClient> TblExcludedClients { get; set; }
        public virtual DbSet<TblFilesNameToUpload> TblFilesNameToUploads { get; set; }
        public virtual DbSet<TblInvoiceDateTable> TblInvoiceDateTables { get; set; }
        public virtual DbSet<TblLogging> TblLoggings { get; set; }

        public virtual DbSet<TblMonthMinConversion> TblMonthMinConversions { get; set; }
        public virtual DbSet<TblMonthMinConversionInvoice> TblMonthMinConversionInvoices { get; set; }
        public virtual DbSet<TblProcess> TblProcesses { get; set; }
        public virtual DbSet<TblProcessBk> TblProcessBks { get; set; }
        public virtual DbSet<TblQbImportsPro> TblQbImportsPros { get; set; }
        public virtual DbSet<TblQbTeCount> TblQbTeCounts { get; set; }
        public virtual DbSet<TblStagingAccount> TblStagingAccounts { get; set; }
        public virtual DbSet<TblStagingAccountTypeConversion> TblStagingAccountTypeConversions { get; set; }
        public virtual DbSet<TblStagingBenefitSummaryRpt> TblStagingBenefitSummaryRpts { get; set; }
        public virtual DbSet<TblStagingBrokerclientlist> TblStagingBrokerclientlists { get; set; }
        public virtual DbSet<TblStagingBswiftBillingnumImport> TblStagingBswiftBillingnumImports { get; set; }
        public virtual DbSet<TblStagingClientsMaster> TblStagingClientsMasters { get; set; }
        public virtual DbSet<TblStagingCobraClientList> TblStagingCobraClientLists { get; set; }
        public virtual DbSet<TblStagingCobraLetter> TblStagingCobraLetters { get; set; }
        public virtual DbSet<TblStagingCobraLettersSummary> TblStagingCobraLettersSummaries { get; set; }
        public virtual DbSet<TblStagingEbExtract> TblStagingEbExtracts { get; set; }
        public virtual DbSet<TblStagingEcExtract> TblStagingEcExtracts { get; set; }
        public virtual DbSet<TblStagingEdi2SourceDatum> TblStagingEdi2SourceData { get; set; }
        public virtual DbSet<TblStagingEdi3SourceDatum> TblStagingEdi3SourceData { get; set; }
        public virtual DbSet<TblStagingEdi4DebitCardSummary> TblStagingEdi4DebitCardSummaries { get; set; }
        public virtual DbSet<TblStagingEdi4SourceDatum> TblStagingEdi4SourceData { get; set; }
        public virtual DbSet<TblStagingEdi5PlanDocReport> TblStagingEdi5PlanDocReports { get; set; }
        public virtual DbSet<TblStagingEdi5PlanDocReportPrior> TblStagingEdi5PlanDocReportPriors { get; set; }
        public virtual DbSet<TblStagingEdi6SourceDatum> TblStagingEdi6SourceData { get; set; }
        public virtual DbSet<TblStagingEmployeeNavImport> TblStagingEmployeeNavImports { get; set; }
        public virtual DbSet<TblStagingFinalEdiBillingGroupCount> TblStagingFinalEdiBillingGroupCounts { get; set; }
        public virtual DbSet<TblStagingNpm> TblStagingNpms { get; set; }
        public virtual DbSet<TblStagingNpmDist> TblStagingNpmDists { get; set; }
        public virtual DbSet<TblStagingNpnCount> TblStagingNpnCounts { get; set; }
        public virtual DbSet<TblStagingQbTpCount> TblStagingQbTpCounts { get; set; }
        public virtual DbSet<TblStagingQbdetail> TblStagingQbdetails { get; set; }
        public virtual DbSet<TblStagingSpmbyacareport> TblStagingSpmbyacareports { get; set; }
        public virtual DbSet<TblStagingSpmbyacareportDist> TblStagingSpmbyacareportDists { get; set; }
        public virtual DbSet<TblStatingEbExtract> TblStatingEbExtracts { get; set; }
        public virtual DbSet<TblStatingEcExtract> TblStatingEcExtracts { get; set; }
        public virtual DbSet<TblStatingQbTeCount> TblStatingQbTeCounts { get; set; }
        public virtual DbSet<TblStatingQbTpCount> TblStatingQbTpCounts { get; set; }
        public virtual DbSet<VwInvoiceByMonth> VwInvoiceByMonths { get; set; }
        public virtual DbSet<VwNewClient> VwNewClient { get; set; }
        public virtual DbSet<VwExistingClient> VwExistingClient { get; set; }
        public virtual DbSet<VwTerminatedClient> VwTerminatedClient { get; set; }

        public virtual DbSet<ClientProductComparison> ClientProductComparisons { get; set; }
        public virtual DbSet<ClientToClientComparison> ClientToClientComparisons { get; set; }



        public virtual DbSet<SpClientDropDownData> SpClientDropDownData { get; set; }
        public virtual DbSet<SpExcludeClientData> SpExcludeClientData { get; set; }

        public virtual DbSet<TblQBClients> TblQBClients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.                optionsBuilder.UseSqlServer("Data Source=BE015;Initial Catalog=Finance_Billing;Integrated Security=SSPI;", Builder => Builder.EnableRetryOnFailure());
                optionsBuilder.UseSqlServer("Data Source=BE015;Initial Catalog=Finance_Billing;Integrated Security=SSPI;", Builder => Builder.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl4DebitcardTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_4_DEBITCARD_TMP");

                entity.Property(e => e.AdministratorId)
                    .HasMaxLength(50)
                    .HasColumnName("Administrator Id");

                entity.Property(e => e.AdministratorName)
                    .HasMaxLength(50)
                    .HasColumnName("Administrator Name");

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .HasColumnName("Column 1");

                entity.Property(e => e.Column10)
                    .HasMaxLength(50)
                    .HasColumnName("Column 10");

                entity.Property(e => e.Column11)
                    .HasMaxLength(50)
                    .HasColumnName("Column 11");

                entity.Property(e => e.Column13)
                    .HasMaxLength(50)
                    .HasColumnName("Column 13");

                entity.Property(e => e.Column14)
                    .HasMaxLength(50)
                    .HasColumnName("Column 14");

                entity.Property(e => e.Column16)
                    .HasMaxLength(50)
                    .HasColumnName("Column 16");

                entity.Property(e => e.Column3)
                    .HasMaxLength(50)
                    .HasColumnName("Column 3");

                entity.Property(e => e.Column5)
                    .HasMaxLength(50)
                    .HasColumnName("Column 5");

                entity.Property(e => e.Column7)
                    .HasMaxLength(50)
                    .HasColumnName("Column 7");

                entity.Property(e => e.Column8)
                    .HasMaxLength(50)
                    .HasColumnName("Column 8");

                entity.Property(e => e.Employer).HasMaxLength(50);

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(50)
                    .HasColumnName("Employer Id");

                entity.Property(e => e.NewCards)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New Cards");

                entity.Property(e => e.ReplacementCards)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Replacement Cards");

                entity.Property(e => e.TotalCards)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Total Cards");
            });

            modelBuilder.Entity<TblBackupReportingExportTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Backup Reporting Export Table");

                entity.Property(e => e.ActualBillingCode)
                    .HasMaxLength(500)
                    .HasColumnName("ACTUAL_BILLING CODE");

                entity.Property(e => e.BackupInvoiceNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Backup Invoice Number");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("BILLING CODE");

                entity.Property(e => e.BillingDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Description");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BillingGroupProcess)
                    .HasMaxLength(500)
                    .HasColumnName("Billing Group Process");

                entity.Property(e => e.BndBillingCode)
                    .HasMaxLength(500)
                    .HasColumnName("BND_BILLING CODE");

                entity.Property(e => e.DeleteReason).HasMaxLength(500);

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.OriginalEmployerName)
                    .HasMaxLength(254)
                    .HasColumnName("ORIGINAL EMPLOYER NAME");

                entity.Property(e => e.ParticipantStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Participant Status");

                entity.Property(e => e.ParticipantTermDate)
                    .HasPrecision(0)
                    .HasColumnName("Participant Term Date");

                entity.Property(e => e.Pepm)
                    .HasMaxLength(255)
                    .HasColumnName("PEPM");

                entity.Property(e => e.PepmAmount)
                    .HasColumnType("money")
                    .HasColumnName("PEPM Amount");

                entity.Property(e => e.PepmFlg).HasColumnName("PEPM Flg");

                entity.Property(e => e.UniqueKeyParticipant).HasMaxLength(255);
            });

            modelBuilder.Entity<TblBillingInvoiceExport>(entity =>
            {
                entity.HasKey(e => e.Rowid)
                    .HasName("{schema}_TBL_BILLING INVOICE EXPORT_pk")
                    .IsClustered(false);

                entity.ToTable("TBL_BILLING INVOICE EXPORT");

                entity.Property(e => e.Rowid).HasColumnName("rowid");

                entity.Property(e => e.BillTo)
                    .HasMaxLength(255)
                    .HasColumnName("Bill To");

                entity.Property(e => e.BillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Billing Amount");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Code");

                entity.Property(e => e.BillingCodeQb)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Code QB");

                entity.Property(e => e.BillingDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Description");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BillingGroupProcess)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group Process");

                entity.Property(e => e.BillingPeriod)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Period");

                entity.Property(e => e.BillingUnitCount)
                    .HasColumnType("money")
                    .HasColumnName("Billing Unit Count");

                entity.Property(e => e.BillingUnitRate)
                    .HasColumnType("money")
                    .HasColumnName("Billing Unit Rate");

                entity.Property(e => e.BrokerCode)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Code");

                entity.Property(e => e.BrokerName)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Name");

                entity.Property(e => e.CalculatedBillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Calculated Billing Amount");

                entity.Property(e => e.CustomerMessage)
                    .HasMaxLength(255)
                    .HasColumnName("Customer Message");

                entity.Property(e => e.DeleteReason).HasMaxLength(2000);

                entity.Property(e => e.EmployerBillingNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Billing Number");

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.GlExpenseAccount)
                    .HasMaxLength(255)
                    .HasColumnName("GL Expense Account");

                entity.Property(e => e.GlReceivableAccount)
                    .HasMaxLength(255)
                    .HasColumnName("GL Receivable Account");

                entity.Property(e => e.InvoiceDate)
                    .HasPrecision(0)
                    .HasColumnName("Invoice Date");

                entity.Property(e => e.InvoiceDueDate)
                    .HasPrecision(0)
                    .HasColumnName("Invoice Due Date");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Invoice Number");

                entity.Property(e => e.KeyMmMonthlyMinimum)
                    .HasMaxLength(255)
                    .HasColumnName("KEY_MM Monthly Minimum");

                entity.Property(e => e.MonthlyMinBillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Monthly Min Billing Amount");

                entity.Property(e => e.MonthlyMinBillingFlg).HasColumnName("Monthly Min Billing Flg");

                entity.Property(e => e.MonthlyMinToDelete).HasColumnName("Monthly Min To Delete");

                entity.Property(e => e.OriginalEmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Original Employer Name");

                entity.Property(e => e.PaidByBrokerFlg).HasColumnName("PAID BY BROKER FLG");

                entity.Property(e => e.ProcessedGroup)
                    .HasMaxLength(50)
                    .HasColumnName("PROCESSED_GROUP");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.SystemEmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("System Employer Key");

                entity.Property(e => e.Terms).HasMaxLength(255);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .HasColumnName("To Email");

                entity.Property(e => e.ToPrint)
                    .HasMaxLength(255)
                    .HasColumnName("To Print");
            });

            modelBuilder.Entity<TblBillingInvoiceExportAllQuickBook>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("tbl_Billing Invoice Export All QuickBooks_pk")
                    .IsClustered(false);

                entity.ToTable("tbl_Billing Invoice Export All QuickBooks");

                entity.Property(e => e.RowId).HasColumnName("rowID");

                entity.Property(e => e.BillTo)
                    .HasMaxLength(255)
                    .HasColumnName("Bill To");

                entity.Property(e => e.BillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Billing Amount");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Code");

                entity.Property(e => e.BillingCodeQb)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Code QB");

                entity.Property(e => e.BillingDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Description");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BillingGroupProcess)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group Process");

                entity.Property(e => e.BillingPeriod)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Period");

                entity.Property(e => e.BillingUnitCount)
                    .HasColumnType("money")
                    .HasColumnName("Billing Unit Count");

                entity.Property(e => e.BillingUnitRate)
                    .HasColumnType("money")
                    .HasColumnName("Billing Unit Rate");

                entity.Property(e => e.BrokerCode)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Code");

                entity.Property(e => e.BrokerName)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Name");

                entity.Property(e => e.CalculatedBillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Calculated Billing Amount");

                entity.Property(e => e.CustomerMessage)
                    .HasMaxLength(255)
                    .HasColumnName("Customer Message");

                entity.Property(e => e.DeleteReason).HasMaxLength(2000);

                entity.Property(e => e.EmployerBillingNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Billing Number");

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.GlExpenseAccount)
                    .HasMaxLength(255)
                    .HasColumnName("GL Expense Account");

                entity.Property(e => e.GlReceivableAccount)
                    .HasMaxLength(255)
                    .HasColumnName("GL Receivable Account");

                entity.Property(e => e.InvoiceDate)
                    .HasPrecision(0)
                    .HasColumnName("Invoice Date");

                entity.Property(e => e.InvoiceDueDate)
                    .HasPrecision(0)
                    .HasColumnName("Invoice Due Date");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Invoice Number");

                entity.Property(e => e.KeyMmMonthlyMinimum)
                    .HasMaxLength(255)
                    .HasColumnName("KEY_MM Monthly Minimum");

                entity.Property(e => e.MonthlyMinBillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Monthly Min Billing Amount");

                entity.Property(e => e.MonthlyMinBillingFlg).HasColumnName("Monthly Min Billing Flg");

                entity.Property(e => e.MonthlyMinToDelete).HasColumnName("Monthly Min To Delete");

                entity.Property(e => e.OriginalEmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Original Employer Name");

                entity.Property(e => e.PaidByBrokerFlg).HasColumnName("PAID BY BROKER FLG");

                entity.Property(e => e.ProcessedGroup)
                    .HasMaxLength(50)
                    .HasColumnName("PROCESSED_GROUP");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.SystemEmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("System Employer Key");

                entity.Property(e => e.Terms).HasMaxLength(255);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .HasColumnName("To Email");

                entity.Property(e => e.ToPrint)
                    .HasMaxLength(255)
                    .HasColumnName("To Print");
            });

            modelBuilder.Entity<TblBillingInvoiceExportQb>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("TBL_BILLING_INVOICE_EXPORT_QB_pk")
                    .IsClustered(false);

                entity.ToTable("TBL_BILLING_INVOICE_EXPORT_QB");

                entity.Property(e => e.RowId).HasColumnName("rowID");

                entity.Property(e => e.BillTo)
                    .HasMaxLength(255)
                    .HasColumnName("Bill To");

                entity.Property(e => e.BillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Billing Amount");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Code");

                entity.Property(e => e.BillingCodeQb)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Code QB");

                entity.Property(e => e.BillingDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Description");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BillingGroupProcess)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group Process");

                entity.Property(e => e.BillingPeriod)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Period");

                entity.Property(e => e.BillingUnitCount)
                    .HasColumnType("money")
                    .HasColumnName("Billing Unit Count");

                entity.Property(e => e.BillingUnitRate)
                    .HasColumnType("money")
                    .HasColumnName("Billing Unit Rate");

                entity.Property(e => e.BrokerCode)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Code");

                entity.Property(e => e.BrokerName)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Name");

                entity.Property(e => e.CalculatedBillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Calculated Billing Amount");

                entity.Property(e => e.CustomerMessage)
                    .HasMaxLength(255)
                    .HasColumnName("Customer Message");

                entity.Property(e => e.DeleteReason).HasMaxLength(2000);

                entity.Property(e => e.EmployerBillingNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Billing Number");

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.GlExpenseAccount)
                    .HasMaxLength(255)
                    .HasColumnName("GL Expense Account");

                entity.Property(e => e.GlReceivableAccount)
                    .HasMaxLength(255)
                    .HasColumnName("GL Receivable Account");

                entity.Property(e => e.InvoiceDate)
                    .HasPrecision(0)
                    .HasColumnName("Invoice Date");

                entity.Property(e => e.InvoiceDueDate)
                    .HasPrecision(0)
                    .HasColumnName("Invoice Due Date");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Invoice Number");

                entity.Property(e => e.KeyMmMonthlyMinimum)
                    .HasMaxLength(255)
                    .HasColumnName("KEY_MM Monthly Minimum");

                entity.Property(e => e.MonthlyMinBillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("Monthly Min Billing Amount");

                entity.Property(e => e.MonthlyMinBillingFlg).HasColumnName("Monthly Min Billing Flg");

                entity.Property(e => e.MonthlyMinToDelete).HasColumnName("Monthly Min To Delete");

                entity.Property(e => e.OriginalEmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Original Employer Name");

                entity.Property(e => e.PaidByBrokerFlg).HasColumnName("PAID BY BROKER FLG");

                entity.Property(e => e.ProcessedGroup)
                    .HasMaxLength(50)
                    .HasColumnName("PROCESSED_GROUP");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.SystemEmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("System Employer Key");

                entity.Property(e => e.Terms).HasMaxLength(255);

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .HasColumnName("To Email");

                entity.Property(e => e.ToPrint)
                    .HasMaxLength(255)
                    .HasColumnName("To Print");
            });

            modelBuilder.Entity<TblBkRptExport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_BK_RPT_EXPORT");

                entity.Property(e => e.ActualBillingCode)
                    .HasMaxLength(500)
                    .HasColumnName("ACTUAL_BILLING CODE");

                entity.Property(e => e.BackupInvoiceNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Backup Invoice Number");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("BILLING CODE");

                entity.Property(e => e.BillingDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Description");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BillingGroupProcess)
                    .HasMaxLength(500)
                    .HasColumnName("Billing Group Process");

                entity.Property(e => e.BndBillingCode)
                    .HasMaxLength(500)
                    .HasColumnName("BND_BILLING CODE");

                entity.Property(e => e.DeleteReason).HasMaxLength(500);

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.OriginalEmployerName)
                    .HasMaxLength(254)
                    .HasColumnName("ORIGINAL EMPLOYER NAME");

                entity.Property(e => e.ParticipantStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Participant Status");

                entity.Property(e => e.ParticipantTermDate)
                    .HasPrecision(0)
                    .HasColumnName("Participant Term Date");

                entity.Property(e => e.Pepm)
                    .HasMaxLength(255)
                    .HasColumnName("PEPM");

                entity.Property(e => e.PepmAmount)
                    .HasColumnType("money")
                    .HasColumnName("PEPM Amount");

                entity.Property(e => e.PepmFlg).HasColumnName("PEPM Flg");

                entity.Property(e => e.UniqueKeyParticipant).HasMaxLength(255);
            });

            modelBuilder.Entity<TblConversionAccountStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_CONVERSION_ACCOUNT_STATUS");

                entity.Property(e => e.SourceStatusCode)
                    .HasMaxLength(255)
                    .HasColumnName("Source Status Code");

                entity.Property(e => e.TargetStatusCode)
                    .HasMaxLength(255)
                    .HasColumnName("Target status Code");
            });

            modelBuilder.Entity<TblConversionEmployeeStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_CONVERSION_EMPLOYEE_STATUS");

                entity.Property(e => e.SourceStatusCode)
                    .HasMaxLength(255)
                    .HasColumnName("Source Status Code");

                entity.Property(e => e.TargetStatusCode)
                    .HasMaxLength(255)
                    .HasColumnName("Target status Code");
            });

            modelBuilder.Entity<TblEdiBillingGroupCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_EDI_BILLING_GROUP_COUNT");

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.FinalBillableCounts).HasColumnName("Final Billable Counts");

                entity.Property(e => e.NpmCount).HasColumnName("NPM Count");

                entity.Property(e => e.Suppress).HasMaxLength(255);

                entity.Property(e => e.TeCount).HasColumnName("TE Count");

                entity.Property(e => e.TpCount).HasColumnName("TP Count");
            });

            modelBuilder.Entity<TblErrorLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__db_error__9E2397E0BD305C55");

                entity.ToTable("TBL_ERROR_LOG");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("created_by");

                entity.Property(e => e.ErrMsg)
                    .HasColumnType("text")
                    .HasColumnName("err_msg");

                entity.Property(e => e.ErrNo)
                    .HasMaxLength(50)
                    .HasColumnName("err_no");

                entity.Property(e => e.ErrSource)
                    .HasMaxLength(500)
                    .HasColumnName("err_source");

                entity.Property(e => e.SqlState)
                    .HasMaxLength(200)
                    .HasColumnName("sql_state");
            });

            modelBuilder.Entity<TblErrorMsg>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__TBL_ERRO__9E2397E03259902A");

                entity.ToTable("TBL_ERROR_MSG");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("created_by");

                entity.Property(e => e.LogLevel)
                    .HasMaxLength(200)
                    .HasColumnName("log_level");

                entity.Property(e => e.LogMsg)
                    .HasColumnType("text")
                    .HasColumnName("log_msg");

                entity.Property(e => e.LogSource)
                    .HasMaxLength(500)
                    .HasColumnName("log_source");
            });
            modelBuilder.Entity<TblExcludedClient>(entity =>
            {
                entity.Property(e => e.ClientID)
                    .HasColumnName("ClientID");

                entity.ToTable("TBL_EXCLUDE_CLIENT");

                entity.Property(e => e.ClientName)
                .HasColumnName("ClientName");
                entity.HasKey(e => e.Id)
                .HasName("Id");
                entity.Property(e => e.isDeleted)
                 .HasColumnName("isDeleted");

                entity.Property(e => e.Bencode)
                    .HasColumnName("Bencode");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("Description");

                entity.Property(e => e.UserID)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasColumnType("text")
                    .HasColumnName("UserName");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CreateDate");
            });

            modelBuilder.Entity<TblFilesNameToUpload>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_FilesNameToUpload");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TblInvoiceDateTable>(entity =>
            {
                entity.HasKey(e => e.BillingDateMonth)
                    .HasName("{schema}_tbl_Invoice Date Table_pk")
                    .IsClustered(false);

                entity.ToTable("TBL_INVOICE_DATE_TABLE");

                entity.Property(e => e.BillingDateMonth)
                    .HasPrecision(0)
                    .HasColumnName("Billing Date Month");

                entity.Property(e => e.BillingPeriod)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Period");

                entity.Property(e => e.BillingPeriodToCompare)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Period To Compare");

                entity.Property(e => e.BillingRunoutDate)
                    .HasPrecision(0)
                    .HasColumnName("Billing Runout Date");

                entity.Property(e => e.EnrollmentMaxEffexctiveDt)
                    .HasPrecision(0)
                    .HasColumnName("Enrollment Max Effexctive dt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceCustomerMessage)
                    .HasMaxLength(255)
                    .HasColumnName("Invoice Customer Message");

                entity.Property(e => e.InvoiceDate)
                    .HasPrecision(0)
                    .HasColumnName("Invoice Date");

                entity.Property(e => e.InvoiceDueDate)
                    .HasPrecision(0)
                    .HasColumnName("Invoice Due Date");

                entity.Property(e => e.InvoiceTerms)
                    .HasMaxLength(255)
                    .HasColumnName("Invoice Terms");

                entity.Property(e => e.ToEmail)
                    .HasMaxLength(255)
                    .HasColumnName("To Email");

                entity.Property(e => e.ToPrint)
                    .HasMaxLength(255)
                    .HasColumnName("To Print");
            });

            modelBuilder.Entity<TblMonthMinConversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_MONTH_MIN_CONVERSION");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("BILLING CODE");

                entity.Property(e => e.BillingDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Description");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BillingUnitCount)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Unit Count");

                entity.Property(e => e.BillingUniteRate)
                    .HasColumnType("money")
                    .HasColumnName("Billing Unite Rate");

                entity.Property(e => e.BrokerCode)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Code");

                entity.Property(e => e.CobraPepmGreater).HasColumnName("COBRA PEPM Greater");

                entity.Property(e => e.EmployerBillingNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Billing Number");

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.FinalInvoiceAmount)
                    .HasColumnType("money")
                    .HasColumnName("FINAL INVOICE AMOUNT");

                entity.Property(e => e.KeyMmMonthlyMinimum)
                    .HasMaxLength(255)
                    .HasColumnName("Key_MM Monthly Minimum");

                entity.Property(e => e.MonthlyMinBillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("MONTHLY MIN BILLING CODE");

                entity.Property(e => e.MonthlyMinGreater).HasColumnName("Monthly Min Greater");

                entity.Property(e => e.MonthlyMinQualified)
                    .HasMaxLength(255)
                    .HasColumnName("Monthly Min Qualified");

                entity.Property(e => e.MonthlyMinimumAmount)
                    .HasColumnType("money")
                    .HasColumnName("MONTHLY MINIMUM AMOUNT");

                entity.Property(e => e.MonthlyMinimumFlg).HasColumnName("MONTHLY MINIMUM FLG");

                entity.Property(e => e.PaidByBrokerFlg).HasColumnName("PAID BY BROKER FLG");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Name");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.SystemEmployerCode)
                    .HasMaxLength(255)
                    .HasColumnName("System Employer Code");
            });

            modelBuilder.Entity<TblMonthMinConversionInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_MONTH_MIN_CONVERSION_INVOICE");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type");

                entity.Property(e => e.BilledAmountMonthlyMinDiff)
                    .HasColumnType("money")
                    .HasColumnName("Billed Amount-Monthly Min Diff");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("BILLING CODE");

                entity.Property(e => e.BillingDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Description");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BillingUnitCount)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Unit Count");

                entity.Property(e => e.BillingUniteRate)
                    .HasColumnType("money")
                    .HasColumnName("Billing Unite Rate");

                entity.Property(e => e.BrokerCode)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Code");

                entity.Property(e => e.EmployerBillingNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Billing Number");

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.FinalInvoiceAmount)
                    .HasColumnType("money")
                    .HasColumnName("FINAL INVOICE AMOUNT");

                entity.Property(e => e.KeyMmMonthlyMinimum)
                    .HasMaxLength(255)
                    .HasColumnName("Key_MM Monthly Minimum");

                entity.Property(e => e.MonthlyMinBillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("MONTHLY MIN BILLING CODE");

                entity.Property(e => e.MonthlyMinGreater).HasColumnName("Monthly Min Greater");

                entity.Property(e => e.MonthlyMinimumAmount)
                    .HasColumnType("money")
                    .HasColumnName("MONTHLY MINIMUM AMOUNT");

                entity.Property(e => e.MonthlyMinimumFlg).HasColumnName("MONTHLY MINIMUM FLG");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Name");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.SystemEmployerCode)
                    .HasMaxLength(255)
                    .HasColumnName("System Employer Code");
            });

            modelBuilder.Entity<TblProcess>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("{schema}_TBL_PROCESS_pk")
                    .IsClustered(false);

                entity.ToTable("TBL_PROCESS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type");

                entity.Property(e => e.AllowClaimsImport)
                    .HasMaxLength(255)
                    .HasColumnName("Allow Claims Import");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("BILLING CODE");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BndBillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("BND_BILLING CODE");

                entity.Property(e => e.BndBundleBillFlg).HasColumnName("BND_BUNDLE BILL FLG");

                entity.Property(e => e.BndBundleBillQual)
                    .HasMaxLength(255)
                    .HasColumnName("BND_BUNDLE BILL QUAL");

                entity.Property(e => e.BndBundleRateAmount)
                    .HasColumnType("money")
                    .HasColumnName("BND_BUNDLE RATE AMOUNT");

                entity.Property(e => e.BrokerCode)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Code");

                entity.Property(e => e.BrokerName)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Name");

                entity.Property(e => e.CobraLetterType)
                    .HasMaxLength(255)
                    .HasColumnName("COBRA_Letter Type");

                entity.Property(e => e.CobraNoticeBillAmount)
                    .HasColumnType("money")
                    .HasColumnName("COBRA_Notice Bill Amount");

                entity.Property(e => e.CobraNoticeCount).HasColumnName("COBRA_Notice Count");

                entity.Property(e => e.CobraPepmCount).HasColumnName("COBRA_PEPM Count");

                entity.Property(e => e.CobraPerNoticeAmount)
                    .HasColumnType("money")
                    .HasColumnName("COBRA_PER NOTICE AMOUNT");

                entity.Property(e => e.CobraPerNoticeFlg).HasColumnName("COBRA_PER NOTICE FLG");

                entity.Property(e => e.ContributionAmount)
                    .HasMaxLength(255)
                    .HasColumnName("Contribution Amount");

                entity.Property(e => e.CoverageTier)
                    .HasMaxLength(255)
                    .HasColumnName("Coverage Tier");

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.DivisionBillingKey)
                    .HasMaxLength(255)
                    .HasColumnName("Division Billing Key");

                entity.Property(e => e.EmployerBillingNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Billing Number");

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.EnrollmentAmount)
                    .HasMaxLength(255)
                    .HasColumnName("Enrollment Amount");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.FlatRateAmount)
                    .HasColumnType("money")
                    .HasColumnName("FLAT RATE AMOUNT");

                entity.Property(e => e.FlatRateFlg).HasColumnName("FLAT RATE FLG");

                entity.Property(e => e.GeneralBillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("GENERAL BILLING AMOUNT");

                entity.Property(e => e.GeneralBillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("GENERAL BILLING CODE");

                entity.Property(e => e.GeneralBillingCount).HasColumnName("GENERAL BILLING COUNT");

                entity.Property(e => e.GeneralBillingFlg).HasColumnName("GENERAL BILLING FLG");

                entity.Property(e => e.GeneralBillingRate)
                    .HasColumnType("money")
                    .HasColumnName("GENERAL BILLING RATE");

                entity.Property(e => e.GeneralKeyMm)
                    .HasMaxLength(255)
                    .HasColumnName("GENERAL KEY_MM");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Invoice Number");

                entity.Property(e => e.KeyMmMonthlyMinimum)
                    .HasMaxLength(255)
                    .HasColumnName("Key_MM Monthly Minimum");

                entity.Property(e => e.LastBilledDate)
                    .HasPrecision(0)
                    .HasColumnName("LAST BILLED DATE");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.MonthlyMinimumAmount)
                    .HasColumnType("money")
                    .HasColumnName("MONTHLY MINIMUM AMOUNT");

                entity.Property(e => e.MonthlyMinimumFlg).HasColumnName("MONTHLY MINIMUM FLG");

                entity.Property(e => e.OriginalEmployerName)
                    .HasMaxLength(254)
                    .HasColumnName("ORIGINAL EMPLOYER NAME");

                entity.Property(e => e.PaidByBrokerFlg).HasColumnName("PAID BY BROKER FLG");

                entity.Property(e => e.PaidByBrokerPercent).HasColumnName("PAID BY BROKER PERCENT");

                entity.Property(e => e.PaidByEmployerFlg).HasColumnName("PAID BY EMPLOYER FLG");

                entity.Property(e => e.PaidByEmployerPercent).HasColumnName("PAID BY EMPLOYER PERCENT");

                entity.Property(e => e.ParticipantId)
                    .HasMaxLength(255)
                    .HasColumnName("Participant ID");

                entity.Property(e => e.ParticipantStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Participant Status");

                entity.Property(e => e.ParticipantTermDate)
                    .HasPrecision(0)
                    .HasColumnName("Participant Term Date");

                entity.Property(e => e.PepmAmount)
                    .HasColumnType("money")
                    .HasColumnName("PEPM AMOUNT");

                entity.Property(e => e.PepmCount).HasColumnName("PEPM COUNT");

                entity.Property(e => e.PepmFlg).HasColumnName("PEPM FLG");

                entity.Property(e => e.PlanEndDate)
                    .HasPrecision(0)
                    .HasColumnName("Plan End Date");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Name");

                entity.Property(e => e.PlanStartDate)
                    .HasPrecision(0)
                    .HasColumnName("Plan Start Date");

                entity.Property(e => e.Process).HasMaxLength(255);

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.SystemEmployerCode)
                    .HasMaxLength(255)
                    .HasColumnName("System Employer Code");

                entity.Property(e => e.UniqueKeyAccount).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyBillingAccount).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyBundleBilling).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyParticipant).HasMaxLength(255);
            });

            modelBuilder.Entity<TblProcessBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_PROCESS_BK");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type");

                entity.Property(e => e.AllowClaimsImport)
                    .HasMaxLength(255)
                    .HasColumnName("Allow Claims Import");

                entity.Property(e => e.BackupInvoiceNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Backup Invoice Number");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("BILLING CODE");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.BillingGroupProcess)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Group Process");

                entity.Property(e => e.BndBillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("BND_BILLING CODE");

                entity.Property(e => e.BndBundleBillFlg).HasColumnName("BND_BUNDLE BILL FLG");

                entity.Property(e => e.BndBundleBillQual)
                    .HasMaxLength(255)
                    .HasColumnName("BND_BUNDLE BILL QUAL");

                entity.Property(e => e.BndBundleRateAmount)
                    .HasColumnType("money")
                    .HasColumnName("BND_BUNDLE RATE AMOUNT");

                entity.Property(e => e.BrokerCode)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Code");

                entity.Property(e => e.BrokerName)
                    .HasMaxLength(255)
                    .HasColumnName("Broker Name");

                entity.Property(e => e.CobraLetterType)
                    .HasMaxLength(255)
                    .HasColumnName("COBRA_Letter Type");

                entity.Property(e => e.CobraNoticeBillAmount)
                    .HasColumnType("money")
                    .HasColumnName("COBRA_Notice Bill Amount");

                entity.Property(e => e.CobraNoticeCount).HasColumnName("COBRA_Notice Count");

                entity.Property(e => e.CobraPepmCount).HasColumnName("COBRA_PEPM Count");

                entity.Property(e => e.CobraPerNoticeAmount)
                    .HasColumnType("money")
                    .HasColumnName("COBRA_PER NOTICE AMOUNT");

                entity.Property(e => e.CobraPerNoticeFlg).HasColumnName("COBRA_PER NOTICE FLG");

                entity.Property(e => e.ContributionAmount)
                    .HasMaxLength(255)
                    .HasColumnName("Contribution Amount");

                entity.Property(e => e.CoverageTier)
                    .HasMaxLength(255)
                    .HasColumnName("Coverage Tier");

                entity.Property(e => e.DeleteReason).HasMaxLength(500);

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.DivisionBillingKey)
                    .HasMaxLength(255)
                    .HasColumnName("Division Billing Key");

                entity.Property(e => e.EmployerBillingNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Billing Number");

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.EnrollmentAmount)
                    .HasMaxLength(255)
                    .HasColumnName("Enrollment Amount");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.FlatRateAmount)
                    .HasColumnType("money")
                    .HasColumnName("FLAT RATE AMOUNT");

                entity.Property(e => e.FlatRateFlg).HasColumnName("FLAT RATE FLG");

                entity.Property(e => e.GeneralBillingAmount)
                    .HasColumnType("money")
                    .HasColumnName("GENERAL BILLING AMOUNT");

                entity.Property(e => e.GeneralBillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("GENERAL BILLING CODE");

                entity.Property(e => e.GeneralBillingCount).HasColumnName("GENERAL BILLING COUNT");

                entity.Property(e => e.GeneralBillingFlg).HasColumnName("GENERAL BILLING FLG");

                entity.Property(e => e.GeneralBillingRate)
                    .HasColumnType("money")
                    .HasColumnName("GENERAL BILLING RATE");

                entity.Property(e => e.GeneralKeyMm)
                    .HasMaxLength(255)
                    .HasColumnName("GENERAL KEY_MM");

                entity.Property(e => e.KeyMmMonthlyMinimum)
                    .HasMaxLength(255)
                    .HasColumnName("Key_MM Monthly Minimum");

                entity.Property(e => e.LastBilledDate)
                    .HasPrecision(0)
                    .HasColumnName("LAST BILLED DATE");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.MonthlyMinimumAmount)
                    .HasColumnType("money")
                    .HasColumnName("MONTHLY MINIMUM AMOUNT");

                entity.Property(e => e.MonthlyMinimumFlg).HasColumnName("MONTHLY MINIMUM FLG");

                entity.Property(e => e.OriginalEmployerName)
                    .HasMaxLength(254)
                    .HasColumnName("ORIGINAL EMPLOYER NAME");

                entity.Property(e => e.PaidByBrokerFlg).HasColumnName("PAID BY BROKER FLG");

                entity.Property(e => e.PaidByBrokerPercent).HasColumnName("PAID BY BROKER PERCENT");

                entity.Property(e => e.PaidByEmployerFlg).HasColumnName("PAID BY EMPLOYER FLG");

                entity.Property(e => e.PaidByEmployerPercent).HasColumnName("PAID BY EMPLOYER PERCENT");

                entity.Property(e => e.ParticipantId)
                    .HasMaxLength(255)
                    .HasColumnName("Participant ID");

                entity.Property(e => e.ParticipantStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Participant Status");

                entity.Property(e => e.ParticipantTermDate)
                    .HasPrecision(0)
                    .HasColumnName("Participant Term Date");

                entity.Property(e => e.PepmAmount)
                    .HasColumnType("money")
                    .HasColumnName("PEPM AMOUNT");

                entity.Property(e => e.PepmCount).HasColumnName("PEPM COUNT");

                entity.Property(e => e.PepmFlg).HasColumnName("PEPM FLG");

                entity.Property(e => e.PlanEndDate)
                    .HasPrecision(0)
                    .HasColumnName("Plan End Date");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Name");

                entity.Property(e => e.PlanStartDate)
                    .HasPrecision(0)
                    .HasColumnName("Plan Start Date");

                entity.Property(e => e.Process).HasMaxLength(255);

                entity.Property(e => e.QbBillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("QB Billing Code");

                entity.Property(e => e.QbBillingCodeDescription)
                    .HasMaxLength(255)
                    .HasColumnName("QB Billing Code Description");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();

                entity.Property(e => e.SystemEmployerCode)
                    .HasMaxLength(255)
                    .HasColumnName("System Employer Code");

                entity.Property(e => e.UniqueKeyAccount).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyBillingAccount).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyBundleBilling).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyParticipant).HasMaxLength(255);
            });
            modelBuilder.Entity<TblLogging>(entity =>
            {
                entity.ToTable("TBL_LOGGINGDB");
                entity.HasKey("Id");
                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.PackageName)
                    .HasColumnName("PackageName");

                entity.Property(e => e.PackageId)
                    .HasColumnName("PackageId");

                entity.Property(e => e.Guid)
                    .HasColumnName("Guid");

                entity.Property(e => e.MachineName)
                    .HasColumnName("MachineName");

                entity.Property(e => e.UserName)
                    .HasColumnName("UserName");

                entity.Property(e => e.DataSource)
                    .HasColumnName("DataSource");

                entity.Property(e => e.StartDateTime)
                    .HasColumnName("StartDateTime");

                entity.Property(e => e.EndDateTime)
                    .HasColumnName("EndDateTime");

                entity.Property(e => e.NumRowsInserted)
                    .HasColumnName("NumRowsInserted");

                entity.Property(e => e.NumRowsUpdated)
                    .HasColumnName("NumRowsUpdated");

                entity.Property(e => e.NumRowsDeleted)
                    .HasColumnName("NumRowsDeleted");

                entity.Property(e => e.NumRowsTotal)
                    .HasColumnName("NumRowsTotal");

                entity.Property(e => e.IsSuccess)
                    .HasColumnName("IsSuccess");

                entity.Property(e => e.IsFailed)
                    .HasColumnName("IsFailed");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("IsCompleted");


            });

            modelBuilder.Entity<TblQbImportsPro>(entity =>
            {
                entity.ToTable("TBL_QB_IMPORTS_PRO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BILLING CODE");

                entity.Property(e => e.BillingDescription)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("Billing Description");

                entity.Property(e => e.BillingGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Billing Group");

                entity.Property(e => e.Division)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("division");

                entity.Property(e => e.EmployerKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employer Key");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("First Name");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Invoice Number");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Last Name");

                entity.Property(e => e.OriginalEmployerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORIGINAL EMPLOYER NAME");

                entity.Property(e => e.ParticipantStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Participant Status");

                entity.Property(e => e.ParticipantTermDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Participant Term Date");

                entity.Property(e => e.PepmAmount)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("pepm_amount");

                entity.Property(e => e.PepmCount).HasColumnName("pepm_count");
            });

            modelBuilder.Entity<TblQbTeCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_QB_TE_COUNT");

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TeCount).HasColumnName("TE  Count");
            });

            modelBuilder.Entity<TblStagingAccount>(entity =>
            {
                entity.ToTable("TBL_STAGING_ACCOUNTS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Account Status");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type");

                entity.Property(e => e.AutoClaimsPayFlg).HasColumnName("Auto Claims Pay flg");

                entity.Property(e => e.DivisionBillingKey)
                    .HasMaxLength(255)
                    .HasColumnName("Division Billing Key");

                entity.Property(e => e.DivisionIbRecords)
                    .HasMaxLength(255)
                    .HasColumnName("Division IB Records");

                entity.Property(e => e.EcAccountType)
                    .HasMaxLength(255)
                    .HasColumnName("EC Account Type");

                entity.Property(e => e.EffectiveDateDt)
                    .HasPrecision(0)
                    .HasColumnName("Effective Date dt");

                entity.Property(e => e.EffectiveDateTxt)
                    .HasMaxLength(255)
                    .HasColumnName("Effective Date txt");

                entity.Property(e => e.EmployeeNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Number");

                entity.Property(e => e.EmployerAnnualElection)
                    .HasColumnType("money")
                    .HasColumnName("Employer Annual Election");

                entity.Property(e => e.EmployerCode)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Code");

                entity.Property(e => e.EmployerPayPeriodElection)
                    .HasColumnType("money")
                    .HasColumnName("Employer Pay Period Election");

                entity.Property(e => e.FutureEnrollmentExclude)
                    .HasMaxLength(255)
                    .HasColumnName("Future Enrollment Exclude");

                entity.Property(e => e.OriginalPrefundedAnnualElectionAmount)
                    .HasColumnType("money")
                    .HasColumnName("Original Prefunded/Annual Election Amount");

                entity.Property(e => e.ParticipantAnnualElection)
                    .HasColumnType("money")
                    .HasColumnName("Participant Annual Election");

                entity.Property(e => e.ParticipantFirstName)
                    .HasMaxLength(255)
                    .HasColumnName("Participant First Name");

                entity.Property(e => e.ParticipantLastName)
                    .HasMaxLength(255)
                    .HasColumnName("Participant Last Name");

                entity.Property(e => e.ParticipantPayPeriodElection)
                    .HasColumnType("money")
                    .HasColumnName("Participant Pay Period Election");

                entity.Property(e => e.ParticipantSsn)
                    .HasMaxLength(255)
                    .HasColumnName("Participant SSN");

                entity.Property(e => e.ParticipantStatus)
                    .HasMaxLength(255)
                    .HasColumnName("Participant Status");

                entity.Property(e => e.ParticipantTermDateTxt)
                    .HasMaxLength(255)
                    .HasColumnName("Participant Term Date txt");

                entity.Property(e => e.PlanEndDateDt)
                    .HasPrecision(0)
                    .HasColumnName("Plan End Date dt");

                entity.Property(e => e.PlanEndDateTxt)
                    .HasMaxLength(255)
                    .HasColumnName("Plan End Date txt");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Name");

                entity.Property(e => e.PlanStartDateDt)
                    .HasPrecision(0)
                    .HasColumnName("Plan Start Date dt");

                entity.Property(e => e.PlanStartDateTxt)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Start Date txt");

                entity.Property(e => e.PlanTermRunout).HasColumnName("Plan Term Runout");

                entity.Property(e => e.ProductPartnerStatus).HasMaxLength(255);

                entity.Property(e => e.RecordType).HasMaxLength(255);

                entity.Property(e => e.TermBillableAccounts)
                    .HasMaxLength(255)
                    .HasColumnName("Term Billable accounts");

                entity.Property(e => e.TermDatePlusRunout)
                    .HasPrecision(0)
                    .HasColumnName("Term date plus Runout");

                entity.Property(e => e.TerminationDateDt)
                    .HasPrecision(0)
                    .HasColumnName("Termination Date dt");

                entity.Property(e => e.TerminationDateTxt)
                    .HasMaxLength(255)
                    .HasColumnName("Termination Date txt");

                entity.Property(e => e.TpaId)
                    .HasMaxLength(255)
                    .HasColumnName("Tpa Id");

                entity.Property(e => e.UniqueKeyParticipant).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyParticipantAccounts).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingAccountTypeConversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_ACCOUNT_TYPE_CONVERSION");

                entity.Property(e => e.AccountTypeCode)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type Code");

                entity.Property(e => e.BillingAccountTypeCode)
                    .HasMaxLength(255)
                    .HasColumnName("Billing Account Type Code");
            });

            modelBuilder.Entity<TblStagingBenefitSummaryRpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_BENEFIT_SUMMARY_RPT");

                entity.Property(e => e.Cnt).HasColumnName("cnt");

                entity.Property(e => e.EmprId)
                    .HasMaxLength(255)
                    .HasColumnName("empr_id");

                entity.Property(e => e.EmprName)
                    .HasMaxLength(255)
                    .HasColumnName("empr_name");

                entity.Property(e => e.Label)
                    .HasMaxLength(255)
                    .HasColumnName("label");

                entity.Property(e => e.Label2)
                    .HasMaxLength(255)
                    .HasColumnName("label2");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(255)
                    .HasColumnName("plan_id");

                entity.Property(e => e.TpaId)
                    .HasMaxLength(255)
                    .HasColumnName("tpa_id");
            });

            modelBuilder.Entity<TblStagingBrokerclientlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_BROKERCLIENTLIST");

                entity.Property(e => e.Active).HasMaxLength(255);

                entity.Property(e => e.BillingStartDate).HasMaxLength(255);

                entity.Property(e => e.BrokerId)
                    .HasMaxLength(255)
                    .HasColumnName("BrokerID");

                entity.Property(e => e.BrokerName).HasMaxLength(255);

                entity.Property(e => e.ClientAlternate).HasMaxLength(255);

                entity.Property(e => e.ClientDivisionId)
                    .HasMaxLength(255)
                    .HasColumnName("ClientDivisionID");

                entity.Property(e => e.ClientDivisionName).HasMaxLength(255);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("ClientID");

                entity.Property(e => e.ClientName).HasMaxLength(1000);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.Ein)
                    .HasMaxLength(255)
                    .HasColumnName("EIN");
            });

            modelBuilder.Entity<TblStagingBswiftBillingnumImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_BSWIFT_BILLINGNUM_IMPORT");

                entity.Property(e => e.BenefitClassBenefitEligible)
                    .HasMaxLength(255)
                    .HasColumnName("Benefit Class Benefit Eligible");

                entity.Property(e => e.BenefitClassName)
                    .HasMaxLength(255)
                    .HasColumnName("Benefit Class Name");

                entity.Property(e => e.ClientEffectiveDate)
                    .HasPrecision(0)
                    .HasColumnName("Client Effective Date");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .HasColumnName("Client Name");

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("Employee ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Group Number");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.ParticipantUniqueKey).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingClientsMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_CLIENTS_MASTER");

                entity.Property(e => e.Active).HasMaxLength(255);

                entity.Property(e => e.BillingStartDate).HasMaxLength(255);

                entity.Property(e => e.ClientAlternate).HasMaxLength(255);

                entity.Property(e => e.ClientDivisionId)
                    .HasMaxLength(255)
                    .HasColumnName("ClientDivisionID");

                entity.Property(e => e.ClientDivisionName).HasMaxLength(255);

                entity.Property(e => e.ClientGroupName).HasMaxLength(255);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("ClientID");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeactivationDate).HasMaxLength(255);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.Ein)
                    .HasMaxLength(255)
                    .HasColumnName("EIN");
            });

            modelBuilder.Entity<TblStagingCobraClientList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_COBRA_CLIENT_LIST");

                entity.Property(e => e.Active).HasMaxLength(255);

                entity.Property(e => e.BillingStartDate).HasMaxLength(255);

                entity.Property(e => e.ClientAlternate).HasMaxLength(255);

                entity.Property(e => e.ClientDivisionId)
                    .HasMaxLength(255)
                    .HasColumnName("ClientDivisionID");

                entity.Property(e => e.ClientDivisionName).HasMaxLength(255);

                entity.Property(e => e.ClientGroupName).HasMaxLength(255);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(255)
                    .HasColumnName("ClientID");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.DeactivationDate).HasMaxLength(255);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.Ein)
                    .HasMaxLength(255)
                    .HasColumnName("EIN");
            });

            modelBuilder.Entity<TblStagingCobraLetter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_COBRA_LETTERS");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.ModeName).HasMaxLength(255);

                entity.Property(e => e.ModeOrder).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingCobraLettersSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_COBRA_LETTERS_SUMMARY");

                entity.Property(e => e.ClientCode).HasMaxLength(255);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.ModeName).HasMaxLength(255);

                entity.Property(e => e.ModeOrder).HasMaxLength(255);

                entity.Property(e => e.Qty).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingEbExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EB_EXTRACT");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(255)
                    .HasColumnName("Address Line 1");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .HasColumnName("Address Line 2");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("Employee ID");

                entity.Property(e => e.EmployeeSocialSecurityNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Social Security Number");

                entity.Property(e => e.EmployeeStatus).HasColumnName("Employee Status");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(255)
                    .HasColumnName("Record Type");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.TerminationDate)
                    .HasMaxLength(255)
                    .HasColumnName("Termination Date");

                entity.Property(e => e.TpaId)
                    .HasMaxLength(255)
                    .HasColumnName("Tpa Id");

                entity.Property(e => e.UserDefinedField)
                    .HasMaxLength(255)
                    .HasColumnName("User Defined Field");

                entity.Property(e => e.Zip).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingEcExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EC_EXTRACT");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(10)
                    .HasColumnName("Account Status");

                entity.Property(e => e.AccountTypeCode)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type Code");

                entity.Property(e => e.AutoDepositCalendarId)
                    .HasMaxLength(255)
                    .HasColumnName("Auto Deposit Calendar ID");

                entity.Property(e => e.AutoReimbursementSetting)
                    .HasMaxLength(255)
                    .HasColumnName("Auto Reimbursement Setting");

                entity.Property(e => e.AvailableBalance)
                    .HasMaxLength(255)
                    .HasColumnName("Available Balance");

                entity.Property(e => e.BillableAccount)
                    .HasMaxLength(255)
                    .HasColumnName("Billable Account");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Card Number");

                entity.Property(e => e.CoverageTierId)
                    .HasMaxLength(255)
                    .HasColumnName("Coverage Tier Id");

                entity.Property(e => e.CurrentAnnualElection)
                    .HasMaxLength(15)
                    .HasColumnName("Current Annual Election");

                entity.Property(e => e.DependentId)
                    .HasMaxLength(255)
                    .HasColumnName("Dependent ID");

                entity.Property(e => e.DisbursableBalance)
                    .HasMaxLength(255)
                    .HasColumnName("Disbursable Balance");

                entity.Property(e => e.DisbursementsPtd)
                    .HasMaxLength(255)
                    .HasColumnName("Disbursements PTD");

                entity.Property(e => e.EbTermDate)
                    .HasMaxLength(255)
                    .HasColumnName("EB Term Date");

                entity.Property(e => e.EbTermStatus)
                    .HasMaxLength(255)
                    .HasColumnName("EB Term Status");

                entity.Property(e => e.EffectiveDate)
                    .HasMaxLength(255)
                    .HasColumnName("Effective Date");

                entity.Property(e => e.EmployeeAddress1)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Address 1");

                entity.Property(e => e.EmployeeAddress2)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Address 2");

                entity.Property(e => e.EmployeeAnnualElection)
                    .HasMaxLength(15)
                    .HasColumnName("Employee Annual Election");

                entity.Property(e => e.EmployeeBirthDate)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Birth Date");

                entity.Property(e => e.EmployeeCity)
                    .HasMaxLength(255)
                    .HasColumnName("Employee City");

                entity.Property(e => e.EmployeeContributionYtd)
                    .HasMaxLength(15)
                    .HasColumnName("Employee Contribution YTD");

                entity.Property(e => e.EmployeeEmailAddress)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Email Address");

                entity.Property(e => e.EmployeeFirstName)
                    .HasMaxLength(255)
                    .HasColumnName("Employee First Name");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("Employee ID");

                entity.Property(e => e.EmployeeLastName)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Last Name");

                entity.Property(e => e.EmployeePayPeriodElection)
                    .HasMaxLength(15)
                    .HasColumnName("Employee Pay Period Election");

                entity.Property(e => e.EmployeePhone)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Phone");

                entity.Property(e => e.EmployeeSocialSecurityNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Social Security Number");

                entity.Property(e => e.EmployeeState)
                    .HasMaxLength(255)
                    .HasColumnName("Employee State");

                entity.Property(e => e.EmployeeStatus)
                    .HasMaxLength(10)
                    .HasColumnName("Employee Status");

                entity.Property(e => e.EmployeeZip)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Zip");

                entity.Property(e => e.EmployerAnnualElection)
                    .HasMaxLength(15)
                    .HasColumnName("Employer Annual Election");

                entity.Property(e => e.EmployerContributionYtd)
                    .HasMaxLength(15)
                    .HasColumnName("Employer Contribution YTD");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Id");

                entity.Property(e => e.EmployerPayPeriodElection)
                    .HasMaxLength(15)
                    .HasColumnName("Employer Pay Period Election");

                entity.Property(e => e.IndividualAmount)
                    .HasMaxLength(15)
                    .HasColumnName("Individual Amount");

                entity.Property(e => e.OriginalPrefundedAnnualElectionAmount)
                    .HasMaxLength(15)
                    .HasColumnName("Original Prefunded/Annual Election Amount");

                entity.Property(e => e.OtherDeposits)
                    .HasMaxLength(255)
                    .HasColumnName("Other Deposits");

                entity.Property(e => e.PlanEndDate)
                    .HasMaxLength(255)
                    .HasColumnName("Plan End Date");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Id");

                entity.Property(e => e.PlanStartDate)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Start Date");

                entity.Property(e => e.ProductPartnerAcctCloseDate).HasMaxLength(255);

                entity.Property(e => e.ProductPartnerAcctStatus).HasMaxLength(255);

                entity.Property(e => e.RecordType).HasMaxLength(255);

                entity.Property(e => e.StartAutoDepositDate)
                    .HasMaxLength(255)
                    .HasColumnName("Start Auto Deposit Date");

                entity.Property(e => e.TerminationDate)
                    .HasMaxLength(255)
                    .HasColumnName("Termination Date");

                entity.Property(e => e.TpaId)
                    .HasMaxLength(255)
                    .HasColumnName("Tpa Id");

                entity.Property(e => e.UniqueKeyAccounts).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyPerpay).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingEdi2SourceDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EDI_2_SOURCE_DATA");

                entity.Property(e => e.BenefitClassBenefitEligible)
                    .HasMaxLength(255)
                    .HasColumnName("Benefit Class Benefit Eligible");

                entity.Property(e => e.BenefitClassName)
                    .HasMaxLength(255)
                    .HasColumnName("Benefit Class Name");

                entity.Property(e => e.ClientEffectiveDate)
                    .HasPrecision(0)
                    .HasColumnName("Client Effective Date");

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .HasColumnName("Client Name");

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("Employee ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Group Number");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.ParticipantUniqueKey).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingEdi3SourceDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EDI_3_SOURCE_DATA");

                entity.Property(e => e.Bencode)
                    .HasMaxLength(255)
                    .HasColumnName("BENCODE");

                entity.Property(e => e.Client).HasMaxLength(255);

                entity.Property(e => e.ErControlBillingCode)
                    .HasMaxLength(255)
                    .HasColumnName("ER Control Billing Code");

                entity.Property(e => e.NewQty).HasColumnName("new_qty");

                entity.Property(e => e.NpmCount)
                    .HasMaxLength(255)
                    .HasColumnName("NPM Count");

                entity.Property(e => e.OldQty).HasColumnName("old_qty");

                entity.Property(e => e.OriginalCalcultated).HasColumnName("original Calcultated");

                entity.Property(e => e.PriorBilledNumber).HasColumnName("Prior Billed Number");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TeCount)
                    .HasMaxLength(255)
                    .HasColumnName("TE Count");

                entity.Property(e => e.TpCount)
                    .HasMaxLength(255)
                    .HasColumnName("TP Count");
            });

            modelBuilder.Entity<TblStagingEdi4DebitCardSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EDI_4_DEBIT_CARD_SUMMARY");

                entity.Property(e => e.AdminId)
                    .HasMaxLength(255)
                    .HasColumnName("Admin ID");

                entity.Property(e => e.AdminName)
                    .HasMaxLength(255)
                    .HasColumnName("Admin Name");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Id");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.Filler1).HasMaxLength(255);

                entity.Property(e => e.Filler2).HasMaxLength(255);

                entity.Property(e => e.Filler3).HasMaxLength(255);

                entity.Property(e => e.Filler4).HasMaxLength(255);

                entity.Property(e => e.Filler5).HasMaxLength(255);

                entity.Property(e => e.Filler6).HasMaxLength(255);

                entity.Property(e => e.Filler7).HasMaxLength(255);

                entity.Property(e => e.Filler8).HasMaxLength(255);

                entity.Property(e => e.Filler9).HasMaxLength(255);

                entity.Property(e => e.NewCardCount).HasColumnName("New Card Count");

                entity.Property(e => e.ReplacementCardCount).HasColumnName("Replacement Card Count");

                entity.Property(e => e.TotalCardsCount).HasColumnName("Total Cards Count");
            });

            modelBuilder.Entity<TblStagingEdi4SourceDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EDI_4_SOURCE_DATA");

                entity.Property(e => e.ActivationDate)
                    .HasMaxLength(255)
                    .HasColumnName("Activation Date");

                entity.Property(e => e.CardEffectiveDate)
                    .HasMaxLength(255)
                    .HasColumnName("Card Effective Date");

                entity.Property(e => e.CardExpireDate)
                    .HasMaxLength(255)
                    .HasColumnName("Card Expire Date");

                entity.Property(e => e.CreateDateDate)
                    .HasPrecision(0)
                    .HasColumnName("Create Date Date");

                entity.Property(e => e.CreationDate)
                    .HasMaxLength(255)
                    .HasColumnName("Creation Date");

                entity.Property(e => e.DependentId)
                    .HasMaxLength(255)
                    .HasColumnName("Dependent Id");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Id");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Id");

                entity.Property(e => e.IssueDate)
                    .HasMaxLength(255)
                    .HasColumnName("Issue Date");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(255)
                    .HasColumnName("Issued By");

                entity.Property(e => e.LastUpdated)
                    .HasMaxLength(255)
                    .HasColumnName("Last Updated");

                entity.Property(e => e.MailedDate)
                    .HasMaxLength(255)
                    .HasColumnName("Mailed Date");

                entity.Property(e => e.PrimaryCard)
                    .HasMaxLength(255)
                    .HasColumnName("Primary Card");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(255)
                    .HasColumnName("Record Type");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(255)
                    .HasColumnName("Status Code");

                entity.Property(e => e.StatusCodeReason)
                    .HasMaxLength(255)
                    .HasColumnName("Status Code Reason");
            });

            modelBuilder.Entity<TblStagingEdi5PlanDocReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EDI_5_PLAN_DOC_REPORT");

                entity.Property(e => e.AccountTypeCode)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type Code");

                entity.Property(e => e.AccountUniqueKey).HasMaxLength(255);

                entity.Property(e => e.Bencode).HasMaxLength(255);

                entity.Property(e => e.BillableRunout)
                    .HasMaxLength(255)
                    .HasColumnName("Billable Runout");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.GraceRoll)
                    .HasMaxLength(255)
                    .HasColumnName("Grace_Roll");

                entity.Property(e => e.LineType)
                    .HasMaxLength(255)
                    .HasColumnName("Line type");

                entity.Property(e => e.PlanEndDate)
                    .HasMaxLength(255)
                    .HasColumnName("Plan End Date");

                entity.Property(e => e.PlanEndDateDt)
                    .HasPrecision(0)
                    .HasColumnName("Plan End Date dt");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(255)
                    .HasColumnName("Plan ID");

                entity.Property(e => e.PlanMax)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Max");

                entity.Property(e => e.PlanMin)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Min");

                entity.Property(e => e.PyStartDate)
                    .HasMaxLength(255)
                    .HasColumnName("PY Start Date");

                entity.Property(e => e.RunoutDate)
                    .HasMaxLength(255)
                    .HasColumnName("Runout Date");

                entity.Property(e => e.RunoutDateDt)
                    .HasPrecision(0)
                    .HasColumnName("Runout Date dt");

                entity.Property(e => e.RunoutDateNumber).HasColumnName("Runout Date Number");

                entity.Property(e => e.TermRunoutDate)
                    .HasMaxLength(255)
                    .HasColumnName("Term Runout Date");

                entity.Property(e => e.TermRunoutDateNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Term Runout Date Number");

                entity.Property(e => e.TpaCode)
                    .HasMaxLength(255)
                    .HasColumnName("TPA Code");
            });

            modelBuilder.Entity<TblStagingEdi5PlanDocReportPrior>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EDI_5_PLAN_DOC_REPORT_PRIOR");

                entity.Property(e => e.AccountTypeCode)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type Code");

                entity.Property(e => e.AccountUniqueKey).HasMaxLength(255);

                entity.Property(e => e.Bencode).HasMaxLength(255);

                entity.Property(e => e.BillableRunout)
                    .HasMaxLength(255)
                    .HasColumnName("Billable Runout");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.GraceRoll)
                    .HasMaxLength(255)
                    .HasColumnName("Grace_Roll");

                entity.Property(e => e.LineType)
                    .HasMaxLength(255)
                    .HasColumnName("Line type");

                entity.Property(e => e.PlanEndDate)
                    .HasMaxLength(255)
                    .HasColumnName("Plan End Date");

                entity.Property(e => e.PlanEndDateDt)
                    .HasPrecision(0)
                    .HasColumnName("Plan End Date dt");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(255)
                    .HasColumnName("Plan ID");

                entity.Property(e => e.PlanMax)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Max");

                entity.Property(e => e.PlanMin)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Min");

                entity.Property(e => e.PyStartDate)
                    .HasMaxLength(255)
                    .HasColumnName("PY Start Date");

                entity.Property(e => e.RunoutDate)
                    .HasMaxLength(255)
                    .HasColumnName("Runout Date");

                entity.Property(e => e.RunoutDateDt)
                    .HasPrecision(0)
                    .HasColumnName("Runout Date dt");

                entity.Property(e => e.RunoutDateNumber).HasColumnName("Runout Date Number");

                entity.Property(e => e.TermRunoutDate)
                    .HasMaxLength(255)
                    .HasColumnName("Term Runout Date");

                entity.Property(e => e.TermRunoutDateNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Term Runout Date Number");

                entity.Property(e => e.TpaCode)
                    .HasMaxLength(255)
                    .HasColumnName("TPA Code");
            });

            modelBuilder.Entity<TblStagingEdi6SourceDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EDI_6_SOURCE_DATA");

                entity.Property(e => e.ActiveEmployees).HasColumnName("Active Employees");

                entity.Property(e => e.CobraEmployees).HasColumnName("COBRA Employees");

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.EligibleEmployees).HasColumnName("Eligible Employees");

                entity.Property(e => e.EnrolledEmployees).HasColumnName("Enrolled Employees");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TotalEmployees).HasColumnName("Total Employees");
            });

            modelBuilder.Entity<TblStagingEmployeeNavImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_EMPLOYEE_NAV_IMPORT");

                entity.Property(e => e.ActiveEmployees).HasColumnName("Active Employees");

                entity.Property(e => e.CobraEmployees).HasColumnName("COBRA Employees");

                entity.Property(e => e.Company).HasMaxLength(255);

                entity.Property(e => e.EligibleEmployees).HasColumnName("Eligible Employees");

                entity.Property(e => e.EnrolledEmployees).HasColumnName("Enrolled Employees");

                entity.Property(e => e.SsmaTimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("SSMA_TimeStamp");

                entity.Property(e => e.TotalEmployees).HasColumnName("Total Employees");
            });

            modelBuilder.Entity<TblStagingFinalEdiBillingGroupCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_FINAL_EDI_BILLING_GROUP_COUNT");

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.FinalBillableCounts).HasColumnName("Final Billable Counts");

                entity.Property(e => e.NpmCount).HasColumnName("NPM Count");

                entity.Property(e => e.Suppress).HasMaxLength(255);

                entity.Property(e => e.TeCount).HasColumnName("TE Count");

                entity.Property(e => e.TpCount).HasColumnName("TP Count");
            });

            modelBuilder.Entity<TblStagingNpm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_NPM");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CoverageLevel).HasMaxLength(255);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Include)
                    .HasMaxLength(255)
                    .HasColumnName("include");

                entity.Property(e => e.IndividualIdentifier).HasMaxLength(255);

                entity.Property(e => e.IsPaylocity)
                    .HasMaxLength(255)
                    .HasColumnName("Is Paylocity");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(255)
                    .HasColumnName("MemberID");

                entity.Property(e => e.PdfgeneratedDateTime).HasColumnName("PDFGeneratedDateTime");

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(255)
                    .HasColumnName("SSN");

                entity.Property(e => e.StateOrProvince).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingNpmDist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_NPM_DIST");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CoverageLevel).HasMaxLength(255);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.Include)
                    .HasMaxLength(255)
                    .HasColumnName("include");

                entity.Property(e => e.IndividualIdentifier).HasMaxLength(255);

                entity.Property(e => e.IsPaylocity)
                    .HasMaxLength(255)
                    .HasColumnName("Is Paylocity");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(255)
                    .HasColumnName("MemberID");

                entity.Property(e => e.NpmUniqueKey)
                    .HasMaxLength(255)
                    .HasColumnName("NPM UniqueKey");

                entity.Property(e => e.PdfgeneratedDateTime)
                    .HasMaxLength(255)
                    .HasColumnName("PDFGeneratedDateTime");

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(255)
                    .HasColumnName("SSN");

                entity.Property(e => e.StateOrProvince).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingNpnCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_NPN_COUNT");

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.CountOfSsn).HasColumnName("CountOfSSN");
            });

            modelBuilder.Entity<TblStagingQbTpCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_QB_TP_COUNT");

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.CountOfSsn).HasColumnName("CountOfSSN");

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingQbdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_QBDETAIL");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.CarrierName).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CoverageLevelType).HasMaxLength(255);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.Ein)
                    .HasMaxLength(255)
                    .HasColumnName("EIN");

                entity.Property(e => e.EmployeeType).HasMaxLength(255);

                entity.Property(e => e.EventCategory).HasMaxLength(255);

                entity.Property(e => e.EventType).HasMaxLength(255);

                entity.Property(e => e.FirstDayOfCobra).HasColumnName("FirstDayOfCOBRA");

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.IndividualIdentifier).HasMaxLength(255);

                entity.Property(e => e.InsuranceType).HasMaxLength(255);

                entity.Property(e => e.IsDependent).HasMaxLength(255);

                entity.Property(e => e.LastDayOfCobra).HasColumnName("LastDayOfCOBRA");

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(255)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MiddleInitial).HasMaxLength(255);

                entity.Property(e => e.PlanName).HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.RelationShipName).HasMaxLength(255);

                entity.Property(e => e.SpecificRightsProcessedDate).HasMaxLength(255);

                entity.Property(e => e.Ssn)
                    .HasMaxLength(255)
                    .HasColumnName("SSN");

                entity.Property(e => e.StateOrProvince).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TobaccoUse).HasMaxLength(255);

                entity.Property(e => e.UsesHealthCoverageTaxCredit).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingSpmbyacareport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_SPMBYACAREPORT");

                entity.Property(e => e.AccountTypeCode)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type Code");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.BillingTypeName).HasMaxLength(255);

                entity.Property(e => e.CarrierName).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.ClientAlternate).HasMaxLength(255);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.CoverageLevelType).HasMaxLength(255);

                entity.Property(e => e.DivisionName).HasMaxLength(255);

                entity.Property(e => e.Dob).HasColumnName("DOB");

                entity.Property(e => e.Ein)
                    .HasMaxLength(255)
                    .HasColumnName("EIN");

                entity.Property(e => e.EmployeeType).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.IndividualIdentifier).HasMaxLength(255);

                entity.Property(e => e.InsuranceType).HasMaxLength(255);

                entity.Property(e => e.IsDependent).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.MemberId)
                    .HasMaxLength(255)
                    .HasColumnName("MemberID");

                entity.Property(e => e.MiddleInitial).HasMaxLength(255);

                entity.Property(e => e.PlanName).HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(255);

                entity.Property(e => e.RelationShipName).HasMaxLength(255);

                entity.Property(e => e.SpminsuranceTypePlanId)
                    .HasMaxLength(255)
                    .HasColumnName("SPMInsuranceTypePlanID");

                entity.Property(e => e.Ssn)
                    .HasMaxLength(255)
                    .HasColumnName("SSN");

                entity.Property(e => e.StateOrProvince).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TobaccoUse).HasMaxLength(255);

                entity.Property(e => e.UniqueKey).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStagingSpmbyacareportDist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STAGING_SPMBYACAREPORT_DIST");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type");

                entity.Property(e => e.ClientAlternate).HasMaxLength(255);

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(255)
                    .HasColumnName("MemberID");

                entity.Property(e => e.UniqueKey).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStatingEbExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STATING_EB_EXTRACT");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(255)
                    .HasColumnName("Address Line 1");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .HasColumnName("Address Line 2");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Division).HasMaxLength(255);

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("Employee ID");

                entity.Property(e => e.EmployeeSocialSecurityNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Social Security Number");

                entity.Property(e => e.EmployeeStatus).HasColumnName("Employee Status");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Id");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("First Name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("Last Name");

                entity.Property(e => e.RecordType)
                    .HasMaxLength(255)
                    .HasColumnName("Record Type");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.TerminationDate)
                    .HasMaxLength(255)
                    .HasColumnName("Termination Date");

                entity.Property(e => e.TpaId)
                    .HasMaxLength(255)
                    .HasColumnName("Tpa Id");

                entity.Property(e => e.UserDefinedField)
                    .HasMaxLength(255)
                    .HasColumnName("User Defined Field");

                entity.Property(e => e.Zip).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStatingEcExtract>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STATING_EC_EXTRACT");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(10)
                    .HasColumnName("Account Status");

                entity.Property(e => e.AccountTypeCode)
                    .HasMaxLength(255)
                    .HasColumnName("Account Type Code");

                entity.Property(e => e.AutoDepositCalendarId)
                    .HasMaxLength(255)
                    .HasColumnName("Auto Deposit Calendar ID");

                entity.Property(e => e.AutoReimbursementSetting)
                    .HasMaxLength(255)
                    .HasColumnName("Auto Reimbursement Setting");

                entity.Property(e => e.AvailableBalance)
                    .HasMaxLength(255)
                    .HasColumnName("Available Balance");

                entity.Property(e => e.BillableAccount)
                    .HasMaxLength(255)
                    .HasColumnName("Billable Account");

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Card Number");

                entity.Property(e => e.CoverageTierId)
                    .HasMaxLength(255)
                    .HasColumnName("Coverage Tier Id");

                entity.Property(e => e.CurrentAnnualElection)
                    .HasMaxLength(15)
                    .HasColumnName("Current Annual Election");

                entity.Property(e => e.DependentId)
                    .HasMaxLength(255)
                    .HasColumnName("Dependent ID");

                entity.Property(e => e.DisbursableBalance)
                    .HasMaxLength(255)
                    .HasColumnName("Disbursable Balance");

                entity.Property(e => e.DisbursementsPtd)
                    .HasMaxLength(255)
                    .HasColumnName("Disbursements PTD");

                entity.Property(e => e.EbTermDate)
                    .HasMaxLength(255)
                    .HasColumnName("EB Term Date");

                entity.Property(e => e.EbTermStatus)
                    .HasMaxLength(255)
                    .HasColumnName("EB Term Status");

                entity.Property(e => e.EffectiveDate)
                    .HasMaxLength(255)
                    .HasColumnName("Effective Date");

                entity.Property(e => e.EmployeeAddress1)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Address 1");

                entity.Property(e => e.EmployeeAddress2)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Address 2");

                entity.Property(e => e.EmployeeAnnualElection)
                    .HasMaxLength(15)
                    .HasColumnName("Employee Annual Election");

                entity.Property(e => e.EmployeeBirthDate)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Birth Date");

                entity.Property(e => e.EmployeeCity)
                    .HasMaxLength(255)
                    .HasColumnName("Employee City");

                entity.Property(e => e.EmployeeContributionYtd)
                    .HasMaxLength(15)
                    .HasColumnName("Employee Contribution YTD");

                entity.Property(e => e.EmployeeEmailAddress)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Email Address");

                entity.Property(e => e.EmployeeFirstName)
                    .HasMaxLength(255)
                    .HasColumnName("Employee First Name");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(255)
                    .HasColumnName("Employee ID");

                entity.Property(e => e.EmployeeLastName)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Last Name");

                entity.Property(e => e.EmployeePayPeriodElection)
                    .HasMaxLength(15)
                    .HasColumnName("Employee Pay Period Election");

                entity.Property(e => e.EmployeePhone)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Phone");

                entity.Property(e => e.EmployeeSocialSecurityNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Social Security Number");

                entity.Property(e => e.EmployeeState)
                    .HasMaxLength(255)
                    .HasColumnName("Employee State");

                entity.Property(e => e.EmployeeStatus)
                    .HasMaxLength(10)
                    .HasColumnName("Employee Status");

                entity.Property(e => e.EmployeeZip)
                    .HasMaxLength(255)
                    .HasColumnName("Employee Zip");

                entity.Property(e => e.EmployerAnnualElection)
                    .HasMaxLength(15)
                    .HasColumnName("Employer Annual Election");

                entity.Property(e => e.EmployerContributionYtd)
                    .HasMaxLength(15)
                    .HasColumnName("Employer Contribution YTD");

                entity.Property(e => e.EmployerId)
                    .HasMaxLength(255)
                    .HasColumnName("Employer Id");

                entity.Property(e => e.EmployerPayPeriodElection)
                    .HasMaxLength(15)
                    .HasColumnName("Employer Pay Period Election");

                entity.Property(e => e.IndividualAmount)
                    .HasMaxLength(15)
                    .HasColumnName("Individual Amount");

                entity.Property(e => e.OriginalPrefundedAnnualElectionAmount)
                    .HasMaxLength(15)
                    .HasColumnName("Original Prefunded/Annual Election Amount");

                entity.Property(e => e.OtherDeposits)
                    .HasMaxLength(255)
                    .HasColumnName("Other Deposits");

                entity.Property(e => e.PlanEndDate)
                    .HasMaxLength(255)
                    .HasColumnName("Plan End Date");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Id");

                entity.Property(e => e.PlanStartDate)
                    .HasMaxLength(255)
                    .HasColumnName("Plan Start Date");

                entity.Property(e => e.ProductPartnerAcctCloseDate).HasMaxLength(255);

                entity.Property(e => e.ProductPartnerAcctStatus).HasMaxLength(255);

                entity.Property(e => e.RecordType).HasMaxLength(255);

                entity.Property(e => e.StartAutoDepositDate)
                    .HasMaxLength(255)
                    .HasColumnName("Start Auto Deposit Date");

                entity.Property(e => e.TerminationDate)
                    .HasMaxLength(255)
                    .HasColumnName("Termination Date");

                entity.Property(e => e.TpaId)
                    .HasMaxLength(255)
                    .HasColumnName("Tpa Id");

                entity.Property(e => e.UniqueKeyAccounts).HasMaxLength(255);

                entity.Property(e => e.UniqueKeyPerpay).HasMaxLength(255);
            });

            modelBuilder.Entity<TblStatingQbTeCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STATING_QB_TE_COUNT");

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TeCount).HasColumnName("TE  Count");
            });

            modelBuilder.Entity<TblStatingQbTpCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TBL_STATING_QB_TP_COUNT");

                entity.Property(e => e.AlternateErId)
                    .HasMaxLength(255)
                    .HasColumnName("Alternate ER ID");

                entity.Property(e => e.CountOfSsn).HasColumnName("CountOfSSN");

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            modelBuilder.Entity<VwInvoiceByMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_INVOICE_BY_MONTH");

                entity.Property(e => e.EmployerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employer Name");

                entity.Property(e => e.InvoiceCount).HasColumnName("INVOICE COUNT");

                entity.Property(e => e.InvoiceTotal)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("INVOICE TOTAL");
            });

            modelBuilder.Entity<VwNewClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_NEW_CLIENT");

                entity.Property(e => e.ClientGroupName)
                .HasColumnName("ClientGroupName");
                entity.Property(e => e.ClientName)
                .HasColumnName("ClientName");
                entity.Property(e => e.BillingStartDate)
                .HasColumnName("BillingStartDate");
                entity.Property(e => e.EIN)
                .HasColumnName("EIN");
                entity.Property(e => e.ClientDivisionName)
                .HasColumnName("ClientDivisionName");
                entity.Property(e => e.ClientID)
                .HasColumnName("ClientID");
                entity.Property(e => e.ClientDivisionID)
                .HasColumnName("ClientDivisionID");
                entity.Property(e => e.Active)
                .HasColumnName("Active");
                entity.Property(e => e.ClientAlternate)
                .HasColumnName("ClientAlternate");
                entity.Property(e => e.DeactivationDate)
                .HasColumnName("DeactivationDate");
                entity.Property(e => e.TPACode)
                .HasColumnName("TPA Code");
                entity.Property(e => e.Linetype)
                .HasColumnName("Line type");
                entity.Property(e => e.AccountTypeCode)
                .HasColumnName("Account Type Code");
                entity.Property(e => e.DivisionName)
                .HasColumnName("DivisionName");
                entity.Property(e => e.PlanID)
                .HasColumnName("Plan ID");

            });
            modelBuilder.Entity<VwExistingClient>(entity =>
            {

                entity.HasNoKey();
                entity.ToView("VW_EXISTING_CLIENT");

                entity.Property(e => e.ClientGroupName)
                 .HasColumnName("ClientGroupName");
                entity.Property(e => e.ClientName)
                .HasColumnName("ClientName");
                entity.Property(e => e.BillingStartDate)
                .HasColumnName("BillingStartDate");
                entity.Property(e => e.EIN)
                .HasColumnName("EIN");
                entity.Property(e => e.ClientDivisionName)
                .HasColumnName("ClientDivisionName");
                entity.Property(e => e.ClientID)
                .HasColumnName("ClientID");
                entity.Property(e => e.ClientDivisionID)
                .HasColumnName("ClientDivisionID");
                entity.Property(e => e.Active)
                .HasColumnName("Active");
                entity.Property(e => e.ClientAlternate)
                .HasColumnName("ClientAlternate");
                entity.Property(e => e.DeactivationDate)
                .HasColumnName("DeactivationDate");
                entity.Property(e => e.TPACode)
                .HasColumnName("TPA Code");
                entity.Property(e => e.Linetype)
                .HasColumnName("Line type");
                entity.Property(e => e.AccountTypeCode)
                .HasColumnName("Account Type Code");
                entity.Property(e => e.DivisionName)
                .HasColumnName("DivisionName");
                entity.Property(e => e.PlanID)
                .HasColumnName("Plan ID");
            });
            modelBuilder.Entity<VwTerminatedClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_TERMINATED_CLIENT");

                entity.Property(e => e.ClientGroupName)
                .HasColumnName("ClientGroupName");
                entity.Property(e => e.ClientName)
                .HasColumnName("ClientName");
                entity.Property(e => e.BillingStartDate)
                .HasColumnName("BillingStartDate");
                entity.Property(e => e.EIN)
                .HasColumnName("EIN");
                entity.Property(e => e.ClientDivisionName)
                .HasColumnName("ClientDivisionName");
                entity.Property(e => e.ClientID)
                .HasColumnName("ClientID");
                entity.Property(e => e.ClientDivisionID)
                .HasColumnName("ClientDivisionID");
                entity.Property(e => e.Active)
                .HasColumnName("Active");
                entity.Property(e => e.ClientAlternate)
                .HasColumnName("ClientAlternate");
                entity.Property(e => e.DeactivationDate)
                .HasColumnName("DeactivationDate");
                entity.Property(e => e.TPACode)
                .HasColumnName("TPA Code");
                entity.Property(e => e.Linetype)
                .HasColumnName("Line type");
                entity.Property(e => e.AccountTypeCode)
                .HasColumnName("Account Type Code");
                entity.Property(e => e.DivisionName)
                .HasColumnName("DivisionName");
                entity.Property(e => e.PlanID)
                .HasColumnName("Plan ID");
            });

            modelBuilder.Entity<ClientProductComparison>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CLIENTPRODUCT_COMPARISON");

                entity.Property(e => e.SourceFileBencode)
                .HasColumnName("SOURCEFILE_BENCODE");
                entity.Property(e => e.SourceFileClientName)
                .HasColumnName("SOURCEFILE_CLIENTNAME");
                entity.Property(e => e.SourceFileProducts)
                .HasColumnName("SOURCEFILE_PRODUCTS");
                entity.Property(e => e.BillingAppBenCode)
                .HasColumnName("BILLINGAPP_BENCODE");
                entity.Property(e => e.BillingAppClientName)
                .HasColumnName("BILLINGAPP_CLIENTNAME");
                entity.Property(e => e.StartBillingDate)
                .HasColumnName("START_BILLING_DATE");
                entity.Property(e => e.EndBillingDate)
                .HasColumnName("END_BILLING_DATE");
                entity.Property(e => e.iNotExistInBillingAppTable)
                .HasColumnName("NOTEXIST_IN_BILLINGAPPTABLE");

            });
            //
            modelBuilder.Entity<ClientToClientComparison>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CLIENTTOCLIENT_COMPARISON");

                entity.Property(e => e.SourceFileBenCode)
                .HasColumnName("SOURCEFILE_BENCODE");
                entity.Property(e => e.SourceFileClientName)
                .HasColumnName("SOURCEFILE_CLIENTNAME");
                entity.Property(e => e.BillingAppBenCode)
                .HasColumnName("BILLINGAPP_BENCODE");
                entity.Property(e => e.BillingAppClientName)
                .HasColumnName("BILLINGAPP_CLIENTNAME");
                entity.Property(e => e.StartBillingDate)
                .HasColumnName("START_BILLING_DATE");
                entity.Property(e => e.EndBillingDate)
                .HasColumnName("END_BILLING_DATE");
                entity.Property(e => e.iNotExistInBillingAppTable)
                .HasColumnName("NOTEXIST_IN_BILLINGAPPTABLE");

            });
            modelBuilder.Entity<SpClientDropDownData>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("SPS_GET_CLIENTDROPDOWNDATA");
                entity.Property(e => e.ClientID)
                .HasColumnName("ClientID");
                entity.Property(e => e.ClientName)
                .HasColumnName("ClientName"); ;
            });
            modelBuilder.Entity<SpExcludeClientData>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("SPS_GET_EXCLUDECLIENTDATA");
                entity.Property(e => e.ClientID)
                .HasColumnName("ClientID");
                entity.Property(e => e.ClientName)
                .HasColumnName("ClientName");
                entity.Property(e => e.Bencode)
                .HasColumnName("Bencode");
                entity.Property(e => e.Description)
                 .HasColumnName("Description");
                entity.Property(e => e.UserID)
                 .HasColumnName("UserID");
                entity.Property(e => e.UserName)
                .HasColumnName("UserName");
                entity.Property(e => e.CreateDate)
                .HasColumnName("CreateDate");
            });
            modelBuilder.Entity<TblQBClients>(entity =>
            {
                entity.HasKey("ClientID");
                entity.ToTable("TBL_QB_CLIENTS");
                entity.Property(e => e.ClientName)
                   .HasMaxLength(255)
                   .HasColumnName("Client Name");
                entity.Property(e => e.BenCode)
                    .HasMaxLength(255)
                    .HasColumnName("Ben Code");
                entity.Property(e => e.ServiceID)
                .HasColumnName("ServiceID")
                .HasMaxLength(255);

                entity.Property(e => e.IsDeleted).HasColumnName("IsDeleted");
                entity.Property(e => e.Status).HasMaxLength(255);
                entity.Property(e => e.CreatedDate).HasColumnName("CreatedDate");
                entity.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate");
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
