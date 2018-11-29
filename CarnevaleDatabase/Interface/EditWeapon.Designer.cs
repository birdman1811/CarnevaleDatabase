namespace CarnevaleDatabase.Interface
{
    partial class EditWeapon
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
            this.weaponCombo = new System.Windows.Forms.ComboBox();
            this.editWeaponPanel = new System.Windows.Forms.Panel();
            this.rangeCounter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectWeaponButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.evasionCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.damageCounter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.penetrationCounter = new System.Windows.Forms.NumericUpDown();
            this.abilitiesListBox = new System.Windows.Forms.ListBox();
            this.abilitiesCombo = new System.Windows.Forms.ComboBox();
            this.deleteAbilityButton = new System.Windows.Forms.Button();
            this.addAbilityButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.editWeaponPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evasionCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penetrationCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // weaponCombo
            // 
            this.weaponCombo.FormattingEnabled = true;
            this.weaponCombo.Location = new System.Drawing.Point(12, 22);
            this.weaponCombo.Name = "weaponCombo";
            this.weaponCombo.Size = new System.Drawing.Size(121, 21);
            this.weaponCombo.TabIndex = 0;
            // 
            // editWeaponPanel
            // 
            this.editWeaponPanel.Controls.Add(this.saveButton);
            this.editWeaponPanel.Controls.Add(this.addAbilityButton);
            this.editWeaponPanel.Controls.Add(this.deleteAbilityButton);
            this.editWeaponPanel.Controls.Add(this.abilitiesCombo);
            this.editWeaponPanel.Controls.Add(this.abilitiesListBox);
            this.editWeaponPanel.Controls.Add(this.penetrationCounter);
            this.editWeaponPanel.Controls.Add(this.label5);
            this.editWeaponPanel.Controls.Add(this.damageCounter);
            this.editWeaponPanel.Controls.Add(this.label4);
            this.editWeaponPanel.Controls.Add(this.evasionCounter);
            this.editWeaponPanel.Controls.Add(this.label3);
            this.editWeaponPanel.Controls.Add(this.rangeCounter);
            this.editWeaponPanel.Controls.Add(this.label2);
            this.editWeaponPanel.Controls.Add(this.nameText);
            this.editWeaponPanel.Controls.Add(this.label1);
            this.editWeaponPanel.Location = new System.Drawing.Point(163, 25);
            this.editWeaponPanel.Name = "editWeaponPanel";
            this.editWeaponPanel.Size = new System.Drawing.Size(590, 403);
            this.editWeaponPanel.TabIndex = 1;
            // 
            // rangeCounter
            // 
            this.rangeCounter.Location = new System.Drawing.Point(34, 103);
            this.rangeCounter.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.rangeCounter.Name = "rangeCounter";
            this.rangeCounter.Size = new System.Drawing.Size(51, 20);
            this.rangeCounter.TabIndex = 3;
            this.rangeCounter.ValueChanged += new System.EventHandler(this.rangeCounter_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(26, 37);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(155, 20);
            this.nameText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapon Name";
            // 
            // selectWeaponButton
            // 
            this.selectWeaponButton.Location = new System.Drawing.Point(12, 60);
            this.selectWeaponButton.Name = "selectWeaponButton";
            this.selectWeaponButton.Size = new System.Drawing.Size(75, 23);
            this.selectWeaponButton.TabIndex = 2;
            this.selectWeaponButton.Text = "Select";
            this.selectWeaponButton.UseVisualStyleBackColor = true;
            this.selectWeaponButton.Click += new System.EventHandler(this.selectWeaponButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Evasion";
            // 
            // evasionCounter
            // 
            this.evasionCounter.Location = new System.Drawing.Point(149, 103);
            this.evasionCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.evasionCounter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.evasionCounter.Name = "evasionCounter";
            this.evasionCounter.Size = new System.Drawing.Size(42, 20);
            this.evasionCounter.TabIndex = 5;
            this.evasionCounter.ValueChanged += new System.EventHandler(this.evasionCounter_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Damage";
            // 
            // damageCounter
            // 
            this.damageCounter.Location = new System.Drawing.Point(262, 102);
            this.damageCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.damageCounter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.damageCounter.Name = "damageCounter";
            this.damageCounter.Size = new System.Drawing.Size(44, 20);
            this.damageCounter.TabIndex = 7;
            this.damageCounter.ValueChanged += new System.EventHandler(this.damageCounter_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Penetration";
            // 
            // penetrationCounter
            // 
            this.penetrationCounter.Location = new System.Drawing.Point(387, 102);
            this.penetrationCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.penetrationCounter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.penetrationCounter.Name = "penetrationCounter";
            this.penetrationCounter.Size = new System.Drawing.Size(46, 20);
            this.penetrationCounter.TabIndex = 9;
            this.penetrationCounter.ValueChanged += new System.EventHandler(this.penetrationCounter_ValueChanged);
            // 
            // abilitiesListBox
            // 
            this.abilitiesListBox.FormattingEnabled = true;
            this.abilitiesListBox.Location = new System.Drawing.Point(34, 157);
            this.abilitiesListBox.Name = "abilitiesListBox";
            this.abilitiesListBox.Size = new System.Drawing.Size(120, 95);
            this.abilitiesListBox.TabIndex = 10;
            // 
            // abilitiesCombo
            // 
            this.abilitiesCombo.FormattingEnabled = true;
            this.abilitiesCombo.Location = new System.Drawing.Point(214, 157);
            this.abilitiesCombo.Name = "abilitiesCombo";
            this.abilitiesCombo.Size = new System.Drawing.Size(121, 21);
            this.abilitiesCombo.TabIndex = 11;
            // 
            // deleteAbilityButton
            // 
            this.deleteAbilityButton.Location = new System.Drawing.Point(34, 258);
            this.deleteAbilityButton.Name = "deleteAbilityButton";
            this.deleteAbilityButton.Size = new System.Drawing.Size(120, 23);
            this.deleteAbilityButton.TabIndex = 12;
            this.deleteAbilityButton.Text = "Remove Ability";
            this.deleteAbilityButton.UseVisualStyleBackColor = true;
            this.deleteAbilityButton.Click += new System.EventHandler(this.deleteAbilityButton_Click);
            // 
            // addAbilityButton
            // 
            this.addAbilityButton.Location = new System.Drawing.Point(214, 184);
            this.addAbilityButton.Name = "addAbilityButton";
            this.addAbilityButton.Size = new System.Drawing.Size(121, 23);
            this.addAbilityButton.TabIndex = 13;
            this.addAbilityButton.Text = "Add Ability";
            this.addAbilityButton.UseVisualStyleBackColor = true;
            this.addAbilityButton.Click += new System.EventHandler(this.addAbilityButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(304, 275);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(197, 101);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save Weapon";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // EditWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectWeaponButton);
            this.Controls.Add(this.editWeaponPanel);
            this.Controls.Add(this.weaponCombo);
            this.Name = "EditWeapon";
            this.Text = "EditWeapon";
            this.editWeaponPanel.ResumeLayout(false);
            this.editWeaponPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evasionCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penetrationCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox weaponCombo;
        private System.Windows.Forms.Panel editWeaponPanel;
        private System.Windows.Forms.Button selectWeaponButton;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rangeCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown evasionCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown damageCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown penetrationCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addAbilityButton;
        private System.Windows.Forms.Button deleteAbilityButton;
        private System.Windows.Forms.ComboBox abilitiesCombo;
        private System.Windows.Forms.ListBox abilitiesListBox;
        private System.Windows.Forms.Button saveButton;
    }
}