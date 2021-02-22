using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace DataSide
{
    #region Basic classes
    public class BidsVersion
    {
        public int BidsVersionID { get; set; }
        public string Product {get;set;}
        public string ProductLine { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public double BidPrice { get; set; }

        public BidsVersion(int iD,string[] aRow)
        {
            BidsVersionID = iD;
            Product = aRow[0];
            ProductLine = aRow[1];
            PartNumber = aRow[2];
            BidPrice = Convert.ToDouble(aRow[4]);
        }
    }

    public class Claim
    {
        public int ClaimId { get; set; }
        public string ClaimRequest { get; set; }
        public string ResellerName { get; set; }
        public string EndUserName { get; set; }
        public string EndCustomerName { get; set; }
        public string AgreementControl { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public int ClaimedQty { get; set; }
        public int RebateQty { get; set; }
        public double RebateAmt { get; set; }

        public Claim(int iD, string[] aRow)
        {
            ClaimId = iD;
            ClaimRequest = aRow[0];
            ResellerName = aRow[1];
            EndUserName = aRow[2];
            EndCustomerName = aRow[3];
            AgreementControl = aRow[4];
            Material = aRow[5];
            Description = aRow[6];
            ClaimedQty = Convert.ToInt32(aRow[7]);
            RebateQty = Convert.ToInt32(aRow[8] == string.Empty ? "0": aRow[8]);
            RebateAmt = Convert.ToDouble(aRow[9]);
        }
    }

    public class Sale
    {
        public int SalesID { get; set; }
        public string InvoiceDate { get; set; }
        public int Quarter { get; set; }
        public string Distributor { get; set; }
        public string Reseller { get; set; }
        public string ProductLine { get; set; }
        public string PartNumber { get; set; }
        public string ProductDescription { get; set; }
        public int Unit { get; set; }
        public double Revenue { get; set; }

        public Sale(int iD, string[] aRow)
        {
            SalesID = iD;
            InvoiceDate = aRow[0];
            Quarter = Convert.ToInt32(aRow[1]);
            Distributor = aRow[2];
            Reseller = aRow[3];
            ProductLine = aRow[4];
            PartNumber = aRow[5];
            ProductDescription = aRow[6];
            Unit = Convert.ToInt32(aRow[7]);
            Revenue = Convert.ToDouble(aRow[8]);
        }
    }
    #endregion

    #region Listview classes

    public class Task2OptionAndTray : ListViewItemInterface
    {
        ListViewItem anOptionAndTrayListview;

        public Task2OptionAndTray (string invoiceDate, int quarter, string distributor, string reseller,
            string productLine, string partNumber, string productDescription, int unit, double revenue)
        {
            anOptionAndTrayListview = new ListViewItem(invoiceDate);
            anOptionAndTrayListview.SubItems.Add(quarter.ToString());
            anOptionAndTrayListview.SubItems.Add(distributor);
            anOptionAndTrayListview.SubItems.Add(reseller);
            anOptionAndTrayListview.SubItems.Add(productLine);
            anOptionAndTrayListview.SubItems.Add(partNumber);
            anOptionAndTrayListview.SubItems.Add(productDescription);
            anOptionAndTrayListview.SubItems.Add(unit.ToString());
            anOptionAndTrayListview.SubItems.Add(revenue.ToString());
        }

        public ListViewItem ListViewItemForTable
        {
            get
            {
                return anOptionAndTrayListview;
            }
        }
    }

    public class Task2SumOfSalesTransaction : ListViewItemInterface
    {
        ListViewItem Task2SumOfSalesTransactionListview;

        public Task2SumOfSalesTransaction(int quarter, string distributor, double revenjue)
        {
            Task2SumOfSalesTransactionListview = new ListViewItem(quarter.ToString());
            Task2SumOfSalesTransactionListview.SubItems.Add(distributor);
            Task2SumOfSalesTransactionListview.SubItems.Add(revenjue.ToString());
        }

        public ListViewItem ListViewItemForTable
        {
            get
            {
                return Task2SumOfSalesTransactionListview;
            }
        }
    }

    public class Task2TopTenResellers : ListViewItemInterface
    {
        public double SumOfUnits { get; set; }

        ListViewItem Task2TopTenResellersListView;

        public Task2TopTenResellers(string reseller, double sumOfUnits)
        {
            SumOfUnits = sumOfUnits;

            Task2TopTenResellersListView = new ListViewItem(reseller);
            Task2TopTenResellersListView.SubItems.Add(sumOfUnits.ToString());
        }

        public ListViewItem ListViewItemForTable
        {
            get
            {
                return Task2TopTenResellersListView;
            }
        }
    }

    public class Task3CompareBidsVersionPrices : ListViewItemInterface
    {
        ListViewItem ComparedBidsVersionListViewItem;

        public Task3CompareBidsVersionPrices(string product, string productLine, string partNumber, int quantity, double bidPrice, double percentage, double secondPrice)
        {
            ComparedBidsVersionListViewItem = new ListViewItem(product);
            ComparedBidsVersionListViewItem.SubItems.Add(productLine);
            ComparedBidsVersionListViewItem.SubItems.Add(partNumber);
            ComparedBidsVersionListViewItem.SubItems.Add(quantity.ToString());
            ComparedBidsVersionListViewItem.SubItems.Add(bidPrice.ToString());
            ComparedBidsVersionListViewItem.SubItems.Add(percentage.ToString());
            ComparedBidsVersionListViewItem.SubItems.Add(secondPrice.ToString());
        }

        public ListViewItem ListViewItemForTable
        {
            get
            {
                return ComparedBidsVersionListViewItem;
            }
        }
    }

    public class Task4ClaimFilled : ListViewItemInterface
    {
        ListViewItem Task4ClaimFilledListView;

        public Task4ClaimFilled(string claimRequest, string resellerName, string endUserName,string endCustomerName, string agreementControl,
            string material, string description, int claimedQty, int rebateQty, double rebateAmt)
        {
            Task4ClaimFilledListView = new ListViewItem(claimRequest);
            Task4ClaimFilledListView.SubItems.Add(resellerName);
            Task4ClaimFilledListView.SubItems.Add(endUserName);
            Task4ClaimFilledListView.SubItems.Add(endCustomerName);
            Task4ClaimFilledListView.SubItems.Add(agreementControl);
            Task4ClaimFilledListView.SubItems.Add(material);
            Task4ClaimFilledListView.SubItems.Add(description);
            Task4ClaimFilledListView.SubItems.Add(claimedQty.ToString());
            Task4ClaimFilledListView.SubItems.Add(rebateQty.ToString());
            Task4ClaimFilledListView.SubItems.Add(rebateAmt.ToString());
        }

        public ListViewItem ListViewItemForTable
        {
            get
            {
                return Task4ClaimFilledListView;
            }
        }
    }

    public class ListviewColumnName
    {
        public int ColumnIdentifier { get; set; }
        public string ColumnName { get; set; }

        public ListviewColumnName(int columnIdentifier, string columnName)
        {
            ColumnIdentifier = columnIdentifier;
            ColumnName = columnName;
        }
    }
    #endregion
}
