
namespace Lexmark_Tamas_Cser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewQueries = new System.Windows.Forms.ListView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.comboboxQueries = new System.Windows.Forms.ComboBox();
            this.labelMainText = new System.Windows.Forms.Label();
            this.labelQueries = new System.Windows.Forms.Label();
            this.labelTask2SalesOptionsSum = new System.Windows.Forms.Label();
            this.labelTotalRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewQueries
            // 
            this.listViewQueries.HideSelection = false;
            this.listViewQueries.Location = new System.Drawing.Point(13, 74);
            this.listViewQueries.Name = "listViewQueries";
            this.listViewQueries.Size = new System.Drawing.Size(780, 320);
            this.listViewQueries.TabIndex = 0;
            this.listViewQueries.UseCompatibleStateImageBehavior = false;
            this.listViewQueries.View = System.Windows.Forms.View.Details;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(693, 400);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(693, 41);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(100, 23);
            this.buttonQuery.TabIndex = 4;
            this.buttonQuery.Text = "Make a query";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // comboboxQueries
            // 
            this.comboboxQueries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxQueries.FormattingEnabled = true;
            this.comboboxQueries.Location = new System.Drawing.Point(13, 43);
            this.comboboxQueries.Name = "comboboxQueries";
            this.comboboxQueries.Size = new System.Drawing.Size(661, 21);
            this.comboboxQueries.TabIndex = 6;
            // 
            // labelMainText
            // 
            this.labelMainText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMainText.Location = new System.Drawing.Point(244, 2);
            this.labelMainText.Name = "labelMainText";
            this.labelMainText.Size = new System.Drawing.Size(290, 13);
            this.labelMainText.TabIndex = 7;
            this.labelMainText.Text = "Small program for Lexmark car fleet coordination position.";
            this.labelMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQueries
            // 
            this.labelQueries.AutoSize = true;
            this.labelQueries.Location = new System.Drawing.Point(10, 27);
            this.labelQueries.Name = "labelQueries";
            this.labelQueries.Size = new System.Drawing.Size(145, 13);
            this.labelQueries.TabIndex = 9;
            this.labelQueries.Text = "Requested Excel test queries";
            // 
            // labelTask2SalesOptionsSum
            // 
            this.labelTask2SalesOptionsSum.AutoSize = true;
            this.labelTask2SalesOptionsSum.Location = new System.Drawing.Point(10, 400);
            this.labelTask2SalesOptionsSum.Name = "labelTask2SalesOptionsSum";
            this.labelTask2SalesOptionsSum.Size = new System.Drawing.Size(150, 13);
            this.labelTask2SalesOptionsSum.TabIndex = 10;
            this.labelTask2SalesOptionsSum.Text = "Total revenue of the products:";
            // 
            // labelTotalRevenue
            // 
            this.labelTotalRevenue.AutoSize = true;
            this.labelTotalRevenue.Location = new System.Drawing.Point(158, 400);
            this.labelTotalRevenue.Name = "labelTotalRevenue";
            this.labelTotalRevenue.Size = new System.Drawing.Size(0, 13);
            this.labelTotalRevenue.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 436);
            this.Controls.Add(this.labelTotalRevenue);
            this.Controls.Add(this.labelTask2SalesOptionsSum);
            this.Controls.Add(this.labelQueries);
            this.Controls.Add(this.labelMainText);
            this.Controls.Add(this.comboboxQueries);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listViewQueries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lexmark Candidate Tamas Cser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewQueries;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.ComboBox comboboxQueries;
        private System.Windows.Forms.Label labelMainText;
        private System.Windows.Forms.Label labelQueries;
        private System.Windows.Forms.Label labelTask2SalesOptionsSum;
        private System.Windows.Forms.Label labelTotalRevenue;
    }
}

