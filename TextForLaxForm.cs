using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexmark_Tamas_Cser
{
    class TextForLaxForm
    {
        public const string LabelMainText = "Small program for Lexmark car fleet coordinator position";
        public const string LabelRequest = "Requested Excel test queries";

        public const string Sales00InvoiceDate = "Invoice Date";
        public const string Sales01Quarter = "Quarter";
        public const string Sales02Distributor = "Distributor";
        public const string Sales03Reseller = "Reseller";
        public const string Sales04ProductLine= "Product Line";
        public const string Sales05PartNumber = "Part Number";
        public const string Sales06ProductDescription = "Product Description";
        public const string Sales07Units = "Units";
        public const string Sales08Revenue = "Revenue";

        public const string SumOfSalesTransaction00 = "Quarter"; 
        public const string SumOfSalesTransaction01 = "Distributor";
        public const string SumOfSalesTransaction02 = "Sum of Revenue";

        public const string TopTenSellers00 = "Reseller";
        public const string TopTenSellers01 = "Sum of Units";

        public const string CompareBidsVersionPrices00 = "Product";
        public const string CompareBidsVersionPrices01 = "Product Line";
        public const string CompareBidsVersionPrices02 = "Part Number";
        public const string CompareBidsVersionPrices03 = "Quantity";
        public const string CompareBidsVersionPrices04 = "Bid1 Price";
        public const string CompareBidsVersionPrices05 = "Percentage";
        public const string CompareBidsVersionPrices06 = "Bid2 Price";

        public const string ClaimFilledClaimRequest00 = "Claim Request";
        public const string ClaimFilledResellerName01 = "Reseller Name";
        public const string ClaimFilledEnUserName02 = "End User Name";
        public const string ClaimFilledEndCustomerName03 = "End Customer Name";
        public const string ClaimFilledAgreementControl04 = "Agreement Control";
        public const string ClaimFilledMaterial05 = "Material";
        public const string ClaimFilledDescription06 = "Description";
        public const string ClaimFilledClaimedQty07 = "Claimed Qty";
        public const string ClaimFilledRebateQty08 = "Rebate Qty";
        public const string ClaimFilledRebateAmt09 = "Rebate Amt";

        public const string ComboSalesOptionAndTray = "Products that are Options and are Trays";
        public const string ComboSumOfSalesTransaction = "Sum of the sales transaction by distributor by quarter";
        public const string ComboTopTenSellersAccordingToUnits = "Summarise the sales transactions to show only the top 10 resellers based on unit sales";
        public const string ComboBid1Bid2Comparison = "Comparison Bid1 and Bid2 prices. Show the change in price as a percentage of the original price";
        public const string ComboClaimFilled = "Update End Customer Name and Rebate Quantity";
    }
}
