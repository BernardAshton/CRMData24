using System;
using System.ComponentModel.DataAnnotations;

namespace Sage200_MVC.Models
{
    public class AlternativeItem
    {
        public long AlternativeItemID { get; set; }
        [Key]
        public long ItemID { get; set; }
        public long ItemAlternativeID { get; set; }
        public bool Preferred { get; set; }
        public byte[] OpLock { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
	public class CustDeliveryAddress
	{
        [Key]
        public long CustDeliveryAddressID { get; set; }
        public long CustomerID { get; set; }
        public string Description { get; set; }
        public string PostalName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string PostCode { get; set; }
        public string Contact { get; set; }
        public string TelephoneNo { get; set; }
        public string FaxNo { get; set; }
        public string EmailAddress { get; set; }
        public string TaxNo { get; set; }
        public long TaxCodeID { get; set; }
        public Nullable<long> CountryCodeID { get; set; }
        public bool ThisIsDefaultAddress { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public Nullable<long> AddressCountryCodeID { get; set; }
    }
    public partial class CustDeliveryAddressX
    {
        [Key]
        public long CustDeliveryAddressXID { get; set; }
        public string DomesticBDM { get; set; }
        public string CommercialBDM { get; set; }
        public string Branch { get; set; }
        public bool BookIn { get; set; }
        public decimal CustomerForecast { get; set; }
    }
    public partial class PLSupplierAccount
    {
        public long PLSupplierAccountID { get; set; }
        public string SupplierAccountNumber { get; set; }
        public string SupplierAccountName { get; set; }
        public string SupplierAccountShortName { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public long SYSCurrencyID { get; set; }
        public long SYSExchangeRateTypeID { get; set; }
        public long SYSCountryCodeID { get; set; }
        public Nullable<long> PLFactorHouseID { get; set; }
        public long DefaultSYSTaxRateID { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public short MonthsToKeepTransactionsFor { get; set; }
        public string DefaultOrderPriority { get; set; }
        public string DefaultNominalAccountNumber { get; set; }
        public string DefaultNominalCostCentre { get; set; }
        public string DefaultNominalDepartment { get; set; }
        public long SYSAccountTypeID { get; set; }
        public long PLPaymentGroupID { get; set; }
        public decimal EarlySettlementDiscountPercent { get; set; }
        public short DaysEarlySettlementDiscApplies { get; set; }
        public short PaymentTermsInDays { get; set; }
        public long SYSPaymentTermsBasisID { get; set; }
        public bool AccountIsOnHold { get; set; }
        public decimal ValueOfCurrentOrdersInPOP { get; set; }
        public Nullable<System.DateTime> DateAccountDetailsLastChanged { get; set; }
        public Nullable<System.DateTime> DateOfLastTransaction { get; set; }
        public string EuroAccountNumberCopiedFromTo { get; set; }
        public Nullable<System.DateTime> DateEuroAccountCopied { get; set; }
        public bool UseTransactionEMail { get; set; }
        public Nullable<long> SYSCreditBureauID { get; set; }
        public Nullable<long> SYSCreditPositionID { get; set; }
        public string TradingTerms { get; set; }
        public string CreditReference { get; set; }
        public Nullable<System.DateTime> AccountOpened { get; set; }
        public Nullable<System.DateTime> LastCreditReview { get; set; }
        public Nullable<System.DateTime> NextCreditReview { get; set; }
        public Nullable<System.DateTime> ApplicationDate { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public bool TermsAgreed { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; }
        public string SpareText2 { get; set; }
        public string SpareText3 { get; set; }
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public Nullable<System.DateTime> SpareDate1 { get; set; }
        public Nullable<System.DateTime> SpareDate2 { get; set; }
        public Nullable<System.DateTime> SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public string MainTelephoneAreaCode { get; set; }
        public string MainTelephoneCountryCode { get; set; }
        public string MainTelephoneSubscriberNumber { get; set; }
        public string MainFaxAreaCode { get; set; }
        public string MainFaxCountryCode { get; set; }
        public string MainFaxSubscriberNumber { get; set; }
        public string MainWebsite { get; set; }
    }
    public partial class PriceBand
    {
        [Key]
        public long PriceBandID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ThisIsTheStandardBand { get; set; }
        public Nullable<long> CurrencyID { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
    }
    public partial class ProductGroup       // Added Manually 01/08/2015
    {
        public long ProductGroupID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool UseDescriptionOnDocs { get; set; }
        public long StockItemTypeID { get; set; }
        public long CostingMethodID { get; set; }
        public System.Int16 StocktakeCyclePeriod { get; set; }
        public bool DoItemsMaintainHistory { get; set; }
        public bool DoItemsUseMarkup { get; set; }
        public decimal MarkupPercent { get; set; }
        public bool CanItemLevelsGoNegative { get; set; }
        public bool DoItemsUseUnits { get; set; }
        public bool SellQuantsUseMultUnits { get; set; }
        public bool BuyQuantsUseMultUnits { get; set; }
        public bool SellPricesUseMultUnits { get; set; }
        public bool BuyPricesUseMultUnits { get; set; }
        public bool ThisIsTheSOPProductGroup { get; set; }
        public long TraceableTypeID { get; set; }
        public bool SaleFromSingleBatch { get; set; }
        public bool AllowDuplicateNumbers { get; set; }
        public bool UsesAlternativeRef { get; set; }
        public bool UsesSellByDate { get; set; }
        public bool UsesUseByDate { get; set; }
        public System.DateTime? LastArchivedUpTo { get; set; }
        public System.DateTime? LastTraceArchivedUpTo { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public bool UseLandedCosts { get; set; }
        public long LandedCostsTypeID { get; set; }
        public decimal LandedCostsValue { get; set; }
        public long STKLabelPrintingOptionTypeID { get; set; }
        public bool UsesRCV { get; set; }
    }
    public partial class SLAccountMemo
    {
        public long SLAccountMemoID { get; set; }
        public long SLCustomerAccountID { get; set; }
        public string MemoText { get; set; }
        public string MemoCreatedBy { get; set; }
        public System.DateTime TimeAndDateMemoCreated { get; set; }
        public bool Active { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public long SYSAccountMemoTypeID { get; set; }
    }
    public class SLCustomerAccount
    {
        [Key]
        public long SLCustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountName { get; set; }
        public string CustomerAccountShortName { get; set; }
        public decimal AccountBalance { get; set; }
        public decimal CreditLimit { get; set; }
        public long SYSCurrencyID { get; set; }
        public long SYSExchangeRateTypeID { get; set; }
        public long SYSCountryCodeID { get; set; }
        public long DefaultSYSTaxRateID { get; set; }
        public string TaxRegistrationNumber { get; set; }
        public short MonthsToKeepTransactionsFor { get; set; }
        public string DefaultOrderPriority { get; set; }
        public Nullable<long> SLFinanceChargeID { get; set; }
        public string DefaultNominalAccountNumber { get; set; }
        public string DefaultNominalCostCentre { get; set; }
        public string DefaultNominalDepartment { get; set; }
        public long SYSAccountTypeID { get; set; }
        public decimal EarlySettlementDiscountPercent { get; set; }
        public short DaysEarlySettlementDiscApplies { get; set; }
        public short PaymentTermsInDays { get; set; }
        public long SYSPaymentTermsBasisID { get; set; }
        public bool UseConsolidatedBilling { get; set; }
        public decimal InvoiceLineDiscountPercent { get; set; }
        public decimal InvoiceDiscountPercent { get; set; }
        public long SLAssociatedOfficeTypeID { get; set; }
        public Nullable<long> AssociatedHeadOfficeAccountID { get; set; }
        public bool SendCopyStatementToBranch { get; set; }
        public Nullable<long> CustomerDiscountGroupID { get; set; }
        public Nullable<long> PriceBandID { get; set; }
        public Nullable<long> OrderValueDiscountID { get; set; }
        public bool AccountIsOnHold { get; set; }
        public decimal ValueOfCurrentOrdersInSOP { get; set; }
        public System.DateTime DateAccountDetailsLastChanged { get; set; }
        public Nullable<System.DateTime> DateOfLastTransaction { get; set; }
        public string EuroAccountNumberCopiedFromTo { get; set; }
        public Nullable<System.DateTime> DateEuroAccountCopied { get; set; }
        public bool UseTransactionEMail { get; set; }
        public Nullable<System.DateTime> DateFinanceChargeLastRun { get; set; }
        public Nullable<long> SYSCreditBureauID { get; set; }
        public Nullable<long> SYSCreditPositionID { get; set; }
        public string TradingTerms { get; set; }
        public string CreditReference { get; set; }
        public int AverageTimeToPay { get; set; }
        public Nullable<System.DateTime> AccountOpened { get; set; }
        public Nullable<System.DateTime> LastCreditReview { get; set; }
        public Nullable<System.DateTime> NextCreditReview { get; set; }
        public Nullable<System.DateTime> ApplicationDate { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public bool TermsAgreed { get; set; }
        public bool UseTaxCodeAsDefault { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public Nullable<System.DateTime> AvgTimeToPayDateLastUpdated { get; set; }
        public string SpareText1 { get; set; }
        public string SpareText2 { get; set; }
        public string SpareText3 { get; set; }
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public Nullable<System.DateTime> SpareDate1 { get; set; }
        public Nullable<System.DateTime> SpareDate2 { get; set; }
        public Nullable<System.DateTime> SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public string DUNSCode { get; set; }
        public string MainTelephoneAreaCode { get; set; }
        public string MainTelephoneCountryCode { get; set; }
        public string MainTelephoneSubscriberNumber { get; set; }
        public string MainFaxAreaCode { get; set; }
        public string MainFaxCountryCode { get; set; }
        public string MainFaxSubscriberNumber { get; set; }
        public string MainWebsite { get; set; }
        public string AnalysisCode1 { get; set; }
        public string AnalysisCode2 { get; set; }
        public string AnalysisCode3 { get; set; }
        public string AnalysisCode4 { get; set; }
        public string AnalysisCode5 { get; set; }
        public string AnalysisCode6 { get; set; }
        public string AnalysisCode7 { get; set; }
        public string AnalysisCode8 { get; set; }
        public string AnalysisCode9 { get; set; }
        public string AnalysisCode10 { get; set; }
        public string AnalysisCode11 { get; set; }
        public string AnalysisCode12 { get; set; }
        public string AnalysisCode13 { get; set; }
        public string AnalysisCode14 { get; set; }
        public string AnalysisCode15 { get; set; }
        public string AnalysisCode16 { get; set; }
        public string AnalysisCode17 { get; set; }
        public string AnalysisCode18 { get; set; }
        public string AnalysisCode19 { get; set; }
        public string AnalysisCode20 { get; set; }
    }
    
    public class SOPCancelledLine                           // Produced using SQL Script
    {
        public long SOPCancelledLineID { get; set; }
        public long SOPOrderReturnID { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public decimal CancelledQuantity { get; set; }
        public DateTime CancelledDate { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string SellingUnitDescription { get; set; }
        public byte[] OpLock { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public decimal StockUnitCancelledQuantity { get; set; }
    }
    
    public partial class SOPDespatchReceiptLine
    {
        public long SOPDespatchReceiptLineID { get; set; }
        public long SOPDespatchReceiptID { get; set; }
        public long SOPOrderReturnLineID { get; set; }
        public Nullable<long> SOPInvoiceCreditLineID { get; set; }
        public string DespatchReceiptNo { get; set; }
        public string OrderReturnNo { get; set; }
        public string InvoiceCreditNo { get; set; }
        public long BinItemID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public decimal DespatchReceiptQuantity { get; set; }
        public System.DateTime DespatchReceiptDate { get; set; }
        public bool IsInvoiced { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public long IntrastatStatusID { get; set; }
        public decimal StockUnitDespRcptQuantity { get; set; }
    }
    public partial class SOPInvoiceCreditLine
    {
        public long SOPInvoiceCreditLineID { get; set; }
        public long SOPInvoiceCreditID { get; set; }
        public Nullable<long> SOPOrderReturnLineID { get; set; }
        public short PrintSequenceNumber { get; set; }
        public string DespatchReceiptNos { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public decimal InvoiceCreditQuantity { get; set; }
        public System.DateTime InvoiceCreditDate { get; set; }
        public decimal OutstandingQuantity { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public decimal LineDiscountPercent { get; set; }
        public string OrderReturnNo { get; set; }               // DocumentNo or OrderNo
        public Nullable<bool> OrderReturnArchived { get; set; }
        public Nullable<long> TEMMessageID { get; set; }
        public Nullable<short> TEMmessageLineNo { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public decimal ItemPrice { get; set; }
        public Nullable<long> SYSTaxRateID { get; set; }
        public string ItemName { get; set; }
        public Nullable<long> SOPOrderReturnID { get; set; }
    }
    public partial class SOPOrderReturn
    {
        public long SOPOrderReturnID { get; set; }
        public long DocumentTypeID { get; set; }
        public string DocumentNo { get; set; }
        public Nullable<System.DateTime> DocumentDate { get; set; }
        public long DocumentStatusID { get; set; }
        public long DocumentPrintStatusID { get; set; }
        public string CustomerDocumentNo { get; set; }
        public long CustomerID { get; set; }
        public long CustomerTypeID { get; set; }
        public Nullable<System.DateTime> RequestedDeliveryDate { get; set; }
        public Nullable<System.DateTime> PromisedDeliveryDate { get; set; }
        public Nullable<long> WarehouseID { get; set; }
        public Nullable<long> CurrencyID { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal SubtotalGoodsValue { get; set; }
        public decimal SubtotalChargesNetValue { get; set; }
        public decimal SubtotalChargesTaxValue { get; set; }
        public decimal SubtotalDiscountValue { get; set; }
        public decimal TotalNetValue { get; set; }
        public decimal TotalTaxValue { get; set; }
        public decimal TotalGrossValue { get; set; }
        public bool UseInvoiceAddress { get; set; }
        public bool PaymentWithOrder { get; set; }
        public long PaymentTypeID { get; set; }
        public decimal PaymentValue { get; set; }
        public string PaymentReference { get; set; }
        public Nullable<long> PaymentBankAccountID { get; set; }
        public string PaymentNominalAccountRef { get; set; }
        public string PaymentNominalCostCentre { get; set; }
        public string PaymentNominalDepartment { get; set; }
        public Nullable<long> PaymentNominalCodeID { get; set; }
        public bool PaymentInvoiced { get; set; }
        public decimal SettlementDiscPercent { get; set; }
        public short SettlementDiscountDays { get; set; }
        public decimal DocumentDiscountPercent { get; set; }
        public string DocumentCreatedBy { get; set; }
        public string Priority { get; set; }
        public string AnalysisCode1 { get; set; }
        public string AnalysisCode2 { get; set; }
        public string AnalysisCode3 { get; set; }
        public string AnalysisCode4 { get; set; }
        public string AnalysisCode5 { get; set; }
        public string AnalysisCode6 { get; set; }
        public short IntrastatStatus { get; set; }
        public long SourceTypeID { get; set; }
        public string SourceDocumentNo { get; set; }
        public bool ArePricesTaxInclusive { get; set; }
        public bool ReadyForInvoicePrint { get; set; }
        public Nullable<System.DateTime> DocumentDueDate { get; set; }
        public Nullable<long> PaymentMethodID { get; set; }
        public bool BOMDetailsOnDespatchNote { get; set; }
        public string PaymentMethodName { get; set; }
        public decimal TotalGrossValueIncSett { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; }
        public string SpareText2 { get; set; }
        public string SpareText3 { get; set; }
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public Nullable<System.DateTime> SpareDate1 { get; set; }
        public Nullable<System.DateTime> SpareDate2 { get; set; }
        public Nullable<System.DateTime> SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public string ExternalReference { get; set; }
        public bool InvoicePaymentImmediately { get; set; }
        public string CRMReference { get; set; }
        public Nullable<long> CRMAccount { get; set; }
    }
    public partial class SOPOrderReturnLine
    {
        public long SOPOrderReturnLineID { get; set; }
        public long SOPOrderReturnID { get; set; }
        public short PrintSequenceNumber { get; set; }
        public long LineTypeID { get; set; }
        public string ItemCode { get; set; }
        public bool UseDescription { get; set; }
        public string ItemDescription { get; set; }
        public decimal LineQuantity { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public decimal UnitSellingPrice { get; set; }
        public bool UnitSellPriceOverridden { get; set; }
        public decimal UnitDiscountPercent { get; set; }
        public decimal UnitDiscountValue { get; set; }
        public bool DiscountPercentSpecified { get; set; }
        public bool UnitDiscountOverridden { get; set; }
        public decimal SellingUnitMultiple { get; set; }
        public decimal PricingUnitMultiple { get; set; }
        public Nullable<long> TaxCodeID { get; set; }
        public string NominalAccountRef { get; set; }
        public string NominalCostCentre { get; set; }
        public string NominalDepartment { get; set; }
        public Nullable<System.DateTime> RequestedDeliveryDate { get; set; }
        public Nullable<System.DateTime> PromisedDeliveryDate { get; set; }
        public string AnalysisCode1 { get; set; }
        public string AnalysisCode2 { get; set; }
        public string AnalysisCode3 { get; set; }
        public string AnalysisCode4 { get; set; }
        public string AnalysisCode5 { get; set; }
        public string AnalysisCode6 { get; set; }
        public bool ShowOnCustomerDocs { get; set; }
        public bool ApplyOrderValueDiscount { get; set; }
        public decimal AllocatedQuantity { get; set; }
        public bool RepeatOrderPricesFixed { get; set; }
        public decimal DespatchReceiptQuantity { get; set; }
        public decimal InvoiceCreditQuantity { get; set; }
        public string PricingUnitDescription { get; set; }
        public string SellingUnitDescription { get; set; }
        public Nullable<long> POPOrderReturnLineID { get; set; }
        public long BackToBackStatusID { get; set; }
        public bool AdditionalChargeInvoiced { get; set; }
        public bool IsLocked { get; set; }
        public decimal AvailableForDespatch { get; set; }
        public bool ReadyForInvoicePrint { get; set; }
        public decimal PostedInvoiceCreditQty { get; set; }
        public long StockItemTypeID { get; set; }
        public decimal TraceAvailForDespatch { get; set; }
        public decimal CostPrice { get; set; }
        public bool BOMDetailsOnDespatchNote { get; set; }
        public Nullable<long> TEMMessageID { get; set; }
        public Nullable<short> TEMmessageLineNo { get; set; }
        public decimal SellingUnitWeight { get; set; }
        public bool ShowOnDespatchNote { get; set; }
        public long TraceableTypeID { get; set; }
        public long ConfirmationIntentTypeID { get; set; }
        public string DespatchNoteComment { get; set; }
        public string PickingListComment { get; set; }
        public long ShowOnPickingListTypeID { get; set; }
        public long SOPOrderFulfilmentMethodID { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; }
        public string SpareText2 { get; set; }
        public string SpareText3 { get; set; }
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public Nullable<System.DateTime> SpareDate1 { get; set; }
        public Nullable<System.DateTime> SpareDate2 { get; set; }
        public Nullable<System.DateTime> SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public bool IncludeInMRP { get; set; }
        public decimal LineUnitPrecision { get; set; }
        public decimal StockUnitPrecision { get; set; }
        public decimal StockUnitLineQuantity { get; set; }
        public decimal StockUnitAllocatedQuantity { get; set; }
        public decimal StockUnitDespRcptQuantity { get; set; }
        public decimal StockUnitInvoiceCreditQuantity { get; set; }
        public decimal StockUnitPostedInvCredQty { get; set; }
        public decimal StockUnitAvailableForDespatch { get; set; }
        public decimal StockUnitMultiple { get; set; }
    }
    public class StockItem
    {
        [Key]
        public long ItemID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long ProductGroupID { get; set; }
        public string Description { get; set; }
        public bool UseDescriptionOnDocs { get; set; }
        public long TaxCodeID { get; set; }
        public decimal StandardCost { get; set; }
        public decimal SOPItemPrice { get; set; }
        public Nullable<long> StockItemStatusID { get; set; }
        public Nullable<System.DateTime> InactiveDate { get; set; }
        public string Manufacturer { get; set; }
        public string PartNumber { get; set; }
        public short StocktakeCyclePeriod { get; set; }
        public string CommodityCode { get; set; }
        public decimal Weight { get; set; }
        public bool SuppressNetMass { get; set; }
        public string StockUnitName { get; set; }
        public string BaseUnitName { get; set; }
        public decimal StockMultOfBaseUnit { get; set; }
        public string Barcode { get; set; }
        public Nullable<System.DateTime> StdCostVarianceLastReset { get; set; }
        public decimal AverageBuyingPrice { get; set; }
        public long TraceableTypeID { get; set; }
        public bool SaleFromSingleBatch { get; set; }
        public bool AllowDuplicateNumbers { get; set; }
        public bool UsesAlternativeRef { get; set; }
        public bool UsesSellByDate { get; set; }
        public bool UsesUseByDate { get; set; }
        public bool RecordNosOnGoodsReceived { get; set; }
        public Nullable<System.DateTime> LastArchivedUpTo { get; set; }
        public decimal FreeStockQuantity { get; set; }
        public Nullable<long> BOMItemTypeID { get; set; }
        public long SOPOrderFulfilmentMethodID { get; set; }
        public string DefaultDespatchNoteComment { get; set; }
        public string DefaultPickingListComment { get; set; }
        public decimal QuantityReserved { get; set; }
        public Nullable<System.DateTime> LastTraceArchivedUpTo { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public long LandedCostsTypeID { get; set; }
        public decimal LandedCostsValue { get; set; }
        public string SpareText1 { get; set; }
        public string SpareText2 { get; set; }
        public string SpareText3 { get; set; }
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public Nullable<System.DateTime> SpareDate1 { get; set; }
        public Nullable<System.DateTime> SpareDate2 { get; set; }
        public Nullable<System.DateTime> SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public bool AllowSalesOrder { get; set; }
        public long STKAutoGenerateOptionTypeID { get; set; }
        public string AutoGeneratePrefix { get; set; }
        public long AutoGenerateNextNumber { get; set; }
        public long STKLabelPrintingOptionTypeID { get; set; }
        public long STKFulfilmentSequenceTypeID { get; set; }
        public int ShelfLife { get; set; }
        public Nullable<long> STKShelfLifeTypeID { get; set; }
        public bool AllowOutOfDate { get; set; }
        public long STKAutoGenerateSeparatorID { get; set; }
        public int AutoGeneratePadding { get; set; }
        public Nullable<long> CountryOfOriginID { get; set; }
        public bool UsesSupplementaryUnit { get; set; }
        public decimal SupplementaryUnitConversionRatio { get; set; }
        public bool UsesRCV { get; set; }
        public bool IsWEEEItem { get; set; }
        public bool IncludeNosOnCountSheets { get; set; }
    }
    public partial class StockItemStatus
    {
        [Key]
        public long StockItemStatusID { get; set; }
        public string StockItemStatusName { get; set; }
    }
    public partial class StockItemSupplier
    {
        public long StockItemSupplierID { get; set; }
        public long ItemID { get; set; }
        public long SupplierID { get; set; }
        public string SupplierStockCode { get; set; }
        public short LeadTime { get; set; }
        public Nullable<long> LeadTimeUnitID { get; set; }
        public decimal UsualOrderQuantity { get; set; }
        public decimal MinimumOrderQuantity { get; set; }
        public bool Preferred { get; set; }
        public Nullable<System.DateTime> DateLastOrder { get; set; }
        public decimal LastBuyingPrice { get; set; }
        public decimal LastOrderQuantity { get; set; }
        public decimal OrderQuantityYTD { get; set; }
        public decimal OrderValueYTD { get; set; }
        public decimal QuantityOnOrder { get; set; }
        public decimal LastBaseBuyingPrice { get; set; }
        public decimal CataloguePrice { get; set; }
        public Nullable<System.DateTime> CataloguePriceDate { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public decimal ListPrice { get; set; }
        public decimal ListBasePrice { get; set; }
        public Nullable<System.DateTime> DateListPriceChanged { get; set; }
        public Nullable<System.DateTime> ListPriceExpiryDate { get; set; }
        public long DefaultPricingSourceTypeID { get; set; }
        public long LandedCostsTypeID { get; set; }
        public decimal LandedCostsValue { get; set; }
        public decimal ReorderMultipleQty { get; set; }
        public Nullable<long> CountryOfOriginID { get; set; }
    }
    public partial class SYSCreditPosition
    {
        public long SYSCreditPositionID { get; set; }
        public string Name { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
        public bool IsDefault { get; set; }
    }
    public partial class TraceableTransHistory
    {
        [Key]
        public long TraceableTransHistoryID { get; set; }
        public long TransactionHistoryID { get; set; }
        public long TraceableTransTypeID { get; set; }
        public long TraceableItemID { get; set; }
        public string IdentificationNo { get; set; }
        public string AdditionalReference { get; set; }
        public Nullable<System.DateTime> SellByDate { get; set; }
        public Nullable<System.DateTime> UseByDate { get; set; }
        public decimal Quantity { get; set; }
        public long TraceableItemStatusID { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
    }
    public class TransactionHistory
    {
        [Key]
        public long TransactionHistoryID { get; set; }
        public long ItemID { get; set; }
        public long TransactionTypeID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public decimal Quantity { get; set; }
        public long SourceAreaTypeID { get; set; }
        public string SourceAreaReference { get; set; }
        public string SourceAreaName { get; set; }
        public string Reference { get; set; }
        public string SecondReference { get; set; }
        public string WarehouseName { get; set; }
        public string BinName { get; set; }
        public decimal UnitCostPrice { get; set; }
        public decimal UnitIssuePrice { get; set; }
        public decimal UnitDiscountValue { get; set; }
        public decimal CostValue { get; set; }
        public decimal IssueValue { get; set; }
        public decimal TotalOrderDiscount { get; set; }
        public bool NominalUpdated { get; set; }
        public string Memo { get; set; }
        public string AnalysisCode1 { get; set; }
        public string AnalysisCode2 { get; set; }
        public string AnalysisCode3 { get; set; }
        public string UserName { get; set; }
        public Nullable<long> EntrySourceID { get; set; }
        public long PostingURN { get; set; }
        public short PostingSource { get; set; }
        public int PostingUser { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public byte[] OpLock { get; set; }
        public System.DateTime DateTimeCreated { get; set; }
    }
}
