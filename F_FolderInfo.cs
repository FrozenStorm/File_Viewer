using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileNameViewer
{
    public partial class F_FolderInfo : Form
    {
        DirectoryInfo FInfo;
        public F_FolderInfo(DirectoryInfo DI,long size)
        {
            this.DialogResult = DialogResult.Cancel;
            FInfo = DI;
            InitializeComponent();
            LB_Folderinfo.Items.Add("Name:\t\t\t" + FInfo.Name);
            LB_Folderinfo.Items.Add("Directory:\t\t\t" + FInfo.FullName + "                                 .");
            LB_Folderinfo.Items.Add("Size:\t\t\t" + size.ToString().PadLeft(12, '_').Insert(3, ",").Insert(7, ",").Insert(11, ",") + " Byte");
            LB_Folderinfo.Items.Add("Creation Time:\t\t" + FInfo.CreationTime);
            LB_Folderinfo.Items.Add("Last Access:\t\t" + FInfo.LastAccessTime);
            LB_Folderinfo.Items.Add("Last Write:\t\t" + FInfo.LastWriteTime);
        }

        private void B_Open_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(FInfo.FullName);
            }
            catch
            {
                MessageBox.Show("Öffnen nicht möglich");
            }
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == MessageBox.Show("Möchten Sie '" + FInfo.Name + "' wirklich löschen?", "Löschen", MessageBoxButtons.OKCancel))
                {

                    Directory.Delete(FInfo.FullName, true);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Löschen nicht möglich");
            }
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
