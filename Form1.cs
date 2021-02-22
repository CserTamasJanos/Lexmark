using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSide;

namespace Lexmark_Tamas_Cser
{
    public partial class Form1 : Form
    {
        List<ListviewColumnName> columnNames = new List<ListviewColumnName>();

        /// <summary>
        /// Returns the names of the selected columns belong to the selected combobox Item.
        /// </summary>
        private List<ListviewColumnName> SelectedColumNames { get { return columnNames.Where(x => x.ColumnIdentifier == comboboxQueries.SelectedIndex).ToList(); } }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMainText.Text = TextForLaxForm.LabelMainText;
            int x = (this.ClientSize.Width - labelMainText.Size.Width) / 2;
            labelMainText.Location = new Point(x, labelMainText.Location.Y);


            labelEnable(false);
            Queries.DownloadAllWorksheets();
            ComboboxItemsUpload();
            ListviewColumsUpload();

            comboboxQueries.SelectedIndex = 0;
            ListViewRefresh();
        }

        /// <summary>
        ///Fills up thecombobox Items' names. 
        /// </summary>
        private void ComboboxItemsUpload()
        {
            comboboxQueries.Items.Add(TextForLaxForm.ComboSalesOptionAndTray);
            comboboxQueries.Items.Add(TextForLaxForm.ComboSumOfSalesTransaction);
            comboboxQueries.Items.Add(TextForLaxForm.ComboTopTenSellersAccordingToUnits);
            comboboxQueries.Items.Add(TextForLaxForm.ComboBid1Bid2Comparison);
            comboboxQueries.Items.Add(TextForLaxForm.ComboClaimFilled);
        }

        /// <summary>
        /// Fills up the columnames List with names and identification number. 
        /// </summary>
        private void ListviewColumsUpload()
        {
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales00InvoiceDate));
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales01Quarter));
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales02Distributor));
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales03Reseller));
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales04ProductLine));
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales05PartNumber));
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales06ProductDescription));
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales07Units));
            columnNames.Add(new ListviewColumnName(0,TextForLaxForm.Sales08Revenue));

            columnNames.Add(new ListviewColumnName(1,TextForLaxForm.SumOfSalesTransaction00));
            columnNames.Add(new ListviewColumnName(1,TextForLaxForm.SumOfSalesTransaction01));
            columnNames.Add(new ListviewColumnName(1, TextForLaxForm.SumOfSalesTransaction02));

            columnNames.Add(new ListviewColumnName(2, TextForLaxForm.TopTenSellers00));
            columnNames.Add(new ListviewColumnName(2, TextForLaxForm.TopTenSellers01));

            columnNames.Add(new ListviewColumnName(3,TextForLaxForm.CompareBidsVersionPrices00));
            columnNames.Add(new ListviewColumnName(3,TextForLaxForm.CompareBidsVersionPrices01));
            columnNames.Add(new ListviewColumnName(3, TextForLaxForm.CompareBidsVersionPrices02));
            columnNames.Add(new ListviewColumnName(3, TextForLaxForm.CompareBidsVersionPrices03));
            columnNames.Add(new ListviewColumnName(3, TextForLaxForm.CompareBidsVersionPrices04));
            columnNames.Add(new ListviewColumnName(3,TextForLaxForm.CompareBidsVersionPrices05));
            columnNames.Add(new ListviewColumnName(3, TextForLaxForm.CompareBidsVersionPrices06));

            columnNames.Add(new ListviewColumnName(4,TextForLaxForm.ClaimFilledClaimRequest00));
            columnNames.Add(new ListviewColumnName(4, TextForLaxForm.ClaimFilledResellerName01));
            columnNames.Add(new ListviewColumnName(4,TextForLaxForm.ClaimFilledEnUserName02));
            columnNames.Add(new ListviewColumnName(4, TextForLaxForm.ClaimFilledEndCustomerName03));
            columnNames.Add(new ListviewColumnName(4, TextForLaxForm.ClaimFilledAgreementControl04));
            columnNames.Add(new ListviewColumnName(4, TextForLaxForm.ClaimFilledMaterial05));
            columnNames.Add(new ListviewColumnName(4, TextForLaxForm.ClaimFilledDescription06));
            columnNames.Add(new ListviewColumnName(4,TextForLaxForm.ClaimFilledClaimedQty07));
            columnNames.Add(new ListviewColumnName(4, TextForLaxForm.ClaimFilledRebateQty08));
            columnNames.Add(new ListviewColumnName(4, TextForLaxForm.ClaimFilledRebateAmt09));
        }

        /// <summary>
        /// Fills up the Listview with exact data.
        /// </summary>
        /// <param name="selectedQuerListViewItemList"></param>
        private void ListViewColumnDataUploader(List<ListViewItem> selectedQuerListViewItemList)
        {
            foreach (ListViewItem aSelectedQuerylistViewItem in selectedQuerListViewItemList)
            {
                listViewQueries.Items.Add(aSelectedQuerylistViewItem);
            }
        }

        /// <summary>
        /// Refreshes the a actual data(ListviewItems) based on the selected combobox item. 
        /// </summary>
        private void ListViewRefresh()
        {
            labelEnable(false);
            listViewQueries.Items.Clear();
            listViewQueries.Columns.Clear();

            foreach (ListviewColumnName aName in SelectedColumNames)
            {
                listViewQueries.Columns.Add(aName.ColumnName);
            }

            List<ListViewItem> aSelectedQueryListViewItemList = new List<ListViewItem>();

            switch(comboboxQueries.SelectedIndex)
            {
                case 0:
                    aSelectedQueryListViewItemList = Queries.Task2OptionAndTray();
                    labelTotalRevenue.Text = Queries.SalesTotalRevenue().ToString();
                    labelEnable(true);
                    break;
                case 1:
                    aSelectedQueryListViewItemList = Queries.Task2SumOfSalesTransaction();
                    break;
                case 2:
                    aSelectedQueryListViewItemList = Queries.Task2TopTenSellers();
                    break;
                case 3:
                    aSelectedQueryListViewItemList = Queries.Task3Bid1Bid2();
                    break;
                case 4:
                    aSelectedQueryListViewItemList = Queries.Task4ClaimFilled();
                    break;
            }

            listViewQueries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ListViewColumnDataUploader(aSelectedQueryListViewItemList);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Small void set labelTask2SalesOptionsSum and labelTotalRevenue Visibility.
        /// </summary>
        /// <param name="enable"></param>
        private void labelEnable(bool enable)
        {
            labelTask2SalesOptionsSum.Visible = 
            labelTotalRevenue.Visible = enable;
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            ListViewRefresh();
        }
    }
}
