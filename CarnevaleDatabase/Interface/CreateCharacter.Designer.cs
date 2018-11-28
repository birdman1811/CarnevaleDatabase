namespace CarnevaleDatabase.Interface
{
    partial class CreateCharacter
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baseSizeCounter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.movementCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dexterityCounter = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.attackCounter = new System.Windows.Forms.NumericUpDown();
            this.protLabel = new System.Windows.Forms.Label();
            this.protectionCounter = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.mindCounter = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.actionCounter = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lifeCounter = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.willCounter = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.commandCounter = new System.Windows.Forms.NumericUpDown();
            this.ducatsLabel = new System.Windows.Forms.Label();
            this.ducatsCounter = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.charTypeCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uniqueCheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.factionCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.imageText = new System.Windows.Forms.TextBox();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.saveCharacterButton = new System.Windows.Forms.Button();
            this.saveNewRule = new System.Windows.Forms.Button();
            this.saveEditedRule = new System.Windows.Forms.Button();
            this.uniqueRuleTextBox = new System.Windows.Forms.TextBox();
            this.addUniqueRuleButton = new System.Windows.Forms.Button();
            this.editUniqueRuleButton = new System.Windows.Forms.Button();
            this.deleteUniqueRuleButton = new System.Windows.Forms.Button();
            this.uniqueRuleBox = new System.Windows.Forms.ListBox();
            this.addWeaponButton = new System.Windows.Forms.Button();
            this.weaponCombo = new System.Windows.Forms.ComboBox();
            this.deleteWeaponButton = new System.Windows.Forms.Button();
            this.weaponsListBox = new System.Windows.Forms.ListBox();
            this.addSpecRuleButton = new System.Windows.Forms.Button();
            this.changeAmountButton = new System.Windows.Forms.Button();
            this.specRuleAmountCounter = new System.Windows.Forms.NumericUpDown();
            this.specRuleCombo = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.specRulesListBox = new System.Windows.Forms.ListBox();
            this.addKeyWordButton = new System.Windows.Forms.Button();
            this.keyWordCombo = new System.Windows.Forms.ComboBox();
            this.deleteKeyWordButton = new System.Windows.Forms.Button();
            this.keyWordsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.baseSizeCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protectionCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mindCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.willCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducatsCounter)).BeginInit();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specRuleAmountCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(74, 10);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(178, 20);
            this.nameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base Size";
            // 
            // baseSizeCounter
            // 
            this.baseSizeCounter.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.baseSizeCounter.Location = new System.Drawing.Point(93, 38);
            this.baseSizeCounter.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.baseSizeCounter.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.baseSizeCounter.Name = "baseSizeCounter";
            this.baseSizeCounter.Size = new System.Drawing.Size(51, 20);
            this.baseSizeCounter.TabIndex = 3;
            this.baseSizeCounter.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movement";
            // 
            // movementCounter
            // 
            this.movementCounter.Location = new System.Drawing.Point(93, 65);
            this.movementCounter.Name = "movementCounter";
            this.movementCounter.Size = new System.Drawing.Size(51, 20);
            this.movementCounter.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dexterity";
            // 
            // dexterityCounter
            // 
            this.dexterityCounter.Location = new System.Drawing.Point(93, 94);
            this.dexterityCounter.Name = "dexterityCounter";
            this.dexterityCounter.Size = new System.Drawing.Size(51, 20);
            this.dexterityCounter.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Attack";
            // 
            // attackCounter
            // 
            this.attackCounter.Location = new System.Drawing.Point(93, 120);
            this.attackCounter.Name = "attackCounter";
            this.attackCounter.Size = new System.Drawing.Size(51, 20);
            this.attackCounter.TabIndex = 9;
            // 
            // protLabel
            // 
            this.protLabel.AutoSize = true;
            this.protLabel.Location = new System.Drawing.Point(5, 148);
            this.protLabel.Name = "protLabel";
            this.protLabel.Size = new System.Drawing.Size(55, 13);
            this.protLabel.TabIndex = 10;
            this.protLabel.Text = "Protection";
            // 
            // protectionCounter
            // 
            this.protectionCounter.Location = new System.Drawing.Point(93, 146);
            this.protectionCounter.Name = "protectionCounter";
            this.protectionCounter.Size = new System.Drawing.Size(51, 20);
            this.protectionCounter.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mind";
            // 
            // mindCounter
            // 
            this.mindCounter.Location = new System.Drawing.Point(93, 172);
            this.mindCounter.Name = "mindCounter";
            this.mindCounter.Size = new System.Drawing.Size(51, 20);
            this.mindCounter.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Action";
            // 
            // actionCounter
            // 
            this.actionCounter.Location = new System.Drawing.Point(93, 202);
            this.actionCounter.Name = "actionCounter";
            this.actionCounter.Size = new System.Drawing.Size(51, 20);
            this.actionCounter.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Life";
            // 
            // lifeCounter
            // 
            this.lifeCounter.Location = new System.Drawing.Point(93, 227);
            this.lifeCounter.Name = "lifeCounter";
            this.lifeCounter.Size = new System.Drawing.Size(51, 20);
            this.lifeCounter.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Will";
            // 
            // willCounter
            // 
            this.willCounter.Location = new System.Drawing.Point(93, 254);
            this.willCounter.Name = "willCounter";
            this.willCounter.Size = new System.Drawing.Size(51, 20);
            this.willCounter.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Command";
            // 
            // commandCounter
            // 
            this.commandCounter.Location = new System.Drawing.Point(93, 286);
            this.commandCounter.Name = "commandCounter";
            this.commandCounter.Size = new System.Drawing.Size(51, 20);
            this.commandCounter.TabIndex = 21;
            // 
            // ducatsLabel
            // 
            this.ducatsLabel.AutoSize = true;
            this.ducatsLabel.Location = new System.Drawing.Point(8, 320);
            this.ducatsLabel.Name = "ducatsLabel";
            this.ducatsLabel.Size = new System.Drawing.Size(41, 13);
            this.ducatsLabel.TabIndex = 22;
            this.ducatsLabel.Text = "Ducats";
            // 
            // ducatsCounter
            // 
            this.ducatsCounter.Location = new System.Drawing.Point(93, 318);
            this.ducatsCounter.Name = "ducatsCounter";
            this.ducatsCounter.Size = new System.Drawing.Size(51, 20);
            this.ducatsCounter.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Character Type";
            // 
            // charTypeCombo
            // 
            this.charTypeCombo.FormattingEnabled = true;
            this.charTypeCombo.Items.AddRange(new object[] {
            "Leader",
            "Hero",
            "Henchman"});
            this.charTypeCombo.Location = new System.Drawing.Point(93, 345);
            this.charTypeCombo.Name = "charTypeCombo";
            this.charTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.charTypeCombo.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 384);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Unique?";
            // 
            // uniqueCheckBox
            // 
            this.uniqueCheckBox.AutoSize = true;
            this.uniqueCheckBox.Location = new System.Drawing.Point(93, 384);
            this.uniqueCheckBox.Name = "uniqueCheckBox";
            this.uniqueCheckBox.Size = new System.Drawing.Size(71, 17);
            this.uniqueCheckBox.TabIndex = 27;
            this.uniqueCheckBox.Text = "Is Unique";
            this.uniqueCheckBox.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 416);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Faction";
            // 
            // factionCombo
            // 
            this.factionCombo.FormattingEnabled = true;
            this.factionCombo.Location = new System.Drawing.Point(93, 413);
            this.factionCombo.Name = "factionCombo";
            this.factionCombo.Size = new System.Drawing.Size(121, 21);
            this.factionCombo.TabIndex = 29;
            this.factionCombo.DataSourceChanged += new System.EventHandler(this.FactionCombo_DataSourceChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 458);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Image URL";
            // 
            // imageText
            // 
            this.imageText.Location = new System.Drawing.Point(93, 451);
            this.imageText.Name = "imageText";
            this.imageText.Size = new System.Drawing.Size(267, 20);
            this.imageText.TabIndex = 31;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.saveCharacterButton);
            this.EditPanel.Controls.Add(this.saveNewRule);
            this.EditPanel.Controls.Add(this.saveEditedRule);
            this.EditPanel.Controls.Add(this.uniqueRuleTextBox);
            this.EditPanel.Controls.Add(this.addUniqueRuleButton);
            this.EditPanel.Controls.Add(this.editUniqueRuleButton);
            this.EditPanel.Controls.Add(this.deleteUniqueRuleButton);
            this.EditPanel.Controls.Add(this.uniqueRuleBox);
            this.EditPanel.Controls.Add(this.addWeaponButton);
            this.EditPanel.Controls.Add(this.weaponCombo);
            this.EditPanel.Controls.Add(this.deleteWeaponButton);
            this.EditPanel.Controls.Add(this.weaponsListBox);
            this.EditPanel.Controls.Add(this.addSpecRuleButton);
            this.EditPanel.Controls.Add(this.changeAmountButton);
            this.EditPanel.Controls.Add(this.specRuleAmountCounter);
            this.EditPanel.Controls.Add(this.specRuleCombo);
            this.EditPanel.Controls.Add(this.deleteButton);
            this.EditPanel.Controls.Add(this.specRulesListBox);
            this.EditPanel.Controls.Add(this.addKeyWordButton);
            this.EditPanel.Controls.Add(this.keyWordCombo);
            this.EditPanel.Controls.Add(this.deleteKeyWordButton);
            this.EditPanel.Controls.Add(this.keyWordsListBox);
            this.EditPanel.Controls.Add(this.imageText);
            this.EditPanel.Controls.Add(this.label11);
            this.EditPanel.Controls.Add(this.label14);
            this.EditPanel.Controls.Add(this.factionCombo);
            this.EditPanel.Controls.Add(this.label13);
            this.EditPanel.Controls.Add(this.uniqueCheckBox);
            this.EditPanel.Controls.Add(this.label12);
            this.EditPanel.Controls.Add(this.charTypeCombo);
            this.EditPanel.Controls.Add(this.ducatsCounter);
            this.EditPanel.Controls.Add(this.ducatsLabel);
            this.EditPanel.Controls.Add(this.commandCounter);
            this.EditPanel.Controls.Add(this.label10);
            this.EditPanel.Controls.Add(this.willCounter);
            this.EditPanel.Controls.Add(this.label9);
            this.EditPanel.Controls.Add(this.lifeCounter);
            this.EditPanel.Controls.Add(this.label8);
            this.EditPanel.Controls.Add(this.actionCounter);
            this.EditPanel.Controls.Add(this.label7);
            this.EditPanel.Controls.Add(this.mindCounter);
            this.EditPanel.Controls.Add(this.label6);
            this.EditPanel.Controls.Add(this.protectionCounter);
            this.EditPanel.Controls.Add(this.protLabel);
            this.EditPanel.Controls.Add(this.attackCounter);
            this.EditPanel.Controls.Add(this.label5);
            this.EditPanel.Controls.Add(this.dexterityCounter);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.movementCounter);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.baseSizeCounter);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.nameText);
            this.EditPanel.Controls.Add(this.label1);
            this.EditPanel.Location = new System.Drawing.Point(12, 2);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1074, 630);
            this.EditPanel.TabIndex = 32;
            // 
            // saveCharacterButton
            // 
            this.saveCharacterButton.Location = new System.Drawing.Point(24, 485);
            this.saveCharacterButton.Name = "saveCharacterButton";
            this.saveCharacterButton.Size = new System.Drawing.Size(336, 132);
            this.saveCharacterButton.TabIndex = 53;
            this.saveCharacterButton.Text = "Save New Character and Reset";
            this.saveCharacterButton.UseVisualStyleBackColor = true;
            this.saveCharacterButton.Click += new System.EventHandler(this.SaveCharacterButton_Click);
            // 
            // saveNewRule
            // 
            this.saveNewRule.Location = new System.Drawing.Point(621, 514);
            this.saveNewRule.Name = "saveNewRule";
            this.saveNewRule.Size = new System.Drawing.Size(127, 23);
            this.saveNewRule.TabIndex = 52;
            this.saveNewRule.Text = "Save Rule";
            this.saveNewRule.UseVisualStyleBackColor = true;
            this.saveNewRule.Click += new System.EventHandler(this.SaveNewRule_Click);
            // 
            // saveEditedRule
            // 
            this.saveEditedRule.Location = new System.Drawing.Point(488, 514);
            this.saveEditedRule.Name = "saveEditedRule";
            this.saveEditedRule.Size = new System.Drawing.Size(127, 23);
            this.saveEditedRule.TabIndex = 51;
            this.saveEditedRule.Text = "Save Rule";
            this.saveEditedRule.UseVisualStyleBackColor = true;
            this.saveEditedRule.Click += new System.EventHandler(this.SaveEditedRule_Click);
            // 
            // uniqueRuleTextBox
            // 
            this.uniqueRuleTextBox.Location = new System.Drawing.Point(398, 451);
            this.uniqueRuleTextBox.Multiline = true;
            this.uniqueRuleTextBox.Name = "uniqueRuleTextBox";
            this.uniqueRuleTextBox.Size = new System.Drawing.Size(637, 57);
            this.uniqueRuleTextBox.TabIndex = 50;
            // 
            // addUniqueRuleButton
            // 
            this.addUniqueRuleButton.Location = new System.Drawing.Point(823, 406);
            this.addUniqueRuleButton.Name = "addUniqueRuleButton";
            this.addUniqueRuleButton.Size = new System.Drawing.Size(132, 23);
            this.addUniqueRuleButton.TabIndex = 49;
            this.addUniqueRuleButton.Text = "Add New Rule";
            this.addUniqueRuleButton.UseVisualStyleBackColor = true;
            this.addUniqueRuleButton.Click += new System.EventHandler(this.AddUniqueRuleButton_Click);
            // 
            // editUniqueRuleButton
            // 
            this.editUniqueRuleButton.Location = new System.Drawing.Point(629, 406);
            this.editUniqueRuleButton.Name = "editUniqueRuleButton";
            this.editUniqueRuleButton.Size = new System.Drawing.Size(132, 23);
            this.editUniqueRuleButton.TabIndex = 48;
            this.editUniqueRuleButton.Text = "Edit Rule";
            this.editUniqueRuleButton.UseVisualStyleBackColor = true;
            this.editUniqueRuleButton.Click += new System.EventHandler(this.EditUniqueRuleButton_Click);
            // 
            // deleteUniqueRuleButton
            // 
            this.deleteUniqueRuleButton.Location = new System.Drawing.Point(398, 406);
            this.deleteUniqueRuleButton.Name = "deleteUniqueRuleButton";
            this.deleteUniqueRuleButton.Size = new System.Drawing.Size(132, 23);
            this.deleteUniqueRuleButton.TabIndex = 47;
            this.deleteUniqueRuleButton.Text = "Delete Rule";
            this.deleteUniqueRuleButton.UseVisualStyleBackColor = true;
            this.deleteUniqueRuleButton.Click += new System.EventHandler(this.DeleteUniqueRuleButton_Click);
            // 
            // uniqueRuleBox
            // 
            this.uniqueRuleBox.FormattingEnabled = true;
            this.uniqueRuleBox.Location = new System.Drawing.Point(398, 271);
            this.uniqueRuleBox.Name = "uniqueRuleBox";
            this.uniqueRuleBox.Size = new System.Drawing.Size(637, 121);
            this.uniqueRuleBox.TabIndex = 46;
            // 
            // addWeaponButton
            // 
            this.addWeaponButton.Location = new System.Drawing.Point(746, 177);
            this.addWeaponButton.Name = "addWeaponButton";
            this.addWeaponButton.Size = new System.Drawing.Size(121, 23);
            this.addWeaponButton.TabIndex = 45;
            this.addWeaponButton.Text = "Add Weapon";
            this.addWeaponButton.UseVisualStyleBackColor = true;
            this.addWeaponButton.Click += new System.EventHandler(this.AddWeaponButton_Click);
            // 
            // weaponCombo
            // 
            this.weaponCombo.FormattingEnabled = true;
            this.weaponCombo.Location = new System.Drawing.Point(746, 149);
            this.weaponCombo.Name = "weaponCombo";
            this.weaponCombo.Size = new System.Drawing.Size(121, 21);
            this.weaponCombo.TabIndex = 44;
            // 
            // deleteWeaponButton
            // 
            this.deleteWeaponButton.Location = new System.Drawing.Point(746, 118);
            this.deleteWeaponButton.Name = "deleteWeaponButton";
            this.deleteWeaponButton.Size = new System.Drawing.Size(120, 23);
            this.deleteWeaponButton.TabIndex = 43;
            this.deleteWeaponButton.Text = "Delete Weapon";
            this.deleteWeaponButton.UseVisualStyleBackColor = true;
            this.deleteWeaponButton.Click += new System.EventHandler(this.DeleteWeaponButton_Click);
            // 
            // weaponsListBox
            // 
            this.weaponsListBox.FormattingEnabled = true;
            this.weaponsListBox.Location = new System.Drawing.Point(746, 17);
            this.weaponsListBox.Name = "weaponsListBox";
            this.weaponsListBox.Size = new System.Drawing.Size(120, 95);
            this.weaponsListBox.TabIndex = 42;
            // 
            // addSpecRuleButton
            // 
            this.addSpecRuleButton.Location = new System.Drawing.Point(541, 229);
            this.addSpecRuleButton.Name = "addSpecRuleButton";
            this.addSpecRuleButton.Size = new System.Drawing.Size(121, 23);
            this.addSpecRuleButton.TabIndex = 41;
            this.addSpecRuleButton.Text = "Add Special Rule";
            this.addSpecRuleButton.UseVisualStyleBackColor = true;
            this.addSpecRuleButton.Click += new System.EventHandler(this.AddSpecRuleButton_Click);
            // 
            // changeAmountButton
            // 
            this.changeAmountButton.Location = new System.Drawing.Point(542, 147);
            this.changeAmountButton.Name = "changeAmountButton";
            this.changeAmountButton.Size = new System.Drawing.Size(119, 23);
            this.changeAmountButton.TabIndex = 40;
            this.changeAmountButton.Text = "Change Amount";
            this.changeAmountButton.UseVisualStyleBackColor = true;
            this.changeAmountButton.Click += new System.EventHandler(this.ChangeAmountButton_Click);
            // 
            // specRuleAmountCounter
            // 
            this.specRuleAmountCounter.Location = new System.Drawing.Point(542, 177);
            this.specRuleAmountCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.specRuleAmountCounter.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.specRuleAmountCounter.Name = "specRuleAmountCounter";
            this.specRuleAmountCounter.Size = new System.Drawing.Size(120, 20);
            this.specRuleAmountCounter.TabIndex = 39;
            // 
            // specRuleCombo
            // 
            this.specRuleCombo.FormattingEnabled = true;
            this.specRuleCombo.Location = new System.Drawing.Point(541, 201);
            this.specRuleCombo.Name = "specRuleCombo";
            this.specRuleCombo.Size = new System.Drawing.Size(121, 21);
            this.specRuleCombo.TabIndex = 38;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(541, 118);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(120, 23);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "Delete Special Rule";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // specRulesListBox
            // 
            this.specRulesListBox.FormattingEnabled = true;
            this.specRulesListBox.Location = new System.Drawing.Point(541, 17);
            this.specRulesListBox.Name = "specRulesListBox";
            this.specRulesListBox.Size = new System.Drawing.Size(120, 95);
            this.specRulesListBox.TabIndex = 36;
            // 
            // addKeyWordButton
            // 
            this.addKeyWordButton.Location = new System.Drawing.Point(340, 174);
            this.addKeyWordButton.Name = "addKeyWordButton";
            this.addKeyWordButton.Size = new System.Drawing.Size(121, 23);
            this.addKeyWordButton.TabIndex = 35;
            this.addKeyWordButton.Text = "Add Key Word";
            this.addKeyWordButton.UseVisualStyleBackColor = true;
            this.addKeyWordButton.Click += new System.EventHandler(this.AddKeyWordButton_Click);
            // 
            // keyWordCombo
            // 
            this.keyWordCombo.FormattingEnabled = true;
            this.keyWordCombo.Location = new System.Drawing.Point(340, 146);
            this.keyWordCombo.Name = "keyWordCombo";
            this.keyWordCombo.Size = new System.Drawing.Size(121, 21);
            this.keyWordCombo.TabIndex = 34;
            // 
            // deleteKeyWordButton
            // 
            this.deleteKeyWordButton.Location = new System.Drawing.Point(340, 117);
            this.deleteKeyWordButton.Name = "deleteKeyWordButton";
            this.deleteKeyWordButton.Size = new System.Drawing.Size(120, 23);
            this.deleteKeyWordButton.TabIndex = 33;
            this.deleteKeyWordButton.Text = "Delete Key Word";
            this.deleteKeyWordButton.UseVisualStyleBackColor = true;
            this.deleteKeyWordButton.Click += new System.EventHandler(this.DeleteKeyWordButton_Click);
            // 
            // keyWordsListBox
            // 
            this.keyWordsListBox.FormattingEnabled = true;
            this.keyWordsListBox.Location = new System.Drawing.Point(340, 17);
            this.keyWordsListBox.Name = "keyWordsListBox";
            this.keyWordsListBox.Size = new System.Drawing.Size(120, 95);
            this.keyWordsListBox.TabIndex = 32;
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 644);
            this.Controls.Add(this.EditPanel);
            this.Name = "CreateCharacter";
            this.Text = "CreateCharacter";
            ((System.ComponentModel.ISupportInitialize)(this.baseSizeCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protectionCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mindCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.willCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ducatsCounter)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specRuleAmountCounter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown baseSizeCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown movementCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown dexterityCounter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown attackCounter;
        private System.Windows.Forms.Label protLabel;
        private System.Windows.Forms.NumericUpDown protectionCounter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown mindCounter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown actionCounter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown lifeCounter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown willCounter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown commandCounter;
        private System.Windows.Forms.Label ducatsLabel;
        private System.Windows.Forms.NumericUpDown ducatsCounter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox charTypeCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox uniqueCheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox factionCombo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox imageText;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button addKeyWordButton;
        private System.Windows.Forms.ComboBox keyWordCombo;
        private System.Windows.Forms.Button deleteKeyWordButton;
        private System.Windows.Forms.ListBox keyWordsListBox;
        private System.Windows.Forms.ListBox specRulesListBox;
        private System.Windows.Forms.Button addSpecRuleButton;
        private System.Windows.Forms.Button changeAmountButton;
        private System.Windows.Forms.NumericUpDown specRuleAmountCounter;
        private System.Windows.Forms.ComboBox specRuleCombo;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteWeaponButton;
        private System.Windows.Forms.ListBox weaponsListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox weaponCombo;
        private System.Windows.Forms.Button addWeaponButton;
        private System.Windows.Forms.Button saveNewRule;
        private System.Windows.Forms.Button saveEditedRule;
        private System.Windows.Forms.TextBox uniqueRuleTextBox;
        private System.Windows.Forms.Button addUniqueRuleButton;
        private System.Windows.Forms.Button editUniqueRuleButton;
        private System.Windows.Forms.Button deleteUniqueRuleButton;
        private System.Windows.Forms.ListBox uniqueRuleBox;
        private System.Windows.Forms.Button saveCharacterButton;
    }
}