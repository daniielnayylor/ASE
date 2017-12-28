namespace BugTracker
{
    partial class frmDeveloper
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
            this.txtcommentarchive = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtArchive = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCommentBug = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtcommentappname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtcommentbug = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lbxBugList = new System.Windows.Forms.ListBox();
            this.lbxCommentList = new System.Windows.Forms.ListBox();
            this.lbxArchiveList = new System.Windows.Forms.ListBox();
            this.btnBugList = new System.Windows.Forms.Button();
            this.txtBugList = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnArchiveList = new System.Windows.Forms.Button();
            this.txtArchiveList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCommentList = new System.Windows.Forms.Button();
            this.txtCommentList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcommentarchive
            // 
            this.txtcommentarchive.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcommentarchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcommentarchive.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtcommentarchive.Location = new System.Drawing.Point(605, 607);
            this.txtcommentarchive.Multiline = true;
            this.txtcommentarchive.Name = "txtcommentarchive";
            this.txtcommentarchive.Size = new System.Drawing.Size(262, 258);
            this.txtcommentarchive.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F);
            this.label16.Location = new System.Drawing.Point(336, 573);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 19);
            this.label16.TabIndex = 37;
            this.label16.Text = "Comments: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(673, 466);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 26);
            this.label15.TabIndex = 38;
            this.label15.Text = "Archive Bug";
            // 
            // txtArchive
            // 
            this.txtArchive.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtArchive.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArchive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchive.Location = new System.Drawing.Point(604, 524);
            this.txtArchive.Multiline = true;
            this.txtArchive.Name = "txtArchive";
            this.txtArchive.Size = new System.Drawing.Size(263, 46);
            this.txtArchive.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(336, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "App Name: ";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnRemove.Location = new System.Drawing.Point(678, 871);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 30);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "Remove Bug";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 29);
            this.label8.TabIndex = 39;
            this.label8.Text = "Bug Tracker - Developer";
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
            this.menuStrip1.Size = new System.Drawing.Size(1044, 27);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.minimizedToolStripMenuItem,
            this.maximizedToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // btnCommentBug
            // 
            this.btnCommentBug.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCommentBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommentBug.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCommentBug.Location = new System.Drawing.Point(331, 871);
            this.btnCommentBug.Name = "btnCommentBug";
            this.btnCommentBug.Size = new System.Drawing.Size(130, 30);
            this.btnCommentBug.TabIndex = 52;
            this.btnCommentBug.Text = "Comment Bug";
            this.btnCommentBug.UseVisualStyleBackColor = false;
            this.btnCommentBug.Click += new System.EventHandler(this.btnCommentBug_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F);
            this.label19.Location = new System.Drawing.Point(694, 573);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 19);
            this.label19.TabIndex = 51;
            this.label19.Text = "Comments: ";
            // 
            // txtcommentappname
            // 
            this.txtcommentappname.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcommentappname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcommentappname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtcommentappname.Location = new System.Drawing.Point(262, 524);
            this.txtcommentappname.Multiline = true;
            this.txtcommentappname.Name = "txtcommentappname";
            this.txtcommentappname.Size = new System.Drawing.Size(262, 46);
            this.txtcommentappname.TabIndex = 49;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F);
            this.label18.Location = new System.Drawing.Point(694, 494);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 19);
            this.label18.TabIndex = 50;
            this.label18.Text = "App Name: ";
            // 
            // txtcommentbug
            // 
            this.txtcommentbug.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtcommentbug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcommentbug.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtcommentbug.Location = new System.Drawing.Point(262, 607);
            this.txtcommentbug.Multiline = true;
            this.txtcommentbug.Name = "txtcommentbug";
            this.txtcommentbug.Size = new System.Drawing.Size(262, 258);
            this.txtcommentbug.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(314, 466);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 26);
            this.label17.TabIndex = 47;
            this.label17.Text = "Comment Bug";
            // 
            // lbxBugList
            // 
            this.lbxBugList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbxBugList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxBugList.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbxBugList.FormattingEnabled = true;
            this.lbxBugList.HorizontalScrollbar = true;
            this.lbxBugList.ItemHeight = 19;
            this.lbxBugList.Location = new System.Drawing.Point(78, 135);
            this.lbxBugList.Name = "lbxBugList";
            this.lbxBugList.Size = new System.Drawing.Size(262, 247);
            this.lbxBugList.TabIndex = 53;
            // 
            // lbxCommentList
            // 
            this.lbxCommentList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbxCommentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxCommentList.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbxCommentList.FormattingEnabled = true;
            this.lbxCommentList.HorizontalScrollbar = true;
            this.lbxCommentList.ItemHeight = 19;
            this.lbxCommentList.Location = new System.Drawing.Point(396, 135);
            this.lbxCommentList.Name = "lbxCommentList";
            this.lbxCommentList.Size = new System.Drawing.Size(262, 247);
            this.lbxCommentList.TabIndex = 54;
            // 
            // lbxArchiveList
            // 
            this.lbxArchiveList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbxArchiveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxArchiveList.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbxArchiveList.FormattingEnabled = true;
            this.lbxArchiveList.HorizontalScrollbar = true;
            this.lbxArchiveList.ItemHeight = 19;
            this.lbxArchiveList.Location = new System.Drawing.Point(708, 135);
            this.lbxArchiveList.Name = "lbxArchiveList";
            this.lbxArchiveList.Size = new System.Drawing.Size(262, 247);
            this.lbxArchiveList.TabIndex = 55;
            // 
            // btnBugList
            // 
            this.btnBugList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBugList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBugList.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnBugList.Location = new System.Drawing.Point(165, 422);
            this.btnBugList.Name = "btnBugList";
            this.btnBugList.Size = new System.Drawing.Size(104, 30);
            this.btnBugList.TabIndex = 57;
            this.btnBugList.Text = "View Bug";
            this.btnBugList.UseVisualStyleBackColor = false;
            this.btnBugList.Click += new System.EventHandler(this.btnBugList_Click);
            // 
            // txtBugList
            // 
            this.txtBugList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBugList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBugList.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBugList.Location = new System.Drawing.Point(165, 389);
            this.txtBugList.Name = "txtBugList";
            this.txtBugList.Size = new System.Drawing.Size(176, 20);
            this.txtBugList.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F);
            this.label13.Location = new System.Drawing.Point(75, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 58;
            this.label13.Text = "App Name: ";
            // 
            // btnArchiveList
            // 
            this.btnArchiveList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnArchiveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveList.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnArchiveList.Location = new System.Drawing.Point(795, 421);
            this.btnArchiveList.Name = "btnArchiveList";
            this.btnArchiveList.Size = new System.Drawing.Size(104, 30);
            this.btnArchiveList.TabIndex = 60;
            this.btnArchiveList.Text = "View Bug";
            this.btnArchiveList.UseVisualStyleBackColor = false;
            this.btnArchiveList.Click += new System.EventHandler(this.btnArchiveList_Click);
            // 
            // txtArchiveList
            // 
            this.txtArchiveList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtArchiveList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArchiveList.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtArchiveList.Location = new System.Drawing.Point(795, 388);
            this.txtArchiveList.Name = "txtArchiveList";
            this.txtArchiveList.Size = new System.Drawing.Size(176, 20);
            this.txtArchiveList.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(705, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "App Name: ";
            // 
            // btnCommentList
            // 
            this.btnCommentList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCommentList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommentList.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCommentList.Location = new System.Drawing.Point(483, 422);
            this.btnCommentList.Name = "btnCommentList";
            this.btnCommentList.Size = new System.Drawing.Size(104, 30);
            this.btnCommentList.TabIndex = 63;
            this.btnCommentList.Text = "View Bug";
            this.btnCommentList.UseVisualStyleBackColor = false;
            this.btnCommentList.Click += new System.EventHandler(this.btnCommentList_Click);
            // 
            // txtCommentList
            // 
            this.txtCommentList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCommentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommentList.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtCommentList.Location = new System.Drawing.Point(483, 389);
            this.txtCommentList.Name = "txtCommentList";
            this.txtCommentList.Size = new System.Drawing.Size(176, 20);
            this.txtCommentList.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(393, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "App Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 65;
            this.label3.Text = "Archive List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 26);
            this.label4.TabIndex = 66;
            this.label4.Text = "Comment List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 67;
            this.label5.Text = "Bug List";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click_1);
            // 
            // minimizedToolStripMenuItem
            // 
            this.minimizedToolStripMenuItem.Name = "minimizedToolStripMenuItem";
            this.minimizedToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.minimizedToolStripMenuItem.Text = "Minimize";
            this.minimizedToolStripMenuItem.Click += new System.EventHandler(this.minimizedToolStripMenuItem_Click);
            // 
            // maximizedToolStripMenuItem
            // 
            this.maximizedToolStripMenuItem.Name = "maximizedToolStripMenuItem";
            this.maximizedToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.maximizedToolStripMenuItem.Text = "Maximize";
            this.maximizedToolStripMenuItem.Click += new System.EventHandler(this.maximizedToolStripMenuItem_Click);
            // 
            // frmDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1044, 909);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCommentList);
            this.Controls.Add(this.txtCommentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnArchiveList);
            this.Controls.Add(this.txtArchiveList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBugList);
            this.Controls.Add(this.txtBugList);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbxArchiveList);
            this.Controls.Add(this.lbxCommentList);
            this.Controls.Add(this.lbxBugList);
            this.Controls.Add(this.btnCommentBug);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtcommentappname);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtcommentbug);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcommentarchive);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtArchive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemove);
            this.Name = "frmDeveloper";
            this.Text = "Bug Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcommentarchive;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtArchive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnCommentBug;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtcommentappname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtcommentbug;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lbxBugList;
        private System.Windows.Forms.ListBox lbxCommentList;
        private System.Windows.Forms.ListBox lbxArchiveList;
        private System.Windows.Forms.Button btnBugList;
        private System.Windows.Forms.TextBox txtBugList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnArchiveList;
        private System.Windows.Forms.TextBox txtArchiveList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommentList;
        private System.Windows.Forms.TextBox txtCommentList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizedToolStripMenuItem;
    }
}