// このコードは、重複定義と不要な宣言を削除し、statusStrip1関連を元に戻した修正版です。

using System;
using System.Drawing;
using System.Windows.Forms;

namespace AltCommander
{
    partial class AltCommanderForm
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

        // --- コントロールのフィールド宣言 ---
        // .Designer.cs ファイルでのみ宣言する
        private SplitContainer mainSplitContainer;
        private SplitContainer topSplitContainer;
        private TableLayoutPanel topLeftTableLayoutPanel;
        private Label driveInfoLabel;
        private Label freeSpaceLabel;
        private Label markedFilesLabel;
        private TextBox pathTextBox;
        private Button treeViewButton;
        private Button sortButton;
        private ListView topRightListView;
        private SplitContainer bottomSplitContainer;
        private TableLayoutPanel bottomLeftTableLayoutPanel;
        private Label driveInfoLabel2;
        private Label freeSpaceLabel2;
        private Label markedFilesLabel2;
        private TextBox pathTextBox2;
        private Button treeViewButton2;
        private Button sortButton2;
        private ListView bottomRightListView;
        private StatusStrip statusStrip1; // 宣言を復活
        private ToolStripStatusLabel statusLabel1; // 宣言を復活


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltCommanderForm));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.topSplitContainer = new System.Windows.Forms.SplitContainer();
            this.topLeftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.driveInfoLabel = new System.Windows.Forms.Label();
            this.freeSpaceLabel = new System.Windows.Forms.Label();
            this.markedFilesLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.treeViewButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.topRightListView = new System.Windows.Forms.ListView();
            this.bottomSplitContainer = new System.Windows.Forms.SplitContainer();
            this.bottomLeftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.driveInfoLabel2 = new System.Windows.Forms.Label();
            this.freeSpaceLabel2 = new System.Windows.Forms.Label();
            this.markedFilesLabel2 = new System.Windows.Forms.Label();
            this.pathTextBox2 = new System.Windows.Forms.TextBox();
            this.treeViewButton2 = new System.Windows.Forms.Button();
            this.sortButton2 = new System.Windows.Forms.Button();
            this.bottomRightListView = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topSplitContainer)).BeginInit();
            this.topSplitContainer.Panel1.SuspendLayout();
            this.topSplitContainer.Panel2.SuspendLayout();
            this.topSplitContainer.SuspendLayout();
            this.topLeftTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomSplitContainer)).BeginInit();
            this.bottomSplitContainer.Panel1.SuspendLayout();
            this.bottomSplitContainer.Panel2.SuspendLayout();
            this.bottomSplitContainer.SuspendLayout();
            this.bottomLeftTableLayoutPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.topSplitContainer);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.bottomSplitContainer);
            this.mainSplitContainer.Size = new System.Drawing.Size(1000, 720);
            this.mainSplitContainer.SplitterDistance = 360;
            this.mainSplitContainer.SplitterWidth = 5;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // topSplitContainer
            // 
            this.topSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.topSplitContainer.IsSplitterFixed = true;
            this.topSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.topSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.topSplitContainer.Name = "topSplitContainer";
            // 
            // topSplitContainer.Panel1
            // 
            this.topSplitContainer.Panel1.Controls.Add(this.topLeftTableLayoutPanel);
            // 
            // topSplitContainer.Panel2
            // 
            this.topSplitContainer.Panel2.Controls.Add(this.topRightListView);
            this.topSplitContainer.Size = new System.Drawing.Size(1000, 360);
            this.topSplitContainer.SplitterDistance = 200;
            this.topSplitContainer.SplitterWidth = 5;
            this.topSplitContainer.TabIndex = 0;
            // 
            // topLeftTableLayoutPanel
            // 
            this.topLeftTableLayoutPanel.ColumnCount = 2;
            this.topLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.topLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.topLeftTableLayoutPanel.Controls.Add(this.driveInfoLabel, 0, 0);
            this.topLeftTableLayoutPanel.Controls.Add(this.freeSpaceLabel, 0, 1);
            this.topLeftTableLayoutPanel.Controls.Add(this.markedFilesLabel, 0, 2);
            this.topLeftTableLayoutPanel.Controls.Add(this.pathTextBox, 0, 3);
            this.topLeftTableLayoutPanel.Controls.Add(this.treeViewButton, 0, 4);
            this.topLeftTableLayoutPanel.Controls.Add(this.sortButton, 1, 4);
            this.topLeftTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topLeftTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topLeftTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topLeftTableLayoutPanel.Name = "topLeftTableLayoutPanel";
            this.topLeftTableLayoutPanel.RowCount = 5;
            this.topLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.topLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLeftTableLayoutPanel.Size = new System.Drawing.Size(200, 360);
            this.topLeftTableLayoutPanel.TabIndex = 0;
            // 
            // driveInfoLabel
            // 
            this.driveInfoLabel.AutoSize = true;
            this.topLeftTableLayoutPanel.SetColumnSpan(this.driveInfoLabel, 2);
            this.driveInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveInfoLabel.Location = new System.Drawing.Point(4, 0);
            this.driveInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driveInfoLabel.Name = "driveInfoLabel";
            this.driveInfoLabel.Size = new System.Drawing.Size(192, 30);
            this.driveInfoLabel.TabIndex = 0;
            this.driveInfoLabel.Text = "Drive:";
            this.driveInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // freeSpaceLabel
            // 
            this.freeSpaceLabel.AutoSize = true;
            this.topLeftTableLayoutPanel.SetColumnSpan(this.freeSpaceLabel, 2);
            this.freeSpaceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeSpaceLabel.Location = new System.Drawing.Point(4, 30);
            this.freeSpaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freeSpaceLabel.Name = "freeSpaceLabel";
            this.freeSpaceLabel.Size = new System.Drawing.Size(192, 30);
            this.freeSpaceLabel.TabIndex = 1;
            this.freeSpaceLabel.Text = "Free:";
            this.freeSpaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // markedFilesLabel
            // 
            this.markedFilesLabel.AutoSize = true;
            this.topLeftTableLayoutPanel.SetColumnSpan(this.markedFilesLabel, 2);
            this.markedFilesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markedFilesLabel.Location = new System.Drawing.Point(4, 60);
            this.markedFilesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.markedFilesLabel.Name = "markedFilesLabel";
            this.markedFilesLabel.Size = new System.Drawing.Size(192, 30);
            this.markedFilesLabel.TabIndex = 2;
            this.markedFilesLabel.Text = "Marks: (0/0)";
            this.markedFilesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pathTextBox
            // 
            this.topLeftTableLayoutPanel.SetColumnSpan(this.pathTextBox, 2);
            this.pathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathTextBox.Location = new System.Drawing.Point(4, 94);
            this.pathTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(192, 25);
            this.pathTextBox.TabIndex = 3;
            this.pathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathTextBox_KeyDown);
            // 
            // treeViewButton
            // 
            this.treeViewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewButton.Location = new System.Drawing.Point(4, 130);
            this.treeViewButton.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewButton.Name = "treeViewButton";
            this.treeViewButton.Size = new System.Drawing.Size(86, 226);
            this.treeViewButton.TabIndex = 4;
            this.treeViewButton.Text = "Tree";
            this.treeViewButton.UseVisualStyleBackColor = true;
            this.treeViewButton.Click += new System.EventHandler(this.treeViewButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortButton.Location = new System.Drawing.Point(98, 130);
            this.sortButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(98, 226);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // topRightListView
            // 
            this.topRightListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topRightListView.FullRowSelect = true;
            this.topRightListView.HideSelection = false;
            this.topRightListView.Location = new System.Drawing.Point(0, 0);
            this.topRightListView.Margin = new System.Windows.Forms.Padding(4);
            this.topRightListView.Name = "topRightListView";
            this.topRightListView.OwnerDraw = true;
            this.topRightListView.Size = new System.Drawing.Size(795, 360);
            this.topRightListView.TabIndex = 0;
            this.topRightListView.UseCompatibleStateImageBehavior = false;
            this.topRightListView.View = System.Windows.Forms.View.Details;
            this.topRightListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_DrawItem);
            this.topRightListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_DrawSubItem);
            // 
            // bottomSplitContainer
            // 
            this.bottomSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.bottomSplitContainer.IsSplitterFixed = true;
            this.bottomSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.bottomSplitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.bottomSplitContainer.Name = "bottomSplitContainer";
            // 
            // bottomSplitContainer.Panel1
            // 
            this.bottomSplitContainer.Panel1.Controls.Add(this.bottomLeftTableLayoutPanel);
            // 
            // bottomSplitContainer.Panel2
            // 
            this.bottomSplitContainer.Panel2.Controls.Add(this.bottomRightListView);
            this.bottomSplitContainer.Size = new System.Drawing.Size(1000, 355);
            this.bottomSplitContainer.SplitterDistance = 200;
            this.bottomSplitContainer.SplitterWidth = 5;
            this.bottomSplitContainer.TabIndex = 1;
            // 
            // bottomLeftTableLayoutPanel
            // 
            this.bottomLeftTableLayoutPanel.ColumnCount = 2;
            this.bottomLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomLeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bottomLeftTableLayoutPanel.Controls.Add(this.driveInfoLabel2, 0, 0);
            this.bottomLeftTableLayoutPanel.Controls.Add(this.freeSpaceLabel2, 0, 1);
            this.bottomLeftTableLayoutPanel.Controls.Add(this.markedFilesLabel2, 0, 2);
            this.bottomLeftTableLayoutPanel.Controls.Add(this.pathTextBox2, 0, 3);
            this.bottomLeftTableLayoutPanel.Controls.Add(this.treeViewButton2, 0, 4);
            this.bottomLeftTableLayoutPanel.Controls.Add(this.sortButton2, 1, 4);
            this.bottomLeftTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomLeftTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.bottomLeftTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bottomLeftTableLayoutPanel.Name = "bottomLeftTableLayoutPanel";
            this.bottomLeftTableLayoutPanel.RowCount = 5;
            this.bottomLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.bottomLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.bottomLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.bottomLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.bottomLeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomLeftTableLayoutPanel.Size = new System.Drawing.Size(200, 355);
            this.bottomLeftTableLayoutPanel.TabIndex = 0;
            // 
            // driveInfoLabel2
            // 
            this.driveInfoLabel2.AutoSize = true;
            this.bottomLeftTableLayoutPanel.SetColumnSpan(this.driveInfoLabel2, 2);
            this.driveInfoLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveInfoLabel2.Location = new System.Drawing.Point(4, 0);
            this.driveInfoLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driveInfoLabel2.Name = "driveInfoLabel2";
            this.driveInfoLabel2.Size = new System.Drawing.Size(192, 30);
            this.driveInfoLabel2.TabIndex = 0;
            this.driveInfoLabel2.Text = "Drive:";
            this.driveInfoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // freeSpaceLabel2
            // 
            this.freeSpaceLabel2.AutoSize = true;
            this.bottomLeftTableLayoutPanel.SetColumnSpan(this.freeSpaceLabel2, 2);
            this.freeSpaceLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freeSpaceLabel2.Location = new System.Drawing.Point(4, 30);
            this.freeSpaceLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freeSpaceLabel2.Name = "freeSpaceLabel2";
            this.freeSpaceLabel2.Size = new System.Drawing.Size(192, 30);
            this.freeSpaceLabel2.TabIndex = 1;
            this.freeSpaceLabel2.Text = "Free:";
            this.freeSpaceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // markedFilesLabel2
            // 
            this.markedFilesLabel2.AutoSize = true;
            this.bottomLeftTableLayoutPanel.SetColumnSpan(this.markedFilesLabel2, 2);
            this.markedFilesLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markedFilesLabel2.Location = new System.Drawing.Point(4, 60);
            this.markedFilesLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.markedFilesLabel2.Name = "markedFilesLabel2";
            this.markedFilesLabel2.Size = new System.Drawing.Size(192, 30);
            this.markedFilesLabel2.TabIndex = 2;
            this.markedFilesLabel2.Text = "Marks: (0/0)";
            this.markedFilesLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pathTextBox2
            // 
            this.bottomLeftTableLayoutPanel.SetColumnSpan(this.pathTextBox2, 2);
            this.pathTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathTextBox2.Location = new System.Drawing.Point(4, 94);
            this.pathTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.pathTextBox2.Name = "pathTextBox2";
            this.pathTextBox2.Size = new System.Drawing.Size(192, 25);
            this.pathTextBox2.TabIndex = 3;
            this.pathTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathTextBox2_KeyDown);
            // 
            // treeViewButton2
            // 
            this.treeViewButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewButton2.Location = new System.Drawing.Point(4, 130);
            this.treeViewButton2.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewButton2.Name = "treeViewButton2";
            this.treeViewButton2.Size = new System.Drawing.Size(92, 221);
            this.treeViewButton2.TabIndex = 4;
            this.treeViewButton2.Text = "Tree";
            this.treeViewButton2.UseVisualStyleBackColor = true;
            this.treeViewButton2.Click += new System.EventHandler(this.treeViewButton2_Click);
            // 
            // sortButton2
            // 
            this.sortButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortButton2.Location = new System.Drawing.Point(104, 130);
            this.sortButton2.Margin = new System.Windows.Forms.Padding(4);
            this.sortButton2.Name = "sortButton2";
            this.sortButton2.Size = new System.Drawing.Size(92, 221);
            this.sortButton2.TabIndex = 5;
            this.sortButton2.Text = "Sort";
            this.sortButton2.UseVisualStyleBackColor = true;
            this.sortButton2.Click += new System.EventHandler(this.sortButton2_Click);
            // 
            // bottomRightListView
            // 
            this.bottomRightListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomRightListView.FullRowSelect = true;
            this.bottomRightListView.HideSelection = false;
            this.bottomRightListView.Location = new System.Drawing.Point(0, 0);
            this.bottomRightListView.Margin = new System.Windows.Forms.Padding(4);
            this.bottomRightListView.Name = "bottomRightListView";
            this.bottomRightListView.OwnerDraw = true;
            this.bottomRightListView.Size = new System.Drawing.Size(795, 355);
            this.bottomRightListView.TabIndex = 0;
            this.bottomRightListView.UseCompatibleStateImageBehavior = false;
            this.bottomRightListView.View = System.Windows.Forms.View.Details;
            this.bottomRightListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_DrawItem);
            this.bottomRightListView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_DrawSubItem);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 698);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1000, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // AltCommanderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainSplitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AltCommanderForm";
            this.Text = "AltCommander";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.topSplitContainer.Panel1.ResumeLayout(false);
            this.topSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topSplitContainer)).EndInit();
            this.topSplitContainer.ResumeLayout(false);
            this.topLeftTableLayoutPanel.ResumeLayout(false);
            this.topLeftTableLayoutPanel.PerformLayout();
            this.bottomSplitContainer.Panel1.ResumeLayout(false);
            this.bottomSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bottomSplitContainer)).EndInit();
            this.bottomSplitContainer.ResumeLayout(false);
            this.bottomLeftTableLayoutPanel.ResumeLayout(false);
            this.bottomLeftTableLayoutPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // --- イベントハンドラの宣言は .cs ファイルで行うため、ここでは削除 ---
        // private void pathTextBox_KeyDown(object sender, KeyEventArgs e);
        // private void pathTextBox2_KeyDown(object sender, KeyEventArgs e);
        // ... (他のイベントハンドラ宣言も削除) ...
        // private void listView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e);
    }
}
