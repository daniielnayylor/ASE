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
            this.SuspendLayout();
            // 
            // txtcommentarchive
            // 
            this.txtcommentarchive.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtcommentarchive.Location = new System.Drawing.Point(200, 327);
            this.txtcommentarchive.Multiline = true;
            this.txtcommentarchive.Name = "txtcommentarchive";
            this.txtcommentarchive.Size = new System.Drawing.Size(180, 141);
            this.txtcommentarchive.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F);
            this.label16.Location = new System.Drawing.Point(30, 327);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 19);
            this.label16.TabIndex = 37;
            this.label16.Text = "Comments: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(161, 237);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 26);
            this.label15.TabIndex = 38;
            this.label15.Text = "Archive Bug";
            // 
            // txtArchive
            // 
            this.txtArchive.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchive.Location = new System.Drawing.Point(200, 275);
            this.txtArchive.Name = "txtArchive";
            this.txtArchive.Size = new System.Drawing.Size(180, 27);
            this.txtArchive.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "App Name: ";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnRemove.Location = new System.Drawing.Point(240, 484);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 30);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "Remove Bug";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // frmDeveloper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 555);
            this.Controls.Add(this.txtcommentarchive);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtArchive);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemove);
            this.Name = "frmDeveloper";
            this.Text = "frmDeveloper";
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
    }
}