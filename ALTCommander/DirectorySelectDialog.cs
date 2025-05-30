using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALTCommander
{
    public partial class DirectorySelectDialog : Form
    {
        public string SelectedDirectoryPath { get; private set; }
        public string InitialDirectory { get; set; }

        // アイコンのインデックスを定数で定義
        private const int ICON_INDEX_FOLDER_CLOSED = 0;
        private const int ICON_INDEX_FOLDER_OPENED = 1; // 開いたフォルダ用（オプション）
        private const int ICON_INDEX_DRIVE = 2;
        // 必要に応じて他のアイコンも

        // よく使うディレクトリのパスを保持（設定ファイルなどから読み込む想定）
        private Dictionary<int, string> _favoritePaths = new Dictionary<int, string>();

        public DirectorySelectDialog()
        {
            InitializeComponent();
            InitializeImageList();
            LoadFavoritePaths(); // よく使うディレクトリの読み込み
        }

        private void InitializeImageList()
        {
            // ダミーアイコンの作成（リソースから読み込むのが望ましい）
            Bitmap folderBmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(folderBmp))
            {
                g.Clear(Color.Transparent);
                g.FillRectangle(Brushes.Gold, 2, 4, 12, 10); // フォルダ本体
                g.FillRectangle(Brushes.Goldenrod, 2, 2, 6, 4); // フォルダのタブ部分
            }
            imageListDirectories.Images.Add("folder_closed", folderBmp);

            Bitmap folderOpenBmp = new Bitmap(16, 16); // 開いたフォルダアイコン（例）
            using (Graphics g = Graphics.FromImage(folderOpenBmp))
            {
                g.Clear(Color.Transparent);
                g.FillRectangle(Brushes.LightGoldenrodYellow, 2, 4, 12, 10);
                g.FillRectangle(Brushes.Goldenrod, 2, 2, 6, 4);
                // 簡単な「開いている」表現
                g.DrawLine(Pens.DarkGoldenrod, 4, 6, 10, 6);

            }
            imageListDirectories.Images.Add("folder_opened", folderOpenBmp);


            Bitmap driveBmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(driveBmp))
            {
                g.Clear(Color.Transparent);
                g.FillRectangle(Brushes.LightGray, 2, 5, 12, 6); // ドライブ本体
                g.DrawRectangle(Pens.DarkGray, 2, 5, 12, 6);    // 枠線
                g.FillEllipse(Brushes.DarkSlateGray, 7, 7, 2, 2); // アクセスランプ風
            }
            imageListDirectories.Images.Add("drive", driveBmp);

            // TreeView に ImageList を設定 (デザイナでも設定可能)
            treeViewDirectories.ImageList = imageListDirectories;
        }

        private void LoadFavoritePaths()
        {
            // TODO: 設定ファイルなどからよく使うディレクトリのパスを読み込む
            // ダミーデータ
            // _favoritePaths[1] = "C:\\Windows";
            // _favoritePaths[2] = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void DirectorySelectDialog_Load(object sender, EventArgs e)
        {
            LoadDrives();
            if (!string.IsNullOrEmpty(InitialDirectory) && Directory.Exists(InitialDirectory))
            {
                SelectNodeByPath(InitialDirectory);
                textBoxSelectedPath.Text = InitialDirectory;
                SelectedDirectoryPath = InitialDirectory;
            }
            else if (treeViewDirectories.Nodes.Count > 0)
            {
                // 初期ディレクトリが無効または未設定の場合、最初のドライブのルートを選択状態にする
                treeViewDirectories.SelectedNode = treeViewDirectories.Nodes[0];
                treeViewDirectories.Nodes[0].Expand(); // 最初のドライブを展開
            }
        }

        private void LoadDrives()
        {
            treeViewDirectories.Nodes.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    TreeNode driveNode = new TreeNode(drive.Name, ICON_INDEX_DRIVE, ICON_INDEX_DRIVE);
                    driveNode.Tag = drive.RootDirectory;
                    driveNode.ToolTipText = $"{drive.VolumeLabel} ({drive.DriveFormat}) - 空き: {FormatBytes(drive.AvailableFreeSpace)} / 全体: {FormatBytes(drive.TotalSize)}";
                    // ダミーノードを追加して「+」を表示させる
                    if (HasSubDirectories(drive.RootDirectory))
                    {
                        driveNode.Nodes.Add(new TreeNode("Loading..."));
                    }
                    treeViewDirectories.Nodes.Add(driveNode);
                }
            }
        }

        private void treeViewDirectories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // 開いたフォルダアイコンに変更 (オプション)
            if (e.Node.Tag is DirectoryInfo && e.Node.Parent != null) // ドライブノード以外
            {
                e.Node.ImageIndex = ICON_INDEX_FOLDER_OPENED;
                e.Node.SelectedImageIndex = ICON_INDEX_FOLDER_OPENED;
            }

            if (e.Node.Nodes.Count > 0 && e.Node.Nodes[0].Text == "Loading...")
            {
                e.Node.Nodes.Clear(); // ダミーノードを削除
                LoadSubDirectories(e.Node);
            }
        }

        // オプション: ノードが閉じられる前にアイコンを元に戻す
        // private void treeViewDirectories_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        // {
        //     if(e.Node.Tag is DirectoryInfo && e.Node.Parent != null) // ドライブノード以外
        //     {
        //         e.Node.ImageIndex = ICON_INDEX_FOLDER_CLOSED;
        //         e.Node.SelectedImageIndex = ICON_INDEX_FOLDER_CLOSED;
        //     }
        // }


        private void LoadSubDirectories(TreeNode parentNode)
        {
            if (!(parentNode.Tag is DirectoryInfo parentDirInfo)) return;

            try
            {
                DirectoryInfo[] subDirs = parentDirInfo.GetDirectories();
                foreach (DirectoryInfo subDir in subDirs)
                {
                    if ((subDir.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden ||
                        (subDir.Attributes & FileAttributes.System) == FileAttributes.System)
                    {
                        continue; // 隠し属性やシステム属性のディレクトリはスキップ
                    }

                    TreeNode subNode = new TreeNode(subDir.Name, ICON_INDEX_FOLDER_CLOSED, ICON_INDEX_FOLDER_CLOSED);
                    subNode.Tag = subDir;
                    subNode.ToolTipText = subDir.FullName;
                    if (HasSubDirectories(subDir))
                    {
                        subNode.Nodes.Add(new TreeNode("Loading..."));
                    }
                    parentNode.Nodes.Add(subNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // MessageBox.Show($"ディレクトリ '{parentDirInfo.FullName}' へのアクセスが拒否されました。", "アクセスエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception )
            {
                // MessageBox.Show($"サブディレクトリの読み込み中にエラーが発生しました: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool HasSubDirectories(DirectoryInfo dirInfo)
        {
            try
            {
                // アクセス権のないディレクトリはサブディレクトリがないものとして扱う
                return dirInfo.EnumerateDirectories().Any();
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
            catch (Exception)
            {
                return false; // その他のエラーも同様
            }
        }

        private void treeViewDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag is DirectoryInfo dirInfo)
            {
                SelectedDirectoryPath = dirInfo.FullName;
                textBoxSelectedPath.Text = SelectedDirectoryPath;

                string rootPath = Path.GetPathRoot(dirInfo.FullName);
                labelCurrentDrive.Text = rootPath;
                try
                {
                    DriveInfo drive = new DriveInfo(rootPath);
                    if (drive.IsReady)
                    {
                        labelFreeSpace.Text = $"{FormatBytes(drive.AvailableFreeSpace)} Free ({FormatBytes(drive.TotalSize)} Total)";
                    }
                    else
                    {
                        labelFreeSpace.Text = "Drive not ready";
                    }
                }
                catch
                {
                    labelFreeSpace.Text = "Error reading drive info";
                }
            }
        }

        private void textBoxSelectedPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string path = textBoxSelectedPath.Text;
                if (Directory.Exists(path))
                {
                    SelectNodeByPath(path);
                }
                else
                {
                    MessageBox.Show("指定されたパスが見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private string FormatBytes(long bytes) // AltCommanderForm.cs より流用
        {
            if (bytes < 0) return "N/A";
            if (bytes == 0) return "0 B";

            string[] suffix = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            int i = 0;
            decimal number = bytes;

            while (Math.Round(number / 1024) >= 1 && i < suffix.Length - 1)
            {
                number /= 1024;
                i++;
            }
            return string.Format("{0:N0} {1}", number, suffix[i]); // 3桁区切りカンマ追加
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string pathFromTextBox = textBoxSelectedPath.Text;
            if (Directory.Exists(pathFromTextBox))
            {
                SelectedDirectoryPath = Path.GetFullPath(pathFromTextBox); // 正規化
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (!string.IsNullOrEmpty(SelectedDirectoryPath) && Directory.Exists(SelectedDirectoryPath))
            {
                // TreeViewで選択されたパスが有効ならそれを使う
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("有効なディレクトリが選択または入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateDirectory_Click(object sender, EventArgs e)
        {
            string parentPath = SelectedDirectoryPath;
            if (string.IsNullOrEmpty(parentPath) || !Directory.Exists(parentPath))
            {
                // 親ディレクトリが選択されていない場合、TreeViewで選択されているノードのパスを使用
                if (treeViewDirectories.SelectedNode != null && treeViewDirectories.SelectedNode.Tag is DirectoryInfo currentDirInfo)
                {
                    parentPath = currentDirInfo.FullName;
                }
                else
                {
                    MessageBox.Show("新しいディレクトリを作成する親ディレクトリを選択してください。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            using (var inputDialog = new Form { Width = 350, Height = 150, Text = "新しいディレクトリの作成", StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog, MinimizeBox = false, MaximizeBox = false })
            {
                var textLabel = new Label() { Left = 20, Top = 20, Width = 300, Text = $"作成場所: {parentPath}\n新しいディレクトリ名:" };
                var textBox = new TextBox() { Left = 20, Top = 60, Width = 290, TabIndex = 0 };
                var okButton = new Button() { Text = "OK", Left = 130, Width = 80, Top = 90, DialogResult = DialogResult.OK, TabIndex = 1 };
                var cancelButton = new Button() { Text = "キャンセル", Left = 220, Width = 90, Top = 90, DialogResult = DialogResult.Cancel, TabIndex = 2 };
                okButton.Click += (s, ev) => { inputDialog.Close(); };
                cancelButton.Click += (s, ev) => { inputDialog.Close(); };
                inputDialog.Controls.Add(textLabel);
                inputDialog.Controls.Add(textBox);
                inputDialog.Controls.Add(okButton);
                inputDialog.Controls.Add(cancelButton);
                inputDialog.AcceptButton = okButton;
                inputDialog.CancelButton = cancelButton;

                if (inputDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string newDirName = textBox.Text.Trim();
                    if (!string.IsNullOrEmpty(newDirName))
                    {
                        if (newDirName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
                        {
                            MessageBox.Show("ディレクトリ名に使用できない文字が含まれています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        try
                        {
                            string newDirPath = Path.Combine(parentPath, newDirName);
                            if (!Directory.Exists(newDirPath))
                            {
                                Directory.CreateDirectory(newDirPath);
                                RefreshTreeNode(parentPath, newDirPath); // TreeViewを更新
                                MessageBox.Show($"ディレクトリ '{newDirPath}' を作成しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                SelectNodeByPath(newDirPath); // 作成したディレクトリを選択
                            }
                            else
                            {
                                MessageBox.Show("指定された名前のディレクトリは既に存在します。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"ディレクトリ作成エラー: {ex.Message}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void RefreshTreeNode(string parentPathToRefresh, string newlyCreatedPath)
        {
            TreeNode nodeToRefresh = FindNodeByPath(treeViewDirectories.Nodes, parentPathToRefresh);
            if (nodeToRefresh != null)
            {
                // 既存のサブノードをクリア
                nodeToRefresh.Nodes.Clear();
                // サブディレクトリを再読み込み
                if (nodeToRefresh.Tag is DirectoryInfo dirInfo)
                {
                    // アイコンを一旦閉じた状態に戻す (BeforeExpandで開くため)
                    if (nodeToRefresh.Parent != null) // ドライブノード以外
                    {
                        nodeToRefresh.ImageIndex = ICON_INDEX_FOLDER_CLOSED;
                        nodeToRefresh.SelectedImageIndex = ICON_INDEX_FOLDER_CLOSED;
                    }
                    // ダミーノードを追加するか、直接サブディレクトリをロードするか
                    // ここでは、再度展開時に読み込まれるようにダミーを追加
                    if (HasSubDirectories(dirInfo))
                    {
                        nodeToRefresh.Nodes.Add(new TreeNode("Loading..."));
                    }
                    nodeToRefresh.Collapse(); // 一旦閉じて
                    nodeToRefresh.Expand();   // 再度展開して更新を促す
                }
            }
        }

        public void SelectNodeByPath(string path)
        {
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path)) return;

            string currentPath = path.TrimEnd(Path.DirectorySeparatorChar);
            List<string> pathParts = new List<string>();

            // パスをルートから分解
            DirectoryInfo di = new DirectoryInfo(currentPath);
            while (di != null)
            {
                pathParts.Add(di.Name);
                di = di.Parent;
            }
            pathParts.Reverse(); // ルートから順になるように

            TreeNodeCollection currentNodes = treeViewDirectories.Nodes;
            TreeNode foundNode = null;

            // Driveノードの選択 (例: "C:" や "C:\" の場合)
            if (pathParts.Count == 1 && pathParts[0].EndsWith(":"))
            {
                string driveName = pathParts[0] + Path.DirectorySeparatorChar;
                foundNode = currentNodes.Cast<TreeNode>().FirstOrDefault(node =>
                   node.Tag is DirectoryInfo nodeDirInfo &&
                   nodeDirInfo.FullName.Equals(driveName, StringComparison.OrdinalIgnoreCase));
            }
            else // 通常のディレクトリパスの場合
            {
                foreach (string part in pathParts)
                {
                    foundNode = null; // 各階層でリセット
                    foreach (TreeNode node in currentNodes)
                    {
                        // ルートドライブの比較 ("C:" vs "C:\") のための調整
                        string nodeName = node.Text;
                        if (node.Tag is DirectoryInfo nodeDirInfo && node.Parent == null) // ドライブノード
                        {
                            nodeName = nodeDirInfo.Name.TrimEnd(Path.DirectorySeparatorChar);
                        }

                        if (nodeName.Equals(part, StringComparison.OrdinalIgnoreCase))
                        {
                            foundNode = node;
                            // サブノードを読み込むために展開 (まだ読み込まれていない場合)
                            if (foundNode.Nodes.Count > 0 && foundNode.Nodes[0].Text == "Loading...")
                            {
                                foundNode.Expand(); // BeforeExpandが呼ばれ、サブノードがロードされる
                            }
                            currentNodes = foundNode.Nodes;
                            break;
                        }
                    }
                    if (foundNode == null) break; //途中で見つからなければ終了
                }
            }


            if (foundNode != null)
            {
                treeViewDirectories.SelectedNode = foundNode;
                foundNode.EnsureVisible(); // 選択ノードが表示されるようにスクロール
            }
        }

        private TreeNode FindNodeByPath(TreeNodeCollection nodes, string path)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag is DirectoryInfo dirInfo && dirInfo.FullName.Equals(path, StringComparison.OrdinalIgnoreCase))
                {
                    return node;
                }
                // 遅延読み込みのため、ノードが展開されていないとサブノードは見つからない。
                // このメソッドは主に親ノードを探すために使用。
                // TreeNode foundChild = FindNodeByPath(node.Nodes, path);
                // if (foundChild != null) return foundChild;
            }
            return null;
        }


        // --- イベントハンドラ (よく使うディレクトリ、ジャンプなど) ---
        private void buttonFav_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && int.TryParse(clickedButton.Text, out int favNumber))
            {
                if (_favoritePaths.TryGetValue(favNumber, out string path))
                {
                    if (Directory.Exists(path))
                    {
                        SelectNodeByPath(path);
                        if (checkBoxSelectAndClose.Checked)
                        {
                            SelectedDirectoryPath = path;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"登録されたパス '{path}' が見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // TODO: よく使うディレクトリ登録機能
                    MessageBox.Show($"よく使うディレクトリ {favNumber} は未登録です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonJump_Click(object sender, EventArgs e)
        {
            // TODO: ジャンプ機能（パス直接入力など）
            MessageBox.Show("ジャンプ機能は未実装です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            // TODO: ディレクトリ履歴機能
            MessageBox.Show("履歴機能は未実装です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSystem_Click(object sender, EventArgs e)
        {
            // TODO: システム関連機能（特殊フォルダへのアクセスなど）
            MessageBox.Show("システム機能は未実装です。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}