namespace CarnevaleDatabase.Interface
{
    partial class KeyWords
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
            this.createKeyWordButton = new System.Windows.Forms.Button();
            this.editKeyWordButton = new System.Windows.Forms.Button();
            this.enterKeyWordLabel = new System.Windows.Forms.Label();
            this.newKeyWordText = new System.Windows.Forms.TextBox();
            this.saveNewKeyWordButton = new System.Windows.Forms.Button();
            this.selectKeyWordLabel = new System.Windows.Forms.Label();
            this.keyWordCombo = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.keyWordText = new System.Windows.Forms.TextBox();
            this.saveEditKeyWordButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createKeyWordButton
            // 
            this.createKeyWordButton.Location = new System.Drawing.Point(54, 34);
            this.createKeyWordButton.Name = "createKeyWordButton";
            this.createKeyWordButton.Size = new System.Drawing.Size(148, 23);
            this.createKeyWordButton.TabIndex = 0;
            this.createKeyWordButton.Text = "Create New Keyword";
            this.createKeyWordButton.UseVisualStyleBackColor = true;
            this.createKeyWordButton.Click += new System.EventHandler(this.createKeyWordButton_Click);
            // 
            // editKeyWordButton
            // 
            this.editKeyWordButton.Location = new System.Drawing.Point(580, 34);
            this.editKeyWordButton.Name = "editKeyWordButton";
            this.editKeyWordButton.Size = new System.Drawing.Size(140, 23);
            this.editKeyWordButton.TabIndex = 1;
            this.editKeyWordButton.Text = "Edit KeyWord";
            this.editKeyWordButton.UseVisualStyleBackColor = true;
            this.editKeyWordButton.Click += new System.EventHandler(this.editKeyWordButton_Click);
            // 
            // enterKeyWordLabel
            // 
            this.enterKeyWordLabel.AutoSize = true;
            this.enterKeyWordLabel.Location = new System.Drawing.Point(54, 75);
            this.enterKeyWordLabel.Name = "enterKeyWordLabel";
            this.enterKeyWordLabel.Size = new System.Drawing.Size(104, 13);
            this.enterKeyWordLabel.TabIndex = 2;
            this.enterKeyWordLabel.Text = "Enter New KeyWord";
            // 
            // newKeyWordText
            // 
            this.newKeyWordText.Location = new System.Drawing.Point(54, 102);
            this.newKeyWordText.Name = "newKeyWordText";
            this.newKeyWordText.Size = new System.Drawing.Size(148, 20);
            this.newKeyWordText.TabIndex = 3;
            // 
            // saveNewKeyWordButton
            // 
            this.saveNewKeyWordButton.Location = new System.Drawing.Point(54, 156);
            this.saveNewKeyWordButton.Name = "saveNewKeyWordButton";
            this.saveNewKeyWordButton.Size = new System.Drawing.Size(148, 23);
            this.saveNewKeyWordButton.TabIndex = 4;
            this.saveNewKeyWordButton.Text = "Save Key Word";
            this.saveNewKeyWordButton.UseVisualStyleBackColor = true;
            this.saveNewKeyWordButton.Click += new System.EventHandler(this.saveNewKeyWordButton_Click);
            // 
            // selectKeyWordLabel
            // 
            this.selectKeyWordLabel.AutoSize = true;
            this.selectKeyWordLabel.Location = new System.Drawing.Point(580, 74);
            this.selectKeyWordLabel.Name = "selectKeyWordLabel";
            this.selectKeyWordLabel.Size = new System.Drawing.Size(84, 13);
            this.selectKeyWordLabel.TabIndex = 5;
            this.selectKeyWordLabel.Text = "Select KeyWord";
            // 
            // keyWordCombo
            // 
            this.keyWordCombo.FormattingEnabled = true;
            this.keyWordCombo.Location = new System.Drawing.Point(580, 102);
            this.keyWordCombo.Name = "keyWordCombo";
            this.keyWordCombo.Size = new System.Drawing.Size(140, 21);
            this.keyWordCombo.TabIndex = 6;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(580, 147);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(140, 23);
            this.selectButton.TabIndex = 7;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // keyWordText
            // 
            this.keyWordText.Location = new System.Drawing.Point(580, 198);
            this.keyWordText.Name = "keyWordText";
            this.keyWordText.Size = new System.Drawing.Size(140, 20);
            this.keyWordText.TabIndex = 8;
            // 
            // saveEditKeyWordButton
            // 
            this.saveEditKeyWordButton.Location = new System.Drawing.Point(580, 241);
            this.saveEditKeyWordButton.Name = "saveEditKeyWordButton";
            this.saveEditKeyWordButton.Size = new System.Drawing.Size(140, 23);
            this.saveEditKeyWordButton.TabIndex = 9;
            this.saveEditKeyWordButton.Text = "Save";
            this.saveEditKeyWordButton.UseVisualStyleBackColor = true;
            this.saveEditKeyWordButton.Click += new System.EventHandler(this.saveEditKeyWordButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(313, 77);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(164, 102);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // KeyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 354);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveEditKeyWordButton);
            this.Controls.Add(this.keyWordText);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.keyWordCombo);
            this.Controls.Add(this.selectKeyWordLabel);
            this.Controls.Add(this.saveNewKeyWordButton);
            this.Controls.Add(this.newKeyWordText);
            this.Controls.Add(this.enterKeyWordLabel);
            this.Controls.Add(this.editKeyWordButton);
            this.Controls.Add(this.createKeyWordButton);
            this.Name = "KeyWords";
            this.Text = "KeyWords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createKeyWordButton;
        private System.Windows.Forms.Button editKeyWordButton;
        private System.Windows.Forms.Label enterKeyWordLabel;
        private System.Windows.Forms.TextBox newKeyWordText;
        private System.Windows.Forms.Button saveNewKeyWordButton;
        private System.Windows.Forms.Label selectKeyWordLabel;
        private System.Windows.Forms.ComboBox keyWordCombo;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox keyWordText;
        private System.Windows.Forms.Button saveEditKeyWordButton;
        private System.Windows.Forms.Button cancelButton;
    }
}