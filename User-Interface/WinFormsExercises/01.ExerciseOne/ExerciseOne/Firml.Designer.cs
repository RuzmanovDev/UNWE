namespace ExerciseOne
{
    partial class Firml
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
            this.PersonalDataGroup = new System.Windows.Forms.GroupBox();
            this.PersonalDataBtn = new System.Windows.Forms.Button();
            this.BirthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.BirthPlaceLabel = new System.Windows.Forms.Label();
            this.TelephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.UniversityDataGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.FacultyNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FacultyNumberLabel = new System.Windows.Forms.Label();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpecialtyComboBox = new System.Windows.Forms.ComboBox();
            this.TextColorChangeBtn = new System.Windows.Forms.Button();
            this.ColorChangeGroupBox = new System.Windows.Forms.GroupBox();
            this.RedRadioBtn = new System.Windows.Forms.RadioButton();
            this.BlackRadioBtn = new System.Windows.Forms.RadioButton();
            this.GreenRadioBtn = new System.Windows.Forms.RadioButton();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.PersonalDataGroup.SuspendLayout();
            this.UniversityDataGroup.SuspendLayout();
            this.ColorChangeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalDataGroup
            // 
            this.PersonalDataGroup.Controls.Add(this.PersonalDataBtn);
            this.PersonalDataGroup.Controls.Add(this.BirthPlaceTextBox);
            this.PersonalDataGroup.Controls.Add(this.BirthPlaceLabel);
            this.PersonalDataGroup.Controls.Add(this.TelephoneMaskedTextBox);
            this.PersonalDataGroup.Controls.Add(this.TelephoneLabel);
            this.PersonalDataGroup.Controls.Add(this.NameTextBox);
            this.PersonalDataGroup.Controls.Add(this.NameLabel);
            this.PersonalDataGroup.Location = new System.Drawing.Point(12, 12);
            this.PersonalDataGroup.Name = "PersonalDataGroup";
            this.PersonalDataGroup.Size = new System.Drawing.Size(305, 172);
            this.PersonalDataGroup.TabIndex = 0;
            this.PersonalDataGroup.TabStop = false;
            this.PersonalDataGroup.Text = "Лични данни";
            // 
            // PersonalDataBtn
            // 
            this.PersonalDataBtn.Location = new System.Drawing.Point(37, 143);
            this.PersonalDataBtn.Name = "PersonalDataBtn";
            this.PersonalDataBtn.Size = new System.Drawing.Size(210, 23);
            this.PersonalDataBtn.TabIndex = 6;
            this.PersonalDataBtn.Text = "Запиши лични данни";
            this.PersonalDataBtn.UseVisualStyleBackColor = true;
            this.PersonalDataBtn.Click += new System.EventHandler(this.PersonalDataBtn_Click);
            // 
            // BirthPlaceTextBox
            // 
            this.BirthPlaceTextBox.Location = new System.Drawing.Point(190, 92);
            this.BirthPlaceTextBox.Name = "BirthPlaceTextBox";
            this.BirthPlaceTextBox.Size = new System.Drawing.Size(87, 20);
            this.BirthPlaceTextBox.TabIndex = 5;
            // 
            // BirthPlaceLabel
            // 
            this.BirthPlaceLabel.AutoSize = true;
            this.BirthPlaceLabel.Location = new System.Drawing.Point(7, 99);
            this.BirthPlaceLabel.Name = "BirthPlaceLabel";
            this.BirthPlaceLabel.Size = new System.Drawing.Size(180, 13);
            this.BirthPlaceLabel.TabIndex = 4;
            this.BirthPlaceLabel.Text = "Месторождение, населено място:";
            // 
            // TelephoneMaskedTextBox
            // 
            this.TelephoneMaskedTextBox.Location = new System.Drawing.Point(190, 59);
            this.TelephoneMaskedTextBox.Mask = "(999) 000-000000";
            this.TelephoneMaskedTextBox.Name = "TelephoneMaskedTextBox";
            this.TelephoneMaskedTextBox.Size = new System.Drawing.Size(87, 20);
            this.TelephoneMaskedTextBox.TabIndex = 3;
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Location = new System.Drawing.Point(7, 62);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(55, 13);
            this.TelephoneLabel.TabIndex = 2;
            this.TelephoneLabel.Text = "Телефон:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(132, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(145, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(87, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Име, Фамилия:";
            // 
            // ResultRichTextBox
            // 
            this.ResultRichTextBox.Location = new System.Drawing.Point(12, 213);
            this.ResultRichTextBox.Name = "ResultRichTextBox";
            this.ResultRichTextBox.Size = new System.Drawing.Size(305, 110);
            this.ResultRichTextBox.TabIndex = 1;
            this.ResultRichTextBox.Text = "";
            // 
            // UniversityDataGroup
            // 
            this.UniversityDataGroup.Controls.Add(this.SpecialtyComboBox);
            this.UniversityDataGroup.Controls.Add(this.label1);
            this.UniversityDataGroup.Controls.Add(this.GroupComboBox);
            this.UniversityDataGroup.Controls.Add(this.button1);
            this.UniversityDataGroup.Controls.Add(this.GroupLabel);
            this.UniversityDataGroup.Controls.Add(this.FacultyNumberMaskedTextBox);
            this.UniversityDataGroup.Controls.Add(this.FacultyNumberLabel);
            this.UniversityDataGroup.Location = new System.Drawing.Point(351, 12);
            this.UniversityDataGroup.Name = "UniversityDataGroup";
            this.UniversityDataGroup.Size = new System.Drawing.Size(288, 172);
            this.UniversityDataGroup.TabIndex = 2;
            this.UniversityDataGroup.TabStop = false;
            this.UniversityDataGroup.Text = "Университетски данни";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Запиши университетски данни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(6, 66);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(39, 13);
            this.GroupLabel.TabIndex = 4;
            this.GroupLabel.Text = "Група:";
            // 
            // FacultyNumberMaskedTextBox
            // 
            this.FacultyNumberMaskedTextBox.Location = new System.Drawing.Point(125, 25);
            this.FacultyNumberMaskedTextBox.Mask = "0000000";
            this.FacultyNumberMaskedTextBox.Name = "FacultyNumberMaskedTextBox";
            this.FacultyNumberMaskedTextBox.Size = new System.Drawing.Size(87, 20);
            this.FacultyNumberMaskedTextBox.TabIndex = 3;
            // 
            // FacultyNumberLabel
            // 
            this.FacultyNumberLabel.AutoSize = true;
            this.FacultyNumberLabel.Location = new System.Drawing.Point(7, 29);
            this.FacultyNumberLabel.Name = "FacultyNumberLabel";
            this.FacultyNumberLabel.Size = new System.Drawing.Size(107, 13);
            this.FacultyNumberLabel.TabIndex = 2;
            this.FacultyNumberLabel.Text = "Факултетен номер:";
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Items.AddRange(new object[] {
            "1536",
            "1537"});
            this.GroupComboBox.Location = new System.Drawing.Point(91, 66);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.GroupComboBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Направление:";
            // 
            // SpecialtyComboBox
            // 
            this.SpecialtyComboBox.FormattingEnabled = true;
            this.SpecialtyComboBox.Items.AddRange(new object[] {
            "Разработка и проектиране на бизнес информационни системи",
            "Анализ и проектиране на бизнес информационни системи"});
            this.SpecialtyComboBox.Location = new System.Drawing.Point(91, 107);
            this.SpecialtyComboBox.Name = "SpecialtyComboBox";
            this.SpecialtyComboBox.Size = new System.Drawing.Size(191, 21);
            this.SpecialtyComboBox.TabIndex = 9;
            // 
            // TextColorChangeBtn
            // 
            this.TextColorChangeBtn.Location = new System.Drawing.Point(12, 141);
            this.TextColorChangeBtn.Name = "TextColorChangeBtn";
            this.TextColorChangeBtn.Size = new System.Drawing.Size(210, 23);
            this.TextColorChangeBtn.TabIndex = 6;
            this.TextColorChangeBtn.Text = "Смяна на цвета на текста";
            this.TextColorChangeBtn.UseVisualStyleBackColor = true;
            this.TextColorChangeBtn.Click += new System.EventHandler(this.TextColorChangeBtn_Click);
            // 
            // ColorChangeGroupBox
            // 
            this.ColorChangeGroupBox.Controls.Add(this.GreenRadioBtn);
            this.ColorChangeGroupBox.Controls.Add(this.BlackRadioBtn);
            this.ColorChangeGroupBox.Controls.Add(this.RedRadioBtn);
            this.ColorChangeGroupBox.Controls.Add(this.TextColorChangeBtn);
            this.ColorChangeGroupBox.Location = new System.Drawing.Point(351, 213);
            this.ColorChangeGroupBox.Name = "ColorChangeGroupBox";
            this.ColorChangeGroupBox.Size = new System.Drawing.Size(228, 184);
            this.ColorChangeGroupBox.TabIndex = 3;
            this.ColorChangeGroupBox.TabStop = false;
            this.ColorChangeGroupBox.Text = "Смяна на цвета";
            // 
            // RedRadioBtn
            // 
            this.RedRadioBtn.AutoSize = true;
            this.RedRadioBtn.Location = new System.Drawing.Point(10, 40);
            this.RedRadioBtn.Name = "RedRadioBtn";
            this.RedRadioBtn.Size = new System.Drawing.Size(63, 17);
            this.RedRadioBtn.TabIndex = 7;
            this.RedRadioBtn.TabStop = true;
            this.RedRadioBtn.Text = "Червен";
            this.RedRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BlackRadioBtn
            // 
            this.BlackRadioBtn.AutoSize = true;
            this.BlackRadioBtn.Location = new System.Drawing.Point(11, 86);
            this.BlackRadioBtn.Name = "BlackRadioBtn";
            this.BlackRadioBtn.Size = new System.Drawing.Size(57, 17);
            this.BlackRadioBtn.TabIndex = 8;
            this.BlackRadioBtn.TabStop = true;
            this.BlackRadioBtn.Text = "Черен";
            this.BlackRadioBtn.UseVisualStyleBackColor = true;
            // 
            // GreenRadioBtn
            // 
            this.GreenRadioBtn.AutoSize = true;
            this.GreenRadioBtn.Location = new System.Drawing.Point(11, 63);
            this.GreenRadioBtn.Name = "GreenRadioBtn";
            this.GreenRadioBtn.Size = new System.Drawing.Size(56, 17);
            this.GreenRadioBtn.TabIndex = 9;
            this.GreenRadioBtn.TabStop = true;
            this.GreenRadioBtn.Text = "Зелен";
            this.GreenRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Location = new System.Drawing.Point(585, 326);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(75, 51);
            this.ClearAllBtn.TabIndex = 4;
            this.ClearAllBtn.Text = "Изчисти";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // Firml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 409);
            this.Controls.Add(this.ClearAllBtn);
            this.Controls.Add(this.ColorChangeGroupBox);
            this.Controls.Add(this.UniversityDataGroup);
            this.Controls.Add(this.ResultRichTextBox);
            this.Controls.Add(this.PersonalDataGroup);
            this.Name = "Firml";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Упражнение 1";
            this.PersonalDataGroup.ResumeLayout(false);
            this.PersonalDataGroup.PerformLayout();
            this.UniversityDataGroup.ResumeLayout(false);
            this.UniversityDataGroup.PerformLayout();
            this.ColorChangeGroupBox.ResumeLayout(false);
            this.ColorChangeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonalDataGroup;
        private System.Windows.Forms.Button PersonalDataBtn;
        private System.Windows.Forms.TextBox BirthPlaceTextBox;
        private System.Windows.Forms.Label BirthPlaceLabel;
        private System.Windows.Forms.MaskedTextBox TelephoneMaskedTextBox;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.RichTextBox ResultRichTextBox;
        private System.Windows.Forms.GroupBox UniversityDataGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.MaskedTextBox FacultyNumberMaskedTextBox;
        private System.Windows.Forms.Label FacultyNumberLabel;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.ComboBox SpecialtyComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TextColorChangeBtn;
        private System.Windows.Forms.GroupBox ColorChangeGroupBox;
        private System.Windows.Forms.RadioButton GreenRadioBtn;
        private System.Windows.Forms.RadioButton BlackRadioBtn;
        private System.Windows.Forms.RadioButton RedRadioBtn;
        private System.Windows.Forms.Button ClearAllBtn;
    }
}

