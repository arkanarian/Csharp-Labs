namespace ApplicationForm
{
    partial class ucAdministratorPage
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
            this.btnDenyAction = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listActions = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listLogs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDenyAction
            // 
            this.btnDenyAction.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDenyAction.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDenyAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDenyAction.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDenyAction.ForeColor = System.Drawing.Color.White;
            this.btnDenyAction.Location = new System.Drawing.Point(642, 21);
            this.btnDenyAction.Name = "btnDenyAction";
            this.btnDenyAction.Size = new System.Drawing.Size(248, 30);
            this.btnDenyAction.TabIndex = 75;
            this.btnDenyAction.Text = "Отменить последнюю операцию";
            this.btnDenyAction.UseVisualStyleBackColor = false;
            this.btnDenyAction.Click += new System.EventHandler(this.btnDenyAction_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(111, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 74;
            this.label5.Text = "Инфомация о событии";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "ID события";
            // 
            // listActions
            // 
            this.listActions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listActions.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listActions.FormattingEnabled = true;
            this.listActions.ItemHeight = 16;
            this.listActions.Items.AddRange(new object[] {
            "*empty*"});
            this.listActions.Location = new System.Drawing.Point(24, 73);
            this.listActions.Name = "listActions";
            this.listActions.Size = new System.Drawing.Size(866, 144);
            this.listActions.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 24);
            this.label8.TabIndex = 71;
            this.label8.Text = "События";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(111, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Инфомация логе";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(21, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Тип лога";
            // 
            // listLogs
            // 
            this.listLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLogs.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listLogs.FormattingEnabled = true;
            this.listLogs.ItemHeight = 16;
            this.listLogs.Items.AddRange(new object[] {
            "*empty*"});
            this.listLogs.Location = new System.Drawing.Point(24, 272);
            this.listLogs.Name = "listLogs";
            this.listLogs.Size = new System.Drawing.Size(854, 304);
            this.listLogs.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Все логи";
            // 
            // ucAdministratorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listLogs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDenyAction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listActions);
            this.Controls.Add(this.label8);
            this.Name = "ucAdministratorPage";
            this.Size = new System.Drawing.Size(921, 590);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDenyAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listActions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listLogs;
        private System.Windows.Forms.Label label3;
    }
}
