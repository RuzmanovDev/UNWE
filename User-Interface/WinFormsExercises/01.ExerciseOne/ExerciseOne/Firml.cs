using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ExerciseOne
{
    public partial class Firml : Form
    {
        private Color TextColor = Color.Black;

        public Firml()
        {
            InitializeComponent();
        }

        private void PersonalDataBtn_Click(object sender, EventArgs e)
        {
            var name = this.NameTextBox.Text;
            var phone = this.TelephoneMaskedTextBox.Text;
            var birthPlace = this.BirthPlaceTextBox.Text;

            this.ResultRichTextBox.Text +=
                $"Лични данни: {Environment.NewLine} {name}{Environment.NewLine}{phone}{Environment.NewLine}{birthPlace}{Environment.NewLine}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var facultyNumber = this.FacultyNumberMaskedTextBox.Text;
            var group = this.GroupComboBox.SelectedItem.ToString();
            var specialty = this.SpecialtyComboBox.SelectedItem.ToString();

            this.ResultRichTextBox.Text +=
                $"Университетски данни: {Environment.NewLine} {facultyNumber}{Environment.NewLine}{group}{Environment.NewLine}{specialty}{Environment.NewLine}";
        }

        private void TextColorChangeBtn_Click(object sender, EventArgs e)
        {
            var checkedButton = this.ColorChangeGroupBox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            if (checkedButton == RedRadioBtn)
            {
                this.TextColor = Color.Red;
            }
            else if (checkedButton == BlackRadioBtn)
            {
                this.TextColor = Color.Black;
            }
            else if (checkedButton == GreenRadioBtn)
            {
                this.TextColor = Color.Green;
            }

            this.ResultRichTextBox.ForeColor = this.TextColor;
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            this.ResultRichTextBox.Text = string.Empty;

            foreach (Control control in this.PersonalDataGroup.Controls)
            {
                this.ClearControl(control);
            }

            foreach (Control control in this.ColorChangeGroupBox.Controls)
            {
                this.ClearControl(control);
            }

            foreach (Control control in this.UniversityDataGroup.Controls)
            {
                this.ClearControl(control);
            }
        }

        private void ClearControl(Control control)
        {
            if (control is TextBox)
            {
                control.Text = string.Empty;
            }
            else if (control is MaskedTextBox)
            {
                control.Text = string.Empty;
            }
            else if (control is RadioButton)
            {
                RadioButton rdbtn = (RadioButton)control;
                rdbtn.Checked = false;
            }
            else if (control is ComboBox)
            {
                var combobox = (ComboBox)control;
                combobox.ResetText();
            }
        }
    }
}
