namespace AS1MBoldo
{
    partial class CarListingsForm
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
            this.dataGridViewAllCars = new System.Windows.Forms.DataGridView();
            this.labelAllCars = new System.Windows.Forms.Label();
            this.labelAllCarsCountLabel = new System.Windows.Forms.Label();
            this.labeAllCarsCount = new System.Windows.Forms.Label();
            this.labelAveragePriceLabel = new System.Windows.Forms.Label();
            this.labelAllCarsAveragePrice = new System.Windows.Forms.Label();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.labelFilters = new System.Windows.Forms.Label();
            this.listBoxMakesFilter = new System.Windows.Forms.ListBox();
            this.listBoxYearsFilter = new System.Windows.Forms.ListBox();
            this.listBoxColorsFilter = new System.Windows.Forms.ListBox();
            this.listBoxDealersFilter = new System.Windows.Forms.ListBox();
            this.labelMakesFilter = new System.Windows.Forms.Label();
            this.labelYearsFilter = new System.Windows.Forms.Label();
            this.labelColorsFilter = new System.Windows.Forms.Label();
            this.labelDealersFilter = new System.Windows.Forms.Label();
            this.labelPriceFilter = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelEngineSize = new System.Windows.Forms.Label();
            this.labelMinEngineSize = new System.Windows.Forms.Label();
            this.labelMaxEngineSize = new System.Windows.Forms.Label();
            this.labelSelectedCars = new System.Windows.Forms.Label();
            this.dataGridViewSelectedCars = new System.Windows.Forms.DataGridView();
            this.labelSelectedCarsCountLabel = new System.Windows.Forms.Label();
            this.labelSelectedCarsCount = new System.Windows.Forms.Label();
            this.labelSelectedCarsAveragePriceLabel = new System.Windows.Forms.Label();
            this.labelSelectedCarsAveragePrice = new System.Windows.Forms.Label();
            this.textBoxMinPriceFilter = new System.Windows.Forms.TextBox();
            this.textBoxMaxPriceFilter = new System.Windows.Forms.TextBox();
            this.textBoxMinEngineSizeFilter = new System.Windows.Forms.TextBox();
            this.textBoxMaxEngineSizeFilter = new System.Windows.Forms.TextBox();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.checkBoxEngineSize = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllCars
            // 
            this.dataGridViewAllCars.AllowUserToAddRows = false;
            this.dataGridViewAllCars.AllowUserToDeleteRows = false;
            this.dataGridViewAllCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllCars.Location = new System.Drawing.Point(63, 62);
            this.dataGridViewAllCars.Name = "dataGridViewAllCars";
            this.dataGridViewAllCars.ReadOnly = true;
            this.dataGridViewAllCars.Size = new System.Drawing.Size(620, 150);
            this.dataGridViewAllCars.TabIndex = 0;
            // 
            // labelAllCars
            // 
            this.labelAllCars.AutoSize = true;
            this.labelAllCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAllCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllCars.Location = new System.Drawing.Point(63, 24);
            this.labelAllCars.Name = "labelAllCars";
            this.labelAllCars.Size = new System.Drawing.Size(52, 15);
            this.labelAllCars.TabIndex = 1;
            this.labelAllCars.Text = "All Cars";
            // 
            // labelAllCarsCountLabel
            // 
            this.labelAllCarsCountLabel.AutoSize = true;
            this.labelAllCarsCountLabel.Location = new System.Drawing.Point(80, 230);
            this.labelAllCarsCountLabel.Name = "labelAllCarsCountLabel";
            this.labelAllCarsCountLabel.Size = new System.Drawing.Size(44, 13);
            this.labelAllCarsCountLabel.TabIndex = 2;
            this.labelAllCarsCountLabel.Text = "Count =";
            // 
            // labeAllCarsCount
            // 
            this.labeAllCarsCount.AutoSize = true;
            this.labeAllCarsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeAllCarsCount.Location = new System.Drawing.Point(131, 229);
            this.labeAllCarsCount.MinimumSize = new System.Drawing.Size(50, 2);
            this.labeAllCarsCount.Name = "labeAllCarsCount";
            this.labeAllCarsCount.Size = new System.Drawing.Size(50, 15);
            this.labeAllCarsCount.TabIndex = 3;
            // 
            // labelAveragePriceLabel
            // 
            this.labelAveragePriceLabel.AutoSize = true;
            this.labelAveragePriceLabel.Location = new System.Drawing.Point(494, 230);
            this.labelAveragePriceLabel.Name = "labelAveragePriceLabel";
            this.labelAveragePriceLabel.Size = new System.Drawing.Size(83, 13);
            this.labelAveragePriceLabel.TabIndex = 4;
            this.labelAveragePriceLabel.Text = "Average Price =";
            // 
            // labelAllCarsAveragePrice
            // 
            this.labelAllCarsAveragePrice.AutoSize = true;
            this.labelAllCarsAveragePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAllCarsAveragePrice.Location = new System.Drawing.Point(583, 229);
            this.labelAllCarsAveragePrice.MinimumSize = new System.Drawing.Size(100, 2);
            this.labelAllCarsAveragePrice.Name = "labelAllCarsAveragePrice";
            this.labelAllCarsAveragePrice.Size = new System.Drawing.Size(100, 15);
            this.labelAllCarsAveragePrice.TabIndex = 5;
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.Location = new System.Drawing.Point(358, 261);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonResetFilters.TabIndex = 6;
            this.buttonResetFilters.Text = "Reset Filters";
            this.buttonResetFilters.UseVisualStyleBackColor = true;
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilters.Location = new System.Drawing.Point(60, 271);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(43, 15);
            this.labelFilters.TabIndex = 7;
            this.labelFilters.Text = "Filters";
            // 
            // listBoxMakesFilter
            // 
            this.listBoxMakesFilter.FormattingEnabled = true;
            this.listBoxMakesFilter.Location = new System.Drawing.Point(63, 322);
            this.listBoxMakesFilter.Name = "listBoxMakesFilter";
            this.listBoxMakesFilter.Size = new System.Drawing.Size(120, 134);
            this.listBoxMakesFilter.TabIndex = 8;
            // 
            // listBoxYearsFilter
            // 
            this.listBoxYearsFilter.FormattingEnabled = true;
            this.listBoxYearsFilter.Location = new System.Drawing.Point(239, 322);
            this.listBoxYearsFilter.Name = "listBoxYearsFilter";
            this.listBoxYearsFilter.Size = new System.Drawing.Size(62, 134);
            this.listBoxYearsFilter.TabIndex = 9;
            // 
            // listBoxColorsFilter
            // 
            this.listBoxColorsFilter.FormattingEnabled = true;
            this.listBoxColorsFilter.Location = new System.Drawing.Point(358, 322);
            this.listBoxColorsFilter.Name = "listBoxColorsFilter";
            this.listBoxColorsFilter.Size = new System.Drawing.Size(120, 134);
            this.listBoxColorsFilter.TabIndex = 10;
            // 
            // listBoxDealersFilter
            // 
            this.listBoxDealersFilter.FormattingEnabled = true;
            this.listBoxDealersFilter.Location = new System.Drawing.Point(583, 322);
            this.listBoxDealersFilter.Name = "listBoxDealersFilter";
            this.listBoxDealersFilter.Size = new System.Drawing.Size(120, 134);
            this.listBoxDealersFilter.TabIndex = 11;
            // 
            // labelMakesFilter
            // 
            this.labelMakesFilter.AutoSize = true;
            this.labelMakesFilter.Location = new System.Drawing.Point(60, 306);
            this.labelMakesFilter.Name = "labelMakesFilter";
            this.labelMakesFilter.Size = new System.Drawing.Size(39, 13);
            this.labelMakesFilter.TabIndex = 12;
            this.labelMakesFilter.Text = "Makes";
            // 
            // labelYearsFilter
            // 
            this.labelYearsFilter.AutoSize = true;
            this.labelYearsFilter.Location = new System.Drawing.Point(239, 305);
            this.labelYearsFilter.Name = "labelYearsFilter";
            this.labelYearsFilter.Size = new System.Drawing.Size(34, 13);
            this.labelYearsFilter.TabIndex = 13;
            this.labelYearsFilter.Text = "Years";
            // 
            // labelColorsFilter
            // 
            this.labelColorsFilter.AutoSize = true;
            this.labelColorsFilter.Location = new System.Drawing.Point(358, 305);
            this.labelColorsFilter.Name = "labelColorsFilter";
            this.labelColorsFilter.Size = new System.Drawing.Size(36, 13);
            this.labelColorsFilter.TabIndex = 14;
            this.labelColorsFilter.Text = "Colors";
            // 
            // labelDealersFilter
            // 
            this.labelDealersFilter.AutoSize = true;
            this.labelDealersFilter.Location = new System.Drawing.Point(583, 305);
            this.labelDealersFilter.Name = "labelDealersFilter";
            this.labelDealersFilter.Size = new System.Drawing.Size(43, 13);
            this.labelDealersFilter.TabIndex = 15;
            this.labelDealersFilter.Text = "Dealers";
            // 
            // labelPriceFilter
            // 
            this.labelPriceFilter.AutoSize = true;
            this.labelPriceFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPriceFilter.Location = new System.Drawing.Point(60, 484);
            this.labelPriceFilter.Name = "labelPriceFilter";
            this.labelPriceFilter.Size = new System.Drawing.Size(33, 15);
            this.labelPriceFilter.TabIndex = 16;
            this.labelPriceFilter.Text = "Price";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(154, 480);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(24, 13);
            this.labelMinPrice.TabIndex = 17;
            this.labelMinPrice.Text = "Min";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(151, 522);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(27, 13);
            this.labelMaxPrice.TabIndex = 18;
            this.labelMaxPrice.Text = "Max";
            // 
            // labelEngineSize
            // 
            this.labelEngineSize.AutoSize = true;
            this.labelEngineSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEngineSize.Location = new System.Drawing.Point(347, 483);
            this.labelEngineSize.Name = "labelEngineSize";
            this.labelEngineSize.Size = new System.Drawing.Size(65, 15);
            this.labelEngineSize.TabIndex = 19;
            this.labelEngineSize.Text = "Engine Size";
            // 
            // labelMinEngineSize
            // 
            this.labelMinEngineSize.AutoSize = true;
            this.labelMinEngineSize.Location = new System.Drawing.Point(467, 479);
            this.labelMinEngineSize.Name = "labelMinEngineSize";
            this.labelMinEngineSize.Size = new System.Drawing.Size(24, 13);
            this.labelMinEngineSize.TabIndex = 20;
            this.labelMinEngineSize.Text = "Min";
            // 
            // labelMaxEngineSize
            // 
            this.labelMaxEngineSize.AutoSize = true;
            this.labelMaxEngineSize.Location = new System.Drawing.Point(464, 521);
            this.labelMaxEngineSize.Name = "labelMaxEngineSize";
            this.labelMaxEngineSize.Size = new System.Drawing.Size(27, 13);
            this.labelMaxEngineSize.TabIndex = 21;
            this.labelMaxEngineSize.Text = "Max";
            // 
            // labelSelectedCars
            // 
            this.labelSelectedCars.AutoSize = true;
            this.labelSelectedCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedCars.Location = new System.Drawing.Point(63, 560);
            this.labelSelectedCars.Name = "labelSelectedCars";
            this.labelSelectedCars.Size = new System.Drawing.Size(88, 15);
            this.labelSelectedCars.TabIndex = 22;
            this.labelSelectedCars.Text = "Selected Cars";
            // 
            // dataGridViewSelectedCars
            // 
            this.dataGridViewSelectedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedCars.Location = new System.Drawing.Point(63, 607);
            this.dataGridViewSelectedCars.Name = "dataGridViewSelectedCars";
            this.dataGridViewSelectedCars.Size = new System.Drawing.Size(620, 150);
            this.dataGridViewSelectedCars.TabIndex = 23;
            // 
            // labelSelectedCarsCountLabel
            // 
            this.labelSelectedCarsCountLabel.AutoSize = true;
            this.labelSelectedCarsCountLabel.Location = new System.Drawing.Point(80, 772);
            this.labelSelectedCarsCountLabel.Name = "labelSelectedCarsCountLabel";
            this.labelSelectedCarsCountLabel.Size = new System.Drawing.Size(44, 13);
            this.labelSelectedCarsCountLabel.TabIndex = 24;
            this.labelSelectedCarsCountLabel.Text = "Count =";
            // 
            // labelSelectedCarsCount
            // 
            this.labelSelectedCarsCount.AutoSize = true;
            this.labelSelectedCarsCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedCarsCount.Location = new System.Drawing.Point(131, 772);
            this.labelSelectedCarsCount.MinimumSize = new System.Drawing.Size(50, 2);
            this.labelSelectedCarsCount.Name = "labelSelectedCarsCount";
            this.labelSelectedCarsCount.Size = new System.Drawing.Size(50, 15);
            this.labelSelectedCarsCount.TabIndex = 25;
            // 
            // labelSelectedCarsAveragePriceLabel
            // 
            this.labelSelectedCarsAveragePriceLabel.AutoSize = true;
            this.labelSelectedCarsAveragePriceLabel.Location = new System.Drawing.Point(494, 771);
            this.labelSelectedCarsAveragePriceLabel.Name = "labelSelectedCarsAveragePriceLabel";
            this.labelSelectedCarsAveragePriceLabel.Size = new System.Drawing.Size(83, 13);
            this.labelSelectedCarsAveragePriceLabel.TabIndex = 26;
            this.labelSelectedCarsAveragePriceLabel.Text = "Average Price =";
            // 
            // labelSelectedCarsAveragePrice
            // 
            this.labelSelectedCarsAveragePrice.AutoSize = true;
            this.labelSelectedCarsAveragePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedCarsAveragePrice.Location = new System.Drawing.Point(583, 771);
            this.labelSelectedCarsAveragePrice.MinimumSize = new System.Drawing.Size(100, 2);
            this.labelSelectedCarsAveragePrice.Name = "labelSelectedCarsAveragePrice";
            this.labelSelectedCarsAveragePrice.Size = new System.Drawing.Size(100, 15);
            this.labelSelectedCarsAveragePrice.TabIndex = 27;
            // 
            // textBoxMinPriceFilter
            // 
            this.textBoxMinPriceFilter.Location = new System.Drawing.Point(184, 477);
            this.textBoxMinPriceFilter.Name = "textBoxMinPriceFilter";
            this.textBoxMinPriceFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinPriceFilter.TabIndex = 28;
            // 
            // textBoxMaxPriceFilter
            // 
            this.textBoxMaxPriceFilter.Location = new System.Drawing.Point(184, 519);
            this.textBoxMaxPriceFilter.Name = "textBoxMaxPriceFilter";
            this.textBoxMaxPriceFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxPriceFilter.TabIndex = 29;
            // 
            // textBoxMinEngineSizeFilter
            // 
            this.textBoxMinEngineSizeFilter.Location = new System.Drawing.Point(497, 476);
            this.textBoxMinEngineSizeFilter.Name = "textBoxMinEngineSizeFilter";
            this.textBoxMinEngineSizeFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinEngineSizeFilter.TabIndex = 30;
            // 
            // textBoxMaxEngineSizeFilter
            // 
            this.textBoxMaxEngineSizeFilter.Location = new System.Drawing.Point(497, 518);
            this.textBoxMaxEngineSizeFilter.Name = "textBoxMaxEngineSizeFilter";
            this.textBoxMaxEngineSizeFilter.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxEngineSizeFilter.TabIndex = 31;
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.Location = new System.Drawing.Point(184, 545);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(102, 17);
            this.checkBoxPrice.TabIndex = 32;
            this.checkBoxPrice.Text = "Search on Price";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            // 
            // checkBoxEngineSize
            // 
            this.checkBoxEngineSize.AutoSize = true;
            this.checkBoxEngineSize.Location = new System.Drawing.Point(497, 545);
            this.checkBoxEngineSize.Name = "checkBoxEngineSize";
            this.checkBoxEngineSize.Size = new System.Drawing.Size(131, 17);
            this.checkBoxEngineSize.TabIndex = 33;
            this.checkBoxEngineSize.Text = "Check on Engine Size";
            this.checkBoxEngineSize.UseVisualStyleBackColor = true;
            // 
            // CarListingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 827);
            this.Controls.Add(this.checkBoxEngineSize);
            this.Controls.Add(this.checkBoxPrice);
            this.Controls.Add(this.textBoxMaxEngineSizeFilter);
            this.Controls.Add(this.textBoxMinEngineSizeFilter);
            this.Controls.Add(this.textBoxMaxPriceFilter);
            this.Controls.Add(this.textBoxMinPriceFilter);
            this.Controls.Add(this.labelSelectedCarsAveragePrice);
            this.Controls.Add(this.labelSelectedCarsAveragePriceLabel);
            this.Controls.Add(this.labelSelectedCarsCount);
            this.Controls.Add(this.labelSelectedCarsCountLabel);
            this.Controls.Add(this.dataGridViewSelectedCars);
            this.Controls.Add(this.labelSelectedCars);
            this.Controls.Add(this.labelMaxEngineSize);
            this.Controls.Add(this.labelMinEngineSize);
            this.Controls.Add(this.labelEngineSize);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelPriceFilter);
            this.Controls.Add(this.labelDealersFilter);
            this.Controls.Add(this.labelColorsFilter);
            this.Controls.Add(this.labelYearsFilter);
            this.Controls.Add(this.labelMakesFilter);
            this.Controls.Add(this.listBoxDealersFilter);
            this.Controls.Add(this.listBoxColorsFilter);
            this.Controls.Add(this.listBoxYearsFilter);
            this.Controls.Add(this.listBoxMakesFilter);
            this.Controls.Add(this.labelFilters);
            this.Controls.Add(this.buttonResetFilters);
            this.Controls.Add(this.labelAllCarsAveragePrice);
            this.Controls.Add(this.labelAveragePriceLabel);
            this.Controls.Add(this.labeAllCarsCount);
            this.Controls.Add(this.labelAllCarsCountLabel);
            this.Controls.Add(this.labelAllCars);
            this.Controls.Add(this.dataGridViewAllCars);
            this.Name = "CarListingsForm";
            this.Text = "Assignment 1 – Car Listings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllCars;
        private System.Windows.Forms.Label labelAllCars;
        private System.Windows.Forms.Label labelAllCarsCountLabel;
        private System.Windows.Forms.Label labeAllCarsCount;
        private System.Windows.Forms.Label labelAveragePriceLabel;
        private System.Windows.Forms.Label labelAllCarsAveragePrice;
        private System.Windows.Forms.Button buttonResetFilters;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.ListBox listBoxMakesFilter;
        private System.Windows.Forms.ListBox listBoxYearsFilter;
        private System.Windows.Forms.ListBox listBoxColorsFilter;
        private System.Windows.Forms.ListBox listBoxDealersFilter;
        private System.Windows.Forms.Label labelMakesFilter;
        private System.Windows.Forms.Label labelYearsFilter;
        private System.Windows.Forms.Label labelColorsFilter;
        private System.Windows.Forms.Label labelDealersFilter;
        private System.Windows.Forms.Label labelPriceFilter;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelEngineSize;
        private System.Windows.Forms.Label labelMinEngineSize;
        private System.Windows.Forms.Label labelMaxEngineSize;
        private System.Windows.Forms.Label labelSelectedCars;
        private System.Windows.Forms.DataGridView dataGridViewSelectedCars;
        private System.Windows.Forms.Label labelSelectedCarsCountLabel;
        private System.Windows.Forms.Label labelSelectedCarsCount;
        private System.Windows.Forms.Label labelSelectedCarsAveragePriceLabel;
        private System.Windows.Forms.Label labelSelectedCarsAveragePrice;
        private System.Windows.Forms.TextBox textBoxMinPriceFilter;
        private System.Windows.Forms.TextBox textBoxMaxPriceFilter;
        private System.Windows.Forms.TextBox textBoxMinEngineSizeFilter;
        private System.Windows.Forms.TextBox textBoxMaxEngineSizeFilter;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.CheckBox checkBoxEngineSize;
    }
}

