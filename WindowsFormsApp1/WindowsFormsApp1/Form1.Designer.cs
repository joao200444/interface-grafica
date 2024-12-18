namespace GameTrainerUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage playersTab;
        private System.Windows.Forms.TabPage miscTab;
        private System.Windows.Forms.TabPage configsTab;
        private Guna.UI2.WinForms.Guna2CheckBox infinityHealth;
        private Guna.UI2.WinForms.Guna2TrackBar damageMultiplier;
        private Guna.UI2.WinForms.Guna2CheckBox noCooldownSkills;
        private Guna.UI2.WinForms.Guna2CheckBox chargeSkillsInstantly;
        private Guna.UI2.WinForms.Guna2CheckBox instantCharacterSwitch;
        private Guna.UI2.WinForms.Guna2CheckBox critRate100;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.playersTab = new System.Windows.Forms.TabPage();
            this.infinityHealth = new Guna.UI2.WinForms.Guna2CheckBox();
            this.damageMultiplier = new Guna.UI2.WinForms.Guna2TrackBar();
            this.miscTab = new System.Windows.Forms.TabPage();
            this.noCooldownSkills = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chargeSkillsInstantly = new Guna.UI2.WinForms.Guna2CheckBox();
            this.configsTab = new System.Windows.Forms.TabPage();
            this.instantCharacterSwitch = new Guna.UI2.WinForms.Guna2CheckBox();
            this.critRate100 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tabControl.SuspendLayout();
            this.playersTab.SuspendLayout();
            this.miscTab.SuspendLayout();
            this.configsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.playersTab);
            this.tabControl.Controls.Add(this.miscTab);
            this.tabControl.Controls.Add(this.configsTab);
            this.tabControl.ItemSize = new System.Drawing.Size(180, 40);
            this.tabControl.Location = new System.Drawing.Point(-3, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(810, 492);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tabControl.TabIndex = 1;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // playersTab
            // 
            this.playersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.playersTab.Controls.Add(this.infinityHealth);
            this.playersTab.Controls.Add(this.damageMultiplier);
            this.playersTab.Location = new System.Drawing.Point(184, 4);
            this.playersTab.Name = "playersTab";
            this.playersTab.Padding = new System.Windows.Forms.Padding(3);
            this.playersTab.Size = new System.Drawing.Size(622, 484);
            this.playersTab.TabIndex = 0;
            this.playersTab.Text = "Players⛑";
            this.playersTab.Click += new System.EventHandler(this.playersTab_Click);
            // 
            // infinityHealth
            // 
            this.infinityHealth.AutoSize = true;
            this.infinityHealth.CheckedState.BorderRadius = 0;
            this.infinityHealth.CheckedState.BorderThickness = 0;
            this.infinityHealth.ForeColor = System.Drawing.Color.White;
            this.infinityHealth.Location = new System.Drawing.Point(11, 29);
            this.infinityHealth.Name = "infinityHealth";
            this.infinityHealth.Size = new System.Drawing.Size(90, 17);
            this.infinityHealth.TabIndex = 0;
            this.infinityHealth.Text = "Infinity Health";
            this.infinityHealth.UncheckedState.BorderRadius = 0;
            this.infinityHealth.UncheckedState.BorderThickness = 0;
            this.infinityHealth.UseVisualStyleBackColor = true;
            // 
            // damageMultiplier
            // 
            this.damageMultiplier.Location = new System.Drawing.Point(9, 61);
            this.damageMultiplier.Name = "damageMultiplier";
            this.damageMultiplier.Size = new System.Drawing.Size(171, 20);
            this.damageMultiplier.TabIndex = 1;
            this.damageMultiplier.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            // 
            // miscTab
            // 
            this.miscTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.miscTab.Controls.Add(this.noCooldownSkills);
            this.miscTab.Controls.Add(this.chargeSkillsInstantly);
            this.miscTab.Location = new System.Drawing.Point(184, 4);
            this.miscTab.Name = "miscTab";
            this.miscTab.Padding = new System.Windows.Forms.Padding(3);
            this.miscTab.Size = new System.Drawing.Size(622, 484);
            this.miscTab.TabIndex = 1;
            this.miscTab.Text = "Misc";
            // 
            // noCooldownSkills
            // 
            this.noCooldownSkills.AutoSize = true;
            this.noCooldownSkills.CheckedState.BorderRadius = 0;
            this.noCooldownSkills.CheckedState.BorderThickness = 0;
            this.noCooldownSkills.ForeColor = System.Drawing.Color.White;
            this.noCooldownSkills.Location = new System.Drawing.Point(11, 29);
            this.noCooldownSkills.Name = "noCooldownSkills";
            this.noCooldownSkills.Size = new System.Drawing.Size(117, 17);
            this.noCooldownSkills.TabIndex = 0;
            this.noCooldownSkills.Text = "No Cooldown Skills";
            this.noCooldownSkills.UncheckedState.BorderRadius = 0;
            this.noCooldownSkills.UncheckedState.BorderThickness = 0;
            this.noCooldownSkills.UseVisualStyleBackColor = true;
            // 
            // chargeSkillsInstantly
            // 
            this.chargeSkillsInstantly.AutoSize = true;
            this.chargeSkillsInstantly.CheckedState.BorderRadius = 0;
            this.chargeSkillsInstantly.CheckedState.BorderThickness = 0;
            this.chargeSkillsInstantly.ForeColor = System.Drawing.Color.White;
            this.chargeSkillsInstantly.Location = new System.Drawing.Point(11, 63);
            this.chargeSkillsInstantly.Name = "chargeSkillsInstantly";
            this.chargeSkillsInstantly.Size = new System.Drawing.Size(129, 17);
            this.chargeSkillsInstantly.TabIndex = 1;
            this.chargeSkillsInstantly.Text = "Charge Skills Instantly";
            this.chargeSkillsInstantly.UncheckedState.BorderRadius = 0;
            this.chargeSkillsInstantly.UncheckedState.BorderThickness = 0;
            this.chargeSkillsInstantly.UseVisualStyleBackColor = true;
            // 
            // configsTab
            // 
            this.configsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.configsTab.Controls.Add(this.instantCharacterSwitch);
            this.configsTab.Controls.Add(this.critRate100);
            this.configsTab.Location = new System.Drawing.Point(184, 4);
            this.configsTab.Name = "configsTab";
            this.configsTab.Padding = new System.Windows.Forms.Padding(3);
            this.configsTab.Size = new System.Drawing.Size(622, 484);
            this.configsTab.TabIndex = 2;
            this.configsTab.Text = "Configs";
            // 
            // instantCharacterSwitch
            // 
            this.instantCharacterSwitch.AutoSize = true;
            this.instantCharacterSwitch.CheckedState.BorderRadius = 0;
            this.instantCharacterSwitch.CheckedState.BorderThickness = 0;
            this.instantCharacterSwitch.ForeColor = System.Drawing.Color.White;
            this.instantCharacterSwitch.Location = new System.Drawing.Point(11, 29);
            this.instantCharacterSwitch.Name = "instantCharacterSwitch";
            this.instantCharacterSwitch.Size = new System.Drawing.Size(142, 17);
            this.instantCharacterSwitch.TabIndex = 0;
            this.instantCharacterSwitch.Text = "Instant Character Switch";
            this.instantCharacterSwitch.UncheckedState.BorderRadius = 0;
            this.instantCharacterSwitch.UncheckedState.BorderThickness = 0;
            this.instantCharacterSwitch.UseVisualStyleBackColor = true;
            // 
            // critRate100
            // 
            this.critRate100.AutoSize = true;
            this.critRate100.CheckedState.BorderRadius = 0;
            this.critRate100.CheckedState.BorderThickness = 0;
            this.critRate100.ForeColor = System.Drawing.Color.White;
            this.critRate100.Location = new System.Drawing.Point(11, 63);
            this.critRate100.Name = "critRate100";
            this.critRate100.Size = new System.Drawing.Size(96, 17);
            this.critRate100.TabIndex = 1;
            this.critRate100.Text = "100% Crit Rate";
            this.critRate100.UncheckedState.BorderRadius = 0;
            this.critRate100.UncheckedState.BorderThickness = 0;
            this.critRate100.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(807, 496);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "SMUNK_YT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.playersTab.ResumeLayout(false);
            this.playersTab.PerformLayout();
            this.miscTab.ResumeLayout(false);
            this.miscTab.PerformLayout();
            this.configsTab.ResumeLayout(false);
            this.configsTab.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
