using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OtbasyBank.Domain.Entities;
namespace OtbasyBank.Application.Interfaces.Persistence
{
    public interface IInternetBankingContext : IDisposable
    {
        public int SaveChanges();
        public DbSet<AgentPhoto> AgentPhotos { get; set; }  
        public DbSet<ArhiveClientInfo> ArhiveClientInfos { get; set; }  
        public DbSet<ArhiveUserLogin> ArhiveUserLogins { get; set; }  
        public DbSet<AttrepTruncationSafeguard> AttrepTruncationSafeguards { get; set; }  
        public DbSet<AuctionBlockList> AuctionBlockLists { get; set; }  
        public DbSet<AuctionBuyStep> AuctionBuySteps { get; set; }  
        public DbSet<AuctionCancelLog> AuctionCancelLogs { get; set; }  
        public DbSet<AuctionDeposit> AuctionDeposits { get; set; }  
        public DbSet<AuctionDepositStatus> AuctionDepositStatuses { get; set; }  
        public DbSet<AuctionDepositsTransferLog> AuctionDepositsTransferLogs { get; set; }  
        public DbSet<AuctionFormsAndSm> AuctionFormsAndSms { get; set; }  
        public DbSet<AuctionLog> AuctionLogs { get; set; }  
        public DbSet<AuctionMoneyTransferLog> AuctionMoneyTransferLogs { get; set; }  
        public DbSet<AuctionProcess> AuctionProcesses { get; set; }  
        public DbSet<AuctionSellStep> AuctionSellSteps { get; set; }  
        public DbSet<AuctionSellersInProcess> AuctionSellersInProcesses { get; set; }  
        public DbSet<AuctionSetting> AuctionSettings { get; set; }  
        public DbSet<AuctionSubAgreement> AuctionSubAgreements { get; set; }  
        public DbSet<AuctionUniversalProcessLogger> AuctionUniversalProcessLoggers { get; set; }  
        public DbSet<AuctionUniversalProcessLoggerValue> AuctionUniversalProcessLoggerValues { get; set; }  
        public DbSet<AuctionUniversalProcessType> AuctionUniversalProcessTypes { get; set; }  
        public DbSet<BankServiceObjectInfo> BankServiceObjectInfos { get; set; }  
        public DbSet<Bio> Bios { get; set; }  
        public DbSet<BlockchainOperation> BlockchainOperations { get; set; }  
        public DbSet<ChangeRequisitesLog> ChangeRequisitesLogs { get; set; }  
        public DbSet<ChangeUserDataLog> ChangeUserDataLogs { get; set; }  
        public DbSet<Changelog> Changelogs { get; set; }  
        public DbSet<ChangerequisitesLogsTwo> ChangerequisitesLogsTwos { get; set; }  
        public DbSet<Client> Clients { get; set; }  
        public DbSet<ClientLivenessBan> ClientLivenessBans { get; set; }  
        public DbSet<ClientNotification> ClientNotifications { get; set; }  
        public DbSet<ClientNotificationHistory> ClientNotificationHistories { get; set; }  
        public DbSet<ClientNotificationStatus> ClientNotificationStatuses { get; set; }  
        public DbSet<ClientRestrictionsAndDelayLog> ClientRestrictionsAndDelayLogs { get; set; }  
        public DbSet<ClientVerificationLog> ClientVerificationLogs { get; set; }  
        public DbSet<ClientVerificationPhoto> ClientVerificationPhotos { get; set; }  
        public DbSet<ConcessionsForClientsGlobalView> ConcessionsForClientsGlobalViews { get; set; }  
        public DbSet<ConcessionsForClientsView> ConcessionsForClientsViews { get; set; }  
        public DbSet<CoronaCreditUser> CoronaCreditUsers { get; set; }  
        public DbSet<CoronaCreditUsersDeleted> CoronaCreditUsersDeleteds { get; set; }  
        public DbSet<CorporateTarifEmployee> CorporateTarifEmployees { get; set; }  
        public DbSet<CreditOperation> CreditOperations { get; set; }  
        public DbSet<CreditOperationQuery> CreditOperationQueries { get; set; }  
        public DbSet<CreditOperationStage> CreditOperationStages { get; set; }  
        public DbSet<DbObjStorage> DbObjStorages { get; set; }  
        public DbSet<DepositAuctionBid> DepositAuctionBids { get; set; }  
        public DbSet<DepositAuctionBidGuaranteePayment> DepositAuctionBidGuaranteePayments { get; set; }  
        public DbSet<DepositAuctionBidGuaranteePaymentCurrAcc> DepositAuctionBidGuaranteePaymentCurrAccs { get; set; }  
        public DbSet<DepositAuctionBidGuaranteePaymentCurrAccLog> DepositAuctionBidGuaranteePaymentCurrAccLogs { get; set; }  
        public DbSet<DepositAuctionBidGuaranteePaymentLog> DepositAuctionBidGuaranteePaymentLogs { get; set; }  
        public DbSet<DepositAuctionBidHistory> DepositAuctionBidHistories { get; set; }  
        public DbSet<DepositAuctionBidPayment> DepositAuctionBidPayments { get; set; }  
        public DbSet<DepositAuctionBidPaymentCurrAcc> DepositAuctionBidPaymentCurrAccs { get; set; }  
        public DbSet<DepositAuctionBidPaymentLog> DepositAuctionBidPaymentLogs { get; set; }  
        public DbSet<DepositAuctionBidProcess> DepositAuctionBidProcesses { get; set; }  
        public DbSet<DepositAuctionBidStage> DepositAuctionBidStages { get; set; }  
        public DbSet<DepositAuctionBidStatus> DepositAuctionBidStatuses { get; set; }  
        public DbSet<DepositAuctionCalendar> DepositAuctionCalendars { get; set; }  
        public DbSet<DepositAuctionDocument> DepositAuctionDocuments { get; set; }  
        public DbSet<DepositAuctionError> DepositAuctionErrors { get; set; }  
        public DbSet<DepositAuctionLot> DepositAuctionLots { get; set; }  
        public DbSet<DepositAuctionLot2> DepositAuctionLot2s { get; set; }  
        public DbSet<DepositAuctionLotHistory> DepositAuctionLotHistories { get; set; }  
        public DbSet<DepositAuctionLotProcess> DepositAuctionLotProcesses { get; set; }  
        public DbSet<DepositAuctionLotStage> DepositAuctionLotStages { get; set; }  
        public DbSet<DepositAuctionLotStatus> DepositAuctionLotStatuses { get; set; }  
        public DbSet<DepositAuctionMail> DepositAuctionMails { get; set; }  
        public DbSet<DepositAuctionParameter> DepositAuctionParameters { get; set; }  
        public DbSet<DepositAuctionPrivetLot> DepositAuctionPrivetLots { get; set; }  
        public DbSet<DepositAuctionWinnerBid> DepositAuctionWinnerBids { get; set; }  
        public DbSet<DepositCessionFree> DepositCessionFrees { get; set; }  
        public DbSet<DepositCessionFreeLog> DepositCessionFreeLogs { get; set; }  
        public DbSet<DepositCessionFreeNotifyText> DepositCessionFreeNotifyTexts { get; set; }  
        public DbSet<DepositCessionFreeRelation> DepositCessionFreeRelations { get; set; }  
        public DbSet<DepositCessionFreeSetting> DepositCessionFreeSettings { get; set; }  
        public DbSet<DepositCessionFreeStatus> DepositCessionFreeStatuses { get; set; }  
        public DbSet<DepositDivisionUndoTable> DepositDivisionUndoTables { get; set; }  
        public DbSet<DepositOperation> DepositOperations { get; set; }  
        public DbSet<DepositOperationLink> DepositOperationLinks { get; set; }  
        public DbSet<DepositOperationQuery> DepositOperationQueries { get; set; }  
        public DbSet<DepositOperationStage> DepositOperationStages { get; set; }  
        public DbSet<Device> Devices { get; set; }  
        public DbSet<DeviceInfo> DeviceInfos { get; set; }  
        public DbSet<DeviceTrusted> DeviceTrusteds { get; set; }  
        public DbSet<DeviceTrustedHistory> DeviceTrustedHistories { get; set; }  
        public DbSet<DeviceTrustedLog> DeviceTrustedLogs { get; set; }  
        public DbSet<DeviceTrustedSession> DeviceTrustedSessions { get; set; }  
        public DbSet<DeviceTrustedSetting> DeviceTrustedSettings { get; set; }  
        public DbSet<DevinoLog> DevinoLogs { get; set; }  
        public DbSet<Document> Documents { get; set; }  
        public DbSet<Draft> Drafts { get; set; }  
        public DbSet<EgovRequest> EgovRequests { get; set; }  
        public DbSet<EgovRequestService> EgovRequestServices { get; set; }  
        public DbSet<EgovResponse> EgovResponses { get; set; }  
        public DbSet<ExternalSiteCity> ExternalSiteCities { get; set; }  
        public DbSet<FamilyPackage> FamilyPackages { get; set; }  
        public DbSet<Faq> Faqs { get; set; }  
        public DbSet<Filial> Filials { get; set; }  
        public DbSet<Fpdeposit> Fpdeposits { get; set; }  
        public DbSet<FpdepositStatus> FpdepositStatuses { get; set; }  
        public DbSet<FpdepositStatusLog> FpdepositStatusLogs { get; set; }  
        public DbSet<FrontEnd> FrontEnds { get; set; }  
        public DbSet<GetAveragePointsForProcessesAllTimeView> GetAveragePointsForProcessesAllTimeViews { get; set; }  
        public DbSet<GetLastRatingsFromClientsView> GetLastRatingsFromClientsViews { get; set; }  
        public DbSet<GetLog4NetLogAuthLogWithArhView> GetLog4NetLogAuthLogWithArhViews { get; set; }  
        public DbSet<GetLog4NetLogCurrAccWithArhView> GetLog4NetLogCurrAccWithArhViews { get; set; }  
        public DbSet<GetLogErrorLogWithArhView> GetLogErrorLogWithArhViews { get; set; }  
        public DbSet<HappyFamily> HappyFamilies { get; set; }  
        public DbSet<HappyFamilyCrmInfo> HappyFamilyCrmInfos { get; set; }  
        public DbSet<Help> Helps { get; set; }  
        public DbSet<HelpStatus> HelpStatuses { get; set; }  
        public DbSet<HelpTopic> HelpTopics { get; set; }  
        public DbSet<History> Histories { get; set; }  
        public DbSet<HistoryAction> HistoryActions { get; set; }  
        public DbSet<HistoryActionType> HistoryActionTypes { get; set; }  
        public DbSet<HistoryActionsByDate> HistoryActionsByDates { get; set; }  
        public DbSet<HistoryOld> HistoryOlds { get; set; }  
        public DbSet<HsTransactionLog> HsTransactionLogs { get; set; }  
        public DbSet<Illustration> Illustrations { get; set; }  
        public DbSet<InfobipToken> InfobipTokens { get; set; }  
        public DbSet<InfobipTokenHistory> InfobipTokenHistories { get; set; }  
        public DbSet<InstructionLog> InstructionLogs { get; set; }  
        public DbSet<Insurance> Insurances { get; set; }  
        public DbSet<InsuranceContract> InsuranceContracts { get; set; }  
        public DbSet<InsuranceLog> InsuranceLogs { get; set; }  
        public DbSet<InsuranceProcess> InsuranceProcesses { get; set; }  
        public DbSet<InsuranceStatus> InsuranceStatuses { get; set; }  
        public DbSet<InvitationNotification> InvitationNotifications { get; set; }  
        public DbSet<Kbe> Kbes { get; set; }  
        public DbSet<KnowledgeBase> KnowledgeBases { get; set; }  
        public DbSet<KnowledgeBaseCategory> KnowledgeBaseCategories { get; set; }  
        public DbSet<KnowledgeBaseFile> KnowledgeBaseFiles { get; set; }  
        public DbSet<KnowledgeBaseParentCategory> KnowledgeBaseParentCategories { get; set; }  
        public DbSet<KnowledgeBaseTag> KnowledgeBaseTags { get; set; }  
        public DbSet<KnowledgeBaseTagConnect> KnowledgeBaseTagConnects { get; set; }  
        public DbSet<Knp> Knps { get; set; }  
        public DbSet<ListClientNotMobileApp> ListClientNotMobileApps { get; set; }  
        public DbSet<LoanStatus> LoanStatuses { get; set; }  
        public DbSet<LoanTechStatus> LoanTechStatuses { get; set; }  
        public DbSet<Log4NetLog> Log4NetLogs { get; set; }  
        public DbSet<Log4NetLogAdminGlobalExceptionLog> Log4NetLogAdminGlobalExceptionLogs { get; set; }  
        public DbSet<Log4NetLogAuthLog> Log4NetLogAuthLogs { get; set; }  
        public DbSet<Log4NetLogAuthLogArh> Log4NetLogAuthLogArhs { get; set; }  
        public DbSet<Log4NetLogCurAcc> Log4NetLogCurAccs { get; set; }  
        public DbSet<Log4NetLogCurAccArh> Log4NetLogCurAccArhs { get; set; }  
        public DbSet<Log4NetLogPnserviceLog> Log4NetLogPnserviceLogs { get; set; }  
        public DbSet<LogClientEnrollment> LogClientEnrollments { get; set; }  
        public DbSet<LogErrorInfo> LogErrorInfos { get; set; }  
        public DbSet<LogErrorInfoArh> LogErrorInfoArhs { get; set; }  
        public DbSet<LogErrorInfoOld> LogErrorInfoOlds { get; set; }  
        public DbSet<LogMobileErrorInfo> LogMobileErrorInfos { get; set; }  
        public DbSet<LogMobileErrorInfoRequest> LogMobileErrorInfoRequests { get; set; }  
        public DbSet<LogMobileErrorNotifyEmail> LogMobileErrorNotifyEmails { get; set; }  
        public DbSet<LogOtpStageEnrollment> LogOtpStageEnrollments { get; set; }  
        public DbSet<LogOtpStageEnrollmentCrm> LogOtpStageEnrollmentCrms { get; set; }  
        public DbSet<LogService> LogServices { get; set; }  
        public DbSet<LogSoapEnvelope> LogSoapEnvelopes { get; set; }  
        public DbSet<LogSoapEnvelopeArh> LogSoapEnvelopeArhs { get; set; }  
        public DbSet<LogSoapEnvelopeOldTemp> LogSoapEnvelopeOldTemps { get; set; }  
        public DbSet<LogSystem> LogSystems { get; set; }  
        public DbSet<LogsInfo> LogsInfos { get; set; }  
        public DbSet<LongOrder> LongOrders { get; set; }  
        public DbSet<LongOrder2> LongOrder2s { get; set; }  
        public DbSet<LongOrderAgrPar> LongOrderAgrPars { get; set; }  
        public DbSet<LongOrderCheck2> LongOrderCheck2s { get; set; }  
        public DbSet<LongOrderFile> LongOrderFiles { get; set; }  
        public DbSet<LongOrderFiles2> LongOrderFiles2s { get; set; }  
        public DbSet<LongOrderPurpose> LongOrderPurposes { get; set; }  
        public DbSet<LongOrderSmslog> LongOrderSmslogs { get; set; }  
        public DbSet<LongOrderSmslog2> LongOrderSmslog2s { get; set; }  
        public DbSet<LongOrderStatus> LongOrderStatuses { get; set; }  
        public DbSet<LongOrderType> LongOrderTypes { get; set; }  
        public DbSet<LotStageProcessDeleted> LotStageProcessDeleteds { get; set; }  
        public DbSet<MapKnpTransferType> MapKnpTransferTypes { get; set; }  
        public DbSet<MigrationHistory> MigrationHistories { get; set; }  
        public DbSet<MilitaryExcludeUser> MilitaryExcludeUsers { get; set; }  
        public DbSet<MilitaryHoldOverUser> MilitaryHoldOverUsers { get; set; }  
        public DbSet<MioErrorLog> MioErrorLogs { get; set; }  
        public DbSet<MobileInterfaceLanguage> MobileInterfaceLanguages { get; set; }  
        public DbSet<Module> Modules { get; set; }  
        public DbSet<ModuleAction> ModuleActions { get; set; }  
        public DbSet<MyDocumentsMenu> MyDocumentsMenus { get; set; }  
        public DbSet<MyDocumentsMenuReadFile> MyDocumentsMenuReadFiles { get; set; }  
        public DbSet<News> News { get; set; }  
        public DbSet<NewsStatus> NewsStatuses { get; set; }  
        public DbSet<Notification> Notifications { get; set; }  
        public DbSet<NotificationArchive> NotificationArchives { get; set; }  
        public DbSet<NotificationCategory> NotificationCategories { get; set; }  
        public DbSet<NotificationOperationRoute> NotificationOperationRoutes { get; set; }  
        public DbSet<NotificationStatus> NotificationStatuses { get; set; }  
        public DbSet<NotificationType> NotificationTypes { get; set; }  
        public DbSet<OperBlock> OperBlocks { get; set; }  
        public DbSet<OtpCode> OtpCodes { get; set; }  
        public DbSet<P51020> P51020s { get; set; }  
        public DbSet<P51020CrmInfo> P51020CrmInfos { get; set; }  
        public DbSet<Passcode> Passcodes { get; set; }  
        public DbSet<Personal> Personals { get; set; }  
        public DbSet<PersonalLoginLog> PersonalLoginLogs { get; set; }  
        public DbSet<PnOneOffUrl> PnOneOffUrls { get; set; }  
        public DbSet<PnToken> PnTokens { get; set; }  
        public DbSet<Postdeposit> Postdeposits { get; set; }  
        public DbSet<PostdepositErrorLog> PostdepositErrorLogs { get; set; }  
        public DbSet<PreQualification> PreQualifications { get; set; }  
        public DbSet<PreQualificationReply> PreQualificationReplies { get; set; }  
        public DbSet<PreQualificationStage> PreQualificationStages { get; set; }  
        public DbSet<PushNotification> PushNotifications { get; set; }  
        public DbSet<PushStatus> PushStatuses { get; set; }  
        public DbSet<Rate> Rates { get; set; }  
        public DbSet<RegCountFromDate> RegCountFromDates { get; set; }  
        public DbSet<RegDepClientCount> RegDepClientCounts { get; set; }  
        public DbSet<RegisterIpFromDate> RegisterIpFromDates { get; set; }  
        public DbSet<Relation> Relations { get; set; }  
        public DbSet<Request> Requests { get; set; }  
        public DbSet<RequestsHistory> RequestsHistories { get; set; }  
        public DbSet<RequestsStatusType> RequestsStatusTypes { get; set; }  
        public DbSet<RequestsType> RequestsTypes { get; set; }  
        public DbSet<ResourceTxt> ResourceTxts { get; set; }  
        public DbSet<Role> Roles { get; set; }  
        public DbSet<RoleAccess> RoleAccesses { get; set; }  
        public DbSet<RoleActionType> RoleActionTypes { get; set; }  
        public DbSet<RoleModule> RoleModules { get; set; }  
        public DbSet<RoleOperation> RoleOperations { get; set; }  
        public DbSet<RoleOperationAction> RoleOperationActions { get; set; }  
        public DbSet<RolesAndOperation> RolesAndOperations { get; set; }  
        public DbSet<RssNews> RssNews { get; set; }  
        public DbSet<RunaObj> RunaObjs { get; set; }  
        public DbSet<RunaObjProp> RunaObjProps { get; set; }  
        public DbSet<RunaObjType> RunaObjTypes { get; set; }  
        public DbSet<RunaOpv> RunaOpvs { get; set; }  
        public DbSet<RunaUserNotify> RunaUserNotifies { get; set; }  
        public DbSet<SendedToBpmlog> SendedToBpmlogs { get; set; }  
        public DbSet<ServiceBusCache> ServiceBusCaches { get; set; }  
        public DbSet<ServiceFile> ServiceFiles { get; set; }  
        public DbSet<Setting> Settings { get; set; }  
        public DbSet<SiteSetting> SiteSettings { get; set; }  
        public DbSet<SmsSendInfo> SmsSendInfos { get; set; }  
        public DbSet<SmsSendLog> SmsSendLogs { get; set; }  
        public DbSet<Sqliinresult> Sqliinresults { get; set; }  
        public DbSet<StandingOrder> StandingOrders { get; set; }  
        public DbSet<StandingOrderProcess> StandingOrderProcesses { get; set; }  
        public DbSet<StandingOrderStage> StandingOrderStages { get; set; }  
        public DbSet<SubAgreement> SubAgreements { get; set; }  
        public DbSet<SynchronizeColvir> SynchronizeColvirs { get; set; }  
        public DbSet<Transfer> Transfers { get; set; }  
        public DbSet<TransferSetting> TransferSettings { get; set; }  
        public DbSet<TransferType> TransferTypes { get; set; }  
        public DbSet<UniqueLogonCountFromDate> UniqueLogonCountFromDates { get; set; }  
        public DbSet<UsdisplayObjectGoal> UsdisplayObjectGoals { get; set; }  
        public DbSet<UsdisplayObjectName> UsdisplayObjectNames { get; set; }  
        public DbSet<User> Users { get; set; }  
        public DbSet<UserAccess> UserAccesses { get; set; }  
        public DbSet<UserAccessLog> UserAccessLogs { get; set; }  
        public DbSet<UserCountByFilial> UserCountByFilials { get; set; }  
        public DbSet<UserFile> UserFiles { get; set; }  
        public DbSet<UserFileSignInfo> UserFileSignInfos { get; set; }  
        public DbSet<UserFileType> UserFileTypes { get; set; }  
        public DbSet<UserFilesPki> UserFilesPkis { get; set; }  
        public DbSet<UserNotifyRepaymentSchedule> UserNotifyRepaymentSchedules { get; set; }  
        public DbSet<UserRole> UserRoles { get; set; }  
        public DbSet<UserToDeactivate> UserToDeactivates { get; set; }  
        public DbSet<UsersAndRolesDictionary> UsersAndRolesDictionaries { get; set; }  
        public DbSet<UsersAndRolesDictionaryHasAccess> UsersAndRolesDictionaryHasAccesses { get; set; }  
        public DbSet<VideoBanner> VideoBanners { get; set; }  
        public DbSet<VideoBannerUserDeviceViewed> VideoBannerUserDeviceVieweds { get; set; }  
        public DbSet<ViewBiStandingOrder> ViewBiStandingOrders { get; set; }  
        public DbSet<ViewBiStandingOrderPayment> ViewBiStandingOrderPayments { get; set; }  
        public DbSet<ViewForTest> ViewForTests { get; set; }  
        public DbSet<ViewSmsSendOtpLog> ViewSmsSendOtpLogs { get; set; }  
        public DbSet<WorkingDay> WorkingDays { get; set; }
        public DbSet<WsLog> WsLogs { get; set; }  

    }
}
