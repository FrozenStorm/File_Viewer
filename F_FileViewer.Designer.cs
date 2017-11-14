namespace FileNameViewer
{
    partial class F_FileNameViewer
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
            this.TB_Pfad = new System.Windows.Forms.TextBox();
            this.L_Pfad = new System.Windows.Forms.Label();
            this.CB_UO_einbeziehen = new System.Windows.Forms.CheckBox();
            this.B_OrdnerSuchen = new System.Windows.Forms.Button();
            this.L_Suchstring = new System.Windows.Forms.Label();
            this.TB_Suchstring = new System.Windows.Forms.TextBox();
            this.B_FilesAnzeigen = new System.Windows.Forms.Button();
            this.LB_Filesname = new System.Windows.Forms.ListBox();
            this.LB_Foldername = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TB_Pfad
            // 
            this.TB_Pfad.Location = new System.Drawing.Point(44, 25);
            this.TB_Pfad.Name = "TB_Pfad";
            this.TB_Pfad.Size = new System.Drawing.Size(652, 20);
            this.TB_Pfad.TabIndex = 0;
            // 
            // L_Pfad
            // 
            this.L_Pfad.AutoSize = true;
            this.L_Pfad.Location = new System.Drawing.Point(41, 9);
            this.L_Pfad.Name = "L_Pfad";
            this.L_Pfad.Size = new System.Drawing.Size(29, 13);
            this.L_Pfad.TabIndex = 1;
            this.L_Pfad.Text = "Pfad";
            // 
            // CB_UO_einbeziehen
            // 
            this.CB_UO_einbeziehen.AutoSize = true;
            this.CB_UO_einbeziehen.Location = new System.Drawing.Point(310, 53);
            this.CB_UO_einbeziehen.Name = "CB_UO_einbeziehen";
            this.CB_UO_einbeziehen.Size = new System.Drawing.Size(158, 17);
            this.CB_UO_einbeziehen.TabIndex = 2;
            this.CB_UO_einbeziehen.Text = "Unterordner mit einbeziehen";
            this.CB_UO_einbeziehen.UseVisualStyleBackColor = true;
            // 
            // B_OrdnerSuchen
            // 
            this.B_OrdnerSuchen.Location = new System.Drawing.Point(702, 25);
            this.B_OrdnerSuchen.Name = "B_OrdnerSuchen";
            this.B_OrdnerSuchen.Size = new System.Drawing.Size(28, 20);
            this.B_OrdnerSuchen.TabIndex = 3;
            this.B_OrdnerSuchen.Text = "...";
            this.B_OrdnerSuchen.UseVisualStyleBackColor = true;
            this.B_OrdnerSuchen.Click += new System.EventHandler(this.B_OrdnerSuchen_Click);
            // 
            // L_Suchstring
            // 
            this.L_Suchstring.AutoSize = true;
            this.L_Suchstring.Location = new System.Drawing.Point(41, 64);
            this.L_Suchstring.Name = "L_Suchstring";
            this.L_Suchstring.Size = new System.Drawing.Size(57, 13);
            this.L_Suchstring.TabIndex = 4;
            this.L_Suchstring.Text = "Suchstring";
            // 
            // TB_Suchstring
            // 
            this.TB_Suchstring.Location = new System.Drawing.Point(44, 80);
            this.TB_Suchstring.Name = "TB_Suchstring";
            this.TB_Suchstring.Size = new System.Drawing.Size(652, 20);
            this.TB_Suchstring.TabIndex = 5;
            this.TB_Suchstring.Text = "*.*";
            // 
            // B_FilesAnzeigen
            // 
            this.B_FilesAnzeigen.Location = new System.Drawing.Point(307, 113);
            this.B_FilesAnzeigen.Name = "B_FilesAnzeigen";
            this.B_FilesAnzeigen.Size = new System.Drawing.Size(158, 42);
            this.B_FilesAnzeigen.TabIndex = 6;
            this.B_FilesAnzeigen.Text = "Files anzeigen";
            this.B_FilesAnzeigen.UseVisualStyleBackColor = true;
            this.B_FilesAnzeigen.Click += new System.EventHandler(this.B_FilesAnzeigen_Click);
            // 
            // LB_Filesname
            // 
            this.LB_Filesname.FormattingEnabled = true;
            this.LB_Filesname.HorizontalScrollbar = true;
            this.LB_Filesname.Location = new System.Drawing.Point(44, 170);
            this.LB_Filesname.Name = "LB_Filesname";
            this.LB_Filesname.Size = new System.Drawing.Size(340, 303);
            this.LB_Filesname.TabIndex = 7;
            this.LB_Filesname.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LB_Filesname_MouseDoubleClick);
            // 
            // LB_Foldername
            // 
            this.LB_Foldername.FormattingEnabled = true;
            this.LB_Foldername.HorizontalScrollbar = true;
            this.LB_Foldername.Location = new System.Drawing.Point(390, 170);
            this.LB_Foldername.Name = "LB_Foldername";
            this.LB_Foldername.Size = new System.Drawing.Size(340, 303);
            this.LB_Foldername.TabIndex = 8;
            this.LB_Foldername.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LB_Foldername_MouseDoubleClick);
            // 
            // F_FileNameViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 490);
            this.Controls.Add(this.LB_Foldername);
            this.Controls.Add(this.LB_Filesname);
            this.Controls.Add(this.B_FilesAnzeigen);
            this.Controls.Add(this.TB_Suchstring);
            this.Controls.Add(this.L_Suchstring);
            this.Controls.Add(this.B_OrdnerSuchen);
            this.Controls.Add(this.CB_UO_einbeziehen);
            this.Controls.Add(this.L_Pfad);
            this.Controls.Add(this.TB_Pfad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "F_FileNameViewer";
            this.Text = "FileViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Pfad;
        private System.Windows.Forms.Label L_Pfad;
        private System.Windows.Forms.CheckBox CB_UO_einbeziehen;
        private System.Windows.Forms.Button B_OrdnerSuchen;
        private System.Windows.Forms.Label L_Suchstring;
        private System.Windows.Forms.TextBox TB_Suchstring;
        private System.Windows.Forms.Button B_FilesAnzeigen;
        private System.Windows.Forms.ListBox LB_Filesname;
        private System.Windows.Forms.ListBox LB_Foldername;
    }
}

