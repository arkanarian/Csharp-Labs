namespace ApplicationForm
{
    partial class ucCompanyPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnSalaryProject = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbBankName = new System.Windows.Forms.Label();
            this.lblCompanyInf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountInf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlDivider.Location = new System.Drawing.Point(211, 39);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(10, 514);
            this.pnlDivider.TabIndex = 20;
            // 
            // btnSalaryProject
            // 
            this.btnSalaryProject.BackColor = System.Drawing.Color.White;
            this.btnSalaryProject.CausesValidation = false;
            this.btnSalaryProject.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSalaryProject.FlatAppearance.BorderSize = 0;
            this.btnSalaryProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaryProject.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSalaryProject.Location = new System.Drawing.Point(36, 103);
            this.btnSalaryProject.Name = "btnSalaryProject";
            this.btnSalaryProject.Size = new System.Drawing.Size(158, 30);
            this.btnSalaryProject.TabIndex = 23;
            this.btnSalaryProject.Text = "Зарплатный проект";
            this.btnSalaryProject.UseVisualStyleBackColor = false;
            this.btnSalaryProject.Click += new System.EventHandler(this.btnSalaryProject_Click);
            this.btnSalaryProject.MouseLeave += new System.EventHandler(this.btnBase_MouseLeave);
            this.btnSalaryProject.MouseHover += new System.EventHandler(this.btnBase_MouseHover);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.White;
            this.btnAccounts.CausesValidation = false;
            this.btnAccounts.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccounts.Location = new System.Drawing.Point(22, 67);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(172, 30);
            this.btnAccounts.TabIndex = 23;
            this.btnAccounts.Text = "Банковские счета";
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            this.btnAccounts.MouseLeave += new System.EventHandler(this.btnBase_MouseLeave);
            this.btnAccounts.MouseHover += new System.EventHandler(this.btnBase_MouseHover);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(232, 39);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(686, 551);
            this.panelContainer.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(229, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Ваш банк:";
            // 
            // lbBankName
            // 
            this.lbBankName.AutoSize = true;
            this.lbBankName.BackColor = System.Drawing.Color.White;
            this.lbBankName.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBankName.Location = new System.Drawing.Point(305, 13);
            this.lbBankName.Name = "lbBankName";
            this.lbBankName.Size = new System.Drawing.Size(119, 17);
            this.lbBankName.TabIndex = 27;
            this.lbBankName.Text = "*название банка*";
            // 
            // lblCompanyInf
            // 
            this.lblCompanyInf.BackColor = System.Drawing.Color.White;
            this.lblCompanyInf.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompanyInf.Location = new System.Drawing.Point(19, 512);
            this.lblCompanyInf.Name = "lblCompanyInf";
            this.lblCompanyInf.Size = new System.Drawing.Size(186, 42);
            this.lblCompanyInf.TabIndex = 28;
            this.lblCompanyInf.Text = "*информация о компании*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(19, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Компания:";
            // 
            // lblAccountInf
            // 
            this.lblAccountInf.AutoSize = true;
            this.lblAccountInf.BackColor = System.Drawing.Color.White;
            this.lblAccountInf.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAccountInf.Location = new System.Drawing.Point(603, 13);
            this.lblAccountInf.Name = "lblAccountInf";
            this.lblAccountInf.Size = new System.Drawing.Size(151, 17);
            this.lblAccountInf.TabIndex = 31;
            this.lblAccountInf.Text = "*информация о счете*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(501, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Текущий счет:";
            // 
            // ucCompanyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblAccountInf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompanyInf);
            this.Controls.Add(this.lbBankName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnSalaryProject);
            this.Controls.Add(this.pnlDivider);
            this.Name = "ucCompanyPage";
            this.Size = new System.Drawing.Size(921, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Button btnSalaryProject;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbBankName;
        private System.Windows.Forms.Label lblCompanyInf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountInf;
        private System.Windows.Forms.Label label4;
    }
}
