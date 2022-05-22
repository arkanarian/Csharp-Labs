
namespace Laba2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBackWhite = new System.Windows.Forms.Panel();
            this.pnlBackBlack = new System.Windows.Forms.Panel();
            this.pnlBackPink = new System.Windows.Forms.Panel();
            this.pnlBackBlue = new System.Windows.Forms.Panel();
            this.pnlBackCyan = new System.Windows.Forms.Panel();
            this.pnlBackGreen = new System.Windows.Forms.Panel();
            this.pnlBackYellow = new System.Windows.Forms.Panel();
            this.pnlBackOrange = new System.Windows.Forms.Panel();
            this.pnlBackRed = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBorderWhite = new System.Windows.Forms.Panel();
            this.pnlBorderBlack = new System.Windows.Forms.Panel();
            this.pnlBorderPink = new System.Windows.Forms.Panel();
            this.pnlBorderBlue = new System.Windows.Forms.Panel();
            this.pnlBorderCyan = new System.Windows.Forms.Panel();
            this.pnlBorderGreen = new System.Windows.Forms.Panel();
            this.pnlBorderYellow = new System.Windows.Forms.Panel();
            this.pnlBorderOrange = new System.Windows.Forms.Panel();
            this.pnlBorderRed = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDrawCoordinates = new System.Windows.Forms.Button();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.lblx1 = new System.Windows.Forms.Label();
            this.pnlCurrentBackColor = new System.Windows.Forms.Panel();
            this.pnlCurrentBorderColor = new System.Windows.Forms.Panel();
            this.cmbFigures = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(808, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Background color:";
            // 
            // pnlBackWhite
            // 
            this.pnlBackWhite.BackColor = System.Drawing.Color.White;
            this.pnlBackWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackWhite.Location = new System.Drawing.Point(920, 28);
            this.pnlBackWhite.Name = "pnlBackWhite";
            this.pnlBackWhite.Size = new System.Drawing.Size(17, 16);
            this.pnlBackWhite.TabIndex = 39;
            this.pnlBackWhite.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // pnlBackBlack
            // 
            this.pnlBackBlack.BackColor = System.Drawing.Color.Black;
            this.pnlBackBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackBlack.Location = new System.Drawing.Point(943, 28);
            this.pnlBackBlack.Name = "pnlBackBlack";
            this.pnlBackBlack.Size = new System.Drawing.Size(17, 16);
            this.pnlBackBlack.TabIndex = 38;
            this.pnlBackBlack.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // pnlBackPink
            // 
            this.pnlBackPink.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlBackPink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackPink.Location = new System.Drawing.Point(966, 28);
            this.pnlBackPink.Name = "pnlBackPink";
            this.pnlBackPink.Size = new System.Drawing.Size(17, 16);
            this.pnlBackPink.TabIndex = 37;
            this.pnlBackPink.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // pnlBackBlue
            // 
            this.pnlBackBlue.BackColor = System.Drawing.Color.Blue;
            this.pnlBackBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackBlue.Location = new System.Drawing.Point(989, 28);
            this.pnlBackBlue.Name = "pnlBackBlue";
            this.pnlBackBlue.Size = new System.Drawing.Size(17, 16);
            this.pnlBackBlue.TabIndex = 36;
            this.pnlBackBlue.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // pnlBackCyan
            // 
            this.pnlBackCyan.BackColor = System.Drawing.Color.Cyan;
            this.pnlBackCyan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackCyan.ForeColor = System.Drawing.Color.Black;
            this.pnlBackCyan.Location = new System.Drawing.Point(1012, 28);
            this.pnlBackCyan.Name = "pnlBackCyan";
            this.pnlBackCyan.Size = new System.Drawing.Size(17, 16);
            this.pnlBackCyan.TabIndex = 35;
            this.pnlBackCyan.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // pnlBackGreen
            // 
            this.pnlBackGreen.BackColor = System.Drawing.Color.Lime;
            this.pnlBackGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackGreen.Location = new System.Drawing.Point(1035, 28);
            this.pnlBackGreen.Name = "pnlBackGreen";
            this.pnlBackGreen.Size = new System.Drawing.Size(17, 16);
            this.pnlBackGreen.TabIndex = 34;
            this.pnlBackGreen.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // pnlBackYellow
            // 
            this.pnlBackYellow.BackColor = System.Drawing.Color.Yellow;
            this.pnlBackYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackYellow.Location = new System.Drawing.Point(1058, 28);
            this.pnlBackYellow.Name = "pnlBackYellow";
            this.pnlBackYellow.Size = new System.Drawing.Size(17, 16);
            this.pnlBackYellow.TabIndex = 33;
            this.pnlBackYellow.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // pnlBackOrange
            // 
            this.pnlBackOrange.BackColor = System.Drawing.Color.Orange;
            this.pnlBackOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackOrange.Location = new System.Drawing.Point(1081, 28);
            this.pnlBackOrange.Name = "pnlBackOrange";
            this.pnlBackOrange.Size = new System.Drawing.Size(17, 16);
            this.pnlBackOrange.TabIndex = 31;
            this.pnlBackOrange.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // pnlBackRed
            // 
            this.pnlBackRed.BackColor = System.Drawing.Color.Red;
            this.pnlBackRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBackRed.Location = new System.Drawing.Point(1104, 28);
            this.pnlBackRed.Name = "pnlBackRed";
            this.pnlBackRed.Size = new System.Drawing.Size(17, 16);
            this.pnlBackRed.TabIndex = 30;
            this.pnlBackRed.Click += new System.EventHandler(this.pnlBackColorBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(836, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Border color:";
            // 
            // pnlBorderWhite
            // 
            this.pnlBorderWhite.BackColor = System.Drawing.Color.White;
            this.pnlBorderWhite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderWhite.Location = new System.Drawing.Point(920, 9);
            this.pnlBorderWhite.Name = "pnlBorderWhite";
            this.pnlBorderWhite.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderWhite.TabIndex = 29;
            this.pnlBorderWhite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // pnlBorderBlack
            // 
            this.pnlBorderBlack.BackColor = System.Drawing.Color.Black;
            this.pnlBorderBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderBlack.Location = new System.Drawing.Point(943, 9);
            this.pnlBorderBlack.Name = "pnlBorderBlack";
            this.pnlBorderBlack.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderBlack.TabIndex = 28;
            this.pnlBorderBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // pnlBorderPink
            // 
            this.pnlBorderPink.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlBorderPink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderPink.Location = new System.Drawing.Point(966, 9);
            this.pnlBorderPink.Name = "pnlBorderPink";
            this.pnlBorderPink.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderPink.TabIndex = 27;
            this.pnlBorderPink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // pnlBorderBlue
            // 
            this.pnlBorderBlue.BackColor = System.Drawing.Color.Blue;
            this.pnlBorderBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderBlue.Location = new System.Drawing.Point(989, 9);
            this.pnlBorderBlue.Name = "pnlBorderBlue";
            this.pnlBorderBlue.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderBlue.TabIndex = 26;
            this.pnlBorderBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // pnlBorderCyan
            // 
            this.pnlBorderCyan.BackColor = System.Drawing.Color.Cyan;
            this.pnlBorderCyan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderCyan.Location = new System.Drawing.Point(1012, 9);
            this.pnlBorderCyan.Name = "pnlBorderCyan";
            this.pnlBorderCyan.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderCyan.TabIndex = 25;
            this.pnlBorderCyan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // pnlBorderGreen
            // 
            this.pnlBorderGreen.BackColor = System.Drawing.Color.Lime;
            this.pnlBorderGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderGreen.Location = new System.Drawing.Point(1035, 9);
            this.pnlBorderGreen.Name = "pnlBorderGreen";
            this.pnlBorderGreen.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderGreen.TabIndex = 24;
            this.pnlBorderGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // pnlBorderYellow
            // 
            this.pnlBorderYellow.BackColor = System.Drawing.Color.Yellow;
            this.pnlBorderYellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderYellow.Location = new System.Drawing.Point(1058, 9);
            this.pnlBorderYellow.Name = "pnlBorderYellow";
            this.pnlBorderYellow.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderYellow.TabIndex = 22;
            this.pnlBorderYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // pnlBorderOrange
            // 
            this.pnlBorderOrange.BackColor = System.Drawing.Color.Orange;
            this.pnlBorderOrange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderOrange.Location = new System.Drawing.Point(1081, 9);
            this.pnlBorderOrange.Name = "pnlBorderOrange";
            this.pnlBorderOrange.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderOrange.TabIndex = 21;
            this.pnlBorderOrange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // pnlBorderRed
            // 
            this.pnlBorderRed.BackColor = System.Drawing.Color.Red;
            this.pnlBorderRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBorderRed.Location = new System.Drawing.Point(1104, 9);
            this.pnlBorderRed.Name = "pnlBorderRed";
            this.pnlBorderRed.Size = new System.Drawing.Size(17, 16);
            this.pnlBorderRed.TabIndex = 20;
            this.pnlBorderRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBorderColorBase_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnOpen);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnDrawCoordinates);
            this.panel2.Controls.Add(this.txtY2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtY1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtX2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtX1);
            this.panel2.Controls.Add(this.lblx1);
            this.panel2.Controls.Add(this.pnlCurrentBackColor);
            this.panel2.Controls.Add(this.pnlCurrentBorderColor);
            this.panel2.Controls.Add(this.cmbFigures);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 53);
            this.panel2.TabIndex = 40;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.redo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.undo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(722, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 21);
            this.textBox1.TabIndex = 49;
            this.textBox1.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(136, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 25);
            this.btnOpen.TabIndex = 53;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(74, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 25);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(722, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "Width:";
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Location = new System.Drawing.Point(12, 15);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(56, 25);
            this.btnNew.TabIndex = 51;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDrawCoordinates
            // 
            this.btnDrawCoordinates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawCoordinates.Location = new System.Drawing.Point(659, 26);
            this.btnDrawCoordinates.Name = "btnDrawCoordinates";
            this.btnDrawCoordinates.Size = new System.Drawing.Size(50, 25);
            this.btnDrawCoordinates.TabIndex = 41;
            this.btnDrawCoordinates.Text = "Draw";
            this.btnDrawCoordinates.UseVisualStyleBackColor = true;
            this.btnDrawCoordinates.Click += new System.EventHandler(this.btnDrawFigureCoordinates_Click);
            // 
            // txtY2
            // 
            this.txtY2.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtY2.Location = new System.Drawing.Point(599, 29);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(54, 21);
            this.txtY2.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(573, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "y2:";
            // 
            // txtY1
            // 
            this.txtY1.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtY1.Location = new System.Drawing.Point(512, 28);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(54, 21);
            this.txtY1.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(486, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "y1:";
            // 
            // txtX2
            // 
            this.txtX2.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtX2.Location = new System.Drawing.Point(422, 27);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(54, 21);
            this.txtX2.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(396, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "x2:";
            // 
            // txtX1
            // 
            this.txtX1.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtX1.Location = new System.Drawing.Point(335, 26);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(54, 21);
            this.txtX1.TabIndex = 41;
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.BackColor = System.Drawing.SystemColors.Control;
            this.lblx1.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblx1.Location = new System.Drawing.Point(309, 28);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(23, 16);
            this.lblx1.TabIndex = 42;
            this.lblx1.Text = "x1:";
            // 
            // pnlCurrentBackColor
            // 
            this.pnlCurrentBackColor.BackColor = System.Drawing.Color.White;
            this.pnlCurrentBackColor.Location = new System.Drawing.Point(785, 28);
            this.pnlCurrentBackColor.Name = "pnlCurrentBackColor";
            this.pnlCurrentBackColor.Size = new System.Drawing.Size(17, 16);
            this.pnlCurrentBackColor.TabIndex = 41;
            // 
            // pnlCurrentBorderColor
            // 
            this.pnlCurrentBorderColor.BackColor = System.Drawing.Color.Black;
            this.pnlCurrentBorderColor.Location = new System.Drawing.Point(785, 9);
            this.pnlCurrentBorderColor.Name = "pnlCurrentBorderColor";
            this.pnlCurrentBorderColor.Size = new System.Drawing.Size(17, 16);
            this.pnlCurrentBorderColor.TabIndex = 40;
            // 
            // cmbFigures
            // 
            this.cmbFigures.FormattingEnabled = true;
            this.cmbFigures.Location = new System.Drawing.Point(457, 2);
            this.cmbFigures.Name = "cmbFigures";
            this.cmbFigures.Size = new System.Drawing.Size(109, 23);
            this.cmbFigures.TabIndex = 41;
            this.cmbFigures.SelectedValueChanged += new System.EventHandler(this.cmbFigures_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(400, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Figure:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 759);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlBackWhite);
            this.Controls.Add(this.pnlBackBlack);
            this.Controls.Add(this.pnlBackPink);
            this.Controls.Add(this.pnlBackBlue);
            this.Controls.Add(this.pnlBackCyan);
            this.Controls.Add(this.pnlBackGreen);
            this.Controls.Add(this.pnlBackYellow);
            this.Controls.Add(this.pnlBackOrange);
            this.Controls.Add(this.pnlBackRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBorderWhite);
            this.Controls.Add(this.pnlBorderBlack);
            this.Controls.Add(this.pnlBorderPink);
            this.Controls.Add(this.pnlBorderBlue);
            this.Controls.Add(this.pnlBorderCyan);
            this.Controls.Add(this.pnlBorderGreen);
            this.Controls.Add(this.pnlBorderYellow);
            this.Controls.Add(this.pnlBorderOrange);
            this.Controls.Add(this.pnlBorderRed);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBackWhite;
        private System.Windows.Forms.Panel pnlBackBlack;
        private System.Windows.Forms.Panel pnlBackPink;
        private System.Windows.Forms.Panel pnlBackBlue;
        private System.Windows.Forms.Panel pnlBackCyan;
        private System.Windows.Forms.Panel pnlBackGreen;
        private System.Windows.Forms.Panel pnlBackYellow;
        private System.Windows.Forms.Panel pnlBackOrange;
        private System.Windows.Forms.Panel pnlBackRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlBorderWhite;
        private System.Windows.Forms.Panel pnlBorderBlack;
        private System.Windows.Forms.Panel pnlBorderPink;
        private System.Windows.Forms.Panel pnlBorderBlue;
        private System.Windows.Forms.Panel pnlBorderCyan;
        private System.Windows.Forms.Panel pnlBorderGreen;
        private System.Windows.Forms.Panel pnlBorderYellow;
        private System.Windows.Forms.Panel pnlBorderOrange;
        private System.Windows.Forms.Panel pnlBorderRed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFigures;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCurrentBackColor;
        private System.Windows.Forms.Panel pnlCurrentBorderColor;
        private System.Windows.Forms.Button btnDrawCoordinates;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

