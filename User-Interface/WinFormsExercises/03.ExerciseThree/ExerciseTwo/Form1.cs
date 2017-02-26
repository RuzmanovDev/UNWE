using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ExerciseTwo
{
    public partial class Form1 : Form
    {
        private const decimal EuroToLeva = 1.95583M;
        private const string BGN = "лв";

        private static int TotalSalesCountLeva = 0;
        private static decimal TotalDiscountLeva = 0;
        private static decimal TotalValueLeva = 0;

        private static int TotalSalesCountEuro = 0;
        private static decimal TotalDiscountEuro = 0;
        private static decimal TotalValueEuro = 0;
        //private static readonly IDictionary<string, CurrencyInfo> OtherCurrencyInfo = new Dictionary<string, CurrencyInfo>();

        private bool IsFinished = false;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void NewSaleBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Въвеждане на данни за нова продажба");
            this.ProductsComboBox.ResetText();
            this.PriceTextBox.Text = string.Empty;
            this.QuantityTextBox.Text = string.Empty;
            this.DiscountTextBox.Text = string.Empty;
            this.SalesValueTextBox.Text = string.Empty;

            this.TotalDiscountEuroTextBox.Text = string.Empty;
            this.TotalSalesCountTextBox.Text = string.Empty;
            this.TotalTextBoxEuro.Text = string.Empty;

            if (IsFinished)
            {
                TotalSalesCountEuro = 0;
                TotalDiscountLeva = 0;
                TotalValueEuro = 0;

                this.Finishbtn.Text = "Приключване";
                this.PriceTextBox.ReadOnly = false;
                this.QuantityTextBox.ReadOnly = false;
                this.DatePicker.Enabled = true;

                this.IsFinished = false;
            }

            this.TotalBtn.Enabled = true;
            this.NewSaleBtn.Enabled = false;
            this.DiscountLabel.ForeColor = Color.Black;
            this.TotalDiscountLabel.ForeColor = Color.Black;
        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изчисляване на отстъпка и обща стойност за текущо въведена продажба");

            decimal priceForUnit;
            decimal quantity;

            var isPriceParsed = decimal.TryParse(this.PriceTextBox.Text, out priceForUnit);
            var isQuantityParsed = decimal.TryParse(this.QuantityTextBox.Text, out quantity);

            if (!isPriceParsed || !isQuantityParsed)
            {
                MessageBox.Show("Моля, въведете валидни данни!");
            }

            var currentPrice = priceForUnit * quantity;

            if (priceForUnit < 0 || quantity < 0)
            {
                MessageBox.Show("Моля, въведете положителни числа");
            }

            decimal discount = currentPrice * 0.10M;

            if (discount > 100)
            {
                this.DiscountTextBox.Text = discount.ToString();
                this.DiscountLabel.ForeColor = Color.Red;
            }
            else
            {
                this.DiscountTextBox.Text = "0";
                this.DiscountLabel.ForeColor = Color.Black;
            }

            string currency = string.Empty;

            try
            {
                currency = CurrencyComboBox.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Моля, изберете валута");
                return;
            }

            if (currency != BGN)
            {
                TotalSalesCountEuro++;
                TotalValueEuro += currentPrice;
                TotalDiscountEuro += discount;
            }
            else
            {
                TotalValueEuro += currentPrice;
                TotalDiscountLeva += discount;
                TotalSalesCountLeva++;
            }

            this.SalesValueTextBox.Text = currentPrice.ToString();

            this.TotalBtn.Enabled = false;
            this.NewSaleBtn.Enabled = true;

            this.DatePicker.Enabled = false;

            string[] row = new[]
                {
                this.ProductsComboBox.SelectedItem.ToString(),
                this.PriceTextBox.Text,
                this.QuantityTextBox.Text,
                this.DiscountTextBox.Text,
                this.SalesValueTextBox.Text
                };

            this.ListView.Items.Add(Convert.ToString(DatePicker.Value)).SubItems.AddRange(row);
        }

        private void Finishbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приключване на въвеждане на продажби и изчисляване на обща отстъпка и стойност за всички въведени продажби");

            this.TotalSalesCountTextBox.Text = TotalSalesCountEuro.ToString();
            this.TotalSalesLevaCount.Text = TotalSalesCountLeva.ToString();

            this.TotalDiscountEuroTextBox.Text = TotalDiscountEuro.ToString();
            this.TotalDiscountLevaTextBox.Text = TotalDiscountLeva.ToString();

            this.TotalTextBoxLeva.Text = TotalValueLeva.ToString();
            this.TotalTextBoxEuro.Text = TotalValueEuro.ToString();

            this.Finishbtn.Text = "Нова операция";

            this.TotalBtn.Enabled = false;
            this.NewSaleBtn.Enabled = true;

            this.PriceTextBox.ReadOnly = true;
            this.QuantityTextBox.ReadOnly = true;

            if (TotalDiscountLeva > 100)
            {
                this.TotalDiscountLabel.ForeColor = Color.Red;
            }
            else
            {
                this.TotalDiscountLabel.ForeColor = Color.Black;
            }

            this.IsFinished = true;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изход от приложението");
            this.Close();
        }
    }
}
