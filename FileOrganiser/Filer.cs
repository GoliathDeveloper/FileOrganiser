using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace FileOrganiser
{
    public partial class Filer : Form
    {
        public Filer()
        {

            InitializeComponent();


        }
        
        public void foreachfile()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(tBSource.Text);
            //System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(tBPath.Text);
            foreach (System.IO.FileInfo f in dir.GetFiles("*.*"))
            {
                //LOAD FILES 
                ListViewItem lSingleItem = listView1.Items.Add(f.Name);
                //SUB ITEMS 
                lSingleItem.SubItems.Add(Convert.ToString(f.Length));
                lSingleItem.SubItems.Add(f.Extension);
            }
        }

        public void foreachfolder()
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(tBSource.Text);
            //FIND ALL FOLDERS IN FOLDER 
            TreeNode Main = treeView1.Nodes.Add("Folders in: " + tBSource.Text);
            Main.Tag = "";
            foreach (System.IO.DirectoryInfo g in dir.GetDirectories())
            {
                //LOAD FOLDERS 
                TreeNode MainNext = Main.Nodes.Add(g.FullName);
                MainNext.Tag = (g.FullName);
            }
        }

        private void forBtn_Click(object sender, EventArgs e)
        {
            foreachfile();
        }

        private void btnFolders_Click(object sender, EventArgs e)
        {
            foreachfolder();
        }

        #region copyDirectory Not Working
        //public static void copyDirectory(string Src, string Dst)
        //{
        //    String[] Files;

        //    if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
        //        Dst += Path.DirectorySeparatorChar;
        //    if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
        //    Files = Directory.GetFileSystemEntries(Src);
        //    foreach (string Element in Files)
        //    {
        //        // Sub directories
        //        if (Directory.Exists(Element))
        //            copyDirectory(Element, Dst + Path.GetFileName(Element));
        //        // Files in directory
        //        else
        //            File.Copy(Element, Dst + Path.GetFileName(Element), true);
        //    }
        //}
        #endregion

        private void btnTest2_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList myfileexts = new ArrayList();
                #region if block for all check box's
                try
                {
                    if (chkBdll.Checked == true)
                    {
                        myfileexts.Add("*.dll");
                    }
                    if (chkBExe.Checked == true)
                    {
                        //need to change
                        myfileexts.Add("*.exe");
                        myfileexts.Add("*.msi");
                    }
                    if (chkBTxt.Checked == true)
                    {
                        myfileexts.Add("*.txt");
                        myfileexts.Add("*.doc");
                        myfileexts.Add("*.docx");
                        myfileexts.Add("*.rtf");
                        myfileexts.Add("*.chm");
                        myfileexts.Add("*.pdf");
                        myfileexts.Add("*.odt");
                        myfileexts.Add("*.fodt");
                        myfileexts.Add("*.File");
                    }
                    if (chkBxImages.Checked == true)
                    {
                        myfileexts.Add("*.jpg");
                        myfileexts.Add("*.bmp");
                        myfileexts.Add("*.gif");
                        myfileexts.Add("*.psd");
                        myfileexts.Add("*.png");
                        myfileexts.Add("*.xcf");
                    }
                    if (chkBxZR.Checked == true)
                    {
                        myfileexts.Add("*.zip");
                        myfileexts.Add("*.rar");
                        myfileexts.Add("*.tgz");
                        myfileexts.Add("*.tar.gz");
                        myfileexts.Add("*.iso");
                    }
                    if (chkBxTorrent.Checked == true)
                    {
                        myfileexts.Add("*.torrent");
                    }
                    if (chkBxHtml.Checked == true)
                    {
                        myfileexts.Add("*.html");
                        myfileexts.Add("*.htm");
                    }
                    if (chkBxMac.Checked == true)
                    {
                        myfileexts.Add("*.dmg");
                        myfileexts.Add("*.pkg");
                        myfileexts.Add("*.dpkg");
                    }
                    if (chkBxSS.Checked == true)
                    {
                        myfileexts.Add("*.xls");
                        myfileexts.Add("*.xlsx");
                        myfileexts.Add("*.ods");
                        myfileexts.Add("*.fods");
                    }
                    if (chkBxShortCuts.Checked == true)
                    {
                        myfileexts.Add("*.lnk");
                    }
                    if (chkBxCSharp.Checked == true)
                    {
                        myfileexts.Add("*.cs");
                    }
                }
                catch
                {
                    MessageBox.Show("Error On Adding files to Array");
                }
                #endregion
                ArrayList myfileinfos = new ArrayList();
                DirectoryInfo di = new DirectoryInfo(tBSource.Text);

                #region Copy
                try
                {
                    if (rBCopy.Checked == true)
                    {
                        foreach (string ext in myfileexts)
                        {
                            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(tBSource.Text);
                            myfileinfos.AddRange(di.GetFiles(ext));
                            foreach (System.IO.FileInfo f in dir.GetFiles(ext))
                            {
                                string fileName = f.ToString();
                                string sourcePath = tBSource.Text;
                                string targetPath = tBTarget.Text;

                                // Use Path class to manipulate file and directory paths. 
                                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                                string destFile = System.IO.Path.Combine(targetPath, fileName);

                                #region document regex cluster
                                Regex regex = new Regex("(.*?)\\.(txt|docx|doc|pdf|chm)$");
                                Match match = regex.Match(f.ToString());
                                if (match.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Documents", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region dll cluster
                                Regex regex2 = new Regex("(.*?)\\.(dll)$");
                                Match match2 = regex2.Match(f.ToString());
                                if (match2.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Dlls", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region Exe cluster
                                Regex regexExe = new Regex("(.*?)\\.(exe|msi)$");
                                Match matchExe = regexExe.Match(f.ToString());
                                if (matchExe.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Installers", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region Mac cluster
                                Regex regexMac = new Regex("(.*?)\\.(dmg|pkg|dpkg)$");
                                Match matchMac = regexMac.Match(f.ToString());
                                if (matchMac.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Mac", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region Image cluster
                                Regex regexImg = new Regex("(.*?)\\.(jpg|bmp|png|gif|tiff|psd|xcf)$");
                                Match matchImg = regexImg.Match(f.ToString());
                                if (matchImg.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Images", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region Zip/Rars & Iso cluster
                                Regex regexZR = new Regex("(.*?)\\.(zip|rar|tar.gz|tgz|iso)$");
                                Match matchZR = regexZR.Match(f.ToString());
                                if (matchZR.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Archives", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region Torrent cluster
                                Regex regexTorrent = new Regex("(.*?)\\.(torrent)$");
                                Match matchTorrent = regexTorrent.Match(f.ToString());
                                if (matchTorrent.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Torrent", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region Html cluster
                                Regex regexHtml = new Regex("(.*?)\\.(html|htm)$");
                                Match matchHtml = regexHtml.Match(f.ToString());
                                if (matchHtml.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Html", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region SpreadSheets cluster
                                Regex regexSS = new Regex("(.*?)\\.(xls|xlsx|ods|fods)$");
                                Match matchSS = regexSS.Match(f.ToString());
                                if (matchSS.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\SpreadSheets", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Copy(sourceFile, NewFileDest, true);
                                }
                                #endregion

                                #region ShortCut cluster
                                Regex regexShortCuts = new Regex("(.*?)\\.(lnk)$");
                                Match matchShortCuts = regexShortCuts.Match(f.ToString());
                                if (matchShortCuts.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\ShortCuts", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Csharp cluster
                                Regex regexCsharp = new Regex("(.*?)\\.(cs|asp|aspx)$");
                                Match matchCsharp = regexCsharp.Match(f.ToString());
                                if (matchCsharp.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Csharp", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Copy Subfolders
                                string NewSubFolder = (string.Format("{0}\\Folders", targetPath));
                                if (!System.IO.Directory.Exists(NewSubFolder))
                                {
                                    System.IO.Directory.CreateDirectory(NewSubFolder);
                                    System.IO.DirectoryInfo Source = new System.IO.DirectoryInfo(tBSource.Text);
                                    System.IO.DirectoryInfo Target = new System.IO.DirectoryInfo(NewSubFolder);
                                    CopyAll(Source, Target);
                                }
                                #endregion
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error on Copy Function");
                }
                #endregion

                #region Move
                try
                {
                    if (rBMove.Checked == true)
                    {
                        foreach (string ext in myfileexts)
                        {
                            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(tBSource.Text);
                            myfileinfos.AddRange(di.GetFiles(ext));
                            foreach (System.IO.FileInfo f in dir.GetFiles(ext))
                            {
                                string fileName = f.ToString();
                                string sourcePath = tBSource.Text;
                                string targetPath = tBTarget.Text;

                                // Use Path class to manipulate file and directory paths. 
                                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                                string destFile = System.IO.Path.Combine(targetPath, fileName);

                                #region document regex cluster
                                Regex regex = new Regex("(.*?)\\.(txt|docx|doc|pdf|chm)$");
                                Match match = regex.Match(f.ToString());
                                if (match.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Documents", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region dll cluster
                                Regex regex2 = new Regex("(.*?)\\.(dll)$");
                                Match match2 = regex2.Match(f.ToString());
                                if (match2.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Dlls", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Exe cluster
                                Regex regexExe = new Regex("(.*?)\\.(exe|msi)$");
                                Match matchExe = regexExe.Match(f.ToString());
                                if (matchExe.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Installers", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Mac cluster
                                Regex regexMac = new Regex("(.*?)\\.(dmg|pkg|dpkg)$");
                                Match matchMac = regexMac.Match(f.ToString());
                                if (matchMac.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Mac", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Image cluster
                                Regex regexImg = new Regex("(.*?)\\.(jpg|bmp|png|gif|tiff|psd|xcf)$");
                                Match matchImg = regexImg.Match(f.ToString());
                                if (matchImg.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Images", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Zip & Rars cluster
                                Regex regexZR = new Regex("(.*?)\\.(zip|rar|tar.gz|tgz|iso)$");
                                Match matchZR = regexZR.Match(f.ToString());
                                if (matchZR.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Archives", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Torrent cluster
                                Regex regexTorrent = new Regex("(.*?)\\.(torrent)$");
                                Match matchTorrent = regexTorrent.Match(f.ToString());
                                if (matchTorrent.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Torrent", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Html cluster
                                Regex regexHtml = new Regex("(.*?)\\.(html|htm)$");
                                Match matchHtml = regexHtml.Match(f.ToString());
                                if (matchHtml.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Html", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region SpreadSheets cluster
                                Regex regexSS = new Regex("(.*?)\\.(xls|xlsx|ods|fods)$");
                                Match matchSS = regexSS.Match(f.ToString());
                                if (matchSS.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\SpreadSheets", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region ShortCut cluster
                                Regex regexShortCuts = new Regex("(.*?)\\.(lnk)$");
                                Match matchShortCuts = regexShortCuts.Match(f.ToString());
                                if (matchShortCuts.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\ShortCuts", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Csharp cluster
                                Regex regexCsharp = new Regex("(.*?)\\.(cs|asp|aspx)$");
                                Match matchCsharp = regexCsharp.Match(f.ToString());
                                if (matchCsharp.Success)
                                {
                                    string NewtargetPath = (string.Format("{0}\\Csharp", targetPath));
                                    if (!System.IO.Directory.Exists(NewtargetPath))
                                    {
                                        System.IO.Directory.CreateDirectory(NewtargetPath);
                                    }
                                    string NewFileDest = System.IO.Path.Combine(NewtargetPath, fileName);
                                    System.IO.File.Move(sourceFile, NewFileDest);
                                }
                                #endregion

                                #region Move Subfolders
                                string NewSubFolder = (string.Format("{0}\\Folders", targetPath));
                                if (!System.IO.Directory.Exists(NewSubFolder))
                                {
                                    System.IO.Directory.CreateDirectory(NewSubFolder);
                                    System.IO.DirectoryInfo Source = new System.IO.DirectoryInfo(tBSource.Text);
                                    System.IO.DirectoryInfo Target = new System.IO.DirectoryInfo(NewSubFolder);
                                    MoveAll(Source, Target);
                                }
                                #endregion
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error on Move Function");
                }
                #endregion

                if(rBCopy.Checked == false && rBMove.Checked == false)
                {
                    MessageBox.Show("Please Choose Copy or Move");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Detected");
                throw new Exception (String.Format("Exception Detected: {0}",ex.Message));
            }
        }

        private void btnMvFolder_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo Source = new System.IO.DirectoryInfo(tBSource.Text);
                System.IO.DirectoryInfo Target = new System.IO.DirectoryInfo(tBTarget.Text);
                CopyAll(Source, Target);
            }
            catch
            {
                MessageBox.Show("Error on Move Button");
            }
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                // Check if the target directory exists, if not, create it.
                if (Directory.Exists(target.FullName) == false)
                {
                    Directory.CreateDirectory(target.FullName);
                }

                // Copy each file into it’s new directory.
                //foreach (FileInfo fi in source.GetFiles())
                //{
                //    Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                //    fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
                //}

                // Copy each subdirectory using recursion.
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        target.CreateSubdirectory(diSourceSubDir.Name);
                    //CopyAll(diSourceSubDir, nextTargetSubDir);
                    CopySubFiles(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Copying Files Error: " + ex.Message);
            }
        }

        public static void CopySubFiles(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                foreach (FileInfo fi in source.GetFiles())
                {
                    Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                    fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Copying Sub-Files: " + ex.Message);
            }
        }

        public static void MoveAll(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                // Check if the target directory exists, if not, create it.
                if (Directory.Exists(target.FullName) == false)
                {
                    Directory.CreateDirectory(target.FullName);
                }
                foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
                {
                    diSourceSubDir.MoveTo(Path.Combine(target.FullName, diSourceSubDir.Name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                //throw new Exception(String.Format("Move All Files Exception Detected: {0}",ex.Message));
            }
        }

        public static void MoveSubFiles(DirectoryInfo source, DirectoryInfo target)
        {
            try
            {
                foreach (FileInfo fi in source.GetFiles())
                {
                    MessageBox.Show(String.Format(@"Moving {0}\{1}", target.FullName, fi.Name));
                    fi.MoveTo(Path.Combine(target.ToString(), fi.Name));
                }
            }
            catch (Exception ex)
            {
                //throw new Exception(String.Format("Moving Sub-Folders Exception Detected: {0}", ex.Message));
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #region Browsers
        private void btnSrcBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    tBSource.Text = folderBrowserDialog1.SelectedPath;
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }

        private void btnTarBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
                    tBTarget.Text = folderBrowserDialog2.SelectedPath;
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error: " + Error.Message);
            }
        }
        #endregion
    }
}