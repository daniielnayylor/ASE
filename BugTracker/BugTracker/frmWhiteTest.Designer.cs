namespace BugTracker
{
    partial class frmWhiteTest
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbxBugs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.txtbugType = new System.Windows.Forms.TextBox();
            this.txtcfName = new System.Windows.Forms.TextBox();
            this.txtmthdName = new System.Windows.Forms.TextBox();
            this.txtcbName = new System.Windows.Forms.TextBox();
            this.txtlineNumb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbxBugView = new System.Windows.Forms.ListBox();
            this.lbxSimpleList = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbxSimpleView = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtcommentbug = new System.Windows.Forms.TextBox();
            this.txtcommentappname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCommentBug = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditBug = new System.Windows.Forms.Button();
            this.txtSourceCodeView = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtsimpleview = new System.Windows.Forms.TextBox();
            this.btnSimpleView = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSourceCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AllowDrop = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAdd.Location = new System.Drawing.Point(182, 808);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Report Bug";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxBugs
            // 
            this.lbxBugs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbxBugs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxBugs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBugs.FormattingEnabled = true;
            this.lbxBugs.HorizontalScrollbar = true;
            this.lbxBugs.ItemHeight = 19;
            this.lbxBugs.Location = new System.Drawing.Point(705, 95);
            this.lbxBugs.Name = "lbxBugs";
            this.lbxBugs.Size = new System.Drawing.Size(262, 380);
            this.lbxBugs.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Simple Bug List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "App Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bug Type: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Class File Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(12, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Method Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.Location = new System.Drawing.Point(12, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Code Block: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.Location = new System.Drawing.Point(12, 527);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Line Number: ";
            // 
            // txtAppName
            // 
            this.txtAppName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAppName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAppName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppName.Location = new System.Drawing.Point(182, 97);
            this.txtAppName.Multiline = true;
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(180, 80);
            this.txtAppName.TabIndex = 0;
            // 
            // txtbugType
            // 
            this.txtbugType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtbugType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbugType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbugType.Location = new System.Drawing.Point(182, 183);
            this.txtbugType.Multiline = true;
            this.txtbugType.Name = "txtbugType";
            this.txtbugType.Size = new System.Drawing.Size(180, 80);
            this.txtbugType.TabIndex = 1;
            // 
            // txtcfName
            // 
            this.txtcfName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcfName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcfName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfName.Location = new System.Drawing.Point(182, 269);
            this.txtcfName.Multiline = true;
            this.txtcfName.Name = "txtcfName";
            this.txtcfName.Size = new System.Drawing.Size(180, 80);
            this.txtcfName.TabIndex = 2;
            // 
            // txtmthdName
            // 
            this.txtmthdName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtmthdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmthdName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmthdName.Location = new System.Drawing.Point(182, 355);
            this.txtmthdName.Multiline = true;
            this.txtmthdName.Name = "txtmthdName";
            this.txtmthdName.Size = new System.Drawing.Size(180, 80);
            this.txtmthdName.TabIndex = 3;
            // 
            // txtcbName
            // 
            this.txtcbName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcbName.Location = new System.Drawing.Point(182, 441);
            this.txtcbName.Multiline = true;
            this.txtcbName.Name = "txtcbName";
            this.txtcbName.Size = new System.Drawing.Size(180, 80);
            this.txtcbName.TabIndex = 4;
            // 
            // txtlineNumb
            // 
            this.txtlineNumb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtlineNumb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlineNumb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlineNumb.Location = new System.Drawing.Point(182, 527);
            this.txtlineNumb.Multiline = true;
            this.txtlineNumb.Name = "txtlineNumb";
            this.txtlineNumb.Size = new System.Drawing.Size(180, 80);
            this.txtlineNumb.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Bug Tracker - White Tester";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(742, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 26);
            this.label10.TabIndex = 31;
            this.label10.Text = "Advanced Bug List";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(742, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 26);
            this.label11.TabIndex = 34;
            this.label11.Text = "Advanced Bug View";
            // 
            // lbxBugView
            // 
            this.lbxBugView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbxBugView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxBugView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBugView.FormattingEnabled = true;
            this.lbxBugView.HorizontalScrollbar = true;
            this.lbxBugView.ItemHeight = 19;
            this.lbxBugView.Location = new System.Drawing.Point(717, 550);
            this.lbxBugView.Name = "lbxBugView";
            this.lbxBugView.Size = new System.Drawing.Size(262, 247);
            this.lbxBugView.TabIndex = 24;
            // 
            // lbxSimpleList
            // 
            this.lbxSimpleList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbxSimpleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxSimpleList.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbxSimpleList.FormattingEnabled = true;
            this.lbxSimpleList.HorizontalScrollbar = true;
            this.lbxSimpleList.ItemHeight = 19;
            this.lbxSimpleList.Location = new System.Drawing.Point(422, 98);
            this.lbxSimpleList.Name = "lbxSimpleList";
            this.lbxSimpleList.Size = new System.Drawing.Size(262, 380);
            this.lbxSimpleList.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(466, 515);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 26);
            this.label14.TabIndex = 33;
            this.label14.Text = "Simple Bug View";
            // 
            // lbxSimpleView
            // 
            this.lbxSimpleView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbxSimpleView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxSimpleView.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbxSimpleView.FormattingEnabled = true;
            this.lbxSimpleView.HorizontalScrollbar = true;
            this.lbxSimpleView.ItemHeight = 19;
            this.lbxSimpleView.Location = new System.Drawing.Point(423, 546);
            this.lbxSimpleView.Name = "lbxSimpleView";
            this.lbxSimpleView.Size = new System.Drawing.Size(262, 247);
            this.lbxSimpleView.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1067, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 26);
            this.label17.TabIndex = 35;
            this.label17.Text = "Comment Bug";
            // 
            // txtcommentbug
            // 
            this.txtcommentbug.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcommentbug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcommentbug.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtcommentbug.Location = new System.Drawing.Point(1008, 211);
            this.txtcommentbug.Multiline = true;
            this.txtcommentbug.Name = "txtcommentbug";
            this.txtcommentbug.Size = new System.Drawing.Size(262, 258);
            this.txtcommentbug.TabIndex = 36;
            // 
            // txtcommentappname
            // 
            this.txtcommentappname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcommentappname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcommentappname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtcommentappname.Location = new System.Drawing.Point(1008, 128);
            this.txtcommentappname.Multiline = true;
            this.txtcommentappname.Name = "txtcommentappname";
            this.txtcommentappname.Size = new System.Drawing.Size(262, 46);
            this.txtcommentappname.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F);
            this.label18.Location = new System.Drawing.Point(1098, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 19);
            this.label18.TabIndex = 38;
            this.label18.Text = "App Name: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F);
            this.label19.Location = new System.Drawing.Point(1098, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 19);
            this.label19.TabIndex = 39;
            this.label19.Text = "Comments: ";
            // 
            // btnCommentBug
            // 
            this.btnCommentBug.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCommentBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommentBug.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCommentBug.Location = new System.Drawing.Point(1072, 475);
            this.btnCommentBug.Name = "btnCommentBug";
            this.btnCommentBug.Size = new System.Drawing.Size(130, 30);
            this.btnCommentBug.TabIndex = 40;
            this.btnCommentBug.Text = "Comment Bug";
            this.btnCommentBug.UseVisualStyleBackColor = false;
            this.btnCommentBug.Click += new System.EventHandler(this.btnCommentBug_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(217, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 26);
            this.label9.TabIndex = 41;
            this.label9.Text = "Bug Detials";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 27);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.restoreToolStripMenuItem,
            this.minimizedToolStripMenuItem,
            this.maximizedToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // minimizedToolStripMenuItem
            // 
            this.minimizedToolStripMenuItem.Name = "minimizedToolStripMenuItem";
            this.minimizedToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.minimizedToolStripMenuItem.Text = "Minimize";
            this.minimizedToolStripMenuItem.Click += new System.EventHandler(this.minimizedToolStripMenuItem_Click);
            // 
            // maximizedToolStripMenuItem
            // 
            this.maximizedToolStripMenuItem.Name = "maximizedToolStripMenuItem";
            this.maximizedToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.maximizedToolStripMenuItem.Text = "Maximize";
            this.maximizedToolStripMenuItem.Click += new System.EventHandler(this.maximizedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btnEditBug
            // 
            this.btnEditBug.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBug.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEditBug.Location = new System.Drawing.Point(182, 844);
            this.btnEditBug.Name = "btnEditBug";
            this.btnEditBug.Size = new System.Drawing.Size(180, 30);
            this.btnEditBug.TabIndex = 47;
            this.btnEditBug.Text = "Edit Bug";
            this.btnEditBug.UseVisualStyleBackColor = false;
            this.btnEditBug.Click += new System.EventHandler(this.btnEditBug_Click);
            // 
            // txtSourceCodeView
            // 
            this.txtSourceCodeView.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSourceCodeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSourceCodeView.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSourceCodeView.Location = new System.Drawing.Point(1008, 550);
            this.txtSourceCodeView.Multiline = true;
            this.txtSourceCodeView.Name = "txtSourceCodeView";
            this.txtSourceCodeView.Size = new System.Drawing.Size(262, 324);
            this.txtSourceCodeView.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F);
            this.label13.Location = new System.Drawing.Point(559, 814);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "App Name: ";
            // 
            // txtsimpleview
            // 
            this.txtsimpleview.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtsimpleview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsimpleview.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtsimpleview.Location = new System.Drawing.Point(649, 814);
            this.txtsimpleview.Name = "txtsimpleview";
            this.txtsimpleview.Size = new System.Drawing.Size(176, 20);
            this.txtsimpleview.TabIndex = 8;
            // 
            // btnSimpleView
            // 
            this.btnSimpleView.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSimpleView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpleView.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSimpleView.Location = new System.Drawing.Point(628, 844);
            this.btnSimpleView.Name = "btnSimpleView";
            this.btnSimpleView.Size = new System.Drawing.Size(176, 30);
            this.btnSimpleView.TabIndex = 9;
            this.btnSimpleView.Text = "View Bug";
            this.btnSimpleView.UseVisualStyleBackColor = false;
            this.btnSimpleView.Click += new System.EventHandler(this.btnSimpleView_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1046, 519);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 26);
            this.label12.TabIndex = 49;
            this.label12.Text = "View Source Code";
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtSourceCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSourceCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSourceCode.Location = new System.Drawing.Point(182, 613);
            this.txtSourceCode.Multiline = true;
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.Size = new System.Drawing.Size(180, 189);
            this.txtSourceCode.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F);
            this.label15.Location = new System.Drawing.Point(12, 613);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 19);
            this.label15.TabIndex = 51;
            this.label15.Text = "Source Control: ";
            // 
            // frmWhiteTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1288, 889);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSourceCodeView);
            this.Controls.Add(this.btnEditBug);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCommentBug);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtcommentappname);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtcommentbug);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnSimpleView);
            this.Controls.Add(this.lbxSimpleView);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtsimpleview);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbxSimpleList);
            this.Controls.Add(this.lbxBugView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtlineNumb);
            this.Controls.Add(this.txtcbName);
            this.Controls.Add(this.txtmthdName);
            this.Controls.Add(this.txtcfName);
            this.Controls.Add(this.txtbugType);
            this.Controls.Add(this.txtAppName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxBugs);
            this.Controls.Add(this.btnAdd);
            this.HelpButton = true;
            this.Name = "frmWhiteTest";
            this.Text = "Bug Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbxBugs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.TextBox txtbugType;
        private System.Windows.Forms.TextBox txtcfName;
        private System.Windows.Forms.TextBox txtmthdName;
        private System.Windows.Forms.TextBox txtcbName;
        private System.Windows.Forms.TextBox txtlineNumb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbxBugView;
        private System.Windows.Forms.ListBox lbxSimpleList;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbxSimpleView;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtcommentbug;
        private System.Windows.Forms.TextBox txtcommentappname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCommentBug;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEditBug;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizedToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSourceCodeView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtsimpleview;
        private System.Windows.Forms.Button btnSimpleView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSourceCode;
        private System.Windows.Forms.Label label15;
    }
}

