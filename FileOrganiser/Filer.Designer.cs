namespace FileOrganiser
{
    partial class Filer
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
            this.tBSource = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.forBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnFolders = new System.Windows.Forms.Button();
            this.tBTarget = new System.Windows.Forms.TextBox();
            this.gBApps = new System.Windows.Forms.GroupBox();
            this.chkBxMac = new System.Windows.Forms.CheckBox();
            this.chkBxDB = new System.Windows.Forms.CheckBox();
            this.chkBxSS = new System.Windows.Forms.CheckBox();
            this.chkBxHtml = new System.Windows.Forms.CheckBox();
            this.chkBxTorrent = new System.Windows.Forms.CheckBox();
            this.chkBxZR = new System.Windows.Forms.CheckBox();
            this.chkBxImages = new System.Windows.Forms.CheckBox();
            this.chkBdll = new System.Windows.Forms.CheckBox();
            this.chkBTxt = new System.Windows.Forms.CheckBox();
            this.chkBExe = new System.Windows.Forms.CheckBox();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnMvFolder = new System.Windows.Forms.Button();
            this.btnSrcBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnTarBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBxCopyorMove = new System.Windows.Forms.GroupBox();
            this.rBMove = new System.Windows.Forms.RadioButton();
            this.rBCopy = new System.Windows.Forms.RadioButton();
            this.chkBxShortCuts = new System.Windows.Forms.CheckBox();
            this.chkBxCSharp = new System.Windows.Forms.CheckBox();
            this.gBApps.SuspendLayout();
            this.grpBxCopyorMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBSource
            // 
            this.tBSource.Location = new System.Drawing.Point(13, 32);
            this.tBSource.Name = "tBSource";
            this.tBSource.Size = new System.Drawing.Size(100, 20);
            this.tBSource.TabIndex = 0;
            this.tBSource.Text = "c:\\test1";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(228, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(162, 236);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // forBtn
            // 
            this.forBtn.Location = new System.Drawing.Point(13, 59);
            this.forBtn.Name = "forBtn";
            this.forBtn.Size = new System.Drawing.Size(75, 23);
            this.forBtn.TabIndex = 2;
            this.forBtn.Text = "Files";
            this.forBtn.UseVisualStyleBackColor = true;
            this.forBtn.Click += new System.EventHandler(this.forBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(396, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(207, 236);
            this.treeView1.TabIndex = 3;
            // 
            // btnFolders
            // 
            this.btnFolders.Location = new System.Drawing.Point(13, 89);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Size = new System.Drawing.Size(75, 23);
            this.btnFolders.TabIndex = 4;
            this.btnFolders.Text = "Folders";
            this.btnFolders.UseVisualStyleBackColor = true;
            this.btnFolders.Click += new System.EventHandler(this.btnFolders_Click);
            // 
            // tBTarget
            // 
            this.tBTarget.Location = new System.Drawing.Point(13, 133);
            this.tBTarget.Name = "tBTarget";
            this.tBTarget.Size = new System.Drawing.Size(100, 20);
            this.tBTarget.TabIndex = 5;
            this.tBTarget.Text = "c:\\test2";
            // 
            // gBApps
            // 
            this.gBApps.Controls.Add(this.chkBxCSharp);
            this.gBApps.Controls.Add(this.chkBxShortCuts);
            this.gBApps.Controls.Add(this.chkBxMac);
            this.gBApps.Controls.Add(this.chkBxDB);
            this.gBApps.Controls.Add(this.chkBxSS);
            this.gBApps.Controls.Add(this.chkBxHtml);
            this.gBApps.Controls.Add(this.chkBxTorrent);
            this.gBApps.Controls.Add(this.chkBxZR);
            this.gBApps.Controls.Add(this.chkBxImages);
            this.gBApps.Controls.Add(this.chkBdll);
            this.gBApps.Controls.Add(this.chkBTxt);
            this.gBApps.Controls.Add(this.chkBExe);
            this.gBApps.Location = new System.Drawing.Point(609, 13);
            this.gBApps.Name = "gBApps";
            this.gBApps.Size = new System.Drawing.Size(241, 130);
            this.gBApps.TabIndex = 7;
            this.gBApps.TabStop = false;
            this.gBApps.Text = "Application Extensions";
            // 
            // chkBxMac
            // 
            this.chkBxMac.AutoSize = true;
            this.chkBxMac.Checked = true;
            this.chkBxMac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxMac.Location = new System.Drawing.Point(114, 83);
            this.chkBxMac.Name = "chkBxMac";
            this.chkBxMac.Size = new System.Drawing.Size(47, 17);
            this.chkBxMac.TabIndex = 17;
            this.chkBxMac.Text = "Mac";
            this.chkBxMac.UseVisualStyleBackColor = true;
            // 
            // chkBxDB
            // 
            this.chkBxDB.AutoSize = true;
            this.chkBxDB.Checked = true;
            this.chkBxDB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxDB.Location = new System.Drawing.Point(114, 67);
            this.chkBxDB.Name = "chkBxDB";
            this.chkBxDB.Size = new System.Drawing.Size(78, 17);
            this.chkBxDB.TabIndex = 20;
            this.chkBxDB.Text = "DataBases";
            this.chkBxDB.UseVisualStyleBackColor = true;
            // 
            // chkBxSS
            // 
            this.chkBxSS.AutoSize = true;
            this.chkBxSS.Checked = true;
            this.chkBxSS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxSS.Location = new System.Drawing.Point(114, 51);
            this.chkBxSS.Name = "chkBxSS";
            this.chkBxSS.Size = new System.Drawing.Size(93, 17);
            this.chkBxSS.TabIndex = 19;
            this.chkBxSS.Text = "SpreadSheets";
            this.chkBxSS.UseVisualStyleBackColor = true;
            // 
            // chkBxHtml
            // 
            this.chkBxHtml.AutoSize = true;
            this.chkBxHtml.Checked = true;
            this.chkBxHtml.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxHtml.Location = new System.Drawing.Point(7, 35);
            this.chkBxHtml.Name = "chkBxHtml";
            this.chkBxHtml.Size = new System.Drawing.Size(47, 17);
            this.chkBxHtml.TabIndex = 18;
            this.chkBxHtml.Text = "Html";
            this.chkBxHtml.UseVisualStyleBackColor = true;
            // 
            // chkBxTorrent
            // 
            this.chkBxTorrent.AutoSize = true;
            this.chkBxTorrent.Checked = true;
            this.chkBxTorrent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxTorrent.Location = new System.Drawing.Point(114, 19);
            this.chkBxTorrent.Name = "chkBxTorrent";
            this.chkBxTorrent.Size = new System.Drawing.Size(60, 17);
            this.chkBxTorrent.TabIndex = 17;
            this.chkBxTorrent.Text = "Torrent";
            this.chkBxTorrent.UseVisualStyleBackColor = true;
            // 
            // chkBxZR
            // 
            this.chkBxZR.AutoSize = true;
            this.chkBxZR.Checked = true;
            this.chkBxZR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxZR.Location = new System.Drawing.Point(7, 83);
            this.chkBxZR.Name = "chkBxZR";
            this.chkBxZR.Size = new System.Drawing.Size(86, 17);
            this.chkBxZR.TabIndex = 4;
            this.chkBxZR.Text = "Archive Files";
            this.chkBxZR.UseVisualStyleBackColor = true;
            // 
            // chkBxImages
            // 
            this.chkBxImages.AutoSize = true;
            this.chkBxImages.Checked = true;
            this.chkBxImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxImages.Location = new System.Drawing.Point(6, 67);
            this.chkBxImages.Name = "chkBxImages";
            this.chkBxImages.Size = new System.Drawing.Size(60, 17);
            this.chkBxImages.TabIndex = 3;
            this.chkBxImages.Text = "Images";
            this.chkBxImages.UseVisualStyleBackColor = true;
            // 
            // chkBdll
            // 
            this.chkBdll.AutoSize = true;
            this.chkBdll.Checked = true;
            this.chkBdll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBdll.Location = new System.Drawing.Point(6, 51);
            this.chkBdll.Name = "chkBdll";
            this.chkBdll.Size = new System.Drawing.Size(38, 17);
            this.chkBdll.TabIndex = 2;
            this.chkBdll.Text = "Dll";
            this.chkBdll.UseVisualStyleBackColor = true;
            // 
            // chkBTxt
            // 
            this.chkBTxt.AutoSize = true;
            this.chkBTxt.Checked = true;
            this.chkBTxt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBTxt.Location = new System.Drawing.Point(114, 35);
            this.chkBTxt.Name = "chkBTxt";
            this.chkBTxt.Size = new System.Drawing.Size(80, 17);
            this.chkBTxt.TabIndex = 1;
            this.chkBTxt.Text = "Documents";
            this.chkBTxt.UseVisualStyleBackColor = true;
            // 
            // chkBExe
            // 
            this.chkBExe.AutoSize = true;
            this.chkBExe.Checked = true;
            this.chkBExe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBExe.Location = new System.Drawing.Point(6, 19);
            this.chkBExe.Name = "chkBExe";
            this.chkBExe.Size = new System.Drawing.Size(84, 17);
            this.chkBExe.TabIndex = 0;
            this.chkBExe.Text = "Executables";
            this.chkBExe.UseVisualStyleBackColor = true;
            // 
            // tBSearch
            // 
            this.tBSearch.Location = new System.Drawing.Point(13, 190);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.Size = new System.Drawing.Size(100, 20);
            this.tBSearch.TabIndex = 8;
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(16, 217);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 9;
            this.btnTest2.Text = "Submit";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnMvFolder
            // 
            this.btnMvFolder.Location = new System.Drawing.Point(120, 217);
            this.btnMvFolder.Name = "btnMvFolder";
            this.btnMvFolder.Size = new System.Drawing.Size(75, 23);
            this.btnMvFolder.TabIndex = 11;
            this.btnMvFolder.Text = "Test Folder 2";
            this.btnMvFolder.UseVisualStyleBackColor = true;
            this.btnMvFolder.Visible = false;
            this.btnMvFolder.Click += new System.EventHandler(this.btnMvFolder_Click);
            // 
            // btnSrcBrowse
            // 
            this.btnSrcBrowse.Location = new System.Drawing.Point(120, 32);
            this.btnSrcBrowse.Name = "btnSrcBrowse";
            this.btnSrcBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSrcBrowse.TabIndex = 12;
            this.btnSrcBrowse.Text = "Browse";
            this.btnSrcBrowse.UseVisualStyleBackColor = true;
            this.btnSrcBrowse.Click += new System.EventHandler(this.btnSrcBrowse_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Browse for a Directory";
            // 
            // btnTarBrowse
            // 
            this.btnTarBrowse.Location = new System.Drawing.Point(120, 133);
            this.btnTarBrowse.Name = "btnTarBrowse";
            this.btnTarBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnTarBrowse.TabIndex = 13;
            this.btnTarBrowse.Text = "Browse";
            this.btnTarBrowse.UseVisualStyleBackColor = true;
            this.btnTarBrowse.Click += new System.EventHandler(this.btnTarBrowse_Click);
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.Description = "Browse for a Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Target";
            // 
            // grpBxCopyorMove
            // 
            this.grpBxCopyorMove.Controls.Add(this.rBMove);
            this.grpBxCopyorMove.Controls.Add(this.rBCopy);
            this.grpBxCopyorMove.Location = new System.Drawing.Point(616, 149);
            this.grpBxCopyorMove.Name = "grpBxCopyorMove";
            this.grpBxCopyorMove.Size = new System.Drawing.Size(70, 73);
            this.grpBxCopyorMove.TabIndex = 16;
            this.grpBxCopyorMove.TabStop = false;
            this.grpBxCopyorMove.Text = "Copy or Move";
            // 
            // rBMove
            // 
            this.rBMove.AutoSize = true;
            this.rBMove.Checked = true;
            this.rBMove.Location = new System.Drawing.Point(7, 49);
            this.rBMove.Name = "rBMove";
            this.rBMove.Size = new System.Drawing.Size(52, 17);
            this.rBMove.TabIndex = 1;
            this.rBMove.TabStop = true;
            this.rBMove.Text = "Move";
            this.rBMove.UseVisualStyleBackColor = true;
            // 
            // rBCopy
            // 
            this.rBCopy.AutoSize = true;
            this.rBCopy.Location = new System.Drawing.Point(7, 28);
            this.rBCopy.Name = "rBCopy";
            this.rBCopy.Size = new System.Drawing.Size(49, 17);
            this.rBCopy.TabIndex = 0;
            this.rBCopy.Text = "Copy";
            this.rBCopy.UseVisualStyleBackColor = true;
            // 
            // chkBxShortCuts
            // 
            this.chkBxShortCuts.AutoSize = true;
            this.chkBxShortCuts.Checked = true;
            this.chkBxShortCuts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxShortCuts.Location = new System.Drawing.Point(7, 101);
            this.chkBxShortCuts.Name = "chkBxShortCuts";
            this.chkBxShortCuts.Size = new System.Drawing.Size(72, 17);
            this.chkBxShortCuts.TabIndex = 21;
            this.chkBxShortCuts.Text = "ShortCuts";
            this.chkBxShortCuts.UseVisualStyleBackColor = true;
            // 
            // chkBxCSharp
            // 
            this.chkBxCSharp.AutoSize = true;
            this.chkBxCSharp.Checked = true;
            this.chkBxCSharp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxCSharp.Location = new System.Drawing.Point(114, 101);
            this.chkBxCSharp.Name = "chkBxCSharp";
            this.chkBxCSharp.Size = new System.Drawing.Size(100, 17);
            this.chkBxCSharp.TabIndex = 22;
            this.chkBxCSharp.Text = "C# Project Files";
            this.chkBxCSharp.UseVisualStyleBackColor = true;
            // 
            // Filer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 294);
            this.Controls.Add(this.grpBxCopyorMove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTarBrowse);
            this.Controls.Add(this.btnSrcBrowse);
            this.Controls.Add(this.btnMvFolder);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.gBApps);
            this.Controls.Add(this.tBTarget);
            this.Controls.Add(this.btnFolders);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.forBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tBSource);
            this.Name = "Filer";
            this.Text = "Filer";
            this.gBApps.ResumeLayout(false);
            this.gBApps.PerformLayout();
            this.grpBxCopyorMove.ResumeLayout(false);
            this.grpBxCopyorMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBSource;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button forBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnFolders;
        private System.Windows.Forms.TextBox tBTarget;
        private System.Windows.Forms.GroupBox gBApps;
        private System.Windows.Forms.CheckBox chkBExe;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.CheckBox chkBTxt;
        private System.Windows.Forms.CheckBox chkBdll;
        private System.Windows.Forms.CheckBox chkBxImages;
        private System.Windows.Forms.Button btnMvFolder;
        private System.Windows.Forms.Button btnSrcBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnTarBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBxZR;
        private System.Windows.Forms.GroupBox grpBxCopyorMove;
        private System.Windows.Forms.RadioButton rBMove;
        private System.Windows.Forms.RadioButton rBCopy;
        private System.Windows.Forms.CheckBox chkBxTorrent;
        private System.Windows.Forms.CheckBox chkBxHtml;
        private System.Windows.Forms.CheckBox chkBxSS;
        private System.Windows.Forms.CheckBox chkBxDB;
        private System.Windows.Forms.CheckBox chkBxMac;
        private System.Windows.Forms.CheckBox chkBxShortCuts;
        private System.Windows.Forms.CheckBox chkBxCSharp;
    }
}

