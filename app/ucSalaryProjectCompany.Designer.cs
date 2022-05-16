namespace ApplicationForm
{
    partial class ucSalaryProjectCompany
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassportNum = new System.Windows.Forms.TextBox();
            this.btnSendSP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listEmployees = new System.Windows.Forms.ListBox();
            this.btnPaySalary = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnSetSalary = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPassNumEmployee = new System.Windows.Forms.ComboBox();
            this.btnUpdateInf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(452, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Номер паспорта сотрудника";
            // 
            // txtPassportNum
            // 
            this.txtPassportNum.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassportNum.Location = new System.Drawing.Point(455, 98);
            this.txtPassportNum.Multiline = true;
            this.txtPassportNum.Name = "txtPassportNum";
            this.txtPassportNum.Size = new System.Drawing.Size(209, 30);
            this.txtPassportNum.TabIndex = 18;
            this.txtPassportNum.Text = "MP543633";
            // 
            // btnSendSP
            // 
            this.btnSendSP.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSendSP.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSendSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendSP.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendSP.ForeColor = System.Drawing.Color.White;
            this.btnSendSP.Location = new System.Drawing.Point(455, 134);
            this.btnSendSP.Name = "btnSendSP";
            this.btnSendSP.Size = new System.Drawing.Size(208, 30);
            this.btnSendSP.TabIndex = 20;
            this.btnSendSP.Text = "Добавить";
            this.btnSendSP.UseVisualStyleBackColor = false;
            this.btnSendSP.Click += new System.EventHandler(this.btnSendSP_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(451, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 49);
            this.label8.TabIndex = 22;
            this.label8.Text = "Добавление сотрудника в зарплатный проект";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Список сотрудников";
            // 
            // listEmployees
            // 
            this.listEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listEmployees.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listEmployees.FormattingEnabled = true;
            this.listEmployees.ItemHeight = 16;
            this.listEmployees.Items.AddRange(new object[] {
            "*empty*"});
            this.listEmployees.Location = new System.Drawing.Point(32, 87);
            this.listEmployees.Name = "listEmployees";
            this.listEmployees.Size = new System.Drawing.Size(379, 416);
            this.listEmployees.TabIndex = 24;
            // 
            // btnPaySalary
            // 
            this.btnPaySalary.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPaySalary.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPaySalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaySalary.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPaySalary.ForeColor = System.Drawing.Color.White;
            this.btnPaySalary.Location = new System.Drawing.Point(32, 510);
            this.btnPaySalary.Name = "btnPaySalary";
            this.btnPaySalary.Size = new System.Drawing.Size(164, 30);
            this.btnPaySalary.TabIndex = 25;
            this.btnPaySalary.Text = "Выплатить зарплату";
            this.btnPaySalary.UseVisualStyleBackColor = false;
            this.btnPaySalary.Click += new System.EventHandler(this.btnPaySalary_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(453, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 27);
            this.label4.TabIndex = 32;
            this.label4.Text = "Задать зарплату";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(454, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Размер зарплаты";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSalary.Location = new System.Drawing.Point(457, 240);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(209, 30);
            this.txtSalary.TabIndex = 30;
            // 
            // btnSetSalary
            // 
            this.btnSetSalary.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSetSalary.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSetSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetSalary.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetSalary.ForeColor = System.Drawing.Color.White;
            this.btnSetSalary.Location = new System.Drawing.Point(457, 331);
            this.btnSetSalary.Name = "btnSetSalary";
            this.btnSetSalary.Size = new System.Drawing.Size(207, 30);
            this.btnSetSalary.TabIndex = 29;
            this.btnSetSalary.Text = "Установить зарплату";
            this.btnSetSalary.UseVisualStyleBackColor = false;
            this.btnSetSalary.Click += new System.EventHandler(this.btnSetSalary_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(454, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Номер паспорта сотрудника";
            // 
            // cmbPassNumEmployee
            // 
            this.cmbPassNumEmployee.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbPassNumEmployee.FormattingEnabled = true;
            this.cmbPassNumEmployee.Location = new System.Drawing.Point(457, 299);
            this.cmbPassNumEmployee.Name = "cmbPassNumEmployee";
            this.cmbPassNumEmployee.Size = new System.Drawing.Size(209, 25);
            this.cmbPassNumEmployee.TabIndex = 45;
            // 
            // btnUpdateInf
            // 
            this.btnUpdateInf.BackColor = System.Drawing.Color.White;
            this.btnUpdateInf.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUpdateInf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInf.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdateInf.Location = new System.Drawing.Point(241, 21);
            this.btnUpdateInf.Name = "btnUpdateInf";
            this.btnUpdateInf.Size = new System.Drawing.Size(82, 30);
            this.btnUpdateInf.TabIndex = 46;
            this.btnUpdateInf.Text = "Обновить";
            this.btnUpdateInf.UseVisualStyleBackColor = false;
            this.btnUpdateInf.Click += new System.EventHandler(this.btnUpdateInf_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(29, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 37);
            this.label3.TabIndex = 61;
            this.label3.Text = "Номер паспорта сотрудника";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(153, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 32);
            this.label11.TabIndex = 71;
            this.label11.Text = "Размер зарплаты";
            // 
            // ucSalaryProjectCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateInf);
            this.Controls.Add(this.cmbPassNumEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.btnSetSalary);
            this.Controls.Add(this.btnPaySalary);
            this.Controls.Add(this.listEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSendSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassportNum);
            this.Name = "ucSalaryProjectCompany";
            this.Size = new System.Drawing.Size(687, 551);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassportNum;
        private System.Windows.Forms.Button btnSendSP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEmployees;
        private System.Windows.Forms.Button btnPaySalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnSetSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPassNumEmployee;
        private System.Windows.Forms.Button btnUpdateInf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
    }
}
