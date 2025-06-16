namespace AltCommander
{
    partial class DirectorySelectDialog
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
            this.components = new System.ComponentModel.Container();
            this.labelCurrentDrive = new System.Windows.Forms.Label();
            this.labelFreeSpace = new System.Windows.Forms.Label();
            this.treeViewDirectories = new System.Windows.Forms.TreeView();
            this.imageListDirectories = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.textBoxSelectedPath = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreateDirectory = new System.Windows.Forms.Button();
            this.groupBoxFavorites = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFav1 = new System.Windows.Forms.Button();
            this.buttonFav2 = new System.Windows.Forms.Button();
            this.buttonFav3 = new System.Windows.Forms.Button();
            this.buttonFav4 = new System.Windows.Forms.Button();
            this.buttonFav5 = new System.Windows.Forms.Button();
            this.buttonFav6 = new System.Windows.Forms.Button();
            this.buttonFav7 = new System.Windows.Forms.Button();
            this.buttonFav8 = new System.Windows.Forms.Button();
            this.buttonFav9 = new System.Windows.Forms.Button();
            this.checkBoxSelectAndClose = new System.Windows.Forms.CheckBox();
            this.buttonJump = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonSystem = new System.Windows.Forms.Button();
            this.groupBoxFile.SuspendLayout();
            this.groupBoxFavorites.SuspendLayout();
            this.flowLayoutPanelFavorites.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentDrive
            // 
            this.labelCurrentDrive.AutoSize = true;
            this.labelCurrentDrive.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentDrive.Name = "labelCurrentDrive";
            this.labelCurrentDrive.Size = new System.Drawing.Size(34, 18);
            this.labelCurrentDrive.TabIndex = 0;
            this.labelCurrentDrive.Text = "C:¥";
            // 
            // labelFreeSpace
            // 
            this.labelFreeSpace.AutoSize = true;
            this.labelFreeSpace.Location = new System.Drawing.Point(12, 31);
            this.labelFreeSpace.Name = "labelFreeSpace";
            this.labelFreeSpace.Size = new System.Drawing.Size(152, 18);
            this.labelFreeSpace.TabIndex = 1;
            this.labelFreeSpace.Text = "0 KBytes Free";
            // 
            // treeViewDirectories
            // 
            this.treeViewDirectories.HideSelection = false;
            this.treeViewDirectories.ImageIndex = 0;
            this.treeViewDirectories.ImageList = this.imageListDirectories;
            this.treeViewDirectories.Location = new System.Drawing.Point(12, 58);
            this.treeViewDirectories.Name = "treeViewDirectories";
            this.treeViewDirectories.SelectedImageIndex = 0;
            this.treeViewDirectories.ShowNodeToolTips = true;
            this.treeViewDirectories.Size = new System.Drawing.Size(450, 380);
            this.treeViewDirectories.TabIndex = 2;
            this.treeViewDirectories.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDirectories_BeforeExpand);
            this.treeViewDirectories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDirectories_AfterSelect);
            // 
            // imageListDirectories
            // 
            this.imageListDirectories.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListDirectories.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListDirectories.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.textBoxSelectedPath);
            this.groupBoxFile.Location = new System.Drawing.Point(478, 52);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(310, 58);
            this.groupBoxFile.TabIndex = 3;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "・選択パス(E)";
            // 
            // textBoxSelectedPath
            // 
            this.textBoxSelectedPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectedPath.Location = new System.Drawing.Point(6, 25);
            this.textBoxSelectedPath.Name = "textBoxSelectedPath";
            this.textBoxSelectedPath.Size = new System.Drawing.Size(298, 25);
            this.textBoxSelectedPath.TabIndex = 0;
            this.textBoxSelectedPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSelectedPath_KeyDown);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(478, 128);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 35);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(638, 128);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 35);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "キャンセル(&C)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDirectory
            // 
            this.buttonCreateDirectory.Location = new System.Drawing.Point(478, 178);
            this.buttonCreateDirectory.Name = "buttonCreateDirectory";
            this.buttonCreateDirectory.Size = new System.Drawing.Size(310, 35);
            this.buttonCreateDirectory.TabIndex = 6;
            this.buttonCreateDirectory.Text = "ディレクトリ作成(&K)";
            this.buttonCreateDirectory.UseVisualStyleBackColor = true;
            this.buttonCreateDirectory.Click += new System.EventHandler(this.buttonCreateDirectory_Click);
            // 
            // groupBoxFavorites
            // 
            this.groupBoxFavorites.Controls.Add(this.flowLayoutPanelFavorites);
            this.groupBoxFavorites.Location = new System.Drawing.Point(12, 444);
            this.groupBoxFavorites.Name = "groupBoxFavorites";
            this.groupBoxFavorites.Size = new System.Drawing.Size(450, 70);
            this.groupBoxFavorites.TabIndex = 7;
            this.groupBoxFavorites.TabStop = false;
            this.groupBoxFavorites.Text = "・よく使うディレクトリ";
            // 
            // flowLayoutPanelFavorites
            // 
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav1);
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav2);
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav3);
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav4);
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav5);
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav6);
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav7);
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav8);
            this.flowLayoutPanelFavorites.Controls.Add(this.buttonFav9);
            this.flowLayoutPanelFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFavorites.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanelFavorites.Name = "flowLayoutPanelFavorites";
            this.flowLayoutPanelFavorites.Size = new System.Drawing.Size(444, 46);
            this.flowLayoutPanelFavorites.TabIndex = 0;
            // 
            // buttonFav1
            // 
            this.buttonFav1.Location = new System.Drawing.Point(3, 3);
            this.buttonFav1.Name = "buttonFav1";
            this.buttonFav1.Size = new System.Drawing.Size(40, 35);
            this.buttonFav1.TabIndex = 0;
            this.buttonFav1.Text = "1";
            this.buttonFav1.UseVisualStyleBackColor = true;
            this.buttonFav1.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonFav2
            // 
            this.buttonFav2.Location = new System.Drawing.Point(49, 3);
            this.buttonFav2.Name = "buttonFav2";
            this.buttonFav2.Size = new System.Drawing.Size(40, 35);
            this.buttonFav2.TabIndex = 1;
            this.buttonFav2.Text = "2";
            this.buttonFav2.UseVisualStyleBackColor = true;
            this.buttonFav2.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonFav3
            // 
            this.buttonFav3.Location = new System.Drawing.Point(95, 3);
            this.buttonFav3.Name = "buttonFav3";
            this.buttonFav3.Size = new System.Drawing.Size(40, 35);
            this.buttonFav3.TabIndex = 2;
            this.buttonFav3.Text = "3";
            this.buttonFav3.UseVisualStyleBackColor = true;
            this.buttonFav3.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonFav4
            // 
            this.buttonFav4.Location = new System.Drawing.Point(141, 3);
            this.buttonFav4.Name = "buttonFav4";
            this.buttonFav4.Size = new System.Drawing.Size(40, 35);
            this.buttonFav4.TabIndex = 3;
            this.buttonFav4.Text = "4";
            this.buttonFav4.UseVisualStyleBackColor = true;
            this.buttonFav4.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonFav5
            // 
            this.buttonFav5.Location = new System.Drawing.Point(187, 3);
            this.buttonFav5.Name = "buttonFav5";
            this.buttonFav5.Size = new System.Drawing.Size(40, 35);
            this.buttonFav5.TabIndex = 4;
            this.buttonFav5.Text = "5";
            this.buttonFav5.UseVisualStyleBackColor = true;
            this.buttonFav5.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonFav6
            // 
            this.buttonFav6.Location = new System.Drawing.Point(233, 3);
            this.buttonFav6.Name = "buttonFav6";
            this.buttonFav6.Size = new System.Drawing.Size(40, 35);
            this.buttonFav6.TabIndex = 5;
            this.buttonFav6.Text = "6";
            this.buttonFav6.UseVisualStyleBackColor = true;
            this.buttonFav6.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonFav7
            // 
            this.buttonFav7.Location = new System.Drawing.Point(279, 3);
            this.buttonFav7.Name = "buttonFav7";
            this.buttonFav7.Size = new System.Drawing.Size(40, 35);
            this.buttonFav7.TabIndex = 6;
            this.buttonFav7.Text = "7";
            this.buttonFav7.UseVisualStyleBackColor = true;
            this.buttonFav7.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonFav8
            // 
            this.buttonFav8.Location = new System.Drawing.Point(325, 3);
            this.buttonFav8.Name = "buttonFav8";
            this.buttonFav8.Size = new System.Drawing.Size(40, 35);
            this.buttonFav8.TabIndex = 7;
            this.buttonFav8.Text = "8";
            this.buttonFav8.UseVisualStyleBackColor = true;
            this.buttonFav8.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // buttonFav9
            // 
            this.buttonFav9.Location = new System.Drawing.Point(371, 3);
            this.buttonFav9.Name = "buttonFav9";
            this.buttonFav9.Size = new System.Drawing.Size(40, 35);
            this.buttonFav9.TabIndex = 8;
            this.buttonFav9.Text = "9";
            this.buttonFav9.UseVisualStyleBackColor = true;
            this.buttonFav9.Click += new System.EventHandler(this.buttonFav_Click);
            // 
            // checkBoxSelectAndClose
            // 
            this.checkBoxSelectAndClose.AutoSize = true;
            this.checkBoxSelectAndClose.Location = new System.Drawing.Point(15, 528);
            this.checkBoxSelectAndClose.Name = "checkBoxSelectAndClose";
            this.checkBoxSelectAndClose.Size = new System.Drawing.Size(249, 22);
            this.checkBoxSelectAndClose.TabIndex = 8;
            this.checkBoxSelectAndClose.Text = "下のボタンで選択も行なって閉じる";
            this.checkBoxSelectAndClose.UseVisualStyleBackColor = true;
            // 
            // buttonJump
            // 
            this.buttonJump.Location = new System.Drawing.Point(270, 523);
            this.buttonJump.Name = "buttonJump";
            this.buttonJump.Size = new System.Drawing.Size(90, 30);
            this.buttonJump.TabIndex = 9;
            this.buttonJump.Text = "ジャンプ(E)";
            this.buttonJump.UseVisualStyleBackColor = true;
            this.buttonJump.Click += new System.EventHandler(this.buttonJump_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(371, 523);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(90, 30);
            this.buttonHistory.TabIndex = 10;
            this.buttonHistory.Text = "ヒストリ(D)";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonSystem
            // 
            this.buttonSystem.Location = new System.Drawing.Point(478, 231);
            this.buttonSystem.Name = "buttonSystem";
            this.buttonSystem.Size = new System.Drawing.Size(150, 35);
            this.buttonSystem.TabIndex = 11;
            this.buttonSystem.Text = "システム(S)";
            this.buttonSystem.UseVisualStyleBackColor = true;
            this.buttonSystem.Click += new System.EventHandler(this.buttonSystem_Click);
            // 
            // DirectorySelectDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.buttonSystem);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonJump);
            this.Controls.Add(this.checkBoxSelectAndClose);
            this.Controls.Add(this.groupBoxFavorites);
            this.Controls.Add(this.buttonCreateDirectory);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.treeViewDirectories);
            this.Controls.Add(this.labelFreeSpace);
            this.Controls.Add(this.labelCurrentDrive);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectorySelectDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "カレント・ディレクトリ選択";
            this.Load += new System.EventHandler(this.DirectorySelectDialog_Load);
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxFavorites.ResumeLayout(false);
            this.flowLayoutPanelFavorites.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentDrive;
        private System.Windows.Forms.Label labelFreeSpace;
        private System.Windows.Forms.TreeView treeViewDirectories;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.TextBox textBoxSelectedPath;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreateDirectory;
        private System.Windows.Forms.GroupBox groupBoxFavorites;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFavorites;
        private System.Windows.Forms.Button buttonFav1;
        private System.Windows.Forms.Button buttonFav2;
        private System.Windows.Forms.Button buttonFav3;
        private System.Windows.Forms.Button buttonFav4;
        private System.Windows.Forms.Button buttonFav5;
        private System.Windows.Forms.Button buttonFav6;
        private System.Windows.Forms.Button buttonFav7;
        private System.Windows.Forms.Button buttonFav8;
        private System.Windows.Forms.Button buttonFav9;
        private System.Windows.Forms.CheckBox checkBoxSelectAndClose;
        private System.Windows.Forms.Button buttonJump;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonSystem;
        private System.Windows.Forms.ImageList imageListDirectories;
    }
}