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
    public partial class F_FileNameViewer : Form
    {
        FolderBrowserDialog F_OrdnerSuchen;
        DirectoryInfo di;
        List<FileInfo> L_Fileinfo = new List<FileInfo>();
        List<DirectoryInfo> L_Folderinfo = new List<DirectoryInfo>();
        List<long> L_FolderSize = new List<long>();


        public F_FileNameViewer()
        {
            InitializeComponent();
            F_OrdnerSuchen = new FolderBrowserDialog();
        }

        private void B_OrdnerSuchen_Click(object sender, EventArgs e)
        {
            if (F_OrdnerSuchen.ShowDialog() == DialogResult.OK)
            {
                TB_Pfad.Text = F_OrdnerSuchen.SelectedPath;
            }
        }

        private void B_FilesAnzeigen_Click(object sender, EventArgs e)
        {
            Files();
            Folder();
        }
        private void Files()
        {
            L_Fileinfo.Clear();
            LB_Filesname.Items.Clear();
            try
            {
                di = new DirectoryInfo(@TB_Pfad.Text);
                if (CB_UO_einbeziehen.Checked == true)
                {
                    L_Fileinfo = di.GetFiles(TB_Suchstring.Text, SearchOption.AllDirectories).ToList();
                }
                else
                {
                    L_Fileinfo = di.GetFiles(TB_Suchstring.Text, SearchOption.TopDirectoryOnly).ToList();
                }
                sort_files();
                int Anzahlfiles = L_Fileinfo.IndexOf(L_Fileinfo.Last<FileInfo>());
                LB_Filesname.Items.Add("___________Byte \t\tFilename");
                LB_Filesname.Items.Add("");
                for (int i = 0; i <= Anzahlfiles; i++)
                {
                    LB_Filesname.Items.Add(L_Fileinfo[i].Length.ToString().PadLeft(12, '_').Insert(3, ",").Insert(7, ",").Insert(11, ",") + "\t\t" + L_Fileinfo[i].Name);
                }
            }
            catch
            {
                TB_Pfad.Text = "Ungültiger Pfad";
            }
        }
        private void Folder2()
        {
            LB_Foldername.Items.Clear();
            L_Folderinfo.Clear();
            L_FolderSize.Clear();
            try
            {
                int Anzahlfiles = L_Fileinfo.IndexOf(L_Fileinfo.Last<FileInfo>());
                for (int i = 0; i <= Anzahlfiles; i++)
                {
                    if (L_Folderinfo.Contains(L_Fileinfo[i].Directory) == false)
                    {
                        L_Folderinfo.Add(L_Fileinfo[i].Directory);
                        L_FolderSize.Add(L_Fileinfo[i].Length);
                    }
                    else
                    {
                        L_FolderSize[L_Folderinfo.IndexOf(L_Fileinfo[i].Directory)] += L_Fileinfo[i].Length;
                    }
                }
                sort_folder();
                int Anzahlfolder = L_Folderinfo.IndexOf(L_Folderinfo.Last<DirectoryInfo>());
                LB_Foldername.Items.Add("___________Byte \t\tFoldername");
                LB_Foldername.Items.Add("");
                for (int i = 0; i <= Anzahlfolder; i++)
                {
                    LB_Foldername.Items.Add(L_FolderSize[i].ToString().PadLeft(12, '_').Insert(3, ",").Insert(7, ",").Insert(11, ",") + "\t\t" + L_Folderinfo[i].Name);
                }
            }
            catch
            {
                TB_Pfad.Text = "Ungültiger Pfad";
            }
        }
        private void Folder()
        {
            LB_Foldername.Items.Clear();
            L_Folderinfo.Clear();
            L_FolderSize.Clear();
            try
            {
                di = new DirectoryInfo(@TB_Pfad.Text);
                if (CB_UO_einbeziehen.Checked == true)
                {
                    L_Folderinfo = di.GetDirectories("*.*", SearchOption.AllDirectories).ToList();
                }
                else
                {
                    L_Folderinfo = di.GetDirectories("*.*", SearchOption.TopDirectoryOnly).ToList();
                }
                foreach (DirectoryInfo dinfo in L_Folderinfo)
                {
                    long size = 0;
                    foreach (FileInfo fi in dinfo.GetFiles(TB_Suchstring.Text, SearchOption.AllDirectories))
                    {
                        size += fi.Length;
                    }
                    L_FolderSize.Add(size);
                }
                sort_folder();
                int Anzahlfolder = L_Folderinfo.IndexOf(L_Folderinfo.Last<DirectoryInfo>());
                LB_Foldername.Items.Add("___________Byte \t\tFoldername");
                LB_Foldername.Items.Add("");
                for (int i = 0; i <= Anzahlfolder; i++)
                {
                    LB_Foldername.Items.Add(L_FolderSize[i].ToString().PadLeft(12, '_').Insert(3, ",").Insert(7, ",").Insert(11, ",") + "\t\t" + L_Folderinfo[i].Name);
                }
            }
            catch
            {
                TB_Pfad.Text = "Ungültiger Pfad";
            }
        }
        private void sort_files()
        {
            FileInfo change;
            int Anzahlfiles = L_Fileinfo.IndexOf(L_Fileinfo.Last<FileInfo>());
            for (int x = 1; x <= Anzahlfiles+1; x++)
            {
                for (int i = 0; i <= Anzahlfiles - x; i++)
                {
                    if (L_Fileinfo[i].Length < L_Fileinfo[i + 1].Length)
                    {
                        change = L_Fileinfo[i];
                        L_Fileinfo[i] = L_Fileinfo[i + 1];
                        L_Fileinfo[i + 1] = change;
                    }
                }
            }
        }
        private void sort_folder()
        {
            long changeSize;
            DirectoryInfo changeDirectory;
            int Anzahlfolder = L_Folderinfo.IndexOf(L_Folderinfo.Last<DirectoryInfo>());
            for (int x = 1; x <= Anzahlfolder+1; x++)
            {
                for (int i = 0; i <= Anzahlfolder - x; i++)
                {
                    if (L_FolderSize[i] < L_FolderSize[i + 1])
                    {
                        changeSize = L_FolderSize[i];
                        L_FolderSize[i] = L_FolderSize[i + 1];
                        L_FolderSize[i + 1] = changeSize;

                        changeDirectory = L_Folderinfo[i];
                        L_Folderinfo[i] = L_Folderinfo[i + 1];
                        L_Folderinfo[i + 1] = changeDirectory;
                    }
                }
            }
        }
        private void LB_Filesname_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LB_Filesname.SelectedIndex > 1)
            {
                F_FileInfo F_Info = new F_FileInfo(L_Fileinfo[LB_Filesname.SelectedIndex - 2]);
                if (DialogResult.OK == F_Info.ShowDialog())
                {
                    L_Fileinfo.RemoveAt(LB_Filesname.SelectedIndex - 2);
                    LB_Filesname.Items.RemoveAt(LB_Filesname.SelectedIndex);
                    Folder();
                }
            }
        }

        private void LB_Foldername_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LB_Foldername.SelectedIndex > 1)
            {
                F_FolderInfo F_Info = new F_FolderInfo(L_Folderinfo[LB_Foldername.SelectedIndex - 2], L_FolderSize[LB_Foldername.SelectedIndex - 2]);
                if (DialogResult.OK == F_Info.ShowDialog())
                {
                    L_Folderinfo.RemoveAt(LB_Foldername.SelectedIndex - 2);
                    L_FolderSize.RemoveAt(LB_Foldername.SelectedIndex - 2);
                    LB_Foldername.Items.RemoveAt(LB_Foldername.SelectedIndex);
                    Files();
                }
            }
        }


    }
}
