using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace DataSide
{
    public class Queries
    {
        private const string Bids_1File = "Bids_version1.csv";
        private const string Bids_2File = "Bids_version2.csv";
        private const string SalesFile = "Sales.csv";
        private const string ClaimsFile = "Claims.csv";

        private const string ProductLineTextQ = "Options";
        private const string ProductDescriptionQ = "Tray";

        private static List<BidsVersion> bids1 = new List<BidsVersion>();
        private static List<BidsVersion> bids2 = new List<BidsVersion>();
        private static List<Sale> sales = new List<Sale>();
        private static List<Claim> claims = new List<Claim>();

        public static void DownloadAllWorksheets()
        {
            DownloadBasicData(1,Bids_1File);
            DownloadBasicData(2, Bids_2File);
            DownloadBasicData(3, SalesFile);
            DownloadBasicData(4, ClaimsFile);
        }

        private static void DownloadBasicData(int switchFile, string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string aRow = string.Empty;
                int newID = 1;

                switch(switchFile)
                {
                    case 1:
                        while ((aRow = reader.ReadLine()) != null)
                        {
                            bids1.Add(new BidsVersion(newID, aRow.Split(';')));
                            newID++;
                        }
                        bids1 = bids1.OrderBy(x => x.Product).ToList();
                        break;
                    case 2:
                        while ((aRow = reader.ReadLine()) != null)
                        {
                            bids2.Add(new BidsVersion(newID, aRow.Split(';')));
                            newID++;
                        }
                        break;
                    case 3:
                        while ((aRow = reader.ReadLine()) != null)
                        {
                            sales.Add(new Sale(newID, aRow.Split(';')));
                            newID++;
                        }
                        break;
                    case 4:
                        while ((aRow = reader.ReadLine()) != null)
                        {
                            claims.Add(new Claim(newID, aRow.Split(';')));
                            newID++;
                        }
                        break;
                }
            }
        }

        public static List<ListViewItem> Task2OptionAndTray ()
        {
            return (from a in sales
                    where a.ProductLine == ProductLineTextQ && a.ProductDescription.Contains(ProductDescriptionQ)
                    select(new Task2OptionAndTray(a.InvoiceDate,a.Quarter,a.Distributor,
                    a.Reseller,a.ProductLine,a.PartNumber,a.ProductDescription,a.Unit,a.Revenue).ListViewItemForTable)).ToList();
        }

        public static double SalesTotalRevenue ()
        {
            return Math.Round((from a in sales
                    where a.ProductLine == ProductLineTextQ && a.ProductDescription.Contains(ProductDescriptionQ)
                    select (a.Revenue)).Sum(),4);
        }

        public static List<ListViewItem> Task2SumOfSalesTransaction()
        {
            List<int> quarters = sales.Select(x => x.Quarter).Distinct().ToList();
            List<string> distributors = sales.Select(x => x.Distributor).Distinct().ToList();
            List<ListViewItem> result = new List<ListViewItem>();

            for(int i = 0; i< quarters.Count;i++)
            {
                int actualQuarter = quarters[i];

                for(int y = 0; y < distributors.Count;y++)
                {
                    string actualDistributor = distributors[y];
                    double sum = 0;

                    for(int z = 0; z < sales.Count; z++)
                    {
                        if(sales[z].Quarter == actualQuarter && sales[z].Distributor == actualDistributor)
                        {
                            sum += sales[z].Revenue;
                        }
                    }

                    result.Add(new Task2SumOfSalesTransaction(actualQuarter,actualDistributor,Math.Round(sum,4)).ListViewItemForTable);
                }
            }

            return result; 
        }

        public static List<ListViewItem> Task2TopTenSellers ()
        {
            List<string> dist = sales.Select(x => x.Reseller).Distinct().ToList();
            List<Task2TopTenResellers> top = new List<Task2TopTenResellers>();
            List<ListViewItem> listToBeAbleToReturnListViewItems = new List<ListViewItem>();

            for(int y = 0; y < dist.Count; y++)
            {
                int sum = 0;

                for (int i = 0; i < sales.Count-1; i++)
                {
                    if (sales[i].Reseller == dist[y])
                    {
                        sum += sales[i].Unit;
                    }

                }
                top.Add(new Task2TopTenResellers(dist[y],sum));
            }

            top = top.OrderByDescending(x=> x.SumOfUnits).ToList();

            for(int i=0;i < 10; i++)
            {
                listToBeAbleToReturnListViewItems.Add(top[i].ListViewItemForTable);
            }

            return listToBeAbleToReturnListViewItems;
        }

        public static List<ListViewItem> Task3Bid1Bid2 ()
        {
            List<ListViewItem> result = new List<ListViewItem>();
            List<BidsVersion> OrderedBid1 = bids1.OrderBy(x =>x.Product).ToList();
            for(int i = 0; i < OrderedBid1.Count; i++)
            {
                result.Add(new Task3CompareBidsVersionPrices(OrderedBid1[i].Product,
                    OrderedBid1[i].ProductLine,
                    OrderedBid1[i].PartNumber,
                    OrderedBid1[i].Quantity,
                    OrderedBid1[i].BidPrice,
                    Math.Round((bids1[i].BidPrice - bids2[i].BidPrice == 0 ? 0 : ((bids1[i].BidPrice-bids2[i].BidPrice)/bids1[i].BidPrice)*-100),2),
                    bids2[i].BidPrice).ListViewItemForTable);
            }

            return result;
        }

        public static List<ListViewItem> Task4ClaimFilled()
        {
            List<ListViewItem> result = new List<ListViewItem>();

            for(int i = 0; i < claims.Count; i++)
            {
                result.Add(new Task4ClaimFilled(
                    claims[i].ClaimRequest,
                    claims[i].ResellerName,
                    claims[i].EndUserName,
                    claims[i].EndUserName == "" ? claims[i].ResellerName : claims[i].EndUserName,
                        claims[i].AgreementControl,
                        claims[i].Material,
                        claims[i].Description,
                        claims[i].ClaimedQty,
                        claims[i].RebateAmt < 0 ? claims[i].ClaimedQty*-1 : claims[i].ClaimedQty,
                        claims[i].RebateAmt).ListViewItemForTable);
            }

            return result;
        }
    }
}
