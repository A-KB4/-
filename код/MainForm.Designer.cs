namespace YourNamespace
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveTextButton = new System.Windows.Forms.Button();
            this.loadTextButton = new System.Windows.Forms.Button();
            this.viewArchiveButton = new System.Windows.Forms.Button();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.eyeColorTextBox = new System.Windows.Forms.TextBox();
            this.nationalityTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.birthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.lastKnownAddressTextBox = new System.Windows.Forms.TextBox();
            this.criminalProfessionTextBox = new System.Windows.Forms.TextBox();
            this.hairColorComboBox = new System.Windows.Forms.ComboBox();
            this.crimeRecordListBox = new System.Windows.Forms.ListBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.eyeColorLabel = new System.Windows.Forms.Label();
            this.nationalityLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.birthPlaceLabel = new System.Windows.Forms.Label();
            this.lastKnownAddressLabel = new System.Windows.Forms.Label();
            this.criminalProfessionLabel = new System.Windows.Forms.Label();
            this.hairColorLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 442);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 50);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.Location = new System.Drawing.Point(625, 443);
            this.archiveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(107, 50);
            this.archiveButton.TabIndex = 1;
            this.archiveButton.Text = "Archive";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(130, 442);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 50);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(242, 442);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 50);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel Search";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(964, 443);
            this.loadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(107, 50);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load Archive";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveTextButton
            // 
            this.saveTextButton.Location = new System.Drawing.Point(399, 442);
            this.saveTextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveTextButton.Name = "saveTextButton";
            this.saveTextButton.Size = new System.Drawing.Size(107, 50);
            this.saveTextButton.TabIndex = 5;
            this.saveTextButton.Text = "Save ";
            this.saveTextButton.UseVisualStyleBackColor = true;
            this.saveTextButton.Click += new System.EventHandler(this.saveTextButton_Click);
            // 
            // loadTextButton
            // 
            this.loadTextButton.Location = new System.Drawing.Point(512, 442);
            this.loadTextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadTextButton.Name = "loadTextButton";
            this.loadTextButton.Size = new System.Drawing.Size(107, 50);
            this.loadTextButton.TabIndex = 6;
            this.loadTextButton.Text = "Load ";
            this.loadTextButton.UseVisualStyleBackColor = true;
            this.loadTextButton.Click += new System.EventHandler(this.loadTextButton_Click);
            // 
            // viewArchiveButton
            // 
            this.viewArchiveButton.Location = new System.Drawing.Point(851, 443);
            this.viewArchiveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewArchiveButton.Name = "viewArchiveButton";
            this.viewArchiveButton.Size = new System.Drawing.Size(107, 50);
            this.viewArchiveButton.TabIndex = 7;
            this.viewArchiveButton.Text = "View Archive";
            this.viewArchiveButton.UseVisualStyleBackColor = true;
            this.viewArchiveButton.Click += new System.EventHandler(this.viewArchiveButton_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(158, 27);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(178, 27);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(158, 62);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(178, 27);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Location = new System.Drawing.Point(158, 97);
            this.nicknameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(178, 27);
            this.nicknameTextBox.TabIndex = 10;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(158, 138);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(178, 27);
            this.heightTextBox.TabIndex = 11;
            // 
            // eyeColorTextBox
            // 
            this.eyeColorTextBox.Location = new System.Drawing.Point(158, 175);
            this.eyeColorTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eyeColorTextBox.Name = "eyeColorTextBox";
            this.eyeColorTextBox.Size = new System.Drawing.Size(178, 27);
            this.eyeColorTextBox.TabIndex = 12;
            // 
            // nationalityTextBox
            // 
            this.nationalityTextBox.Location = new System.Drawing.Point(158, 212);
            this.nationalityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nationalityTextBox.Name = "nationalityTextBox";
            this.nationalityTextBox.Size = new System.Drawing.Size(178, 27);
            this.nationalityTextBox.TabIndex = 13;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Location = new System.Drawing.Point(158, 250);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(178, 27);
            this.birthDateTextBox.TabIndex = 14;
            // 
            // birthPlaceTextBox
            // 
            this.birthPlaceTextBox.Location = new System.Drawing.Point(158, 287);
            this.birthPlaceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthPlaceTextBox.Name = "birthPlaceTextBox";
            this.birthPlaceTextBox.Size = new System.Drawing.Size(178, 27);
            this.birthPlaceTextBox.TabIndex = 15;
            // 
            // lastKnownAddressTextBox
            // 
            this.lastKnownAddressTextBox.Location = new System.Drawing.Point(158, 324);
            this.lastKnownAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastKnownAddressTextBox.Name = "lastKnownAddressTextBox";
            this.lastKnownAddressTextBox.Size = new System.Drawing.Size(178, 27);
            this.lastKnownAddressTextBox.TabIndex = 16;
            // 
            // criminalProfessionTextBox
            // 
            this.criminalProfessionTextBox.Location = new System.Drawing.Point(158, 358);
            this.criminalProfessionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.criminalProfessionTextBox.Name = "criminalProfessionTextBox";
            this.criminalProfessionTextBox.Size = new System.Drawing.Size(178, 27);
            this.criminalProfessionTextBox.TabIndex = 17;
            // 
            // hairColorComboBox
            // 
            this.hairColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hairColorComboBox.FormattingEnabled = true;
            this.hairColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Blonde",
            "Red",
            "Gray"});
            this.hairColorComboBox.Location = new System.Drawing.Point(158, 393);
            this.hairColorComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hairColorComboBox.Name = "hairColorComboBox";
            this.hairColorComboBox.Size = new System.Drawing.Size(178, 28);
            this.hairColorComboBox.TabIndex = 18;
            // 
            // crimeRecordListBox
            // 
            this.crimeRecordListBox.FormattingEnabled = true;
            this.crimeRecordListBox.ItemHeight = 20;
            this.crimeRecordListBox.Location = new System.Drawing.Point(342, 25);
            this.crimeRecordListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crimeRecordListBox.Name = "crimeRecordListBox";
            this.crimeRecordListBox.Size = new System.Drawing.Size(1493, 404);
            this.crimeRecordListBox.TabIndex = 19;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(18, 28);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(83, 20);
            this.firstNameLabel.TabIndex = 20;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(18, 65);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(82, 20);
            this.lastNameLabel.TabIndex = 21;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Location = new System.Drawing.Point(18, 103);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(78, 20);
            this.nicknameLabel.TabIndex = 22;
            this.nicknameLabel.Text = "Nickname:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(18, 141);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(57, 20);
            this.heightLabel.TabIndex = 23;
            this.heightLabel.Text = "Height:";
            // 
            // eyeColorLabel
            // 
            this.eyeColorLabel.AutoSize = true;
            this.eyeColorLabel.Location = new System.Drawing.Point(18, 178);
            this.eyeColorLabel.Name = "eyeColorLabel";
            this.eyeColorLabel.Size = new System.Drawing.Size(75, 20);
            this.eyeColorLabel.TabIndex = 24;
            this.eyeColorLabel.Text = "Eye Color:";
            // 
            // nationalityLabel
            // 
            this.nationalityLabel.AutoSize = true;
            this.nationalityLabel.Location = new System.Drawing.Point(18, 215);
            this.nationalityLabel.Name = "nationalityLabel";
            this.nationalityLabel.Size = new System.Drawing.Size(85, 20);
            this.nationalityLabel.TabIndex = 25;
            this.nationalityLabel.Text = "Nationality:";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(18, 253);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(79, 20);
            this.birthDateLabel.TabIndex = 26;
            this.birthDateLabel.Text = "Birth Date:";
            // 
            // birthPlaceLabel
            // 
            this.birthPlaceLabel.AutoSize = true;
            this.birthPlaceLabel.Location = new System.Drawing.Point(18, 290);
            this.birthPlaceLabel.Name = "birthPlaceLabel";
            this.birthPlaceLabel.Size = new System.Drawing.Size(82, 20);
            this.birthPlaceLabel.TabIndex = 27;
            this.birthPlaceLabel.Text = "Birth Place:";
            // 
            // lastKnownAddressLabel
            // 
            this.lastKnownAddressLabel.AutoSize = true;
            this.lastKnownAddressLabel.Location = new System.Drawing.Point(13, 327);
            this.lastKnownAddressLabel.Name = "lastKnownAddressLabel";
            this.lastKnownAddressLabel.Size = new System.Drawing.Size(144, 20);
            this.lastKnownAddressLabel.TabIndex = 28;
            this.lastKnownAddressLabel.Text = "Last Known Address:";
            // 
            // criminalProfessionLabel
            // 
            this.criminalProfessionLabel.AutoSize = true;
            this.criminalProfessionLabel.Location = new System.Drawing.Point(18, 365);
            this.criminalProfessionLabel.Name = "criminalProfessionLabel";
            this.criminalProfessionLabel.Size = new System.Drawing.Size(139, 20);
            this.criminalProfessionLabel.TabIndex = 29;
            this.criminalProfessionLabel.Text = "Criminal Profession:";
            // 
            // hairColorLabel
            // 
            this.hairColorLabel.AutoSize = true;
            this.hairColorLabel.Location = new System.Drawing.Point(18, 403);
            this.hairColorLabel.Name = "hairColorLabel";
            this.hairColorLabel.Size = new System.Drawing.Size(80, 20);
            this.hairColorLabel.TabIndex = 30;
            this.hairColorLabel.Text = "Hair Color:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(738, 443);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(107, 50);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = " Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1919, 506);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.hairColorLabel);
            this.Controls.Add(this.criminalProfessionLabel);
            this.Controls.Add(this.lastKnownAddressLabel);
            this.Controls.Add(this.birthPlaceLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.nationalityLabel);
            this.Controls.Add(this.eyeColorLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.crimeRecordListBox);
            this.Controls.Add(this.hairColorComboBox);
            this.Controls.Add(this.criminalProfessionTextBox);
            this.Controls.Add(this.lastKnownAddressTextBox);
            this.Controls.Add(this.birthPlaceTextBox);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(this.nationalityTextBox);
            this.Controls.Add(this.eyeColorTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.viewArchiveButton);
            this.Controls.Add(this.loadTextButton);
            this.Controls.Add(this.saveTextButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Crime Record System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveTextButton;
        private System.Windows.Forms.Button loadTextButton;
        private System.Windows.Forms.Button viewArchiveButton;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox eyeColorTextBox;
        private System.Windows.Forms.TextBox nationalityTextBox;
        private System.Windows.Forms.TextBox birthDateTextBox;
        private System.Windows.Forms.TextBox birthPlaceTextBox;
        private System.Windows.Forms.TextBox lastKnownAddressTextBox;
        private System.Windows.Forms.TextBox criminalProfessionTextBox;
        private System.Windows.Forms.ComboBox hairColorComboBox;
        private System.Windows.Forms.ListBox crimeRecordListBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label eyeColorLabel;
        private System.Windows.Forms.Label nationalityLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label birthPlaceLabel;
        private System.Windows.Forms.Label lastKnownAddressLabel;
        private System.Windows.Forms.Label criminalProfessionLabel;
        private System.Windows.Forms.Label hairColorLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}
