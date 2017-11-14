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
    public partial class F_FileInfo : Form
    {
        FileInfo FInfo;
        public F_FileInfo(FileInfo FI)
        {
            this.DialogResult = DialogResult.Cancel;
            FInfo = FI;
            InitializeComponent();
            LB_Fileinfo.Items.Add("Name:\t\t\t" + FInfo.Name);
            LB_Fileinfo.Items.Add("Directory:\t\t\t" + FInfo.DirectoryName + "                                 .");
            LB_Fileinfo.Items.Add("Size:\t\t\t" + FInfo.Length.ToString().PadLeft(12, '_').Insert(3, ",").Insert(7, ",").Insert(11, ",") + " Byte");
            LB_Fileinfo.Items.Add("Creation Time:\t\t" + FInfo.CreationTime);
            LB_Fileinfo.Items.Add("Last Access:\t\t" + FInfo.LastAccessTime);
            LB_Fileinfo.Items.Add("Last Write:\t\t" + FInfo.LastWriteTime);
            LB_Fileinfo.Items.Add("Is read only:\t\t" + FInfo.IsReadOnly);
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
                    File.Delete(FInfo.FullName);
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
