using System;
using System.Windows.Forms;

namespace AltCommander
{
    public partial class SortForm : Form
    {
        // プロパティを追加して、選択されたソート設定を保持・取得できるようにする
        // 例:
        // public SortKey SelectedSortKey { get; private set; }
        // public SortOrder SelectedSortOrder { get; private set; }
        // public FileAttributes AttributesToTop { get; private set; }
        // public bool GatherNewFiles { get; private set; }
        // public string TopExtensions { get; private set; }

        public SortForm()
        {
            InitializeComponent();

            // TODO: 必要に応じて、現在のソート設定をフォームに反映させる処理を追加
            // LoadCurrentSettings();
        }

        // OKボタンがクリックされたときの処理 (例)
        private void buttonOK_Click(object sender, EventArgs e)
        {
            // TODO: フォーム上の選択内容を読み取り、プロパティに設定する
            // SaveSelectedSettings();
            this.DialogResult = DialogResult.OK; // フォームを閉じる
        }

        // Cancelボタンがクリックされたときの処理は DialogResult = Cancel で自動的に行われる

        // 必要に応じて、設定の読み込み/保存メソッドを実装
        /*
        private void LoadCurrentSettings()
        {
            // 現在の設定に基づいて RadioButton や CheckBox の状態を設定
        }

        private void SaveSelectedSettings()
        {
            // 選択されている RadioButton や CheckBox から設定値を読み取り、プロパティに保存
        }
        */

        // 列挙型を定義してソートキーや順序を管理すると便利
        /*
        public enum SortKey
        {
            Name,
            Extension,
            Size,
            CreationTime,
            AccessTime,
            WriteTime,
            None
        }

        public enum SortOrder
        {
            Ascending,
            Descending
        }
        */
    }
}
