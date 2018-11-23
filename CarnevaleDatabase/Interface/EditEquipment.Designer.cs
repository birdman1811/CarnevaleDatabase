namespace CarnevaleDatabase.Interface
{
    partial class EditEquipment
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
            this.createNewButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.equipmentCombo = new System.Windows.Forms.ComboBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.equipmentNameText = new System.Windows.Forms.TextBox();
            this.equipmentTextLabel = new System.Windows.Forms.Label();
            this.equipmentRulesText = new System.Windows.Forms.TextBox();
            this.itemCostLabel = new System.Windows.Forms.Label();
            this.costSpinner = new System.Windows.Forms.NumericUpDown();
            this.iconUrlLabel = new System.Windows.Forms.Label();
            this.iconUrlText = new System.Windows.Forms.TextBox();
            this.insertNewButton = new System.Windows.Forms.Button();
            this.updateItemButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.costSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // createNewButton
            // 
            this.createNewButton.Location = new System.Drawing.Point(30, 39);
            this.createNewButton.Name = "createNewButton";
            this.createNewButton.Size = new System.Drawing.Size(162, 23);
            this.createNewButton.TabIndex = 0;
            this.createNewButton.Text = "Create New Equipment Item";
            this.createNewButton.UseVisualStyleBackColor = true;
            this.createNewButton.Click += new System.EventHandler(this.createNewButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.Location = new System.Drawing.Point(30, 89);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(162, 23);
            this.editItemButton.TabIndex = 1;
            this.editItemButton.Text = "Edit Equipment Item";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // equipmentCombo
            // 
            this.equipmentCombo.FormattingEnabled = true;
            this.equipmentCombo.Location = new System.Drawing.Point(30, 149);
            this.equipmentCombo.Name = "equipmentCombo";
            this.equipmentCombo.Size = new System.Drawing.Size(162, 21);
            this.equipmentCombo.TabIndex = 2;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(30, 189);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(162, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(296, 89);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(88, 13);
            this.itemNameLabel.TabIndex = 4;
            this.itemNameLabel.Text = "Equipment Name";
            // 
            // equipmentNameText
            // 
            this.equipmentNameText.Location = new System.Drawing.Point(299, 114);
            this.equipmentNameText.Name = "equipmentNameText";
            this.equipmentNameText.Size = new System.Drawing.Size(156, 20);
            this.equipmentNameText.TabIndex = 5;
            // 
            // equipmentTextLabel
            // 
            this.equipmentTextLabel.AutoSize = true;
            this.equipmentTextLabel.Location = new System.Drawing.Point(296, 157);
            this.equipmentTextLabel.Name = "equipmentTextLabel";
            this.equipmentTextLabel.Size = new System.Drawing.Size(81, 13);
            this.equipmentTextLabel.TabIndex = 6;
            this.equipmentTextLabel.Text = "Equipment Text";
            // 
            // equipmentRulesText
            // 
            this.equipmentRulesText.Location = new System.Drawing.Point(299, 189);
            this.equipmentRulesText.Multiline = true;
            this.equipmentRulesText.Name = "equipmentRulesText";
            this.equipmentRulesText.Size = new System.Drawing.Size(156, 145);
            this.equipmentRulesText.TabIndex = 7;
            // 
            // itemCostLabel
            // 
            this.itemCostLabel.AutoSize = true;
            this.itemCostLabel.Location = new System.Drawing.Point(524, 120);
            this.itemCostLabel.Name = "itemCostLabel";
            this.itemCostLabel.Size = new System.Drawing.Size(81, 13);
            this.itemCostLabel.TabIndex = 8;
            this.itemCostLabel.Text = "Equipment Cost";
            // 
            // costSpinner
            // 
            this.costSpinner.Location = new System.Drawing.Point(612, 120);
            this.costSpinner.Name = "costSpinner";
            this.costSpinner.Size = new System.Drawing.Size(50, 20);
            this.costSpinner.TabIndex = 9;
            // 
            // iconUrlLabel
            // 
            this.iconUrlLabel.AutoSize = true;
            this.iconUrlLabel.Location = new System.Drawing.Point(527, 157);
            this.iconUrlLabel.Name = "iconUrlLabel";
            this.iconUrlLabel.Size = new System.Drawing.Size(106, 13);
            this.iconUrlLabel.TabIndex = 10;
            this.iconUrlLabel.Text = "Equipment Icon URL";
            // 
            // iconUrlText
            // 
            this.iconUrlText.Location = new System.Drawing.Point(475, 189);
            this.iconUrlText.Name = "iconUrlText";
            this.iconUrlText.Size = new System.Drawing.Size(313, 20);
            this.iconUrlText.TabIndex = 11;
            // 
            // insertNewButton
            // 
            this.insertNewButton.Location = new System.Drawing.Point(475, 248);
            this.insertNewButton.Name = "insertNewButton";
            this.insertNewButton.Size = new System.Drawing.Size(148, 23);
            this.insertNewButton.TabIndex = 12;
            this.insertNewButton.Text = "Save New Item";
            this.insertNewButton.UseVisualStyleBackColor = true;
            this.insertNewButton.Click += new System.EventHandler(this.insertNewButton_Click);
            // 
            // updateItemButton
            // 
            this.updateItemButton.Location = new System.Drawing.Point(475, 289);
            this.updateItemButton.Name = "updateItemButton";
            this.updateItemButton.Size = new System.Drawing.Size(148, 23);
            this.updateItemButton.TabIndex = 13;
            this.updateItemButton.Text = "Update Item";
            this.updateItemButton.UseVisualStyleBackColor = true;
            this.updateItemButton.Click += new System.EventHandler(this.updateItemButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(475, 337);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 90);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateItemButton);
            this.Controls.Add(this.insertNewButton);
            this.Controls.Add(this.iconUrlText);
            this.Controls.Add(this.iconUrlLabel);
            this.Controls.Add(this.costSpinner);
            this.Controls.Add(this.itemCostLabel);
            this.Controls.Add(this.equipmentRulesText);
            this.Controls.Add(this.equipmentTextLabel);
            this.Controls.Add(this.equipmentNameText);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.equipmentCombo);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.createNewButton);
            this.Name = "EditEquipment";
            this.Text = "Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.costSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNewButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.ComboBox equipmentCombo;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox equipmentNameText;
        private System.Windows.Forms.Label equipmentTextLabel;
        private System.Windows.Forms.TextBox equipmentRulesText;
        private System.Windows.Forms.Label itemCostLabel;
        private System.Windows.Forms.NumericUpDown costSpinner;
        private System.Windows.Forms.Label iconUrlLabel;
        private System.Windows.Forms.TextBox iconUrlText;
        private System.Windows.Forms.Button insertNewButton;
        private System.Windows.Forms.Button updateItemButton;
        private System.Windows.Forms.Button cancelButton;
    }
}