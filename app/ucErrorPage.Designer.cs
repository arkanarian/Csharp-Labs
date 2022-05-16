namespace ApplicationForm
{
    partial class ucErrorPage
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbErrorMessage = new System.Windows.Forms.Label();
            this.btnCloseErrorPage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(207, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ошибка";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbErrorMessage);
            this.panel1.Controls.Add(this.btnCloseErrorPage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 291);
            this.panel1.TabIndex = 8;
            // 
            // lbErrorMessage
            // 
            this.lbErrorMessage.BackColor = System.Drawing.Color.White;
            this.lbErrorMessage.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbErrorMessage.Location = new System.Drawing.Point(3, 121);
            this.lbErrorMessage.Name = "lbErrorMessage";
            this.lbErrorMessage.Size = new System.Drawing.Size(501, 17);
            this.lbErrorMessage.TabIndex = 23;
            this.lbErrorMessage.Text = "Информация об ошибке";
            // 
            // btnCloseErrorPage
            // 
            this.btnCloseErrorPage.BackColor = System.Drawing.Color.White;
            this.btnCloseErrorPage.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnCloseErrorPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseErrorPage.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseErrorPage.Location = new System.Drawing.Point(223, 228);
            this.btnCloseErrorPage.Name = "btnCloseErrorPage";
            this.btnCloseErrorPage.Size = new System.Drawing.Size(56, 30);
            this.btnCloseErrorPage.TabIndex = 22;
            this.btnCloseErrorPage.Text = "ОК";
            this.btnCloseErrorPage.UseVisualStyleBackColor = false;
            this.btnCloseErrorPage.Click += new System.EventHandler(this.btnCloseErrorPage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 297);
            this.panel2.TabIndex = 0;
            // 
            // ucErrorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ucErrorPage";
            this.Size = new System.Drawing.Size(519, 303);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCloseErrorPage;
        private System.Windows.Forms.Label lbErrorMessage;
    }
}
