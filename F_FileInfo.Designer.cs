namespace FileNameViewer
{
    partial class F_FileInfo
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Fileinfo = new System.Windows.Forms.ListBox();
            this.B_Open = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Fileinfo
            // 
            this.LB_Fileinfo.FormattingEnabled = true;
            this.LB_Fileinfo.HorizontalScrollbar = true;
            this.LB_Fileinfo.Location = new System.Drawing.Point(12, 12);
            this.LB_Fileinfo.Name = "LB_Fileinfo";
            this.LB_Fileinfo.Size = new System.Drawing.Size(414, 147);
            this.LB_Fileinfo.TabIndex = 8;
            // 
            // B_Open
            // 
            this.B_Open.Location = new System.Drawing.Point(12, 180);
            this.B_Open.Name = "B_Open";
            this.B_Open.Size = new System.Drawing.Size(93, 35);
            this.B_Open.TabIndex = 9;
            this.B_Open.Text = "Open";
            this.B_Open.UseVisualStyleBackColor = true;
            this.B_Open.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.Location = new System.Drawing.Point(111, 181);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(93, 34);
            this.B_Delete.TabIndex = 10;
            this.B_Delete.Text = "Delete";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Close
            // 
            this.B_Close.Location = new System.Drawing.Point(333, 181);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(93, 34);
            this.B_Close.TabIndex = 11;
            this.B_Close.Text = "Close";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // F_FileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 227);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.B_Open);
            this.Controls.Add(this.LB_Fileinfo);
            this.MaximumSize = new System.Drawing.Size(446, 261);
            this.MinimumSize = new System.Drawing.Size(446, 261);
            this.Name = "F_FileInfo";
            this.Text = "FileInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Fileinfo;
        private System.Windows.Forms.Button B_Open;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Close;
    }
}