using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // DriveInfo, Directory, File などで使用

namespace AltCommander
{
    public partial class AltCommanderForm : Form
    {

        public AltCommanderForm()
        {
            InitializeComponent();
            InitializeListViewColumns();
            // フォームロード時に初期ドライブ情報を読み込む
            LoadInitialDriveInfo();
        }

        // --- イベントハンドラ ---

        // 上部パス入力テキストボックスでキーが押されたとき
        private async void pathTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enterキーの効果音を抑制
                string path = pathTextBox.Text;
                // 対応するListViewとドライブ情報ペインを渡す
                await LoadDirectoryAsync(topRightListView, pathTextBox, markedFilesLabel, topLeftTableLayoutPanel);
            }
        }

        // 下部パス入力テキストボックスでキーが押されたとき
        private async void pathTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enterキーの効果音を抑制
                string path = pathTextBox2.Text;
                // 対応するListViewとドライブ情報ペインを渡す
                await LoadDirectoryAsync(bottomRightListView, pathTextBox2, markedFilesLabel2, bottomLeftTableLayoutPanel);
            }
        }


        // 上部ツリー表示ボタンがクリックされたときのイベントハンドラ
        private void treeViewButton_Click(object sender, EventArgs e)
        {
            // TODO: ツリー表示機能の実装
            UpdateStatus("ツリー表示 (未実装)");
        }

        // 上部ソートボタンがクリックされたときのイベントハンドラ
        private void sortButton_Click(object sender, EventArgs e)
        {
            using (SortForm sortDialog = new SortForm())
            {
                if (sortDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // TODO: ソート適用
                    UpdateStatus("ソート設定が適用されました。");
                }
            }
        }

        // 下部ツリー表示ボタンがクリックされたときのイベントハンドラ
        private void treeViewButton2_Click(object sender, EventArgs e)
        {
            // TODO: ツリー表示機能の実装 (下部ペイン用)
            UpdateStatus("ツリー表示 (未実装)");
        }

        // 下部ソートボタンがクリックされたときのイベントハンドラ
        private void sortButton2_Click(object sender, EventArgs e)
        {
            using (SortForm sortDialog = new SortForm())
            {
                if (sortDialog.ShowDialog(this) == DialogResult.OK)
                {
                    // TODO: ソート適用
                    UpdateStatus("ソート設定が適用されました。");
                }
            }
        }

        // ListView のアイテム描画イベント (主に背景やフォーカス)
        private void listView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // オーナー描画が有効な場合のみ処理
            if (!e.Item.ListView.OwnerDraw) return;

            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // 選択時の背景色で塗りつぶす
                // FullRowSelect = false の場合、アイテムのテキスト部分のみハイライトするなどの調整が必要
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            }
            else
            {
                // 通常時の背景色で塗りつぶす
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
            }

            // フォーカス枠を描画 (必要であれば)
            if ((e.State & ListViewItemStates.Focused) != 0)
            {
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds);
            }
            // DrawDefault は false のまま
        }

        // ListView のサブアイテム描画イベント (ファイル名、サイズなどのテキスト描画)
        private void listView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // オーナー描画が有効な場合のみ処理
            if (!e.Item.ListView.OwnerDraw) return;

            ListView listView = sender as ListView;
            if (listView == null) return;

            // テキストの色を選択状態に応じて設定
            Color textColor = ((e.ItemState & ListViewItemStates.Selected) != 0) ? SystemColors.HighlightText : SystemColors.WindowText;
            // デフォルトのテキスト描画フラグ
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine;

            string textToDraw = "";
            // サブアイテムが存在するか確認
            if (e.ColumnIndex < e.Item.SubItems.Count)
            {
                textToDraw = e.Item.SubItems[e.ColumnIndex].Text; // Text プロパティではなく SubItems を使う
                                                                  // サイズ列(Index=1)なら右寄せ
                if (e.ColumnIndex == 1)
                {
                    flags = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine;
                }
            }

            // ★現時点ではカラム表示。カスタムレイアウト実装時にここを大幅に修正
            //   e.Bounds は Details View でのカラム矩形を示す
            TextRenderer.DrawText(e.Graphics, textToDraw, listView.Font, e.Bounds, textColor, flags);
        }


        // --- ヘルパーメソッド ---

        // ステータスバーのテキストを更新するメソッド
        private void UpdateStatus(string message)
        {
            // UIスレッド以外からの呼び出しに対応
            if (statusStrip1.InvokeRequired)
            {
                statusStrip1.Invoke(new Action(() => statusLabel1.Text = message));
            }
            else
            {
                statusLabel1.Text = message;
            }
        }

        // ListView のカラムを初期化するメソッド
        private void InitializeListViewColumns()
        {
            SetupListViewColumns(this.topRightListView);
            SetupListViewColumns(this.bottomRightListView);
        }

        // 指定された ListView に標準的なカラムを設定するヘルパーメソッド
        private void SetupListViewColumns(ListView listView)
        {
            listView.Columns.Clear();
            // オーナー描画でカラムヘッダ非表示なので、カラム追加は必須ではないが、
            // SubItems のインデックス管理や Details View の内部構造のために追加しておく
            listView.Columns.Add("名前", 250, HorizontalAlignment.Left); // Index 0
            listView.Columns.Add("サイズ", 100, HorizontalAlignment.Right); // Index 1
            listView.Columns.Add("更新日時", 150, HorizontalAlignment.Left); // Index 2
            listView.Columns.Add("種類", 100, HorizontalAlignment.Left); // Index 3
        }

        // フォームロード時に初期ドライブ情報を読み込む
        private void LoadInitialDriveInfo()
        {
            try
            {
                // Cドライブを上部に表示
                string initialPathTop = "C:\\";
                if (Directory.Exists(initialPathTop))
                {
                    // UIスレッドをブロックしないように非同期で開始 (結果は待たない)
                    _ = LoadDirectoryAsync(topRightListView, pathTextBox, markedFilesLabel, topLeftTableLayoutPanel);
                }
                else
                {
                    UpdateStatus("Cドライブが見つかりません。");
                    // ドライブ情報もクリア
                    UpdateDriveInfo(topLeftTableLayoutPanel, null);
                    pathTextBox.Text = "";
                    markedFilesLabel.Text = "Marks: (0/0)";

                }

                // 利用可能な別のドライブを下部に表示 (例: Dドライブ)
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                // Cドライブ以外で最初の準備完了 Fixed ドライブを探す
                string initialPathBottom = allDrives.FirstOrDefault(d => d.IsReady && d.DriveType == DriveType.Fixed && !d.Name.Equals(initialPathTop, StringComparison.OrdinalIgnoreCase))?.Name;

                if (!string.IsNullOrEmpty(initialPathBottom) && Directory.Exists(initialPathBottom))
                {
                    // UIスレッドをブロックしないように非同期で開始 (結果は待たない)
                    _ = LoadDirectoryAsync(bottomRightListView, pathTextBox2, markedFilesLabel2, bottomLeftTableLayoutPanel);
                }
                else // 適切な固定ドライブが見つからない場合、最初の準備完了ドライブを試す (Cドライブ以外)
                {
                    string fallbackPath = allDrives.FirstOrDefault(d => d.IsReady && !d.Name.Equals(initialPathTop, StringComparison.OrdinalIgnoreCase))?.Name;
                    if (!string.IsNullOrEmpty(fallbackPath))
                    {
                        _ = LoadDirectoryAsync(bottomRightListView, pathTextBox2, markedFilesLabel2, bottomLeftTableLayoutPanel);
                    }
                    else // それも見つからない場合
                    {
                        // 適切なドライブが見つからない場合の処理
                        pathTextBox2.Text = "";
                        UpdateDriveInfo(bottomLeftTableLayoutPanel, null); // ドライブ情報クリア
                        markedFilesLabel2.Text = "Marks: (0/0)";
                        UpdateStatus("下部ペインに表示する適切なドライブが見つかりません。");
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"初期ドライブ読み込みエラー: {ex.Message}");
            }
        }

        // 指定されたパスのディレクトリ内容を非同期でListViewに読み込む
        private async Task LoadDirectoryAsync(ListView targetListView, TextBox sourcePathTextBox, Label targetMarkedLabel, TableLayoutPanel drivePane)
        {
            string path = sourcePathTextBox.Text;
            if (string.IsNullOrWhiteSpace(path)) return;

            // パスの正規化と存在確認
            try
            {
                path = Path.GetFullPath(path); // フルパスに変換＆検証
                sourcePathTextBox.Text = path; // 正規化したパスを反映
                if (!Directory.Exists(path))
                {
                    UpdateStatus($"エラー: ディレクトリが見つかりません - {path}");
                    targetListView.Items.Clear();
                    UpdateDriveInfo(drivePane, path); // ドライブ情報だけは更新試行
                    targetMarkedLabel.Text = "Marks: (0/0)";
                    return;
                }
            }
            catch (Exception ex) // Path.GetFullPath で例外が発生した場合 (不正なパス文字など)
            {
                UpdateStatus($"エラー: 無効なパスです - {ex.Message}");
                targetListView.Items.Clear();
                UpdateDriveInfo(drivePane, null); // ドライブ情報もクリア
                targetMarkedLabel.Text = "Marks: (0/0)";
                return;
            }

            // 読み込み開始
            UpdateStatus($"読み込み中: {path}");
            targetListView.Enabled = false; // 読み込み中は操作不可に
            targetListView.BeginUpdate();   // 描画を一時停止
            targetListView.Items.Clear();   // 既存アイテムをクリア
            targetMarkedLabel.Text = "Marks: (0/0)"; // マーク情報クリア

            long totalSize = 0;
            int fileCount = 0;
            int totalCount = 0;
            List<ListViewItem> itemsToAdd = new List<ListViewItem>(); // UIスレッド外で作成するアイテムリスト

            try
            {
                // 親ディレクトリへの参照 (..) をリストの先頭に追加
                DirectoryInfo parentDir = Directory.GetParent(path);
                if (parentDir != null)
                {
                    ListViewItem parentItem = new ListViewItem(".."); // 表示名
                                                                      // SubItems は Columns に対応させる (オーナー描画でも内部的には利用)
                    parentItem.SubItems.AddRange(new string[] { "<DIR>", "", "親フォルダ" }); // サイズ、更新日時、種類
                    parentItem.Tag = parentDir; // DirectoryInfo オブジェクトを Tag に格納
                    itemsToAdd.Add(parentItem);
                    totalCount++;
                }

                // ファイルシステムエントリを別スレッドで取得・処理
                await Task.Run(() =>
                {
                    try
                    {
                        DirectoryInfo di = new DirectoryInfo(path);
                        // ディレクトリを先に列挙
                        foreach (var dir in di.EnumerateDirectories("*", SearchOption.TopDirectoryOnly))
                        {
                            ListViewItem item = new ListViewItem(dir.Name);
                            item.Tag = dir;
                            item.SubItems.AddRange(new string[] { "<DIR>", dir.LastWriteTime.ToString("yyyy/MM/dd HH:mm"), "フォルダ" });
                            itemsToAdd.Add(item);
                            totalCount++;
                        }
                        // 次にファイルを列挙
                        foreach (var file in di.EnumerateFiles("*", SearchOption.TopDirectoryOnly))
                        {
                            ListViewItem item = new ListViewItem(file.Name);
                            item.Tag = file;
                            item.SubItems.AddRange(new string[] { FormatBytes(file.Length), file.LastWriteTime.ToString("yyyy/MM/dd HH:mm"), GetFileTypeDescription(file.Extension) });
                            itemsToAdd.Add(item);
                            totalSize += file.Length;
                            fileCount++;
                            totalCount++;
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // Task内で発生したアクセス拒否はUIスレッドでステータス表示
                        targetListView.Invoke(new Action(() => {
                            UpdateStatus($"エラー: アクセスが拒否されました - {path}");
                        }));
                    }
                    catch (Exception ex)
                    {
                        // その他のTask内エラー
                        targetListView.Invoke(new Action(() => {
                            UpdateStatus($"エラー読み込み中: {ex.Message}");
                        }));
                    }
                }); // Task.Run の終わり

                // ドライブ情報を更新 (UIスレッドで実行)
                UpdateDriveInfo(drivePane, path);

                // UIスレッドで ListView にアイテムを一括追加
                if (itemsToAdd.Count > 0)
                {
                    targetListView.Items.AddRange(itemsToAdd.ToArray());
                }

                // 読み込み完了メッセージ
                UpdateStatus($"{totalCount} 個のアイテム ({fileCount} ファイル, {FormatBytes(totalSize)}) - {path}");

            }
            catch (UnauthorizedAccessException ex) // UIスレッドで発生する可能性のあるアクセス拒否 (GetParentなど)
            {
                UpdateStatus($"エラー: アクセスが拒否されました - {ex.Message}");
                UpdateDriveInfo(drivePane, path); // ドライブ情報は表示試行
            }
            catch (Exception ex) // その他のUIスレッドエラー
            {
                UpdateStatus($"エラー: {ex.Message}");
                UpdateDriveInfo(drivePane, path); // ドライブ情報は表示試行
            }
            finally
            {
                targetListView.EndUpdate();   // 描画を再開
                targetListView.Enabled = true;  // 操作可能に戻す
                // マーク情報を更新 (選択数は 0)
                targetMarkedLabel.Text = $"Marks: (0/{totalCount})";
            }
        }


        // 指定されたドライブ情報をペインに表示するメソッド
        private void UpdateDriveInfo(TableLayoutPanel drivePane, string currentPath)
        {
            // TableLayoutPanel 内のコントロールを取得 (名前で検索)
            Label infoLabel = drivePane.Controls.Find("driveInfoLabel", true).FirstOrDefault() as Label ??
                            drivePane.Controls.Find("driveInfoLabel2", true).FirstOrDefault() as Label;
            Label freeLabel = drivePane.Controls.Find("freeSpaceLabel", true).FirstOrDefault() as Label ??
                            drivePane.Controls.Find("freeSpaceLabel2", true).FirstOrDefault() as Label;

            if (infoLabel == null || freeLabel == null) return; // 必要なラベルが見つからない

            string driveLetter = null;
            if (!string.IsNullOrEmpty(currentPath))
            {
                try
                {
                    // パスからルート（ドライブレター）を取得
                    driveLetter = Path.GetPathRoot(currentPath);
                }
                catch { /* 不正なパスの場合など */ }
            }

            if (string.IsNullOrEmpty(driveLetter))
            {
                // ドライブが特定できない場合
                infoLabel.Text = "Drive:";
                freeLabel.Text = "Free:";
                return;
            }

            try
            {
                DriveInfo drive = new DriveInfo(driveLetter);
                if (drive.IsReady)
                {
                    // ドライブ名とボリュームラベルを表示
                    infoLabel.Text = $"{drive.Name.TrimEnd('\\')} {drive.VolumeLabel}";
                    // 空き容量と総容量を表示
                    freeLabel.Text = $"Free: {FormatBytes(drive.AvailableFreeSpace)} / {FormatBytes(drive.TotalSize)}";
                }
                else
                {
                    // ドライブ準備未完了の場合
                    infoLabel.Text = $"{drive.Name.TrimEnd('\\')} (準備未完了)";
                    freeLabel.Text = "Free: -";
                }
            }
            catch (Exception ex)
            {
                // ドライブ情報の取得でエラーが発生した場合
                infoLabel.Text = "Drive: エラー";
                freeLabel.Text = "Free: エラー";
                UpdateStatus($"ドライブ情報更新エラー ({driveLetter}): {ex.Message}");
            }
        }


        // バイト数を適切な単位 (B, KB, MB, GB) にフォーマットするメソッド
        private string FormatBytes(long bytes)
        {
            if (bytes < 0) return "N/A"; // サイズが負の場合は無効
            if (bytes == 0) return "0 B";

            string[] suffix = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            int i = 0;
            decimal number = bytes; // decimal を使用して精度を維持

            // 設定でB単位表示が選択されている場合 (未実装)
            // if (Properties.Settings.Default.DisplayUnit == "B") return $"{bytes} B";

            while (Math.Round(number / 1024) >= 1 && i < suffix.Length - 1)
            {
                number /= 1024;
                i++;
            }
            // 小数点以下1桁まで表示 (必要に応じて調整)
            return string.Format("{0:0.#} {1}", number, suffix[i]);
        }

        // 拡張子からファイルの種類を取得する簡単な例
        private string GetFileTypeDescription(string extension)
        {
            // より堅牢にするには、システムの関連付け情報を参照する方が良い
            switch (extension.ToLower())
            {
                case ".txt": return "テキスト ドキュメント";
                case ".jpg": case ".jpeg": return "JPEG 画像";
                case ".png": return "PNG 画像";
                case ".gif": return "GIF 画像";
                case ".bmp": return "ビットマップ画像";
                case ".pdf": return "PDF ドキュメント";
                case ".doc": case ".docx": return "Microsoft Word 文書";
                case ".xls": case ".xlsx": return "Microsoft Excel シート";
                case ".ppt": case ".pptx": return "Microsoft PowerPoint プレゼンテーション";
                case ".zip": return "圧縮 (zip) フォルダ";
                case ".exe": return "アプリケーション";
                case ".dll": return "アプリケーション拡張";
                case "": return "ファイル"; // 拡張子なしの場合
                default:
                    return $"{extension.ToUpper().TrimStart('.')} ファイル";
            }
        }

        // TODO: ソート適用メソッド
        /*
        private void ApplySortSettings(ListView listView, SortForm.SortSettings settings)
        {
             // ListViewItemComparer を使ってソートを実行
             // listView.ListViewItemSorter = new ListViewItemComparer(settings);
             // listView.Sort();
        }
        */

    } // AltCommanderForm クラスの終わり
} // AltCommander 名前空間の終わり

