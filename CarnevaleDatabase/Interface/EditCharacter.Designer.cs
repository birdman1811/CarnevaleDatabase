namespace CarnevaleDatabase.Interface
{
    partial class EditCharacter
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
            this.selectFactionToEditLabel = new System.Windows.Forms.Label();
            this.factionToEditCombo = new System.Windows.Forms.ComboBox();
            this.selectFactionToEditButton = new System.Windows.Forms.Button();
            this.selectCharLabel = new System.Windows.Forms.Label();
            this.selectCharCombo = new System.Windows.Forms.ComboBox();
            this.selectCharButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFactionToEditLabel
            // 
            this.selectFactionToEditLabel.AutoSize = true;
            this.selectFactionToEditLabel.Location = new System.Drawing.Point(13, 13);
            this.selectFactionToEditLabel.Name = "selectFactionToEditLabel";
            this.selectFactionToEditLabel.Size = new System.Drawing.Size(75, 13);
            this.selectFactionToEditLabel.TabIndex = 0;
            this.selectFactionToEditLabel.Text = "Select Faction";
            // 
            // factionToEditCombo
            // 
            this.factionToEditCombo.FormattingEnabled = true;
            this.factionToEditCombo.Location = new System.Drawing.Point(16, 30);
            this.factionToEditCombo.Name = "factionToEditCombo";
            this.factionToEditCombo.Size = new System.Drawing.Size(121, 21);
            this.factionToEditCombo.TabIndex = 1;
            // 
            // selectFactionToEditButton
            // 
            this.selectFactionToEditButton.Location = new System.Drawing.Point(16, 58);
            this.selectFactionToEditButton.Name = "selectFactionToEditButton";
            this.selectFactionToEditButton.Size = new System.Drawing.Size(75, 23);
            this.selectFactionToEditButton.TabIndex = 2;
            this.selectFactionToEditButton.Text = "Select";
            this.selectFactionToEditButton.UseVisualStyleBackColor = true;
            this.selectFactionToEditButton.Click += new System.EventHandler(this.selectFactionToEditButton_Click);
            // 
            // selectCharLabel
            // 
            this.selectCharLabel.AutoSize = true;
            this.selectCharLabel.Location = new System.Drawing.Point(16, 100);
            this.selectCharLabel.Name = "selectCharLabel";
            this.selectCharLabel.Size = new System.Drawing.Size(86, 13);
            this.selectCharLabel.TabIndex = 3;
            this.selectCharLabel.Text = "Select Character";
            // 
            // selectCharCombo
            // 
            this.selectCharCombo.FormattingEnabled = true;
            this.selectCharCombo.Location = new System.Drawing.Point(19, 117);
            this.selectCharCombo.Name = "selectCharCombo";
            this.selectCharCombo.Size = new System.Drawing.Size(121, 21);
            this.selectCharCombo.TabIndex = 4;
            // 
            // selectCharButton
            // 
            this.selectCharButton.Location = new System.Drawing.Point(19, 145);
            this.selectCharButton.Name = "selectCharButton";
            this.selectCharButton.Size = new System.Drawing.Size(75, 23);
            this.selectCharButton.TabIndex = 5;
            this.selectCharButton.Text = "Select Character";
            this.selectCharButton.UseVisualStyleBackColor = true;
            this.selectCharButton.Click += new System.EventHandler(this.selectCharButton_Click);
            // 
            // EditCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 642);
            this.Controls.Add(this.selectCharButton);
            this.Controls.Add(this.selectCharCombo);
            this.Controls.Add(this.selectCharLabel);
            this.Controls.Add(this.selectFactionToEditButton);
            this.Controls.Add(this.factionToEditCombo);
            this.Controls.Add(this.selectFactionToEditLabel);
            this.Name = "EditCharacter";
            this.Text = "EditCharacter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectFactionToEditLabel;
        private System.Windows.Forms.ComboBox factionToEditCombo;
        private System.Windows.Forms.Button selectFactionToEditButton;
        private System.Windows.Forms.Label selectCharLabel;
        private System.Windows.Forms.ComboBox selectCharCombo;
        private System.Windows.Forms.Button selectCharButton;
    }
}