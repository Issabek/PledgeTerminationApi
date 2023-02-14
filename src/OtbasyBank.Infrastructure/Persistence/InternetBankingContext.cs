using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OtbasyBank.Application.Interfaces.Persistence;
using OtbasyBank.Domain.Entities;
namespace OtbasyBank.Infrastructure.Persistance
{
    public partial class InternetBankingContext : DbContext, IInternetBankingContext
    {
        public InternetBankingContext()
        {
        }

        public InternetBankingContext(DbContextOptions<InternetBankingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AgentPhoto> AgentPhotos { get; set; } = null!;
        public virtual DbSet<ArhiveClientInfo> ArhiveClientInfos { get; set; } = null!;
        public virtual DbSet<ArhiveUserLogin> ArhiveUserLogins { get; set; } = null!;
        public virtual DbSet<AttrepTruncationSafeguard> AttrepTruncationSafeguards { get; set; } = null!;
        public virtual DbSet<AuctionBlockList> AuctionBlockLists { get; set; } = null!;
        public virtual DbSet<AuctionBuyStep> AuctionBuySteps { get; set; } = null!;
        public virtual DbSet<AuctionCancelLog> AuctionCancelLogs { get; set; } = null!;
        public virtual DbSet<AuctionDeposit> AuctionDeposits { get; set; } = null!;
        public virtual DbSet<AuctionDepositStatus> AuctionDepositStatuses { get; set; } = null!;
        public virtual DbSet<AuctionDepositsTransferLog> AuctionDepositsTransferLogs { get; set; } = null!;
        public virtual DbSet<AuctionFormsAndSm> AuctionFormsAndSms { get; set; } = null!;
        public virtual DbSet<AuctionLog> AuctionLogs { get; set; } = null!;
        public virtual DbSet<AuctionMoneyTransferLog> AuctionMoneyTransferLogs { get; set; } = null!;
        public virtual DbSet<AuctionProcess> AuctionProcesses { get; set; } = null!;
        public virtual DbSet<AuctionSellStep> AuctionSellSteps { get; set; } = null!;
        public virtual DbSet<AuctionSellersInProcess> AuctionSellersInProcesses { get; set; } = null!;
        public virtual DbSet<AuctionSetting> AuctionSettings { get; set; } = null!;
        public virtual DbSet<AuctionSubAgreement> AuctionSubAgreements { get; set; } = null!;
        public virtual DbSet<AuctionUniversalProcessLogger> AuctionUniversalProcessLoggers { get; set; } = null!;
        public virtual DbSet<AuctionUniversalProcessLoggerValue> AuctionUniversalProcessLoggerValues { get; set; } = null!;
        public virtual DbSet<AuctionUniversalProcessType> AuctionUniversalProcessTypes { get; set; } = null!;
        public virtual DbSet<BankServiceObjectInfo> BankServiceObjectInfos { get; set; } = null!;
        public virtual DbSet<Bio> Bios { get; set; } = null!;
        public virtual DbSet<BlockchainOperation> BlockchainOperations { get; set; } = null!;
        public virtual DbSet<ChangeRequisitesLog> ChangeRequisitesLogs { get; set; } = null!;
        public virtual DbSet<ChangeUserDataLog> ChangeUserDataLogs { get; set; } = null!;
        public virtual DbSet<Changelog> Changelogs { get; set; } = null!;
        public virtual DbSet<ChangerequisitesLogsTwo> ChangerequisitesLogsTwos { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ClientLivenessBan> ClientLivenessBans { get; set; } = null!;
        public virtual DbSet<ClientNotification> ClientNotifications { get; set; } = null!;
        public virtual DbSet<ClientNotificationHistory> ClientNotificationHistories { get; set; } = null!;
        public virtual DbSet<ClientNotificationStatus> ClientNotificationStatuses { get; set; } = null!;
        public virtual DbSet<ClientRestrictionsAndDelayLog> ClientRestrictionsAndDelayLogs { get; set; } = null!;
        public virtual DbSet<ClientVerificationLog> ClientVerificationLogs { get; set; } = null!;
        public virtual DbSet<ClientVerificationPhoto> ClientVerificationPhotos { get; set; } = null!;
        public virtual DbSet<ConcessionsForClientsGlobalView> ConcessionsForClientsGlobalViews { get; set; } = null!;
        public virtual DbSet<ConcessionsForClientsView> ConcessionsForClientsViews { get; set; } = null!;
        public virtual DbSet<CoronaCreditUser> CoronaCreditUsers { get; set; } = null!;
        public virtual DbSet<CoronaCreditUsersDeleted> CoronaCreditUsersDeleteds { get; set; } = null!;
        public virtual DbSet<CorporateTarifEmployee> CorporateTarifEmployees { get; set; } = null!;
        public virtual DbSet<CreditOperation> CreditOperations { get; set; } = null!;
        public virtual DbSet<CreditOperationQuery> CreditOperationQueries { get; set; } = null!;
        public virtual DbSet<CreditOperationStage> CreditOperationStages { get; set; } = null!;
        public virtual DbSet<DbObjStorage> DbObjStorages { get; set; } = null!;
        public virtual DbSet<DepositAuctionBid> DepositAuctionBids { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidGuaranteePayment> DepositAuctionBidGuaranteePayments { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidGuaranteePaymentCurrAcc> DepositAuctionBidGuaranteePaymentCurrAccs { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidGuaranteePaymentCurrAccLog> DepositAuctionBidGuaranteePaymentCurrAccLogs { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidGuaranteePaymentLog> DepositAuctionBidGuaranteePaymentLogs { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidHistory> DepositAuctionBidHistories { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidPayment> DepositAuctionBidPayments { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidPaymentCurrAcc> DepositAuctionBidPaymentCurrAccs { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidPaymentLog> DepositAuctionBidPaymentLogs { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidProcess> DepositAuctionBidProcesses { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidStage> DepositAuctionBidStages { get; set; } = null!;
        public virtual DbSet<DepositAuctionBidStatus> DepositAuctionBidStatuses { get; set; } = null!;
        public virtual DbSet<DepositAuctionCalendar> DepositAuctionCalendars { get; set; } = null!;
        public virtual DbSet<DepositAuctionDocument> DepositAuctionDocuments { get; set; } = null!;
        public virtual DbSet<DepositAuctionError> DepositAuctionErrors { get; set; } = null!;
        public virtual DbSet<DepositAuctionLot> DepositAuctionLots { get; set; } = null!;
        public virtual DbSet<DepositAuctionLot2> DepositAuctionLot2s { get; set; } = null!;
        public virtual DbSet<DepositAuctionLotHistory> DepositAuctionLotHistories { get; set; } = null!;
        public virtual DbSet<DepositAuctionLotProcess> DepositAuctionLotProcesses { get; set; } = null!;
        public virtual DbSet<DepositAuctionLotStage> DepositAuctionLotStages { get; set; } = null!;
        public virtual DbSet<DepositAuctionLotStatus> DepositAuctionLotStatuses { get; set; } = null!;
        public virtual DbSet<DepositAuctionMail> DepositAuctionMails { get; set; } = null!;
        public virtual DbSet<DepositAuctionParameter> DepositAuctionParameters { get; set; } = null!;
        public virtual DbSet<DepositAuctionPrivetLot> DepositAuctionPrivetLots { get; set; } = null!;
        public virtual DbSet<DepositAuctionWinnerBid> DepositAuctionWinnerBids { get; set; } = null!;
        public virtual DbSet<DepositCessionFree> DepositCessionFrees { get; set; } = null!;
        public virtual DbSet<DepositCessionFreeLog> DepositCessionFreeLogs { get; set; } = null!;
        public virtual DbSet<DepositCessionFreeNotifyText> DepositCessionFreeNotifyTexts { get; set; } = null!;
        public virtual DbSet<DepositCessionFreeRelation> DepositCessionFreeRelations { get; set; } = null!;
        public virtual DbSet<DepositCessionFreeSetting> DepositCessionFreeSettings { get; set; } = null!;
        public virtual DbSet<DepositCessionFreeStatus> DepositCessionFreeStatuses { get; set; } = null!;
        public virtual DbSet<DepositDivisionUndoTable> DepositDivisionUndoTables { get; set; } = null!;
        public virtual DbSet<DepositOperation> DepositOperations { get; set; } = null!;
        public virtual DbSet<DepositOperationLink> DepositOperationLinks { get; set; } = null!;
        public virtual DbSet<DepositOperationQuery> DepositOperationQueries { get; set; } = null!;
        public virtual DbSet<DepositOperationStage> DepositOperationStages { get; set; } = null!;
        public virtual DbSet<Device> Devices { get; set; } = null!;
        public virtual DbSet<DeviceInfo> DeviceInfos { get; set; } = null!;
        public virtual DbSet<DeviceTrusted> DeviceTrusteds { get; set; } = null!;
        public virtual DbSet<DeviceTrustedHistory> DeviceTrustedHistories { get; set; } = null!;
        public virtual DbSet<DeviceTrustedLog> DeviceTrustedLogs { get; set; } = null!;
        public virtual DbSet<DeviceTrustedSession> DeviceTrustedSessions { get; set; } = null!;
        public virtual DbSet<DeviceTrustedSetting> DeviceTrustedSettings { get; set; } = null!;
        public virtual DbSet<DevinoLog> DevinoLogs { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Draft> Drafts { get; set; } = null!;
        public virtual DbSet<EgovRequest> EgovRequests { get; set; } = null!;
        public virtual DbSet<EgovRequestService> EgovRequestServices { get; set; } = null!;
        public virtual DbSet<EgovResponse> EgovResponses { get; set; } = null!;
        public virtual DbSet<ExternalSiteCity> ExternalSiteCities { get; set; } = null!;
        public virtual DbSet<FamilyPackage> FamilyPackages { get; set; } = null!;
        public virtual DbSet<Faq> Faqs { get; set; } = null!;
        public virtual DbSet<Filial> Filials { get; set; } = null!;
        public virtual DbSet<Fpdeposit> Fpdeposits { get; set; } = null!;
        public virtual DbSet<FpdepositStatus> FpdepositStatuses { get; set; } = null!;
        public virtual DbSet<FpdepositStatusLog> FpdepositStatusLogs { get; set; } = null!;
        public virtual DbSet<FrontEnd> FrontEnds { get; set; } = null!;
        public virtual DbSet<GetAveragePointsForProcessesAllTimeView> GetAveragePointsForProcessesAllTimeViews { get; set; } = null!;
        public virtual DbSet<GetLastRatingsFromClientsView> GetLastRatingsFromClientsViews { get; set; } = null!;
        public virtual DbSet<GetLog4NetLogAuthLogWithArhView> GetLog4NetLogAuthLogWithArhViews { get; set; } = null!;
        public virtual DbSet<GetLog4NetLogCurrAccWithArhView> GetLog4NetLogCurrAccWithArhViews { get; set; } = null!;
        public virtual DbSet<GetLogErrorLogWithArhView> GetLogErrorLogWithArhViews { get; set; } = null!;
        public virtual DbSet<HappyFamily> HappyFamilies { get; set; } = null!;
        public virtual DbSet<HappyFamilyCrmInfo> HappyFamilyCrmInfos { get; set; } = null!;
        public virtual DbSet<Help> Helps { get; set; } = null!;
        public virtual DbSet<HelpStatus> HelpStatuses { get; set; } = null!;
        public virtual DbSet<HelpTopic> HelpTopics { get; set; } = null!;
        public virtual DbSet<History> Histories { get; set; } = null!;
        public virtual DbSet<HistoryAction> HistoryActions { get; set; } = null!;
        public virtual DbSet<HistoryActionType> HistoryActionTypes { get; set; } = null!;
        public virtual DbSet<HistoryActionsByDate> HistoryActionsByDates { get; set; } = null!;
        public virtual DbSet<HistoryOld> HistoryOlds { get; set; } = null!;
        public virtual DbSet<HsTransactionLog> HsTransactionLogs { get; set; } = null!;
        public virtual DbSet<Illustration> Illustrations { get; set; } = null!;
        public virtual DbSet<InfobipToken> InfobipTokens { get; set; } = null!;
        public virtual DbSet<InfobipTokenHistory> InfobipTokenHistories { get; set; } = null!;
        public virtual DbSet<InstructionLog> InstructionLogs { get; set; } = null!;
        public virtual DbSet<Insurance> Insurances { get; set; } = null!;
        public virtual DbSet<InsuranceContract> InsuranceContracts { get; set; } = null!;
        public virtual DbSet<InsuranceLog> InsuranceLogs { get; set; } = null!;
        public virtual DbSet<InsuranceProcess> InsuranceProcesses { get; set; } = null!;
        public virtual DbSet<InsuranceStatus> InsuranceStatuses { get; set; } = null!;
        public virtual DbSet<InvitationNotification> InvitationNotifications { get; set; } = null!;
        public virtual DbSet<Kbe> Kbes { get; set; } = null!;
        public virtual DbSet<KnowledgeBase> KnowledgeBases { get; set; } = null!;
        public virtual DbSet<KnowledgeBaseCategory> KnowledgeBaseCategories { get; set; } = null!;
        public virtual DbSet<KnowledgeBaseFile> KnowledgeBaseFiles { get; set; } = null!;
        public virtual DbSet<KnowledgeBaseParentCategory> KnowledgeBaseParentCategories { get; set; } = null!;
        public virtual DbSet<KnowledgeBaseTag> KnowledgeBaseTags { get; set; } = null!;
        public virtual DbSet<KnowledgeBaseTagConnect> KnowledgeBaseTagConnects { get; set; } = null!;
        public virtual DbSet<Knp> Knps { get; set; } = null!;
        public virtual DbSet<ListClientNotMobileApp> ListClientNotMobileApps { get; set; } = null!;
        public virtual DbSet<LoanStatus> LoanStatuses { get; set; } = null!;
        public virtual DbSet<LoanTechStatus> LoanTechStatuses { get; set; } = null!;
        public virtual DbSet<Log4NetLog> Log4NetLogs { get; set; } = null!;
        public virtual DbSet<Log4NetLogAdminGlobalExceptionLog> Log4NetLogAdminGlobalExceptionLogs { get; set; } = null!;
        public virtual DbSet<Log4NetLogAuthLog> Log4NetLogAuthLogs { get; set; } = null!;
        public virtual DbSet<Log4NetLogAuthLogArh> Log4NetLogAuthLogArhs { get; set; } = null!;
        public virtual DbSet<Log4NetLogCurAcc> Log4NetLogCurAccs { get; set; } = null!;
        public virtual DbSet<Log4NetLogCurAccArh> Log4NetLogCurAccArhs { get; set; } = null!;
        public virtual DbSet<Log4NetLogPnserviceLog> Log4NetLogPnserviceLogs { get; set; } = null!;
        public virtual DbSet<LogClientEnrollment> LogClientEnrollments { get; set; } = null!;
        public virtual DbSet<LogErrorInfo> LogErrorInfos { get; set; } = null!;
        public virtual DbSet<LogErrorInfoArh> LogErrorInfoArhs { get; set; } = null!;
        public virtual DbSet<LogErrorInfoOld> LogErrorInfoOlds { get; set; } = null!;
        public virtual DbSet<LogMobileErrorInfo> LogMobileErrorInfos { get; set; } = null!;
        public virtual DbSet<LogMobileErrorInfoRequest> LogMobileErrorInfoRequests { get; set; } = null!;
        public virtual DbSet<LogMobileErrorNotifyEmail> LogMobileErrorNotifyEmails { get; set; } = null!;
        public virtual DbSet<LogOtpStageEnrollment> LogOtpStageEnrollments { get; set; } = null!;
        public virtual DbSet<LogOtpStageEnrollmentCrm> LogOtpStageEnrollmentCrms { get; set; } = null!;
        public virtual DbSet<LogService> LogServices { get; set; } = null!;
        public virtual DbSet<LogSoapEnvelope> LogSoapEnvelopes { get; set; } = null!;
        public virtual DbSet<LogSoapEnvelopeArh> LogSoapEnvelopeArhs { get; set; } = null!;
        public virtual DbSet<LogSoapEnvelopeOldTemp> LogSoapEnvelopeOldTemps { get; set; } = null!;
        public virtual DbSet<LogSystem> LogSystems { get; set; } = null!;
        public virtual DbSet<LogsInfo> LogsInfos { get; set; } = null!;
        public virtual DbSet<LongOrder> LongOrders { get; set; } = null!;
        public virtual DbSet<LongOrder2> LongOrder2s { get; set; } = null!;
        public virtual DbSet<LongOrderAgrPar> LongOrderAgrPars { get; set; } = null!;
        public virtual DbSet<LongOrderCheck2> LongOrderCheck2s { get; set; } = null!;
        public virtual DbSet<LongOrderFile> LongOrderFiles { get; set; } = null!;
        public virtual DbSet<LongOrderFiles2> LongOrderFiles2s { get; set; } = null!;
        public virtual DbSet<LongOrderPurpose> LongOrderPurposes { get; set; } = null!;
        public virtual DbSet<LongOrderSmslog> LongOrderSmslogs { get; set; } = null!;
        public virtual DbSet<LongOrderSmslog2> LongOrderSmslog2s { get; set; } = null!;
        public virtual DbSet<LongOrderStatus> LongOrderStatuses { get; set; } = null!;
        public virtual DbSet<LongOrderType> LongOrderTypes { get; set; } = null!;
        public virtual DbSet<LotStageProcessDeleted> LotStageProcessDeleteds { get; set; } = null!;
        public virtual DbSet<MapKnpTransferType> MapKnpTransferTypes { get; set; } = null!;
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = null!;
        public virtual DbSet<MilitaryExcludeUser> MilitaryExcludeUsers { get; set; } = null!;
        public virtual DbSet<MilitaryHoldOverUser> MilitaryHoldOverUsers { get; set; } = null!;
        public virtual DbSet<MioErrorLog> MioErrorLogs { get; set; } = null!;
        public virtual DbSet<MobileInterfaceLanguage> MobileInterfaceLanguages { get; set; } = null!;
        public virtual DbSet<Module> Modules { get; set; } = null!;
        public virtual DbSet<ModuleAction> ModuleActions { get; set; } = null!;
        public virtual DbSet<MyDocumentsMenu> MyDocumentsMenus { get; set; } = null!;
        public virtual DbSet<MyDocumentsMenuReadFile> MyDocumentsMenuReadFiles { get; set; } = null!;
        public virtual DbSet<News> News { get; set; } = null!;
        public virtual DbSet<NewsStatus> NewsStatuses { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<NotificationArchive> NotificationArchives { get; set; } = null!;
        public virtual DbSet<NotificationCategory> NotificationCategories { get; set; } = null!;
        public virtual DbSet<NotificationOperationRoute> NotificationOperationRoutes { get; set; } = null!;
        public virtual DbSet<NotificationStatus> NotificationStatuses { get; set; } = null!;
        public virtual DbSet<NotificationType> NotificationTypes { get; set; } = null!;
        public virtual DbSet<OperBlock> OperBlocks { get; set; } = null!;
        public virtual DbSet<OtpCode> OtpCodes { get; set; } = null!;
        public virtual DbSet<P51020> P51020s { get; set; } = null!;
        public virtual DbSet<P51020CrmInfo> P51020CrmInfos { get; set; } = null!;
        public virtual DbSet<Passcode> Passcodes { get; set; } = null!;
        public virtual DbSet<Personal> Personals { get; set; } = null!;
        public virtual DbSet<PersonalLoginLog> PersonalLoginLogs { get; set; } = null!;
        public virtual DbSet<PnOneOffUrl> PnOneOffUrls { get; set; } = null!;
        public virtual DbSet<PnToken> PnTokens { get; set; } = null!;
        public virtual DbSet<Postdeposit> Postdeposits { get; set; } = null!;
        public virtual DbSet<PostdepositErrorLog> PostdepositErrorLogs { get; set; } = null!;
        public virtual DbSet<PreQualification> PreQualifications { get; set; } = null!;
        public virtual DbSet<PreQualificationReply> PreQualificationReplies { get; set; } = null!;
        public virtual DbSet<PreQualificationStage> PreQualificationStages { get; set; } = null!;
        public virtual DbSet<PushNotification> PushNotifications { get; set; } = null!;
        public virtual DbSet<PushStatus> PushStatuses { get; set; } = null!;
        public virtual DbSet<Rate> Rates { get; set; } = null!;
        public virtual DbSet<RegCountFromDate> RegCountFromDates { get; set; } = null!;
        public virtual DbSet<RegDepClientCount> RegDepClientCounts { get; set; } = null!;
        public virtual DbSet<RegisterIpFromDate> RegisterIpFromDates { get; set; } = null!;
        public virtual DbSet<Relation> Relations { get; set; } = null!;
        public virtual DbSet<Request> Requests { get; set; } = null!;
        public virtual DbSet<RequestsHistory> RequestsHistories { get; set; } = null!;
        public virtual DbSet<RequestsStatusType> RequestsStatusTypes { get; set; } = null!;
        public virtual DbSet<RequestsType> RequestsTypes { get; set; } = null!;
        public virtual DbSet<ResourceTxt> ResourceTxts { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleAccess> RoleAccesses { get; set; } = null!;
        public virtual DbSet<RoleActionType> RoleActionTypes { get; set; } = null!;
        public virtual DbSet<RoleModule> RoleModules { get; set; } = null!;
        public virtual DbSet<RoleOperation> RoleOperations { get; set; } = null!;
        public virtual DbSet<RoleOperationAction> RoleOperationActions { get; set; } = null!;
        public virtual DbSet<RolesAndOperation> RolesAndOperations { get; set; } = null!;
        public virtual DbSet<RssNews> RssNews { get; set; } = null!;
        public virtual DbSet<RunaObj> RunaObjs { get; set; } = null!;
        public virtual DbSet<RunaObjProp> RunaObjProps { get; set; } = null!;
        public virtual DbSet<RunaObjType> RunaObjTypes { get; set; } = null!;
        public virtual DbSet<RunaOpv> RunaOpvs { get; set; } = null!;
        public virtual DbSet<RunaUserNotify> RunaUserNotifies { get; set; } = null!;
        public virtual DbSet<SendedToBpmlog> SendedToBpmlogs { get; set; } = null!;
        public virtual DbSet<ServiceBusCache> ServiceBusCaches { get; set; } = null!;
        public virtual DbSet<ServiceFile> ServiceFiles { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<SiteSetting> SiteSettings { get; set; } = null!;
        public virtual DbSet<SmsSendInfo> SmsSendInfos { get; set; } = null!;
        public virtual DbSet<SmsSendLog> SmsSendLogs { get; set; } = null!;
        public virtual DbSet<Sqliinresult> Sqliinresults { get; set; } = null!;
        public virtual DbSet<StandingOrder> StandingOrders { get; set; } = null!;
        public virtual DbSet<StandingOrderProcess> StandingOrderProcesses { get; set; } = null!;
        public virtual DbSet<StandingOrderStage> StandingOrderStages { get; set; } = null!;
        public virtual DbSet<SubAgreement> SubAgreements { get; set; } = null!;
        public virtual DbSet<SynchronizeColvir> SynchronizeColvirs { get; set; } = null!;
        public virtual DbSet<Transfer> Transfers { get; set; } = null!;
        public virtual DbSet<TransferSetting> TransferSettings { get; set; } = null!;
        public virtual DbSet<TransferType> TransferTypes { get; set; } = null!;
        public virtual DbSet<UniqueLogonCountFromDate> UniqueLogonCountFromDates { get; set; } = null!;
        public virtual DbSet<UsdisplayObjectGoal> UsdisplayObjectGoals { get; set; } = null!;
        public virtual DbSet<UsdisplayObjectName> UsdisplayObjectNames { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserAccess> UserAccesses { get; set; } = null!;
        public virtual DbSet<UserAccessLog> UserAccessLogs { get; set; } = null!;
        public virtual DbSet<UserCountByFilial> UserCountByFilials { get; set; } = null!;
        public virtual DbSet<UserFile> UserFiles { get; set; } = null!;
        public virtual DbSet<UserFileSignInfo> UserFileSignInfos { get; set; } = null!;
        public virtual DbSet<UserFileType> UserFileTypes { get; set; } = null!;
        public virtual DbSet<UserFilesPki> UserFilesPkis { get; set; } = null!;
        public virtual DbSet<UserNotifyRepaymentSchedule> UserNotifyRepaymentSchedules { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserToDeactivate> UserToDeactivates { get; set; } = null!;
        public virtual DbSet<UsersAndRolesDictionary> UsersAndRolesDictionaries { get; set; } = null!;
        public virtual DbSet<UsersAndRolesDictionaryHasAccess> UsersAndRolesDictionaryHasAccesses { get; set; } = null!;
        public virtual DbSet<VideoBanner> VideoBanners { get; set; } = null!;
        public virtual DbSet<VideoBannerUserDeviceViewed> VideoBannerUserDeviceVieweds { get; set; } = null!;
        public virtual DbSet<ViewBiStandingOrder> ViewBiStandingOrders { get; set; } = null!;
        public virtual DbSet<ViewBiStandingOrderPayment> ViewBiStandingOrderPayments { get; set; } = null!;
        public virtual DbSet<ViewForTest> ViewForTests { get; set; } = null!;
        public virtual DbSet<ViewSmsSendOtpLog> ViewSmsSendOtpLogs { get; set; } = null!;
        public virtual DbSet<WorkingDay> WorkingDays { get; set; } = null!;
        public virtual DbSet<WsLog> WsLogs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=10.10.15.86;Initial Catalog=ib-db-new;User ID=ib-db-user;Password=9PwV5Eg?zp;Max Pool Size = 5000;Pooling = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgentPhoto>(entity =>
            {
                entity.HasKey(e => e.Iin);

                entity.ToTable("AgentPhoto");

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Contract).HasMaxLength(250);

                entity.Property(e => e.DateUpdated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Poa).HasMaxLength(250);

                entity.Property(e => e.Position).HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ArhiveClientInfo>(entity =>
            {
                entity.ToTable("ArhiveClientInfo");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.ClientId).HasColumnName("client_Id");

                entity.Property(e => e.ClientId1)
                    .HasMaxLength(50)
                    .HasColumnName("clientId");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<ArhiveUserLogin>(entity =>
            {
                entity.ToTable("ArhiveUserLogin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ArhiveType)
                    .HasColumnName("arhiveType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserFailedPasswordAttemptCount).HasColumnName("userFailedPasswordAttemptCount");

                entity.Property(e => e.UserFailedPasswordAttemptWindowStart)
                    .HasColumnType("datetime")
                    .HasColumnName("userFailedPasswordAttemptWindowStart")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserLastLockOutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userLastLockOutDate");

                entity.Property(e => e.UserLastLoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userLastLoginDate");

                entity.Property(e => e.UserLastPassChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userLastPassChangeDate");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .HasColumnName("userLogin");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(128)
                    .HasColumnName("userPassword");

                entity.Property(e => e.UserType)
                    .HasColumnName("userType")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AttrepTruncationSafeguard>(entity =>
            {
                entity.HasKey(e => new { e.LatchTaskName, e.LatchMachineGuid, e.LatchKey })
                    .HasName("PK__attrep_t__65C99AC830E084B3");

                entity.ToTable("attrep_truncation_safeguard");

                entity.Property(e => e.LatchTaskName)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("latchTaskName");

                entity.Property(e => e.LatchMachineGuid)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("latchMachineGUID");

                entity.Property(e => e.LatchKey)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LatchLocker)
                    .HasColumnType("datetime")
                    .HasColumnName("latchLocker");
            });

            modelBuilder.Entity<AuctionBlockList>(entity =>
            {
                entity.HasKey(e => e.AuctionDepositId)
                    .HasName("PK_dbo.AuctionBlockLists");

                entity.Property(e => e.AuctionDepositId).ValueGeneratedNever();

                entity.Property(e => e.UnblockTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AuctionBuyStep>(entity =>
            {
                entity.HasIndex(e => e.PublicKey, "IX_AuctionBuySteps_missing_26090");

                entity.HasIndex(e => e.UsersUserId, "IX_Users_userId");

                entity.Property(e => e.AgreementSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.Otp).HasColumnName("OTP");

                entity.Property(e => e.UsersUserId).HasColumnName("Users_userId");

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.AuctionBuySteps)
                    .HasForeignKey(d => d.UsersUserId)
                    .HasConstraintName("FK_dbo.AuctionBuySteps_dbo.Users_Users_userId");
            });

            modelBuilder.Entity<AuctionCancelLog>(entity =>
            {
                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.SmsDate).HasColumnType("datetime");

                entity.Property(e => e.UnblockDate).HasColumnType("datetime");

                entity.HasOne(d => d.AuctionDeposits)
                    .WithMany(p => p.AuctionCancelLogs)
                    .HasForeignKey(d => d.AuctionDepositsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.AuctionCancelLogs_dbo.AuctionDeposits_AuctionDepositsId");

                entity.HasOne(d => d.AuctionProcess)
                    .WithMany(p => p.AuctionCancelLogs)
                    .HasForeignKey(d => d.AuctionProcessId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_dbo.AuctionCancelLogs_dbo.AuctionProcesses_AuctionProcessId");

                entity.HasOne(d => d.CancelStatus)
                    .WithMany(p => p.AuctionCancelLogs)
                    .HasForeignKey(d => d.CancelStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AuctionCancelLogs_dbo.AuctionDepositStatus_CancelStatusId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuctionCancelLogs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AuctionCancelLogs_dbo.Users_UserId");
            });

            modelBuilder.Entity<AuctionDeposit>(entity =>
            {
                entity.HasIndex(e => e.BuyStepsId, "IX_BuyStepsId");

                entity.HasIndex(e => e.ProcessId, "IX_ProcessId");

                entity.HasIndex(e => e.SellStepsId, "IX_SellStepsId");

                entity.HasIndex(e => e.StatusId, "IX_StatusId");

                entity.HasIndex(e => e.SellStepsId, "SanzharUniqAddAuctionDepContrains")
                    .IsUnique();

                entity.Property(e => e.BankCommission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BuyerSendNotification).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepositCreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepositId).HasColumnName("depositId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FullReward).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GosReward).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastYearReward).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellerSendNotification).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAccumulations).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<AuctionDepositStatus>(entity =>
            {
                entity.ToTable("AuctionDepositStatus");
            });

            modelBuilder.Entity<AuctionDepositsTransferLog>(entity =>
            {
                entity.HasIndex(e => e.AuctionDepositsId, "IX_AuctionDepositsId");

                entity.HasIndex(e => e.AuctionProcessId, "IX_AuctionProcessId");

                entity.HasIndex(e => e.BuyerUserUserId, "IX_BuyerUser_userId");

                entity.HasIndex(e => e.SellerUserUserId, "IX_SellerUser_userId");

                entity.Property(e => e.BuyerUserUserId).HasColumnName("BuyerUser_userId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastTryDate).HasColumnType("datetime");

                entity.Property(e => e.SellerUserUserId).HasColumnName("SellerUser_userId");

                entity.Property(e => e.WsConcessionDepositId).HasColumnName("wsConcessionDepositId");

                entity.Property(e => e.WsSessionId).HasColumnName("wsSessionId");
            });

            modelBuilder.Entity<AuctionFormsAndSm>(entity =>
            {
                entity.ToTable("AuctionFormsAndSMS");

                entity.Property(e => e.Key).HasMaxLength(50);
            });

            modelBuilder.Entity<AuctionLog>(entity =>
            {
                entity.HasIndex(e => e.ProcessId, "IX_ProcessId");

                entity.HasIndex(e => e.UsersUserId, "IX_Users_userId");

                entity.Property(e => e.AuctionType).HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.UsersUserId).HasColumnName("Users_userId");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.AuctionLogs)
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_dbo.AuctionLogs_dbo.AuctionProcesses_ProcessId");

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.AuctionLogs)
                    .HasForeignKey(d => d.UsersUserId)
                    .HasConstraintName("FK_dbo.AuctionLogs_dbo.Users_Users_userId");
            });

            modelBuilder.Entity<AuctionMoneyTransferLog>(entity =>
            {
                entity.HasIndex(e => new { e.AuctionProcessId, e.AuctionDepositsId }, "AuctionMoneyTransfer_UniqueRecords")
                    .IsUnique();

                entity.HasIndex(e => e.AuctionDepositsId, "IX_AuctionDepositsId");

                entity.HasIndex(e => e.AuctionProcessId, "IX_AuctionProcessId");

                entity.HasIndex(e => e.BuyerUserUserId, "IX_BuyerUser_userId");

                entity.HasIndex(e => e.SellerUserUserId, "IX_SellerUser_userId");

                entity.Property(e => e.BankCommission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BuyerUserUserId).HasColumnName("BuyerUser_userId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastTryDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentSguide)
                    .HasMaxLength(50)
                    .HasColumnName("PaymentSGuide");

                entity.Property(e => e.SellerUserUserId).HasColumnName("SellerUser_userId");

                entity.Property(e => e.Sum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WsOrderIdBtoS).HasColumnName("wsOrderIdBToS");

                entity.Property(e => e.WsOrderIdCommision).HasColumnName("wsOrderIdCommision");

                entity.HasOne(d => d.AuctionDeposits)
                    .WithMany(p => p.AuctionMoneyTransferLogs)
                    .HasForeignKey(d => d.AuctionDepositsId)
                    .HasConstraintName("FK_dbo.AuctionMoneyTransferLogs_dbo.AuctionDeposits_AuctionDepositsId");

                entity.HasOne(d => d.AuctionProcess)
                    .WithMany(p => p.AuctionMoneyTransferLogs)
                    .HasForeignKey(d => d.AuctionProcessId)
                    .HasConstraintName("FK_dbo.AuctionMoneyTransferLogs_dbo.AuctionProcesses_AuctionProcessId");

                entity.HasOne(d => d.BuyerUserUser)
                    .WithMany(p => p.AuctionMoneyTransferLogBuyerUserUsers)
                    .HasForeignKey(d => d.BuyerUserUserId)
                    .HasConstraintName("FK_dbo.AuctionMoneyTransferLogs_dbo.Users_BuyerUser_userId");

                entity.HasOne(d => d.SellerUserUser)
                    .WithMany(p => p.AuctionMoneyTransferLogSellerUserUsers)
                    .HasForeignKey(d => d.SellerUserUserId)
                    .HasConstraintName("FK_dbo.AuctionMoneyTransferLogs_dbo.Users_SellerUser_userId");
            });

            modelBuilder.Entity<AuctionProcess>(entity =>
            {
                entity.HasIndex(e => new { e.UsersId, e.ProcessIsEnd }, "IX_AuctionProcesses_missing_25919");

                entity.HasIndex(e => e.BuyStepsId, "IX_BuyStepsId");

                entity.HasIndex(e => e.UsersUserId, "IX_Users_userId");

                entity.Property(e => e.BuyerAgreementSignDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Otp).HasColumnName("OTP");

                entity.Property(e => e.UsersUserId).HasColumnName("Users_userId");

                entity.HasOne(d => d.BuySteps)
                    .WithMany(p => p.AuctionProcesses)
                    .HasForeignKey(d => d.BuyStepsId)
                    .HasConstraintName("FK_dbo.AuctionProcesses_dbo.AuctionBuySteps_BuyStepsId");

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.AuctionProcesses)
                    .HasForeignKey(d => d.UsersUserId)
                    .HasConstraintName("FK_dbo.AuctionProcesses_dbo.Users_Users_userId");
            });

            modelBuilder.Entity<AuctionSellStep>(entity =>
            {
                entity.HasIndex(e => e.PublicKey, "IX_AuctionSellSteps_missing_26042");

                entity.HasIndex(e => e.UsersUserId, "IX_Users_userId");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate");

                entity.Property(e => e.DepositId).HasColumnName("depositId");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Otp).HasColumnName("OTP");

                entity.Property(e => e.StatementSignDate).HasColumnType("datetime");

                entity.Property(e => e.UsersUserId).HasColumnName("Users_userId");

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.AuctionSellSteps)
                    .HasForeignKey(d => d.UsersUserId)
                    .HasConstraintName("FK_dbo.AuctionSellSteps_dbo.Users_Users_userId");
            });

            modelBuilder.Entity<AuctionSellersInProcess>(entity =>
            {
                entity.HasIndex(e => e.AuctionDepositsId, "IX_AuctionDepositsId");

                entity.HasIndex(e => e.UsersId, "IX_AuctionSellersInProcesses_missing_32541");

                entity.HasIndex(e => e.ProcessId, "IX_ProcessId");

                entity.HasIndex(e => e.UsersUserId, "IX_Users_userId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Otp).HasColumnName("OTP");

                entity.Property(e => e.SellerAgreementSignDate).HasColumnType("datetime");

                entity.Property(e => e.UsersUserId).HasColumnName("Users_userId");

                entity.HasOne(d => d.AuctionDeposits)
                    .WithMany(p => p.AuctionSellersInProcesses)
                    .HasForeignKey(d => d.AuctionDepositsId)
                    .HasConstraintName("FK_dbo.AuctionSellersInProcesses_dbo.AuctionDeposits_AuctionDepositsId");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.AuctionSellersInProcesses)
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_dbo.AuctionSellersInProcesses_dbo.AuctionProcesses_ProcessId");

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.AuctionSellersInProcesses)
                    .HasForeignKey(d => d.UsersUserId)
                    .HasConstraintName("FK_dbo.AuctionSellersInProcesses_dbo.Users_Users_userId");
            });

            modelBuilder.Entity<AuctionSetting>(entity =>
            {
                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<AuctionSubAgreement>(entity =>
            {
                entity.HasIndex(e => e.AuctionDepositsId, "IX_AuctionDepositsId");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.SubAgreementStartDate).HasColumnType("datetime");

                entity.Property(e => e.SubAgreementStopDate).HasColumnType("datetime");

                entity.HasOne(d => d.AuctionDeposits)
                    .WithMany(p => p.AuctionSubAgreements)
                    .HasForeignKey(d => d.AuctionDepositsId)
                    .HasConstraintName("FK_dbo.AuctionSubAgreements_dbo.AuctionDeposits_AuctionDepositsId");
            });

            modelBuilder.Entity<AuctionUniversalProcessLogger>(entity =>
            {
                entity.HasIndex(e => e.TypeId, "IX_TypeId");

                entity.HasIndex(e => e.UsersUserId, "IX_Users_userId");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(4);

                entity.Property(e => e.Step).HasMaxLength(100);

                entity.Property(e => e.UsersUserId).HasColumnName("Users_userId");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AuctionUniversalProcessLoggers)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_dbo.AuctionUniversalProcessLoggers_dbo.AuctionUniversalProcessTypes_TypeId");

                entity.HasOne(d => d.UsersUser)
                    .WithMany(p => p.AuctionUniversalProcessLoggers)
                    .HasForeignKey(d => d.UsersUserId)
                    .HasConstraintName("FK_dbo.AuctionUniversalProcessLoggers_dbo.Users_Users_userId");
            });

            modelBuilder.Entity<AuctionUniversalProcessLoggerValue>(entity =>
            {
                entity.HasIndex(e => e.AuctionUniversalProcessLoggerId, "IX_AuctionUniversalProcessLoggerId");

                entity.Property(e => e.Key).HasMaxLength(10);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.HasOne(d => d.AuctionUniversalProcessLogger)
                    .WithMany(p => p.AuctionUniversalProcessLoggerValues)
                    .HasForeignKey(d => d.AuctionUniversalProcessLoggerId)
                    .HasConstraintName("FK_dbo.AuctionUniversalProcessLoggerValues_dbo.AuctionUniversalProcessLoggers_AuctionUniversalProcessLoggerId");
            });

            modelBuilder.Entity<BankServiceObjectInfo>(entity =>
            {
                entity.ToTable("BankServiceObjectInfo");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AddressKaz)
                    .HasMaxLength(500)
                    .HasColumnName("Address_Kaz");

                entity.Property(e => e.BpmBranchCode).HasMaxLength(10);

                entity.Property(e => e.BpmCityCode).HasMaxLength(10);

                entity.Property(e => e.BpmCityName).HasMaxLength(150);

                entity.Property(e => e.BpmDepCode).HasMaxLength(10);

                entity.Property(e => e.CityName).HasMaxLength(150);

                entity.Property(e => e.CityNameKaz)
                    .HasMaxLength(150)
                    .HasColumnName("CityName_Kaz");

                entity.Property(e => e.DepartmentName).HasMaxLength(150);

                entity.Property(e => e.DepartmentNameKaz)
                    .HasMaxLength(150)
                    .HasColumnName("DepartmentName_Kaz");

                entity.Property(e => e.ExternalSiteId).HasMaxLength(20);

                entity.Property(e => e.GeoPosition).HasMaxLength(100);

                entity.Property(e => e.Lat).HasMaxLength(100);

                entity.Property(e => e.Lon).HasMaxLength(100);

                entity.Property(e => e.ObjectTypeName).HasMaxLength(100);

                entity.Property(e => e.ServicesList).HasMaxLength(4000);

                entity.Property(e => e.ServicesListKaz)
                    .HasMaxLength(4000)
                    .HasColumnName("ServicesList_Kaz");

                entity.Property(e => e.WorkTime).HasMaxLength(400);

                entity.Property(e => e.WorkTimeKaz)
                    .HasMaxLength(400)
                    .HasColumnName("WorkTime_Kaz");
            });

            modelBuilder.Entity<Bio>(entity =>
            {
                entity.ToTable("Bio");

                entity.HasIndex(e => new { e.DeviceId, e.BioStatusId }, "IX_Bio_missing_29504");

                entity.Property(e => e.Id).HasComment("Идентификатор отпечатка");

                entity.Property(e => e.BioStatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Статус отпечатка");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.DeviceId).HasComment("Идентификатор устройства");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Bios)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bio_Device");
            });

            modelBuilder.Entity<BlockchainOperation>(entity =>
            {
                entity.ToTable("BlockchainOperation");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AppId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LetterInfo).HasColumnType("ntext");

                entity.Property(e => e.LoanId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parameters).HasColumnType("ntext");

                entity.Property(e => e.PledgeId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rka)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RKA");

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCanceled)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Canceled");

                entity.Property(e => e.StatusNew)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_New");

                entity.Property(e => e.StatusPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Paid");

                entity.Property(e => e.StatusRecall)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Recall");

                entity.Property(e => e.StatusRegistered)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Registered");

                entity.Property(e => e.StatusRejected)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Rejected");

                entity.Property(e => e.StatusSuspendedNotPaid)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Suspended_Not_Paid");

                entity.Property(e => e.StatusVerified)
                    .HasColumnType("datetime")
                    .HasColumnName("Status_Verified");
            });

            modelBuilder.Entity<ChangeRequisitesLog>(entity =>
            {
                entity.ToTable("ChangeRequisitesLogs", "OperationsLogs");

                entity.Property(e => e.Level).HasMaxLength(128);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserIin)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChangeUserDataLog>(entity =>
            {
                entity.ToTable("ChangeUserDataLog");

                entity.Property(e => e.ObjectDescriber).HasMaxLength(600);

                entity.Property(e => e.Reason).HasMaxLength(2000);

                entity.Property(e => e.Sender).HasMaxLength(300);
            });

            modelBuilder.Entity<Changelog>(entity =>
            {
                entity.ToTable("changelog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Checksum)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("checksum");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.InstalledBy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("installed_by");

                entity.Property(e => e.InstalledOn)
                    .HasColumnType("datetime")
                    .HasColumnName("installed_on")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<ChangerequisitesLogsTwo>(entity =>
            {
                entity.ToTable("ChangerequisitesLogsTwo", "OperationsLogs");

                entity.Property(e => e.Level).HasMaxLength(128);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserIin)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.HasIndex(e => e.UserId, "NonClusteredIndex-20180604-102153")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ClientFilialCode, "NonClusteredIndex-20180604-103019")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ClientCode, "SSClientCode");

                entity.HasIndex(e => e.ClientIin, "SSClientIIN");

                entity.HasIndex(e => e.ClientId, "Sanzh2");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.ClientFilialCode)
                    .HasMaxLength(5)
                    .HasColumnName("clientFilialCode");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .HasColumnName("clientId");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.Fname).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sname).HasMaxLength(50);

                entity.Property(e => e.SynchColvirDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_Users");
            });

            modelBuilder.Entity<ClientLivenessBan>(entity =>
            {
                entity.ToTable("ClientLivenessBan");

                entity.HasIndex(e => new { e.Iin, e.Process }, "IX_ClientLivenessBan_missing_31113");

                entity.Property(e => e.FraudPercentage).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Iin).HasMaxLength(20);

                entity.Property(e => e.Process).HasMaxLength(100);

                entity.Property(e => e.ProcessTimde)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ClientNotification>(entity =>
            {
                entity.ToTable("ClientNotification");

                entity.HasIndex(e => e.ClientId, "IX_ClientId");

                entity.HasIndex(e => new { e.ClientId, e.NotificationId }, "IX_ClientId_NotificationId")
                    .IsUnique();

                entity.HasIndex(e => e.NotificationId, "IX_NotificationId");

                entity.HasIndex(e => new { e.StatusDate, e.StatusId }, "i_clnt_notification_statusdate_status");

                entity.Property(e => e.ColvirReferenceId).HasMaxLength(100);

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PEND')")
                    .IsFixedLength();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientNotifications)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientNotification_Client");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ClientNotifications)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientNotification_ClientNotificationStatus");
            });

            modelBuilder.Entity<ClientNotificationHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClientNotificationHistory");

                entity.HasIndex(e => new { e.ClientId, e.NotificationId }, "IX_ClientNotificationHistory_ClientId_NotificationId")
                    .IsClustered();

                entity.HasIndex(e => new { e.NotificationId, e.ClientNotificationId }, "NotificationId_ClientNotificationId");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PEND')")
                    .IsFixedLength();

                entity.HasOne(d => d.Client)
                    .WithMany()
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientNotificationHistory_Client");

                entity.HasOne(d => d.Status)
                    .WithMany()
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientNotificationHistory_ClientNotificationStatus");
            });

            modelBuilder.Entity<ClientNotificationStatus>(entity =>
            {
                entity.ToTable("ClientNotificationStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(50)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(50)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<ClientRestrictionsAndDelayLog>(entity =>
            {
                entity.ToTable("ClientRestrictionsAndDelayLog");

                entity.HasIndex(e => e.UserId, "IX_ClientRestrictionsAndDelayLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallTime).HasColumnName("callTime");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.InputParameters).HasColumnName("inputParameters");

                entity.Property(e => e.MethodName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("methodName");

                entity.Property(e => e.ObjectId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("objectId");

                entity.Property(e => e.ResponseTime).HasColumnName("responseTime");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.ResultCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resultCode");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("sourceName");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<ClientVerificationLog>(entity =>
            {
                entity.ToTable("ClientVerificationLog");

                entity.HasIndex(e => e.DateInserted, "index_ClientVerificationLog_DateInserted");

                entity.Property(e => e.DateInserted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Iin).HasMaxLength(20);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.Uuid).HasMaxLength(100);
            });

            modelBuilder.Entity<ClientVerificationPhoto>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.DateInserted, "index_ClientVerificationPhotos_DateInserted");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.DateInserted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ClientVerificationLog)
                    .WithMany()
                    .HasForeignKey(d => d.ClientVerificationLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClientVer__Clien__24BD5A91");
            });

            modelBuilder.Entity<ConcessionsForClientsGlobalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ConcessionsForClientsGlobalView");

                entity.Property(e => e.AuctionCreateDate).HasColumnType("datetime");

                entity.Property(e => e.AuctionDepositCreateDate).HasColumnType("datetime");

                entity.Property(e => e.BankCommission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BuyerFio)
                    .HasMaxLength(152)
                    .HasColumnName("buyerFIO");

                entity.Property(e => e.BuyerIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BuyerIIN")
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellerFio)
                    .HasMaxLength(152)
                    .HasColumnName("sellerFIO");

                entity.Property(e => e.SellerIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SellerIIN")
                    .IsFixedLength();

                entity.Property(e => e.Summ).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<ConcessionsForClientsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ConcessionsForClientsView");

                entity.Property(e => e.AuctionCreateDate).HasColumnType("datetime");

                entity.Property(e => e.AuctionDepositCreateDate).HasColumnType("datetime");

                entity.Property(e => e.BankCommission).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BuyerFio)
                    .HasMaxLength(152)
                    .HasColumnName("buyerFIO");

                entity.Property(e => e.BuyerIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BuyerIIN")
                    .IsFixedLength();

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Saldo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellerFio)
                    .HasMaxLength(152)
                    .HasColumnName("sellerFIO");

                entity.Property(e => e.SellerIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SellerIIN")
                    .IsFixedLength();

                entity.Property(e => e.Summ).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<CoronaCreditUser>(entity =>
            {
                entity.Property(e => e.ClientCode).HasMaxLength(50);

                entity.Property(e => e.ClientId).HasMaxLength(50);

                entity.Property(e => e.ColverReferenceId).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HouseLoanDate).HasColumnType("datetime");

                entity.Property(e => e.Iin)
                    .HasMaxLength(50)
                    .HasColumnName("IIN");

                entity.Property(e => e.LoanId).HasMaxLength(50);

                entity.Property(e => e.NeedTransferToHouseLoan).HasDefaultValueSql("((0))");

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<CoronaCreditUsersDeleted>(entity =>
            {
                entity.ToTable("CoronaCreditUsersDeleted");

                entity.Property(e => e.ClientCode).HasMaxLength(50);

                entity.Property(e => e.ClientId).HasMaxLength(50);

                entity.Property(e => e.ColverReferenceId).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.HouseLoanDate).HasColumnType("datetime");

                entity.Property(e => e.Iin)
                    .HasMaxLength(50)
                    .HasColumnName("IIN");

                entity.Property(e => e.LoanId).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<CorporateTarifEmployee>(entity =>
            {
                entity.ToTable("corporateTarifEmployee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adress)
                    .HasMaxLength(300)
                    .HasColumnName("adress");

                entity.Property(e => e.CompanyGuid).HasColumnName("companyGuid");

                entity.Property(e => e.Fio)
                    .HasMaxLength(200)
                    .HasColumnName("fio");

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .HasColumnName("iin");

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("insertDateTime");

                entity.Property(e => e.InsertUser)
                    .HasMaxLength(100)
                    .HasColumnName("insertUser");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .HasColumnName("phoneNumber");

                entity.Property(e => e.Position)
                    .HasMaxLength(200)
                    .HasColumnName("position");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(3, 2)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<CreditOperation>(entity =>
            {
                entity.ToTable("CreditOperation");

                entity.Property(e => e.CreditOperationId)
                    .ValueGeneratedNever()
                    .HasColumnName("creditOperationID");

                entity.Property(e => e.CoType)
                    .HasColumnName("coType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CreditId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("creditID");

                entity.Property(e => e.CreditOperationBankId).HasColumnName("creditOperationBankID");

                entity.Property(e => e.CreditOperationData)
                    .HasColumnType("xml")
                    .HasColumnName("creditOperationData");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<CreditOperationQuery>(entity =>
            {
                entity.ToTable("CreditOperationQuery");

                entity.Property(e => e.CreditOperationQueryId).HasColumnName("creditOperationQueryID");

                entity.Property(e => e.BankAnswer)
                    .HasMaxLength(1000)
                    .HasColumnName("bankAnswer");

                entity.Property(e => e.BankComment)
                    .HasMaxLength(500)
                    .HasColumnName("bankComment");

                entity.Property(e => e.CoType).HasColumnName("coType");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CreditOperationId).HasColumnName("creditOperationID");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("sessionID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TokenId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("tokenID");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.XmlData)
                    .HasColumnType("xml")
                    .HasColumnName("xmlData");
            });

            modelBuilder.Entity<CreditOperationStage>(entity =>
            {
                entity.ToTable("CreditOperationStage");

                entity.Property(e => e.CreditOperationStageId).HasColumnName("creditOperationStageID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CreditOperationId).HasColumnName("creditOperationID");

                entity.Property(e => e.CreditOperationStageData)
                    .HasColumnType("xml")
                    .HasColumnName("creditOperationStageData");

                entity.Property(e => e.CurrentStage)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("currentStage");

                entity.Property(e => e.StageNum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("stageNum");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<DbObjStorage>(entity =>
            {
                entity.HasKey(e => e.SourceId)
                    .HasName("PK__DB_OBJ_S__2630BE82E14FB037");

                entity.ToTable("DB_OBJ_STORAGE");

                entity.Property(e => e.SourceId)
                    .HasMaxLength(250)
                    .HasColumnName("SOURCE_ID");

                entity.Property(e => e.DataAsJson).HasColumnName("dataAsJson");

                entity.Property(e => e.DataAsXml)
                    .HasColumnType("xml")
                    .HasColumnName("dataAsXML");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<DepositAuctionBid>(entity =>
            {
                entity.ToTable("DepositAuctionBid");

                entity.HasIndex(e => new { e.DepositAuctionLotId, e.BidStatusId }, "SSDepAucBid");

                entity.Property(e => e.Id).HasComment("Идентификатор ставки");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("Сумма ставки");

                entity.Property(e => e.BidStatusId).HasComment("Статус ставки");

                entity.Property(e => e.ClientId).HasComment("Идентификатор клиета");

                entity.Property(e => e.ContactInfo)
                    .HasMaxLength(250)
                    .HasComment("Контактная инормация");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания ставки");

                entity.Property(e => e.DepositAuctionLotId).HasComment("Идентификатор лота");

                entity.Property(e => e.GosPremDepositId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Номер депозита для переноса гос премии");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('EPAY')")
                    .IsFixedLength();

                entity.Property(e => e.ProcessId).HasComment("Идентфикаора процесса");

                entity.Property(e => e.RemainderPaymentType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NULL')")
                    .IsFixedLength();

                entity.HasOne(d => d.BidStatus)
                    .WithMany(p => p.DepositAuctionBids)
                    .HasForeignKey(d => d.BidStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DepositAuctionBid_DepositAuctionBidStatusId_fk");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DepositAuctionBids)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DepositAuctionBid_ClientId_fk");

                entity.HasOne(d => d.DepositAuctionLot)
                    .WithMany(p => p.DepositAuctionBids)
                    .HasForeignKey(d => d.DepositAuctionLotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionBid_DepositAuctionLotId");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.DepositAuctionBids)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DepositAuctionBid_DepositAuctionBidProcess_id_fk");
            });

            modelBuilder.Entity<DepositAuctionBidGuaranteePayment>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepositAuctionBidGuaranteePayment");

                entity.HasComment("Гарантийный взнос");

                entity.HasIndex(e => e.BidId, "IX_DepositAuctionBidGuaranteePayment_BidId")
                    .IsUnique()
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.OrderId, "UQ_DepositAuctionBidGuaranteePayment_OrderId")
                    .IsUnique();

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.BidId).HasComment("Ссылка на идентификатор ставки");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата и время создания записи");

                entity.Property(e => e.EpayRedirectInfo)
                    .HasColumnType("xml")
                    .HasComment("Данные использованные для переадресации на портал оплаты EPay");

                entity.Property(e => e.EpayWsInput)
                    .HasColumnType("xml")
                    .HasComment("Данные запроса веб-сервиса сервисной шины");

                entity.Property(e => e.EpayWsResponse)
                    .HasColumnType("xml")
                    .HasComment("Данные ответа веб-сервиса сервисной шины");

                entity.Property(e => e.OrderId).HasComment("Идентификатор оплаты гарантийного взноса");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(200)
                    .HasComment("Статус оплаты гарантийного взноса");

                entity.Property(e => e.OrderStatusDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата и время обновления значения статуса оплаты гарантийного взноса в этой таблице");

                entity.HasOne(d => d.Bid)
                    .WithOne(p => p.DepositAuctionBidGuaranteePayment)
                    .HasForeignKey<DepositAuctionBidGuaranteePayment>(d => d.BidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionBidGuaranteePayment_DepositAuctionBid_Id");
            });

            modelBuilder.Entity<DepositAuctionBidGuaranteePaymentCurrAcc>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepositAuctionBidGuaranteePaymentCurrAcc");

                entity.HasComment("Гарантийный взнос");

                entity.HasIndex(e => e.BidId, "IX_DepositAuctionBidGuaranteePaymentCurrAcc_BidId")
                    .IsUnique()
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.BidId).HasComment("Ссылка на идентификатор ставки");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата и время создания записи");

                entity.Property(e => e.CurrAccIban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(200)
                    .HasComment("Статус оплаты гарантийного взноса");

                entity.Property(e => e.OrderStatusDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата и время обновления значения статуса оплаты гарантийного взноса в этой таблице");

                entity.HasOne(d => d.Bid)
                    .WithOne(p => p.DepositAuctionBidGuaranteePaymentCurrAcc)
                    .HasForeignKey<DepositAuctionBidGuaranteePaymentCurrAcc>(d => d.BidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionBidGuaranteePaymentCurrAcc_DepositAuctionBid_Id");
            });

            modelBuilder.Entity<DepositAuctionBidGuaranteePaymentCurrAccLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepositAuctionBidGuaranteePaymentCurrAccLog");

                entity.HasComment("История статусов платежа гарантийного взноса");

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата и время создания записи");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(200)
                    .HasComment("Статус оплаты гарантийного взноса");

                entity.Property(e => e.OrderStatusDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата и время обновления значения статуса оплаты гарантийного взноса в этой таблице");
            });

            modelBuilder.Entity<DepositAuctionBidGuaranteePaymentLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepositAuctionBidGuaranteePaymentLog");

                entity.HasComment("История статусов платежа гарантийного взноса");

                entity.HasIndex(e => e.OrderId, "IX_DepositAuctionBidGuaranteePaymentLog_OrderId")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата и время создания записи");

                entity.Property(e => e.OrderId).HasComment("Ссылка на идентификатор оплаты гарантийного взноса");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(200)
                    .HasComment("Статус оплаты гарантийного взноса");

                entity.Property(e => e.OrderStatusDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата и время обновления значения статуса оплаты гарантийного взноса в этой таблице");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DepositAuctionBidGuaranteePaymentLogs)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DepositAuctionBidHistory>(entity =>
            {
                entity.ToTable("DepositAuctionBidHistory");

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasComment("Сумма ставки");

                entity.Property(e => e.BidId).HasComment("Идентификатор ставки");

                entity.Property(e => e.BidStatusId).HasComment("Статус ставки");

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата изменения");

                entity.Property(e => e.ClientId).HasComment("ID клинта");

                entity.Property(e => e.ContactInfo)
                    .HasMaxLength(250)
                    .HasComment("Контактные данные");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasComment("Время создания ставки");

                entity.Property(e => e.DepositAuctionLotId).HasComment("ID лота");

                entity.Property(e => e.GosPremDepositId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("ID депозита для переноса гос премии");

                entity.Property(e => e.ProcessId).HasComment("ID процесса");
            });

            modelBuilder.Entity<DepositAuctionBidPayment>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepositAuctionBidPayment");

                entity.HasComment("Гарантийный взнос");

                entity.HasIndex(e => e.BidId, "IX_DepositAuctionBidPayment_BidId")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.OrderId, "UQ_DepositAuctionBidPayment_OrderId")
                    .IsUnique();

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.BidId).HasComment("Ссылка на идентификатор ставки");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата и время создания записи");

                entity.Property(e => e.EpayRedirectInfo)
                    .HasColumnType("xml")
                    .HasComment("Данные использованные для пере");

                entity.Property(e => e.EpayWsInput)
                    .HasColumnType("xml")
                    .HasComment("Данные запроса веб-сервиса сер");

                entity.Property(e => e.EpayWsResponse)
                    .HasColumnType("xml")
                    .HasComment("Данные ответа веб-сервиса серв");

                entity.Property(e => e.OrderId).HasComment("Идентификатор оплаты гарантийн");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(200)
                    .HasComment("Статус оплаты гарантийного взн");

                entity.Property(e => e.OrderStatusDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата и время обновления значен");

                entity.HasOne(d => d.Bid)
                    .WithMany(p => p.DepositAuctionBidPayments)
                    .HasForeignKey(d => d.BidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionBidPayment_DepositAuctionBid_Id");
            });

            modelBuilder.Entity<DepositAuctionBidPaymentCurrAcc>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepositAuctionBidPaymentCurrAcc");

                entity.HasComment("Гарантийный взнос");

                entity.HasIndex(e => e.BidId, "IX_DepositAuctionBidPaymentCurrAcc_BidId")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.BidId).HasComment("Ссылка на идентификатор ставки");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата и время создания записи");

                entity.Property(e => e.CurrAccIban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(200)
                    .HasComment("Статус оплаты гарантийного взн");

                entity.Property(e => e.OrderStatusDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата и время обновления значен");

                entity.HasOne(d => d.Bid)
                    .WithMany(p => p.DepositAuctionBidPaymentCurrAccs)
                    .HasForeignKey(d => d.BidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionBidPaymentCurrAcc_DepositAuctionBid_Id");
            });

            modelBuilder.Entity<DepositAuctionBidPaymentLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DepositAuctionBidPaymentLog");

                entity.HasComment("История статусов платежа выкупа депозита");

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата и время создания записи");

                entity.Property(e => e.OrderId).HasComment("Ссылка на идентификатор оплаты выкупа депозита");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(200)
                    .HasComment("Статус оплаты выкупа депозита");

                entity.Property(e => e.OrderStatusDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата и время обновления значения статуса оплаты выкупа депозита в этой таблице");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DepositAuctionBidPaymentLogs)
                    .HasPrincipalKey(p => p.OrderId)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DepositAuctionBidProcess>(entity =>
            {
                entity.ToTable("DepositAuctionBidProcess");

                entity.Property(e => e.ClientId).HasComment("ID клиента");

                entity.Property(e => e.Complited).HasComment("Признак завершенности");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.LotId).HasComment("Идентификатор лота");

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(50)
                    .HasComment("Наименование процесса");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DepositAuctionBidProcesses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DepositAuctionBidProcess_ClientId");
            });

            modelBuilder.Entity<DepositAuctionBidStage>(entity =>
            {
                entity.ToTable("DepositAuctionBidStage");

                entity.HasIndex(e => new { e.ProcessId, e.PostedDate }, "SSDepositAuctionBidStage");

                entity.Property(e => e.PostedDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата обработки формы");

                entity.Property(e => e.PostedModel)
                    .HasColumnType("xml")
                    .HasComment("Обрабатываемая модель");

                entity.Property(e => e.ProcessId).HasComment("ID процесса");

                entity.Property(e => e.ShowDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата показа формы");

                entity.Property(e => e.ShowModel)
                    .HasColumnType("xml")
                    .HasComment("Отображаемая модель");

                entity.Property(e => e.StepName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Наименование шага");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.DepositAuctionBidStages)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionBidStage_DepositAuctionBidProcess_Id");
            });

            modelBuilder.Entity<DepositAuctionBidStatus>(entity =>
            {
                entity.ToTable("DepositAuctionBidStatus");

                entity.Property(e => e.Id).HasComment("ID статуса");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasComment("Описание");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasComment("Наименование статуса");
            });

            modelBuilder.Entity<DepositAuctionCalendar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DepositAuctionCalendar");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.FromDate)
                    .HasColumnType("date")
                    .HasComment("Дата начала");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasComment("ID записи");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .HasComment("Причина запрета торгов");

                entity.Property(e => e.ToDate)
                    .HasColumnType("date")
                    .HasComment("Дата завершения");
            });

            modelBuilder.Entity<DepositAuctionDocument>(entity =>
            {
                entity.ToTable("DepositAuctionDocument");

                entity.Property(e => e.Id).HasComment("ID записи");

                entity.Property(e => e.BidId).HasComment("Идентфикатор ставки");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.DocBody)
                    .HasColumnType("ntext")
                    .HasComment("Содержимое документа");

                entity.Property(e => e.DocName)
                    .HasMaxLength(250)
                    .HasComment("Наименование документа");

                entity.Property(e => e.DocSignCode)
                    .HasColumnType("ntext")
                    .HasComment("Подпись");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(50)
                    .HasComment("Присвоенные номер документа");

                entity.Property(e => e.KeyInfo)
                    .HasColumnType("ntext")
                    .HasComment("Информация об OTP");

                entity.Property(e => e.LotId).HasComment("Идентификатор лота");

                entity.HasOne(d => d.Bid)
                    .WithMany(p => p.DepositAuctionDocuments)
                    .HasForeignKey(d => d.BidId)
                    .HasConstraintName("FK_DepositAuctionDocument_DepositAuctionBid");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.DepositAuctionDocuments)
                    .HasForeignKey(d => d.LotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionDocument_DepositAuctionLot");
            });

            modelBuilder.Entity<DepositAuctionError>(entity =>
            {
                entity.ToTable("DepositAuctionError");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID записи");

                entity.Property(e => e.BidId).HasComment("Идентифкаор ставки");

                entity.Property(e => e.Error)
                    .HasMaxLength(2000)
                    .HasComment("Описание ошибки");

                entity.Property(e => e.ErrorDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата возникнования ошибки");

                entity.Property(e => e.ErrorStack)
                    .HasColumnType("ntext")
                    .HasComment("Стэк ошибки");

                entity.Property(e => e.LotId).HasComment("Идентфикатор лота");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'IB')")
                    .HasComment("Система в которой произошла ошибка");

                entity.HasOne(d => d.Bid)
                    .WithMany(p => p.DepositAuctionErrors)
                    .HasForeignKey(d => d.BidId)
                    .HasConstraintName("DepositAuctionError_DepositAuctionBid_Id_fk");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.DepositAuctionErrors)
                    .HasForeignKey(d => d.LotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DepositAuctionError_DepositAuctionLot_Id_fk");
            });

            modelBuilder.Entity<DepositAuctionLot>(entity =>
            {
                entity.ToTable("DepositAuctionLot");

                entity.HasIndex(e => new { e.DepositId, e.DepositAuctionLotStatusId }, "IX_DepositAuctionLot_missing_26014");

                entity.Property(e => e.Id).HasComment("ID записи");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата фактического завершения");

                entity.Property(e => e.AgreementSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма договора");

                entity.Property(e => e.AreLostBidsHandled).HasComment("Флаг обработки проигравших ставок");

                entity.Property(e => e.AuctionDuration).HasComment("Продолжительность жизни лота (дней)");

                entity.Property(e => e.BidStep)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Шаг увеличение стоимости");

                entity.Property(e => e.BlockId).HasComment("Идентфикатор блокировки");

                entity.Property(e => e.BuyerSignDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата подписания документов покупателем");

                entity.Property(e => e.CessionSessionId).HasMaxLength(50);

                entity.Property(e => e.ClientId).HasComment("Идентфикатор клиета");

                entity.Property(e => e.CommissionOfTheBank)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Комиссия банка");

                entity.Property(e => e.ConcessionDepositId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("Идентификатор депозита в учетной системе");

                entity.Property(e => e.DepositAuctionLotStatusId).HasComment("Статус лота");

                entity.Property(e => e.DepositCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата открытия депозита");

                entity.Property(e => e.DepositData)
                    .HasColumnType("ntext")
                    .HasComment("Сериализованная модель депозита");

                entity.Property(e => e.DepositId)
                    .HasMaxLength(40)
                    .HasComment("Идентфикатор депозита");

                entity.Property(e => e.DepositNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Номер депозита");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("EMail")
                    .HasComment("E-mail");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата завершения торгов");

                entity.Property(e => e.FullReward)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма вознагрождения");

                entity.Property(e => e.GosPremDepositId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("Идентификатор депозита для переноса гос премии");

                entity.Property(e => e.Iban)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasComment("Номер счета");

                entity.Property(e => e.IsCreatePayment).HasComment("Признак завершения взаиморасчетов");

                entity.Property(e => e.PerformanceIndicator).HasComment("Оценочный показатель");

                entity.Property(e => e.ProcessId).HasComment("Идентификатор процесса в рамках которого появилась запись");

                entity.Property(e => e.SecurityDeposit)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма гарантийного взноса");

                entity.Property(e => e.SellerSignDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата подписания документов продавцом");

                entity.Property(e => e.SignDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата подписания");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата начала торгов");

                entity.Property(e => e.StartingPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Начальная цена");

                entity.Property(e => e.TotalAccumulations)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма накоплений");

                entity.Property(e => e.TotalAccumulationsOnStart)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма накопления на момент создания лота");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DepositAuctionLots)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionLot_ClientId");

                entity.HasOne(d => d.DepositAuctionLotStatus)
                    .WithMany(p => p.DepositAuctionLots)
                    .HasForeignKey(d => d.DepositAuctionLotStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionLot_DepositAuctionLotStatusId");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.DepositAuctionLots)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionLot_DepositAuctionLotProcess_Id");
            });

            modelBuilder.Entity<DepositAuctionLot2>(entity =>
            {
                entity.ToTable("DepositAuctionLot2");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.AgreementSum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BidStep).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BuyerSignDate).HasColumnType("datetime");

                entity.Property(e => e.CessionSessionId).HasMaxLength(50);

                entity.Property(e => e.CommissionOfTheBank).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConcessionDepositId).HasMaxLength(150);

                entity.Property(e => e.DepositCreateDate).HasColumnType("datetime");

                entity.Property(e => e.DepositData).HasColumnType("ntext");

                entity.Property(e => e.DepositId).HasMaxLength(40);

                entity.Property(e => e.DepositNumber).HasMaxLength(250);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("EMail");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FullReward).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GosPremDepositId).HasMaxLength(150);

                entity.Property(e => e.Iban).HasMaxLength(34);

                entity.Property(e => e.SecurityDeposit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SellerSignDate).HasColumnType("datetime");

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartingPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAccumulations).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAccumulationsOnStart).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DepositAuctionLotHistory>(entity =>
            {
                entity.ToTable("DepositAuctionLotHistory");

                entity.Property(e => e.Id).HasComment("ID записи");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата фактического завершения");

                entity.Property(e => e.AgreementSum)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма договора");

                entity.Property(e => e.AreLostBidsHandled).HasComment("Флаг обработки проигравших ставок");

                entity.Property(e => e.AuctionDuration).HasComment("Продолжительность жизни лота (дней)");

                entity.Property(e => e.BidStep)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Шаг увеличение стоимости");

                entity.Property(e => e.BlockId).HasComment("Идентфикатор блокировки");

                entity.Property(e => e.BuyerSignDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата подписания документов покупателем");

                entity.Property(e => e.ClientId).HasComment("Идентфикатор клиета");

                entity.Property(e => e.CommissionOfTheBank)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Комиссия банка");

                entity.Property(e => e.ConcessionDepositId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("Идентификатор депозита в учетной системе");

                entity.Property(e => e.DepositAuctionLotStatusId).HasComment("Статус лота");

                entity.Property(e => e.DepositCreateDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата открытия депозита");

                entity.Property(e => e.DepositData)
                    .HasColumnType("ntext")
                    .HasComment("Сериализованная модель депозита");

                entity.Property(e => e.DepositId)
                    .HasMaxLength(40)
                    .HasComment("Идентфикатор депозита");

                entity.Property(e => e.DepositNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Номер депозита");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("EMail")
                    .HasComment("E-mail");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата завершения торгов");

                entity.Property(e => e.FullReward)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма вознагрождения");

                entity.Property(e => e.GosPremDepositId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("Идентификатор депозита для переноса гос премии");

                entity.Property(e => e.HistoryDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата создания изменения");

                entity.Property(e => e.Iban)
                    .HasMaxLength(34)
                    .IsUnicode(false)
                    .HasComment("Номер счета");

                entity.Property(e => e.IsCreatePayment).HasComment("Признак завершения взаиморасчетов");

                entity.Property(e => e.LotId).HasComment("Идентфикатор лота");

                entity.Property(e => e.PerformanceIndicator).HasComment("Оценочный показатель");

                entity.Property(e => e.ProcessId).HasComment("Идентификатор процесса в рамках которого появилась запись");

                entity.Property(e => e.SecurityDeposit)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма гарантийного взноса");

                entity.Property(e => e.SellerSignDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата подписания документов продавцом");

                entity.Property(e => e.SignDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата подписания");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата начала торгов");

                entity.Property(e => e.StartingPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Начальная цена");

                entity.Property(e => e.TotalAccumulations)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("Сумма накоплений");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DepositAuctionLotHistories)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionLotHistory_ClientId");

                entity.HasOne(d => d.DepositAuctionLotStatus)
                    .WithMany(p => p.DepositAuctionLotHistories)
                    .HasForeignKey(d => d.DepositAuctionLotStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionLotHistory_DepositAuctionLotStatusId");
            });

            modelBuilder.Entity<DepositAuctionLotProcess>(entity =>
            {
                entity.ToTable("DepositAuctionLotProcess");

                entity.Property(e => e.Id).HasComment("ID записи");

                entity.Property(e => e.ClientId).HasComment("Идентфикатор клиента");

                entity.Property(e => e.Complited).HasComment("Признак завершенности");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.DepositId)
                    .HasMaxLength(40)
                    .HasComment("Идентификатор депозита");

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(50)
                    .HasComment("Наименование процесса");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DepositAuctionLotProcesses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionLotProcess_ClientId");
            });

            modelBuilder.Entity<DepositAuctionLotStage>(entity =>
            {
                entity.ToTable("DepositAuctionLotStage");

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.PostedDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата обработки формы");

                entity.Property(e => e.PostedModel)
                    .HasColumnType("xml")
                    .HasComment("Обрабатываемая модель");

                entity.Property(e => e.ProcessId).HasComment("ID процесса");

                entity.Property(e => e.ShowDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата показа формы");

                entity.Property(e => e.ShowModel)
                    .HasColumnType("xml")
                    .HasComment("Отображаемая модель");

                entity.Property(e => e.StepName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Наименование нага");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.DepositAuctionLotStages)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionLotStage_DepositAuctionLotProcess_Id");
            });

            modelBuilder.Entity<DepositAuctionLotStatus>(entity =>
            {
                entity.ToTable("DepositAuctionLotStatus");

                entity.Property(e => e.Id).HasComment("ID статуса");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasComment("Описание");

                entity.Property(e => e.InProcess).HasComment("Признак процесса");

                entity.Property(e => e.IsCanceled).HasComment("Признак отказа");

                entity.Property(e => e.IsComplited).HasComment("Признак завершения");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasComment("Наименование статуса");
            });

            modelBuilder.Entity<DepositAuctionMail>(entity =>
            {
                entity.ToTable("DepositAuctionMail");

                entity.Property(e => e.Id).HasComment("Идентфикатор записи");

                entity.Property(e => e.Attachment).HasComment("Вложение");

                entity.Property(e => e.AttachmentName)
                    .HasMaxLength(250)
                    .HasComment("Наименовние вложения");

                entity.Property(e => e.Body)
                    .HasColumnType("ntext")
                    .HasComment("Содержимое письма");

                entity.Property(e => e.LotId).HasComment("Идентфикатор лота");

                entity.Property(e => e.SendDate)
                    .HasColumnType("datetime")
                    .HasComment("Дата отправки");

                entity.Property(e => e.SendStatus).HasComment("Статус отправки письма");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasComment("Тема письма");

                entity.Property(e => e.To)
                    .HasMaxLength(250)
                    .HasComment("Кому отправить");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.DepositAuctionMails)
                    .HasForeignKey(d => d.LotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionMail_DepositAuctionLot");
            });

            modelBuilder.Entity<DepositAuctionParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DepositAuctionParameter");

                entity.Property(e => e.BidStep).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SecurityDeposit).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<DepositAuctionPrivetLot>(entity =>
            {
                entity.HasKey(e => new { e.LotId, e.BuyerIin })
                    .HasName("PK__DepositA__3CCC59B494330E73");

                entity.ToTable("DepositAuctionPrivetLot");

                entity.Property(e => e.LotId).HasComment("Идентификатор лота");

                entity.Property(e => e.BuyerIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("ИИН покупателя");

                entity.HasOne(d => d.Lot)
                    .WithMany(p => p.DepositAuctionPrivetLots)
                    .HasForeignKey(d => d.LotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionPrivetLot_DepositAuctionLot");
            });

            modelBuilder.Entity<DepositAuctionWinnerBid>(entity =>
            {
                entity.HasKey(e => e.DepositAuctionLotId);

                entity.ToTable("DepositAuctionWinnerBid");

                entity.HasIndex(e => e.DepositAuctionBidId, "UQ_DepositAuctionWinnerBid_DepositAuctionBidId")
                    .IsUnique();

                entity.Property(e => e.DepositAuctionLotId)
                    .ValueGeneratedNever()
                    .HasComment("Идентификатор лота");

                entity.Property(e => e.DepositAuctionBidId).HasComment("Идентификатор ставки победителя");

                entity.HasOne(d => d.DepositAuctionBid)
                    .WithOne(p => p.DepositAuctionWinnerBid)
                    .HasForeignKey<DepositAuctionWinnerBid>(d => d.DepositAuctionBidId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionWinnerBid_DepositAuctionBidId");

                entity.HasOne(d => d.DepositAuctionLot)
                    .WithOne(p => p.DepositAuctionWinnerBid)
                    .HasForeignKey<DepositAuctionWinnerBid>(d => d.DepositAuctionLotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepositAuctionWinnerBid_DepositAuctionLotId");
            });

            modelBuilder.Entity<DepositCessionFree>(entity =>
            {
                entity.ToTable("DepositCessionFree");

                entity.HasIndex(e => e.DepositId, "IX_DepositCessionFree");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientFromCode).HasMaxLength(100);

                entity.Property(e => e.ClientFromFio).HasMaxLength(100);

                entity.Property(e => e.ClientFromIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClientFromIIN")
                    .IsFixedLength();

                entity.Property(e => e.ClientFromUserId).HasMaxLength(100);

                entity.Property(e => e.ClientToCode).HasMaxLength(100);

                entity.Property(e => e.ClientToFio).HasMaxLength(100);

                entity.Property(e => e.ClientToIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("ClientToIIN")
                    .IsFixedLength();

                entity.Property(e => e.ClientToUserId).HasMaxLength(100);

                entity.Property(e => e.ColvirId).HasMaxLength(100);

                entity.Property(e => e.DepositId).HasMaxLength(100);

                entity.Property(e => e.RelationDegree).HasMaxLength(100);

                entity.Property(e => e.RequestLinkIdFrom).HasMaxLength(100);

                entity.Property(e => e.RequestLinkIdTo).HasMaxLength(100);

                entity.Property(e => e.SuccessCode).HasMaxLength(100);
            });

            modelBuilder.Entity<DepositCessionFreeLog>(entity =>
            {
                entity.ToTable("DepositCessionFreeLog");

                entity.HasIndex(e => e.UserId, "IX_DepositCessionFreeLog");

                entity.HasIndex(e => e.CessionId, "IX_DepositCessionFreeLog_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CallTime).HasColumnName("callTime");

                entity.Property(e => e.CessionId).HasColumnName("cessionId");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.InputParameters).HasColumnName("inputParameters");

                entity.Property(e => e.MethodName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("methodName");

                entity.Property(e => e.ResponseTime).HasColumnName("responseTime");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.ResultCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("resultCode");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("sourceName");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<DepositCessionFreeNotifyText>(entity =>
            {
                entity.ToTable("DepositCessionFreeNotifyText");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("messageCode");

                entity.Property(e => e.MessageTextKaz)
                    .HasMaxLength(2000)
                    .HasColumnName("messageTextKaz");

                entity.Property(e => e.MessageTextRu)
                    .HasMaxLength(2000)
                    .HasColumnName("messageTextRu");
            });

            modelBuilder.Entity<DepositCessionFreeRelation>(entity =>
            {
                entity.ToTable("DepositCessionFreeRelation");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<DepositCessionFreeSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.OperationTimeFinish)
                    .HasColumnType("datetime")
                    .HasColumnName("operationTimeFinish");

                entity.Property(e => e.ServiceEnableDateEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("serviceEnableDateEnd");

                entity.Property(e => e.ServiceEnableDateStart)
                    .HasColumnType("datetime")
                    .HasColumnName("serviceEnableDateStart");
            });

            modelBuilder.Entity<DepositCessionFreeStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode);

                entity.Property(e => e.StatusCode).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.StatusName).HasMaxLength(100);
            });

            modelBuilder.Entity<DepositDivisionUndoTable>(entity =>
            {
                entity.ToTable("DepositDivisionUndoTable");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MainDepositId).HasMaxLength(250);

                entity.Property(e => e.TerminateDepositId).HasMaxLength(250);
            });

            modelBuilder.Entity<DepositOperation>(entity =>
            {
                entity.ToTable("DepositOperation");

                entity.Property(e => e.DepositOperationId)
                    .ValueGeneratedNever()
                    .HasColumnName("depositOperationID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DepositOperationBankId).HasColumnName("depositOperationBankID");

                entity.Property(e => e.DepositOperationData)
                    .HasColumnType("xml")
                    .HasColumnName("depositOperationData");

                entity.Property(e => e.DoType)
                    .HasColumnName("doType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<DepositOperationLink>(entity =>
            {
                entity.ToTable("DepositOperationLink");

                entity.Property(e => e.DepositId)
                    .HasMaxLength(20)
                    .HasColumnName("depositID");

                entity.Property(e => e.DepositOperationId).HasColumnName("depositOperationID");
            });

            modelBuilder.Entity<DepositOperationQuery>(entity =>
            {
                entity.ToTable("DepositOperationQuery");

                entity.Property(e => e.DepositOperationQueryId).HasColumnName("depositOperationQueryID");

                entity.Property(e => e.BankAnswer)
                    .HasMaxLength(1000)
                    .HasColumnName("bankAnswer");

                entity.Property(e => e.BankComment)
                    .HasMaxLength(500)
                    .HasColumnName("bankComment");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.DepositOperationId).HasColumnName("depositOperationID");

                entity.Property(e => e.DoType).HasColumnName("doType");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("sessionID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TokenId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("tokenID");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.XmlData)
                    .HasColumnType("xml")
                    .HasColumnName("xmlData");
            });

            modelBuilder.Entity<DepositOperationStage>(entity =>
            {
                entity.ToTable("DepositOperationStage");

                entity.Property(e => e.DepositOperationStageId).HasColumnName("depositOperationStageID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CurrentStage)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("currentStage");

                entity.Property(e => e.DepositOperationId).HasColumnName("depositOperationID");

                entity.Property(e => e.DepositOperationStageData)
                    .HasColumnType("xml")
                    .HasColumnName("depositOperationStageData");

                entity.Property(e => e.StageNum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("stageNum");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.ToTable("Device");

                entity.HasIndex(e => e.DeviceId, "IX_Device_DeviceId")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.UserId, "IX_Device_missing_25992");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.DateVerified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .HasComment("Идентификатор устройства");

                entity.Property(e => e.FrontEndId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Идентификатор фронта");

                entity.Property(e => e.UserId).HasComment("ID пользователя");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Devices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Passcode_Users");
            });

            modelBuilder.Entity<DeviceInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DeviceInfo");

                entity.HasIndex(e => e.DateCreate, "DeviceDateCreate");

                entity.HasIndex(e => e.DeviceId, "DeviceId");

                entity.Property(e => e.CurrentBuild)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currentBuild");

                entity.Property(e => e.CurrentVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currentVersion");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.Device)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deviceName");

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deviceType");

                entity.Property(e => e.Idiom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idiom");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manufacturer");

                entity.Property(e => e.PlatformName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("platformName");

                entity.Property(e => e.VersionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("versionName");
            });

            modelBuilder.Entity<DeviceTrusted>(entity =>
            {
                entity.ToTable("DeviceTrusted");

                entity.HasIndex(e => new { e.DeviceId, e.UserId }, "IX_DeviceTrusted")
                    .IsUnique();

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Идентификатор устройства");

                entity.Property(e => e.FrontEndId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Идентификатор фронта");

                entity.Property(e => e.UserId).HasComment("ID пользователя");
            });

            modelBuilder.Entity<DeviceTrustedHistory>(entity =>
            {
                entity.ToTable("DeviceTrustedHistory");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Идентификатор устройства");

                entity.Property(e => e.FrontEndId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Идентификатор фронта");

                entity.Property(e => e.UserId).HasComment("ID пользователя");
            });

            modelBuilder.Entity<DeviceTrustedLog>(entity =>
            {
                entity.ToTable("DeviceTrustedLog");

                entity.HasIndex(e => e.UserId, "IX_DeviceTrustedLog");

                entity.HasIndex(e => e.SessionId, "IX_DeviceTrustedLog_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentBuild)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currentBuild");

                entity.Property(e => e.CurrentVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currentVersion");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Device)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deviceName");

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("deviceType");

                entity.Property(e => e.Idiom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idiom");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("manufacturer");

                entity.Property(e => e.PlatformName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("platformName");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");

                entity.Property(e => e.VersionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("versionName");
            });

            modelBuilder.Entity<DeviceTrustedSession>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.DeviceId }, "IX_DeviceTrustedSessions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreate).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sessionId");
            });

            modelBuilder.Entity<DeviceTrustedSetting>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettingValue).HasMaxLength(1000);
            });

            modelBuilder.Entity<DevinoLog>(entity =>
            {
                entity.ToTable("devino_log");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.Number)
                    .HasMaxLength(250)
                    .HasColumnName("number");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("startDate")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("Document");

                entity.HasIndex(e => new { e.RefType, e.Guid }, "IX_Document_missing_25958");

                entity.HasIndex(e => e.RefId, "NonClusteredRefId");

                entity.HasIndex(e => new { e.RefType, e.Ordinal }, "NonClusteredRefTypeOrdinal");

                entity.HasIndex(e => new { e.RefType, e.Ordinal }, "Sanzh1");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.Ext)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Guid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Ordinal).HasDefaultValueSql("((1))");

                entity.Property(e => e.RefType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(500)
                    .HasColumnName("Title_KK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(500)
                    .HasColumnName("Title_RU");
            });

            modelBuilder.Entity<Draft>(entity =>
            {
                entity.ToTable("Draft");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Body).HasColumnType("xml");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EgovRequest>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkId).HasColumnName("linkId");

                entity.Property(e => e.MethodName)
                    .HasMaxLength(250)
                    .HasColumnName("methodName");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.RequestData)
                    .HasColumnType("xml")
                    .HasColumnName("requestData");

                entity.Property(e => e.ResponseData)
                    .HasColumnType("xml")
                    .HasColumnName("responseData");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<EgovRequestService>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrMess)
                    .HasMaxLength(250)
                    .HasColumnName("errMess");

                entity.Property(e => e.RequestId).HasColumnName("requestId");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(100)
                    .HasColumnName("serviceCode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ServiceData)
                    .HasColumnType("xml")
                    .HasColumnName("serviceData");

                entity.Property(e => e.ServiceFileId).HasColumnName("serviceFileId");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(250)
                    .HasColumnName("serviceName");

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(250)
                    .HasColumnName("serviceUrl");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<EgovResponse>(entity =>
            {
                entity.ToTable("EgovResponse");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .HasColumnName("IIN");

                entity.Property(e => e.Phone).HasMaxLength(12);
            });

            modelBuilder.Entity<ExternalSiteCity>(entity =>
            {
                entity.ToTable("ExternalSiteCity");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<FamilyPackage>(entity =>
            {
                entity.ToTable("FamilyPackage");

                entity.HasIndex(e => e.ClientId, "IX_FamilyPackage_missing_25914");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateDeactivated).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("Faq");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Actual)
                    .HasColumnName("actual")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.NameKz)
                    .HasMaxLength(500)
                    .HasColumnName("Name_kz");

                entity.Property(e => e.NameRu)
                    .HasMaxLength(500)
                    .HasColumnName("Name_ru");

                entity.Property(e => e.OrderNum)
                    .HasColumnName("order_num")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.TextKz)
                    .HasColumnType("ntext")
                    .HasColumnName("Text_kz");

                entity.Property(e => e.TextRu)
                    .HasColumnType("ntext")
                    .HasColumnName("Text_ru");
            });

            modelBuilder.Entity<Filial>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .IsClustered(false);

                entity.ToTable("Filial");

                entity.HasIndex(e => e.CbsOblCode, "ClusteredIndex-20180510-101042")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Code, "NonClusteredIndex-20180604-102254")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.CbsOblCode)
                    .HasMaxLength(50)
                    .HasColumnName("cbs_obl_code");

                entity.Property(e => e.CbsOblName)
                    .HasMaxLength(450)
                    .HasColumnName("cbs_obl_name");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Fpdeposit>(entity =>
            {
                entity.ToTable("FPDeposit");

                entity.HasIndex(e => new { e.ClientId, e.Status }, "IX_FPDeposit_missing_25931");

                entity.HasIndex(e => e.Status, "IX_FPDeposit_missing_25935");

                entity.HasIndex(e => new { e.AlterCode, e.Status }, "IX_FPDeposit_missing_32573");

                entity.HasIndex(e => e.FamilyPackageId, "SanzhFamily");

                entity.Property(e => e.AlterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBAN");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relation)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.FamilyPackage)
                    .WithMany(p => p.Fpdeposits)
                    .HasForeignKey(d => d.FamilyPackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FPDeposit_FamilyPackage");

                entity.HasOne(d => d.RelationNavigation)
                    .WithMany(p => p.Fpdeposits)
                    .HasForeignKey(d => d.Relation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FPDeposit_Relation");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Fpdeposits)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FPDeposit_FPDepositStatus");
            });

            modelBuilder.Entity<FpdepositStatus>(entity =>
            {
                entity.ToTable("FPDepositStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MessageToInitiatorKk)
                    .HasMaxLength(500)
                    .HasColumnName("MessageToInitiatorKK");

                entity.Property(e => e.MessageToInitiatorRu)
                    .HasMaxLength(500)
                    .HasColumnName("MessageToInitiatorRU");

                entity.Property(e => e.MessageToIviteeKk)
                    .HasMaxLength(500)
                    .HasColumnName("MessageToIviteeKK");

                entity.Property(e => e.MessageToIviteeRu)
                    .HasMaxLength(500)
                    .HasColumnName("MessageToIviteeRU");
            });

            modelBuilder.Entity<FpdepositStatusLog>(entity =>
            {
                entity.ToTable("FPDepositStatusLog");

                entity.Property(e => e.FpdepositId).HasColumnName("FPDepositId");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Fpdeposit)
                    .WithMany(p => p.FpdepositStatusLogs)
                    .HasForeignKey(d => d.FpdepositId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FPDepositStatusLog_FPDeposit");
            });

            modelBuilder.Entity<FrontEnd>(entity =>
            {
                entity.ToTable("FrontEnd");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Идентификатор фронта");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasComment("Описание");
            });

            modelBuilder.Entity<GetAveragePointsForProcessesAllTimeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetAveragePointsForProcessesAllTimeView");

                entity.Property(e => e.RequestType).HasMaxLength(250);
            });

            modelBuilder.Entity<GetLastRatingsFromClientsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetLastRatingsFromClientsView");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Fio)
                    .HasMaxLength(152)
                    .HasColumnName("FIO");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<GetLog4NetLogAuthLogWithArhView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetLog4NetLog_AuthLogWithArhView");

                entity.Property(e => e.Controller)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GetLog4NetLogCurrAccWithArhView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetLog4NetLog_CurrAccWithArhView");

                entity.Property(e => e.Controller)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GetLogErrorLogWithArhView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetLog_ErrorLogWithArhView");

                entity.Property(e => e.Browser).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorGuid)
                    .HasMaxLength(100)
                    .HasColumnName("errorGuid");

                entity.Property(e => e.ErrorType).HasMaxLength(50);

                entity.Property(e => e.ExComputer).HasMaxLength(250);

                entity.Property(e => e.ExError).HasMaxLength(250);

                entity.Property(e => e.ExMessage).HasMaxLength(250);

                entity.Property(e => e.ExMethod).HasMaxLength(250);

                entity.Property(e => e.ExNamespace).HasMaxLength(250);

                entity.Property(e => e.ExSource).HasMaxLength(250);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ip)
                    .HasMaxLength(250)
                    .HasColumnName("IP");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.Property(e => e.UserLogin).HasMaxLength(50);
            });

            modelBuilder.Entity<HappyFamily>(entity =>
            {
                entity.ToTable("HappyFamily");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdrObl).HasMaxLength(500);

                entity.Property(e => e.AdrReg).HasMaxLength(500);

                entity.Property(e => e.Adress).HasMaxLength(500);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Category).HasMaxLength(1000);

                entity.Property(e => e.Contact).HasMaxLength(500);

                entity.Property(e => e.CrmResponse).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DadName).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .HasColumnName("IIN");

                entity.Property(e => e.Phone).HasMaxLength(12);

                entity.Property(e => e.QueuedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.SendCrmDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategory).HasMaxLength(1000);

                entity.Property(e => e.SurName).HasMaxLength(100);
            });

            modelBuilder.Entity<HappyFamilyCrmInfo>(entity =>
            {
                entity.ToTable("HappyFamily_CRM_INFO");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .HasColumnName("IIN");

                entity.Property(e => e.LastTryDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<Help>(entity =>
            {
                entity.ToTable("Help");

                entity.Property(e => e.Id)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BodyKk).HasColumnName("BodyKK");

                entity.Property(e => e.BodyRu).HasColumnName("BodyRU");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DRFT')")
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");

                entity.Property(e => e.TopicId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Helps)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Help_HelpStatus");

                entity.HasOne(d => d.Topic)
                    .WithMany(p => p.Helps)
                    .HasForeignKey(d => d.TopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Help_HelpTopic");
            });

            modelBuilder.Entity<HelpStatus>(entity =>
            {
                entity.ToTable("HelpStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<HelpTopic>(entity =>
            {
                entity.ToTable("HelpTopic");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("History");

                entity.HasIndex(e => new { e.ActionType, e.Date }, "IX_History_missing_32122");

                entity.HasIndex(e => new { e.UserId, e.ActionName }, "SSCRMHistoryIndex1");

                entity.Property(e => e.HistoryId).HasColumnName("history_id");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .HasColumnName("actionName");

                entity.Property(e => e.ActionType).HasColumnName("actionType");

                entity.Property(e => e.CheaterUserId).HasColumnName("cheaterUser_id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Headurl)
                    .HasMaxLength(300)
                    .HasColumnName("headurl");

                entity.Property(e => e.IpLat)
                    .HasMaxLength(50)
                    .HasColumnName("ip_lat");

                entity.Property(e => e.IpLon)
                    .HasMaxLength(50)
                    .HasColumnName("ip_lon");

                entity.Property(e => e.IpRegionName)
                    .HasMaxLength(200)
                    .HasColumnName("ip_region_name");

                entity.Property(e => e.Link)
                    .HasMaxLength(300)
                    .HasColumnName("link");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectInfo)
                    .HasColumnType("ntext")
                    .HasColumnName("objectInfo");

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(100)
                    .HasColumnName("objectType");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("userIp");
            });

            modelBuilder.Entity<HistoryAction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HistoryActions");

                entity.Property(e => e.ActionType).HasColumnName("actionType");

                entity.Property(e => e.ActionTypeName)
                    .HasMaxLength(250)
                    .HasColumnName("actionTypeName");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.Data)
                    .HasColumnType("datetime")
                    .HasColumnName("data");

                entity.Property(e => e.Dep)
                    .HasMaxLength(50)
                    .HasColumnName("dep");

                entity.Property(e => e.SystemName).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("userIp");
            });

            modelBuilder.Entity<HistoryActionType>(entity =>
            {
                entity.ToTable("HistoryActionType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasColumnName("code");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<HistoryActionsByDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HistoryActionsByDate");

                entity.Property(e => e.ActionName).HasMaxLength(250);

                entity.Property(e => e.ActionType).HasColumnName("actionType");

                entity.Property(e => e.Counttt).HasColumnName("counttt");

                entity.Property(e => e.Datestr)
                    .HasColumnType("datetime")
                    .HasColumnName("datestr");
            });

            modelBuilder.Entity<HistoryOld>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK_History");

                entity.ToTable("HistoryOld");

                entity.HasIndex(e => new { e.UserId, e.ActionName }, "SSCRMHistoryIndex");

                entity.Property(e => e.HistoryId).HasColumnName("history_id");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .HasColumnName("actionName");

                entity.Property(e => e.ActionType).HasColumnName("actionType");

                entity.Property(e => e.CheaterUserId).HasColumnName("cheaterUser_id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Headurl)
                    .HasMaxLength(300)
                    .HasColumnName("headurl");

                entity.Property(e => e.IpLat)
                    .HasMaxLength(50)
                    .HasColumnName("ip_lat");

                entity.Property(e => e.IpLon)
                    .HasMaxLength(50)
                    .HasColumnName("ip_lon");

                entity.Property(e => e.IpRegionName)
                    .HasMaxLength(200)
                    .HasColumnName("ip_region_name");

                entity.Property(e => e.Link)
                    .HasMaxLength(300)
                    .HasColumnName("link");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ObjectInfo)
                    .HasColumnType("ntext")
                    .HasColumnName("objectInfo");

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(100)
                    .HasColumnName("objectType");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("userIp");
            });

            modelBuilder.Entity<HsTransactionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HS_TRANSACTION_LOG", "HS_RECOVERY");

                entity.Property(e => e.GlobalTranId)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("GLOBAL_TRAN_ID")
                    .IsFixedLength();

                entity.Property(e => e.TranComment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TRAN_COMMENT")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Illustration>(entity =>
            {
                entity.ToTable("Illustration");

                entity.HasIndex(e => e.RefId, "IX_Illustration_missing_31706");

                entity.HasIndex(e => new { e.RefType, e.RefId, e.Size, e.Priority }, "UK_Illustration")
                    .IsUnique();

                entity.Property(e => e.Ext)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RefType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfobipToken>(entity =>
            {
                entity.ToTable("InfobipToken");

                entity.HasIndex(e => e.Token, "IX_InfobipToken_missing_25960");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NEWW')")
                    .IsFixedLength();

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfobipTokenHistory>(entity =>
            {
                entity.ToTable("InfobipTokenHistory");

                entity.Property(e => e.Changed)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InstructionLog>(entity =>
            {
                entity.Property(e => e.Comment).HasMaxLength(100);

                entity.Property(e => e.Folder).HasMaxLength(100);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.Operation).HasMaxLength(20);
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("Insurance");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoanId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SendDataXml).HasColumnType("xml");

                entity.Property(e => e.Status)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Xml).HasColumnType("xml");
            });

            modelBuilder.Entity<InsuranceContract>(entity =>
            {
                entity.ToTable("InsuranceContract");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Bic)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Bin)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.ContractNo).HasMaxLength(50);

                entity.Property(e => e.CustomerIban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Iban)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kbe)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Premium).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SendDataInsurId).HasMaxLength(50);

                entity.Property(e => e.TransferDesc).HasMaxLength(500);

                entity.Property(e => e.TransferReference)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InsuranceLog>(entity =>
            {
                entity.ToTable("InsuranceLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogProcessId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InsuranceProcess>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.ToTable("InsuranceProcess");

                entity.Property(e => e.Attempt).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateInsuranceAgreementDateP).HasColumnType("datetime");

                entity.Property(e => e.CreateInsuranceAgreementDateT).HasColumnType("datetime");

                entity.Property(e => e.CreateInsuranceAgreementP).HasColumnType("text");

                entity.Property(e => e.CreateInsuranceAgreementT).HasColumnType("text");

                entity.Property(e => e.LogProcessId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.PaymentDateP).HasColumnType("datetime");

                entity.Property(e => e.PaymentDateT).HasColumnType("datetime");

                entity.Property(e => e.PaymentReferenceP).HasMaxLength(50);

                entity.Property(e => e.PaymentReferenceT).HasMaxLength(50);

                entity.Property(e => e.ResultPaymentCodeP).HasMaxLength(30);

                entity.Property(e => e.ResultPaymentCodeT).HasMaxLength(30);

                entity.Property(e => e.SendDataDate).HasColumnType("datetime");

                entity.Property(e => e.SendDataResult).HasColumnType("xml");

                entity.Property(e => e.SendFileDateP).HasColumnType("datetime");

                entity.Property(e => e.SendFileDateT).HasColumnType("datetime");

                entity.Property(e => e.SendFileResultP).HasColumnType("text");

                entity.Property(e => e.SendFileResultT).HasColumnType("text");
            });

            modelBuilder.Entity<InsuranceStatus>(entity =>
            {
                entity.ToTable("InsuranceStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(50)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(50)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<InvitationNotification>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("InvitationNotification_pk")
                    .IsClustered(false);

                entity.ToTable("InvitationNotification");

                entity.HasIndex(e => e.ClientNotificationId, "IX_InvitationNotification_ClientNotificationId");

                entity.Property(e => e.FpdepositId).HasColumnName("FPDepositId");

                entity.HasOne(d => d.Fpdeposit)
                    .WithMany(p => p.InvitationNotifications)
                    .HasForeignKey(d => d.FpdepositId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvitationNotification_FPDeposit");
            });

            modelBuilder.Entity<Kbe>(entity =>
            {
                entity.ToTable("KBe");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(50)
                    .HasColumnName("Title_KK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(50)
                    .HasColumnName("Title_RU");
            });

            modelBuilder.Entity<KnowledgeBase>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KnowledgeBase");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.KnowledgeBaseId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<KnowledgeBaseCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KnowledgeBaseCategory");

                entity.Property(e => e.CategoryName).HasMaxLength(300);

                entity.Property(e => e.KnowledgeBaseCategoryId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<KnowledgeBaseFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KnowledgeBaseFile");

                entity.Property(e => e.FileName).HasMaxLength(300);

                entity.Property(e => e.KnowledgeBaseFileId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<KnowledgeBaseParentCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KnowledgeBaseParentCategory");

                entity.Property(e => e.KnowledgeBaseParentCategoryId).ValueGeneratedOnAdd();

                entity.Property(e => e.ParentCategoryName).HasMaxLength(300);
            });

            modelBuilder.Entity<KnowledgeBaseTag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KnowledgeBaseTag");

                entity.Property(e => e.KnowledgeBaseTagId).ValueGeneratedOnAdd();

                entity.Property(e => e.TagName).HasMaxLength(300);
            });

            modelBuilder.Entity<KnowledgeBaseTagConnect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KnowledgeBaseTagConnect");

                entity.Property(e => e.KnowledgeBaseTagConnectId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Knp>(entity =>
            {
                entity.ToTable("Knp");

                entity.Property(e => e.Id)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<ListClientNotMobileApp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ListClientNotMobileApp");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .HasColumnName("userLogin");
            });

            modelBuilder.Entity<LoanStatus>(entity =>
            {
                entity.ToTable("LoanStatus");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsPositive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<LoanTechStatus>(entity =>
            {
                entity.ToTable("LoanTechStatus");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.HasOne(d => d.LoanStatus)
                    .WithMany(p => p.LoanTechStatuses)
                    .HasForeignKey(d => d.LoanStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LoanTechStatus_LoanStatus");
            });

            modelBuilder.Entity<Log4NetLog>(entity =>
            {
                entity.ToTable("Log4NetLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogProcessId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log4NetLogAdminGlobalExceptionLog>(entity =>
            {
                entity.ToTable("Log4NetLog_AdminGlobalExceptionLogs");

                entity.Property(e => e.Controller)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExInnerMessage).HasMaxLength(4000);

                entity.Property(e => e.ExStackTrace).HasMaxLength(4000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log4NetLogAuthLog>(entity =>
            {
                entity.ToTable("Log4NetLog_AuthLog");

                entity.Property(e => e.Controller)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log4NetLogAuthLogArh>(entity =>
            {
                entity.ToTable("Log4NetLog_AuthLog_arh");

                entity.Property(e => e.Controller)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log4NetLogCurAcc>(entity =>
            {
                entity.ToTable("Log4NetLog_CurAcc");

                entity.Property(e => e.Controller)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log4NetLogCurAccArh>(entity =>
            {
                entity.ToTable("Log4NetLog_CurAcc_arh");

                entity.Property(e => e.Controller)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Log4NetLogPnserviceLog>(entity =>
            {
                entity.ToTable("Log4NetLog_PNServiceLog");

                entity.Property(e => e.Controller)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ExInnerMessage).HasMaxLength(4000);

                entity.Property(e => e.ExStackTrace).HasMaxLength(4000);

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasMaxLength(4000);

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Userlogin)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogClientEnrollment>(entity =>
            {
                entity.ToTable("log_client_enrollment");

                entity.HasIndex(e => e.Date, "index_log_client_enrollment_Date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception).HasMaxLength(4000);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Line)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogErrorInfo>(entity =>
            {
                entity.ToTable("log_error_info");

                entity.HasIndex(e => e.ErrorGuid, "GUID")
                    .IsUnique();

                entity.HasIndex(e => e.UserLogin, "NonClusteredIndex-20200614-183306");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Browser).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorGuid)
                    .HasMaxLength(100)
                    .HasColumnName("errorGuid");

                entity.Property(e => e.ErrorType).HasMaxLength(50);

                entity.Property(e => e.ExComputer).HasMaxLength(250);

                entity.Property(e => e.ExError).HasMaxLength(250);

                entity.Property(e => e.ExMessage).HasMaxLength(250);

                entity.Property(e => e.ExMethod).HasMaxLength(250);

                entity.Property(e => e.ExNamespace).HasMaxLength(250);

                entity.Property(e => e.ExSource).HasMaxLength(250);

                entity.Property(e => e.Ip)
                    .HasMaxLength(250)
                    .HasColumnName("IP");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.Property(e => e.UserLogin).HasMaxLength(50);
            });

            modelBuilder.Entity<LogErrorInfoArh>(entity =>
            {
                entity.ToTable("log_error_info_arh");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Browser).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorGuid)
                    .HasMaxLength(100)
                    .HasColumnName("errorGuid");

                entity.Property(e => e.ErrorType).HasMaxLength(50);

                entity.Property(e => e.ExComputer).HasMaxLength(250);

                entity.Property(e => e.ExError).HasMaxLength(250);

                entity.Property(e => e.ExMessage).HasMaxLength(250);

                entity.Property(e => e.ExMethod).HasMaxLength(250);

                entity.Property(e => e.ExNamespace).HasMaxLength(250);

                entity.Property(e => e.ExSource).HasMaxLength(250);

                entity.Property(e => e.Ip)
                    .HasMaxLength(250)
                    .HasColumnName("IP");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.Property(e => e.UserLogin).HasMaxLength(50);
            });

            modelBuilder.Entity<LogErrorInfoOld>(entity =>
            {
                entity.ToTable("log_error_info_old");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Browser).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorGuid)
                    .HasMaxLength(100)
                    .HasColumnName("errorGuid");

                entity.Property(e => e.ErrorType).HasMaxLength(50);

                entity.Property(e => e.ExComputer).HasMaxLength(250);

                entity.Property(e => e.ExError).HasMaxLength(250);

                entity.Property(e => e.ExMessage).HasMaxLength(250);

                entity.Property(e => e.ExMethod).HasMaxLength(250);

                entity.Property(e => e.ExNamespace).HasMaxLength(250);

                entity.Property(e => e.ExSource).HasMaxLength(250);

                entity.Property(e => e.Ip)
                    .HasMaxLength(250)
                    .HasColumnName("IP");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.Property(e => e.UserLogin).HasMaxLength(50);
            });

            modelBuilder.Entity<LogMobileErrorInfo>(entity =>
            {
                entity.ToTable("log_mobile_error_info");

                entity.HasIndex(e => e.CreateDate, "index_log_mobile_error_info_CreateDate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Browser).HasMaxLength(20);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorGuid)
                    .HasMaxLength(100)
                    .HasColumnName("errorGuid");

                entity.Property(e => e.ErrorType).HasMaxLength(50);

                entity.Property(e => e.ExComputer).HasMaxLength(250);

                entity.Property(e => e.ExError).HasMaxLength(4000);

                entity.Property(e => e.ExMessage).HasMaxLength(4000);

                entity.Property(e => e.ExMethod).HasMaxLength(250);

                entity.Property(e => e.ExNamespace).HasMaxLength(250);

                entity.Property(e => e.ExSource).HasMaxLength(250);

                entity.Property(e => e.Ip)
                    .HasMaxLength(250)
                    .HasColumnName("IP");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .HasColumnName("URL");

                entity.Property(e => e.UserLogin).HasMaxLength(50);
            });

            modelBuilder.Entity<LogMobileErrorInfoRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log_mobile_error_info_request");

                entity.HasIndex(e => e.CreateDate, "index_log_mobile_error_info_request_CreateDate");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Guid).HasMaxLength(100);
            });

            modelBuilder.Entity<LogMobileErrorNotifyEmail>(entity =>
            {
                entity.ToTable("log_mobile_error_notify_email");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErrorId).HasColumnName("error_id");

                entity.Property(e => e.IsUsed)
                    .HasColumnName("is_used")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Error)
                    .WithMany(p => p.LogMobileErrorNotifyEmails)
                    .HasForeignKey(d => d.ErrorId)
                    .HasConstraintName("FK_mobile_error_notify_email_mobile_error_info");
            });

            modelBuilder.Entity<LogOtpStageEnrollment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogOtpStageEnrollment");

                entity.HasIndex(e => new { e.CrmResult, e.CreateDate }, "IX_LogOtpStageEnrollment_missing_12954");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ClientIIN");

                entity.Property(e => e.ClientLogin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CrmResult).HasMaxLength(50);

                entity.Property(e => e.Operation)
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogOtpStageEnrollmentCrm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogOtpStageEnrollmentCRM");

                entity.Property(e => e.CaseOrigin).HasMaxLength(50);

                entity.Property(e => e.CrmRequestDate).HasColumnType("datetime");

                entity.Property(e => e.CrmResult).HasMaxLength(50);

                entity.Property(e => e.CrmresponseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CRMResponseDate");

                entity.Property(e => e.DopInfo).HasMaxLength(50);

                entity.Property(e => e.Fam)
                    .HasMaxLength(50)
                    .HasColumnName("FAM");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .HasColumnName("IIN");

                entity.Property(e => e.MobilePhone).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("NAME");

                entity.Property(e => e.Otch)
                    .HasMaxLength(50)
                    .HasColumnName("OTCH");
            });

            modelBuilder.Entity<LogService>(entity =>
            {
                entity.ToTable("log_service");

                entity.HasIndex(e => e.Date, "index_log_service_Date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception).HasMaxLength(4000);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Line)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogSoapEnvelope>(entity =>
            {
                entity.ToTable("LogSoapEnvelope");

                entity.HasIndex(e => e.RequestDt, "NonClusteredIndex-20210826-161559");

                entity.Property(e => e.Action)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResponseDt).HasColumnType("datetime");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'IB')");

                entity.Property(e => e.UserLogin).HasMaxLength(50);
            });

            modelBuilder.Entity<LogSoapEnvelopeArh>(entity =>
            {
                entity.ToTable("LogSoapEnvelope_arh");

                entity.Property(e => e.Action)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResponseDt).HasColumnType("datetime");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'IB')");

                entity.Property(e => e.UserLogin).HasMaxLength(50);
            });

            modelBuilder.Entity<LogSoapEnvelopeOldTemp>(entity =>
            {
                entity.ToTable("LogSoapEnvelope_old_temp");

                entity.Property(e => e.Action)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResponseDt).HasColumnType("datetime");

                entity.Property(e => e.SystemName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'IB')");
            });

            modelBuilder.Entity<LogSystem>(entity =>
            {
                entity.ToTable("log_system");

                entity.HasIndex(e => e.Date, "index_log_system_Date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception).HasMaxLength(4000);

                entity.Property(e => e.Level)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Line)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Method)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogsInfo>(entity =>
            {
                entity.ToTable("LogsInfo");

                entity.Property(e => e.SendingDate).HasColumnType("datetime");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<LongOrder>(entity =>
            {
                entity.ToTable("LongOrder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BenAccountCode)
                    .HasMaxLength(50)
                    .HasColumnName("benAccountCode");

                entity.Property(e => e.BenClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("benClientCode");

                entity.Property(e => e.CheckComment).HasColumnName("checkComment");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("checkDate");

                entity.Property(e => e.CheckUserLogin)
                    .HasMaxLength(50)
                    .HasColumnName("checkUserLogin");

                entity.Property(e => e.ColverId)
                    .HasMaxLength(20)
                    .HasColumnName("Colver_id");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("dateFrom");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("dateTo");

                entity.Property(e => e.DepId).HasColumnName("depId");

                entity.Property(e => e.Guid).HasColumnName("guid");

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("insertDateTime");

                entity.Property(e => e.Kbe)
                    .HasMaxLength(15)
                    .HasColumnName("kbe");

                entity.Property(e => e.Knp)
                    .HasMaxLength(15)
                    .HasColumnName("knp");

                entity.Property(e => e.Kod)
                    .HasMaxLength(15)
                    .HasColumnName("kod");

                entity.Property(e => e.OrderTypeId).HasColumnName("orderTypeId");

                entity.Property(e => e.ParsId).HasColumnName("parsId");

                entity.Property(e => e.PayDay).HasColumnName("payDay");

                entity.Property(e => e.PurposeText).HasColumnName("purposeText");

                entity.Property(e => e.PurposeType).HasColumnName("purposeType");

                entity.Property(e => e.ReceiverIin)
                    .HasMaxLength(12)
                    .HasColumnName("receiverIIN");

                entity.Property(e => e.ReceiverName)
                    .HasMaxLength(100)
                    .HasColumnName("receiverName");

                entity.Property(e => e.SenderFio)
                    .HasMaxLength(100)
                    .HasColumnName("senderFIO");

                entity.Property(e => e.SenderIin)
                    .HasMaxLength(12)
                    .HasColumnName("senderIIn");

                entity.Property(e => e.SpecAccountCode)
                    .HasMaxLength(50)
                    .HasColumnName("specAccountCode");

                entity.Property(e => e.StatementNumber)
                    .HasMaxLength(50)
                    .HasColumnName("statementNumber");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.UpdateDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("updateDateTime");
            });

            modelBuilder.Entity<LongOrder2>(entity =>
            {
                entity.ToTable("LongOrder2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BenAccountCode)
                    .HasMaxLength(50)
                    .HasColumnName("benAccountCode");

                entity.Property(e => e.BenClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("benClientCode");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("dateFrom");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("dateTo");

                entity.Property(e => e.DepId).HasColumnName("depId");

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("insertDateTime");

                entity.Property(e => e.Kbe)
                    .HasMaxLength(15)
                    .HasColumnName("kbe");

                entity.Property(e => e.Knp)
                    .HasMaxLength(15)
                    .HasColumnName("knp");

                entity.Property(e => e.Kod)
                    .HasMaxLength(15)
                    .HasColumnName("kod");

                entity.Property(e => e.OrderTypeId).HasColumnName("orderTypeId");

                entity.Property(e => e.ParsId).HasColumnName("parsId");

                entity.Property(e => e.PayDay).HasColumnName("payDay");

                entity.Property(e => e.PurposeText).HasColumnName("purposeText");

                entity.Property(e => e.PurposeType).HasColumnName("purposeType");

                entity.Property(e => e.ReceiverIin)
                    .HasMaxLength(12)
                    .HasColumnName("receiverIIN");

                entity.Property(e => e.ReceiverName)
                    .HasMaxLength(100)
                    .HasColumnName("receiverName");

                entity.Property(e => e.SenderIin)
                    .HasMaxLength(12)
                    .HasColumnName("senderIIn");

                entity.Property(e => e.SpecAccountCode)
                    .HasMaxLength(50)
                    .HasColumnName("specAccountCode");

                entity.Property(e => e.StatementNumber)
                    .HasMaxLength(50)
                    .HasColumnName("statementNumber");

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .HasColumnName("token");

                entity.HasOne(d => d.OrderType)
                    .WithMany(p => p.LongOrder2s)
                    .HasForeignKey(d => d.OrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LongOrder_LongOrderType2");

                entity.HasOne(d => d.PurposeTypeNavigation)
                    .WithMany(p => p.LongOrder2s)
                    .HasForeignKey(d => d.PurposeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LongOrder_LongOrderPurpose2");
            });

            modelBuilder.Entity<LongOrderAgrPar>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<LongOrderCheck2>(entity =>
            {
                entity.ToTable("LongOrderCheck2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("datetime")
                    .HasColumnName("checkDate");

                entity.Property(e => e.ColverId)
                    .HasMaxLength(20)
                    .HasColumnName("Colver_id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .HasColumnName("comment");

                entity.Property(e => e.LongOrderId).HasColumnName("longOrderId");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.LongOrder)
                    .WithMany(p => p.LongOrderCheck2s)
                    .HasForeignKey(d => d.LongOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LongOrderCheck_LongOrder");
            });

            modelBuilder.Entity<LongOrderFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.File).HasColumnName("file");

                entity.Property(e => e.FileContentType)
                    .HasMaxLength(50)
                    .HasColumnName("fileContentType");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .HasColumnName("fileName");

                entity.Property(e => e.LongOrderId).HasColumnName("longOrderId");

                entity.HasOne(d => d.LongOrder)
                    .WithMany(p => p.LongOrderFiles)
                    .HasForeignKey(d => d.LongOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LongOrderFiles_LongOrder");
            });

            modelBuilder.Entity<LongOrderFiles2>(entity =>
            {
                entity.ToTable("LongOrderFiles2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.File).HasColumnName("file");

                entity.Property(e => e.FileContentType)
                    .HasMaxLength(50)
                    .HasColumnName("fileContentType");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .HasColumnName("fileName");

                entity.Property(e => e.LongOrderId).HasColumnName("longOrderId");

                entity.HasOne(d => d.LongOrder)
                    .WithMany(p => p.LongOrderFiles2s)
                    .HasForeignKey(d => d.LongOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LongOrderFiles_LongOrder2");
            });

            modelBuilder.Entity<LongOrderPurpose>(entity =>
            {
                entity.ToTable("LongOrderPurpose");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<LongOrderSmslog>(entity =>
            {
                entity.ToTable("LongOrderSMSLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientPhone)
                    .HasMaxLength(50)
                    .HasColumnName("clientPhone");

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("insertDateTime");

                entity.Property(e => e.LongOrderGuid).HasColumnName("longOrderGuid");

                entity.Property(e => e.Response).HasColumnName("response");

                entity.Property(e => e.Text)
                    .HasMaxLength(500)
                    .HasColumnName("text");
            });

            modelBuilder.Entity<LongOrderSmslog2>(entity =>
            {
                entity.ToTable("LongOrderSMSLog2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .HasColumnName("clientIIN");

                entity.Property(e => e.ClientPhone)
                    .HasMaxLength(50)
                    .HasColumnName("clientPhone");

                entity.Property(e => e.InsertDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("insertDateTime");

                entity.Property(e => e.Response).HasColumnName("response");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<LongOrderStatus>(entity =>
            {
                entity.ToTable("LongOrderStatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionKz)
                    .HasMaxLength(200)
                    .HasColumnName("descriptionKZ");
            });

            modelBuilder.Entity<LongOrderType>(entity =>
            {
                entity.ToTable("LongOrderType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<LotStageProcessDeleted>(entity =>
            {
                entity.ToTable("LotStageProcessDeleted");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Complited).HasComment("Признак завершенности");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepositId)
                    .HasMaxLength(40)
                    .HasComment("Идентификатор депозита");

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(50)
                    .HasComment("Наименование процесса");
            });

            modelBuilder.Entity<MapKnpTransferType>(entity =>
            {
                entity.HasKey(e => new { e.KnpId, e.TransferTypeId });

                entity.ToTable("MapKnpTransferType");

                entity.Property(e => e.KnpId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransferTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Knp)
                    .WithMany(p => p.MapKnpTransferTypes)
                    .HasForeignKey(d => d.KnpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MapKnpTransferType_Knp");

                entity.HasOne(d => d.TransferType)
                    .WithMany(p => p.MapKnpTransferTypes)
                    .HasForeignKey(d => d.TransferTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MapKnpTransferType_TransferType");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<MilitaryExcludeUser>(entity =>
            {
                entity.Property(e => e.Fio)
                    .HasMaxLength(100)
                    .HasColumnName("FIO");

                entity.Property(e => e.Iin)
                    .HasMaxLength(20)
                    .HasColumnName("IIN");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<MilitaryHoldOverUser>(entity =>
            {
                entity.Property(e => e.Fio)
                    .HasMaxLength(100)
                    .HasColumnName("FIO");

                entity.Property(e => e.Iin)
                    .HasMaxLength(20)
                    .HasColumnName("IIN");
            });

            modelBuilder.Entity<MioErrorLog>(entity =>
            {
                entity.ToTable("MioErrorLog");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .HasColumnName("IIN");

                entity.Property(e => e.Method).HasMaxLength(50);
            });

            modelBuilder.Entity<MobileInterfaceLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Mobile Interface Language");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserLanguage)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("userLanguage");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .HasColumnName("userLogin");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module");

                entity.Property(e => e.ModuleId).HasColumnName("moduleId");

                entity.Property(e => e.Name).HasMaxLength(80);
            });

            modelBuilder.Entity<ModuleAction>(entity =>
            {
                entity.ToTable("ModuleAction");

                entity.Property(e => e.ModuleActionId).HasColumnName("moduleActionId");

                entity.Property(e => e.MethodType)
                    .HasMaxLength(100)
                    .HasColumnName("methodType")
                    .HasDefaultValueSql("(N'ActionResult')");

                entity.Property(e => e.ModuleId).HasColumnName("moduleId");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ModuleActions)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModuleAction_Module");
            });

            modelBuilder.Entity<MyDocumentsMenu>(entity =>
            {
                entity.ToTable("MyDocumentsMenu");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BackId).HasColumnName("backId");

                entity.Property(e => e.CntNewFiles).HasColumnName("cntNewFiles");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.FileTypeId).HasColumnName("fileTypeId");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(100)
                    .HasColumnName("itemName");

                entity.Property(e => e.ItemNameKaz)
                    .HasMaxLength(100)
                    .HasColumnName("itemNameKaz");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .HasColumnName("itemType");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.Property(e => e.Title)
                    .HasMaxLength(75)
                    .HasColumnName("title");

                entity.Property(e => e.TitleKaz)
                    .HasMaxLength(75)
                    .HasColumnName("titleKaz");
            });

            modelBuilder.Entity<MyDocumentsMenuReadFile>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_MyDocumentsMenuReadFiles");

                entity.HasIndex(e => e.UserFileId, "IX_MyDocumentsMenuReadFiles_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FileTableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.BodyKk).HasColumnName("BodyKK");

                entity.Property(e => e.BodyRu).HasColumnName("BodyRU");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DRFT')")
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_News_NewsStatus");
            });

            modelBuilder.Entity<NewsStatus>(entity =>
            {
                entity.ToTable("NewsStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.BodyKk).HasColumnName("BodyKK");

                entity.Property(e => e.BodyRu).HasColumnName("BodyRU");

                entity.Property(e => e.CategoryId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MediaSourceRef)
                    .HasColumnType("text")
                    .HasColumnName("mediaSourceRef");

                entity.Property(e => e.MediaSourceRefKk)
                    .HasColumnType("text")
                    .HasColumnName("mediaSourceRefKK");

                entity.Property(e => e.MediaSourceType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mediaSourceType");

                entity.Property(e => e.OperationType).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DRFT')")
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('INFO')")
                    .IsFixedLength();

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_NotificationStatus");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_NotificationType");
            });

            modelBuilder.Entity<NotificationArchive>(entity =>
            {
                entity.ToTable("NotificationArchive");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BodyKk).HasColumnName("BodyKK");

                entity.Property(e => e.BodyRu).HasColumnName("BodyRU");

                entity.Property(e => e.CategoryId).HasDefaultValueSql("((0))");

                entity.Property(e => e.MediaSourceRef)
                    .HasColumnType("text")
                    .HasColumnName("mediaSourceRef");

                entity.Property(e => e.MediaSourceType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mediaSourceType");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DRFT')")
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('INFO')")
                    .IsFixedLength();

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.NotificationArchives)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationArchive_NotificationStatus");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.NotificationArchives)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationArchive_NotificationType");
            });

            modelBuilder.Entity<NotificationCategory>(entity =>
            {
                entity.ToTable("NotificationCategory");

                entity.HasIndex(e => e.CrmId, "UQ__Notifica__FB4272A932DDF43C")
                    .IsUnique();

                entity.Property(e => e.Actual)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CrmId).HasMaxLength(100);

                entity.Property(e => e.DarkModeBg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DarkModeBG")
                    .HasDefaultValueSql("('#f6b73c')");

                entity.Property(e => e.LightModeBg)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LightModeBG")
                    .HasDefaultValueSql("('#00969A')");

                entity.Property(e => e.NameKk)
                    .HasMaxLength(100)
                    .HasColumnName("NameKK");

                entity.Property(e => e.NameRu)
                    .HasMaxLength(100)
                    .HasColumnName("NameRU");

                entity.Property(e => e.Ord).HasColumnName("ord");
            });

            modelBuilder.Entity<NotificationOperationRoute>(entity =>
            {
                entity.HasKey(e => new { e.OperationType, e.Platform });

                entity.Property(e => e.Platform).HasMaxLength(10);

                entity.Property(e => e.ButtonNameKk)
                    .HasMaxLength(100)
                    .HasColumnName("ButtonNameKK");

                entity.Property(e => e.ButtonNameRu)
                    .HasMaxLength(100)
                    .HasColumnName("ButtonNameRU");

                entity.Property(e => e.Route).HasMaxLength(100);
            });

            modelBuilder.Entity<NotificationStatus>(entity =>
            {
                entity.ToTable("NotificationStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(50)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(50)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.ToTable("NotificationType");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(50)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(50)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<OperBlock>(entity =>
            {
                entity.ToTable("OperBlock");

                entity.HasIndex(e => e.OperCode, "UQ__OperBloc__67DBE8B907765820")
                    .IsUnique();

                entity.Property(e => e.OperBlockId).HasColumnName("operBlockId");

                entity.Property(e => e.ChangeAuthor)
                    .HasMaxLength(900)
                    .HasColumnName("changeAuthor");

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("changeDate");

                entity.Property(e => e.CreateAuthor)
                    .HasMaxLength(900)
                    .HasColumnName("createAuthor");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("createDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsShowMessage)
                    .HasColumnName("isShowMessage")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MessageKk).HasColumnName("messageKK");

                entity.Property(e => e.MessageRu).HasColumnName("messageRU");

                entity.Property(e => e.OperCode)
                    .HasMaxLength(70)
                    .HasColumnName("operCode");

                entity.Property(e => e.OperName)
                    .HasMaxLength(50)
                    .HasColumnName("operName");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OtpCode>(entity =>
            {
                entity.ToTable("OTP_Code");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OtpCode1).HasColumnName("OTP_code");

                entity.Property(e => e.PhoneNumber).HasMaxLength(1000);
            });

            modelBuilder.Entity<P51020>(entity =>
            {
                entity.ToTable("P51020");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdrObl).HasMaxLength(500);

                entity.Property(e => e.AdrReg).HasMaxLength(500);

                entity.Property(e => e.Adress).HasMaxLength(500);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Category).HasMaxLength(1000);

                entity.Property(e => e.Contact).HasMaxLength(500);

                entity.Property(e => e.DadName).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .HasColumnName("IIN");

                entity.Property(e => e.Phone).HasMaxLength(12);

                entity.Property(e => e.QueuedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.SubCategory).HasMaxLength(1000);

                entity.Property(e => e.SurName).HasMaxLength(100);
            });

            modelBuilder.Entity<P51020CrmInfo>(entity =>
            {
                entity.ToTable("P51020_CRM_INFO");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Iin)
                    .HasMaxLength(12)
                    .HasColumnName("IIN");

                entity.Property(e => e.LastTryDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<Passcode>(entity =>
            {
                entity.ToTable("Passcode");

                entity.HasIndex(e => e.DeviceId, "NonClusteredDeviceId");

                entity.Property(e => e.Id).HasComment("Идентификатор записи");

                entity.Property(e => e.DateCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Дата создания");

                entity.Property(e => e.DeviceId).HasComment("Идентификатор устройства");

                entity.Property(e => e.Hash)
                    .HasMaxLength(256)
                    .HasComment("Хэш кода");

                entity.Property(e => e.PasscodeStatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasComment("Статус кода");

                entity.Property(e => e.Salt).HasComment("Соль");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Passcodes)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Passcode_Device");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Personal");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .HasColumnName("fname");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .HasColumnName("position");

                entity.Property(e => e.Sname)
                    .HasMaxLength(50)
                    .HasColumnName("sname");
            });

            modelBuilder.Entity<PersonalLoginLog>(entity =>
            {
                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PnOneOffUrl>(entity =>
            {
                entity.HasKey(e => e.UrlGuid);

                entity.ToTable("PN_OneOffUrl");

                entity.Property(e => e.UrlGuid)
                    .ValueGeneratedNever()
                    .HasColumnName("urlGuid");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TokenId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("tokenId");

                entity.Property(e => e.UrlType).HasColumnName("urlType");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<PnToken>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("PN_Token");

                entity.HasIndex(e => e.TokenId, "NonClusteredIndex-20200412-105726");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("userId");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.TokenId)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("tokenId");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<Postdeposit>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Postdeposit");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AcceptOtp).HasColumnName("AcceptOTP");

                entity.Property(e => e.AgreementWithOtp).HasColumnName("AgreementWithOTP");

                entity.Property(e => e.AgreementWithoutOtp).HasColumnName("AgreementWithoutOTP");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Otp)
                    .HasMaxLength(6)
                    .HasColumnName("OTP");

                entity.Property(e => e.Stage).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserLogin).HasMaxLength(15);
            });

            modelBuilder.Entity<PostdepositErrorLog>(entity =>
            {
                entity.ToTable("PostdepositErrorLog");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.User).HasMaxLength(100);
            });

            modelBuilder.Entity<PreQualification>(entity =>
            {
                entity.ToTable("PreQualification");

                entity.Property(e => e.PreQualificationId)
                    .ValueGeneratedNever()
                    .HasColumnName("preQualificationID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.PqType)
                    .HasColumnName("pqType")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PreQualificationBankId).HasColumnName("preQualificationBankID");

                entity.Property(e => e.PreQualificationData)
                    .HasColumnType("xml")
                    .HasColumnName("preQualificationData");

                entity.Property(e => e.PreQualificationSendBankToData)
                    .HasColumnType("xml")
                    .HasColumnName("preQualificationSendBankToData");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<PreQualificationReply>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PreQualificationReply");

                entity.Property(e => e.PreQualificationBankId).HasColumnName("preQualificationBankID");

                entity.Property(e => e.PreQualificationReply1)
                    .HasMaxLength(1000)
                    .HasColumnName("preQualificationReply");

                entity.Property(e => e.PreQualificationReplyId).HasColumnName("preQualificationReplyID");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<PreQualificationStage>(entity =>
            {
                entity.ToTable("PreQualificationStage");

                entity.Property(e => e.PreQualificationStageId).HasColumnName("preQualificationStageID");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.CurrentStage)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("currentStage");

                entity.Property(e => e.PreQualificationId).HasColumnName("preQualificationID");

                entity.Property(e => e.PreQualificationStageData)
                    .HasColumnType("xml")
                    .HasColumnName("preQualificationStageData");

                entity.Property(e => e.StageNum)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("stageNum");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            modelBuilder.Entity<PushNotification>(entity =>
            {
                entity.HasKey(e => e.PushId)
                    .HasName("PK__PushNoti__BF0A7ED963811208");

                entity.ToTable("PushNotification");

                entity.Property(e => e.DatetimeCreate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastAttempt).HasColumnType("datetime");

                entity.Property(e => e.PushStatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PEND')")
                    .IsFixedLength();

                entity.HasOne(d => d.PushStatus)
                    .WithMany(p => p.PushNotifications)
                    .HasForeignKey(d => d.PushStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PushNotification_PushStatus_Id_fk");
            });

            modelBuilder.Entity<PushStatus>(entity =>
            {
                entity.ToTable("PushStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(50)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(50)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<Rate>(entity =>
            {
                entity.ToTable("Rate");

                entity.HasIndex(e => e.RequestId, "NonClusteredRequestId");

                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Rates)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Rate_Requests");
            });

            modelBuilder.Entity<RegCountFromDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RegCountFromDate");

                entity.Property(e => e.Data)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.RegCount).HasColumnName("regCount");
            });

            modelBuilder.Entity<RegDepClientCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RegDepClientCount");

                entity.Property(e => e.Count).HasColumnName("count_");

                entity.Property(e => e.Dep)
                    .HasMaxLength(50)
                    .HasColumnName("dep");
            });

            modelBuilder.Entity<RegisterIpFromDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RegisterIpFromDate");

                entity.Property(e => e.Data)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("userIp");
            });

            modelBuilder.Entity<Relation>(entity =>
            {
                entity.ToTable("Relation");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TitleKk)
                    .HasMaxLength(100)
                    .HasColumnName("TitleKK");

                entity.Property(e => e.TitleRu)
                    .HasMaxLength(100)
                    .HasColumnName("TitleRU");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasIndex(e => e.ParentRequest, "IX_Requests_missing_31759");

                entity.HasIndex(e => e.ParentRequest, "IX_Requests_missing_31762");

                entity.HasIndex(e => e.ParentRequest, "IX_Requests_missing_32605");

                entity.HasIndex(e => new { e.UserId, e.RegNum }, "NonClusteredIndex-UserID-RegNum");

                entity.HasIndex(e => new { e.UserId, e.TypeId, e.StatusId }, "SSRequests");

                entity.HasIndex(e => e.CreateDate, "i_request_createdate");

                entity.HasIndex(e => e.LinkId, "i_request_linkid");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LinkId).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.RegNum).HasMaxLength(250);

                entity.Property(e => e.RequestData).HasColumnType("ntext");

                entity.Property(e => e.ResponseData).HasColumnType("ntext");
            });

            modelBuilder.Entity<RequestsHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RequestsHistory");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LinkId).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(450);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.RegNum).HasMaxLength(250);

                entity.Property(e => e.RequestData).HasColumnType("ntext");

                entity.Property(e => e.ResponseData).HasColumnType("ntext");
            });

            modelBuilder.Entity<RequestsStatusType>(entity =>
            {
                entity.ToTable("RequestsStatusType");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameKz)
                    .HasMaxLength(50)
                    .HasColumnName("Name_kz");
            });

            modelBuilder.Entity<RequestsType>(entity =>
            {
                entity.ToTable("RequestsType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Actual).HasColumnName("actual");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.NameKz)
                    .HasMaxLength(250)
                    .HasColumnName("name_kz");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type")
                    .HasDefaultValueSql("(N'deposite')");
            });

            modelBuilder.Entity<ResourceTxt>(entity =>
            {
                entity.ToTable("ResourceTxt");

                entity.Property(e => e.KeyTxt).HasMaxLength(200);

                entity.Property(e => e.ValueKz).HasMaxLength(1000);

                entity.Property(e => e.ValueRu).HasMaxLength(1000);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasComment("role_id идентифицирует Роли пользователей системы");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .HasColumnName("name")
                    .HasComment("name относится к Роли пользователей системы");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasComment("status относится к Роли пользователей системы");

                entity.Property(e => e.UserType)
                    .HasColumnName("userType")
                    .HasDefaultValueSql("((2))");
            });

            modelBuilder.Entity<RoleAccess>(entity =>
            {
                entity.ToTable("RoleAccess");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name).HasMaxLength(2500);
            });

            modelBuilder.Entity<RoleActionType>(entity =>
            {
                entity.ToTable("RoleActionType");

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<RoleModule>(entity =>
            {
                entity.HasComment("Модули ролей (сами модули в проекте)");

                entity.Property(e => e.RoleModuleId).HasColumnName("roleModuleId");

                entity.Property(e => e.ModuleActionDivisionParamType).HasColumnName("moduleActionDivisionParamType");

                entity.Property(e => e.ModuleActionId)
                    .HasColumnName("moduleActionId")
                    .HasComment("id действия модуля");

                entity.Property(e => e.ModuleActionParameter)
                    .HasColumnName("moduleActionParameter")
                    .HasComment("параметр для действия модуля");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasComment("id роли");

                entity.HasOne(d => d.ModuleAction)
                    .WithMany(p => p.RoleModules)
                    .HasForeignKey(d => d.ModuleActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleModules_ModuleAction");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleModules)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleModules_Roles");
            });

            modelBuilder.Entity<RoleOperation>(entity =>
            {
                entity.ToTable("RoleOperation");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).HasMaxLength(250);

                entity.Property(e => e.Description).HasMaxLength(2500);

                entity.Property(e => e.Module).HasMaxLength(300);

                entity.Property(e => e.Name).HasMaxLength(2500);
            });

            modelBuilder.Entity<RoleOperationAction>(entity =>
            {
                entity.ToTable("RoleOperationAction");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(2000);
            });

            modelBuilder.Entity<RolesAndOperation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RolesAndOperations");

                entity.Property(e => e.ActionName).HasMaxLength(250);

                entity.Property(e => e.OperationCb)
                    .HasMaxLength(250)
                    .HasColumnName("OperationCB");

                entity.Property(e => e.OperationCd)
                    .HasColumnType("datetime")
                    .HasColumnName("OperationCD");

                entity.Property(e => e.OperationDesc).HasMaxLength(2500);

                entity.Property(e => e.OperationModule).HasMaxLength(300);

                entity.Property(e => e.OperationName).HasMaxLength(2500);

                entity.Property(e => e.RoleCb)
                    .HasMaxLength(250)
                    .HasColumnName("RoleCB");

                entity.Property(e => e.RoleCd)
                    .HasColumnType("datetime")
                    .HasColumnName("RoleCD");

                entity.Property(e => e.RoleCode).HasMaxLength(50);

                entity.Property(e => e.RoleDesc).HasMaxLength(2000);

                entity.Property(e => e.RoleName).HasMaxLength(2500);
            });

            modelBuilder.Entity<RssNews>(entity =>
            {
                entity.ToTable("RSS_News");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lang)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PubDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DRFT')")
                    .IsFixedLength();

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.RssNews)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RSS_News_NewsStatus");
            });

            modelBuilder.Entity<RunaObj>(entity =>
            {
                entity.ToTable("runaObj");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.TypeObject).HasColumnName("typeObject");
            });

            modelBuilder.Entity<RunaObjProp>(entity =>
            {
                entity.ToTable("runaObjProps");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .HasColumnName("comment");

                entity.Property(e => e.ObjPropId).HasColumnName("objPropId");

                entity.Property(e => e.ObjTypeId).HasColumnName("objTypeId");
            });

            modelBuilder.Entity<RunaObjType>(entity =>
            {
                entity.HasKey(e => e.ObjTypeId)
                    .HasName("PK_objTypes");

                entity.ToTable("runaObjTypes");

                entity.Property(e => e.ObjTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("objTypeId");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .HasColumnName("comment");
            });

            modelBuilder.Entity<RunaOpv>(entity =>
            {
                entity.ToTable("runaOpv");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ObjectId).HasColumnName("objectId");

                entity.Property(e => e.PropertyId).HasColumnName("propertyId");

                entity.Property(e => e.Val)
                    .HasColumnType("sql_variant")
                    .HasColumnName("val");
            });

            modelBuilder.Entity<RunaUserNotify>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("runaUserNotify");

                entity.Property(e => e.CoborrowerClientCode).HasColumnName("coborrowerClientCode");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoanId).HasMaxLength(100);

                entity.Property(e => e.NotifyMessageKaz).HasMaxLength(4000);

                entity.Property(e => e.NotifyMessageRu).HasMaxLength(4000);

                entity.Property(e => e.Ord).HasColumnName("ord");

                entity.Property(e => e.Parameters).HasMaxLength(463);

                entity.Property(e => e.Stage)
                    .HasMaxLength(100)
                    .HasColumnName("stage");

                entity.Property(e => e.ViewModelName)
                    .HasMaxLength(72)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SendedToBpmlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SendedToBPMLog");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ServiceBusCache>(entity =>
            {
                entity.HasKey(e => e.CacheId)
                    .HasName("PK__ServiceB__59903A3A4CA1D877")
                    .IsClustered(false);

                entity.ToTable("ServiceBusCache");

                entity.IsMemoryOptimized();

                entity.Property(e => e.CacheId).HasColumnName("cacheId");

                entity.Property(e => e.ActionId).HasColumnName("actionId");

                entity.Property(e => e.AltCode)
                    .HasMaxLength(50)
                    .HasColumnName("altCode");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .HasColumnName("clientId");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.ModuleId).HasColumnName("moduleId");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .HasColumnName("userLogin");

                entity.Property(e => e.XmlData).HasColumnName("xmlData");

                entity.Property(e => e.XmlInputData).HasColumnName("xmlInputData");
            });

            modelBuilder.Entity<ServiceFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Service_Files");

                entity.HasIndex(e => e.Id, "IX_Service_Files_missing_31782");

                entity.HasIndex(e => e.IsCopied, "Service_Files_isCopied");

                entity.Property(e => e.BankFileId).HasColumnName("bankFileId");

                entity.Property(e => e.ClientCode).HasMaxLength(1000);

                entity.Property(e => e.ColvirReferenceId)
                    .HasMaxLength(1000)
                    .HasColumnName("ColvirReferenceID");

                entity.Property(e => e.ErrorCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.FileId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsCopied)
                    .HasColumnName("isCopied")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RunTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceMethod).HasMaxLength(1000);

                entity.Property(e => e.UserBranchName).HasMaxLength(1000);

                entity.Property(e => e.UserDepName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code).HasMaxLength(1000);
            });

            modelBuilder.Entity<SiteSetting>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<SmsSendInfo>(entity =>
            {
                entity.ToTable("SmsSendInfo");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.RegNum).HasMaxLength(50);

                entity.Property(e => e.RequestData)
                    .HasColumnType("xml")
                    .HasComment("Запрос");

                entity.Property(e => e.ResponseData)
                    .HasColumnType("text")
                    .HasComment("Ответ");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'NEW')");

                entity.Property(e => e.Text).HasMaxLength(500);
            });

            modelBuilder.Entity<SmsSendLog>(entity =>
            {
                entity.ToTable("SmsSendLog");

                entity.HasIndex(e => e.CreateDate, "NonClusteredIndex-CreateDate-20210826-085457");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Module)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestData)
                    .HasColumnType("xml")
                    .HasComment("Запрос");

                entity.Property(e => e.ResponseData)
                    .HasColumnType("xml")
                    .HasComment("Ответ");

                entity.Property(e => e.TypeSystem)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UserIIN");
            });

            modelBuilder.Entity<Sqliinresult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SQLIINResults$");

                entity.Property(e => e.Iin)
                    .HasMaxLength(255)
                    .HasColumnName("IIN");
            });

            modelBuilder.Entity<StandingOrder>(entity =>
            {
                entity.ToTable("StandingOrder");

                entity.HasIndex(e => e.Reference, "IX_StandingOrder")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId, "IX_StandingOrder_missing_25907");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlterCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CardId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).HasMaxLength(250);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeleteDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Iban)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasMaxLength(250);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.StandingOrders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StandingOrder_Client");
            });

            modelBuilder.Entity<StandingOrderProcess>(entity =>
            {
                entity.HasKey(e => e.ProcessId)
                    .HasName("PK__Standing__1B39A956A2C2666B");

                entity.ToTable("StandingOrderProcess");

                entity.Property(e => e.AtmRrn)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("AtmRRN");

                entity.Property(e => e.AtmStatus)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AtmStatusDate).HasColumnType("datetime");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EpayStatus)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EpayStatusDate).HasColumnType("datetime");

                entity.Property(e => e.LogProcessId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DRFT')")
                    .IsFixedLength();

                entity.Property(e => e.ProcessStatusDate).HasColumnType("datetime");

                entity.HasOne(d => d.StandingOrder)
                    .WithMany(p => p.StandingOrderProcesses)
                    .HasForeignKey(d => d.StandingOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StandingOrderProcess_StandingOrde");
            });

            modelBuilder.Entity<StandingOrderStage>(entity =>
            {
                entity.HasKey(e => e.StageId)
                    .HasName("PK__Standing__03EB7AD8C3AB05C9");

                entity.ToTable("StandingOrderStage");

                entity.Property(e => e.ReceivedData).HasColumnType("text");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.SendData).HasColumnType("text");

                entity.Property(e => e.SendDate).HasColumnType("datetime");

                entity.Property(e => e.StageName).HasMaxLength(50);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.StandingOrderStages)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StandingOrderStage_StandingOrderProcess");
            });

            modelBuilder.Entity<SubAgreement>(entity =>
            {
                entity.ToTable("SubAgreement");

                entity.HasIndex(e => e.LotId, "IX_SubAgreement_LotId")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubAgreementDate).HasColumnType("datetime");

                entity.Property(e => e.SubAgreementId).HasMaxLength(250);

                entity.Property(e => e.SubAgreementNumber).HasMaxLength(250);
            });

            modelBuilder.Entity<SynchronizeColvir>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SynchronizeColvir");

                entity.HasIndex(e => new { e.SynchronizeColvirId, e.UserId }, "ClusteredIndex-20210730-113625")
                    .IsClustered();

                entity.Property(e => e.ChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("changeDate");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(20)
                    .HasColumnName("clientCode");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(20)
                    .HasColumnName("columnName");

                entity.Property(e => e.NewData)
                    .HasMaxLength(300)
                    .HasColumnName("newData");

                entity.Property(e => e.OldData)
                    .HasMaxLength(300)
                    .HasColumnName("oldData");

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .HasColumnName("reason");

                entity.Property(e => e.SynchronizeColvirId).ValueGeneratedOnAdd();

                entity.Property(e => e.TableName)
                    .HasMaxLength(20)
                    .HasColumnName("tableName");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.ToTable("Transfer");

                entity.HasIndex(e => new { e.TransferTypeId, e.Amount, e.SrcAccount, e.DateCreated }, "IX_Transfer_missing_26108");

                entity.HasIndex(e => new { e.SrcAccount, e.TransferTypeId, e.DateCreated }, "IX_Transfer_missing_26110");

                entity.HasIndex(e => e.RequestId, "NonClusteredRequestId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContractDate)
                    .HasColumnType("date")
                    .HasColumnName("contractDate");

                entity.Property(e => e.ContractNum)
                    .HasMaxLength(50)
                    .HasColumnName("contractNum");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeeReference).HasMaxLength(50);

                entity.Property(e => e.Kbe)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Knp)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Kod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.SrcAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TariffColvirCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tariffColvirCode");

                entity.Property(e => e.TransferTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TrgAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrgAltCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrgIin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrgName).HasMaxLength(200);

                entity.Property(e => e.TrgPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Transfer_Requests");

                entity.HasOne(d => d.TransferType)
                    .WithMany(p => p.Transfers)
                    .HasForeignKey(d => d.TransferTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transfer_TransferType");
            });

            modelBuilder.Entity<TransferSetting>(entity =>
            {
                entity.HasKey(e => e.TransferTypeId);

                entity.Property(e => e.TransferTypeId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FeeMaximum)
                    .HasColumnType("money")
                    .HasColumnName("feeMaximum");

                entity.Property(e => e.FeeMinimum)
                    .HasColumnType("money")
                    .HasColumnName("feeMinimum");

                entity.Property(e => e.FeeRate)
                    .HasColumnType("decimal(18, 10)")
                    .HasColumnName("feeRate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OperationTimeFinish)
                    .HasColumnType("datetime")
                    .HasColumnName("operationTimeFinish");

                entity.Property(e => e.OperationTimeStart)
                    .HasColumnType("datetime")
                    .HasColumnName("operationTimeStart");

                entity.Property(e => e.TariffColvirCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("tariffColvirCode");
            });

            modelBuilder.Entity<TransferType>(entity =>
            {
                entity.ToTable("TransferType");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Kbe)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Kod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<UniqueLogonCountFromDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UniqueLogonCountFromDate");

                entity.Property(e => e.Data)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.LogOnCount).HasColumnName("logOnCount");
            });

            modelBuilder.Entity<UsdisplayObjectGoal>(entity =>
            {
                entity.ToTable("USDisplayObjectGoals");

                entity.Property(e => e.DisplayId).HasMaxLength(250);

                entity.Property(e => e.Goal).HasMaxLength(500);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UsdisplayObjectName>(entity =>
            {
                entity.ToTable("USDisplayObjectNames");

                entity.HasIndex(e => new { e.DisplayId, e.TypeId }, "IX_Table_DisplayIdIndex")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DisplayId, "NonClusteredIndex-DisplayId")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.DisplayId).HasMaxLength(250);

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewName).HasMaxLength(500);

                entity.Property(e => e.OldName).HasMaxLength(500);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserLogin, "NonClusteredUserLogin");

                entity.HasIndex(e => e.UserType, "SSUserLoginCreateDate");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.LastOdsupdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LastODSUpdateDate");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SynchColvirDate).HasColumnType("datetime");

                entity.Property(e => e.UserCreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userCreateDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(50)
                    .HasColumnName("userEmail");

                entity.Property(e => e.UserFailedPasswordAttemptCount).HasColumnName("userFailedPasswordAttemptCount");

                entity.Property(e => e.UserFailedPasswordAttemptWindowStart)
                    .HasColumnType("datetime")
                    .HasColumnName("userFailedPasswordAttemptWindowStart")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserLanguage)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("userLanguage")
                    .IsFixedLength();

                entity.Property(e => e.UserLastLockOutDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userLastLockOutDate");

                entity.Property(e => e.UserLastLoginChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userLastLoginChangeDate");

                entity.Property(e => e.UserLastLoginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userLastLoginDate");

                entity.Property(e => e.UserLastPassChangeDate)
                    .HasColumnType("datetime")
                    .HasColumnName("userLastPassChangeDate");

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .HasColumnName("userLogin");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(128)
                    .HasColumnName("userPassword");

                entity.Property(e => e.UserType)
                    .HasColumnName("userType")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<UserAccess>(entity =>
            {
                entity.ToTable("UserAccess");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentJob).HasMaxLength(250);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GivenBy).HasMaxLength(250);

                entity.Property(e => e.Module).HasMaxLength(250);

                entity.Property(e => e.StandsInFor).HasMaxLength(250);

                entity.HasOne(d => d.RoleAccess)
                    .WithMany(p => p.UserAccesses)
                    .HasForeignKey(d => d.RoleAccessId)
                    .HasConstraintName("FK_UserAccess_RoleAccess");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAccesses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAccess_Users");
            });

            modelBuilder.Entity<UserAccessLog>(entity =>
            {
                entity.ToTable("UserAccessLog");

                entity.Property(e => e.CurrentJob).HasMaxLength(250);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GivenBy).HasMaxLength(250);

                entity.Property(e => e.RoleCode).HasMaxLength(250);

                entity.Property(e => e.RoleName).HasMaxLength(250);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserLogin).HasMaxLength(250);
            });

            modelBuilder.Entity<UserCountByFilial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserCountByFilials");

                entity.Property(e => e.ActiveCount).HasColumnName("active_count");

                entity.Property(e => e.CbsOblCode)
                    .HasMaxLength(50)
                    .HasColumnName("cbs_obl_code");

                entity.Property(e => e.MonthValue)
                    .HasMaxLength(4000)
                    .HasColumnName("month_value");

                entity.Property(e => e.RegCount).HasColumnName("reg_count");

                entity.Property(e => e.YearValue).HasColumnName("year_value");
            });

            modelBuilder.Entity<UserFile>(entity =>
            {
                entity.HasKey(e => e.UserFileGuid)
                    .HasName("PK_userFiles");

                entity.HasIndex(e => e.SourceReqCode, "IX_UserFiles_missing_25905");

                entity.Property(e => e.UserFileGuid)
                    .ValueGeneratedNever()
                    .HasColumnName("userFileGuid");

                entity.Property(e => e.BankFileId).HasColumnName("bankFileId");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .HasColumnName("clientId");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.Deleted)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted");

                entity.Property(e => e.FileData).HasColumnName("fileData");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .HasColumnName("fileName");

                entity.Property(e => e.FileTypeId).HasColumnName("fileTypeId");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.SourceReqCode)
                    .HasMaxLength(50)
                    .HasColumnName("sourceReqCode");

                entity.Property(e => e.SourceReqNum)
                    .HasMaxLength(50)
                    .HasColumnName("sourceReqNum");

                entity.Property(e => e.SourceSystem).HasColumnName("sourceSystem");

                entity.Property(e => e.Uploaded)
                    .HasColumnType("datetime")
                    .HasColumnName("uploaded");

                entity.Property(e => e.UserFileId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("userFileID");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<UserFileSignInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserFileSignInfo");

                entity.HasIndex(e => e.UserFileGuid, "IX_UserFileSignInfo_missing_12313");

                entity.Property(e => e.BankKeyInfo)
                    .HasColumnType("xml")
                    .HasColumnName("bankKeyInfo");

                entity.Property(e => e.BankSignResult)
                    .IsUnicode(false)
                    .HasColumnName("bankSignResult");

                entity.Property(e => e.BankSigned)
                    .HasColumnType("datetime")
                    .HasColumnName("bankSigned");

                entity.Property(e => e.ClientKeyInfo)
                    .HasColumnType("xml")
                    .HasColumnName("clientKeyInfo");

                entity.Property(e => e.ClientSignResult)
                    .IsUnicode(false)
                    .HasColumnName("clientSignResult");

                entity.Property(e => e.ClientSigned)
                    .HasColumnType("datetime")
                    .HasColumnName("clientSigned");

                entity.Property(e => e.IsBankSignWithFile).HasColumnName("isBankSignWithFile");

                entity.Property(e => e.IsClientSignWithFile).HasColumnName("isClientSignWithFile");

                entity.Property(e => e.UserFileGuid).HasColumnName("userFileGuid");
            });

            modelBuilder.Entity<UserFileType>(entity =>
            {
                entity.HasKey(e => e.FileTypeId)
                    .HasName("PK_FileTypes");

                entity.Property(e => e.FileTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("fileTypeId");

                entity.Property(e => e.BankFileTypeId).HasColumnName("bankFileTypeId");

                entity.Property(e => e.FileStorageTime).HasColumnName("fileStorageTime");

                entity.Property(e => e.FileTypeName)
                    .HasMaxLength(100)
                    .HasColumnName("fileTypeName");

                entity.Property(e => e.NeedBankSign).HasColumnName("needBankSign");

                entity.Property(e => e.NeedClientSign).HasColumnName("needClientSign");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<UserFilesPki>(entity =>
            {
                entity.HasKey(e => e.UserFileGuid)
                    .HasName("PK_userFilesPKI");

                entity.ToTable("UserFilesPKI");

                entity.Property(e => e.UserFileGuid)
                    .ValueGeneratedNever()
                    .HasColumnName("userFileGuid");

                entity.Property(e => e.BankFileId).HasColumnName("bankFileId");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .HasColumnName("clientId");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.Deleted)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted");

                entity.Property(e => e.FileData).HasColumnName("fileData");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .HasColumnName("fileName");

                entity.Property(e => e.FileTypeId).HasColumnName("fileTypeId");

                entity.Property(e => e.IsDelete).HasColumnName("isDelete");

                entity.Property(e => e.SourceReqCode)
                    .HasMaxLength(50)
                    .HasColumnName("sourceReqCode");

                entity.Property(e => e.SourceReqNum)
                    .HasMaxLength(50)
                    .HasColumnName("sourceReqNum");

                entity.Property(e => e.SourceSystem).HasColumnName("sourceSystem");

                entity.Property(e => e.Uploaded)
                    .HasColumnType("datetime")
                    .HasColumnName("uploaded");

                entity.Property(e => e.UserFileId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("userFileID");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<UserNotifyRepaymentSchedule>(entity =>
            {
                entity.ToTable("UserNotifyRepaymentSchedule");

                entity.HasIndex(e => new { e.CoborrowerClientCode, e.Stage }, "IX_UserNotifyRepaymentSchedule_missing_26274");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoborrowerClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("coborrowerClientCode");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LoanId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyMessageKaz).HasMaxLength(250);

                entity.Property(e => e.NotifyMessageRu).HasMaxLength(250);

                entity.Property(e => e.Ord).HasColumnName("ord");

                entity.Property(e => e.Parameters).HasMaxLength(500);

                entity.Property(e => e.Stage)
                    .HasMaxLength(50)
                    .HasColumnName("stage");

                entity.Property(e => e.ViewModelName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.RoleId }, "Index_RoleByUser")
                    .IsUnique();

                entity.Property(e => e.UserRoleId).HasColumnName("userRoleId");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<UserToDeactivate>(entity =>
            {
                entity.ToTable("UserToDeactivate");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeactivateDate).HasColumnType("datetime");

                entity.Property(e => e.InitialUser).HasMaxLength(500);

                entity.Property(e => e.RequestId).HasMaxLength(500);

                entity.Property(e => e.UserDomainAccount).HasMaxLength(500);
            });

            modelBuilder.Entity<UsersAndRolesDictionary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UsersAndRolesDictionary");

                entity.Property(e => e.AccessEd)
                    .HasColumnType("datetime")
                    .HasColumnName("AccessED");

                entity.Property(e => e.AccessedUserCb)
                    .HasMaxLength(250)
                    .HasColumnName("AccessedUserCB");

                entity.Property(e => e.AccessedUserCd)
                    .HasColumnType("datetime")
                    .HasColumnName("AccessedUserCD");

                entity.Property(e => e.AccessedUserDesc).HasMaxLength(2000);

                entity.Property(e => e.AccessedUserJob).HasMaxLength(250);

                entity.Property(e => e.ActionName).HasMaxLength(250);

                entity.Property(e => e.OperationCb)
                    .HasMaxLength(250)
                    .HasColumnName("OperationCB");

                entity.Property(e => e.OperationCd)
                    .HasColumnType("datetime")
                    .HasColumnName("OperationCD");

                entity.Property(e => e.OperationDesc).HasMaxLength(2500);

                entity.Property(e => e.OperationModule).HasMaxLength(300);

                entity.Property(e => e.OperationName).HasMaxLength(2500);

                entity.Property(e => e.RoleCb)
                    .HasMaxLength(250)
                    .HasColumnName("RoleCB");

                entity.Property(e => e.RoleCd)
                    .HasColumnType("datetime")
                    .HasColumnName("RoleCD");

                entity.Property(e => e.RoleCode).HasMaxLength(50);

                entity.Property(e => e.RoleDesc).HasMaxLength(2000);

                entity.Property(e => e.RoleName).HasMaxLength(2500);

                entity.Property(e => e.RoleOperationCd)
                    .HasColumnType("datetime")
                    .HasColumnName("RoleOperationCD");

                entity.Property(e => e.RoleOperationDesc).HasMaxLength(2000);

                entity.Property(e => e.UserLogin).HasMaxLength(50);
            });

            modelBuilder.Entity<UsersAndRolesDictionaryHasAccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UsersAndRolesDictionaryHasAccess");

                entity.Property(e => e.Module).HasMaxLength(300);

                entity.Property(e => e.UserLogin)
                    .HasMaxLength(50)
                    .HasColumnName("userLogin");
            });

            modelBuilder.Entity<VideoBanner>(entity =>
            {
                entity.ToTable("video_banner");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryDescription).HasMaxLength(50);

                entity.Property(e => e.ImageLoc).HasMaxLength(250);

                entity.Property(e => e.Lang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(250);
            });

            modelBuilder.Entity<VideoBannerUserDeviceViewed>(entity =>
            {
                entity.HasKey(e => new { e.DeviceId, e.UserId, e.VideoBannerId });

                entity.ToTable("video_banner_userDeviceViewed");

                entity.HasIndex(e => e.DeviceId, "vb_deviceId");

                entity.HasIndex(e => e.UserId, "vb_userId");

                entity.Property(e => e.DeviceId).HasMaxLength(250);

                entity.Property(e => e.DateViewed).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewBiStandingOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_bi_standingOrder");

                entity.Property(e => e.AlterCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ViewBiStandingOrderPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_bi_standingOrderPayment");

                entity.Property(e => e.AlterCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ClientCode)
                    .HasMaxLength(50)
                    .HasColumnName("clientCode");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("code");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Fio)
                    .HasMaxLength(152)
                    .HasColumnName("FIO");

                entity.Property(e => e.Iban)
                    .HasMaxLength(34)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ViewForTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_for_test");

                entity.Property(e => e.ClientIin)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("clientIIN")
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<ViewSmsSendOtpLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_SmsSendOtpLog");

                entity.Property(e => e.ClientCode).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Iin)
                    .HasMaxLength(100)
                    .HasColumnName("IIN");

                entity.Property(e => e.OperationCode).HasMaxLength(100);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.RequestData).HasColumnType("xml");

                entity.Property(e => e.ResponseData).HasColumnType("xml");
            });

            modelBuilder.Entity<WorkingDay>(entity =>
            {
                entity.HasKey(e => e.WorkDate);

                entity.ToTable("Working_Days");

                entity.Property(e => e.WorkDate).HasColumnType("date");
            });

            modelBuilder.Entity<WsLog>(entity =>
            {
                entity.ToTable("WsLog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.InnerException)
                    .HasMaxLength(500)
                    .HasColumnName("inner_exception");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .HasColumnName("message");

                entity.Property(e => e.Parameters)
                    .IsUnicode(false)
                    .HasColumnName("parameters");

                entity.Property(e => e.Source)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("source");

                entity.Property(e => e.StackTrace)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("stack_trace");

                entity.Property(e => e.TargetSite)
                    .IsUnicode(false)
                    .HasColumnName("target_site");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WsName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ws_name");
            });

            modelBuilder.HasSequence("InsuranceSequence")
                .HasMin(1)
                .HasMax(999999999999)
                .IsCyclic();

            modelBuilder.HasSequence("RnnSequence")
                .HasMin(1)
                .HasMax(999999999999)
                .IsCyclic();

            modelBuilder.HasSequence<int>("StanSequence")
                .StartsAt(900000)
                .HasMin(900000)
                .HasMax(999999)
                .IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
