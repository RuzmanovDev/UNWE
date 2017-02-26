namespace ExerciseTwo
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
            this.components = new System.ComponentModel.Container();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SaleValueLabel = new System.Windows.Forms.Label();
            this.SalesValueTextBox = new System.Windows.Forms.TextBox();
            this.NewSaleBtn = new System.Windows.Forms.Button();
            this.Finishbtn = new System.Windows.Forms.Button();
            this.TotalBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TotalGroupBox = new System.Windows.Forms.GroupBox();
            this.LevaLabel = new System.Windows.Forms.Label();
            this.Currencylabel = new System.Windows.Forms.Label();
            this.TotalDiscountLevaTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBoxLeva = new System.Windows.Forms.TextBox();
            this.TotalSalesLevaCount = new System.Windows.Forms.TextBox();
            this.TotalTextBoxEuro = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalDiscountEuroTextBox = new System.Windows.Forms.TextBox();
            this.TotalDiscountLabel = new System.Windows.Forms.Label();
            this.TotalSalesCountTextBox = new System.Windows.Forms.TextBox();
            this.SalesCountValue = new System.Windows.Forms.Label();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.ListView = new System.Windows.Forms.ListView();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TotalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(40, 34);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(48, 13);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Артикул";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(40, 159);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(56, 13);
            this.DiscountLabel.TabIndex = 2;
            this.DiscountLabel.Text = "Отстъпка";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(40, 117);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(66, 13);
            this.QuantityLabel.TabIndex = 3;
            this.QuantityLabel.Text = "Количество";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(40, 78);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(84, 13);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Единична Цена";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(135, 117);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityTextBox.TabIndex = 5;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(135, 159);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.ReadOnly = true;
            this.DiscountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiscountTextBox.TabIndex = 6;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(135, 78);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 7;
            // 
            // SaleValueLabel
            // 
            this.SaleValueLabel.AutoSize = true;
            this.SaleValueLabel.Location = new System.Drawing.Point(40, 201);
            this.SaleValueLabel.Name = "SaleValueLabel";
            this.SaleValueLabel.Size = new System.Drawing.Size(54, 13);
            this.SaleValueLabel.TabIndex = 8;
            this.SaleValueLabel.Text = "Стойност";
            // 
            // SalesValueTextBox
            // 
            this.SalesValueTextBox.Location = new System.Drawing.Point(135, 201);
            this.SalesValueTextBox.Name = "SalesValueTextBox";
            this.SalesValueTextBox.ReadOnly = true;
            this.SalesValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesValueTextBox.TabIndex = 9;
            // 
            // NewSaleBtn
            // 
            this.NewSaleBtn.Enabled = false;
            this.NewSaleBtn.Location = new System.Drawing.Point(389, 30);
            this.NewSaleBtn.Name = "NewSaleBtn";
            this.NewSaleBtn.Size = new System.Drawing.Size(159, 23);
            this.NewSaleBtn.TabIndex = 10;
            this.NewSaleBtn.Text = "Нова продажба";
            this.NewSaleBtn.UseVisualStyleBackColor = true;
            this.NewSaleBtn.Click += new System.EventHandler(this.NewSaleBtn_Click);
            // 
            // Finishbtn
            // 
            this.Finishbtn.Location = new System.Drawing.Point(389, 172);
            this.Finishbtn.Name = "Finishbtn";
            this.Finishbtn.Size = new System.Drawing.Size(159, 23);
            this.Finishbtn.TabIndex = 11;
            this.Finishbtn.Text = "Приключване";
            this.Finishbtn.UseVisualStyleBackColor = true;
            this.Finishbtn.Click += new System.EventHandler(this.Finishbtn_Click);
            // 
            // TotalBtn
            // 
            this.TotalBtn.Location = new System.Drawing.Point(389, 59);
            this.TotalBtn.Name = "TotalBtn";
            this.TotalBtn.Size = new System.Drawing.Size(159, 23);
            this.TotalBtn.TabIndex = 12;
            this.TotalBtn.Text = "Тотал";
            this.TotalBtn.UseVisualStyleBackColor = true;
            this.TotalBtn.Click += new System.EventHandler(this.TotalBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(389, 201);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(159, 23);
            this.ExitBtn.TabIndex = 13;
            this.ExitBtn.Text = "Изход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TotalGroupBox
            // 
            this.TotalGroupBox.Controls.Add(this.LevaLabel);
            this.TotalGroupBox.Controls.Add(this.Currencylabel);
            this.TotalGroupBox.Controls.Add(this.TotalDiscountLevaTextBox);
            this.TotalGroupBox.Controls.Add(this.TotalTextBoxLeva);
            this.TotalGroupBox.Controls.Add(this.TotalSalesLevaCount);
            this.TotalGroupBox.Controls.Add(this.TotalTextBoxEuro);
            this.TotalGroupBox.Controls.Add(this.TotalLabel);
            this.TotalGroupBox.Controls.Add(this.TotalDiscountEuroTextBox);
            this.TotalGroupBox.Controls.Add(this.TotalDiscountLabel);
            this.TotalGroupBox.Controls.Add(this.TotalSalesCountTextBox);
            this.TotalGroupBox.Controls.Add(this.SalesCountValue);
            this.TotalGroupBox.Location = new System.Drawing.Point(43, 261);
            this.TotalGroupBox.Name = "TotalGroupBox";
            this.TotalGroupBox.Size = new System.Drawing.Size(534, 126);
            this.TotalGroupBox.TabIndex = 14;
            this.TotalGroupBox.TabStop = false;
            this.TotalGroupBox.Text = "Тотал";
            // 
            // LevaLabel
            // 
            this.LevaLabel.AutoSize = true;
            this.LevaLabel.Location = new System.Drawing.Point(452, 76);
            this.LevaLabel.Name = "LevaLabel";
            this.LevaLabel.Size = new System.Drawing.Size(19, 13);
            this.LevaLabel.TabIndex = 24;
            this.LevaLabel.Text = "лв";
            // 
            // Currencylabel
            // 
            this.Currencylabel.AutoSize = true;
            this.Currencylabel.Location = new System.Drawing.Point(458, 50);
            this.Currencylabel.Name = "Currencylabel";
            this.Currencylabel.Size = new System.Drawing.Size(13, 13);
            this.Currencylabel.TabIndex = 23;
            this.Currencylabel.Text = "--";
            // 
            // TotalDiscountLevaTextBox
            // 
            this.TotalDiscountLevaTextBox.Location = new System.Drawing.Point(183, 69);
            this.TotalDiscountLevaTextBox.Name = "TotalDiscountLevaTextBox";
            this.TotalDiscountLevaTextBox.ReadOnly = true;
            this.TotalDiscountLevaTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalDiscountLevaTextBox.TabIndex = 22;
            // 
            // TotalTextBoxLeva
            // 
            this.TotalTextBoxLeva.Location = new System.Drawing.Point(346, 69);
            this.TotalTextBoxLeva.Name = "TotalTextBoxLeva";
            this.TotalTextBoxLeva.ReadOnly = true;
            this.TotalTextBoxLeva.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBoxLeva.TabIndex = 21;
            // 
            // TotalSalesLevaCount
            // 
            this.TotalSalesLevaCount.Location = new System.Drawing.Point(28, 69);
            this.TotalSalesLevaCount.Name = "TotalSalesLevaCount";
            this.TotalSalesLevaCount.ReadOnly = true;
            this.TotalSalesLevaCount.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesLevaCount.TabIndex = 20;
            // 
            // TotalTextBoxEuro
            // 
            this.TotalTextBoxEuro.Location = new System.Drawing.Point(346, 43);
            this.TotalTextBoxEuro.Name = "TotalTextBoxEuro";
            this.TotalTextBoxEuro.ReadOnly = true;
            this.TotalTextBoxEuro.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBoxEuro.TabIndex = 19;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(343, 23);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(85, 13);
            this.TotalLabel.TabIndex = 18;
            this.TotalLabel.Text = "Обща стойност";
            // 
            // TotalDiscountEuroTextBox
            // 
            this.TotalDiscountEuroTextBox.Location = new System.Drawing.Point(183, 43);
            this.TotalDiscountEuroTextBox.Name = "TotalDiscountEuroTextBox";
            this.TotalDiscountEuroTextBox.ReadOnly = true;
            this.TotalDiscountEuroTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalDiscountEuroTextBox.TabIndex = 17;
            // 
            // TotalDiscountLabel
            // 
            this.TotalDiscountLabel.AutoSize = true;
            this.TotalDiscountLabel.Location = new System.Drawing.Point(180, 23);
            this.TotalDiscountLabel.Name = "TotalDiscountLabel";
            this.TotalDiscountLabel.Size = new System.Drawing.Size(56, 13);
            this.TotalDiscountLabel.TabIndex = 16;
            this.TotalDiscountLabel.Text = "Отстъпка";
            // 
            // TotalSalesCountTextBox
            // 
            this.TotalSalesCountTextBox.Location = new System.Drawing.Point(28, 43);
            this.TotalSalesCountTextBox.Name = "TotalSalesCountTextBox";
            this.TotalSalesCountTextBox.ReadOnly = true;
            this.TotalSalesCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalSalesCountTextBox.TabIndex = 15;
            // 
            // SalesCountValue
            // 
            this.SalesCountValue.AutoSize = true;
            this.SalesCountValue.Location = new System.Drawing.Point(25, 27);
            this.SalesCountValue.Name = "SalesCountValue";
            this.SalesCountValue.Size = new System.Drawing.Size(85, 13);
            this.SalesCountValue.TabIndex = 3;
            this.SalesCountValue.Text = "Брой продажби";
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Items.AddRange(new object[] {
            "Артукул1",
            "Артукул2",
            "Артукул3"});
            this.ProductsComboBox.Location = new System.Drawing.Point(135, 34);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(100, 21);
            this.ProductsComboBox.TabIndex = 15;
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Items.AddRange(new object[] {
            "лв",
            "евро"});
            this.CurrencyComboBox.Location = new System.Drawing.Point(252, 78);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(41, 21);
            this.CurrencyComboBox.TabIndex = 16;
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ListView.Location = new System.Drawing.Point(43, 405);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(505, 97);
            this.ListView.TabIndex = 17;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(43, 8);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 20);
            this.DatePicker.TabIndex = 18;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Артикул";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ед.Цена";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Количество";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Отстъпка";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Стойност";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 514);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.ProductsComboBox);
            this.Controls.Add(this.TotalGroupBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.TotalBtn);
            this.Controls.Add(this.Finishbtn);
            this.Controls.Add(this.NewSaleBtn);
            this.Controls.Add(this.SalesValueTextBox);
            this.Controls.Add(this.SaleValueLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.ProductLabel);
            this.Name = "Form1";
            this.Text = "Информационна система продажби";
            this.TotalGroupBox.ResumeLayout(false);
            this.TotalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label SaleValueLabel;
        private System.Windows.Forms.TextBox SalesValueTextBox;
        private System.Windows.Forms.Button NewSaleBtn;
        private System.Windows.Forms.Button Finishbtn;
        private System.Windows.Forms.Button TotalBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.GroupBox TotalGroupBox;
        private System.Windows.Forms.TextBox TotalTextBoxEuro;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalDiscountEuroTextBox;
        private System.Windows.Forms.Label TotalDiscountLabel;
        private System.Windows.Forms.TextBox TotalSalesCountTextBox;
        private System.Windows.Forms.Label SalesCountValue;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.Label LevaLabel;
        private System.Windows.Forms.Label Currencylabel;
        private System.Windows.Forms.TextBox TotalDiscountLevaTextBox;
        private System.Windows.Forms.TextBox TotalTextBoxLeva;
        private System.Windows.Forms.TextBox TotalSalesLevaCount;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

