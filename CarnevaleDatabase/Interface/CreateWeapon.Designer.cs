namespace CarnevaleDatabase.Interface
{
    partial class CreateWeapon
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rangeCounter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.evasionCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.damageCounter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.penetrationCounter = new System.Windows.Forms.NumericUpDown();
            this.abilityBox = new System.Windows.Forms.ListBox();
            this.abilityCombo = new System.Windows.Forms.ComboBox();
            this.removeAbilityButton = new System.Windows.Forms.Button();
            this.addWeaponAbility = new System.Windows.Forms.Button();
            this.editAbilitiesPanel = new System.Windows.Forms.Panel();
            this.savNewAbilityButton = new System.Windows.Forms.Button();
            this.saveEditedAbilityButton = new System.Windows.Forms.Button();
            this.abilityTextBox = new System.Windows.Forms.TextBox();
            this.newAbilityButton = new System.Windows.Forms.Button();
            this.editAbilityButton = new System.Windows.Forms.Button();
            this.editAbilitiesListBox = new System.Windows.Forms.ListBox();
            this.editAbilitiesButton = new System.Windows.Forms.Button();
            this.saveWeaponButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rangeCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evasionCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penetrationCounter)).BeginInit();
            this.editAbilitiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapon Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(28, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Range";
            // 
            // rangeCounter
            // 
            this.rangeCounter.Location = new System.Drawing.Point(31, 130);
            this.rangeCounter.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.rangeCounter.Name = "rangeCounter";
            this.rangeCounter.Size = new System.Drawing.Size(36, 20);
            this.rangeCounter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Evasion";
            // 
            // evasionCounter
            // 
            this.evasionCounter.Location = new System.Drawing.Point(126, 130);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Damage";
            // 
            // damageCounter
            // 
            this.damageCounter.Location = new System.Drawing.Point(246, 129);
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Penetration";
            // 
            // penetrationCounter
            // 
            this.penetrationCounter.Location = new System.Drawing.Point(357, 130);
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
            // 
            // abilityBox
            // 
            this.abilityBox.FormattingEnabled = true;
            this.abilityBox.Location = new System.Drawing.Point(28, 192);
            this.abilityBox.Name = "abilityBox";
            this.abilityBox.Size = new System.Drawing.Size(120, 95);
            this.abilityBox.TabIndex = 10;
            // 
            // abilityCombo
            // 
            this.abilityCombo.FormattingEnabled = true;
            this.abilityCombo.Location = new System.Drawing.Point(178, 192);
            this.abilityCombo.Name = "abilityCombo";
            this.abilityCombo.Size = new System.Drawing.Size(121, 21);
            this.abilityCombo.TabIndex = 11;
            // 
            // removeAbilityButton
            // 
            this.removeAbilityButton.Location = new System.Drawing.Point(27, 302);
            this.removeAbilityButton.Name = "removeAbilityButton";
            this.removeAbilityButton.Size = new System.Drawing.Size(121, 23);
            this.removeAbilityButton.TabIndex = 12;
            this.removeAbilityButton.Text = "Remove Ability";
            this.removeAbilityButton.UseVisualStyleBackColor = true;
            this.removeAbilityButton.Click += new System.EventHandler(this.RemoveAbilityButton_Click);
            // 
            // addWeaponAbility
            // 
            this.addWeaponAbility.Location = new System.Drawing.Point(178, 230);
            this.addWeaponAbility.Name = "addWeaponAbility";
            this.addWeaponAbility.Size = new System.Drawing.Size(121, 23);
            this.addWeaponAbility.TabIndex = 13;
            this.addWeaponAbility.Text = "Add Ability";
            this.addWeaponAbility.UseVisualStyleBackColor = true;
            this.addWeaponAbility.Click += new System.EventHandler(this.addWeaponAbility_Click);
            // 
            // editAbilitiesPanel
            // 
            this.editAbilitiesPanel.Controls.Add(this.savNewAbilityButton);
            this.editAbilitiesPanel.Controls.Add(this.saveEditedAbilityButton);
            this.editAbilitiesPanel.Controls.Add(this.abilityTextBox);
            this.editAbilitiesPanel.Controls.Add(this.newAbilityButton);
            this.editAbilitiesPanel.Controls.Add(this.editAbilityButton);
            this.editAbilitiesPanel.Controls.Add(this.editAbilitiesListBox);
            this.editAbilitiesPanel.Location = new System.Drawing.Point(541, 87);
            this.editAbilitiesPanel.Name = "editAbilitiesPanel";
            this.editAbilitiesPanel.Size = new System.Drawing.Size(420, 385);
            this.editAbilitiesPanel.TabIndex = 14;
            // 
            // savNewAbilityButton
            // 
            this.savNewAbilityButton.Location = new System.Drawing.Point(296, 103);
            this.savNewAbilityButton.Name = "savNewAbilityButton";
            this.savNewAbilityButton.Size = new System.Drawing.Size(75, 23);
            this.savNewAbilityButton.TabIndex = 5;
            this.savNewAbilityButton.Text = "Save";
            this.savNewAbilityButton.UseVisualStyleBackColor = true;
            this.savNewAbilityButton.Click += new System.EventHandler(this.savNewAbilityButton_Click);
            // 
            // saveEditedAbilityButton
            // 
            this.saveEditedAbilityButton.Location = new System.Drawing.Point(175, 103);
            this.saveEditedAbilityButton.Name = "saveEditedAbilityButton";
            this.saveEditedAbilityButton.Size = new System.Drawing.Size(75, 23);
            this.saveEditedAbilityButton.TabIndex = 4;
            this.saveEditedAbilityButton.Text = "Save";
            this.saveEditedAbilityButton.UseVisualStyleBackColor = true;
            this.saveEditedAbilityButton.Click += new System.EventHandler(this.saveEditedAbilityButton_Click);
            // 
            // abilityTextBox
            // 
            this.abilityTextBox.Location = new System.Drawing.Point(175, 72);
            this.abilityTextBox.Name = "abilityTextBox";
            this.abilityTextBox.Size = new System.Drawing.Size(225, 20);
            this.abilityTextBox.TabIndex = 3;
            // 
            // newAbilityButton
            // 
            this.newAbilityButton.Location = new System.Drawing.Point(296, 26);
            this.newAbilityButton.Name = "newAbilityButton";
            this.newAbilityButton.Size = new System.Drawing.Size(104, 23);
            this.newAbilityButton.TabIndex = 2;
            this.newAbilityButton.Text = "Create New Ability";
            this.newAbilityButton.UseVisualStyleBackColor = true;
            this.newAbilityButton.Click += new System.EventHandler(this.newAbilityButton_Click);
            // 
            // editAbilityButton
            // 
            this.editAbilityButton.Location = new System.Drawing.Point(175, 26);
            this.editAbilityButton.Name = "editAbilityButton";
            this.editAbilityButton.Size = new System.Drawing.Size(75, 23);
            this.editAbilityButton.TabIndex = 1;
            this.editAbilityButton.Text = "Edit Ability";
            this.editAbilityButton.UseVisualStyleBackColor = true;
            this.editAbilityButton.Click += new System.EventHandler(this.editAbilityButton_Click);
            // 
            // editAbilitiesListBox
            // 
            this.editAbilitiesListBox.FormattingEnabled = true;
            this.editAbilitiesListBox.Location = new System.Drawing.Point(29, 26);
            this.editAbilitiesListBox.Name = "editAbilitiesListBox";
            this.editAbilitiesListBox.Size = new System.Drawing.Size(120, 316);
            this.editAbilitiesListBox.TabIndex = 0;
            // 
            // editAbilitiesButton
            // 
            this.editAbilitiesButton.Location = new System.Drawing.Point(178, 277);
            this.editAbilitiesButton.Name = "editAbilitiesButton";
            this.editAbilitiesButton.Size = new System.Drawing.Size(121, 92);
            this.editAbilitiesButton.TabIndex = 15;
            this.editAbilitiesButton.Text = "Edit Avaiailable Weapon Abilities";
            this.editAbilitiesButton.UseVisualStyleBackColor = true;
            this.editAbilitiesButton.Click += new System.EventHandler(this.editAbilitiesButton_Click);
            // 
            // saveWeaponButton
            // 
            this.saveWeaponButton.Location = new System.Drawing.Point(328, 190);
            this.saveWeaponButton.Name = "saveWeaponButton";
            this.saveWeaponButton.Size = new System.Drawing.Size(171, 179);
            this.saveWeaponButton.TabIndex = 16;
            this.saveWeaponButton.Text = "Save New Weapon";
            this.saveWeaponButton.UseVisualStyleBackColor = true;
            this.saveWeaponButton.Click += new System.EventHandler(this.SaveWeaponButton_Click);
            // 
            // CreateWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 639);
            this.Controls.Add(this.saveWeaponButton);
            this.Controls.Add(this.editAbilitiesButton);
            this.Controls.Add(this.editAbilitiesPanel);
            this.Controls.Add(this.addWeaponAbility);
            this.Controls.Add(this.removeAbilityButton);
            this.Controls.Add(this.abilityCombo);
            this.Controls.Add(this.abilityBox);
            this.Controls.Add(this.penetrationCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.damageCounter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.evasionCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rangeCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateWeapon";
            this.Text = "CreateWeapon";
            ((System.ComponentModel.ISupportInitialize)(this.rangeCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evasionCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penetrationCounter)).EndInit();
            this.editAbilitiesPanel.ResumeLayout(false);
            this.editAbilitiesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rangeCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown evasionCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown damageCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown penetrationCounter;
        private System.Windows.Forms.ListBox abilityBox;
        private System.Windows.Forms.ComboBox abilityCombo;
        private System.Windows.Forms.Button removeAbilityButton;
        private System.Windows.Forms.Button addWeaponAbility;
        private System.Windows.Forms.Panel editAbilitiesPanel;
        private System.Windows.Forms.Button savNewAbilityButton;
        private System.Windows.Forms.Button saveEditedAbilityButton;
        private System.Windows.Forms.TextBox abilityTextBox;
        private System.Windows.Forms.Button newAbilityButton;
        private System.Windows.Forms.Button editAbilityButton;
        private System.Windows.Forms.ListBox editAbilitiesListBox;
        private System.Windows.Forms.Button editAbilitiesButton;
        private System.Windows.Forms.Button saveWeaponButton;
    }
}