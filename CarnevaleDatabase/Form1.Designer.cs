namespace CarnevaleDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.createCharacter = new System.Windows.Forms.Button();
            this.editCharacter = new System.Windows.Forms.Button();
            this.createWeapon = new System.Windows.Forms.Button();
            this.editWeapon = new System.Windows.Forms.Button();
            this.keyWords = new System.Windows.Forms.Button();
            this.specialRules = new System.Windows.Forms.Button();
            this.createFaction = new System.Windows.Forms.Button();
            this.editFaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Buckingham", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnevale Database Editor";
            // 
            // createCharacter
            // 
            this.createCharacter.Location = new System.Drawing.Point(84, 110);
            this.createCharacter.Name = "createCharacter";
            this.createCharacter.Size = new System.Drawing.Size(159, 54);
            this.createCharacter.TabIndex = 1;
            this.createCharacter.Text = "Create Character";
            this.createCharacter.UseVisualStyleBackColor = true;
            // 
            // editCharacter
            // 
            this.editCharacter.Location = new System.Drawing.Point(84, 185);
            this.editCharacter.Name = "editCharacter";
            this.editCharacter.Size = new System.Drawing.Size(159, 54);
            this.editCharacter.TabIndex = 2;
            this.editCharacter.Text = "Edit Character";
            this.editCharacter.UseVisualStyleBackColor = true;
            // 
            // createWeapon
            // 
            this.createWeapon.Location = new System.Drawing.Point(329, 110);
            this.createWeapon.Name = "createWeapon";
            this.createWeapon.Size = new System.Drawing.Size(159, 54);
            this.createWeapon.TabIndex = 3;
            this.createWeapon.Text = "Create Weapon";
            this.createWeapon.UseVisualStyleBackColor = true;
            // 
            // editWeapon
            // 
            this.editWeapon.Location = new System.Drawing.Point(329, 185);
            this.editWeapon.Name = "editWeapon";
            this.editWeapon.Size = new System.Drawing.Size(159, 54);
            this.editWeapon.TabIndex = 4;
            this.editWeapon.Text = "Edit Weapon";
            this.editWeapon.UseVisualStyleBackColor = true;
            // 
            // keyWords
            // 
            this.keyWords.Location = new System.Drawing.Point(203, 289);
            this.keyWords.Name = "keyWords";
            this.keyWords.Size = new System.Drawing.Size(159, 54);
            this.keyWords.TabIndex = 5;
            this.keyWords.Text = "Key Words";
            this.keyWords.UseVisualStyleBackColor = true;
            // 
            // specialRules
            // 
            this.specialRules.Location = new System.Drawing.Point(203, 360);
            this.specialRules.Name = "specialRules";
            this.specialRules.Size = new System.Drawing.Size(159, 54);
            this.specialRules.TabIndex = 6;
            this.specialRules.Text = "Special Rules";
            this.specialRules.UseVisualStyleBackColor = true;
            // 
            // createFaction
            // 
            this.createFaction.Location = new System.Drawing.Point(84, 467);
            this.createFaction.Name = "createFaction";
            this.createFaction.Size = new System.Drawing.Size(159, 54);
            this.createFaction.TabIndex = 7;
            this.createFaction.Text = "Create Faction";
            this.createFaction.UseVisualStyleBackColor = true;
            // 
            // editFaction
            // 
            this.editFaction.Location = new System.Drawing.Point(329, 467);
            this.editFaction.Name = "editFaction";
            this.editFaction.Size = new System.Drawing.Size(159, 54);
            this.editFaction.TabIndex = 8;
            this.editFaction.Text = "Edit Faction";
            this.editFaction.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(567, 610);
            this.Controls.Add(this.editFaction);
            this.Controls.Add(this.createFaction);
            this.Controls.Add(this.specialRules);
            this.Controls.Add(this.keyWords);
            this.Controls.Add(this.editWeapon);
            this.Controls.Add(this.createWeapon);
            this.Controls.Add(this.editCharacter);
            this.Controls.Add(this.createCharacter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Carnevale Database Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createCharacter;
        private System.Windows.Forms.Button editCharacter;
        private System.Windows.Forms.Button createWeapon;
        private System.Windows.Forms.Button editWeapon;
        private System.Windows.Forms.Button keyWords;
        private System.Windows.Forms.Button specialRules;
        private System.Windows.Forms.Button createFaction;
        private System.Windows.Forms.Button editFaction;
    }
}

