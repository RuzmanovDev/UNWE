using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace ExerciseTwo
{
    public partial class Form1 : Form
    {
        private static int TotalSalesCount = 0;
        private static decimal TotalDiscount = 0;
        private static decimal TotalValue = 0;

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
            this.ProductTextBox.Text = string.Empty;
            this.PriceTextBox.Text = string.Empty;
            this.QuantityTextBox.Text = string.Empty;
            this.DiscountTextBox.Text = string.Empty;
            this.SalesValueTextBox.Text = string.Empty;

            this.TotalDiscountTextBox.Text = string.Empty;
            this.TotalSalesCountTextBox.Text = string.Empty;
            this.TotalTextBox.Text = string.Empty;

            if (IsFinished)
            {
                TotalSalesCount = 0;
                TotalDiscount = 0;
                TotalValue = 0;

                this.Finishbtn.Text = "Приключване";
                this.ProductTextBox.ReadOnly = false;
                this.PriceTextBox.ReadOnly = false;
                this.QuantityTextBox.ReadOnly = false;

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
            var priceForUnit = decimal.Parse(this.PriceTextBox.Text);
            var quantity = decimal.Parse(this.QuantityTextBox.Text);

            var currentPrice = priceForUnit * quantity;

            decimal discount = currentPrice * 0.10M;

            if (discount > 100)
            {
                this.DiscountTextBox.Text = discount.ToString();
                this.DiscountLabel.ForeColor = Color.Red;
                TotalDiscount += discount;
            }
            else
            {
                this.DiscountTextBox.Text = "0";
                this.DiscountLabel.ForeColor = Color.Black;
            }

            this.SalesValueTextBox.Text = currentPrice.ToString();

            TotalSalesCount++;
            TotalValue += currentPrice;

            this.TotalBtn.Enabled = false;
            this.NewSaleBtn.Enabled = true;
        }

        private void Finishbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приключване на въвеждане на продажби и изчисляване на обща отстъпка и стойност за всички въведени продажби");
            this.TotalSalesCountTextBox.Text = TotalSalesCount.ToString();
            TotalDiscountTextBox.Text = TotalDiscount.ToString();
            TotalTextBox.Text = TotalValue.ToString();

            this.Finishbtn.Text = "Нова операция";

            this.TotalBtn.Enabled = false;
            this.NewSaleBtn.Enabled = true;

            this.ProductTextBox.ReadOnly = true;
            this.PriceTextBox.ReadOnly = true;
            this.QuantityTextBox.ReadOnly = true;

            if (TotalDiscount > 100)
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
