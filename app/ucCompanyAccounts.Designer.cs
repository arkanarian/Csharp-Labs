namespace ApplicationForm
{
    partial class ucCompanyAccounts
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
            this.label8 = new System.Windows.Forms.Label();
            this.listAccounts = new System.Windows.Forms.ListBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSumm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSumCash = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGiveCash = new System.Windows.Forms.Button();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnActivateAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSumTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.cmbAccountsTS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(50, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 26);
            this.label8.TabIndex = 31;
            this.label8.Text = "Банковские счета";
            // 
            // listAccounts
            // 
            this.listAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAccounts.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listAccounts.FormattingEnabled = true;
            this.listAccounts.ItemHeight = 16;
            this.listAccounts.Items.AddRange(new object[] {
            "*empty*"});
            this.listAccounts.Location = new System.Drawing.Point(54, 88);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(316, 400);
            this.listAccounts.TabIndex = 32;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(54, 506);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(107, 30);
            this.btnCreateAccount.TabIndex = 47;
            this.btnCreateAccount.Text = "Открыть счет";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddMoney.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMoney.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddMoney.ForeColor = System.Drawing.Color.White;
            this.btnAddMoney.Location = new System.Drawing.Point(426, 180);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(208, 30);
            this.btnAddMoney.TabIndex = 53;
            this.btnAddMoney.Text = "Пополнить";
            this.btnAddMoney.UseVisualStyleBackColor = false;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(423, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 26);
            this.label3.TabIndex = 56;
            this.label3.Text = "Пополнение счета";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(51, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Номер счета";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(165, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 58;
            this.label5.Text = "Сумма на счете";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(423, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Сумма";
            // 
            // txtSumm
            // 
            this.txtSumm.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumm.Location = new System.Drawing.Point(427, 144);
            this.txtSumm.Multiline = true;
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.Size = new System.Drawing.Size(209, 30);
            this.txtSumm.TabIndex = 59;
            this.txtSumm.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(424, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Сумма";
            // 
            // txtSumCash
            // 
            this.txtSumCash.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumCash.Location = new System.Drawing.Point(428, 276);
            this.txtSumCash.Multiline = true;
            this.txtSumCash.Name = "txtSumCash";
            this.txtSumCash.Size = new System.Drawing.Size(209, 30);
            this.txtSumCash.TabIndex = 65;
            this.txtSumCash.Text = "0";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(424, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 26);
            this.label9.TabIndex = 64;
            this.label9.Text = "Снять наличными";
            // 
            // btnGiveCash
            // 
            this.btnGiveCash.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiveCash.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGiveCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiveCash.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGiveCash.ForeColor = System.Drawing.Color.White;
            this.btnGiveCash.Location = new System.Drawing.Point(427, 312);
            this.btnGiveCash.Name = "btnGiveCash";
            this.btnGiveCash.Size = new System.Drawing.Size(208, 30);
            this.btnGiveCash.TabIndex = 61;
            this.btnGiveCash.Text = "Снять";
            this.btnGiveCash.UseVisualStyleBackColor = false;
            this.btnGiveCash.Click += new System.EventHandler(this.btnGiveCash_Click);
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRemoveAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRemoveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAccount.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveAccount.ForeColor = System.Drawing.Color.White;
            this.btnRemoveAccount.Location = new System.Drawing.Point(181, 506);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(152, 30);
            this.btnRemoveAccount.TabIndex = 67;
            this.btnRemoveAccount.Text = "Закрыть текущий счет";
            this.btnRemoveAccount.UseVisualStyleBackColor = false;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(427, 30);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(209, 25);
            this.cmbAccounts.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(425, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 71;
            this.label11.Text = "Банковский счет";
            // 
            // btnActivateAccount
            // 
            this.btnActivateAccount.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActivateAccount.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnActivateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivateAccount.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActivateAccount.ForeColor = System.Drawing.Color.White;
            this.btnActivateAccount.Location = new System.Drawing.Point(428, 61);
            this.btnActivateAccount.Name = "btnActivateAccount";
            this.btnActivateAccount.Size = new System.Drawing.Size(209, 30);
            this.btnActivateAccount.TabIndex = 70;
            this.btnActivateAccount.Text = "Сделать активным";
            this.btnActivateAccount.UseVisualStyleBackColor = false;
            this.btnActivateAccount.Click += new System.EventHandler(this.btnActivateAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(423, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Сумма";
            // 
            // txtSumTS
            // 
            this.txtSumTS.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSumTS.Location = new System.Drawing.Point(427, 461);
            this.txtSumTS.Multiline = true;
            this.txtSumTS.Name = "txtSumTS";
            this.txtSumTS.Size = new System.Drawing.Size(209, 30);
            this.txtSumTS.TabIndex = 75;
            this.txtSumTS.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(424, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 26);
            this.label2.TabIndex = 74;
            this.label2.Text = "Перевести на счет";
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(426, 497);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(208, 30);
            this.btnTransaction.TabIndex = 73;
            this.btnTransaction.Text = "Перевести";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // cmbAccountsTS
            // 
            this.cmbAccountsTS.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAccountsTS.FormattingEnabled = true;
            this.cmbAccountsTS.Location = new System.Drawing.Point(425, 413);
            this.cmbAccountsTS.Name = "cmbAccountsTS";
            this.cmbAccountsTS.Size = new System.Drawing.Size(209, 25);
            this.cmbAccountsTS.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(423, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Банковский счет";
            // 
            // ucCompanyAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbAccountsTS);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSumTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.cmbAccounts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnActivateAccount);
            this.Controls.Add(this.btnRemoveAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSumCash);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGiveCash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSumm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.listAccounts);
            this.Controls.Add(this.label8);
            this.Name = "ucCompanyAccounts";
            this.Size = new System.Drawing.Size(685, 551);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listAccounts;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSumm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSumCash;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGiveCash;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnActivateAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSumTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.ComboBox cmbAccountsTS;
        private System.Windows.Forms.Label label10;
    }
}
