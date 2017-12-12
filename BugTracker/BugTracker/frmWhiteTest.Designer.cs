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
            this.btnEdit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbxBugView = new System.Windows.Forms.ListBox();
            this.txtchoosebug = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnViewBug = new System.Windows.Forms.Button();
            this.lbxSimpleList = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtsimpleview = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbxSimpleView = new System.Windows.Forms.ListBox();
            this.btnSimpleView = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtcommentbug = new System.Windows.Forms.TextBox();
            this.txtcommentappname = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCommentBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAdd.Location = new System.Drawing.Point(110, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Report Bug";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxBugs
            // 
            this.lbxBugs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBugs.FormattingEnabled = true;
            this.lbxBugs.ItemHeight = 19;
            this.lbxBugs.Location = new System.Drawing.Point(705, 83);
            this.lbxBugs.Name = "lbxBugs";
            this.lbxBugs.Size = new System.Drawing.Size(262, 137);
            this.lbxBugs.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Simple Bug List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "App Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bug Type: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Class File Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Method Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Code Block: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.Location = new System.Drawing.Point(12, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Line Number: ";
            // 
            // txtAppName
            // 
            this.txtAppName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppName.Location = new System.Drawing.Point(182, 83);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(180, 27);
            this.txtAppName.TabIndex = 0;
            // 
            // txtbugType
            // 
            this.txtbugType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbugType.Location = new System.Drawing.Point(182, 127);
            this.txtbugType.Name = "txtbugType";
            this.txtbugType.Size = new System.Drawing.Size(180, 27);
            this.txtbugType.TabIndex = 1;
            // 
            // txtcfName
            // 
            this.txtcfName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfName.Location = new System.Drawing.Point(182, 175);
            this.txtcfName.Name = "txtcfName";
            this.txtcfName.Size = new System.Drawing.Size(180, 27);
            this.txtcfName.TabIndex = 2;
            // 
            // txtmthdName
            // 
            this.txtmthdName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmthdName.Location = new System.Drawing.Point(182, 219);
            this.txtmthdName.Name = "txtmthdName";
            this.txtmthdName.Size = new System.Drawing.Size(180, 27);
            this.txtmthdName.TabIndex = 3;
            // 
            // txtcbName
            // 
            this.txtcbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcbName.Location = new System.Drawing.Point(182, 265);
            this.txtcbName.Name = "txtcbName";
            this.txtcbName.Size = new System.Drawing.Size(180, 27);
            this.txtcbName.TabIndex = 4;
            // 
            // txtlineNumb
            // 
            this.txtlineNumb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlineNumb.Location = new System.Drawing.Point(182, 308);
            this.txtlineNumb.Name = "txtlineNumb";
            this.txtlineNumb.Size = new System.Drawing.Size(180, 27);
            this.txtlineNumb.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(143, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Bug Tracker";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEdit.Location = new System.Drawing.Point(230, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 30);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit Bug";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(742, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 26);
            this.label10.TabIndex = 31;
            this.label10.Text = "Advanced Bug List";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(727, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 26);
            this.label11.TabIndex = 34;
            this.label11.Text = "Advanced Bug View";
            // 
            // lbxBugView
            // 
            this.lbxBugView.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBugView.FormattingEnabled = true;
            this.lbxBugView.ItemHeight = 19;
            this.lbxBugView.Location = new System.Drawing.Point(705, 277);
            this.lbxBugView.Name = "lbxBugView";
            this.lbxBugView.Size = new System.Drawing.Size(262, 137);
            this.lbxBugView.TabIndex = 24;
            // 
            // txtchoosebug
            // 
            this.txtchoosebug.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtchoosebug.Location = new System.Drawing.Point(791, 430);
            this.txtchoosebug.Name = "txtchoosebug";
            this.txtchoosebug.Size = new System.Drawing.Size(176, 27);
            this.txtchoosebug.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F);
            this.label12.Location = new System.Drawing.Point(701, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "App Name: ";
            // 
            // btnViewBug
            // 
            this.btnViewBug.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnViewBug.Location = new System.Drawing.Point(791, 463);
            this.btnViewBug.Name = "btnViewBug";
            this.btnViewBug.Size = new System.Drawing.Size(104, 30);
            this.btnViewBug.TabIndex = 11;
            this.btnViewBug.Text = "View Bug";
            this.btnViewBug.UseVisualStyleBackColor = true;
            this.btnViewBug.Click += new System.EventHandler(this.btnViewBug_Click);
            // 
            // lbxSimpleList
            // 
            this.lbxSimpleList.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbxSimpleList.FormattingEnabled = true;
            this.lbxSimpleList.ItemHeight = 19;
            this.lbxSimpleList.Location = new System.Drawing.Point(422, 82);
            this.lbxSimpleList.Name = "lbxSimpleList";
            this.lbxSimpleList.Size = new System.Drawing.Size(262, 137);
            this.lbxSimpleList.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F);
            this.label13.Location = new System.Drawing.Point(418, 429);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "App Name: ";
            // 
            // txtsimpleview
            // 
            this.txtsimpleview.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtsimpleview.Location = new System.Drawing.Point(508, 430);
            this.txtsimpleview.Name = "txtsimpleview";
            this.txtsimpleview.Size = new System.Drawing.Size(176, 27);
            this.txtsimpleview.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(451, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 26);
            this.label14.TabIndex = 33;
            this.label14.Text = "Simple Bug View";
            // 
            // lbxSimpleView
            // 
            this.lbxSimpleView.Font = new System.Drawing.Font("Calibri", 12F);
            this.lbxSimpleView.FormattingEnabled = true;
            this.lbxSimpleView.ItemHeight = 19;
            this.lbxSimpleView.Location = new System.Drawing.Point(422, 277);
            this.lbxSimpleView.Name = "lbxSimpleView";
            this.lbxSimpleView.Size = new System.Drawing.Size(262, 137);
            this.lbxSimpleView.TabIndex = 22;
            // 
            // btnSimpleView
            // 
            this.btnSimpleView.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSimpleView.Location = new System.Drawing.Point(508, 463);
            this.btnSimpleView.Name = "btnSimpleView";
            this.btnSimpleView.Size = new System.Drawing.Size(104, 30);
            this.btnSimpleView.TabIndex = 9;
            this.btnSimpleView.Text = "View Bug";
            this.btnSimpleView.UseVisualStyleBackColor = true;
            this.btnSimpleView.Click += new System.EventHandler(this.btnSimpleView_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1144, 453);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 26);
            this.label17.TabIndex = 35;
            this.label17.Text = "Comment Bug";
            // 
            // txtcommentbug
            // 
            this.txtcommentbug.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtcommentbug.Location = new System.Drawing.Point(1103, 544);
            this.txtcommentbug.Multiline = true;
            this.txtcommentbug.Name = "txtcommentbug";
            this.txtcommentbug.Size = new System.Drawing.Size(262, 141);
            this.txtcommentbug.TabIndex = 36;
            // 
            // txtcommentappname
            // 
            this.txtcommentappname.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtcommentappname.Location = new System.Drawing.Point(1189, 492);
            this.txtcommentappname.Name = "txtcommentappname";
            this.txtcommentappname.Size = new System.Drawing.Size(176, 27);
            this.txtcommentappname.TabIndex = 37;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F);
            this.label18.Location = new System.Drawing.Point(1099, 500);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 19);
            this.label18.TabIndex = 38;
            this.label18.Text = "App Name: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F);
            this.label19.Location = new System.Drawing.Point(1177, 522);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 19);
            this.label19.TabIndex = 39;
            this.label19.Text = "Comments: ";
            // 
            // btnCommentBug
            // 
            this.btnCommentBug.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnCommentBug.Location = new System.Drawing.Point(1149, 690);
            this.btnCommentBug.Name = "btnCommentBug";
            this.btnCommentBug.Size = new System.Drawing.Size(130, 30);
            this.btnCommentBug.TabIndex = 40;
            this.btnCommentBug.Text = "Comment Bug";
            this.btnCommentBug.UseVisualStyleBackColor = true;
            this.btnCommentBug.Click += new System.EventHandler(this.btnCommentBug_Click);
            // 
            // frmWhiteTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 799);
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
            this.Controls.Add(this.btnViewBug);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtchoosebug);
            this.Controls.Add(this.lbxBugView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEdit);
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
            this.Name = "frmWhiteTest";
            this.Text = "1";
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
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbxBugView;
        private System.Windows.Forms.TextBox txtchoosebug;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnViewBug;
        private System.Windows.Forms.ListBox lbxSimpleList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtsimpleview;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbxSimpleView;
        private System.Windows.Forms.Button btnSimpleView;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtcommentbug;
        private System.Windows.Forms.TextBox txtcommentappname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCommentBug;
    }
}

