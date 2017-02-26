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
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
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
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalDiscountTextBox = new System.Windows.Forms.TextBox();
            this.TotalDiscountLabel = new System.Windows.Forms.Label();
            this.TotalSalesCountTextBox = new System.Windows.Forms.TextBox();
            this.SalesCountValue = new System.Windows.Forms.Label();
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
            // ProductTextBox
            // 
            this.ProductTextBox.Location = new System.Drawing.Point(135, 34);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductTextBox.TabIndex = 1;
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
            this.TotalGroupBox.Controls.Add(this.TotalTextBox);
            this.TotalGroupBox.Controls.Add(this.TotalLabel);
            this.TotalGroupBox.Controls.Add(this.TotalDiscountTextBox);
            this.TotalGroupBox.Controls.Add(this.TotalDiscountLabel);
            this.TotalGroupBox.Controls.Add(this.TotalSalesCountTextBox);
            this.TotalGroupBox.Controls.Add(this.SalesCountValue);
            this.TotalGroupBox.Location = new System.Drawing.Point(43, 261);
            this.TotalGroupBox.Name = "TotalGroupBox";
            this.TotalGroupBox.Size = new System.Drawing.Size(505, 83);
            this.TotalGroupBox.TabIndex = 14;
            this.TotalGroupBox.TabStop = false;
            this.TotalGroupBox.Text = "Тотал";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(346, 43);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 19;
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
            // TotalDiscountTextBox
            // 
            this.TotalDiscountTextBox.Location = new System.Drawing.Point(183, 43);
            this.TotalDiscountTextBox.Name = "TotalDiscountTextBox";
            this.TotalDiscountTextBox.ReadOnly = true;
            this.TotalDiscountTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalDiscountTextBox.TabIndex = 17;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 370);
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
            this.Controls.Add(this.ProductTextBox);
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
        private System.Windows.Forms.TextBox ProductTextBox;
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
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalDiscountTextBox;
        private System.Windows.Forms.Label TotalDiscountLabel;
        private System.Windows.Forms.TextBox TotalSalesCountTextBox;
        private System.Windows.Forms.Label SalesCountValue;
    }
}

