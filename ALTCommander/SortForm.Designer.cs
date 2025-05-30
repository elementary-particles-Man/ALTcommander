// このコードは、不要なイベントハンドラ宣言を削除した修正版です。

namespace AltCommander
{
    partial class SortForm
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
            // --- コントロールの宣言と初期化 ---
            this.groupBoxSortKey = new System.Windows.Forms.GroupBox();
            this.radioButtonSortNone = new System.Windows.Forms.RadioButton();
            this.radioButtonSortWriteTime = new System.Windows.Forms.RadioButton();
            this.radioButtonSortAccessTime = new System.Windows.Forms.RadioButton();
            this.radioButtonSortCreationTime = new System.Windows.Forms.RadioButton();
            this.radioButtonSortSize = new System.Windows.Forms.RadioButton();
            this.radioButtonSortExtension = new System.Windows.Forms.RadioButton();
            this.radioButtonSortName = new System.Windows.Forms.RadioButton();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonDescending = new System.Windows.Forms.RadioButton();
            this.radioButtonAscending = new System.Windows.Forms.RadioButton();
            this.groupBoxAttributes = new System.Windows.Forms.GroupBox();
            this.checkBoxArchive = new System.Windows.Forms.CheckBox();
            this.checkBoxSystem = new System.Windows.Forms.CheckBox();
            this.checkBoxHidden = new System.Windows.Forms.CheckBox();
            this.checkBoxReadOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxDirectory = new System.Windows.Forms.CheckBox();
            this.checkBoxGatherNewFiles = new System.Windows.Forms.CheckBox();
            this.labelTopExtensions = new System.Windows.Forms.Label();
            this.textBoxTopExtensions = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxSortKey.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxAttributes.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBoxSortKey
            //
            this.groupBoxSortKey.Controls.Add(this.radioButtonSortNone);
            this.groupBoxSortKey.Controls.Add(this.radioButtonSortWriteTime);
            this.groupBoxSortKey.Controls.Add(this.radioButtonSortAccessTime);
            this.groupBoxSortKey.Controls.Add(this.radioButtonSortCreationTime);
            this.groupBoxSortKey.Controls.Add(this.radioButtonSortSize);
            this.groupBoxSortKey.Controls.Add(this.radioButtonSortExtension);
            this.groupBoxSortKey.Controls.Add(this.radioButtonSortName);
            this.groupBoxSortKey.Location = new System.Drawing.Point(20, 20);
            this.groupBoxSortKey.Name = "groupBoxSortKey";
            this.groupBoxSortKey.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.groupBoxSortKey.Size = new System.Drawing.Size(280, 270);
            this.groupBoxSortKey.TabIndex = 0;
            this.groupBoxSortKey.TabStop = false;
            this.groupBoxSortKey.Text = "ソート・キー";
            //
            // radioButtonSortNone
            //
            this.radioButtonSortNone.AutoSize = true;
            this.radioButtonSortNone.Location = new System.Drawing.Point(25, 230);
            this.radioButtonSortNone.Name = "radioButtonSortNone";
            this.radioButtonSortNone.Size = new System.Drawing.Size(98, 19);
            this.radioButtonSortNone.TabIndex = 6;
            this.radioButtonSortNone.TabStop = true;
            this.radioButtonSortNone.Text = "ソートなし(&N)";
            this.radioButtonSortNone.UseVisualStyleBackColor = true;
            //
            // radioButtonSortWriteTime
            //
            this.radioButtonSortWriteTime.AutoSize = true;
            this.radioButtonSortWriteTime.Location = new System.Drawing.Point(25, 195);
            this.radioButtonSortWriteTime.Name = "radioButtonSortWriteTime";
            this.radioButtonSortWriteTime.Size = new System.Drawing.Size(140, 19);
            this.radioButtonSortWriteTime.TabIndex = 5;
            this.radioButtonSortWriteTime.TabStop = true;
            this.radioButtonSortWriteTime.Text = "最終書き込み時刻(&W)";
            this.radioButtonSortWriteTime.UseVisualStyleBackColor = true;
            //
            // radioButtonSortAccessTime
            //
            this.radioButtonSortAccessTime.AutoSize = true;
            this.radioButtonSortAccessTime.Location = new System.Drawing.Point(25, 160);
            this.radioButtonSortAccessTime.Name = "radioButtonSortAccessTime";
            this.radioButtonSortAccessTime.Size = new System.Drawing.Size(139, 19);
            this.radioButtonSortAccessTime.TabIndex = 4;
            this.radioButtonSortAccessTime.TabStop = true;
            this.radioButtonSortAccessTime.Text = "最終アクセス時刻(&A)";
            this.radioButtonSortAccessTime.UseVisualStyleBackColor = true;
            //
            // radioButtonSortCreationTime
            //
            this.radioButtonSortCreationTime.AutoSize = true;
            this.radioButtonSortCreationTime.Location = new System.Drawing.Point(25, 125);
            this.radioButtonSortCreationTime.Name = "radioButtonSortCreationTime";
            this.radioButtonSortCreationTime.Size = new System.Drawing.Size(128, 19);
            this.radioButtonSortCreationTime.TabIndex = 3;
            this.radioButtonSortCreationTime.TabStop = true;
            this.radioButtonSortCreationTime.Text = "ファイル作成時刻(&C)";
            this.radioButtonSortCreationTime.UseVisualStyleBackColor = true;
            //
            // radioButtonSortSize
            //
            this.radioButtonSortSize.AutoSize = true;
            this.radioButtonSortSize.Location = new System.Drawing.Point(25, 90);
            this.radioButtonSortSize.Name = "radioButtonSortSize";
            this.radioButtonSortSize.Size = new System.Drawing.Size(75, 19);
            this.radioButtonSortSize.TabIndex = 2;
            this.radioButtonSortSize.TabStop = true;
            this.radioButtonSortSize.Text = "サイズ(&S)";
            this.radioButtonSortSize.UseVisualStyleBackColor = true;
            //
            // radioButtonSortExtension
            //
            this.radioButtonSortExtension.AutoSize = true;
            this.radioButtonSortExtension.Location = new System.Drawing.Point(25, 55);
            this.radioButtonSortExtension.Name = "radioButtonSortExtension";
            this.radioButtonSortExtension.Size = new System.Drawing.Size(81, 19);
            this.radioButtonSortExtension.TabIndex = 1;
            this.radioButtonSortExtension.TabStop = true;
            this.radioButtonSortExtension.Text = "拡張子(&E)";
            this.radioButtonSortExtension.UseVisualStyleBackColor = true;
            //
            // radioButtonSortName
            //
            this.radioButtonSortName.AutoSize = true;
            this.radioButtonSortName.Checked = true;
            this.radioButtonSortName.Location = new System.Drawing.Point(25, 25);
            this.radioButtonSortName.Name = "radioButtonSortName";
            this.radioButtonSortName.Size = new System.Drawing.Size(94, 19);
            this.radioButtonSortName.TabIndex = 0;
            this.radioButtonSortName.TabStop = true;
            this.radioButtonSortName.Text = "ファイル名(&F)";
            this.radioButtonSortName.UseVisualStyleBackColor = true;
            //
            // groupBoxOrder
            //
            this.groupBoxOrder.Controls.Add(this.radioButtonDescending);
            this.groupBoxOrder.Controls.Add(this.radioButtonAscending);
            this.groupBoxOrder.Location = new System.Drawing.Point(320, 20);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.groupBoxOrder.Size = new System.Drawing.Size(280, 110);
            this.groupBoxOrder.TabIndex = 1;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "順序";
            //
            // radioButtonDescending
            //
            this.radioButtonDescending.AutoSize = true;
            this.radioButtonDescending.Location = new System.Drawing.Point(25, 65);
            this.radioButtonDescending.Name = "radioButtonDescending";
            this.radioButtonDescending.Size = new System.Drawing.Size(102, 19);
            this.radioButtonDescending.TabIndex = 1;
            this.radioButtonDescending.Text = "降順(&D) 大→小";
            this.radioButtonDescending.UseVisualStyleBackColor = true;
            //
            // radioButtonAscending
            //
            this.radioButtonAscending.AutoSize = true;
            this.radioButtonAscending.Checked = true;
            this.radioButtonAscending.Location = new System.Drawing.Point(25, 30);
            this.radioButtonAscending.Name = "radioButtonAscending";
            this.radioButtonAscending.Size = new System.Drawing.Size(102, 19);
            this.radioButtonAscending.TabIndex = 0;
            this.radioButtonAscending.TabStop = true;
            this.radioButtonAscending.Text = "昇順(&U) 小→大";
            this.radioButtonAscending.UseVisualStyleBackColor = true;
            //
            // groupBoxAttributes
            //
            this.groupBoxAttributes.Controls.Add(this.checkBoxArchive);
            this.groupBoxAttributes.Controls.Add(this.checkBoxSystem);
            this.groupBoxAttributes.Controls.Add(this.checkBoxHidden);
            this.groupBoxAttributes.Controls.Add(this.checkBoxReadOnly);
            this.groupBoxAttributes.Controls.Add(this.checkBoxDirectory);
            this.groupBoxAttributes.Location = new System.Drawing.Point(320, 140);
            this.groupBoxAttributes.Name = "groupBoxAttributes";
            this.groupBoxAttributes.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.groupBoxAttributes.Size = new System.Drawing.Size(280, 220);
            this.groupBoxAttributes.TabIndex = 2;
            this.groupBoxAttributes.TabStop = false;
            this.groupBoxAttributes.Text = "先頭に集める属性";
            //
            // checkBoxArchive
            //
            this.checkBoxArchive.AutoSize = true;
            this.checkBoxArchive.Location = new System.Drawing.Point(25, 170);
            this.checkBoxArchive.Name = "checkBoxArchive";
            this.checkBoxArchive.Size = new System.Drawing.Size(92, 19);
            this.checkBoxArchive.TabIndex = 4;
            this.checkBoxArchive.Text = "アーカイブ(&5)";
            this.checkBoxArchive.UseVisualStyleBackColor = true;
            //
            // checkBoxSystem
            //
            this.checkBoxSystem.AutoSize = true;
            this.checkBoxSystem.Location = new System.Drawing.Point(25, 135);
            this.checkBoxSystem.Name = "checkBoxSystem";
            this.checkBoxSystem.Size = new System.Drawing.Size(123, 19);
            this.checkBoxSystem.TabIndex = 3;
            this.checkBoxSystem.Text = "システムファイル(&4)";
            this.checkBoxSystem.UseVisualStyleBackColor = true;
            //
            // checkBoxHidden
            //
            this.checkBoxHidden.AutoSize = true;
            this.checkBoxHidden.Location = new System.Drawing.Point(25, 100);
            this.checkBoxHidden.Name = "checkBoxHidden";
            this.checkBoxHidden.Size = new System.Drawing.Size(103, 19);
            this.checkBoxHidden.TabIndex = 2;
            this.checkBoxHidden.Text = "隠しファイル(&3)";
            this.checkBoxHidden.UseVisualStyleBackColor = true;
            //
            // checkBoxReadOnly
            //
            this.checkBoxReadOnly.AutoSize = true;
            this.checkBoxReadOnly.Location = new System.Drawing.Point(25, 65);
            this.checkBoxReadOnly.Name = "checkBoxReadOnly";
            this.checkBoxReadOnly.Size = new System.Drawing.Size(117, 19);
            this.checkBoxReadOnly.TabIndex = 1;
            this.checkBoxReadOnly.Text = "読み出し専用(&2)";
            this.checkBoxReadOnly.UseVisualStyleBackColor = true;
            //
            // checkBoxDirectory
            //
            this.checkBoxDirectory.AutoSize = true;
            this.checkBoxDirectory.Checked = true;
            this.checkBoxDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDirectory.Location = new System.Drawing.Point(25, 30);
            this.checkBoxDirectory.Name = "checkBoxDirectory";
            this.checkBoxDirectory.Size = new System.Drawing.Size(99, 19);
            this.checkBoxDirectory.TabIndex = 0;
            this.checkBoxDirectory.Text = "ディレクトリ(&1)";
            this.checkBoxDirectory.UseVisualStyleBackColor = true;
            //
            // checkBoxGatherNewFiles
            //
            this.checkBoxGatherNewFiles.AutoSize = true;
            this.checkBoxGatherNewFiles.Location = new System.Drawing.Point(320, 370);
            this.checkBoxGatherNewFiles.Name = "checkBoxGatherNewFiles";
            this.checkBoxGatherNewFiles.Size = new System.Drawing.Size(146, 19);
            this.checkBoxGatherNewFiles.TabIndex = 3;
            this.checkBoxGatherNewFiles.Text = "新着ファイルを集める(&6)";
            this.checkBoxGatherNewFiles.UseVisualStyleBackColor = true;
            //
            // labelTopExtensions
            //
            this.labelTopExtensions.AutoSize = true;
            this.labelTopExtensions.Location = new System.Drawing.Point(20, 300);
            this.labelTopExtensions.Name = "labelTopExtensions";
            this.labelTopExtensions.Size = new System.Drawing.Size(269, 15);
            this.labelTopExtensions.TabIndex = 4;
            this.labelTopExtensions.Text = "先頭に集める拡張子(&X) (セミコロンで複数指定可能)";
            //
            // textBoxTopExtensions
            //
            this.textBoxTopExtensions.Location = new System.Drawing.Point(20, 320);
            this.textBoxTopExtensions.Name = "textBoxTopExtensions";
            this.textBoxTopExtensions.Size = new System.Drawing.Size(280, 22);
            this.textBoxTopExtensions.TabIndex = 5;
            //
            // buttonOK
            //
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(410, 440);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 35);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click); // イベント接続は残す
            //
            // buttonCancel
            //
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(510, 440);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "キャンセル";
            this.buttonCancel.UseVisualStyleBackColor = true;
            //
            // SortForm
            //
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(630, 490);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxTopExtensions);
            this.Controls.Add(this.labelTopExtensions);
            this.Controls.Add(this.checkBoxGatherNewFiles);
            this.Controls.Add(this.groupBoxAttributes);
            this.Controls.Add(this.groupBoxOrder);
            this.Controls.Add(this.groupBoxSortKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ファイルの一時的なソート";
            this.groupBoxSortKey.ResumeLayout(false);
            this.groupBoxSortKey.PerformLayout();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.groupBoxAttributes.ResumeLayout(false);
            this.groupBoxAttributes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // --- コントロールのフィールド宣言 ---
        private System.Windows.Forms.GroupBox groupBoxSortKey;
        private System.Windows.Forms.RadioButton radioButtonSortNone;
        private System.Windows.Forms.RadioButton radioButtonSortWriteTime;
        private System.Windows.Forms.RadioButton radioButtonSortAccessTime;
        private System.Windows.Forms.RadioButton radioButtonSortCreationTime;
        private System.Windows.Forms.RadioButton radioButtonSortSize;
        private System.Windows.Forms.RadioButton radioButtonSortExtension;
        private System.Windows.Forms.RadioButton radioButtonSortName;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.RadioButton radioButtonDescending;
        private System.Windows.Forms.RadioButton radioButtonAscending;
        private System.Windows.Forms.GroupBox groupBoxAttributes;
        private System.Windows.Forms.CheckBox checkBoxArchive;
        private System.Windows.Forms.CheckBox checkBoxSystem;
        private System.Windows.Forms.CheckBox checkBoxHidden;
        private System.Windows.Forms.CheckBox checkBoxReadOnly;
        private System.Windows.Forms.CheckBox checkBoxDirectory;
        private System.Windows.Forms.CheckBox checkBoxGatherNewFiles;
        private System.Windows.Forms.Label labelTopExtensions;
        private System.Windows.Forms.TextBox textBoxTopExtensions;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;

        // --- イベントハンドラの宣言は .cs ファイルで行うため、ここでは削除 ---
        // private void buttonOK_Click(object sender, EventArgs e);
    }
}
