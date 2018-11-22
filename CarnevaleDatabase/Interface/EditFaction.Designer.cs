using System;

namespace CarnevaleDatabase.Interface
{
    partial class EditFaction
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
            this.factionSelectBox = new System.Windows.Forms.ComboBox();
            this.selectFactionLabel = new System.Windows.Forms.Label();
            this.selectFactionButton = new System.Windows.Forms.Button();
            this.factionNameBox = new System.Windows.Forms.TextBox();
            this.factionNameLabel = new System.Windows.Forms.Label();
            this.imgUrlText = new System.Windows.Forms.TextBox();
            this.imgUrlLabel = new System.Windows.Forms.Label();
            this.commandImgUrlLabel = new System.Windows.Forms.Label();
            this.commandImgUrlText = new System.Windows.Forms.TextBox();
            this.iconUrlText = new System.Windows.Forms.TextBox();
            this.iconUrlLabel = new System.Windows.Forms.Label();
            this.detailedIconLabel = new System.Windows.Forms.Label();
            this.detailedIconText = new System.Windows.Forms.TextBox();
            this.reverseIconText = new System.Windows.Forms.TextBox();
            this.reverseIconLabel = new System.Windows.Forms.Label();
            this.factionStripUrlLabel = new System.Windows.Forms.Label();
            this.factionStripUrlText = new System.Windows.Forms.TextBox();
            this.factionLoreText = new System.Windows.Forms.TextBox();
            this.factionLoreLabel = new System.Windows.Forms.Label();
            this.factionGameplayText = new System.Windows.Forms.TextBox();
            this.factionGameplayLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // factionSelectBox
            // 
            this.factionSelectBox.FormattingEnabled = true;
            this.factionSelectBox.Location = new System.Drawing.Point(21, 53);
            this.factionSelectBox.Name = "factionSelectBox";
            this.factionSelectBox.Size = new System.Drawing.Size(151, 21);
            this.factionSelectBox.TabIndex = 0;
            // 
            // selectFactionLabel
            // 
            this.selectFactionLabel.AutoSize = true;
            this.selectFactionLabel.Location = new System.Drawing.Point(21, 34);
            this.selectFactionLabel.Name = "selectFactionLabel";
            this.selectFactionLabel.Size = new System.Drawing.Size(75, 13);
            this.selectFactionLabel.TabIndex = 1;
            this.selectFactionLabel.Text = "Select Faction";
            // 
            // selectFactionButton
            // 
            this.selectFactionButton.Location = new System.Drawing.Point(21, 91);
            this.selectFactionButton.Name = "selectFactionButton";
            this.selectFactionButton.Size = new System.Drawing.Size(101, 23);
            this.selectFactionButton.TabIndex = 2;
            this.selectFactionButton.Text = "Select Faction";
            this.selectFactionButton.UseVisualStyleBackColor = true;
            this.selectFactionButton.Click += new System.EventHandler(this.SelectFactionButton_Click);
            // 
            // factionNameBox
            // 
            this.factionNameBox.Location = new System.Drawing.Point(203, 53);
            this.factionNameBox.Name = "factionNameBox";
            this.factionNameBox.Size = new System.Drawing.Size(331, 20);
            this.factionNameBox.TabIndex = 3;
            // 
            // factionNameLabel
            // 
            this.factionNameLabel.AutoSize = true;
            this.factionNameLabel.Location = new System.Drawing.Point(203, 34);
            this.factionNameLabel.Name = "factionNameLabel";
            this.factionNameLabel.Size = new System.Drawing.Size(73, 13);
            this.factionNameLabel.TabIndex = 4;
            this.factionNameLabel.Text = "Faction Name";
            // 
            // imgUrlText
            // 
            this.imgUrlText.Location = new System.Drawing.Point(203, 123);
            this.imgUrlText.Name = "imgUrlText";
            this.imgUrlText.Size = new System.Drawing.Size(595, 20);
            this.imgUrlText.TabIndex = 5;
            // 
            // imgUrlLabel
            // 
            this.imgUrlLabel.AutoSize = true;
            this.imgUrlLabel.Location = new System.Drawing.Point(203, 104);
            this.imgUrlLabel.Name = "imgUrlLabel";
            this.imgUrlLabel.Size = new System.Drawing.Size(99, 13);
            this.imgUrlLabel.TabIndex = 6;
            this.imgUrlLabel.Text = "Faction Image URL";
            // 
            // commandImgUrlLabel
            // 
            this.commandImgUrlLabel.AutoSize = true;
            this.commandImgUrlLabel.Location = new System.Drawing.Point(203, 169);
            this.commandImgUrlLabel.Name = "commandImgUrlLabel";
            this.commandImgUrlLabel.Size = new System.Drawing.Size(149, 13);
            this.commandImgUrlLabel.TabIndex = 7;
            this.commandImgUrlLabel.Text = "Faction Command Image URL";
            // 
            // commandImgUrlText
            // 
            this.commandImgUrlText.Location = new System.Drawing.Point(203, 195);
            this.commandImgUrlText.Name = "commandImgUrlText";
            this.commandImgUrlText.Size = new System.Drawing.Size(595, 20);
            this.commandImgUrlText.TabIndex = 8;
            // 
            // iconUrlText
            // 
            this.iconUrlText.Location = new System.Drawing.Point(203, 263);
            this.iconUrlText.Name = "iconUrlText";
            this.iconUrlText.Size = new System.Drawing.Size(595, 20);
            this.iconUrlText.TabIndex = 9;
            // 
            // iconUrlLabel
            // 
            this.iconUrlLabel.AutoSize = true;
            this.iconUrlLabel.Location = new System.Drawing.Point(203, 237);
            this.iconUrlLabel.Name = "iconUrlLabel";
            this.iconUrlLabel.Size = new System.Drawing.Size(91, 13);
            this.iconUrlLabel.TabIndex = 10;
            this.iconUrlLabel.Text = "Faction Icon URL";
            // 
            // detailedIconLabel
            // 
            this.detailedIconLabel.AutoSize = true;
            this.detailedIconLabel.Location = new System.Drawing.Point(203, 307);
            this.detailedIconLabel.Name = "detailedIconLabel";
            this.detailedIconLabel.Size = new System.Drawing.Size(133, 13);
            this.detailedIconLabel.TabIndex = 11;
            this.detailedIconLabel.Text = "Faction Detailed Icon URL";
            // 
            // detailedIconText
            // 
            this.detailedIconText.Location = new System.Drawing.Point(203, 333);
            this.detailedIconText.Name = "detailedIconText";
            this.detailedIconText.Size = new System.Drawing.Size(595, 20);
            this.detailedIconText.TabIndex = 12;
            // 
            // reverseIconText
            // 
            this.reverseIconText.Location = new System.Drawing.Point(203, 396);
            this.reverseIconText.Name = "reverseIconText";
            this.reverseIconText.Size = new System.Drawing.Size(595, 20);
            this.reverseIconText.TabIndex = 13;
            // 
            // reverseIconLabel
            // 
            this.reverseIconLabel.AutoSize = true;
            this.reverseIconLabel.Location = new System.Drawing.Point(206, 377);
            this.reverseIconLabel.Name = "reverseIconLabel";
            this.reverseIconLabel.Size = new System.Drawing.Size(134, 13);
            this.reverseIconLabel.TabIndex = 14;
            this.reverseIconLabel.Text = "Faction Reverse Icon URL";
            // 
            // factionStripUrlLabel
            // 
            this.factionStripUrlLabel.AutoSize = true;
            this.factionStripUrlLabel.Location = new System.Drawing.Point(206, 431);
            this.factionStripUrlLabel.Name = "factionStripUrlLabel";
            this.factionStripUrlLabel.Size = new System.Drawing.Size(91, 13);
            this.factionStripUrlLabel.TabIndex = 15;
            this.factionStripUrlLabel.Text = "Faction Strip URL";
            // 
            // factionStripUrlText
            // 
            this.factionStripUrlText.Location = new System.Drawing.Point(203, 459);
            this.factionStripUrlText.Name = "factionStripUrlText";
            this.factionStripUrlText.Size = new System.Drawing.Size(595, 20);
            this.factionStripUrlText.TabIndex = 16;
            // 
            // factionLoreText
            // 
            this.factionLoreText.Location = new System.Drawing.Point(890, 123);
            this.factionLoreText.Multiline = true;
            this.factionLoreText.Name = "factionLoreText";
            this.factionLoreText.Size = new System.Drawing.Size(401, 160);
            this.factionLoreText.TabIndex = 17;
            // 
            // factionLoreLabel
            // 
            this.factionLoreLabel.AutoSize = true;
            this.factionLoreLabel.Location = new System.Drawing.Point(890, 100);
            this.factionLoreLabel.Name = "factionLoreLabel";
            this.factionLoreLabel.Size = new System.Drawing.Size(66, 13);
            this.factionLoreLabel.TabIndex = 18;
            this.factionLoreLabel.Text = "Faction Lore";
            // 
            // factionGameplayText
            // 
            this.factionGameplayText.Location = new System.Drawing.Point(890, 333);
            this.factionGameplayText.Multiline = true;
            this.factionGameplayText.Name = "factionGameplayText";
            this.factionGameplayText.Size = new System.Drawing.Size(401, 146);
            this.factionGameplayText.TabIndex = 19;
            // 
            // factionGameplayLabel
            // 
            this.factionGameplayLabel.AutoSize = true;
            this.factionGameplayLabel.Location = new System.Drawing.Point(893, 314);
            this.factionGameplayLabel.Name = "factionGameplayLabel";
            this.factionGameplayLabel.Size = new System.Drawing.Size(92, 13);
            this.factionGameplayLabel.TabIndex = 20;
            this.factionGameplayLabel.Text = "Faction Gameplay";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(21, 153);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(151, 112);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save Faction";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(21, 286);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(151, 67);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 629);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.factionGameplayLabel);
            this.Controls.Add(this.factionGameplayText);
            this.Controls.Add(this.factionLoreLabel);
            this.Controls.Add(this.factionLoreText);
            this.Controls.Add(this.factionStripUrlText);
            this.Controls.Add(this.factionStripUrlLabel);
            this.Controls.Add(this.reverseIconLabel);
            this.Controls.Add(this.reverseIconText);
            this.Controls.Add(this.detailedIconText);
            this.Controls.Add(this.detailedIconLabel);
            this.Controls.Add(this.iconUrlLabel);
            this.Controls.Add(this.iconUrlText);
            this.Controls.Add(this.commandImgUrlText);
            this.Controls.Add(this.commandImgUrlLabel);
            this.Controls.Add(this.imgUrlLabel);
            this.Controls.Add(this.imgUrlText);
            this.Controls.Add(this.factionNameLabel);
            this.Controls.Add(this.factionNameBox);
            this.Controls.Add(this.selectFactionButton);
            this.Controls.Add(this.selectFactionLabel);
            this.Controls.Add(this.factionSelectBox);
            this.Name = "EditFaction";
            this.Text = "EditFaction";
            this.Load += new System.EventHandler(this.EditFaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ComboBox factionSelectBox;
        private System.Windows.Forms.Label selectFactionLabel;
        private System.Windows.Forms.Button selectFactionButton;
        private System.Windows.Forms.TextBox factionNameBox;
        private System.Windows.Forms.Label factionNameLabel;
        private System.Windows.Forms.TextBox imgUrlText;
        private System.Windows.Forms.Label imgUrlLabel;
        private System.Windows.Forms.Label commandImgUrlLabel;
        private System.Windows.Forms.TextBox commandImgUrlText;
        private System.Windows.Forms.TextBox iconUrlText;
        private System.Windows.Forms.Label iconUrlLabel;
        private System.Windows.Forms.Label detailedIconLabel;
        private System.Windows.Forms.TextBox detailedIconText;
        private System.Windows.Forms.TextBox reverseIconText;
        private System.Windows.Forms.Label reverseIconLabel;
        private System.Windows.Forms.Label factionStripUrlLabel;
        private System.Windows.Forms.TextBox factionStripUrlText;
        private System.Windows.Forms.TextBox factionLoreText;
        private System.Windows.Forms.Label factionLoreLabel;
        private System.Windows.Forms.TextBox factionGameplayText;
        private System.Windows.Forms.Label factionGameplayLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}