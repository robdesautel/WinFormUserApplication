namespace WinFormExampleUsage
{
    partial class NewEmployee
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
            this.Person = new System.Windows.Forms.TabControl();
            this.PersonContact = new System.Windows.Forms.TabPage();
            this.personSuffixLabel = new System.Windows.Forms.Label();
            this.personSuffix = new System.Windows.Forms.ComboBox();
            this.personPhoneNumberType = new System.Windows.Forms.Label();
            this.personPhoneNumberLabel = new System.Windows.Forms.Label();
            this.saveContactButton = new System.Windows.Forms.Button();
            this.personRecieveEmails = new System.Windows.Forms.CheckBox();
            this.personContactInforamtionLabel = new System.Windows.Forms.Label();
            this.personContactInformation = new System.Windows.Forms.ComboBox();
            this.personTitleLabel = new System.Windows.Forms.Label();
            this.personTitle = new System.Windows.Forms.ComboBox();
            this.personLastNameLabel = new System.Windows.Forms.Label();
            this.personLastName = new System.Windows.Forms.TextBox();
            this.personFirstNameLabel = new System.Windows.Forms.Label();
            this.personFirstName = new System.Windows.Forms.TextBox();
            this.personEmailAddressLabel = new System.Windows.Forms.Label();
            this.personEmailAddress = new System.Windows.Forms.TextBox();
            this.personCountryRegionLabel = new System.Windows.Forms.Label();
            this.personCountryRegion = new System.Windows.Forms.ComboBox();
            this.personContactTypes = new System.Windows.Forms.ComboBox();
            this.personContactType = new System.Windows.Forms.Label();
            this.personAddressType = new System.Windows.Forms.ComboBox();
            this.personAddressTypeLabel = new System.Windows.Forms.Label();
            this.personZipCodeLabel = new System.Windows.Forms.Label();
            this.personZipCode = new System.Windows.Forms.TextBox();
            this.personAddress2Label = new System.Windows.Forms.Label();
            this.personAddress2 = new System.Windows.Forms.TextBox();
            this.personAddress1Label = new System.Windows.Forms.Label();
            this.personAddress1 = new System.Windows.Forms.TextBox();
            this.personPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cellPhoneTypes = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Person.SuspendLayout();
            this.PersonContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // Person
            // 
            this.Person.Controls.Add(this.PersonContact);
            this.Person.Controls.Add(this.tabPage2);
            this.Person.Location = new System.Drawing.Point(1, 2);
            this.Person.Name = "Person";
            this.Person.SelectedIndex = 0;
            this.Person.Size = new System.Drawing.Size(939, 477);
            this.Person.TabIndex = 26;
            // 
            // PersonContact
            // 
            this.PersonContact.Controls.Add(this.personSuffixLabel);
            this.PersonContact.Controls.Add(this.personSuffix);
            this.PersonContact.Controls.Add(this.personPhoneNumberType);
            this.PersonContact.Controls.Add(this.personPhoneNumberLabel);
            this.PersonContact.Controls.Add(this.saveContactButton);
            this.PersonContact.Controls.Add(this.personRecieveEmails);
            this.PersonContact.Controls.Add(this.personContactInforamtionLabel);
            this.PersonContact.Controls.Add(this.personContactInformation);
            this.PersonContact.Controls.Add(this.personTitleLabel);
            this.PersonContact.Controls.Add(this.personTitle);
            this.PersonContact.Controls.Add(this.personLastNameLabel);
            this.PersonContact.Controls.Add(this.personLastName);
            this.PersonContact.Controls.Add(this.personFirstNameLabel);
            this.PersonContact.Controls.Add(this.personFirstName);
            this.PersonContact.Controls.Add(this.personEmailAddressLabel);
            this.PersonContact.Controls.Add(this.personEmailAddress);
            this.PersonContact.Controls.Add(this.personCountryRegionLabel);
            this.PersonContact.Controls.Add(this.personCountryRegion);
            this.PersonContact.Controls.Add(this.personContactTypes);
            this.PersonContact.Controls.Add(this.personContactType);
            this.PersonContact.Controls.Add(this.personAddressType);
            this.PersonContact.Controls.Add(this.personAddressTypeLabel);
            this.PersonContact.Controls.Add(this.personZipCodeLabel);
            this.PersonContact.Controls.Add(this.personZipCode);
            this.PersonContact.Controls.Add(this.personAddress2Label);
            this.PersonContact.Controls.Add(this.personAddress2);
            this.PersonContact.Controls.Add(this.personAddress1Label);
            this.PersonContact.Controls.Add(this.personAddress1);
            this.PersonContact.Controls.Add(this.personPhoneNumber);
            this.PersonContact.Controls.Add(this.cellPhoneTypes);
            this.PersonContact.Location = new System.Drawing.Point(4, 22);
            this.PersonContact.Name = "PersonContact";
            this.PersonContact.Padding = new System.Windows.Forms.Padding(3);
            this.PersonContact.Size = new System.Drawing.Size(931, 451);
            this.PersonContact.TabIndex = 0;
            this.PersonContact.Text = "Contact Information";
            this.PersonContact.UseVisualStyleBackColor = true;
            // 
            // personSuffixLabel
            // 
            this.personSuffixLabel.AutoSize = true;
            this.personSuffixLabel.Location = new System.Drawing.Point(412, 18);
            this.personSuffixLabel.Name = "personSuffixLabel";
            this.personSuffixLabel.Size = new System.Drawing.Size(81, 13);
            this.personSuffixLabel.TabIndex = 57;
            this.personSuffixLabel.Text = "Suffix (Optional)";
            // 
            // personSuffix
            // 
            this.personSuffix.FormattingEnabled = true;
            this.personSuffix.Location = new System.Drawing.Point(412, 37);
            this.personSuffix.Name = "personSuffix";
            this.personSuffix.Size = new System.Drawing.Size(80, 21);
            this.personSuffix.TabIndex = 56;
            // 
            // personPhoneNumberType
            // 
            this.personPhoneNumberType.AutoSize = true;
            this.personPhoneNumberType.Location = new System.Drawing.Point(160, 233);
            this.personPhoneNumberType.Name = "personPhoneNumberType";
            this.personPhoneNumberType.Size = new System.Drawing.Size(105, 13);
            this.personPhoneNumberType.TabIndex = 55;
            this.personPhoneNumberType.Text = "Phone Number Type";
            // 
            // personPhoneNumberLabel
            // 
            this.personPhoneNumberLabel.AutoSize = true;
            this.personPhoneNumberLabel.Location = new System.Drawing.Point(7, 233);
            this.personPhoneNumberLabel.Name = "personPhoneNumberLabel";
            this.personPhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.personPhoneNumberLabel.TabIndex = 54;
            this.personPhoneNumberLabel.Text = "Phone Number";
            // 
            // saveContactButton
            // 
            this.saveContactButton.Location = new System.Drawing.Point(470, 383);
            this.saveContactButton.Name = "saveContactButton";
            this.saveContactButton.Size = new System.Drawing.Size(75, 23);
            this.saveContactButton.TabIndex = 53;
            this.saveContactButton.Text = "Save Contact";
            this.saveContactButton.UseVisualStyleBackColor = true;
            this.saveContactButton.Click += new System.EventHandler(this.saveContactButton_Click);
            // 
            // personRecieveEmails
            // 
            this.personRecieveEmails.AutoSize = true;
            this.personRecieveEmails.Location = new System.Drawing.Point(10, 345);
            this.personRecieveEmails.Name = "personRecieveEmails";
            this.personRecieveEmails.Size = new System.Drawing.Size(99, 17);
            this.personRecieveEmails.TabIndex = 52;
            this.personRecieveEmails.Text = "Recieve Emails";
            this.personRecieveEmails.UseVisualStyleBackColor = true;
            // 
            // personContactInforamtionLabel
            // 
            this.personContactInforamtionLabel.AutoSize = true;
            this.personContactInforamtionLabel.Location = new System.Drawing.Point(657, 20);
            this.personContactInforamtionLabel.Name = "personContactInforamtionLabel";
            this.personContactInforamtionLabel.Size = new System.Drawing.Size(99, 13);
            this.personContactInforamtionLabel.TabIndex = 51;
            this.personContactInforamtionLabel.Text = "Contact Inforamtion";
            // 
            // personContactInformation
            // 
            this.personContactInformation.FormattingEnabled = true;
            this.personContactInformation.Location = new System.Drawing.Point(657, 39);
            this.personContactInformation.Name = "personContactInformation";
            this.personContactInformation.Size = new System.Drawing.Size(121, 21);
            this.personContactInformation.TabIndex = 50;
            // 
            // personTitleLabel
            // 
            this.personTitleLabel.AutoSize = true;
            this.personTitleLabel.Location = new System.Drawing.Point(7, 19);
            this.personTitleLabel.Name = "personTitleLabel";
            this.personTitleLabel.Size = new System.Drawing.Size(75, 13);
            this.personTitleLabel.TabIndex = 49;
            this.personTitleLabel.Text = "Title (Optional)";
            // 
            // personTitle
            // 
            this.personTitle.FormattingEnabled = true;
            this.personTitle.Location = new System.Drawing.Point(7, 39);
            this.personTitle.Name = "personTitle";
            this.personTitle.Size = new System.Drawing.Size(57, 21);
            this.personTitle.TabIndex = 48;
            // 
            // personLastNameLabel
            // 
            this.personLastNameLabel.AutoSize = true;
            this.personLastNameLabel.Location = new System.Drawing.Point(265, 19);
            this.personLastNameLabel.Name = "personLastNameLabel";
            this.personLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.personLastNameLabel.TabIndex = 47;
            this.personLastNameLabel.Text = "Last Name";
            // 
            // personLastName
            // 
            this.personLastName.Location = new System.Drawing.Point(268, 39);
            this.personLastName.Name = "personLastName";
            this.personLastName.Size = new System.Drawing.Size(128, 20);
            this.personLastName.TabIndex = 46;
            // 
            // personFirstNameLabel
            // 
            this.personFirstNameLabel.AutoSize = true;
            this.personFirstNameLabel.Location = new System.Drawing.Point(96, 21);
            this.personFirstNameLabel.Name = "personFirstNameLabel";
            this.personFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.personFirstNameLabel.TabIndex = 45;
            this.personFirstNameLabel.Text = "First Name";
            // 
            // personFirstName
            // 
            this.personFirstName.Location = new System.Drawing.Point(100, 39);
            this.personFirstName.Name = "personFirstName";
            this.personFirstName.Size = new System.Drawing.Size(135, 20);
            this.personFirstName.TabIndex = 44;
            // 
            // personEmailAddressLabel
            // 
            this.personEmailAddressLabel.AutoSize = true;
            this.personEmailAddressLabel.Location = new System.Drawing.Point(521, 23);
            this.personEmailAddressLabel.Name = "personEmailAddressLabel";
            this.personEmailAddressLabel.Size = new System.Drawing.Size(73, 13);
            this.personEmailAddressLabel.TabIndex = 43;
            this.personEmailAddressLabel.Text = "Email Address";
            // 
            // personEmailAddress
            // 
            this.personEmailAddress.Location = new System.Drawing.Point(524, 39);
            this.personEmailAddress.Name = "personEmailAddress";
            this.personEmailAddress.Size = new System.Drawing.Size(100, 20);
            this.personEmailAddress.TabIndex = 42;
            // 
            // personCountryRegionLabel
            // 
            this.personCountryRegionLabel.AutoSize = true;
            this.personCountryRegionLabel.Location = new System.Drawing.Point(7, 189);
            this.personCountryRegionLabel.Name = "personCountryRegionLabel";
            this.personCountryRegionLabel.Size = new System.Drawing.Size(121, 13);
            this.personCountryRegionLabel.TabIndex = 41;
            this.personCountryRegionLabel.Text = "Choose Country/Region";
            // 
            // personCountryRegion
            // 
            this.personCountryRegion.FormattingEnabled = true;
            this.personCountryRegion.Location = new System.Drawing.Point(7, 205);
            this.personCountryRegion.Name = "personCountryRegion";
            this.personCountryRegion.Size = new System.Drawing.Size(121, 21);
            this.personCountryRegion.TabIndex = 40;
            // 
            // personContactTypes
            // 
            this.personContactTypes.FormattingEnabled = true;
            this.personContactTypes.Location = new System.Drawing.Point(166, 150);
            this.personContactTypes.Name = "personContactTypes";
            this.personContactTypes.Size = new System.Drawing.Size(121, 21);
            this.personContactTypes.TabIndex = 39;
            // 
            // personContactType
            // 
            this.personContactType.AutoSize = true;
            this.personContactType.Location = new System.Drawing.Point(163, 134);
            this.personContactType.Name = "personContactType";
            this.personContactType.Size = new System.Drawing.Size(71, 13);
            this.personContactType.TabIndex = 38;
            this.personContactType.Text = "Contact Type";
            // 
            // personAddressType
            // 
            this.personAddressType.FormattingEnabled = true;
            this.personAddressType.Location = new System.Drawing.Point(166, 96);
            this.personAddressType.Name = "personAddressType";
            this.personAddressType.Size = new System.Drawing.Size(121, 21);
            this.personAddressType.TabIndex = 37;
            // 
            // personAddressTypeLabel
            // 
            this.personAddressTypeLabel.AutoSize = true;
            this.personAddressTypeLabel.Location = new System.Drawing.Point(163, 78);
            this.personAddressTypeLabel.Name = "personAddressTypeLabel";
            this.personAddressTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.personAddressTypeLabel.TabIndex = 36;
            this.personAddressTypeLabel.Text = "Address Type";
            // 
            // personZipCodeLabel
            // 
            this.personZipCodeLabel.AutoSize = true;
            this.personZipCodeLabel.Location = new System.Drawing.Point(163, 189);
            this.personZipCodeLabel.Name = "personZipCodeLabel";
            this.personZipCodeLabel.Size = new System.Drawing.Size(50, 13);
            this.personZipCodeLabel.TabIndex = 35;
            this.personZipCodeLabel.Text = "Zip Code";
            // 
            // personZipCode
            // 
            this.personZipCode.Location = new System.Drawing.Point(163, 208);
            this.personZipCode.Name = "personZipCode";
            this.personZipCode.Size = new System.Drawing.Size(100, 20);
            this.personZipCode.TabIndex = 34;
            // 
            // personAddress2Label
            // 
            this.personAddress2Label.AutoSize = true;
            this.personAddress2Label.Location = new System.Drawing.Point(7, 134);
            this.personAddress2Label.Name = "personAddress2Label";
            this.personAddress2Label.Size = new System.Drawing.Size(54, 13);
            this.personAddress2Label.TabIndex = 31;
            this.personAddress2Label.Text = "Address 2";
            // 
            // personAddress2
            // 
            this.personAddress2.Location = new System.Drawing.Point(7, 153);
            this.personAddress2.Name = "personAddress2";
            this.personAddress2.Size = new System.Drawing.Size(121, 20);
            this.personAddress2.TabIndex = 30;
            // 
            // personAddress1Label
            // 
            this.personAddress1Label.AutoSize = true;
            this.personAddress1Label.Location = new System.Drawing.Point(7, 78);
            this.personAddress1Label.Name = "personAddress1Label";
            this.personAddress1Label.Size = new System.Drawing.Size(54, 13);
            this.personAddress1Label.TabIndex = 29;
            this.personAddress1Label.Text = "Address 1";
            // 
            // personAddress1
            // 
            this.personAddress1.Location = new System.Drawing.Point(7, 97);
            this.personAddress1.Name = "personAddress1";
            this.personAddress1.Size = new System.Drawing.Size(121, 20);
            this.personAddress1.TabIndex = 28;
            // 
            // personPhoneNumber
            // 
            this.personPhoneNumber.Location = new System.Drawing.Point(7, 252);
            this.personPhoneNumber.Mask = "(999) 000-0000";
            this.personPhoneNumber.Name = "personPhoneNumber";
            this.personPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.personPhoneNumber.TabIndex = 27;
            // 
            // cellPhoneTypes
            // 
            this.cellPhoneTypes.FormattingEnabled = true;
            this.cellPhoneTypes.Location = new System.Drawing.Point(163, 252);
            this.cellPhoneTypes.Name = "cellPhoneTypes";
            this.cellPhoneTypes.Size = new System.Drawing.Size(121, 21);
            this.cellPhoneTypes.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(931, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(939, 476);
            this.Controls.Add(this.Person);
            this.Name = "NewEmployee";
            this.Text = "Form1";
            this.Person.ResumeLayout(false);
            this.PersonContact.ResumeLayout(false);
            this.PersonContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Person;
        private System.Windows.Forms.TabPage PersonContact;
        private System.Windows.Forms.CheckBox personRecieveEmails;
        private System.Windows.Forms.Label personContactInforamtionLabel;
        private System.Windows.Forms.ComboBox personContactInformation;
        private System.Windows.Forms.Label personTitleLabel;
        private System.Windows.Forms.ComboBox personTitle;
        private System.Windows.Forms.Label personLastNameLabel;
        private System.Windows.Forms.TextBox personLastName;
        private System.Windows.Forms.Label personFirstNameLabel;
        private System.Windows.Forms.TextBox personFirstName;
        private System.Windows.Forms.Label personEmailAddressLabel;
        private System.Windows.Forms.TextBox personEmailAddress;
        private System.Windows.Forms.Label personCountryRegionLabel;
        private System.Windows.Forms.ComboBox personCountryRegion;
        private System.Windows.Forms.ComboBox personContactTypes;
        private System.Windows.Forms.Label personContactType;
        private System.Windows.Forms.ComboBox personAddressType;
        private System.Windows.Forms.Label personAddressTypeLabel;
        private System.Windows.Forms.Label personZipCodeLabel;
        private System.Windows.Forms.TextBox personZipCode;
        private System.Windows.Forms.Label personAddress2Label;
        private System.Windows.Forms.TextBox personAddress2;
        private System.Windows.Forms.Label personAddress1Label;
        private System.Windows.Forms.TextBox personAddress1;
        private System.Windows.Forms.MaskedTextBox personPhoneNumber;
        private System.Windows.Forms.ComboBox cellPhoneTypes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button saveContactButton;
        private System.Windows.Forms.Label personPhoneNumberLabel;
        private System.Windows.Forms.Label personPhoneNumberType;
        private System.Windows.Forms.Label personSuffixLabel;
        private System.Windows.Forms.ComboBox personSuffix;
    }
}

