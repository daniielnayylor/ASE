namespace BugTracker
{
    partial class Form1
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
            this.txtbugID = new System.Windows.Forms.TextBox();
            this.txtbugType = new System.Windows.Forms.TextBox();
            this.txtcfName = new System.Windows.Forms.TextBox();
            this.txtmthdName = new System.Windows.Forms.TextBox();
            this.txtcbName = new System.Windows.Forms.TextBox();
            this.txtlineNumb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.removeID = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnAdd.Location = new System.Drawing.Point(110, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Report Bug";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxBugs
            // 
            this.lbxBugs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBugs.FormattingEnabled = true;
            this.lbxBugs.ItemHeight = 19;
            this.lbxBugs.Location = new System.Drawing.Point(372, 83);
            this.lbxBugs.Name = "lbxBugs";
            this.lbxBugs.Size = new System.Drawing.Size(248, 327);
            this.lbxBugs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bug Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "BugID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bug Type: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Class File Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Method Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Code Block: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.Location = new System.Drawing.Point(12, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Line Number: ";
            // 
            // txtbugID
            // 
            this.txtbugID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbugID.Location = new System.Drawing.Point(182, 83);
            this.txtbugID.Name = "txtbugID";
            this.txtbugID.Size = new System.Drawing.Size(180, 27);
            this.txtbugID.TabIndex = 9;
            // 
            // txtbugType
            // 
            this.txtbugType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbugType.Location = new System.Drawing.Point(182, 127);
            this.txtbugType.Name = "txtbugType";
            this.txtbugType.Size = new System.Drawing.Size(180, 27);
            this.txtbugType.TabIndex = 10;
            // 
            // txtcfName
            // 
            this.txtcfName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcfName.Location = new System.Drawing.Point(182, 175);
            this.txtcfName.Name = "txtcfName";
            this.txtcfName.Size = new System.Drawing.Size(180, 27);
            this.txtcfName.TabIndex = 11;
            // 
            // txtmthdName
            // 
            this.txtmthdName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmthdName.Location = new System.Drawing.Point(182, 219);
            this.txtmthdName.Name = "txtmthdName";
            this.txtmthdName.Size = new System.Drawing.Size(180, 27);
            this.txtmthdName.TabIndex = 12;
            // 
            // txtcbName
            // 
            this.txtcbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcbName.Location = new System.Drawing.Point(182, 265);
            this.txtcbName.Name = "txtcbName";
            this.txtcbName.Size = new System.Drawing.Size(180, 27);
            this.txtcbName.TabIndex = 13;
            // 
            // txtlineNumb
            // 
            this.txtlineNumb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlineNumb.Location = new System.Drawing.Point(182, 308);
            this.txtlineNumb.Name = "txtlineNumb";
            this.txtlineNumb.Size = new System.Drawing.Size(180, 27);
            this.txtlineNumb.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(143, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bug Tracker";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnRemove.Location = new System.Drawing.Point(148, 454);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 30);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove Bug";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Remove Bug: ";
            // 
            // removeID
            // 
            this.removeID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeID.Location = new System.Drawing.Point(148, 421);
            this.removeID.Name = "removeID";
            this.removeID.Size = new System.Drawing.Size(104, 27);
            this.removeID.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnEdit.Location = new System.Drawing.Point(230, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 30);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit Bug";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 496);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.removeID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtlineNumb);
            this.Controls.Add(this.txtcbName);
            this.Controls.Add(this.txtmthdName);
            this.Controls.Add(this.txtcfName);
            this.Controls.Add(this.txtbugType);
            this.Controls.Add(this.txtbugID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxBugs);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox txtbugID;
        private System.Windows.Forms.TextBox txtbugType;
        private System.Windows.Forms.TextBox txtcfName;
        private System.Windows.Forms.TextBox txtmthdName;
        private System.Windows.Forms.TextBox txtcbName;
        private System.Windows.Forms.TextBox txtlineNumb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox removeID;
        private System.Windows.Forms.Button btnEdit;
    }
}

